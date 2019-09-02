using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebol.Dados.Api.DTOs
{
    public class JogoDTO
    {
        public int Ano { get; set; }
        public int Rodada { get; set; }                
        public string DiaDaSemana { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public int Numero { get; set; }
        public string TimeMandante { get; set; }
        public string TimeVisitante { get; set; }
        public string GolsMandante { get; set; }
        public string GolsVisitante { get; set; }
        public string Estadio { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
