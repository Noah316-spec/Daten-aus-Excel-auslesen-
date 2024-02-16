namespace WPF_Anwendung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eingabetlg = new System.Windows.Forms.TextBox();
            this.titel = new System.Windows.Forms.Label();
            this.tlg1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timerwert = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telbl1 = new System.Windows.Forms.Label();
            this.eingabete = new System.Windows.Forms.TextBox();
            this.eingabete2 = new System.Windows.Forms.TextBox();
            this.trente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblbezsub = new System.Windows.Forms.Label();
            this.lblbezte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(343, 156);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(173, 31);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Start";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Noah Nassiri";
            // 
            // eingabetlg
            // 
            this.eingabetlg.Location = new System.Drawing.Point(173, 163);
            this.eingabetlg.Name = "eingabetlg";
            this.eingabetlg.Size = new System.Drawing.Size(160, 20);
            this.eingabetlg.TabIndex = 2;
            this.eingabetlg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(306, 12);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(410, 25);
            this.titel.TabIndex = 3;
            this.titel.Text = "Abfrage Telegramm Daten / TE Status";
            // 
            // tlg1
            // 
            this.tlg1.AutoSize = true;
            this.tlg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlg1.Location = new System.Drawing.Point(70, 164);
            this.tlg1.Name = "tlg1";
            this.tlg1.Size = new System.Drawing.Size(97, 16);
            this.tlg1.TabIndex = 4;
            this.tlg1.Text = "Telegramm Nr:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(173, 189);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 160);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(813, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ende";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bezeichnung:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "V0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telegramm Funktion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telegramme:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Com-Driver FA/TS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ortsbezeichnung:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Prozessname:";
            // 
            // timerwert
            // 
            this.timerwert.Location = new System.Drawing.Point(952, 28);
            this.timerwert.Name = "timerwert";
            this.timerwert.Size = new System.Drawing.Size(59, 20);
            this.timerwert.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Telegramm Daten",
            "TE Status"});
            this.comboBox1.Location = new System.Drawing.Point(145, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Auswahl:";
            // 
            // telbl1
            // 
            this.telbl1.AutoSize = true;
            this.telbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telbl1.Location = new System.Drawing.Point(99, 117);
            this.telbl1.Name = "telbl1";
            this.telbl1.Size = new System.Drawing.Size(68, 16);
            this.telbl1.TabIndex = 18;
            this.telbl1.Text = "TE Status:";
            // 
            // eingabete
            // 
            this.eingabete.Location = new System.Drawing.Point(173, 116);
            this.eingabete.Multiline = true;
            this.eingabete.Name = "eingabete";
            this.eingabete.Size = new System.Drawing.Size(41, 26);
            this.eingabete.TabIndex = 19;
            this.eingabete.TextChanged += new System.EventHandler(this.eingabete_TextChanged);
            this.eingabete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eingabete_KeyPress);
            // 
            // eingabete2
            // 
            this.eingabete2.Location = new System.Drawing.Point(242, 116);
            this.eingabete2.Multiline = true;
            this.eingabete2.Name = "eingabete2";
            this.eingabete2.Size = new System.Drawing.Size(41, 26);
            this.eingabete2.TabIndex = 20;
            this.eingabete2.TextChanged += new System.EventHandler(this.eingabete2_TextChanged);
            this.eingabete2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eingabete2_KeyPress);
            // 
            // trente
            // 
            this.trente.AutoSize = true;
            this.trente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trente.Location = new System.Drawing.Point(222, 122);
            this.trente.Name = "trente";
            this.trente.Size = new System.Drawing.Size(14, 20);
            this.trente.TabIndex = 21;
            this.trente.Text = "/";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(430, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 160);
            this.textBox1.TabIndex = 22;
            // 
            // lblbezsub
            // 
            this.lblbezsub.AutoSize = true;
            this.lblbezsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbezsub.Location = new System.Drawing.Point(427, 167);
            this.lblbezsub.Name = "lblbezsub";
            this.lblbezsub.Size = new System.Drawing.Size(130, 16);
            this.lblbezsub.TabIndex = 23;
            this.lblbezsub.Text = "Sub Bezeichnung:";
            // 
            // lblbezte
            // 
            this.lblbezte.AutoSize = true;
            this.lblbezte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbezte.Location = new System.Drawing.Point(173, 167);
            this.lblbezte.Name = "lblbezte";
            this.lblbezte.Size = new System.Drawing.Size(122, 16);
            this.lblbezte.TabIndex = 24;
            this.lblbezte.Text = "Te Bezeichnung:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 476);
            this.Controls.Add(this.lblbezte);
            this.Controls.Add(this.lblbezsub);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trente);
            this.Controls.Add(this.eingabete2);
            this.Controls.Add(this.eingabete);
            this.Controls.Add(this.telbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.timerwert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tlg1);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.eingabetlg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Abfrage Telegramm Daten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eingabetlg;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label tlg1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox timerwert;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label telbl1;
        private System.Windows.Forms.TextBox eingabete;
        private System.Windows.Forms.TextBox eingabete2;
        private System.Windows.Forms.Label trente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblbezsub;
        private System.Windows.Forms.Label lblbezte;
    }
}

