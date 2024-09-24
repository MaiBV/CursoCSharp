using System.Diagnostics.Contracts;
using CursoCSharp.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");






// Console.WriteLine($"Percorrendo a lista utilizando FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição n° {contador} - {listaString[contador]}");
// }

// Console.WriteLine($"Percorrendo a lista utilizando FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - {item}");
//     contadorForeach++;
// }


// List<string> listaString = ["SP", "BA", "MG"];

// Console.WriteLine("Percorrendo listaString com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição n° {contador} - {listaString[contador]}");
    
// }

// Console.WriteLine("Percorrendo listaString com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - {item}");
//     contadorForeach++;
// }


// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// Console.WriteLine("Percorrendo o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição n° {contador} - {arrayInteiros[contador]}"
// }

// Console.WriteLine("Percorrendo o Array com o FOREACH");


// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - {valor}");
//     contadorForeach++;
// }


// Pessoa pessoa = new Pessoa();
// pessoa.Nome = "João";
// pessoa.Idade = 30;
// pessoa.Apresentar();


// string opção = string.Empty;
// bool exibirMenu = true;


// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Busca clientes");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Sair");

//     opção = Console.ReadLine() ?? string.Empty;

//     switch(opção)
//     {
//         case "1":
//             Console.WriteLine("Digite o nome do cliente: ");
//             string nome = Console.ReadLine() ?? string.Empty;
//             if (string.IsNullOrEmpty(nome))
//             {
//                 Console.WriteLine("Nome não pode ser vazio.");
//                 break;
//             }
//             Console.WriteLine("Digite a idade do cliente: ");
//             string? idadeInput = Console.ReadLine();
//             if (string.IsNullOrEmpty(idadeInput) || !int.TryParse(idadeInput, out int idade))
//             {
//                 Console.WriteLine("Idade inválida.");
//                 break;
//             }
//             Pessoa pessoa = new()
//             {
//                 Nome = nome,
//                 Idade = idade
//             };
//             pessoa.Apresentar();
//             break;
//         case "2":
//             Console.WriteLine("Buscando clientes...");
//             break;
//         case "3":
//             Console.WriteLine("Apagando cliente...");
//             break;
//         case "4":
//             Console.WriteLine("Saindo...");
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }
// }

// Console.WriteLine("O programa foi encerrado");



// Pessoa pessoa1 = new Pessoa
// {
//     Nome = "Maiara",
//     Idade = 47
// };
// pessoa1.Apresentar();



// Calculadora calculadora = new Calculadora();
// calculadora.Somar(5, 5);
// calculadora.Subtrair(10, 5);
// calculadora.Multiplicar(5, 5);
// calculadora.Dividir(10, 2);
// calculadora.Potencia(2, 3);
// calculadora.Seno(30);
// calculadora.Cosseno(30);
// calculadora.Tangente(30);
// calculadora.RaizQuadrada(25);