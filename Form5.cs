using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projeto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox14.PasswordChar = '•';
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCompleto = textBox1.Text;
            string cpf = textBox2.Text;
            string cargoEmpresa = textBox3.Text;
            string nacionalidade = textBox4.Text;
            string emailEmpresa = textBox12.Text;
            string telefoneEmpresa = maskedTextBox1.Text;
            string emailRepresentante = textBox7.Text;
            string telefoneRepresentante = maskedTextBox2.Text;
            string senha = textBox14.Text;
            string confirmarSenha = textBox8.Text;

            bool aceitouTermos1 = checkBox1.Checked;
            bool aceitouTermos2 = checkBox2.Checked;

            if (string.IsNullOrEmpty(nomeCompleto) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(cargoEmpresa) ||
                string.IsNullOrEmpty(nacionalidade) || string.IsNullOrEmpty(emailEmpresa) || string.IsNullOrEmpty(telefoneEmpresa) ||
                string.IsNullOrEmpty(emailRepresentante) || string.IsNullOrEmpty(telefoneRepresentante) || string.IsNullOrEmpty(senha) ||
                string.IsNullOrEmpty(confirmarSenha))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (!aceitouTermos1 || !aceitouTermos2)
            {
                MessageBox.Show("Aceite os termos!");
                return;
            }

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo PDF (*.pdf)|*.pdf",
                FileName = "Cadastro_Usuario.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        Document doc = new Document();
                        PdfWriter.GetInstance(doc, stream);
                        doc.Open();

                        doc.Add(new Paragraph("Cadastro de Usuário\n\n"));

                        PdfPTable tabela = new PdfPTable(2);
                        tabela.AddCell("Campo");
                        tabela.AddCell("Valor");

                        tabela.AddCell("Nome Completo"); tabela.AddCell(nomeCompleto);
                        tabela.AddCell("CPF"); tabela.AddCell(cpf);
                        tabela.AddCell("Cargo na Empresa"); tabela.AddCell(cargoEmpresa);
                        tabela.AddCell("Nacionalidade"); tabela.AddCell(nacionalidade);
                        tabela.AddCell("Email da Empresa"); tabela.AddCell(emailEmpresa);
                        tabela.AddCell("Telefone da Empresa"); tabela.AddCell(telefoneEmpresa);
                        tabela.AddCell("Email do Representante"); tabela.AddCell(emailRepresentante);
                        tabela.AddCell("Telefone do Representante"); tabela.AddCell(telefoneRepresentante);
                        tabela.AddCell("Senha"); tabela.AddCell(senha);

                        doc.Add(tabela);
                        doc.Close();
                    }

                    MessageBox.Show("PDF gerado com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar o PDF: {ex.Message}");
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
