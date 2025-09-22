namespace AlgoritmosDeSeguridad.App
{
    partial class frmPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkBxLlave = new System.Windows.Forms.CheckBox();
            this.cbxAlgoritmoSimetrico = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIVSimetrico = new System.Windows.Forms.TextBox();
            this.btnTamanoLlaveSimetrico = new System.Windows.Forms.Button();
            this.btnEncriptarSimetrico = new System.Windows.Forms.Button();
            this.btnDesencriptarSimetrico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlano02Simetrico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCifradoSimetrico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlano01Simetrico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLlaveSimetrico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAsimetricoDesencriptar = new System.Windows.Forms.Button();
            this.txtAsimetricoDesencriptado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAsimetricoCifrado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAsimetricoEncriptar = new System.Windows.Forms.Button();
            this.txtAsimetricoPlano01 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLlaveAsimetrico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLongitud = new System.Windows.Forms.Button();
            this.btnGenerarHash = new System.Windows.Forms.Button();
            this.txtResultadoHASH = new System.Windows.Forms.TextBox();
            this.txtMsgHASH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 594);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkBxLlave);
            this.tabPage1.Controls.Add(this.cbxAlgoritmoSimetrico);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtIVSimetrico);
            this.tabPage1.Controls.Add(this.btnTamanoLlaveSimetrico);
            this.tabPage1.Controls.Add(this.btnEncriptarSimetrico);
            this.tabPage1.Controls.Add(this.btnDesencriptarSimetrico);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPlano02Simetrico);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtCifradoSimetrico);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPlano01Simetrico);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLlaveSimetrico);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(756, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simétricos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkBxLlave
            // 
            this.chkBxLlave.AutoSize = true;
            this.chkBxLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxLlave.Location = new System.Drawing.Point(408, 38);
            this.chkBxLlave.Margin = new System.Windows.Forms.Padding(4);
            this.chkBxLlave.Name = "chkBxLlave";
            this.chkBxLlave.Size = new System.Drawing.Size(264, 24);
            this.chkBxLlave.TabIndex = 16;
            this.chkBxLlave.Text = "Generar llave automaticamente";
            this.chkBxLlave.UseVisualStyleBackColor = true;
            // 
            // cbxAlgoritmoSimetrico
            // 
            this.cbxAlgoritmoSimetrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlgoritmoSimetrico.FormattingEnabled = true;
            this.cbxAlgoritmoSimetrico.Location = new System.Drawing.Point(227, 36);
            this.cbxAlgoritmoSimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAlgoritmoSimetrico.Name = "cbxAlgoritmoSimetrico";
            this.cbxAlgoritmoSimetrico.Size = new System.Drawing.Size(160, 28);
            this.cbxAlgoritmoSimetrico.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Algoritmo a Utilizar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vector IV:";
            // 
            // txtIVSimetrico
            // 
            this.txtIVSimetrico.BackColor = System.Drawing.Color.White;
            this.txtIVSimetrico.Location = new System.Drawing.Point(144, 133);
            this.txtIVSimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVSimetrico.Name = "txtIVSimetrico";
            this.txtIVSimetrico.Size = new System.Drawing.Size(532, 22);
            this.txtIVSimetrico.TabIndex = 12;
            // 
            // btnTamanoLlaveSimetrico
            // 
            this.btnTamanoLlaveSimetrico.Location = new System.Drawing.Point(685, 92);
            this.btnTamanoLlaveSimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamanoLlaveSimetrico.Name = "btnTamanoLlaveSimetrico";
            this.btnTamanoLlaveSimetrico.Size = new System.Drawing.Size(40, 28);
            this.btnTamanoLlaveSimetrico.TabIndex = 11;
            this.btnTamanoLlaveSimetrico.Text = "T";
            this.btnTamanoLlaveSimetrico.UseVisualStyleBackColor = true;
            // 
            // btnEncriptarSimetrico
            // 
            this.btnEncriptarSimetrico.Location = new System.Drawing.Point(469, 505);
            this.btnEncriptarSimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncriptarSimetrico.Name = "btnEncriptarSimetrico";
            this.btnEncriptarSimetrico.Size = new System.Drawing.Size(100, 28);
            this.btnEncriptarSimetrico.TabIndex = 10;
            this.btnEncriptarSimetrico.Text = "Encriptar";
            this.btnEncriptarSimetrico.UseVisualStyleBackColor = true;
            this.btnEncriptarSimetrico.Click += new System.EventHandler(this.btnEncriptarSimetrico_Click);
            // 
            // btnDesencriptarSimetrico
            // 
            this.btnDesencriptarSimetrico.Location = new System.Drawing.Point(577, 505);
            this.btnDesencriptarSimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesencriptarSimetrico.Name = "btnDesencriptarSimetrico";
            this.btnDesencriptarSimetrico.Size = new System.Drawing.Size(100, 28);
            this.btnDesencriptarSimetrico.TabIndex = 9;
            this.btnDesencriptarSimetrico.Text = "Desencriptar";
            this.btnDesencriptarSimetrico.UseVisualStyleBackColor = true;
            this.btnDesencriptarSimetrico.Click += new System.EventHandler(this.btnDesencriptarSimetrico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 400);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Texto Plano:";
            // 
            // txtPlano02Simetrico
            // 
            this.txtPlano02Simetrico.Location = new System.Drawing.Point(144, 396);
            this.txtPlano02Simetrico.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlano02Simetrico.Multiline = true;
            this.txtPlano02Simetrico.Name = "txtPlano02Simetrico";
            this.txtPlano02Simetrico.Size = new System.Drawing.Size(532, 80);
            this.txtPlano02Simetrico.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(645, 10);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtCifradoSimetrico
            // 
            this.txtCifradoSimetrico.Location = new System.Drawing.Point(144, 258);
            this.txtCifradoSimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCifradoSimetrico.Multiline = true;
            this.txtCifradoSimetrico.Name = "txtCifradoSimetrico";
            this.txtCifradoSimetrico.Size = new System.Drawing.Size(532, 80);
            this.txtCifradoSimetrico.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Texto Cifrado:";
            // 
            // txtPlano01Simetrico
            // 
            this.txtPlano01Simetrico.Location = new System.Drawing.Point(144, 177);
            this.txtPlano01Simetrico.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlano01Simetrico.Multiline = true;
            this.txtPlano01Simetrico.Name = "txtPlano01Simetrico";
            this.txtPlano01Simetrico.Size = new System.Drawing.Size(532, 73);
            this.txtPlano01Simetrico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto Plano:";
            // 
            // txtLlaveSimetrico
            // 
            this.txtLlaveSimetrico.Location = new System.Drawing.Point(144, 95);
            this.txtLlaveSimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.txtLlaveSimetrico.Name = "txtLlaveSimetrico";
            this.txtLlaveSimetrico.Size = new System.Drawing.Size(532, 22);
            this.txtLlaveSimetrico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llave:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAsimetricoDesencriptar);
            this.tabPage2.Controls.Add(this.txtAsimetricoDesencriptado);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtAsimetricoCifrado);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnAsimetricoEncriptar);
            this.tabPage2.Controls.Add(this.txtAsimetricoPlano01);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtLlaveAsimetrico);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(756, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asimétricos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAsimetricoDesencriptar
            // 
            this.btnAsimetricoDesencriptar.Location = new System.Drawing.Point(628, 455);
            this.btnAsimetricoDesencriptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsimetricoDesencriptar.Name = "btnAsimetricoDesencriptar";
            this.btnAsimetricoDesencriptar.Size = new System.Drawing.Size(100, 28);
            this.btnAsimetricoDesencriptar.TabIndex = 9;
            this.btnAsimetricoDesencriptar.Text = "Desencriptar";
            this.btnAsimetricoDesencriptar.UseVisualStyleBackColor = true;
            this.btnAsimetricoDesencriptar.Click += new System.EventHandler(this.btnAsimetricoDesencriptar_Click);
            // 
            // txtAsimetricoDesencriptado
            // 
            this.txtAsimetricoDesencriptado.Location = new System.Drawing.Point(27, 343);
            this.txtAsimetricoDesencriptado.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsimetricoDesencriptado.Multiline = true;
            this.txtAsimetricoDesencriptado.Name = "txtAsimetricoDesencriptado";
            this.txtAsimetricoDesencriptado.Size = new System.Drawing.Size(692, 82);
            this.txtAsimetricoDesencriptado.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Texto Desencriptado";
            // 
            // txtAsimetricoCifrado
            // 
            this.txtAsimetricoCifrado.Location = new System.Drawing.Point(27, 220);
            this.txtAsimetricoCifrado.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsimetricoCifrado.Multiline = true;
            this.txtAsimetricoCifrado.Name = "txtAsimetricoCifrado";
            this.txtAsimetricoCifrado.Size = new System.Drawing.Size(692, 82);
            this.txtAsimetricoCifrado.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Texto Cifrado:";
            // 
            // btnAsimetricoEncriptar
            // 
            this.btnAsimetricoEncriptar.Location = new System.Drawing.Point(520, 455);
            this.btnAsimetricoEncriptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsimetricoEncriptar.Name = "btnAsimetricoEncriptar";
            this.btnAsimetricoEncriptar.Size = new System.Drawing.Size(100, 28);
            this.btnAsimetricoEncriptar.TabIndex = 4;
            this.btnAsimetricoEncriptar.Text = "Encriptar";
            this.btnAsimetricoEncriptar.UseVisualStyleBackColor = true;
            this.btnAsimetricoEncriptar.Click += new System.EventHandler(this.btnAsimetricoEncriptar_Click);
            // 
            // txtAsimetricoPlano01
            // 
            this.txtAsimetricoPlano01.Location = new System.Drawing.Point(27, 97);
            this.txtAsimetricoPlano01.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsimetricoPlano01.Multiline = true;
            this.txtAsimetricoPlano01.Name = "txtAsimetricoPlano01";
            this.txtAsimetricoPlano01.Size = new System.Drawing.Size(692, 82);
            this.txtAsimetricoPlano01.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Texto a Encriptar:";
            // 
            // txtLlaveAsimetrico
            // 
            this.txtLlaveAsimetrico.Location = new System.Drawing.Point(80, 18);
            this.txtLlaveAsimetrico.Margin = new System.Windows.Forms.Padding(4);
            this.txtLlaveAsimetrico.Name = "txtLlaveAsimetrico";
            this.txtLlaveAsimetrico.Size = new System.Drawing.Size(640, 22);
            this.txtLlaveAsimetrico.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Llave:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnLongitud);
            this.tabPage3.Controls.Add(this.btnGenerarHash);
            this.tabPage3.Controls.Add(this.txtResultadoHASH);
            this.tabPage3.Controls.Add(this.txtMsgHASH);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(756, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HASH";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnLongitud
            // 
            this.btnLongitud.Location = new System.Drawing.Point(680, 363);
            this.btnLongitud.Margin = new System.Windows.Forms.Padding(4);
            this.btnLongitud.Name = "btnLongitud";
            this.btnLongitud.Size = new System.Drawing.Size(36, 28);
            this.btnLongitud.TabIndex = 5;
            this.btnLongitud.Text = "lngtd";
            this.btnLongitud.UseVisualStyleBackColor = true;
            // 
            // btnGenerarHash
            // 
            this.btnGenerarHash.Location = new System.Drawing.Point(584, 449);
            this.btnGenerarHash.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarHash.Name = "btnGenerarHash";
            this.btnGenerarHash.Size = new System.Drawing.Size(132, 28);
            this.btnGenerarHash.TabIndex = 4;
            this.btnGenerarHash.Text = "Generar HASH";
            this.btnGenerarHash.UseVisualStyleBackColor = true;
            this.btnGenerarHash.Click += new System.EventHandler(this.btnGenerarHash_Click);
            // 
            // txtResultadoHASH
            // 
            this.txtResultadoHASH.Location = new System.Drawing.Point(123, 367);
            this.txtResultadoHASH.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultadoHASH.Name = "txtResultadoHASH";
            this.txtResultadoHASH.Size = new System.Drawing.Size(548, 22);
            this.txtResultadoHASH.TabIndex = 3;
            // 
            // txtMsgHASH
            // 
            this.txtMsgHASH.Location = new System.Drawing.Point(41, 84);
            this.txtMsgHASH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsgHASH.Multiline = true;
            this.txtMsgHASH.Name = "txtMsgHASH";
            this.txtMsgHASH.Size = new System.Drawing.Size(673, 260);
            this.txtMsgHASH.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 370);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Resultado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Texto:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 622);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de Seguridad";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkBxLlave;
        private System.Windows.Forms.ComboBox cbxAlgoritmoSimetrico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIVSimetrico;
        private System.Windows.Forms.Button btnTamanoLlaveSimetrico;
        private System.Windows.Forms.Button btnEncriptarSimetrico;
        private System.Windows.Forms.Button btnDesencriptarSimetrico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlano02Simetrico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCifradoSimetrico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlano01Simetrico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLlaveSimetrico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAsimetricoDesencriptar;
        private System.Windows.Forms.TextBox txtAsimetricoDesencriptado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAsimetricoCifrado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAsimetricoEncriptar;
        private System.Windows.Forms.TextBox txtAsimetricoPlano01;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLlaveAsimetrico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLongitud;
        private System.Windows.Forms.Button btnGenerarHash;
        private System.Windows.Forms.TextBox txtResultadoHASH;
        private System.Windows.Forms.TextBox txtMsgHASH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}