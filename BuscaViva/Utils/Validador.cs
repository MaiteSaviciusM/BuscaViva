namespace BuscaVivaConsole.Utils
{
    public static class Validador
    {
        public static int ValidarSensor()
        {
            while (true)
            {
                Console.Write("ID do sensor (somente números): ");
                string entrada = Console.ReadLine();

                try
                {
                    if (string.IsNullOrWhiteSpace(entrada))
                        throw new Exception("O campo 'ID do sensor' não pode ficar vazio.");

                    int idSensor = int.Parse(entrada);

                    if (idSensor <= 0)
                        throw new Exception("O ID do sensor deve ser um número positivo.");

                    return idSensor;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Digite apenas números inteiros para o ID do sensor.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

        public static string ValidarTexto(string entrada, string campo)
        {
            while (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine($"Erro: O campo '{campo}' não pode estar vazio.");
                Console.Write($"Digite o valor para {campo}: ");
                entrada = Console.ReadLine();
            }

            return entrada.Trim();
        }

        public static int ValidarNumero(string entrada, string campo)
        {
            int numero;
            while (true)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(entrada))
                        throw new Exception($"O campo '{campo}' não pode estar vazio.");

                    if (!int.TryParse(entrada, out numero))
                        throw new FormatException();

                    return numero;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Erro: O campo '{campo}' deve ser um número inteiro válido.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                Console.Write($"Digite o valor para {campo}: ");
                entrada = Console.ReadLine();
            }
        }
    }
}