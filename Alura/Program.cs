//Screen Sound

string mensagemBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8 });
bandasRegistradas.Add("The Beatles", new List<int> { 10, 9 });


void ExibirMensagemBoasVindas()
{
   Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░ ");
   Console.WriteLine(mensagemBoasVindas);
   Console.WriteLine("Seu site preferido para avaliação de bandas");

}

void ExibirOpcoesDeMenu()
{
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\n Digite sua opção: ");
        string OpcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1: registrarBandas();
            break;
        case 2: exibirListasDasBandas();
            break;
        case 3: notaParaBandas();
            break;
        case 4:
            mediaParaABanda();
            break;
        case 5: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Espero que você volte em breve :)");
            break;
        default: Console.WriteLine("Não existe a opção selecionada.");
            break; 
    }
}

ExibirMensagemBoasVindas();
ExibirOpcoesDeMenu();

void registrarBandas()
{
    Console.Clear();
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($" A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    ExibirOpcoesDeMenu();

}

void exibirListasDasBandas()
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas ");
    string nomeDaBanda = Console.ReadLine();
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");   
    }
    Console.WriteLine("\n Aperte qualquer tecla para voltar para o console");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDeMenu();
}

void notaParaBandas()
{
    //Digite qual a banda você deseja avaliar
    //Se a banda existir no dicionário >> atribuir uma nota
    //Se não, voltar ao menu principal.

    Console.Clear();
    Console.WriteLine("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string NomeDaBanda = Console.ReadLine();
    if(bandasRegistradas.ContainsKey(NomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {NomeDaBanda} merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[NomeDaBanda].Add(nota);
        Thread.Sleep(4000);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {NomeDaBanda}");
    } else {
        Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada, registre-a no dicionário para poder avalia-la");

    }
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
}

void mediaParaABanda()
{
    //Verificar se existe determinada banda no sistema
    //Verificar as notas atribuidas para a banda no sistema
    //Tirar a média delas

    Console.Clear();
    Console.WriteLine("Média das bandas");
    Console.Write("Digite qual banda você deseja ver a média");
    string NomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(NomeDaBanda))
    {
        List <int> notasDasBandas = bandasRegistradas[NomeDaBanda];
        Console.WriteLine($"O nome da banda é {NomeDaBanda} e sua média é de {notasDasBandas.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();   
        ExibirOpcoesDeMenu();
    }
    else { Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada, registre-a no dicionário para poder avalia-la");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
    }

}