using System;

namespace Projeto.Models
{
    public class AgendamentoViewModel
    {
        private const string Format = @"dd/MM/yyyy";

        public AgendamentoModel agendamento { get; set; }

        public String NomeFormatado
        {
            get { return agendamento.Nome + " " + agendamento.SobreNome; }
        }
        public bool AceitarTermo
        {
            get { return agendamento.GridCheck == true ? true : false; }
        }
        public String MascaraCpf
        {
            get { return Convert.ToUInt64(agendamento.CPF).ToString(@"000\.000\.000\-00"); }
        }
        public String FormatarData
        {
            get { return Convert.ToDateTime(agendamento.DataSugerida).ToString(Format); }
        }


    }

}