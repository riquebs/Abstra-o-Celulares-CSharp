namespace DesafioPOO.Models
{
    // Herdando funcionalidades da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // Sobrescrevendo o método "InstalarAplicativo" da classe PAI "Smartphone"

         public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone...");
            Console.WriteLine("Seu aplicativo foi instalado com sucesso!");
        }
    }
}