using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GT_RT
{
    public class ClassificacaoGeral
    {
        #region prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Pontuacao { get; set; }
        public int? Classificacao { get; set; }
        public bool IsDeleted { get; set; }

        public List<Resultado>? Resultados { get; set; }
        #endregion
    }
}
