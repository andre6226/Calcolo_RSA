using System;
using System.Windows.Forms;

namespace RSAlib
{
    public partial class RSA : Form
    {
        // Salva
        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filepath != "")
            {
                System.IO.StreamWriter fs = new System.IO.StreamWriter(filepath);
                fs.WriteLine("Chiave Pubblica: " + textpub.Text.Replace("\n", "").Replace("\r", ""));
                fs.WriteLine("Chiave Privata: " + textpriv.Text.Replace("\n", "").Replace("\r", ""));
                fs.WriteLine("Stringa Iniziale: " + iniziale.Text);
                fs.WriteLine("Stringa Cifrata: " + cifrata.Text);
                fs.WriteLine("Stringa Decifrata: " + decifrata.Text);
                fs.Dispose();
                fs.Close();

            }
            else salvaConNomeToolStripMenuItem_Click(sender, e);

        }
        // Salva con nome
        private void salvaConNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salva un file";
            saveFileDialog1.Filter = "Text File | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter fs = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
                fs.WriteLine("Chiave Pubblica: " + textpub.Text.Replace("\n", "").Replace("\r", ""));
                fs.WriteLine("Chiave Privata: " + textpriv.Text.Replace("\n", "").Replace("\r", ""));
                fs.WriteLine("Stringa Iniziale: " + iniziale.Text);
                fs.WriteLine("Stringa Cifrata: " + cifrata.Text);
                fs.WriteLine("Stringa Decifrata: " + decifrata.Text);
                filepath = saveFileDialog1.FileName;
                Text = filepath;
                fs.Dispose();
                fs.Close();
            }
        }
        // Apri..
        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Apri un File";
            openFileDialog1.Filter = "Text File | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader fs = new System.IO.StreamReader(openFileDialog1.OpenFile());
                textpub.Text = fs.ReadLine().Replace("Chiave Pubblica: ", "");
                textpriv.Text = fs.ReadLine().Replace("Chiave Privata: ", ""); ;
                iniziale.Text = fs.ReadLine().Replace("Stringa Iniziale: ", ""); ;
                cifrata.Text = fs.ReadLine().Replace("Stringa Cifrata: ", ""); ;
                decifrata.Text = fs.ReadLine().Replace("Stringa Decifrata: ", ""); ;
                filepath = openFileDialog1.FileName;
                Text = filepath;
                fs.Dispose();
                fs.Close();
            }
        }


        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textpub.Text = "";
            textpriv.Text = "";
            iniziale.Text = "";
            cifrata.Text = "";
            decifrata.Text = "";
            filepath = "";
            Text = "Calcolo RSA";
        }

        private void nuovaFinestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new RSA();
            newform.Show();
        }

        private void informazioniSuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new Form2();
            newform.ShowDialog();
        }
    }
}
