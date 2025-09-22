using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDeSeguridad.Algoritmos
{
    public static class Hash
    {
        public static string GenerarHashSHA256(string textoEntrada)
        {
            try
            {
                using (SHA256Managed algSHA = new SHA256Managed())
                {
                    byte[] msg = Encoding.UTF8.GetBytes(textoEntrada);
                    byte[] resultado = algSHA.ComputeHash(msg);
                    return Convert.ToBase64String(resultado);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el hash: " + ex.Message);
            }

        }
    }
}