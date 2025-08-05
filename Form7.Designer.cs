namespace Projeto
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botSalvar = new Button();
            botEditar = new Button();
            botExcluir = new Button();
            botListar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botSalvar
            // 
            botSalvar.Location = new Point(30, 108);
            botSalvar.Margin = new Padding(4, 5, 4, 5);
            botSalvar.Name = "botSalvar";
            botSalvar.Size = new Size(107, 38);
            botSalvar.TabIndex = 0;
            botSalvar.Text = "Salvar";
            botSalvar.UseVisualStyleBackColor = true;
            botSalvar.Click += botSalvar_Click;
            // 
            // botEditar
            // 
            botEditar.Location = new Point(146, 108);
            botEditar.Margin = new Padding(4, 5, 4, 5);
            botEditar.Name = "botEditar";
            botEditar.Size = new Size(107, 38);
            botEditar.TabIndex = 1;
            botEditar.Text = "Editar";
            botEditar.UseVisualStyleBackColor = true;
            botEditar.Click += botEditar_Click;
            // 
            // botExcluir
            // 
            botExcluir.Location = new Point(261, 108);
            botExcluir.Margin = new Padding(4, 5, 4, 5);
            botExcluir.Name = "botExcluir";
            botExcluir.Size = new Size(107, 38);
            botExcluir.TabIndex = 2;
            botExcluir.Text = "Excluir";
            botExcluir.UseVisualStyleBackColor = true;
            botExcluir.Click += botExcluir_Click;
            // 
            // botListar
            // 
            botListar.Location = new Point(377, 108);
            botListar.Margin = new Padding(4, 5, 4, 5);
            botListar.Name = "botListar";
            botListar.Size = new Size(107, 38);
            botListar.TabIndex = 3;
            botListar.Text = "Listar";
            botListar.UseVisualStyleBackColor = true;
            botListar.Click += botListar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 40);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 40);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 193);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(503, 250);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 8;
            label2.Text = "Idade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 7);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 10;
            label3.Text = "Id (Para Editar):";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(328, 40);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 31);
            textBox3.TabIndex = 9;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(botListar);
            Controls.Add(botExcluir);
            Controls.Add(botEditar);
            Controls.Add(botSalvar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botSalvar;
        private Button botEditar;
        private Button botExcluir;
        private Button botListar;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
    }
}