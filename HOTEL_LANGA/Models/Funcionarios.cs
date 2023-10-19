using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOTEL_LANGA.Models
{
    public class Funcionarios
    {
       
        public  int Id { get; set; }

        public string Nome { get; set; }

        public  string Sexo { get; set; }

        public  string Senha { get; set; }

        public  string Tell { get; set; }

        public  string Nacionalidade { get; set; }

        public  string Endereco { get; set; }

        public string Departamento { get; set; }

        public string Cargo { get; set; }

        public  string Status { get; set; }

        public Funcionarios()
        {

        }
    }
}