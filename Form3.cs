using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projeto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 childForm = new Form4();
            childForm.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeSocial = textBox1.Text;
            string cnpj = textBox2.Text;
            string ramoVendas = textBox3.Text;
            string rua = textBox7.Text;
            string bairro = textBox10.Text;
            string numero = textBox9.Text;
            string cidade = comboBox1.SelectedItem?.ToString();
            string estado = comboBox2.SelectedItem?.ToString();
            string complemento = textBox8.Text;

            if (string.IsNullOrEmpty(nomeSocial) || string.IsNullOrEmpty(cnpj) || string.IsNullOrEmpty(rua) ||
                string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(cidade) ||
                string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(ramoVendas))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo PDF (*.pdf)|*.pdf",
                FileName = "DadosEmpresa.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document();
                        PdfWriter.GetInstance(doc, stream);
                        doc.Open();

                        doc.Add(new Paragraph("Cadastro de Empresa\n\n"));

                        PdfPTable tabela = new PdfPTable(2);
                        tabela.AddCell("Campo");
                        tabela.AddCell("Valor");

                        tabela.AddCell("Nome Social");
                        tabela.AddCell(nomeSocial);

                        tabela.AddCell("CNPJ");
                        tabela.AddCell(cnpj);

                        tabela.AddCell("Ramo de Vendas");
                        tabela.AddCell(ramoVendas);

                        tabela.AddCell("Rua");
                        tabela.AddCell(rua);

                        tabela.AddCell("Bairro");
                        tabela.AddCell(bairro);

                        tabela.AddCell("Número");
                        tabela.AddCell(numero);

                        tabela.AddCell("Cidade");
                        tabela.AddCell(cidade);

                        tabela.AddCell("Estado");
                        tabela.AddCell(estado);

                        tabela.AddCell("Complemento");
                        tabela.AddCell(complemento);

                        doc.Add(tabela);
                        doc.Close();
                    }

                    MessageBox.Show("PDF com os dados gerado com sucesso!");

                    Form5 childForm = new Form5();
                    childForm.Show();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar o PDF: {ex.Message}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
