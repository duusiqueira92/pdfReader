﻿namespace leitorPDF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.menuGeral = new System.Windows.Forms.MenuStrip();
            this.menuGeralFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeralOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeralPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeralClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.menuGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 24);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(425, 358);
            this.axAcroPDF1.TabIndex = 0;
            this.axAcroPDF1.OnError += new System.EventHandler(this.axAcroPDF1_OnError);
            // 
            // menuGeral
            // 
            this.menuGeral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGeralFile});
            this.menuGeral.Location = new System.Drawing.Point(0, 0);
            this.menuGeral.Name = "menuGeral";
            this.menuGeral.Size = new System.Drawing.Size(425, 24);
            this.menuGeral.TabIndex = 1;
            this.menuGeral.Text = "menuGeral";
            // 
            // menuGeralFile
            // 
            this.menuGeralFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGeralOpen,
            this.menuGeralPrint,
            this.menuGeralClose});
            this.menuGeralFile.Name = "menuGeralFile";
            this.menuGeralFile.Size = new System.Drawing.Size(37, 20);
            this.menuGeralFile.Text = "&File";
            // 
            // menuGeralOpen
            // 
            this.menuGeralOpen.Name = "menuGeralOpen";
            this.menuGeralOpen.Size = new System.Drawing.Size(152, 22);
            this.menuGeralOpen.Text = "&Open";
            this.menuGeralOpen.Click += new System.EventHandler(this.menuGeralOpen_Click);
            // 
            // menuGeralPrint
            // 
            this.menuGeralPrint.Name = "menuGeralPrint";
            this.menuGeralPrint.Size = new System.Drawing.Size(152, 22);
            this.menuGeralPrint.Text = "&Print";
            this.menuGeralPrint.Click += new System.EventHandler(this.menuGeralPrint_Click);
            // 
            // menuGeralClose
            // 
            this.menuGeralClose.Name = "menuGeralClose";
            this.menuGeralClose.Size = new System.Drawing.Size(152, 22);
            this.menuGeralClose.Text = "&Close";
            this.menuGeralClose.Click += new System.EventHandler(this.menuGeralClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 382);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.menuGeral);
            this.MainMenuStrip = this.menuGeral;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario para PDF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.menuGeral.ResumeLayout(false);
            this.menuGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.MenuStrip menuGeral;
        private System.Windows.Forms.ToolStripMenuItem menuGeralFile;
        private System.Windows.Forms.ToolStripMenuItem menuGeralOpen;
        private System.Windows.Forms.ToolStripMenuItem menuGeralPrint;
        private System.Windows.Forms.ToolStripMenuItem menuGeralClose;
    }
}

