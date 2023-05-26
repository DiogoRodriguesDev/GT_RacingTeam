using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GT_RT
{
    public class Piloto
    {
        #region Prop

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_piloto { get; set; }

        public bool IsDeleted { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Id_Equipa { get; set; } 
        public string PaisRegiao { get; set; } = string.Empty;
        public double Valor { get; set; } = 300;
        public byte[]? Foto { get; set; }

        public Equipa? Piloto_Equipa { get; set; } //VERIFICAR REMOÇÃO
        public  int? Id_Piloto_Categoria { get; set; } //VERIFICAR REMOÇÃO
        public Piloto_Categorias? Piloto_Categoria { get; set; } //VERIFICAR REMOÇÃO
        public bool? Inativo { get; set; }

        #endregion
    }
}
