using BuscaViva.Services;
using BuscaVivaConsole;
using BuscaVivaConsole.Models;
using BuscaVivaConsole.Services;
using BuscaVivaConsole.Utils;

class Program
{
    static FilaBusca fila = new();

    static void Main()
    {
        Login.EfetuarLogin();
        
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n--- BuscaViva Console ---");
            Console.WriteLine("1. Registrar novo alerta");
            Console.WriteLine("2. Ver fila de busca");
            Console.WriteLine("3. Marcar próximo ponto como verificado");
            Console.WriteLine("4. Ver histórico de alertas");
            Console.WriteLine("5. Cancelar último alerta registrado");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            try
            {
                switch (opcao)
                {
                    case "1":
                        RegistrarAlerta();
                        break;
                    case "2":
                        MostrarFila();
                        break;
                    case "3":
                        MarcarVerificado();
                        break;
                    case "4":
                        MostrarHistorico();
                        break;
                    case "5":
                        CancelarUltimo();
                        break;
                    case "6":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERRO] {ex.Message}");
            }
        }
    }

    static void RegistrarAlerta()
    {
        int idSensor = Validador.ValidarSensor();

        Console.Write("Ponto de detecção (ex: Ponto A): ");
        string ponto = Validador.ValidarTexto(Console.ReadLine(), "Ponto");

        DateTime timestamp = DateTime.Now;

        var alerta = new Alerta(idSensor.ToString(), ponto, timestamp);
        fila.AdicionarAlerta(alerta);

        Console.WriteLine($"Alerta registrado com sucesso em {timestamp:dd/MM/yyyy HH:mm:ss}.");
    }



    static void MostrarFila()
    {
        var filaAtual = fila.ObterFilaAtual();

        if (!filaAtual.Any())
        {
            Console.WriteLine("Nenhum ponto na fila.");
            return;
        }

        Console.WriteLine("\n--- Fila de Busca ---");
        foreach (var alerta in filaAtual)
        {
            Console.WriteLine(alerta);
        }
    }

    static void MarcarVerificado()
    {
        var alerta = fila.MarcarProximoComoVerificado();

        if (alerta == null)
        {
            Console.WriteLine("Nenhum alerta na fila para verificar.");
        }
        else
        {
            Console.WriteLine($"Alerta do ponto {alerta.Ponto} marcado como verificado.");
        }
    }

    static void MostrarHistorico()
    {
        var historico = fila.ObterHistorico();

        if (!historico.Any())
        {
            Console.WriteLine("Histórico vazio.");
            return;
        }

        Console.WriteLine("\n--- Histórico de Alertas ---");
        foreach (var alerta in historico)
        {
            Console.WriteLine(alerta);
        }
    }

    static void CancelarUltimo()
    {
        bool cancelado = fila.CancelarUltimoAlerta();

        if (!cancelado)
            Console.WriteLine("Não há alertas pendentes para cancelar.");
    }

}
