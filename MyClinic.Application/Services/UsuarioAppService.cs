using MyClinic.Application.Interfaces;
using MyClinic.Domain.Entities;
using MyClinic.Domain.Enums;
using MyClinic.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Application.Services
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioAppService(IUsuarioService usuarioService) : base(usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        public Usuario GetByChaveSolicitacaoSenha(string chaveSolicitacaoSenha)
        {
            return this._usuarioService.GetByChaveSolicitacaoSenha(chaveSolicitacaoSenha);
        }

        public IEnumerable<Usuario> GetByClinica(int idClinica)
        {
            return this._usuarioService.GetByClinica(idClinica);
        }

        public Usuario GetByEmail(string email)
        {
            return this._usuarioService.GetByEmail(email);
        }

        public IEnumerable<Usuario> GetByFuncao(EPapel funcao)
        {
            return this._usuarioService.GetByFuncao(funcao);
        }

        public Usuario GetByLoginSenha(string login, string senha)
        {
            return this._usuarioService.GetByLoginSenha(login, senha);
        }

        public void UpdateNovaSenha(Usuario usuario)
        {
            this._usuarioService.UpdateNovaSenha(usuario);
        }
    }
}
