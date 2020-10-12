using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace ProjetoAV3_Redes_SDCD
{
    public partial class Tanque2 : UserControl
    {
        public Tanque2()
        {
            InitializeComponent();
        }

        private void Timer_ControleTanque2_Tick(object sender, EventArgs e)
        {          
            if (Program.clp.IsConnected)
            {          
                VerticalPB_Tanque2.Value = Program.Nivel_Tanque2;
                TB_NivelTanque2.Text = Program.Nivel_Tanque2.ToString();

                TB_PressaoTanque2.Text = Program.Pressao_Tanque2.ToString("0.00");

                TB_TemperaturaTanque2.Text = Program.Temperatura_Tanque2.ToString("0.00");

                if (Program.BombaTanque_2 == true)
                {
                    PB_BombaTanque2.Visible = true;
                }
                else if (Program.BombaTanque_2 == false)
                {
                    PB_BombaTanque2.Visible = false;
                }

                if (Program.CompressorTanque_2 == true)
                {
                    PB_CompressorTanque2.Visible = true;
                }
                else if (Program.CompressorTanque_2 == false)
                {
                    PB_CompressorTanque2.Visible = false;
                }

                if(Program.ValvulaAlivioTanque_2 == true)
                {
                    PB_ValvulaAlivio2.Visible = true;
                }
                else if(Program.ValvulaAlivioTanque_2 == false)
                {
                    PB_ValvulaAlivio2.Visible = false;
                }

                if (Program.SprinklerTanque_2 == true)
                {
                    PB_SprinklerTanque2.Visible = true;
                }
                else if (Program.SprinklerTanque_2 == false)
                {
                    PB_SprinklerTanque2.Visible = false;
                }
            }
        }
    }
}
