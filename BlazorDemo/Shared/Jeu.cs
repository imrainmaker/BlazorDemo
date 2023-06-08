using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared
{
    public class Jeu
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public DateTime DatedeSortie { get; set; }
        [Range(0, 5)]
        public int Note { get; set; }
    }
}
