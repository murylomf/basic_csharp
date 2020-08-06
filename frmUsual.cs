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
    public partial class frmUsual : Form
    {
        public frmUsual()
        {
            InitializeComponent();
            lstProduto.Columns.Add("Nome", 300, HorizontalAlignment.Left);
            carregarList(lstProduto, "SELECT * FROM TBPRODUTO");


        }



        public void carregarList(ListView lst, string query)
        {
            clsConnect conexao = new clsConnect();
            conexao.conectar();

            lst.Items.Clear();

            MySqlCommand cmd = new MySqlCommand(query, conexao.objConexao);
            MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);

            while (dr.Read())
            {
                ListViewItem lista = new ListViewItem(dr[("NMPRODUTO")].ToString());
               
                lstProduto.Items.Add(lista);
            }
            dr.Close();
            conexao.desconectar();
        }

        public void desativar(int pId)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja desativar este Cliente?", "Confirma a Exclusao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iResposta.ToString() == "Yes")
            {
                clsConnect conexao = new clsConnect();
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("UPDATE TBPRODUTO SET STATUS = 'Inativo' WHERE IDPRODUTO=@ID", conexao.objConexao);
                cmd.Parameters.AddWithValue("@ID", pId);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();
            }
        }

        public void editar(int pId)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja editar este Cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iResposta.ToString() == "Yes")
            {
                clsConnect conexao = new clsConnect();
                conexao.conectar();
                MySqlCommand cmd = new MySqlCommand("UPDATE TBPRODUTO SET nmProduto = 'Inativo' WHERE IDPRODUTO=@ID", conexao.objConexao);
                cmd.Parameters.AddWithValue("@ID", pId);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();
            }
        }


        private void frmUsual_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            frmADD add = new frmADD();

            add.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnInative_Click(object sender, EventArgs e)
        {
            
        }
    }
}
