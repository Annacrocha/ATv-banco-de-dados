using MySql.Data.MySqlClient;

namespace ATv_banco_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                if (usuario != "" && senha != "")
                {
                    string conexaoBanco = "Server=localhost; Database=sistemalogin; Uid=root; Pwd='';";
                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);
                    conexao.Open();

                    string consultarUsuario = "select * from usuarios where usuario = @usuario and senha = @senha ";
                    MySqlCommand comandoSql = new MySqlCommand(consultarUsuario, conexao);

                    comandoSql.Parameters.AddWithValue("@usuario", usuario);
                    comandoSql.Parameters.AddWithValue("@senha", senha);

                    int registro = Convert.ToInt32(comandoSql.ExecuteScalar());

                    if (registro > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                    } else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                    }
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Preencha os campos !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login" + ex.Message);
            }
        }

    }
}
