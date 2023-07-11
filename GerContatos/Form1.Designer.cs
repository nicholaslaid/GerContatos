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
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            telefone = new DataGridViewTextBoxColumn();
            imagem = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt1 = new TextBox();
            txt3 = new TextBox();
            txt2 = new TextBox();
            btnAdd = new Button();
            label4 = new Label();
            txt4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(370, 31);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Abrir";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(72, 31);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(263, 225);
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, telefone, imagem, email });
            dataGridView1.Location = new Point(663, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(665, 235);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 375);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 6;
            label1.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 300);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 455);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 8;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt1
            // 
            txt1.Location = new Point(185, 300);
            txt1.Name = "txt1";
            txt1.Size = new Size(150, 31);
            txt1.TabIndex = 9;
            // 
            // txt3
            // 
            txt3.Location = new Point(185, 452);
            txt3.Name = "txt3";
            txt3.Size = new Size(150, 31);
            txt3.TabIndex = 10;
            // 
            // txt2
            // 
            txt2.Location = new Point(185, 369);
            txt2.Name = "txt2";
            txt2.Size = new Size(150, 31);
            txt2.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 522);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 37);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 303);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 13;
            label4.Text = "id";
            // 
            // txt4
            // 
            txt4.Enabled = false;
            txt4.Location = new Point(457, 303);
            txt4.Name = "txt4";
            txt4.Size = new Size(162, 31);
            txt4.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 603);
            Controls.Add(txt4);
            Controls.Add(label4);
            Controls.Add(btnAdd);
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
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnExcluir;
        private Button btnOpen;
        private PictureBox pbImage;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn telefone;
        private DataGridViewTextBoxColumn imagem;
        private DataGridViewTextBoxColumn email;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt3;
        private TextBox txt2;
        private Button btnAdd;
        private Label label4;
        private TextBox txt4;
    }
}