using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GT_RT
{
    public class Corrida
    {
        #region Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_corrida { get; set; }

        public string? Nome_Corrida { get; set; }
        public bool IsDeleted { get; set; }
        public string? Circuito { get; set; }

        public DateTime? Data { get; set; }
        public int? Id_competicao { get; set; }
        public string? CarrosPermitidos { get; set; }
        public string? Tipo_Pneus { get; set; }
        public int? NumeroVoltas { get; set; }
        public int? NumeroMinutos { get; set; }
        public int? Id_Resultado { get; set; } 
        [ForeignKey("Id_Resultado")]
        public Resultado? Resultado { get; set; }
        
        #endregion
    }
}
