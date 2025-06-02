using BuscaViva.Models;
using System;
using System.Collections.Generic;

namespace BuscaViva.Services
{
    public static class Login
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("fabio", "2257"),
            new Usuario("lucas", "98188"),
            new Usuario("maite", "98435"),
            new Usuario("murilo", "99855")
            
        };

        public static void EfetuarLogin()
        {
            while (true)
            {
                Console.Write("Usuário: ");
                string usuario = Console.ReadLine();

                Console.Write("Senha: ");
                string senha = LerSenha();

                if (ValidarUsuario(usuario, senha))
                {
                    Console.WriteLine("Login realizado com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Usuário ou senha incorretos. Tente novamente.");
                }
            }
        }

        private static bool ValidarUsuario(string usuario, string senha)
        {
            foreach (var user in usuarios)
            {
                if (user.NomeUsuario == usuario && user.Senha == senha)
                    return true;
            }
            return false;
        }

        private static string LerSenha()
        {
            string senha = "";
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);

                if (tecla.Key != ConsoleKey.Backspace && tecla.Key != ConsoleKey.Enter)
                {
                    senha += tecla.KeyChar;
                    Console.Write("*");
                }
                else if (tecla.Key == ConsoleKey.Backspace && senha.Length > 0)
                {
                    senha = senha.Substring(0, senha.Length - 1);
                    Console.Write("\b \b");
                }
            } while (tecla.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return senha;
        }
    }
}
