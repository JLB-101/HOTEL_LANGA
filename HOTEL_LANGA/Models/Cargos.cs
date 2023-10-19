using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOTEL_LANGA.Models
{
    public class Cargos
    {
        public int Id { get; set; }

        public string NomeCargo { get; set; }

        public  string Departamento { get; set; }

        public  string Status { get; set; }

        public Cargos()
        {

        }
    }
}