﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Klant
    {
        public int KlantNr { get; set; }
        public string Voornaam { get; set; }
        public ICollection<Rekening> Rekeningen { get; set; } = new List<Rekening>();
    }
}
