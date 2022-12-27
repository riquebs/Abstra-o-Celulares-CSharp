namespace DesafioPOO.Models
{
      // Herdando funcionalidades da classe "Smartphone"
    public class Nokia : Smartphone
    {
       public Nokia (string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // Sobrescrevendo o método "InstalarAplicativo" da classe PAI "Smartphone"
    
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
            Console.WriteLine("Seu aplicativo foi instalado com sucesso!");
        }
 }
}