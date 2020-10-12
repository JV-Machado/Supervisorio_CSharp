using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAV3_Redes_SDCD
{
    public partial class Graficos : Form
    {
        int x1 = 0;
        int x2 = 0;
        int x3 = 0;
        int x4 = 0;
        int x5 = 0;
        int x6 = 0;
        int x7 = 0;
        int x8 = 0;
        int x9 = 0;
        public Graficos()
        {
            InitializeComponent();
            ChartNivel_1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartNivel_2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartNivel_3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartPressao_1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartPressao_2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartPressao_3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartTemperatura_1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartTemperatura_2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            ChartTemperatura_3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            
        }

        private void Timer_Graficos_Tick(object sender, EventArgs e)
        {
            if (Program.clp.IsConnected)
            {
                if (ChartNivel_1.Series[0].Points.Count > 5)
                {
                    ChartNivel_1.Series[0].Points.RemoveAt(0);
                    ChartNivel_1.Update();
                }         
                ChartNivel_1.Series[0].Points.AddXY(x1++, Program.Nivel_Tanque1);

                if (ChartNivel_2.Series[0].Points.Count > 5)
                {
                    ChartNivel_2.Series[0].Points.RemoveAt(0);
                    ChartNivel_2.Update();
                }
                ChartNivel_2.Series[0].Points.AddXY(x2++, Program.Nivel_Tanque2);

                if (ChartNivel_3.Series[0].Points.Count > 5)
                {
                    ChartNivel_3.Series[0].Points.RemoveAt(0);
                    ChartNivel_3.Update();
                }
                ChartNivel_3.Series[0].Points.AddXY(x3++, Program.Nivel_Tanque3);

                if (ChartPressao_1.Series[0].Points.Count > 5)
                {
                    ChartPressao_1.Series[0].Points.RemoveAt(0);
                    ChartPressao_1.Update();
                }
                ChartPressao_1.Series[0].Points.AddXY(x4++, Program.Pressao_Tanque1);

                if (ChartPressao_2.Series[0].Points.Count > 5)
                {
                    ChartPressao_2.Series[0].Points.RemoveAt(0);
                    ChartPressao_2.Update();
                }
                ChartPressao_2.Series[0].Points.AddXY(x5++, Program.Pressao_Tanque2);

                if (ChartPressao_3.Series[0].Points.Count > 5)
                {
                    ChartPressao_3.Series[0].Points.RemoveAt(0);
                    ChartPressao_3.Update();
                }
                ChartPressao_3.Series[0].Points.AddXY(x6++, Program.Pressao_Tanque3);

                if (ChartTemperatura_1.Series[0].Points.Count > 5)
                {
                    ChartTemperatura_1.Series[0].Points.RemoveAt(0);
                    ChartTemperatura_1.Update();
                }
                ChartTemperatura_1.Series[0].Points.AddXY(x7++, Program.Temperatura_Tanque1);

                if (ChartTemperatura_2.Series[0].Points.Count > 5)
                {
                    ChartTemperatura_2.Series[0].Points.RemoveAt(0);
                    ChartTemperatura_2.Update();
                }
                ChartTemperatura_2.Series[0].Points.AddXY(x8++, Program.Temperatura_Tanque2);

                if (ChartTemperatura_3.Series[0].Points.Count > 5)
                {
                    ChartTemperatura_3.Series[0].Points.RemoveAt(0);
                    ChartTemperatura_3.Update();
                }
                ChartTemperatura_3.Series[0].Points.AddXY(x9++, Program.Temperatura_Tanque3);
            }
        }

        private void CB_3d_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.clp.IsConnected)
            {
                if (CB_Enable3D.Checked)
                {
                    ChartNivel_1.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartNivel_2.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartNivel_3.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartPressao_1.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartPressao_2.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartPressao_3.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartTemperatura_1.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartTemperatura_2.ChartAreas[0].Area3DStyle.Enable3D = true;
                    ChartTemperatura_3.ChartAreas[0].Area3DStyle.Enable3D = true;
                }
                else
                {
                    ChartNivel_1.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartNivel_2.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartNivel_3.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartPressao_1.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartPressao_2.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartPressao_3.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartTemperatura_1.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartTemperatura_2.ChartAreas[0].Area3DStyle.Enable3D = false;
                    ChartTemperatura_3.ChartAreas[0].Area3DStyle.Enable3D = false;
                }
            }
        }
    }
}
