﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.General
{
    [Table("LISTA_NOTAS", Schema ="dbo")]
    public partial class En_De_Lista_Notas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }


        [StringLength(100, ErrorMessage = "El campo [0] no puede tener mas de [1] caracteres", MinimumLength = 0)]
        [Required]
        [Display(Name = "NOMBRE")]

        public string NOMBRE { get; set; }

    }
}