using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_01
{
    public class Manager : Person
    {
        public DateTime HireDate { get; set; }
        public string? Department { get; set; }
    }
}