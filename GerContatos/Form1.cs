using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace GerContatos
{
    public partial class Form1 : Form
    {
        string openedImage = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts();
            dataGridView1.DataSource = contacts.GetAll();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens (JPG, GiF, PNG, JFIF)|*.JPG;*.GIF;*.PNG;*.JFIF";

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                openedImage = openFileDialog.FileName;


                Bitmap bitmap = new Bitmap(openFileDialog.FileName);


                pbImage.Image = bitmap;
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Config.op == Operation.Add)
            {
                Add();
            }
            else if (Config.op == Operation.Edit)
            {
                Edit();
            }
            if (!string.IsNullOrEmpty(openedImage))
            {
                FileInfo fileInfo = new FileInfo(openedImage);

                Contacts contacts = new Contacts();
                contacts.name = "";
                contacts.image = Guid.NewGuid().ToString() + fileInfo.Extension;

                bool response = contacts.SaveImageToFile(openedImage, Config.imageFolder, contacts.image);

                if (response)
                {
                    bool responseAdd = contacts.Add(contacts);

                    if (responseAdd)
                    {
                        MessageBox.Show("Gravação feita com sucesso");
                    }
                }
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Contacts contacts = new Contacts();
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id"].Value);

                if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
                {
                    Config.op = Operation.Edit;
                    Config.tempContact = contacts.Get(id);

                    Form1 edit = new Form1();
                    edit.ShowDialog();

                }
                else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
                {
                    DialogResult dialogResult = MessageBox.Show(
                    "Comfirma Exclusão", "Excluir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool response = contacts.Delete(id);

                        if (response)
                        {
                            LoadContatos();

                        }
                        else
                        {
                            MessageBox.Show("Erro ao tentar excluir");
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void Add()
        {
            try
            {
                FileInfo fileInfo = new FileInfo(openedImage);
                Contacts contacts = new Contacts();

                contacts.id = Convert.ToInt32(txt4);
                contacts.name = txt1.Text;
                contacts.email = txt2.Text;
                contacts.telefone = Convert.ToInt32(txt3.Text);
                contacts.image = Guid.NewGuid().ToString() + fileInfo.Extension;



                bool response = contacts.Add(contacts);

                if (!response)
                    MessageBox.Show("Erro ao tentar gravar o produto");
                else
                    this.Close();

            }
            catch (Exception ex)
            { }
        }

        private void Edit()
        {
            FileInfo fileInfo = new FileInfo(openedImage);
            try
            {
                DialogResult dialog = MessageBox.Show("Confirma alteração?", "Alterar",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Contacts contacts = new Contacts();

                    contacts.id = Convert.ToInt32(txt4.Text);
                    contacts.telefone = Convert.ToInt32(txt3.Text);
                    contacts.name = txt1.Text;
                    contacts.email = txt2.Text;
                    contacts.image = Guid.NewGuid().ToString() + fileInfo.Extension;



                    bool response = contacts.Update(contacts);

                    if (!response)
                        MessageBox.Show("Erro ao tentar alterar");
                    else
                        this.Close();
                }
            }
            catch (Exception ex)
            { }
        }

        private void LoadContatos()
        {
            txt4.Text = Config.tempContact.email.ToString();
            txt1.Text = Config.tempContact.id.ToString();
            txt2.Text = Config.tempContact.telefone.ToString();
            txt3.Text = Config.tempContact.name.ToString();

            Contacts contacts = new Contacts();
            dataGridView1.DataSource = contacts.GetAll();

        }
    }
}