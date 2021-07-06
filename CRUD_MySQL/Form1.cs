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

namespace CRUD_MySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter dataAdapter;
        MySqlDataReader dataReader;
        string strSQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=root;");
                
                strSQL = "INSERT INTO CAD_CLIENTE (NOME, NUMERO) VALUES (@NOME, @NUMERO)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", );
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
