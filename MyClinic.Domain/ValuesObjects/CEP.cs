using FluentValidator;
using MyClinic.Domain.Interfaces.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MyClinic.Domain.ValuesObjects
{
    public class CEP
    {
        public string Number { get; private set; }

        public CEP(string cep)
        {  
            if (this.Validate(cep))
                this.Number = cep;
        }

        private  bool Validate(string cepNumber)
        {
            if (!new Regex(@"[0-9]{5}-[\d]{3}").IsMatch(cepNumber))
                throw new Exception("CEP deve estar no formato #####-###");

            if (cepNumber.Length != 8)
                throw new Exception("CEP deve possuir 8 Dígitos");

            return true;
        }
    }
}
