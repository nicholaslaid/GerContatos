namespace GerContatos
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEdit = new Button();
            btnCancel = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            txtTelefone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnOpen = new Button();
            pbImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(482, 361);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 34);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(203, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(203, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(203, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(203, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(203, 234);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(150, 31);
            txtTelefone.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 60);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 6;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 120);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 7;
            label2.Text = "nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 174);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 8;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 237);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 9;
            label4.Text = "telefone";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(556, 247);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(112, 34);
            btnOpen.TabIndex = 10;
            btnOpen.Text = "Abrir";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(498, 38);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(230, 190);
            pbImage.TabIndex = 11;
            pbImage.TabStop = false;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbImage);
            Controls.Add(btnOpen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Name = "FormAdd";
            Text = "Add";
            Load += Add_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnCancel;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtId;
        private TextBox txtTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnOpen;
        private PictureBox pbImage;
    }
}