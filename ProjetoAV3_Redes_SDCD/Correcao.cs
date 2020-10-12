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
    public partial class Correcao : UserControl
    {
        public Correcao()
        {
            InitializeComponent();
        }

        private void Timer_Correcao_Tick(object sender, EventArgs e)
        {
            if(Program.clp.IsConnected)
            {

                TB_PesagemBotijao.Text = Program.Pesagem_Botijao.ToString("0.00");

                if (Program.AtuadorCorrige_Botijao == true)
                {
                    PB_Correcao.Visible = true;
                }
                else
                {
                    PB_Correcao.Visible = false;
                }

                if(Program.Sensor_Botijao == true)
                {
                    PB_SensorPesagem.Visible = true;
                    PB_IdentificaBotijao.Visible = true;
                }
                else
                {
                    PB_SensorPesagem.Visible = false;
                    PB_IdentificaBotijao.Visible = false;
                  //  TB_PesagemBotijao.Text = 0.ToString();
                }
                if(Program.EsteiraLiberar_Botijao == true)
                {
                    PB_EsteiraLiberacao.Visible = true;
                }
                else
                {
                    PB_EsteiraLiberacao.Visible = false;
                }

            }
            

        }
    }
}
