namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        protected string Modelo { get; private set; }
        protected string IMEI { get; private set; }
        protected string Memoria { get; private set; }

        protected Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}