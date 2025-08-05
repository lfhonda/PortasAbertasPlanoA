using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Projeto
{
    public partial class Form7 : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ExemploBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Form7()
        {

        }

        private void botSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Pessoas (Nome, Idade) Values (@Nome, @Idade)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Idade", int.Parse(textBox2.Text));
                    cmd.ExecuteNonQuery();
                }
            }

            textBox1.Clear();
            textBox2.Clear();
            ListarDados();
        }

        private void botListar_Click(object sender, EventArgs e)
        {
            ListarDados();
        }

        private void ListarDados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Pessoas";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void botEditar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int id))
            {
                MessageBox.Show("ID inválido! Informe um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IdExiste(id))
            {
                MessageBox.Show("ID não encontrado! Verifique o número e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Pessoas SET Nome = @Nome, Idade = @Idade WHERE Id = @Id;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Idade", int.Parse(textBox2.Text));
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
    
            textBox3.Clear();
            ListarDados();
        }

        private bool IdExiste(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Pessoas WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void botExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Pessoas WHERE Id = @Id;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                ListarDados();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}