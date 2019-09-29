using MyClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public int IdClinica { get; set; }
        public EPapel Papel { get; private set; }
        public string CRM { get; set; }
        public string Sexo { get; set; }
        public string Permissoes { get; private set; }
        public double? PercentualRepasseClinica { get; private set; }
        public DateTime? dataLimiteSolicitacaoSenha { get; set; }
        public string ChaveSolicitacaoSenha { get; set; }

        public void ConfigurarPermissao(EPapel papel, string permissao)
        {
            this.Papel = papel;
            if (this.Papel == EPapel.Administrador)
                this.Permissoes = "#ADM#";

            this.Permissoes = permissao;
        }

        public void ConfigurarPercentualRepasseClinica(double? percentual)
        {
            if (percentual.HasValue && percentual.Value >= 0)
                this.PercentualRepasseClinica = percentual;
        }
    }
}
