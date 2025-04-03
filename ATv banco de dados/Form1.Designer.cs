namespace ATv_banco_de_dados
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
            btLogin = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btcCadastrar = new Button();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Location = new Point(184, 191);
            btLogin.Margin = new Padding(2, 2, 2, 2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(78, 20);
            btLogin.TabIndex = 0;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(166, 74);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(166, 132);
            lblSenha.Margin = new Padding(2, 0, 2, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(244, 74);
            txtUsuario.Margin = new Padding(2, 2, 2, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(106, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(244, 132);
            txtSenha.Margin = new Padding(2, 2, 2, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(106, 23);
            txtSenha.TabIndex = 4;
            // 
            // btcCadastrar
            // 
            btcCadastrar.Location = new Point(302, 191);
            btcCadastrar.Name = "btcCadastrar";
            btcCadastrar.Size = new Size(75, 23);
            btcCadastrar.TabIndex = 5;
            btcCadastrar.Text = "Cadastrar";
            btcCadastrar.UseVisualStyleBackColor = true;
            btcCadastrar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btcCadastrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(btLogin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btcCadastrar;
    }
}
