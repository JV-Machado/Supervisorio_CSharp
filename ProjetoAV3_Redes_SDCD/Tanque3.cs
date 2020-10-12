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
    public partial class Tanque3 : UserControl
    {
        public Tanque3()
        {
            InitializeComponent();
        }

        private void Timer_ControleTanque3_Tick(object sender, EventArgs e)
        {
            if (Program.clp.IsConnected)
            {            
                VerticalPB_Tanque3.Value = Program.Nivel_Tanque3;
                TB_NivelTanque3.Text = Program.Nivel_Tanque3.ToString();

                TB_PressaoTanque3.Text = Program.Pressao_Tanque3.ToString("0.00");

                TB_TemperaturaTanque3.Text = Program.Temperatura_Tanque3.ToString("0.00");

                if (Program.BombaTanque_3 == true)
                {
                    PB_BombaTanque3.Visible = true;
                }
                else if (Program.BombaTanque_3 == false)
                {
                    PB_BombaTanque3.Visible = false;
                }

                if (Program.CompressorTanque_3 == true)
                {
                    PB_CompressorTanque3.Visible = true;
                }
                else if (Program.CompressorTanque_3 == false)
                {
                    PB_CompressorTanque3.Visible = false;
                }

                if(Program.ValvulaAlivioTanque_3 == true)
                {
                    PB_ValvulaAlivio3.Visible = true;
                }
                else if(Program.ValvulaAlivioTanque_3 == false)
                {
                    PB_ValvulaAlivio3.Visible = false;
                }

                if (Program.SprinklerTanque_3 == true)
                {
                    PB_SprinklerTanque3.Visible = true;
                }
                else if (Program.SprinklerTanque_3 == false)
                {
                    PB_SprinklerTanque3.Visible = false;
                }
            }
        }
    }
}
