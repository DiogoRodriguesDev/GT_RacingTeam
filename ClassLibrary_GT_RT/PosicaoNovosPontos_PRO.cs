using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GT_RT
{
    public class PosicaoNovosPontos_PRO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id_Posicao { get; set; }
        public int? Numero_Posicao { get; set; }
        public int? Pontos_Da_Posicao { get; set; }
        public bool IsDeleted { get; set; }
    }
}

