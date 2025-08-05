namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 childForm = new Form4();
            childForm.Show();
        }

        private void testeDosBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 childForm = new Form7();
            childForm.Show();
        }
    }
}
