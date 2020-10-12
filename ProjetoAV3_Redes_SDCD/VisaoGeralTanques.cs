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
    public partial class VisaoGeralTanques : UserControl
    {
        public VisaoGeralTanques()
        {
            InitializeComponent();
        }

        private void Timer_Geral_Tanques_Tick(object sender, EventArgs e)
        {
            if(Program.clp.IsConnected)
            {
                VerticalPB_Tanque1G.Value = Program.Nivel_Tanque1;
                TB_NivelTanque1G.Text = Program.Nivel_Tanque1.ToString();
                TB_PressaoTanque1G.Text = Program.Pressao_Tanque1.ToString("0.00");
                TB_TemperaturaTanque1G.Text = Program.Temperatura_Tanque1.ToString("0.00");

                VerticalPB_Tanque2G.Value = Program.Nivel_Tanque2;
                TB_NivelTanque2G.Text = Program.Nivel_Tanque2.ToString();
                TB_PressaoTanque2G.Text = Program.Pressao_Tanque2.ToString("0.00");
                TB_TemperaturaTanque2G.Text = Program.Temperatura_Tanque2.ToString("0.00");

                VerticalPB_Tanque3G.Value = Program.Nivel_Tanque3;
                TB_NivelTanque3G.Text = Program.Nivel_Tanque3.ToString();
                TB_PressaoTanque3G.Text = Program.Pressao_Tanque3.ToString("0.00");
                TB_TemperaturaTanque3G.Text = Program.Temperatura_Tanque3.ToString("0.00");

            }

        }
    }
}
