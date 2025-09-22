using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosDeSeguridad.App
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Lista de Algoritmos Implemenatados
            cbxAlgoritmoSimetrico.Items.Add("DES");
            cbxAlgoritmoSimetrico.Items.Add("3DES");
            cbxAlgoritmoSimetrico.Items.Add("AES");
            cbxAlgoritmoSimetrico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAlgoritmoSimetrico.Text = cbxAlgoritmoSimetrico.Items[0].ToString();

            // La llave y vector IV deben definirse por defecto, esto ayuda a evitar errores.
            chkBxLlave.Checked = true;
        }

        private void btnEncriptarSimetrico_Click(object sender, EventArgs e)
        {
            string clave = string.Empty;
            string vectorIV = string.Empty;
            string cifrado = AlgoritmosDeSeguridad.Algoritmos.Simetrico.EncriptarSimetrico(txtPlano01Simetrico.Text, cbxAlgoritmoSimetrico.Text, out clave, out vectorIV);

            txtCifradoSimetrico.Text = cifrado;
            txtLlaveSimetrico.Text = clave;
            txtIVSimetrico.Text = vectorIV;

        }

        private void btnDesencriptarSimetrico_Click(object sender, EventArgs e)
        {
            string clave = txtLlaveSimetrico.Text;
            string vectorIV = txtIVSimetrico.Text;
            string plano = AlgoritmosDeSeguridad.Algoritmos.Simetrico.DesencriptarSimetrico(txtCifradoSimetrico.Text, cbxAlgoritmoSimetrico.Text, clave, vectorIV);
            txtPlano02Simetrico.Text = plano;
        }

        private void btnAsimetricoEncriptar_Click(object sender, EventArgs e)
        {
            string llavePublica;
            string cifrado = AlgoritmosDeSeguridad.Algoritmos.Asimetrico.EncriptarAsimetrico(txtAsimetricoPlano01.Text, out llavePublica);
            txtAsimetricoCifrado.Text = cifrado;
            txtLlaveAsimetrico.Text= llavePublica;
        }

        private void btnAsimetricoDesencriptar_Click(object sender, EventArgs e)
        {
            string descifrado = AlgoritmosDeSeguridad.Algoritmos.Asimetrico.DesencriptarAsimetrico(txtAsimetricoCifrado.Text);
            txtAsimetricoDesencriptado.Text = descifrado;
        }

        private void btnGenerarHash_Click(object sender, EventArgs e)
        {
            string hash = AlgoritmosDeSeguridad.Algoritmos.Hash.GenerarHashSHA256(txtMsgHASH.Text);
            txtResultadoHASH.Text = hash;
        }

        private void btnLongitudHash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El resultado de aplicar HASH al texto ingresado, genero una longitud de " + txtResultadoHASH.Text.Length + ".", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
