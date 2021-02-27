using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus.Models
{
    public class Content
    {
        public long Updated { get; set; } // TimeStamp data da atualização
        public int Cases { get; set; } // total de casos

        public int Deaths { get; set; } // total de mortos
        public int Recovered { get; set; } // total de recuperados

        public int Active { get; set; } // ativos
        public int Critical { get; set; } // casos críticos

        public int Tests { get; set; } // total de teste?

        public long Population { get; set; } // total população
    }
}