﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class State
    {
        public int Id { get; set; }


        [Display(Name = "Departamento/Estado")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; } = null!;

        public Country? Country { get; set; }

        public ICollection <City>? Cities { get; set;}

        [Display(Name ="Ciudades")]
        public int CitiesCount => Cities == null ? 0 : Cities.Count;

        public int CountryId { get; set; }

    }
}
