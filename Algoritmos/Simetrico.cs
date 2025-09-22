using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDeSeguridad.Algoritmos
{
    public static class Simetrico
    {

        public static string EncriptarSimetrico(
            string textoPlano,
            string nombreAlgoritmo,
            out string claveBase64,
            out string ivBase64,
            string claveBase64Entrada = null,
            string ivBase64Entrada = null,
            bool generarLlavesAutomaticamente = true)
        {
            try
            {
                SymmetricAlgorithm algoritmoSimetrico;

                // Crear algoritmo según selección
                switch (nombreAlgoritmo.ToUpper())
                {
                    case "DES":
                        algoritmoSimetrico = DES.Create();
                        break;
                    case "TRIPLEDES":
                    case "3DES":
                        algoritmoSimetrico = TripleDES.Create();
                        break;
                    case "AES":
                        algoritmoSimetrico = Aes.Create();
                        break;
                    default:
                        throw new ArgumentException("Algoritmo no válido. Usa DES, TripleDES o AES.");
                }

                // Configuración estándar
                algoritmoSimetrico.Mode = CipherMode.CBC;
                algoritmoSimetrico.Padding = PaddingMode.PKCS7;

                if (generarLlavesAutomaticamente)
                {
                    algoritmoSimetrico.GenerateKey();
                    algoritmoSimetrico.GenerateIV();
                }
                else
                {
                    // Ajustar clave
                    byte[] keyInput = Convert.FromBase64String(claveBase64Entrada ?? "");
                    int keySizeBytes = algoritmoSimetrico.KeySize / 8;
                    byte[] keyBytes = new byte[keySizeBytes];
                    Array.Copy(keyInput, keyBytes, Math.Min(keyInput.Length, keySizeBytes));
                    for (int i = keyInput.Length; i < keySizeBytes; i++)
                        keyBytes[i] = (byte)'Z';
                    algoritmoSimetrico.Key = keyBytes;

                    // Ajustar IV
                    byte[] ivInput = Convert.FromBase64String(ivBase64Entrada ?? "");
                    int ivSizeBytes = algoritmoSimetrico.BlockSize / 8;
                    byte[] ivBytes = new byte[ivSizeBytes];
                    Array.Copy(ivInput, ivBytes, Math.Min(ivInput.Length, ivSizeBytes));
                    for (int i = ivInput.Length; i < ivSizeBytes; i++)
                        ivBytes[i] = (byte)'Z';
                    algoritmoSimetrico.IV = ivBytes;
                }

                // Encriptar
                byte[] textoBytes = Encoding.UTF8.GetBytes(textoPlano);
                byte[] textoCifrado;

                using (ICryptoTransform encriptador = algoritmoSimetrico.CreateEncryptor())
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, encriptador, CryptoStreamMode.Write))
                {
                    cs.Write(textoBytes, 0, textoBytes.Length);
                    cs.FlushFinalBlock();
                    textoCifrado = ms.ToArray();
                }

                // Salidas
                claveBase64 = Convert.ToBase64String(algoritmoSimetrico.Key);
                ivBase64 = Convert.ToBase64String(algoritmoSimetrico.IV);
                return Convert.ToBase64String(textoCifrado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al encriptar: " + ex.Message);
            }
        }


        public static string DesencriptarSimetrico(
            string textoCifradoBase64,
            string nombreAlgoritmo,
            string claveBase64Entrada,
            string ivBase64Entrada)
        {
            try
            {
                SymmetricAlgorithm algoritmoSimetrico;

                // Crear algoritmo según selección
                switch (nombreAlgoritmo.ToUpper())
                {
                    case "DES":
                        algoritmoSimetrico = DES.Create();
                        break;
                    case "TRIPLEDES":
                    case "3DES":
                        algoritmoSimetrico = TripleDES.Create();
                        break;
                    case "AES":
                        algoritmoSimetrico = Aes.Create();
                        break;
                    default:
                        throw new ArgumentException("Algoritmo no válido. Usa DES, TripleDES o AES.");
                }

                // Configuración estándar
                algoritmoSimetrico.Mode = CipherMode.CBC;
                algoritmoSimetrico.Padding = PaddingMode.PKCS7;

                // Ajustar clave
                byte[] keyInput = Convert.FromBase64String(claveBase64Entrada ?? "");
                int keySizeBytes = algoritmoSimetrico.KeySize / 8;
                byte[] keyBytes = new byte[keySizeBytes];
                Array.Copy(keyInput, keyBytes, Math.Min(keyInput.Length, keySizeBytes));
                for (int i = keyInput.Length; i < keySizeBytes; i++)
                    keyBytes[i] = (byte)'Z';
                algoritmoSimetrico.Key = keyBytes;

                // Ajustar IV
                byte[] ivInput = Convert.FromBase64String(ivBase64Entrada ?? "");
                int ivSizeBytes = algoritmoSimetrico.BlockSize / 8;
                byte[] ivBytes = new byte[ivSizeBytes];
                Array.Copy(ivInput, ivBytes, Math.Min(ivInput.Length, ivSizeBytes));
                for (int i = ivInput.Length; i < ivSizeBytes; i++)
                    ivBytes[i] = (byte)'Z';
                algoritmoSimetrico.IV = ivBytes;

                // Desencriptar
                byte[] datosCifrados = Convert.FromBase64String(textoCifradoBase64);
                byte[] datosDesencriptados;

                using (ICryptoTransform desencriptador = algoritmoSimetrico.CreateDecryptor())
                using (MemoryStream ms = new MemoryStream(datosCifrados))
                using (CryptoStream cs = new CryptoStream(ms, desencriptador, CryptoStreamMode.Read))
                using (MemoryStream resultadoStream = new MemoryStream())
                {
                    cs.CopyTo(resultadoStream);
                    datosDesencriptados = resultadoStream.ToArray();
                }

                return Encoding.UTF8.GetString(datosDesencriptados);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al desencriptar: " + ex.Message);
            }

        }
    }
}