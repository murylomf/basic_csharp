using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fr_Consultoria
{
    public partial class frmADM : Form
    {
        public frmADM()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmADM_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fr_consultoriDataSet1.tbproduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbprodutoTableAdapter.Fill(this.fr_consultoriDataSet1.tbproduto);

        }
    }
}
