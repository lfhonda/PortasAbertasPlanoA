namespace Projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            testeDosBotõesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem, cadastroToolStripMenuItem, testeDosBotõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1093, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(75, 29);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(72, 29);
            cadastroToolStripMenuItem.Text = "Login";
            cadastroToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // testeDosBotõesToolStripMenuItem
            // 
            testeDosBotõesToolStripMenuItem.Name = "testeDosBotõesToolStripMenuItem";
            testeDosBotõesToolStripMenuItem.Size = new Size(162, 29);
            testeDosBotõesToolStripMenuItem.Text = "Teste dos Botões";
            testeDosBotõesToolStripMenuItem.Click += testeDosBotõesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1093, 727);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Tela Inicial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem testeDosBotõesToolStripMenuItem;
    }
}
