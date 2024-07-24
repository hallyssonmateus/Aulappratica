// See https://aka.ms/new-console-template for more information

string mensagemDeBoasVindas = "Bem vindos a minha aula basica de C#";

void ExibirMensagemBoasVindas(){
    Console.WriteLine("*********************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("*********************");
}

void ExibirOpcoesMenu(){
    Console.WriteLine("\nDigite 1 para registar uma banda");
    Console.WriteLine("Digite 2 para mostrar uma banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcaoEscolhidaNumerica == 1){
        Console.WriteLine("Voce digitou a opção 1");
    }
}

ExibirMensagemBoasVindas();
ExibirOpcoesMenu();


