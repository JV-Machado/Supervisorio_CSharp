using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace ProjetoAV3_Redes_SDCD
{
    public static class Program
    {
        public static string Usuario;
        public static bool Ligar_Processo;
        public static bool EmergenciaB;
        public static bool Reset_Contagem;
        public static bool Processo_Ligado;
        public static bool BombaTanque_1;
        public static bool CompressorTanque_1;
        public static bool ValvulaAlivioTanque_1;
        public static bool SprinklerTanque_1;
        public static int Nivel_Tanque1;
        public static double Pressao_Tanque1;
        public static double Temperatura_Tanque1;
        public static bool BombaTanque_2;
        public static bool CompressorTanque_2;
        public static bool ValvulaAlivioTanque_2;
        public static bool SprinklerTanque_2;
        public static bool BombaTanque_3;
        public static bool CompressorTanque_3;
        public static bool ValvulaAlivioTanque_3;
        public static bool SprinklerTanque_3;
        public static int Nivel_Tanque2;
        public static double Pressao_Tanque2;
        public static double Temperatura_Tanque2;
        public static int Nivel_Tanque3;
        public static double Pressao_Tanque3;
        public static double Temperatura_Tanque3;       
        public static bool SensorBotijao_1;
        public static bool SensorBotijao_2;
        public static bool SensorBotijao_3;
        public static bool SensorBotijao_4;
        public static bool SensorBotijao_5;
        public static bool SensorBotijao_6;
        public static bool Esteira_1;
        public static bool Esteira_2;
        public static bool Esteira_3;
        public static bool Esteira_4;
        public static bool Esteira_5;
        public static bool Esteira_6;
        public static bool Atuador_1;
        public static bool Atuador_2;
        public static bool Atuador_3;
        public static bool Atuador_4;
        public static bool Atuador_5;
        public static bool Atuador_6;
        public static short ContagemTotal_Carrossel;
        public static short ContagemEntrada_Carrossel;
        public static bool EsteiraLiberar_Botijao;
        public static bool AtuadorCorrige_Botijao;
        public static bool Sensor_Botijao;
        public static double Pesagem_Botijao;
        public static bool SensorInicio_Pintura;
        public static bool SensorFim_Pintura;
        public static bool Pintura_1;
        public static bool Pintura_2;
        public static bool Pintura_3;
        public static bool Pintura_4;
        public static bool Pintura_5;
        public static bool Pintura_6;
        public static short ContagemInicio_Pintura;
        public static short ContagemTotalSensorFim_Pintura;
        public static short ContagemFim_Pintura;
        public static Plc clp = new Plc(CpuType.S71200, "172.19.10.83", 0, 1);
     
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
