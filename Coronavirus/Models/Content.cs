using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus.Models
{
    public class Content
    {
        public int updated { get; set; } // TimeStamp data da atualização
        public int cases { get; set; } // total de casos
        public int deaths { get; set; } // total de mortos
        public int recovered { get; set; } // total de recuperados

        public int active { get; set; } // ativos
        public int critical { get; set; } // casos críticos

        public int tests { get; set; } // total de teste?

        public int population { get; set; } // total população
    }
}