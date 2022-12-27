namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        protected string Modelo { get; set; }

        protected string IMEI { get; set; }

        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Nokia: Efetuando chamada para o Iphone...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Iphone: Recebendo chamada do Nokia...\nChamada encerrada com sucesso!");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}