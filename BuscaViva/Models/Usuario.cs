namespace BuscaViva.Models
{
    public class Usuario
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }

        public Usuario(string nomeUsuario, string senha)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
        }
    }
}
