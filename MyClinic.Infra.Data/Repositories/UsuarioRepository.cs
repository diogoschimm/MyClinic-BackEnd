using MyClinic.Domain.Entities;
using MyClinic.Domain.Enums;
using MyClinic.Domain.Interfaces.Repositories;
using MyClinic.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClinic.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MyClinicContext myClinicContext)
            : base(myClinicContext)
        {
        }

        public IEnumerable<Usuario> GetByClinica(int idClinica)
        {
            return this._myClinicContext.Usuarios.Where(u => u.IdClinica == idClinica);
        }

        public IEnumerable<Usuario> GetByFuncao(EPapel funcao)
        {
            return this._myClinicContext.Usuarios.Where(u => u.Papel == funcao);
        }

        public Usuario GetByLoginSenha(string login, string senha)
        {
            return this._myClinicContext.Usuarios.Where(u => u.EmailUsuario == login && u.SenhaUsuario == senha).FirstOrDefault();
        }

        public Usuario GetByEmail(string email)
        {
            return this._myClinicContext.Usuarios.Where(u => u.EmailUsuario == email).FirstOrDefault();
        }

        public Usuario GetByChaveSolicitacaoSenha(string chaveSolicitacaoSenha)
        {
            return this._myClinicContext.Usuarios.Where(u => u.ChaveSolicitacaoSenha == chaveSolicitacaoSenha).FirstOrDefault();
        }

        public void UpdateNovaSenha(Usuario usuario)
        {
            this.Update(usuario);
        }
    }
}
