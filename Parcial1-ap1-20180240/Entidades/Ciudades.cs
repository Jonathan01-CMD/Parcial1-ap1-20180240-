﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial1_ap1_20180240.Entidades
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }
    }
}
