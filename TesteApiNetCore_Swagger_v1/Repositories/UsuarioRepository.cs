using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteApiNetCore_Swagger_v1.Models;

namespace TesteApiNetCore_Swagger_v1.Repositories
{
    public static class UsuarioRepository
    {
        public static Usuario Get(string username, string password)
        {
            var usuarios = new List<Usuario>();
            usuarios.Add(new Usuario { Id = 1, Username = "Jose", Password = "jose", Role = "Funcionario" });
            usuarios.Add(new Usuario { Id = 2, Username = "Pedro", Password = "pedro", Role = "Gerente" });
            return usuarios.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
        }
    }
}
