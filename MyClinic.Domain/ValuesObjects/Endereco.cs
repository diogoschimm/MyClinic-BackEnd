using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.ValuesObjects
{
    public class Endereco
    {
        public CEP CEP { get; private set; } 
        public string Logradouro { get; private set; }
        public string Numero { get;  private set; }
        public string Bairro { get; private set; }
        public Cidade Cidade { get; private set; }
    }
}
