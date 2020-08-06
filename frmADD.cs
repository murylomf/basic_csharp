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

namespace Fr_Consultoria
{
    public partial class frmADD : Form
    {
        public frmADD()
        {
            InitializeComponent();
        }

        public  void cadastrarCliente(string pNome, int pcategoria)
        {
            clsConnect conexao = new clsConnect();
            conexao.conectar();
            MySqlCommand cmd;
            try
            {
                cmd = new MySqlCommand("INSERT INTO tbproduto (nmProduto, idCategoria) VALUES(PNOME,pcategoria);", conexao.objConexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PNOME", pNome);
                cmd.Parameters.AddWithValue("@pcategoria", Convert.ToInt32(pcategoria));
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrarCliente (txtName.Text, Convert.ToInt32(txtcategoria.Text));
        }
    }
}
