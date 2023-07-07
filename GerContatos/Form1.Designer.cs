namespace GerContatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEdit = new Button();
            btnExcluir = new Button();
            btnList = new Button();
            pbImage = new PictureBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            imagem = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(212, 335);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(141, 392);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.Location = new Point(72, 335);
            btnList.Name = "btnList";
            btnList.Size = new Size(112, 34);
            btnList.TabIndex = 2;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(61, 89);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(263, 174);
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, telefone, imagem, email });
            dataGridView1.Location = new Point(419, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(667, 225);
            dataGridView1.TabIndex = 4;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 150;
            // 
            // name
            // 
            name.HeaderText = "Nome";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 150;
            // 
            // telefone
            // 
            telefone.HeaderText = "Telefone";
            telefone.MinimumWidth = 8;
            telefone.Name = "telefone";
            telefone.ReadOnly = true;
            telefone.Width = 150;
            // 
            // imagem
            // 
            imagem.HeaderText = "Imagem";
            imagem.MinimumWidth = 8;
            imagem.Name = "imagem";
            imagem.ReadOnly = true;
            imagem.Width = 150;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pbImage);
            Controls.Add(btnList);
            Controls.Add(btnExcluir);
            Controls.Add(btnEdit);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEdit;
        private Button btnExcluir;
        private Button btnList;
        private PictureBox pbImage;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn imagem;
        private DataGridViewTextBoxColumn email;
    }
}