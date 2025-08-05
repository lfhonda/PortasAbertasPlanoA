namespace Projeto
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(503, 60);
            label1.Name = "label1";
            label1.Size = new Size(412, 90);
            label1.TabIndex = 1;
            label1.Text = "SOBRE NÓS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(443, 141);
            label2.Name = "label2";
            label2.Size = new Size(538, 344);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(621, 488);
            button1.Name = "button1";
            button1.Size = new Size(136, 53);
            button1.TabIndex = 3;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(993, 627);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Sobre";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}