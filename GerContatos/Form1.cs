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
            bool image = false;
            Contacts contacts = new Contacts();

            contacts.name = txt1.Text;
            contacts.email = txt2.Text;
            contacts.telefone = txt3.Text;

            if (!string.IsNullOrEmpty(openedImage))
            {
                FileInfo fileInfo = new FileInfo(openedImage);
                contacts.image = Guid.NewGuid().ToString() + fileInfo.Extension;
                bool response = contacts.SaveImageToFile(openedImage, Config.imageFolder, contacts.image);
                image = true;
            }

            bool responseAdd = contacts.Add(contacts, image);

            if (responseAdd)
            {
                LoadContatos();
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Contacts contacts = new Contacts();
                int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Identificador"].Value);

                if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
                {
                    Config.op = Operation.Edit;
                    Config.tempContact = contacts.Get(id);

                    FormAdd edit = new FormAdd();
                    edit.ShowDialog();

                }
                else if (e.ColumnIndex == dataGridView1.Columns["Deletar"].Index)
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
                contacts.telefone = txt3.Text;
                contacts.image = Guid.NewGuid().ToString() + fileInfo.Extension;



                bool response = contacts.Add(contacts, false);

                if (!response)
                    MessageBox.Show("Erro ao tentar gravar o produto");
                else
                    this.Close();

            }
            catch (Exception ex)
            { }
        }

        

        private void LoadContatos()
        {

            dataGridView1.AutoGenerateColumns = false;
            Contacts contacts = new Contacts();
            dataGridView1.DataSource = contacts.GetAll();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            {
                bool image = false;
                Contacts contacts = new Contacts();

                contacts.name = txt1.Text;
                contacts.email = txt2.Text;
                contacts.telefone = txt3.Text;

                if (!string.IsNullOrEmpty(openedImage))
                {
                    FileInfo fileInfo = new FileInfo(openedImage);
                    contacts.image = Guid.NewGuid().ToString() + fileInfo.Extension;
                    bool response = contacts.SaveImageToFile(openedImage, Config.imageFolder, contacts.image);
                    image = true;
                }

                bool responseAdd = contacts.Add(contacts, image);

                if (responseAdd)
                {
                    LoadContatos();
                }

            }
        }
    }
}