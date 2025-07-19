using DesafioPOO.Models;

while (true)
{
    Console.WriteLine("\n--------- SIMULADOR DE SMARTPHONE ---------");
    Console.WriteLine("Digite 'sair' a qualquer momento para encerrar.\n");

    Console.Write("Informe o número do celular: ");
    string numero = Console.ReadLine();
    if (numero.ToLower() == "sair") break;

    Console.Write("Informe o modelo do aparelho: ");
    string modelo = Console.ReadLine();
    if (modelo.ToLower() == "sair") break;

    Console.Write("Informe o IMEI: ");
    string imei = Console.ReadLine();
    if (imei.ToLower() == "sair") break;

    Console.Write("Informe a memória (em GB): ");
    string inputMemoria = Console.ReadLine();
    if (inputMemoria.ToLower() == "sair") break;

    if (!int.TryParse(inputMemoria, out int memoria) || memoria <= 0)
    {
        Console.WriteLine("ATENÇÃO: Memória inválida. Digite um número inteiro positivo.");
        continue;
    }

    Smartphone celular = null;

    while (true)
    {
        Console.Write("Informe o tipo de smartphone (Nokia/Iphone): ");
        string tipo = Console.ReadLine();
        if (tipo.ToLower() == "sair") return;

        if (tipo.ToLower() == "nokia")
        {
            celular = new Nokia(numero, modelo, imei, memoria);
            break;
        }
        else if (tipo.ToLower() == "iphone")
        {
            celular = new Iphone(numero, modelo, imei, memoria);
            break;
        }
        else
        {
            Console.WriteLine("ATENÇÃO: Tipo de smartphone não reconhecido. Digite apenas 'Nokia' ou 'Iphone'.");
        }
    }

    Console.Write("Informe o nome do aplicativo que deseja instalar: ");
    string app = Console.ReadLine();
    if (app.ToLower() == "sair") break;

    celular.Ligar();
    celular.ReceberLigacao();
    celular.InstalarAplicativo(app);

    Console.WriteLine("\nFim da simulação.");
    Console.Write("Digite 'sair' para encerrar ou pressione Enter para simular novamente: ");
    string continuar = Console.ReadLine();
    if (continuar.ToLower() == "sair") break;
}
