using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //NUEVA NOTA//
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        //BTN DE EXIT//
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //BTN OPEN//
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.Title = "Open a file...";
            if (ofd.ShowDialog() == DialogResult.OK);
            {
               System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        //BTN DE GUARDADO//
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Files (.txt)|*.txt";
            svf.Title = "Save file...";
            if (svf.ShowDialog() == DialogResult.OK);
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.Write(richTextBox1.Text);   
                sw.Close();
            }
        }
        //DESHACER TEXTO//
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //BTN CORTAR TEXTO//
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //BTN DE COPIA//
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //BTN DE REHACER//
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();   
        }
        //BTN DE PEGADO//
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //BTN DE SELECCIONAR TODO//
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
