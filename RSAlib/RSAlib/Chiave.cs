using System.Security.Cryptography;

namespace RSAlib
{
    // Classi Chiave
    public class Chiave
    {
        protected RSAParameters Key;

        public void SetKey(RSAParameters key) => Key = key;

        public RSAParameters GetKey() => Key;

        //Converte Key in una stringa in formato XML
        public string keytostring()
        {
            var stringWriter = new System.IO.StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, Key);
            return stringWriter.ToString();
        }

    }

    public class Chiavepub : Chiave
    {
        //Creo una nuova chiave pubblica assegnando a Key il valore della chiave pubblica creata dal Csp
        public Chiavepub(int nbit, RSACryptoServiceProvider Csp)
        {
            Key = Csp.ExportParameters(false);
        }
        //Creo una nuova chiave pubblica assegnando a Key il valore di una chiave preesistente in formato stringa (XML)
        public Chiavepub(string keystring)
        {
            var sr = new System.IO.StringReader(keystring);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            Key = (RSAParameters)xs.Deserialize(sr);
        }

    }


    public class Chiavepriv : Chiave
    {
        //Creo una nuova chiave privata assegnando a Key il valore della chiave privata creata dal Csp
        public Chiavepriv(int nbit, RSACryptoServiceProvider Csp)
        {
            Key = Csp.ExportParameters(true);
        }
        //Creo una nuova chiave privata assegnando a Key il valore di una chiave preesistente in formato stringa (XML)
        public Chiavepriv(string keystring)
        {
            var sr = new System.IO.StringReader(keystring);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            Key = (RSAParameters)xs.Deserialize(sr);
        }

    }
}
