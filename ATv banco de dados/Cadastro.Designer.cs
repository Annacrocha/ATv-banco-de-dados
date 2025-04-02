
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
            txtData = new TextBox();
            txtCurso = new TextBox();
            txtTelefone = new TextBox();
            btCadastro = new Button();
            btListar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            btLimpar = new Button();
            dataGridView1 = new DataGridView();
            mtxbData = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(161, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(52, 101);
            lblData.Name = "lblData";
            lblData.Size = new Size(174, 25);
            lblData.TabIndex = 1;
            lblData.Text = "Data de nascimento:";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(164, 175);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(62, 25);
            lblCurso.TabIndex = 2;
            lblCurso.Text = "Curso:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(146, 250);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(81, 25);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(232, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 31);
            txtNome.TabIndex = 4;
            // 
            // txtData
            // 
            txtData.Location = new Point(232, 101);
            txtData.Name = "txtData";
            txtData.Size = new Size(335, 31);
            txtData.TabIndex = 5;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(232, 172);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(335, 31);
            txtCurso.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(232, 250);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(335, 31);
            txtTelefone.TabIndex = 7;
            // 
            // btCadastro
            // 
            btCadastro.Location = new Point(29, 329);
            btCadastro.Name = "btCadastro";
            btCadastro.Size = new Size(112, 34);
            btCadastro.TabIndex = 8;
            btCadastro.Text = "Cadastrar";
            btCadastro.UseVisualStyleBackColor = true;
            btCadastro.Click += btCadastro_Click;
            // 
            // btListar
            // 
            btListar.Location = new Point(186, 329);
            btListar.Name = "btListar";
            btListar.Size = new Size(112, 34);
            btListar.TabIndex = 9;
            btListar.Text = "Listar";
            btListar.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            btEditar.Location = new Point(346, 329);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(112, 34);
            btEditar.TabIndex = 10;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            btExcluir.Location = new Point(498, 329);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 34);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(652, 329);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(112, 34);
            btLimpar.TabIndex = 12;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 369);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(735, 203);
            dataGridView1.TabIndex = 13;
            // 
            // mtxbData
            // 
            mtxbData.Location = new Point(232, 101);
            mtxbData.Name = "mtxbData";
            mtxbData.Size = new Size(268, 31);
            mtxbData.TabIndex = 14;
            mtxbData.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(mtxbData);
            Controls.Add(dataGridView1);
            Controls.Add(btLimpar);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btListar);
            Controls.Add(btCadastro);
            Controls.Add(txtTelefone);
            Controls.Add(txtCurso);
            Controls.Add(txtData);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblCurso);
            Controls.Add(lblData);
            Controls.Add(lblNome);
            Name = "Cadastro";
            Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtCurso;
        private TextBox txtTelefone;
        private Button btCadastro;
        private Button btListar;
        private Button btEditar;
        private Button btExcluir;
        private Button btLimpar;
        private DataGridView dataGridView1;
        private MaskedTextBox mtxbData;
    }
}