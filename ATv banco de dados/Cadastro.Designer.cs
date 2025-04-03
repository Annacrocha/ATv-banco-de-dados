
namespace ATv_banco_de_dados
{
    partial class Cadastro
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
            lblNome = new Label();
            lblData = new Label();
            lblCurso = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtCurso = new TextBox();
            txtTelefone = new TextBox();
            btCadastro = new Button();
            btListar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            btLimpar = new Button();
            dgvExibicao = new DataGridView();
            txtDataNascimento = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvExibicao).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(113, 25);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(82, 61);
            lblData.Margin = new Padding(2, 0, 2, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(74, 15);
            lblData.TabIndex = 1;
            lblData.Text = "Nascimento:";
            lblData.Click += lblData_Click;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(115, 105);
            lblCurso.Margin = new Padding(2, 0, 2, 0);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(41, 15);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "Curso:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(102, 150);
            lblTelefone.Margin = new Padding(2, 0, 2, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(162, 22);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(236, 23);
            txtNome.TabIndex = 4;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(162, 103);
            txtCurso.Margin = new Padding(2);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(236, 23);
            txtCurso.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(162, 150);
            txtTelefone.Margin = new Padding(2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(236, 23);
            txtTelefone.TabIndex = 7;
            // 
            // btCadastro
            // 
            btCadastro.Location = new Point(20, 197);
            btCadastro.Margin = new Padding(2);
            btCadastro.Name = "btCadastro";
            btCadastro.Size = new Size(78, 20);
            btCadastro.TabIndex = 8;
            btCadastro.Text = "Cadastrar";
            btCadastro.UseVisualStyleBackColor = true;
            btCadastro.Click += btCadastro_Click;
            // 
            // btListar
            // 
            btListar.Location = new Point(130, 197);
            btListar.Margin = new Padding(2);
            btListar.Name = "btListar";
            btListar.Size = new Size(78, 20);
            btListar.TabIndex = 9;
            btListar.Text = "Listar";
            btListar.UseVisualStyleBackColor = true;
            btListar.Click += btListar_Click;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(242, 197);
            btEditar.Margin = new Padding(2);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(78, 20);
            btEditar.TabIndex = 10;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            btEditar.Click += btEditar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(349, 197);
            btExcluir.Margin = new Padding(2);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(78, 20);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(456, 197);
            btLimpar.Margin = new Padding(2);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(78, 20);
            btLimpar.TabIndex = 12;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // dgvExibicao
            // 
            dgvExibicao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExibicao.Location = new Point(20, 227);
            dgvExibicao.Margin = new Padding(2);
            dgvExibicao.Name = "dgvExibicao";
            dgvExibicao.RowHeadersWidth = 62;
            dgvExibicao.Size = new Size(514, 152);
            dgvExibicao.TabIndex = 13;
            //dgvExibicao.CellContentClick += dgvExibicao_CellContentClick;
            dgvExibicao.CellDoubleClick += dgvExibicao_CellDoubleClick;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(162, 61);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(236, 23);
            txtDataNascimento.TabIndex = 14;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 399);
            Controls.Add(txtDataNascimento);
            Controls.Add(dgvExibicao);
            Controls.Add(btLimpar);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btListar);
            Controls.Add(btCadastro);
            Controls.Add(txtTelefone);
            Controls.Add(txtCurso);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblCurso);
            Controls.Add(lblData);
            Controls.Add(lblNome);
            Margin = new Padding(2);
            Name = "Cadastro";
            Text = "Cadastro de Alunos";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExibicao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvExibicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblData_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblNome;
        private Label lblData;
        private Label lblCurso;
        private Label lblTelefone;
        private TextBox txtNome;
        private TextBox txtData;

        public Cadastro(TextBox txtData)
        {
            this.txtData = txtData;
        }

        private TextBox txtCurso;
        private TextBox txtTelefone;
        private Button btCadastro;
        private Button btListar;
        private Button btEditar;
        private Button btExcluir;
        private Button btLimpar;
        private DataGridView dgvExibicao;
        private MaskedTextBox txtDataNascimento;
    }
}