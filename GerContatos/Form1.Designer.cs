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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt1 = new TextBox();
            txt3 = new TextBox();
            txt2 = new TextBox();
            label4 = new Label();
            txt4 = new TextBox();
            id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(75, 157);
            btnOpen.Margin = new Padding(2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(78, 32);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Abrir";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(31, 7);
            pbImage.Margin = new Padding(2);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(184, 135);
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            pbImage.Click += pbImage_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Email });
            dataGridView1.Location = new Point(237, 7);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(673, 201);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 258);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 6;
            label1.Text = "Phone";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 229);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 230);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(292, 227);
            txt1.Margin = new Padding(2);
            txt1.Name = "txt1";
            txt1.Size = new Size(106, 23);
            txt1.TabIndex = 9;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt3
            // 
            txt3.Location = new Point(491, 229);
            txt3.Margin = new Padding(2);
            txt3.Name = "txt3";
            txt3.Size = new Size(106, 23);
            txt3.TabIndex = 10;
            txt3.TextChanged += txt3_TextChanged;
            // 
            // txt2
            // 
            txt2.Location = new Point(292, 254);
            txt2.Margin = new Padding(2);
            txt2.Name = "txt2";
            txt2.Size = new Size(106, 23);
            txt2.TabIndex = 11;
            txt2.TextChanged += txt2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 258);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 13;
            label4.Text = "id";
            label4.Click += label4_Click;
            // 
            // txt4
            // 
            txt4.Enabled = false;
            txt4.Location = new Point(491, 256);
            txt4.Margin = new Padding(2);
            txt4.Name = "txt4";
            txt4.Size = new Size(106, 23);
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "Identificador";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 329);
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
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Email;
    }
}