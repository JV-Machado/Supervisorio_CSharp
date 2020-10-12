using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace ProjetoAV3_Redes_SDCD
{
    class VariaveisCLP
    {
        //Inicio do Processo//
        public bool LigarProcesso { get; set; }
        public bool Emergencia { get; set; }
        public bool ResetContagem { get; set; }
        public bool ProcessoLigado { get; set; }
        //Leitura Tela Carrossel//
        public bool SensorBotijao1 { get; set; }
        public bool SensorBotijao2 { get; set; }
        public bool SensorBotijao3 { get; set; }
        public bool SensorBotijao4 { get; set; }
        public bool SensorBotijao5 { get; set; }
        public bool SensorBotijao6 { get; set; }

        public bool Esteira1 { get; set; }
        public bool Esteira2 { get; set; }
        public bool Esteira3 { get; set; }
        public bool Esteira4 { get; set; }
        public bool Esteira5 { get; set; }
        public bool Esteira6 { get; set; }

        public bool Atuador1 { get; set; }
        public bool Atuador2 { get; set; }
        public bool Atuador3 { get; set; }
        public bool Atuador4 { get; set; }
        public bool Atuador5 { get; set; }
        public bool Atuador6 { get; set; }

        public short ContagemEntradaCarrossel { get; set; }
        public short ContagemTotalCarrossel { get; set; }

        //Leitura Tela Correção//
        public bool EsteiraLiberarBotijao { get; set; }
        public bool Atuador_Corrige { get; set; }
        public bool SensorBotijao { get; set; }
        public double PesagemBotijao { get; set; }

        //Leitura Tela Pintura//
        public short ContagemInicioPintura { get; set; }
        public short ContagemTotalFimPintura { get; set; }
        public bool SensorInicioPintura { get; set; }
        public bool SensorFimPintura { get; set; }
        public bool Pintura1 { get; set; }
        public bool Pintura2 { get; set; }
        public bool Pintura3 { get; set; }
        public bool Pintura4 { get; set; }
        public bool Pintura5 { get; set; }
        public bool Pintura6 { get; set; }
        public short ContagemFimPintura { get; set; }

        //Leitura Tela Tanque 1//
        public int NivelTanque1 { get; set; }
        public double PressaoTanque1 { get; set; }
        public double TemperaturaTanque1 { get; set; }
        public bool BombaTanque1 { get; set; }
        public bool CompressorTanque1 { get; set; }
        public bool ValvulaAlivioTanque1 { get; set; }
        public bool SprinklerTanque1 { get; set; }

        //Leitura Tela Tanque 2//
        public int NivelTanque2 { get; set; }
        public double PressaoTanque2 { get; set; }
        public double TemperaturaTanque2 { get; set; }
        public bool BombaTanque2 { get; set; }
        public bool CompressorTanque2 { get; set; }
        public bool ValvulaAlivioTanque2 { get; set; }
        public bool SprinklerTanque2 { get; set; }

        //Leitura Tela Tanque 3//
        public int NivelTanque3 { get; set; }
        public double PressaoTanque3 { get; set; }
        public double TemperaturaTanque3 { get; set; }
        public bool BombaTanque3 { get; set; }
        public bool CompressorTanque3 { get; set; }
        public bool ValvulaAlivioTanque3 { get; set; }
        public bool SprinklerTanque3 { get; set; }
    }
}
