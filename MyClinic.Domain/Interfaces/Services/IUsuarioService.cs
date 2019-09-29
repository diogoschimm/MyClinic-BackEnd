using MyClinic.Domain.Entities;
using MyClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        IEnumerable<Usuario> GetByClinica(int idClinica);
        IEnumerable<Usuario> GetByFuncao(EPapel funcao);
        Usuario GetByLoginSenha(string login, string senha);
        Usuario GetByEmail(string email);
        Usuario GetByChaveSolicitacaoSenha(string chaveSolicitacaoSenha);
        void UpdateNovaSenha(Usuario usuario);
    }
}
