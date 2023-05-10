using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary_GT_RT
{
    public class ResultadoCorrida
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_ResultadoCorrida { get; set; }

        public bool IsDeleted { get; set; }

        public int? Id_piloto { get; set; }

        public int? Id_corrida { get; set; }

        public TimeSpan? Tempo_total { get; set; }

        public int? Pontos { get; set; }

        public int? PosicaoFinal { get; set; }

        public int? Id_Posicao { get; set; }
    }
}
