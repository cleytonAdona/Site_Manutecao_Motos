using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class AgendamentoModel
    {
        public string Nome {get;set;}
        public string SobreNome {get;set;}
        public string Email {get;set;}
        public string CPF {get;set;}
        public string Endereco {get;set;}
        public string Complemento {get;set;}
        public string Cidade {get;set;}
        public string UF {get;set;}
        public string Contato {get;set;}
        public bool GridCheck { get; set; }
        public string Servico { get; set; }
        public string DataSugerida { get; set; }
    }

}