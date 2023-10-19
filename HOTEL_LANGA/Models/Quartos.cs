using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOTEL_LANGA.Models
{
    public class Quartos
    {
        public int id { get; set; }

        public  string numeroQuarto { get; set; }

        public string tipoQuarto { get; set; }

        public string tipoCama { get; set; }

        public string status { get; set; }

        Quartos()
        {

        }

    }
}