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
                DateTime datamysqlFormat = Convert.ToDateTime(txtData.Text);
                string dataFormatada = datamysqlFormat.ToString("yyyy-MM-dd");
                string curso = txtCurso.Text;
                string telefone = txtTelefone.Text;

                string conexaoBanco = "Server=locallost; Database=cadastroAlunos; Uid=root; Pwd='';";
                MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                conexao.Open();


            }
            catch
            {

            }
        }
    }
}
