using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GT_RT
{
    public class Competicao
    {
        #region Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Nome { get; set; }
        public bool IsDeleted { get; set; }
        public string? Descricao { get; set; }
        public int? Id_Piloto_Categoria { get; set; }
        public byte[]? Foto { get; set; }
        public string Nome_Categoria { get; set; }


        #endregion
    }
}
