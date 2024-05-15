using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Personeelslid
    {
        public int PersoneelsNr { get; set; }
        public string Voornaam { get; set; }
        public ICollection<Personeelslid> Personeel { get; set; } = new List<Personeelslid>();

        [InverseProperty("Personeel")]
        [ForeignKey ("ManagerNr")]
        public Personeelslid? Manager { get; set; }
        public int? ManagerNr { get; set; }
    }
}
