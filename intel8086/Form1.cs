using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.InteropServices;

namespace intel8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void toSP(int value)
        {

        }
        
        public void AX_D_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public void AX_D_TextChanged(object sender, EventArgs e)
        {
            long number_AX = long.Parse(AX_D.Text);
            string hex_number_AX = Convert.ToString(number_AX, 16);
            AX_H.Text = hex_number_AX.ToUpper();
            //smth like update from every input fields
            SP_H.Text = hex_number_AX.ToUpper();
        }

        public void BX_D_TextChanged(object sender, EventArgs e)
        {
            long number_BX = long.Parse(BX_D.Text);
            string hex_number_BX = Convert.ToString(number_BX, 16);
            BX_H.Text = hex_number_BX.ToUpper();
            SP_H.Text = hex_number_BX.ToUpper();
        }


        public void CX_D_TextChanged(object sender, EventArgs e)
        {
            long number_CX = long.Parse(CX_D.Text);
            string hex_number_CX = Convert.ToString(number_CX, 16);
            CX_H.Text = hex_number_CX.ToUpper();
            SP_H.Text = hex_number_CX.ToUpper();
        }

        public void DX_D_TextChanged(object sender, EventArgs e)
        {
            long number_DX = long.Parse(DX_D.Text);
            string hex_number_DX = Convert.ToString(number_DX, 16);
            DX_H.Text = hex_number_DX.ToUpper();
            SP_H.Text = hex_number_DX.ToUpper();
        }
        public void SP_H_TextChanged(object sender, EventArgs e)
        {
            
        }
        //stack changing value for every change added to memory 
        private void SP_D_TextChanged(object sender, EventArgs e)
        {
            long number_SP = long.Parse(SP_D.Text);
            string hex_number_SP = Convert.ToString(number_SP, 16);
            SP_H.Text = hex_number_SP;
        }


        private void label1_Click(object sender, EventArgs e){ }
        private void label8_Click(object sender, EventArgs e){ }
        private void label9_Click(object sender, EventArgs e){ }
        private void label6_Click(object sender, EventArgs e){ }



        private void AX_H_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BX_H_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CX_H_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DX_H_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

       
        private void rozkaz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rej_zrodlowy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wartosc_zrodlowy = rej_zrodlowy.Text;
            rej_docelowy.Items.Clear();
            if (wartosc_zrodlowy == "AX")
            {
                rej_docelowy.Items.Add("BX");
                rej_docelowy.Items.Add("CX");
                rej_docelowy.Items.Add("DX");
                rej_docelowy.Items.Add("SI");
                rej_docelowy.Items.Add("DI");
                rej_docelowy.Items.Add("BP");
            }
            else if (wartosc_zrodlowy == "BX")
            {
                rej_docelowy.Items.Add("AX");
                rej_docelowy.Items.Add("CX");
                rej_docelowy.Items.Add("DX");
                rej_docelowy.Items.Add("SI");
                rej_docelowy.Items.Add("DI");
                rej_docelowy.Items.Add("BP");
            }
            else if (wartosc_zrodlowy == "CX")
            {
                rej_docelowy.Items.Add("AX");
                rej_docelowy.Items.Add("BX");
                rej_docelowy.Items.Add("DX");
                rej_docelowy.Items.Add("SI");
                rej_docelowy.Items.Add("DI");
                rej_docelowy.Items.Add("BP");
            }
            else if (wartosc_zrodlowy == "DX")
            {
                rej_docelowy.Items.Add("AX");
                rej_docelowy.Items.Add("BX");
                rej_docelowy.Items.Add("CX");
                rej_docelowy.Items.Add("SI");
                rej_docelowy.Items.Add("DI");
                rej_docelowy.Items.Add("BP");
            }
            else if (wartosc_zrodlowy == "SI")
            {
                rej_docelowy.Items.Add("AX");
                rej_docelowy.Items.Add("BX");
                rej_docelowy.Items.Add("CX");
                rej_docelowy.Items.Add("DX");
                rej_docelowy.Items.Add("DI");
                rej_docelowy.Items.Add("BP");
            }
            else if (wartosc_zrodlowy == "DI")
            {
                rej_docelowy.Items.Add("AX");
                rej_docelowy.Items.Add("BX");
                rej_docelowy.Items.Add("CX");
                rej_docelowy.Items.Add("DX");
                rej_docelowy.Items.Add("SI");
                rej_docelowy.Items.Add("BP");
            } else if (wartosc_zrodlowy == "BP")
            {
                rej_docelowy.Items.Add("AX");
                rej_docelowy.Items.Add("BX");
                rej_docelowy.Items.Add("CX");
                rej_docelowy.Items.Add("DX");
                rej_docelowy.Items.Add("SI");
                rej_docelowy.Items.Add("DI");
            }
        }

        private void rej_docelowy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //memory to store data from registry
        Dictionary<string, string> memory = new Dictionary<string, string>();

        //genereting index from  action registry and offset value
        private string index(string offset, string zrodlowy, string rejestr)
        {
            string index = rejestr + offset + zrodlowy + BP_H.Text;

            return index;
        }

        private void przycisk_Click(object sender, EventArgs e)
        {
            string wykonaj = polecenie.Text;
            string rodzaj_rozkazu = rozkaz.Text;
            string zrodlowy = rej_zrodlowy.Text;
            string docelowy = rej_docelowy.Text;
            string off = offset.Text;

            string wartosc_zrodlowego= w_zrodlowego(zrodlowy);
            string wartosc_docelowego = w_docelowego(docelowy);

            if (rodzaj_rozkazu == "MOV")
            {
                if (docelowy == "AX") {
                    if (zrodlowy == "SI" || zrodlowy == "DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                    }
                    else
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = wartosc_zrodlowego;
                    }
                } 
                else if (docelowy == "BX")
                {
                    if (zrodlowy == "SI" || zrodlowy == "DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        BX_H.Text = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                    }
                    else
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        BX_H.Text = wartosc_zrodlowego;
                    }
                }
                else if (docelowy == "CX")
                {
                    if (zrodlowy == "SI" || zrodlowy == "DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        CX_H.Text = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                    }
                    else
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        CX_H.Text = wartosc_zrodlowego;
                    }
                }
                else if (docelowy == "DX")
                {
                    if (zrodlowy == "SI" || zrodlowy == "DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        DX_H.Text = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                    }
                    else
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        DX_H.Text = wartosc_zrodlowego;
                    }
                }
                else if (docelowy == "SI" || docelowy == "DI" || docelowy == "BP")
                {
                    wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                    polecenie.Text = wykonaj;
                    memory[index(off, wartosc_docelowego, docelowy)] = wartosc_zrodlowego;

                }
                
            }else if(rodzaj_rozkazu == "POP")
            {
                if (docelowy == "AX") {
                    AX_H.Text = SP_H.Text;
                    wykonaj = rodzaj_rozkazu + " " + docelowy + " SP";
                    polecenie.Text = wykonaj;
                }
                else if (docelowy == "BX") {
                    BX_H.Text = SP_H.Text;
                    wykonaj = rodzaj_rozkazu + " " + docelowy + " SP";
                    polecenie.Text = wykonaj;
                }
                else if (docelowy == "CX") {
                    CX_H.Text = SP_H.Text;
                    wykonaj = rodzaj_rozkazu + " " + docelowy + " SP";
                    polecenie.Text = wykonaj;
                } 
                else if (docelowy == "DX")
                {
                    DX_H.Text = SP_H.Text;
                    wykonaj = rodzaj_rozkazu + " " + docelowy + " SP";
                    polecenie.Text = wykonaj;
                }
            }else if(rodzaj_rozkazu == "PUSH")
            {
                if (zrodlowy == "AX")
                {
                    SP_H.Text = AX_H.Text;
                    wykonaj = rodzaj_rozkazu + " SP " + zrodlowy;
                    polecenie.Text = wykonaj;
                }
                else if (zrodlowy == "BX")
                {
                    SP_H.Text = BX_H.Text;
                    wykonaj = rodzaj_rozkazu + " SP " + zrodlowy;
                    polecenie.Text = wykonaj;
                }
                else if (zrodlowy == "CX")
                {
                    SP_H.Text = CX_H.Text;
                    wykonaj = rodzaj_rozkazu + " SP " + zrodlowy;
                    polecenie.Text = wykonaj;
                }
                else if (zrodlowy == "DX") {
                    SP_H.Text = DX_H.Text;
                    wykonaj = rodzaj_rozkazu + " SP " + zrodlowy;
                    polecenie.Text = wykonaj;
                } 
            } else if (rodzaj_rozkazu == "XCHG")
            {
                if (docelowy == "AX")
                {
                    if (zrodlowy == "BX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = wartosc_zrodlowego;
                        BX_H.Text = wartosc_docelowego;
                    }
                    else if (zrodlowy == "CX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = wartosc_zrodlowego;
                        CX_H.Text = wartosc_docelowego;
                    }
                    else if (zrodlowy == "DX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = wartosc_zrodlowego;
                        DX_H.Text = wartosc_docelowego;
                    }
                    else if (zrodlowy == "SI" || zrodlowy =="DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        string temp = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                        memory[index(off, wartosc_zrodlowego, zrodlowy)] = wartosc_docelowego;
                        AX_H.Text = temp;
                    }
                }
                else if (docelowy == "BX")
                {
                    if (zrodlowy == "AX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = wartosc_docelowego;
                        BX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "CX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        CX_H.Text = wartosc_docelowego;
                        BX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "DX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        DX_H.Text = wartosc_docelowego;
                        BX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "SI" || zrodlowy == "DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        string temp = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                        memory[index(off, wartosc_zrodlowego, zrodlowy)] = wartosc_docelowego;
                        BX_H.Text = temp;
                    }
                }
                else if (docelowy == "CX")
                {
                    if (zrodlowy == "AX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = wartosc_docelowego;
                        CX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "BX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        BX_H.Text = wartosc_docelowego;
                        CX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "DX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        DX_H.Text = wartosc_docelowego;
                        CX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "SI" || zrodlowy == "DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        string temp = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                        memory[index(off, wartosc_zrodlowego, zrodlowy)] = wartosc_docelowego;
                        CX_H.Text = temp;
                    }
                }
                else if (docelowy == "SI")
                {
                    if (zrodlowy == "AX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "BX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        BX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "DX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        DX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "CX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        CX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    memory[index(off, wartosc_docelowego, docelowy)] = wartosc_zrodlowego;
                }
                else if (docelowy == "DI")
                {
                    if (zrodlowy == "AX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "BX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        BX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "DX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        DX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "CX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        CX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    memory[index(off, wartosc_docelowego, docelowy)] = wartosc_zrodlowego;
                }
                else if (docelowy == "BP")
                {
                    if (zrodlowy == "AX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "BX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        BX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "DX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        DX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    else if (zrodlowy == "CX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        CX_H.Text = memory[index(off, wartosc_docelowego, docelowy)];
                    }
                    memory[index(off, wartosc_docelowego, docelowy)] = wartosc_zrodlowego;
                }
                else
                {
                    if (zrodlowy == "AX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        AX_H.Text = wartosc_docelowego;
                        DX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "BX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        BX_H.Text = wartosc_docelowego;
                        DX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "CX")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        CX_H.Text = wartosc_docelowego;
                        DX_H.Text = wartosc_zrodlowego;
                    }
                    else if (zrodlowy == "SI" || zrodlowy == "DI" || zrodlowy == "BP")
                    {
                        wykonaj = rodzaj_rozkazu + " " + docelowy + " " + zrodlowy;
                        polecenie.Text = wykonaj;
                        string temp = memory[index(off, wartosc_zrodlowego, zrodlowy)];
                        memory[index(off, wartosc_zrodlowego, zrodlowy)] = wartosc_docelowego;
                        DX_H.Text = temp;
                    }
                }
            }
        }

 
        //fetching data from registry
         public string w_zrodlowego(string zrodlowy)
        {
            if (zrodlowy == "AX") return AX_H.Text;
            else if (zrodlowy == "BX") return BX_H.Text;
            else if (zrodlowy == "CX") return CX_H.Text;
            else if (zrodlowy == "SI") return SI_H.Text;
            else if (zrodlowy == "DI") return DI_H.Text;
            else if (zrodlowy == "BP") return BP_H.Text;
            else return DX_H.Text;
        }

        //fetching data from direct registry
        public string w_docelowego(string docelowy)
        {
            if (docelowy == "AX") return AX_H.Text;
            else if (docelowy == "BX") return BX_H.Text;
            else if (docelowy == "CX") return CX_H.Text;
            else if (docelowy == "SI") return SI_H.Text;
            else if (docelowy == "DI") return DI_H.Text;
            else if (docelowy == "BP") return BP_H.Text;
            else return DX_H.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generating random values of registry
            Random generator = new Random();
            AX_D.Text = generator.Next(0, 255).ToString();
            BX_D.Text = generator.Next(0, 255).ToString();
            CX_D.Text = generator.Next(0, 255).ToString();
            DX_D.Text = generator.Next(0, 255).ToString();
            DX_D.Text = generator.Next(0, 255).ToString();

            long number_SI = generator.Next(0, 255);
            string hex_number_SI = Convert.ToString(number_SI, 16);
            SI_H.Text = hex_number_SI.ToUpper();

            long number_DI = generator.Next(0, 255);
            string hex_number_DI = Convert.ToString(number_DI, 16);
            DI_H.Text = hex_number_DI.ToUpper();

            long number_BP = generator.Next(0, 255);
            string hex_number_BP = Convert.ToString(number_BP, 16);
            BP_H.Text = hex_number_BP.ToUpper();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            AX_H.Text = " ";
            BX_H.Text = " ";
            CX_H.Text = " ";
            DX_H.Text = " ";
            SI_H.Text = " ";
            DI_H.Text = " ";
            BP_H.Text = " ";
            SP_H.Text = " ";
            offset.Text = " ";
            polecenie.Text = " ";
            rozkaz.Text = " ";
            rej_docelowy.Text = " ";
            rej_zrodlowy.Text = " ";
        }
    }
}