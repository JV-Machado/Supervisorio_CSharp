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
    public partial class Tanque1 : UserControl
    {
        public Tanque1()
        {
            InitializeComponent();
        }

        private void Timer_Controle_Tick(object sender, EventArgs e)
        {
           
            if (Program.clp.IsConnected)
            {
                VerticalPB_Tanque1.Value = Program.Nivel_Tanque1;
                TB_NivelTanque1.Text = Program.Nivel_Tanque1.ToString();

                TB_PressaoTanque1.Text = Program.Pressao_Tanque1.ToString("0.00");

                TB_TemperaturaTanque1.Text = Program.Temperatura_Tanque1.ToString("0.00");

                if (Program.BombaTanque_1 == true)
                {
                    PB_BombaTanque1.Visible = true;
                }
                else if(Program.BombaTanque_1 == false)
                {
                    PB_BombaTanque1.Visible = false;
                }

                if (Program.CompressorTanque_1 == true)
                {
                    PB_CompressorTanque1.Visible = true;
                }
                else if(Program.CompressorTanque_1 == false)
                {
                    PB_CompressorTanque1.Visible = false;
                }

                if(Program.ValvulaAlivioTanque_1 == true)
                {
                    PB_ValvulaAlivio1.Visible = true;
                }
                else if(Program.ValvulaAlivioTanque_1 == false)
                {
                    PB_ValvulaAlivio1.Visible = false;
                }

                if (Program.SprinklerTanque_1 == true)
                {
                    PB_SprinklerTanque1.Visible = true;
                }
                else if(Program.SprinklerTanque_1 == false)
                {
                    PB_SprinklerTanque1.Visible = false;
                }
            }
        }
    }
}
