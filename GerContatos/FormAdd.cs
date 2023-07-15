using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GerContatos
{
    public partial class FormAdd : Form
    {
        string openedImage = string.Empty;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {


            if (Config.op == Operation.Edit)
            {
                LoadContacts();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Config.op == Operation.Add)
            {
                Add();
            }
            else if (Config.op == Operation.Edit)
            {
                Edit();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add()
        {
            try
            {


                FileInfo fileInfo = new FileInfo(openedImage);
                Contacts contacts = new Contacts();

                contacts.id = Convert.ToInt32(txtId);
                contacts.name = txtNome.Text;
                contacts.email = txtEmail.Text;
                contacts.telefone = txtTelefone.Text;
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

        private void Edit()
        {
  
            try
            {
                DialogResult dialog = MessageBox.Show("Confirma alteração?", "Alterar",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    bool image = false;
                    Contacts contacts = new Contacts();

                    contacts.id = Convert.ToInt32(txtId.Text);
                    contacts.telefone = txtTelefone.Text;
                    contacts.name = txtNome.Text;
                    contacts.email = txtEmail.Text;

                    if (!string.IsNullOrEmpty(openedImage))
                    {
                        FileInfo fileInfo = new FileInfo(openedImage);
                        contacts.image = Guid.NewGuid().ToString() + fileInfo.Extension;
                        bool responseSave = contacts.SaveImageToFile(openedImage, Config.imageFolder, contacts.image);
                        image = true;
                    }


                    bool response = contacts.Update(contacts, image);

                    if (!response)
                        MessageBox.Show("Erro ao tentar alterar");
                    else
                        this.Close();
                }
            }
            catch (Exception ex)
            { }
        }

        private void LoadContacts()
        {
            txtId.Text = Config.tempContact.id.ToString();
            txtNome.Text = Config.tempContact.name.ToString();
            txtTelefone.Text = Config.tempContact.telefone.ToString();
            txtEmail.Text = Config.tempContact.email.ToString();

        }
        public bool SaveImageToFile(string sourcePath, string savePath, string name)
        {
            bool result = false;

            try
            {
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);


                }
                Bitmap bitmap = new Bitmap(sourcePath);
                bitmap.Save(Path.Combine(savePath, name));
                result = true;
            }
            catch (Exception ex)
            { }

            return result;
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
    }
}
