using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Fr_Consultoria
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
        }

        public bool verifivarLogin(string objLogin, string objSenha)
        {
            clsConnect conexao = new clsConnect();
            conexao.conectar();

            string query = "SELECT USERNAME, PASSWORD FROM USER WHERE USERNAME=@LOGIN AND PASSWORD=@SENHA";

            MySqlCommand cmd = new MySqlCommand(query, conexao.objConexao);
            cmd.Parameters.AddWithValue("@LOGIN", objLogin.ToString());
            cmd.Parameters.AddWithValue("@SENHA", objSenha);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr["username"].ToString();
                dr["password"].ToString();
                dr.Close();
                conexao.desconectar();
                return true;
            }
            else
            {
                dr.Close();
                conexao.desconectar();
                return false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeePSW_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string name = txtLogin.Text;
            string psw = txtSenha.Text;


            bool verf = verifivarLogin(name, psw);

            if (verf == true)
            {
                MessageBox.Show("Salve");
                frmADM formADM = new frmADM();

                formADM.Show();
            }

            else
            {
                MessageBox.Show("Algo Errado");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
