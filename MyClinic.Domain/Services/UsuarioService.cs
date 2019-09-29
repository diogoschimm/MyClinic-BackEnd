using MyClinic.Domain.Entities;
using MyClinic.Domain.Enums;
using MyClinic.Domain.Interfaces.Repositories;
using MyClinic.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }

        public Usuario GetByChaveSolicitacaoSenha(string chaveSolicitacaoSenha)
        {
            return this._usuarioRepository.GetByChaveSolicitacaoSenha(chaveSolicitacaoSenha);
        }

        public IEnumerable<Usuario> GetByClinica(int idClinica)
        {
            return this._usuarioRepository.GetByClinica(idClinica);
        }

        public Usuario GetByEmail(string email)
        {
            return this._usuarioRepository.GetByEmail(email);
        }

        public IEnumerable<Usuario> GetByFuncao(EPapel funcao)
        {
            return this._usuarioRepository.GetByFuncao(funcao);
        }

        public Usuario GetByLoginSenha(string login, string senha)
        {
            return this._usuarioRepository.GetByLoginSenha(login, senha);
        }

        public void UpdateNovaSenha(Usuario usuario)
        {
            this._usuarioRepository.UpdateNovaSenha(usuario);
        }
    }
}
