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
    public partial class Pintura : UserControl
    {
       
        public Pintura()
        {
            InitializeComponent();
        }

        private void Timer_Pintura_Tick(object sender, EventArgs e)
        {          
            if(Program.clp.IsConnected)
            {              
                TB_ContagemInicioPintura.Text = Program.ContagemInicio_Pintura.ToString();
                
                TB_ContagemFimPintura.Text = Program.ContagemTotalSensorFim_Pintura.ToString();
                
                if (Program.Pintura_1 == true)
                {
                    PB_Pintura1.Visible = true;
                }
                else if(Program.Pintura_1 == false)
                {
                    PB_Pintura1.Visible = false;
                }

                if (Program.Pintura_2 == true)
                {
                    PB_Pintura2.Visible = true;
                }
                else if (Program.Pintura_2 == false)
                {
                    PB_Pintura2.Visible = false;
                }

                if (Program.Pintura_3 == true)
                {
                    PB_Pintura3.Visible = true;
                }
                else if (Program.Pintura_3 == false)
                {
                    PB_Pintura3.Visible = false;
                }

                if (Program.Pintura_4 == true)
                {
                    PB_Pintura4.Visible = true;
                }
                else if (Program.Pintura_4 == false)
                {
                    PB_Pintura4.Visible = false;
                }

                if (Program.Pintura_5 == true)
                {
                    PB_Pintura5.Visible = true;
                }
                else if (Program.Pintura_5 == false)
                {
                    PB_Pintura5.Visible = false;
                }

                if (Program.Pintura_6 == true)
                {
                    PB_Pintura6.Visible = true;
                }
                else if (Program.Pintura_6 == false)
                {
                    PB_Pintura6.Visible = false;
                }

                PB_Botijao1.Visible = false;
                PB_Botijao2.Visible = false;
                PB_Botijao3.Visible = false;

                if (Program.ContagemFim_Pintura == 0)
                {
                    PB_Botijao1.Visible = false;
                    PB_Botijao2.Visible = false;
                    PB_Botijao3.Visible = false;
                }
                else if(Program.ContagemFim_Pintura == 1)
                {
                    PB_Botijao1.Visible = true;
                    PB_Botijao2.Visible = false;
                    PB_Botijao3.Visible = false;
                }
                else if(Program.ContagemFim_Pintura == 2)
                {
                    PB_Botijao1.Visible = true;
                    PB_Botijao2.Visible = true;
                    PB_Botijao3.Visible = false;
                }
                
                 if(Program.ContagemFim_Pintura == 3)
                {
                    PB_Botijao1.Visible = true;
                    PB_Botijao2.Visible = true;
                    PB_Botijao3.Visible = true;
                }

                
                if (Program.SensorInicio_Pintura == true)
                {
                    PB_BotijaoInicio.Visible = true;
                    PB_SensorEntrada.Visible = true;
                }
                else if(Program.SensorInicio_Pintura == false)
                {
                    PB_BotijaoInicio.Visible = false;
                    PB_SensorEntrada.Visible = false;
                }
                
                if(Program.SensorFim_Pintura == true)
                {
                    PB_SensorSaida.Visible = true;
                }
                else if(Program.SensorFim_Pintura == false)
                {
                    PB_SensorSaida.Visible = false;
                }
                
            }
        }
    }
}
