using DesafioPOO.Models;

// Para mais informações sobre o funcionamento do projeto, verificar em README.md

Console.WriteLine("Você deseja ligar os aparelhos? [S / N]");
string ligar = Console.ReadLine();

while(ligar != "S" && ligar !="N")
{
    Console.WriteLine("Opção inválida! digite novamente: [S / N]");
    ligar = Console.ReadLine();
}

if(ligar == "N")
{
    Console.WriteLine("Tudo bem, até a próxima! \nEncerrando a aplicação...");
} 

else
{
    Nokia nokia = new Nokia(numero: "N1234", modelo: "Lumia", imei: "S1234", memoria: 2048);
    Iphone iphone = new Iphone(numero:"I4321", modelo:"8 Plus", imei:"I4321", memoria: 1024);

Console.WriteLine("Ligando o NOKIA...");
Console.WriteLine("Ligando o IPHONE...");

Pausa();

nokia.Ligar();
iphone.ReceberLigacao();
Pausa();

nokia.InstalarAplicativo("WhatsApp Messenger");
Console.WriteLine("-");
iphone.InstalarAplicativo("Telegram Messenger");
Console.WriteLine("-");

Console.WriteLine("Testes finalizados!");
Pausa();
}

void Pausa()
{
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadLine();
}