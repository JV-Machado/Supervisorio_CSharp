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
    public partial class Carrossel : UserControl
    {
        public Carrossel()
        {
            InitializeComponent();
        }

        private void Timer_Carrossel_Tick(object sender, EventArgs e)
        {
            if(Program.clp.IsConnected)
            {
                TB_QNT_BotijoesCarrossel.Text = Program.ContagemEntrada_Carrossel.ToString();
                TB_QNT_Total.Text = Program.ContagemTotal_Carrossel.ToString();

                if (Program.SensorBotijao_1 == true)
                {
                    PB_SensorBotijao1.Visible = true;
                }
                else if(Program.SensorBotijao_1 == false)
                {
                    PB_SensorBotijao1.Visible = false;
                }

                if (Program.SensorBotijao_2 == true)
                {
                    PB_SensorBotijao2.Visible = true;
                }
                else if (Program.SensorBotijao_2 == false)
                {
                    PB_SensorBotijao2.Visible = false;
                }

                if (Program.SensorBotijao_3 == true)
                {
                    PB_SensorBotijao3.Visible = true;
                }
                else if (Program.SensorBotijao_3 == false)
                {
                    PB_SensorBotijao3.Visible = false;
                }

                if (Program.SensorBotijao_4 == true)
                {
                    PB_SensorBotijao4.Visible = true;
                }
                else if (Program.SensorBotijao_4 == false)
                {
                    PB_SensorBotijao4.Visible = false;
                }

                if (Program.SensorBotijao_5 == true)
                {
                    PB_SensorBotijao5.Visible = true;
                }
                else if (Program.SensorBotijao_5 == false)
                {
                    PB_SensorBotijao5.Visible = false;
                }

                if (Program.SensorBotijao_6 == true)
                {
                    PB_SensorBotijao6.Visible = true;
                }
                else if (Program.SensorBotijao_6 == false)
                {
                    PB_SensorBotijao6.Visible = false;
                }

                if(Program.Esteira_1 == true)
                {
                    PB_Esteira1.Visible = true;
                }
                else if (Program.Esteira_1 == false)
                {
                    PB_Esteira1.Visible = false;
                }
                if (Program.Esteira_2 == true)
                {
                    PB_Esteira2.Visible = true;
                }
                else if (Program.Esteira_2 == false)
                {
                    PB_Esteira2.Visible = false;
                }
                if (Program.Esteira_3 == true)
                {
                    PB_Esteira3.Visible = true;
                }
                else if (Program.Esteira_3 == false)
                {
                    PB_Esteira3.Visible = false;
                }
                if (Program.Esteira_4 == true)
                {
                    PB_Esteira4.Visible = true;
                }
                else if (Program.Esteira_4 == false)
                {
                    PB_Esteira4.Visible = false;
                }
                if (Program.Esteira_5 == true)
                {
                    PB_Esteira5.Visible = true;
                }
                else if (Program.Esteira_5 == false)
                {
                    PB_Esteira5.Visible = false;
                }
                if (Program.Esteira_6 == true)
                {
                    PB_Esteira6.Visible = true;
                }
                else if (Program.Esteira_6 == false)
                {
                    PB_Esteira6.Visible = false;
                }

                if(Program.Atuador_1 == true)
                {
                    PB_Atuador1.Visible = true;
                }
                else if(Program.Atuador_1 == false)
                {
                    PB_Atuador1.Visible = false;
                }
                if (Program.Atuador_2 == true)
                {
                    PB_Atuador2.Visible = true;
                }
                else if (Program.Atuador_2 == false)
                {
                    PB_Atuador2.Visible = false;
                }
                if (Program.Atuador_3 == true)
                {
                    PB_Atuador3.Visible = true;
                }
                else if (Program.Atuador_3 == false)
                {
                    PB_Atuador3.Visible = false;
                }
                if (Program.Atuador_4 == true)
                {
                    PB_Atuador4.Visible = true;
                }
                else if (Program.Atuador_4 == false)
                {
                    PB_Atuador4.Visible = false;
                }
                if (Program.Atuador_5 == true)
                {
                    PB_Atuador5.Visible = true;
                }
                else if (Program.Atuador_5 == false)
                {
                    PB_Atuador5.Visible = false;
                }
                if (Program.Atuador_6 == true)
                {
                    PB_Atuador6.Visible = true;
                }
                else if (Program.Atuador_6 == false)
                {
                    PB_Atuador6.Visible = false;
                }

                
            }
        }
    }
}
