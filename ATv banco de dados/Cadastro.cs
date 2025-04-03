using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATv_banco_de_dados
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void btCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                DateTime datamysqlFormat = Convert.ToDateTime(txtDataNascimento.Text);
                string dataFormatada = datamysqlFormat.ToString("yyyy-MM-dd");
                string curso = txtCurso.Text;
                string telefone = txtTelefone.Text;

                string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; Pwd='';";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                conexao.Open();

                string insert = "insert into alunos (nome, nascimento, curso, telefone) values (@nome, @nascimento, @curso, @telefone)";
                MySqlCommand comandoSql = new MySqlCommand(insert, conexao);

                comandoSql.Parameters.AddWithValue("@nome", nome);
                comandoSql.Parameters.AddWithValue("@nascimento", dataFormatada);
                comandoSql.Parameters.AddWithValue("@curso", curso);
                comandoSql.Parameters.AddWithValue("@telefone", telefone);

                int registro = Convert.ToInt32(comandoSql.ExecuteNonQuery());
                if (registro > 0)
                {
                    MessageBox.Show("Cadastro realizado!");
                }
                else
                {
                    MessageBox.Show("Preencha os campos!");
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btListar_Click(object sender, EventArgs e)
        {
            string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; Pwd='';";
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);
            conexao.Open();

            string select = "select * from alunos";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(select, conexao);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvExibicao.DataSource = dataTable;
            dgvExibicao.AutoResizeColumns();

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string nasc = txtDataNascimento.Text;
                DateTime datamysqlFormat = Convert.ToDateTime(nasc);
                string dataFormatada = datamysqlFormat.ToString("yyyy-MM-dd");
                string curso = txtCurso.Text;
                string telefone = txtTelefone.Text;

                string conexaoBanco = "Server=localhost; Database=cadastroAlunos; Uid=root; Pwd='';";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                conexao.Open();

                txtNome.Text = " ";
                txtDataNascimento.Text = " ";
                txtCurso.Text = " ";
                txtTelefone.Text = " ";

                int idAluno = Convert.ToInt32(dgvExibicao.CurrentRow.Cells[0].Value.ToString());

                string update = "UPTADE alunos SET nome=@nome, nascimento=@nascimento, telefone=@telefone, curso=@curso WHERE id_aluno = @id";
                MySqlCommand comandoSql = new MySqlCommand(update, conexao);

                comandoSql.Parameters.AddWithValue("@nome", nome);
                comandoSql.Parameters.AddWithValue("@nascimento", dataFormatada);
                comandoSql.Parameters.AddWithValue("@curso", curso);
                comandoSql.Parameters.AddWithValue("@telefone", telefone);
                comandoSql.Parameters.AddWithValue("@id", idAluno);

                int mudanca = Convert.ToInt32(comandoSql.ExecuteNonQuery());
                if (mudanca > 0)
                {
                    MessageBox.Show("Alterações realizadas!");
                }
                else
                {
                    MessageBox.Show("Erro ao editar!");
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void dgvExibicao_CellContentClick(object sender, DataGridViewCellEventArgs e)
//{

       // }

        private void dgvExibicao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvExibicao.CurrentRow.Cells[1].Value.ToString();
            txtDataNascimento.Text = dgvExibicao.CurrentRow.Cells[2].Value.ToString();
            txtCurso.Text = dgvExibicao.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = dgvExibicao.CurrentRow.Cells[3].Value.ToString();
          

        }
    }
}