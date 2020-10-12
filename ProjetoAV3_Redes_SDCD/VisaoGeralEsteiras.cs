using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAV3_Redes_SDCD
{
    public partial class VisaoGeralEsteiras : UserControl
    {
        public VisaoGeralEsteiras()
        {
            InitializeComponent();
        }

        private void Timer_VisaoGeralEsteiras_Tick(object sender, EventArgs e)
        {
            if (Program.clp.IsConnected)
            {
                TB_VG_ContagemTotalCarrossel.Text = Program.ContagemTotal_Carrossel.ToString();
                TB_VG_PesagemBotijao.Text = Program.Pesagem_Botijao.ToString();

                if (Program.Esteira_1 == true)
                {
                    PB_VG_Esteira1.Visible = true;
                }
                else if (Program.Esteira_1 == false)
                {
                    PB_VG_Esteira1.Visible = false;
                }
                if (Program.Esteira_2 == true)
                {
                    PB_VG_Esteira2.Visible = true;
                }
                else if (Program.Esteira_2 == false)
                {
                    PB_VG_Esteira2.Visible = false;
                }
                if (Program.Esteira_3 == true)
                {
                    PB_VG_Esteira3.Visible = true;
                }
                else if (Program.Esteira_3 == false)
                {
                    PB_VG_Esteira3.Visible = false;
                }
                if (Program.Esteira_4 == true)
                {
                    PB_VG_Esteira4.Visible = true;
                }
                else if (Program.Esteira_4 == false)
                {
                    PB_VG_Esteira4.Visible = false;
                }
                if (Program.Esteira_5 == true)
                {
                    PB_VG_Esteira5.Visible = true;
                }
                else if (Program.Esteira_5 == false)
                {
                    PB_VG_Esteira5.Visible = false;
                }
                if (Program.Esteira_6 == true)
                {
                    PB_VG_Esteira6.Visible = true;
                }
                else if (Program.Esteira_6 == false)
                {
                    PB_VG_Esteira6.Visible = false;
                }

                if (Program.AtuadorCorrige_Botijao == true)
                {
                    PB_VG_Correcao.Visible = true;
                }
                else
                {
                    PB_VG_Correcao.Visible = false;
                }
                
                if (Program.Pintura_1 == true)
                {
                    PB_VG_Pintura1.Visible = true;
                }
                else if (Program.Pintura_1 == false)
                {
                    PB_VG_Pintura1.Visible = false;
                }

                if (Program.Pintura_2 == true)
                {
                    PB_VG_Pintura2.Visible = true;
                }
                else if (Program.Pintura_2 == false)
                {
                    PB_VG_Pintura2.Visible = false;
                }

                if (Program.Pintura_3 == true)
                {
                    PB_VG_Pintura3.Visible = true;
                }
                else if (Program.Pintura_3 == false)
                {
                    PB_VG_Pintura3.Visible = false;
                }

                if (Program.Pintura_4 == true)
                {
                    PB_VG_Pintura4.Visible = true;
                }
                else if (Program.Pintura_4 == false)
                {
                    PB_VG_Pintura4.Visible = false;
                }

                if (Program.Pintura_5 == true)
                {
                    PB_VG_Pintura5.Visible = true;
                }
                else if (Program.Pintura_5 == false)
                {
                    PB_VG_Pintura5.Visible = false;
                }

                if (Program.Pintura_6 == true)
                {
                    PB_VG_Pintura6.Visible = true;
                }
                else if (Program.Pintura_6 == false)
                {
                    PB_VG_Pintura6.Visible = false;
                }

                TB__VG_ContagemTotalPintura.Text = Program.ContagemTotalSensorFim_Pintura.ToString();
            }
        }
    }
}
