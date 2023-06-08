using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.Shared
{
    public class Quiz
    {
        public int id {  get; set; }
        public string Question { get; set; }
        public bool Reponse { get; set; }
        public string Explication { get; set; }

    }
}
