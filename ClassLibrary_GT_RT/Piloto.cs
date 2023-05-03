﻿using System;
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
        public string? Nickname { get; set; }
        public string? Descricao { get; set; }
        public int? Id_Equipa { get; set; }
        public string? PaisRegiao { get; set; }
        public double Valor { get; set; } = 300;

        public List<Resultado>? Resultados { get; set; }
        #endregion

        #region ctor
        //public Piloto() { }

        //public Piloto(string nome, string nickname)
        //{
        //    Nome = nome;
        //    Nickname = nickname;
        //}
        #endregion
    }
}
