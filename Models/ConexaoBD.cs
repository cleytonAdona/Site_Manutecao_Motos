using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Site_Manutecao_Motos.Models
{
public class ConexaoBD
    {
        private MySqlConnection IniciarConexao()
        {

            MySqlConnection conexao = null;

            try
            {
                conexao = new MySqlConnection("server=localhost;user=root;database=mtbd01");
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.Write("Falha na Conexão!");
            }

            return conexao;
        }
    }
}
