﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSAlib
{

    //Inizio Form
    public partial class RSA : Form
    {


        private static int nbit = 512;


        public RSA()
        {
            InitializeComponent();
        }

        private void radioButton512_CheckedChanged(object sender, EventArgs e)
        {
            nbit = 512;
        }

        private void radioButton1024_CheckedChanged(object sender, EventArgs e)
        {
            nbit = 1024;
        }



        private void radioButton2048_CheckedChanged(object sender, EventArgs e)
        {
            nbit = 2048;
        }

        private void radioButton4096_CheckedChanged(object sender, EventArgs e)
        {
            nbit = 4096;
        }


        //Genera una chiave pubblica e una privata
        private void Genera_Click(object sender, EventArgs e)
        {
            //Creo un nuovo Cryptographic Service Provider con due chiavi grandi nbit
            RSACryptoServiceProvider Csp = new RSACryptoServiceProvider(nbit);
            Chiave pubKey = new Chiavepub(nbit, Csp);
            Chiave privKey = new Chiavepriv(nbit, Csp);
            //scrivo le due chiavi in formato XML nelle textbox
            textpub.Text = pubKey.keytostring();
            textpriv.Text = privKey.keytostring();
        }


        private void Cifra_Click(object sender, EventArgs e)
        {
            // Verifico che la stringa iniziale sia più minore o uguale alla lunghezza massima e che le due textbox non siano vuote
            if (iniziale.Text.Length <= (((nbit / 8) - 11) / 2) && textpub.Text != "" && iniziale.Text != "" )
            {
                //Creo un nuovo Csp
                RSACryptoServiceProvider Csp = new RSACryptoServiceProvider();
                //Assegno a pubKey la chiave nella textbox che contiene la chiave pubblica
                Chiave pubKey = new Chiavepub(textpub.Text);
                //importo la chiave pubblica
                Csp.ImportParameters(pubKey.GetKey());
                //Converto la stringa in bytes
                var bytesIniziale = System.Text.Encoding.Unicode.GetBytes(iniziale.Text);
                //cifro i bytes e converto il risultato in stringa
                cifrata.Text = Convert.ToBase64String(Csp.Encrypt(bytesIniziale, false));
            }
        }



        private void Decifra_Click(object sender, EventArgs e)
        {
            // Verifico che le due textbox non siano vuote
            if (textpriv.Text != "" && cifrata.Text != "")
            {
                //Creo un nuovo Csp
                RSACryptoServiceProvider Csp = new RSACryptoServiceProvider();
                //Assegno a privKey la chiave nella textbox che contiene la chiave privata
                Chiave privKey = new Chiavepriv(textpriv.Text);
                //importo la chiave privata
                Csp.ImportParameters(privKey.GetKey());
                //Converto la stringa in bytes
                var bytesCifrata = Convert.FromBase64String(cifrata.Text);
                //decifro i bytes e converto il risultato in stringa
                decifrata.Text = Encoding.Unicode.GetString(Csp.Decrypt(bytesCifrata, false));
            }

        }

        private void cifdec_Click(object sender, EventArgs e)
        {
                Cifra_Click(sender, e);
                Decifra_Click(sender, e);
        }
    }




    
}
