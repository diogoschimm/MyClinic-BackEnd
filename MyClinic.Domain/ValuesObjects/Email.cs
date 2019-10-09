using FluentValidator;
using MyClinic.Domain.Interfaces.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.ValuesObjects
{
    public class Email : Notifiable, ISelfValidator
    {
        public Email(string emailAddress)
        {
            this.EmailAddress = emailAddress;
            this.Validate();
        }

        public string EmailAddress { get; private set; }

        public bool Validate()
        {
            if (!this.EmailAddress.Contains("@"))
                this.AddNotification("EmailAddress", "E-mail inválido");

            return this.Notifications.Count == 0;
        }
    }
}
