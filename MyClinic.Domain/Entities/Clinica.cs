using MyClinic.Domain.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.Entities
{
    public class Clinica
    {
        public int IdClinica { get; set; }
        public string RazaoSocial { get; set; }
        public CNPJ CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public URL LinkPortal { get; set; }
        public Endereco Endereco { get; set; }

    }
}
