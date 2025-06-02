using BuscaVivaConsole.Models;

namespace BuscaVivaConsole.Services
{
    public class FilaBusca
    {
        private readonly Queue<Alerta> filaDeBusca = new();
        private readonly List<Alerta> historico = new();

        public void AdicionarAlerta(Alerta alerta)
        {
            filaDeBusca.Enqueue(alerta);
            historico.Add(alerta);
        }

        public Alerta? MarcarProximoComoVerificado()
        {
            if (filaDeBusca.Count == 0)
                return null;

            Alerta alerta = filaDeBusca.Dequeue();
            alerta.MarcarVerificado();
            return alerta;
        }

        public List<Alerta> ObterFilaAtual()
        {
            return filaDeBusca.ToList();
        }

        public List<Alerta> ObterHistorico()
        {
            return historico.ToList();
        }

        public bool CancelarUltimoAlerta()
        {
            if (filaDeBusca.Count == 0)
                return false;

            var novaFila = new Queue<Alerta>(filaDeBusca);
            var listaTemp = novaFila.ToList();
            var alertaRemovido = listaTemp.Last();

            listaTemp.RemoveAt(listaTemp.Count - 1);
            filaDeBusca.Clear();

            foreach (var alerta in listaTemp)
                filaDeBusca.Enqueue(alerta);

            // Marca o alerta como cancelado no histórico
            alertaRemovido.Cancelado = true;

            Console.WriteLine($"Alerta cancelado: {alertaRemovido}");
            return true;
        }

    }
}
