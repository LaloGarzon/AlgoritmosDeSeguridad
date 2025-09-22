using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDeSeguridad.Algoritmos
{
    public static class Asimetrico
    {
        public static string EncriptarAsimetrico(
            string textoPlano,
            out string llavePublicaXml,
            string rutaLlavesPrivadas = "llaves.xml")
        {
            try
            {
                RSACryptoServiceProvider algRSA = new RSACryptoServiceProvider(2048);

                // Exportar llave pública
                llavePublicaXml = algRSA.ToXmlString(false);

                // Guardar llave privada en archivo
                string llavesPrivadas = algRSA.ToXmlString(true);
                File.WriteAllText(rutaLlavesPrivadas, llavesPrivadas);

                // Encriptar texto
                byte[] datos = Encoding.UTF8.GetBytes(textoPlano);
                byte[] resultado = algRSA.Encrypt(datos, false);

                return Convert.ToBase64String(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al encriptar asimétricamente: " + ex.Message);
            }
        }

        public static string DesencriptarAsimetrico(
            string textoCifradoBase64,
            string rutaLlavesPrivadas = "llaves.xml")
        {
            try
            {
                RSACryptoServiceProvider algRSA = new RSACryptoServiceProvider(2048);

                // Leer llave privada desde archivo
                string llavesPrivadas = File.ReadAllText(rutaLlavesPrivadas);
                algRSA.FromXmlString(llavesPrivadas);

                // Desencriptar texto
                byte[] datos = Convert.FromBase64String(textoCifradoBase64);
                byte[] resultado = algRSA.Decrypt(datos, false);

                return Encoding.UTF8.GetString(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al desencriptar asimétricamente: " + ex.Message);
            }
        }


    }
}
