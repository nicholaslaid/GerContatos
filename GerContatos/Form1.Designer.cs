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
            btnOpen = new Button();
            pbImage = new PictureBox();
            dataGridView1 = new DataGridView();
            imageBmp = new DataGridViewImageColumn();
            Imagem = new DataGridViewTextBoxColumn();
            Identificador = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Deletar = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt1 = new TextBox();
            txt3 = new TextBox();
            txt2 = new TextBox();
            label4 = new Label();
            txt4 = new TextBox();
            id = new DataGridViewTextBoxColumn();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(107, 262);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(111, 53);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Abrir";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(44, 12);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(263, 225);
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            pbImage.Click += pbImage_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { imageBmp, Imagem, Identificador, name, Telefone, Email, Editar, Deletar });
            dataGridView1.Location = new Point(348, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(964, 335);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // imageBmp
            // 
            imageBmp.DataPropertyName = "imageBmp";
            imageBmp.HeaderText = "Imagem";
            imageBmp.MinimumWidth = 8;
            imageBmp.Name = "imageBmp";
            imageBmp.ReadOnly = true;
            imageBmp.Width = 150;
            // 
            // Imagem
            // 
            Imagem.DataPropertyName = "image";
            Imagem.HeaderText = "Imagem";
            Imagem.MinimumWidth = 8;
            Imagem.Name = "Imagem";
            Imagem.ReadOnly = true;
            Imagem.Visible = false;
            Imagem.Width = 150;
            // 
            // Identificador
            // 
            Identificador.DataPropertyName = "id";
            Identificador.HeaderText = "Identificador";
            Identificador.MinimumWidth = 8;
            Identificador.Name = "Identificador";
            Identificador.ReadOnly = true;
            Identificador.Visible = false;
            Identificador.Width = 150;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Nome";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 150;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 8;
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 150;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 150;
            // 
            // Deletar
            // 
            Deletar.HeaderText = "Deletar";
            Deletar.MinimumWidth = 8;
            Deletar.Name = "Deletar";
            Deletar.ReadOnly = true;
            Deletar.Text = "Deletar";
            Deletar.UseColumnTextForButtonValue = true;
            Deletar.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 430);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 6;
            label1.Text = "Phone";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 382);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 383);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 8;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(417, 378);
            txt1.Name = "txt1";
            txt1.Size = new Size(150, 31);
            txt1.TabIndex = 9;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt3
            // 
            txt3.Location = new Point(701, 382);
            txt3.Name = "txt3";
            txt3.Size = new Size(150, 31);
            txt3.TabIndex = 10;
            txt3.TextChanged += txt3_TextChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(417, 423);
            txt2.Name = "txt2";
            txt2.Size = new Size(150, 31);
            txt2.TabIndex = 11;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 430);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 13;
            label4.Text = "id";
            label4.Click += label4_Click;
            // 
            // txt4
            // 
            txt4.Enabled = false;
            txt4.Location = new Point(701, 427);
            txt4.Name = "txt4";
            txt4.Size = new Size(150, 31);
            txt4.TabIndex = 14;
            txt4.TextChanged += txt4_TextChanged;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Visible = false;
            id.Width = 150;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(947, 396);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 548);
            Controls.Add(btnAdicionar);
            Controls.Add(txt4);
            Controls.Add(label4);
            Controls.Add(txt2);
            Controls.Add(txt3);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pbImage);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExcluir;
        private Button btnOpen;
        private PictureBox pbImage;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt3;
        private TextBox txt2;
        private Label label4;
        private TextBox txt4;
        private DataGridViewTextBoxColumn id;
        private Button btnAdicionar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewImageColumn imageBmp;
        private DataGridViewTextBoxColumn Imagem;
        private DataGridViewTextBoxColumn Identificador;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Deletar;
    }
}