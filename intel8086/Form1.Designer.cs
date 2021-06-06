namespace intel8086
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BX_D = new System.Windows.Forms.TextBox();
            this.AX_D = new System.Windows.Forms.MaskedTextBox();
            this.CX_D = new System.Windows.Forms.TextBox();
            this.DX_D = new System.Windows.Forms.TextBox();
            this.przycisk = new System.Windows.Forms.Button();
            this.rozkaz = new System.Windows.Forms.ComboBox();
            this.rej_zrodlowy = new System.Windows.Forms.ComboBox();
            this.rej_docelowy = new System.Windows.Forms.ComboBox();
            this.AX_H = new System.Windows.Forms.MaskedTextBox();
            this.BX_H = new System.Windows.Forms.MaskedTextBox();
            this.CX_H = new System.Windows.Forms.MaskedTextBox();
            this.DX_H = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SP_H = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.random = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.BP_H = new System.Windows.Forms.MaskedTextBox();
            this.DI_H = new System.Windows.Forms.MaskedTextBox();
            this.SI_H = new System.Windows.Forms.MaskedTextBox();
            this.offset = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SP_D = new System.Windows.Forms.TextBox();
            this.polecenie = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BX_D
            // 
            this.BX_D.Location = new System.Drawing.Point(54, 203);
            this.BX_D.Name = "BX_D";
            this.BX_D.Size = new System.Drawing.Size(100, 20);
            this.BX_D.TabIndex = 0;
            this.BX_D.TextChanged += new System.EventHandler(this.BX_D_TextChanged);
            // 
            // AX_D
            // 
            this.AX_D.Location = new System.Drawing.Point(54, 162);
            this.AX_D.Name = "AX_D";
            this.AX_D.Size = new System.Drawing.Size(100, 20);
            this.AX_D.TabIndex = 1;
            this.AX_D.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.AX_D_MaskInputRejected);
            this.AX_D.TextChanged += new System.EventHandler(this.AX_D_TextChanged);
            // 
            // CX_D
            // 
            this.CX_D.Location = new System.Drawing.Point(54, 242);
            this.CX_D.Name = "CX_D";
            this.CX_D.Size = new System.Drawing.Size(100, 20);
            this.CX_D.TabIndex = 2;
            this.CX_D.TextChanged += new System.EventHandler(this.CX_D_TextChanged);
            // 
            // DX_D
            // 
            this.DX_D.Location = new System.Drawing.Point(54, 281);
            this.DX_D.Name = "DX_D";
            this.DX_D.Size = new System.Drawing.Size(100, 20);
            this.DX_D.TabIndex = 3;
            this.DX_D.TextChanged += new System.EventHandler(this.DX_D_TextChanged);
            // 
            // przycisk
            // 
            this.przycisk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.przycisk.Location = new System.Drawing.Point(683, 357);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(75, 23);
            this.przycisk.TabIndex = 4;
            this.przycisk.Text = "Wykonaj";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // rozkaz
            // 
            this.rozkaz.FormattingEnabled = true;
            this.rozkaz.Items.AddRange(new object[] {
            "MOV",
            "XCHG",
            "PUSH",
            "POP"});
            this.rozkaz.Location = new System.Drawing.Point(460, 161);
            this.rozkaz.Name = "rozkaz";
            this.rozkaz.Size = new System.Drawing.Size(121, 21);
            this.rozkaz.TabIndex = 5;
            this.rozkaz.SelectedIndexChanged += new System.EventHandler(this.rozkaz_SelectedIndexChanged);
            // 
            // rej_zrodlowy
            // 
            this.rej_zrodlowy.FormattingEnabled = true;
            this.rej_zrodlowy.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX",
            "SI",
            "DI",
            "BP"});
            this.rej_zrodlowy.Location = new System.Drawing.Point(659, 161);
            this.rej_zrodlowy.Name = "rej_zrodlowy";
            this.rej_zrodlowy.Size = new System.Drawing.Size(121, 21);
            this.rej_zrodlowy.TabIndex = 6;
            this.rej_zrodlowy.SelectedIndexChanged += new System.EventHandler(this.rej_zrodlowy_SelectedIndexChanged);
            // 
            // rej_docelowy
            // 
            this.rej_docelowy.FormattingEnabled = true;
            this.rej_docelowy.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX",
            "SI",
            "DI",
            "BP"});
            this.rej_docelowy.Location = new System.Drawing.Point(659, 272);
            this.rej_docelowy.Name = "rej_docelowy";
            this.rej_docelowy.Size = new System.Drawing.Size(121, 21);
            this.rej_docelowy.TabIndex = 7;
            this.rej_docelowy.SelectedIndexChanged += new System.EventHandler(this.rej_docelowy_SelectedIndexChanged);
            // 
            // AX_H
            // 
            this.AX_H.Location = new System.Drawing.Point(54, 162);
            this.AX_H.Name = "AX_H";
            this.AX_H.Size = new System.Drawing.Size(100, 20);
            this.AX_H.TabIndex = 8;
            this.AX_H.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.AX_H_MaskInputRejected);
            // 
            // BX_H
            // 
            this.BX_H.Location = new System.Drawing.Point(54, 203);
            this.BX_H.Name = "BX_H";
            this.BX_H.Size = new System.Drawing.Size(100, 20);
            this.BX_H.TabIndex = 9;
            this.BX_H.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.BX_H_MaskInputRejected);
            // 
            // CX_H
            // 
            this.CX_H.Location = new System.Drawing.Point(54, 242);
            this.CX_H.Name = "CX_H";
            this.CX_H.Size = new System.Drawing.Size(100, 20);
            this.CX_H.TabIndex = 10;
            this.CX_H.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CX_H_MaskInputRejected);
            // 
            // DX_H
            // 
            this.DX_H.Location = new System.Drawing.Point(54, 281);
            this.DX_H.Name = "DX_H";
            this.DX_H.Size = new System.Drawing.Size(100, 20);
            this.DX_H.TabIndex = 11;
            this.DX_H.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DX_H_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "AX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "BX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "DX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "HEX";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ROZKAZ : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rejestr źródłowy";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Rejestr docelowy";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "REJESTRY";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(61, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(761, 58);
            this.label11.TabIndex = 22;
            this.label11.Text = "Symulator rozkazów procesora Intel 8086";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "SP";
            // 
            // SP_H
            // 
            this.SP_H.Location = new System.Drawing.Point(258, 280);
            this.SP_H.Name = "SP_H";
            this.SP_H.Size = new System.Drawing.Size(100, 20);
            this.SP_H.TabIndex = 25;
            this.SP_H.TextChanged += new System.EventHandler(this.SP_H_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(646, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Autor : Maksymilian Jachymczak";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Losowe wartości";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // random
            // 
            this.random.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.random.Location = new System.Drawing.Point(109, 356);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(75, 23);
            this.random.TabIndex = 29;
            this.random.Text = "Wygeneruj";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(255, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "REJESTRY WSKAŹNIKOWE";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(294, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "HEX";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(231, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "BP";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(231, 203);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "DI";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(231, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 13);
            this.label22.TabIndex = 38;
            this.label22.Text = "SI";
            // 
            // BP_H
            // 
            this.BP_H.Location = new System.Drawing.Point(258, 242);
            this.BP_H.Name = "BP_H";
            this.BP_H.Size = new System.Drawing.Size(100, 20);
            this.BP_H.TabIndex = 36;
            // 
            // DI_H
            // 
            this.DI_H.Location = new System.Drawing.Point(258, 203);
            this.DI_H.Name = "DI_H";
            this.DI_H.Size = new System.Drawing.Size(100, 20);
            this.DI_H.TabIndex = 35;
            // 
            // SI_H
            // 
            this.SI_H.Location = new System.Drawing.Point(258, 162);
            this.SI_H.Name = "SI_H";
            this.SI_H.Size = new System.Drawing.Size(100, 20);
            this.SI_H.TabIndex = 34;
            // 
            // offset
            // 
            this.offset.Location = new System.Drawing.Point(258, 358);
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(100, 20);
            this.offset.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(204, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "OFFSET";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // SP_D
            // 
            this.SP_D.Location = new System.Drawing.Point(258, 280);
            this.SP_D.Name = "SP_D";
            this.SP_D.Size = new System.Drawing.Size(100, 20);
            this.SP_D.TabIndex = 24;
            this.SP_D.TextChanged += new System.EventHandler(this.SP_D_TextChanged);
            // 
            // polecenie
            // 
            this.polecenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.polecenie.Location = new System.Drawing.Point(523, 90);
            this.polecenie.Name = "polecenie";
            this.polecenie.Size = new System.Drawing.Size(192, 20);
            this.polecenie.TabIndex = 48;
            this.polecenie.Click += new System.EventHandler(this.label5_Click);
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(109, 395);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 49;
            this.clear.Text = "Wyczyść";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Wyczyść wartości";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.polecenie);
            this.Controls.Add(this.offset);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.BP_H);
            this.Controls.Add(this.DI_H);
            this.Controls.Add(this.SI_H);
            this.Controls.Add(this.random);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SP_H);
            this.Controls.Add(this.SP_D);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DX_H);
            this.Controls.Add(this.CX_H);
            this.Controls.Add(this.BX_H);
            this.Controls.Add(this.AX_H);
            this.Controls.Add(this.rej_docelowy);
            this.Controls.Add(this.rej_zrodlowy);
            this.Controls.Add(this.rozkaz);
            this.Controls.Add(this.przycisk);
            this.Controls.Add(this.DX_D);
            this.Controls.Add(this.CX_D);
            this.Controls.Add(this.AX_D);
            this.Controls.Add(this.BX_D);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Intel8086 Jachymczak Maksymilian";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CX_D;
        private System.Windows.Forms.TextBox DX_D;
        private System.Windows.Forms.Button przycisk;
        private System.Windows.Forms.ComboBox rozkaz;
        private System.Windows.Forms.ComboBox rej_zrodlowy;
        private System.Windows.Forms.ComboBox rej_docelowy;
        private System.Windows.Forms.MaskedTextBox CX_H;
        private System.Windows.Forms.MaskedTextBox DX_H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox AX_D;
        public System.Windows.Forms.MaskedTextBox AX_H;
        public System.Windows.Forms.TextBox BX_D;
        public System.Windows.Forms.MaskedTextBox BX_H;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SP_H;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox BP_H;
        public System.Windows.Forms.MaskedTextBox DI_H;
        public System.Windows.Forms.MaskedTextBox SI_H;
        private System.Windows.Forms.TextBox offset;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SP_D;
        private System.Windows.Forms.Label polecenie;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
    }
}

