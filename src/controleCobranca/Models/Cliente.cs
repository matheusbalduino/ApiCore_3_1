using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleCobranca.Models
{
    public class Cliente
    {
        public int indice { get; set; }
        public int cdContrato { get; set; }
        public int nrTermo { get; set; }
        public int lote { get; set; }
        public string destinatario { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string obs { get; set; }
        public string registroPlano { get; set; }
        public DateTime dataEnvio { get; set; }
        public string titulo { get; set; }
        public DateTime vencimento { get; set; }
        public decimal valor { get; set; }
    }
}
