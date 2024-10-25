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
using WinFormsApp8.NovaPasta;

namespace WinFormsApp8
{
    public partial class CadastroAtualizacao : Form
    {
        private int? productId = null;
        Database db = new Database();

        public CadastroAtualizacao()
        {
            InitializeComponent();
        }

        private void CadastroAtualizacao_Load(int id, string nome, decimal preco)
        {
            productId = id;
            txtNome.Text = nome;
            txtPreco.Text = preco.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);

            db.OpenConnection();
            string query;

            if (productId == null) 
            {
                query = "INSERT INTO Produto (Nome, Preco) VALUES (@nome, @preco)";
            }
            else 
            {
                query = "UPDATE Produto SET Nome = @nome, Preco = @preco WHERE Id = @id";
            }

            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@preco", preco);

            if (productId != null)
            {
                cmd.Parameters.AddWithValue("@id", productId);
            }

            cmd.ExecuteNonQuery();
            db.CloseConnection();
            DialogResult = DialogResult.OK; 
        }
    }
}
    

