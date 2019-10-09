using FluentValidator;
using MyClinic.Domain.Interfaces.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.ValuesObjects
{
    public class CNPJ : ISelfValidator
    {
        public CNPJ(string documentNumber)
        {
            this.DocumentNumber = documentNumber;
            this.Validate();
        }

        public string DocumentNumber { get; private set; }

        public bool Validate()
        {
            if (this.DocumentNumber.Length != 14)
                throw new Exception("O Número do CNPJ deve possuir 14 dígitos");

            return true;
        }
    }
}
