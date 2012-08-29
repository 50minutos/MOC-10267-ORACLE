using System;

namespace _004_LoginUsandoSession
{
    public class Usuario
    {
        public String Id { get; set; }
        public String Senha { get; set; }

        public Usuario(String id, String senha)
        {
            Id = id;
            Senha = senha;
        }

        public override bool Equals(object obj)
        {
            var outro = obj as Usuario;

            return outro != null && Id.Equals(outro.Id) && Senha.Equals(outro.Senha);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Senha.GetHashCode();
        }
    }
}
