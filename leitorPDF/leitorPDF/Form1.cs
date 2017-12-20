using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leitorPDF
{
    public partial class Form1 : Form
    {
        OpenFileDialog abrirPdf = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuGeralOpen_Click(object sender, EventArgs e)
        {
            abrirPdf.Filter = "Arquivos PDF *.pdf|*.pdf";
            abrirPdf.Title = "Somente Arquivos PDF";

            abrirPdf.ShowDialog();

            if(abrirPdf.FileName != "")
            {
                axAcroPDF1.LoadFile(abrirPdf.FileName);
            }
            else
            {
                return;
            }
        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }

        private void menuGeralPrint_Click(object sender, EventArgs e)
        {
            if (!axAcroPDF1.LoadFile(abrirPdf.FileName))
            {
                MessageBox.Show("Favor abrir um pdf");
            }else
            {
                axAcroPDF1.printWithDialog();
            }
        }

        private void menuGeralClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
