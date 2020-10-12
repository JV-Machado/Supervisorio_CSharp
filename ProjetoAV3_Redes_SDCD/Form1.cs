using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace ProjetoAV3_Redes_SDCD
{
    public partial class Form1 : Form
    {
        VariaveisCLP VarCLP = new VariaveisCLP();
        int flag = 0;
        int flag2 = 0;
        int flag3 = 0;
        public Form1()
        {
            InitializeComponent();
            if(Program.Usuario == "Usuario1")
            {
                pictureBox1.Image = Image.FromFile("Usuario1.png");
                LBL_Nome_Usuario.Text = "Usuario 1";
            }
            if(Program.Usuario == "Usuario2")
            {
                pictureBox1.Image = Image.FromFile("Usuario2.png");
                LBL_Nome_Usuario.Text = "Usuario 2";
            }
            if(Program.Usuario == "Usuario3")
            {
                pictureBox1.Image = Image.FromFile("Usuario3.png");
                LBL_Nome_Usuario.Text = "Usuario 3";
            }
        }


        private void BTN_Tela_Carrossel_Click(object sender, EventArgs e)
        {
           
            if (Program.Usuario == "Usuario1" || Program.Usuario == "Usuario3")
            {
                carrossel1.Visible = true;
                correcao1.Visible = false;
                pintura1.Visible = false;
                visaoGeralEsteiras1.Visible = false;
                tanque11.Visible = false;
                tanque21.Visible = false;
                tanque31.Visible = false;
                visaoGeralTanques1.Visible = false;
            }
            else
            {
                carrossel1.Visible = false;
                MessageBox.Show("Usuário não possui permissão");
            }
            
        }

        private void BTN_Tela_Correcao_Click(object sender, EventArgs e)
        {
          

            if (Program.Usuario == "Usuario1" || Program.Usuario == "Usuario3")
            {
                
                carrossel1.Visible = false;
                correcao1.Visible = true;
                pintura1.Visible = false;
                visaoGeralEsteiras1.Visible = false;
                tanque11.Visible = false;
                tanque21.Visible = false;
                tanque31.Visible = false;
                visaoGeralTanques1.Visible = false;
            }
            else
            {
                correcao1.Visible = false;
                MessageBox.Show("Usuário não possui permissão");
            }
            
        }

        private void BTN_Tela_Pintura_Click(object sender, EventArgs e)
        {
         
            if (Program.Usuario == "Usuario1" || Program.Usuario == "Usuario3")
            {
                carrossel1.Visible = false;
                correcao1.Visible = false;
                pintura1.Visible = true;
                visaoGeralEsteiras1.Visible = false;
                tanque11.Visible = false;
                tanque21.Visible = false;
                tanque31.Visible = false;
                visaoGeralTanques1.Visible = false;
            }
            else
            {
                pintura1.Visible = false;
                MessageBox.Show("Usuário não possui permissão");
            }
        }


        private void BTN_VisaoGeralEsteiras_Click(object sender, EventArgs e)
        {
            carrossel1.Visible = false;
            correcao1.Visible = false;
            pintura1.Visible = false;
            visaoGeralEsteiras1.Visible = true;
            tanque11.Visible = false;
            tanque21.Visible = false;
            tanque31.Visible = false;
            visaoGeralTanques1.Visible = false;
        }

        private void BTN_Tela_Tanque1_Click(object sender, EventArgs e)
        {
            
            if (Program.Usuario == "Usuario1" || Program.Usuario == "Usuario2")
            {
                carrossel1.Visible = false;
                correcao1.Visible = false;
                pintura1.Visible = false;
                visaoGeralEsteiras1.Visible = false;
                tanque11.Visible = true;
                tanque21.Visible = false;
                tanque31.Visible = false;
                visaoGeralTanques1.Visible = false;
            }
            else
            {
                tanque11.Visible = false;
                MessageBox.Show("Usuário não possui permissão");
            }
        }

        private void BTN_Tela_Tanque2_Click(object sender, EventArgs e)
        {
           
            if (Program.Usuario == "Usuario1" || Program.Usuario == "Usuario2")
            {
                carrossel1.Visible = false;
                correcao1.Visible = false;
                pintura1.Visible = false;
                visaoGeralEsteiras1.Visible = false;
                tanque11.Visible = false;
                tanque21.Visible = true;
                tanque31.Visible = false;
                visaoGeralTanques1.Visible = false;
            }
            else
            {
                tanque21.Visible = false;
                MessageBox.Show("Usuário não possui permissão");
            }
        }

        private void BTN_Tela_Tanque3_Click(object sender, EventArgs e)
        {
         
            if (Program.Usuario == "Usuario1" || Program.Usuario == "Usuario2")
            {
                carrossel1.Visible = false;
                correcao1.Visible = false;
                pintura1.Visible = false;
                visaoGeralEsteiras1.Visible = false;
                tanque11.Visible = false;
                tanque21.Visible = false;
                tanque31.Visible = true;
                visaoGeralTanques1.Visible = false;
            }
            else
            {
                tanque31.Visible = false;
                MessageBox.Show("Usuário não possui permissão");
            }
        }

        private void BTN_VisaoGeralTanques_Click(object sender, EventArgs e)
        {
       
            carrossel1.Visible = false;
            correcao1.Visible = false;
            pintura1.Visible = false;
            visaoGeralEsteiras1.Visible = false;
            tanque11.Visible = false;
            tanque21.Visible = false;
            tanque31.Visible = false;
            visaoGeralTanques1.Visible = true;
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Login Tela_Login = new Login();
            this.Hide();
            Tela_Login.ShowDialog();
        }

        private void Timer_Alarme_Tick(object sender, EventArgs e)
        {
            if(Program.clp.IsConnected)
            {               
                Program.clp.ReadClass(VarCLP, 3);
                ///////////////////////////CARROSSEL/////////////////////////////
                Program.Ligar_Processo = VarCLP.LigarProcesso;
                Program.EmergenciaB = VarCLP.Emergencia;
                Program.Reset_Contagem = VarCLP.ResetContagem;
                if (Program.Ligar_Processo == true)
                {
                    BTN_LigarProcesso.BackColor = Color.Green;
                }
                else
                {
                    BTN_LigarProcesso.BackColor = Color.Gray;
                }
                if(Program.EmergenciaB == true)
                {
                    BTN_Emergencia.BackColor = Color.Green;
                }
                else
                {
                    BTN_Emergencia.BackColor = Color.Red;
                }
                if(Program.Reset_Contagem == true)
                {
                    BTN_Reset.BackColor = Color.Yellow;
                }
                else
                {
                    BTN_Reset.BackColor = Color.Gray;
                }
                Program.Processo_Ligado = VarCLP.ProcessoLigado;
                if(Program.Processo_Ligado == true)
                {
                    PB_ProcessoLigado.Visible = true;
                }
                else
                {
                    PB_ProcessoLigado.Visible = false;
                }
                Program.SensorBotijao_1 = VarCLP.SensorBotijao1;
                Program.SensorBotijao_2 = VarCLP.SensorBotijao2;
                Program.SensorBotijao_3 = VarCLP.SensorBotijao3;
                Program.SensorBotijao_4 = VarCLP.SensorBotijao4;
                Program.SensorBotijao_5 = VarCLP.SensorBotijao5;
                Program.SensorBotijao_6 = VarCLP.SensorBotijao6;
                Program.Esteira_1 = VarCLP.Esteira1;
                Program.Esteira_2 = VarCLP.Esteira2;
                Program.Esteira_3 = VarCLP.Esteira3;
                Program.Esteira_4 = VarCLP.Esteira4;
                Program.Esteira_5 = VarCLP.Esteira5;
                Program.Esteira_6 = VarCLP.Esteira6;
                Program.Atuador_1 = VarCLP.Atuador1;
                Program.Atuador_2 = VarCLP.Atuador2;
                Program.Atuador_3 = VarCLP.Atuador3;
                Program.Atuador_4 = VarCLP.Atuador4;
                Program.Atuador_5 = VarCLP.Atuador5;
                Program.Atuador_6 = VarCLP.Atuador6;
                Program.ContagemEntrada_Carrossel = VarCLP.ContagemEntradaCarrossel;
                Program.ContagemTotal_Carrossel = VarCLP.ContagemTotalCarrossel;

                ////////////////////////////CORREÇÃO//////////////////////////////
                Program.EsteiraLiberar_Botijao = VarCLP.EsteiraLiberarBotijao;
                Program.AtuadorCorrige_Botijao = VarCLP.Atuador_Corrige;
                Program.Sensor_Botijao = VarCLP.SensorBotijao;
                Program.Pesagem_Botijao = VarCLP.PesagemBotijao;

                ////////////////////////////PINTURA///////////////////////////////
                Program.SensorInicio_Pintura = VarCLP.SensorInicioPintura;
                Program.SensorFim_Pintura = VarCLP.SensorFimPintura;
                Program.Pintura_1 = VarCLP.Pintura1;
                Program.Pintura_2 = VarCLP.Pintura2;
                Program.Pintura_3 = VarCLP.Pintura3;
                Program.Pintura_4 = VarCLP.Pintura4;
                Program.Pintura_5 = VarCLP.Pintura5;
                Program.Pintura_6 = VarCLP.Pintura6;
                Program.ContagemInicio_Pintura = VarCLP.ContagemInicioPintura;
                Program.ContagemTotalSensorFim_Pintura = VarCLP.ContagemTotalFimPintura;
                Program.ContagemFim_Pintura = VarCLP.ContagemFimPintura;

                ////////////////////////////TANQUE 1//////////////////////////////
                Program.Nivel_Tanque1 = VarCLP.NivelTanque1;
                Program.Pressao_Tanque1 = VarCLP.PressaoTanque1;
                Program.Temperatura_Tanque1 = VarCLP.TemperaturaTanque1;
                Program.BombaTanque_1 = VarCLP.BombaTanque1;
                Program.CompressorTanque_1 = VarCLP.CompressorTanque1;
                Program.ValvulaAlivioTanque_1 = VarCLP.ValvulaAlivioTanque1;
                Program.SprinklerTanque_1 = VarCLP.SprinklerTanque1;
                ////////////////////////////TANQUE 2//////////////////////////////
                Program.Nivel_Tanque2 = VarCLP.NivelTanque2;
                Program.Pressao_Tanque2 = VarCLP.PressaoTanque2;
                Program.Temperatura_Tanque2 = VarCLP.TemperaturaTanque2;
                Program.BombaTanque_2 = VarCLP.BombaTanque2;
                Program.CompressorTanque_2 = VarCLP.CompressorTanque2;
                Program.ValvulaAlivioTanque_2 = VarCLP.ValvulaAlivioTanque2;
                Program.SprinklerTanque_2 = VarCLP.SprinklerTanque2;
                ////////////////////////////TANQUE 3//////////////////////////////
                Program.Nivel_Tanque3 = VarCLP.NivelTanque3;
                Program.Pressao_Tanque3 = VarCLP.PressaoTanque3;
                Program.Temperatura_Tanque3 = VarCLP.TemperaturaTanque3;
                Program.BombaTanque_3 = VarCLP.BombaTanque3;
                Program.CompressorTanque_3 = VarCLP.CompressorTanque3;
                Program.ValvulaAlivioTanque_3 = VarCLP.ValvulaAlivioTanque3;
                Program.SprinklerTanque_3 = VarCLP.SprinklerTanque3;
                ////////////////////////////ALARMES///////////////////////////////
                //Pesagem
                if(Program.Sensor_Botijao == true)
                {
                    if (Program.Pesagem_Botijao < 2)
                    {
                        PB_AlarmeInferior.Visible = true;
                        PB_AlarmeSuperior.Visible = false;
                    }
                    else if (Program.Pesagem_Botijao >= 2 && Program.Pesagem_Botijao <= 5)
                    {
                        PB_AlarmeInferior.Visible = false;
                        PB_AlarmeSuperior.Visible = false;
                    }
                    else if (Program.Pesagem_Botijao > 5)
                    {
                        PB_AlarmeInferior.Visible = false;
                        PB_AlarmeSuperior.Visible = true;
                    }
                }
                else
                {
                    PB_AlarmeInferior.Visible = false;
                    PB_AlarmeSuperior.Visible = false;
                }
                

                ////////////////////////TANQUE 1///////////////////////
                //Nível 1
                if(Program.Nivel_Tanque1 > 255)
                {
                    PB_NivelAlto1.Visible = true;
                }
                else if(Program.Nivel_Tanque1 <= 255)
                {
                    PB_NivelAlto1.Visible = false;
                }

                //Pressão 1
               
                if(Program.Pressao_Tanque1 < 17.5)
                {
                    PB_PressaoAlta1.Visible = false;
                }
                else if(Program.Pressao_Tanque1 >= 17.5)
                {
                    PB_PressaoAlta1.Visible = true;
                }

                //Temperatura 1
                if (Program.Temperatura_Tanque1 > 50)
                {
                    PB_TemperaturaAlta1.Visible = true;
                }
                else if (Program.Temperatura_Tanque1 <= 50)
                {
                    PB_TemperaturaAlta1.Visible = false;
                }

                ///////////////////////TANQUE 2//////////////////////
                //Nível 2
                if(Program.Nivel_Tanque2 > 255)
                {
                    PB_NivelAlto2.Visible = true;
                }
                else if(Program.Nivel_Tanque2 <= 255)
                {
                    PB_NivelAlto2.Visible = false;
                }

                //Pressão 2
               
                if(Program.Pressao_Tanque2 < 17.5)
                {
                    PB_PressaoAlta2.Visible = false;
                }
                else if(Program.Pressao_Tanque2 >= 17.5)
                {
                    PB_TemperaturaAlta2.Visible = true;
                }

                //Temperatura 2
                if(Program.Temperatura_Tanque2 > 50)
                {
                    PB_TemperaturaAlta2.Visible = true;
                }
                else if(Program.Temperatura_Tanque2 <= 50)
                {
                    PB_TemperaturaAlta2.Visible = false;
                }

                ////////////////////TANQUE 3/////////////////////
                //Nível 3
                if(Program.Nivel_Tanque3 > 255)
                {
                    PB_NivelAlto3.Visible = true;
                }
                else if(Program.Nivel_Tanque3 <= 255)
                {
                    PB_NivelAlto3.Visible = false;
                }

                //Pressão 3
               
                if(Program.Pressao_Tanque3 < 17.5)
                {
                    PB_PressaoAlta3.Visible = false;
                }
                else if(Program.Pressao_Tanque3 >= 17.5)
                {
                    PB_PressaoAlta3.Visible = true;
                }

                //Temperatura 3
                if(Program.Temperatura_Tanque3 > 50)
                {
                    PB_TemperaturaAlta3.Visible = true;
                }
                else if(Program.Temperatura_Tanque3 <= 50)
                {
                    PB_TemperaturaAlta3.Visible = false;
                }
                
            }
        }

        private void BTN_LigarProcesso_Click(object sender, EventArgs e)
        {
            if (Program.clp.IsConnected)
            {
                //Liga Processo
                if (flag == 0)
                {
                    Program.clp.Write("DB3.DBX0.0", true);
                    flag = 1;
                }
                else if (flag == 1)
                {
                    Program.clp.Write("DB3.DBX0.0", false);
                    flag = 0;
                }
            }
        }

        private void BTN_Emergencia_Click(object sender, EventArgs e)
        {
            if(Program.clp.IsConnected)
            {
                if (flag2 == 0)
                {
                    Program.clp.Write("DB3.DBX0.1", false);
                    flag2 = 1;
                }
                else if (flag2 == 1)
                {
                    Program.clp.Write("DB3.DBX0.1", true);
                    flag2 = 0;
                }
            }            
        }

        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            if(Program.clp.IsConnected)
            {
                if (flag3 == 0)
                {
                    Program.clp.Write("DB3.DBX0.2", false);
                    flag3 = 1;
                }
                else if (flag3 == 1)
                {
                    Program.clp.Write("DB3.DBX0.2", true);
                    flag3 = 0;
                }
            }          
        }

        private void BTN_Graficos_Click(object sender, EventArgs e)
        {
            Graficos Tela_Graficos = new Graficos();
            Tela_Graficos.ShowDialog();
        }
    }
}
