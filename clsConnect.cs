using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Fr_Consultoria
{
    class clsConnect
    {

        public MySqlConnection objConexao = new MySqlConnection();

        public void conectar()
        {
            objConexao.ConnectionString = @"server=localhost;user id=root;database=fr_consultori;persistsecurityinfo=False";
            objConexao.Open();
        }

        public void desconectar()
        {
            objConexao.Close();
        }

    }
}
