namespace BuscaVivaConsole.Models
{
    public class Alerta
    {
        public string IdSensor { get; private set; }
        public string Ponto { get; private set; }
        public DateTime Timestamp { get; private set; }
        public bool Verificado { get; private set; }
        public bool Cancelado { get; set; }

        public Alerta(string idSensor, string ponto, DateTime timestamp)
        {
            IdSensor = idSensor;
            Ponto = ponto;
            Timestamp = timestamp;
            Verificado = false;
        }

        public void MarcarVerificado()
        {
            Verificado = true;
        }

        public override string ToString()
        {
            string status;

            if (Cancelado)
                status = "[Cancelado]";
            else if (Verificado)
                status = "[Verificado]";
            else
                status = "[Pendente]";

            return $"{status} ID: {IdSensor}, Ponto: {Ponto}, Horário: {Timestamp:dd/MM/yyyy HH:mm:ss}";
        }

    }
}
