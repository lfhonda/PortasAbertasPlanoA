namespace Projeto
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            label17 = new Label();
            textBox8 = new TextBox();
            textBox14 = new TextBox();
            label13 = new Label();
            label20 = new Label();
            button1 = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(36, 100, 116);
            label17.Location = new Point(194, 277);
            label17.Name = "label17";
            label17.Size = new Size(138, 49);
            label17.TabIndex = 35;
            label17.Text = "Login:";
            // 
            // textBox8
            // 
            textBox8.Cursor = Cursors.IBeam;
            textBox8.Location = new Point(306, 365);
            textBox8.MaxLength = 200;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(162, 31);
            textBox8.TabIndex = 63;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox14
            // 
            textBox14.Cursor = Cursors.IBeam;
            textBox14.Location = new Point(46, 365);
            textBox14.MaxLength = 200;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(162, 31);
            textBox14.TabIndex = 62;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(357, 337);
            label13.Name = "label13";
            label13.Size = new Size(64, 25);
            label13.TabIndex = 61;
            label13.Text = "Senha:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(36, 337);
            label20.Name = "label20";
            label20.Size = new Size(190, 25);
            label20.TabIndex = 60;
            label20.Text = "CPF do Representante:";
            // 
            // button1
            // 
            button1.Location = new Point(205, 429);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 64;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 549);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 65;
            label1.Text = "Novo Aqui?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(259, 549);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(110, 25);
            linkLabel1.TabIndex = 66;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Se Cadastre!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 602);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(textBox14);
            Controls.Add(label13);
            Controls.Add(label20);
            Controls.Add(label17);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label17;
        private TextBox textBox8;
        private TextBox textBox14;
        private Label label13;
        private Label label20;
        private Button button1;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}