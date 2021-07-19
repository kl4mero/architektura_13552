using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();



            if (memactiv != 1)
            {
                for (int i = 0; i < memory.Length; i++)
                {
                    memory[i] = "00";
                    if (i == memory.Length)
                    {
                        memactiv = 1;
                    }
                }
                
            }

        }

        string[] memory = new string[65536];

        int memactiv = 0;


        private void Reset1_Click(object sender, EventArgs e)
        {
         

            AX_text.Text = "0000";
            BX_text.Text = "0000";
            CX_text.Text = "0000";
            DX_text.Text = "0000";

            AX_text_2.Text = "0000";
            BX_text_2.Text = "0000";
            CX_text_2.Text = "0000";
            DX_text_2.Text = "0000";

        }

        private void Reset2_Click(object sender, EventArgs e)
        {

            SI_text.Text = "0000";
            DI_text.Text = "0000";
            BP_text.Text = "0000";
            DISP_text.Text = "0000";

            SI_text_2.Text = "0000";
            DI_text_2.Text = "0000";
            BP_text_2.Text = "0000";
            DISP_text_2.Text = "0000";

        }

        private void BX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = BX_text.Text;

        }

        private void CX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = CX_text.Text;

        }

        private void DX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = DX_text.Text;

        }

        private void AX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = AX_text.Text;

        }

        private void CX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = CX_text.Text;

        }

        private void DX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = DX_text.Text;

        }

        private void AX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = AX_text.Text;

        }

        private void BX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = BX_text.Text;

        }

        private void DX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = DX_text.Text;

        }

        private void AX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = AX_text.Text;

        }

        private void BX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = BX_text.Text;

        }

        private void CX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = CX_text.Text;

        }

        private void XCHG_AX_BX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_AX_CX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void XCHG_AX_DX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_BX_AX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_BX_CX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void XCHG_BX_DX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_CX_AX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_CX_BX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_CX_DX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_DX_AX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_DX_BX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_DX_CX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void Mem_move_Click(object sender, EventArgs e)
        {
            
            int SI = int.Parse(SI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DI = int.Parse(DI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BP = int.Parse(BP_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BX = int.Parse(BX_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DISP = int.Parse(DISP_text.Text, System.Globalization.NumberStyles.HexNumber);

            int inedx_SI_DISP = SI + DISP;
            int inedx_DI_DISP = DI + DISP;

            int bsae_BX_DISP = BX + DISP;
            int bsae_BP_DISP = BP + DISP;

            int index_base_SI_BX_DISP = SI + BX + DISP;
            int index_base_DI_BX_DISP = DI + BX + DISP;
            int index_base_SI_BP_DISP = SI + BP + DISP;
            int index_base_DI_BP_DISP = DI + BP + DISP;

            string AX1 = AX_text.Text.Remove(2);
            string AX2 = AX_text.Text.Substring(2);
            string BX1 = BX_text.Text.Remove(2);
            string BX2 = BX_text.Text.Substring(2);
            string CX1 = CX_text.Text.Remove(2);
            string CX2 = CX_text.Text.Substring(2);
            string DX1 = DX_text.Text.Remove(2);
            string DX2 = DX_text.Text.Substring(2);


            
            if (Mem_To_Reg.Checked == true)
            {

                if (Index_check.Checked == true)
                {

                    if (SI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                AX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                AX_text.Text = memory[inedx_SI_DISP] + "00";
                            }

                           

                        }
                        if (BX_check.Checked ==true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                BX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                BX_text.Text = memory[inedx_SI_DISP] + "00";
                            }


                        }
                        if (CX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                CX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                CX_text.Text = memory[inedx_SI_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                DX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                DX_text.Text = memory[inedx_SI_DISP] + "00";
                            }

                        }

                    }
                    if (DI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            
                            if (inedx_DI_DISP <= 65534)
                            {
                                AX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                AX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                BX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                BX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                CX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                CX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                DX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                DX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }

                    }

                }

                if (Base_check.Checked == true)
                {

                    if (BX2_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                AX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                AX_text.Text = memory[bsae_BX_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {

                            if (inedx_DI_DISP <= 65534)
                            {
                                BX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                BX_text.Text = memory[bsae_BX_DISP] + "00";
                            }
                            
                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                CX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                CX_text.Text = memory[bsae_BX_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                DX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                DX_text.Text = memory[bsae_BX_DISP] + "00";
                            }

                        }

                    }

                    if (BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            AX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
   
                        }
                        if (BX_check.Checked == true)
                        {

                            BX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];

                        }
                        if (CX_check.Checked == true)
                        {

                            CX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];

                        }
                        if (DX_check.Checked == true)
                        {

                            DX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];

                        }

                    }

                }

                if (Index_base_check.Checked == true )
                {
                    if (SI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }

                        }

                    }

                    if (DI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }

                        }

                    }

                    if (SI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {

                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {

                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {

                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }

                    }

                    if (DI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }
                        
                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }

                        }

                    }

                }

            }
           
            if (Reg_To_Mem.Checked == true)
            {

                if (Index_check.Checked == true)
                {

                    if (SI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = AX1;
                                memory[inedx_SI_DISP + 1] = AX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked ==true)
                        {
                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = BX1;
                                memory[inedx_SI_DISP + 1] = BX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = BX1;
                            }
                            
                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = CX1;
                                memory[inedx_SI_DISP + 1] = CX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = DX1;
                                memory[inedx_SI_DISP + 1] = DX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = DX1;
                            }

                        }

                    }

                    if (DI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = AX1;
                                memory[inedx_DI_DISP + 1] = AX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = BX1;
                                memory[inedx_DI_DISP + 1] = BX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = CX1;
                                memory[inedx_DI_DISP + 1] = CX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = DX1;
                                memory[inedx_DI_DISP + 1] = DX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = DX1;
                            }

                        }

                    }

                }

                if (Base_check.Checked == true)
                {

                    if (BX2_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = AX1;
                                memory[bsae_BX_DISP + 1] = AX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = AX1;
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = BX1;
                                memory[bsae_BX_DISP + 1] = BX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = CX1;
                                memory[bsae_BX_DISP + 1] = CX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = DX1;
                                memory[bsae_BX_DISP + 1] = DX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = DX1;
                            }
                           

                        }

                    }

                    if (BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = AX1;
                                memory[bsae_BP_DISP + 1] = AX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = AX1;
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = BX1;
                                memory[bsae_BP_DISP + 1] = BX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = CX1;
                                memory[bsae_BP_DISP + 1] = CX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = DX1;
                                memory[bsae_BP_DISP + 1] = DX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = DX1;
                            }

                        }

                    }

                }

                if (Index_base_check.Checked == true )
                {
                    if (SI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = AX1;
                                memory[index_base_SI_BX_DISP + 1] = AX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {

                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = BX1;
                                memory[index_base_SI_BX_DISP + 1] = BX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = CX1;
                                memory[index_base_SI_BX_DISP + 1] = CX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = DX1;
                                memory[index_base_SI_BX_DISP + 1] = DX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = DX1;
                            }

                        }

                    }

                    if (DI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = AX1;
                                memory[index_base_DI_BX_DISP + 1] = AX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = AX1;
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = BX1;
                                memory[index_base_DI_BX_DISP + 1] = BX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = CX1;
                                memory[index_base_DI_BX_DISP + 1] = CX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = DX1;
                                memory[index_base_DI_BX_DISP + 1] = DX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = DX1;
                            }

                        }

                    }

                    if (SI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = AX1;
                                memory[index_base_SI_BP_DISP + 1] = AX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = AX1;
                            }
                           

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = BX1;
                                memory[index_base_SI_BP_DISP + 1] = BX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = CX1;
                                memory[index_base_SI_BP_DISP + 1] = CX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = DX1;
                                memory[index_base_SI_BP_DISP + 1] = DX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = DX1;
                            }

                        }

                    }

                    if (DI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = AX1;
                                memory[index_base_DI_BP_DISP + 1] = AX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = BX1;
                                memory[index_base_DI_BP_DISP + 1] = BX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = CX1;
                                memory[index_base_DI_BP_DISP + 1] = CX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = DX1;
                                memory[index_base_DI_BP_DISP + 1] = DX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = DX1;
                            }

                        }

                    }

                }

            }

                       
        }

        private void Mem_Xchg_Click(object sender, EventArgs e)
        {
            

            int SI = int.Parse(SI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DI = int.Parse(DI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BP = int.Parse(BP_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BX = int.Parse(BX_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DISP = int.Parse(DISP_text.Text, System.Globalization.NumberStyles.HexNumber);

            int inedx_SI_DISP = SI + DISP;
            int inedx_DI_DISP = DI + DISP;

            int bsae_BX_DISP = BX + DISP;
            int bsae_BP_DISP = BP + DISP;

            int index_base_SI_BX_DISP = SI + BX + DISP;
            int index_base_DI_BX_DISP = DI + BX + DISP;
            int index_base_SI_BP_DISP = SI + BP + DISP;
            int index_base_DI_BP_DISP = DI + BP + DISP;

            string AX1 = AX_text.Text.Remove(2);
            string AX2 = AX_text.Text.Substring(2);
            string BX1 = BX_text.Text.Remove(2);
            string BX2 = BX_text.Text.Substring(2);
            string CX1 = CX_text.Text.Remove(2);
            string CX2 = CX_text.Text.Substring(2);
            string DX1 = DX_text.Text.Remove(2);
            string DX2 = DX_text.Text.Substring(2);

            if (Index_check.Checked == true)
            {

                if (SI_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            AX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = AX1;
                            memory[inedx_SI_DISP + 1] = AX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            AX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = AX1;
                        }                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            BX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = BX1;
                            memory[inedx_SI_DISP + 1] = BX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            BX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = BX1;
                        }

                    }
                    if (CX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            CX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = CX1;
                            memory[inedx_SI_DISP + 1] = CX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            CX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = CX1;
                        }                       

                    }
                    if (DX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            DX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = DX1;
                            memory[inedx_SI_DISP + 1] = DX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            DX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = DX1;
                        }                       

                    }

                }
                if (DI_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            AX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = AX1;
                            memory[inedx_DI_DISP + 1] = AX2;
                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            AX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            BX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = BX1;
                            memory[inedx_DI_DISP + 1] = BX2;

                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            BX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = BX1;
                        }
                       
                    }
                    if (CX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            CX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = CX1;
                            memory[inedx_DI_DISP + 1] = CX2;
                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            CX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = CX1;
                        }
                     

                    }
                    if (DX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            DX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = DX1;
                            memory[inedx_DI_DISP + 1] = DX2;
                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            DX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = DX1;
                        }
                       

                    }

                }

            }

            if (Base_check.Checked == true)
            {

                if (BX2_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            AX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = AX1;
                            memory[bsae_BX_DISP + 1] = AX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            AX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = AX1;
                        }
                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            BX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = BX1;
                            memory[bsae_BX_DISP + 1] = BX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            BX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            CX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = CX1;
                            memory[bsae_BX_DISP + 1] = CX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            CX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = CX1;
                        }
                      

                    }
                    if (DX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            DX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = DX1;
                            memory[bsae_BX_DISP + 1] = DX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            DX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = DX1;
                        }
                    
                    }

                }

                if (BP_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            AX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = AX1;
                            memory[bsae_BP_DISP + 1] = AX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            AX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            BX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = BX1;
                            memory[bsae_BP_DISP + 1] = BX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            BX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            CX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = CX1;
                            memory[bsae_BP_DISP + 1] = CX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            CX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = CX1;
                        }
                       

                    }
                    if (DX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            DX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = DX1;
                            memory[bsae_BP_DISP + 1] = DX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            DX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = DX1;
                        }
                      

                    }

                }

            }

            if (Index_base_check.Checked == true)
            {
                if (SI_BX_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = AX1;
                            memory[index_base_SI_BX_DISP + 1] = AX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = AX1;
                        }                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = BX1;
                            memory[index_base_SI_BX_DISP + 1] = BX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = CX1;
                            memory[index_base_SI_BX_DISP + 1] = CX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = CX1;
                        }
                    

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = DX1;
                            memory[index_base_SI_BX_DISP + 1] = DX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = DX1;
                        }
                   

                    }

                }

                if (DI_BX_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = AX1;
                            memory[index_base_DI_BX_DISP + 1] = AX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = AX1;
                        }
                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = BX1;
                            memory[index_base_DI_BX_DISP + 1] = BX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = CX1;
                            memory[index_base_DI_BX_DISP + 1] = CX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = CX1;
                        }
                  

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = DX1;
                            memory[index_base_DI_BX_DISP + 1] = DX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = DX1;
                        }
                     

                    }

                }

                if (SI_BP_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = AX1;
                            memory[index_base_SI_BP_DISP + 1] = AX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = BX1;
                            memory[index_base_SI_BP_DISP + 1] = BX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = BX1;
                        }
                       

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = CX1;
                            memory[index_base_SI_BP_DISP + 1] = CX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = CX1;
                        }
                        

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = DX1;
                            memory[index_base_SI_BP_DISP + 1] = DX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = DX1;
                        }                      
                    }

                }

                if (DI_BP_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = AX1;
                            memory[index_base_DI_BP_DISP + 1] = AX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = BX1;
                            memory[index_base_DI_BP_DISP + 1] = BX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = BX1;
                        }
                      

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = CX1;
                            memory[index_base_DI_BP_DISP + 1] = CX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = CX1;
                        }
                        

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = DX1;
                            memory[index_base_DI_BP_DISP + 1] = DX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = DX1;
                        }
                       

                    }

                }

            }

        }


    }
}
