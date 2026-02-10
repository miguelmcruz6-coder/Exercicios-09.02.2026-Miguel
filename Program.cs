//////////////////////////////////////////////////// 1. Entrada, Processamento e Saída ////////////////////////////////////////////////////


// // Peça ao usuário dois números e mostre a soma, subtração, multiplicação e divisão entre eles.


// Console.WriteLine("\nDigite um número");
// double n1 = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Digite outro número");
// double n2 = double.Parse(Console.ReadLine()!);

// Console.WriteLine("\nOperações: \n");
// Console.WriteLine($"Soma: {n1 + n2}");
// Console.WriteLine($"Subtração: {n1 - n2}");
// Console.WriteLine($"Multiplicação: {n1 * n2}");
// Console.WriteLine($"Divisão: {n1 / n2}\n");


// // Leia um número e mostre o seu dobro e o seu triplo.


// Console.WriteLine("\nDigite um número");
// double numero = double.Parse(Console.ReadLine()!);

// Console.WriteLine($"\nDobro: {numero * 2}");
// Console.WriteLine($"Triplo: {numero * 3}\n");


// // Leia o nome de uma pessoa e exiba uma mensagem de boas-vindas personalizada.


// Console.WriteLine("Digite seu nome");
// string nome = Console.ReadLine()!;
// Console.WriteLine("Olá " + nome);


// // Leia a idade de uma pessoa e informe quantos anos ela terá daqui a 10 anos.


// Console.WriteLine("Digite uma idade");
// int idade = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Esta pessoa terá {idade + 10} anos daqui a 10 anos");


//////////////////////////////////////////////////// 2. Estruturas Condicionais (if / else) ////////////////////////////////////////////////////


// // Leia um número e informe se ele é par ou ímpar.


// Console.WriteLine("\nDigite um número inteiro");
// int pOuI = int.Parse(Console.ReadLine()!);

// if (pOuI % 2 == 0)
// {
//     Console.WriteLine("Seu número é par");
// }
// else
// {
//     Console.WriteLine("Seu número é ímpar");
// }


// // Leia dois números e mostre qual é o maior ou informe se são iguais.


// Console.WriteLine("\nDigite um número");
// int n1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Digite outro número");
// int n2 = int.Parse(Console.ReadLine()!);

// if (n1 > n2)
// {
//     Console.WriteLine("\nO primeiro número é maior\n");
// }
// else if (n1 < n2)
// {
//     Console.WriteLine("\nO segundo número é maior\n");
// }
// else
// {
//     Console.WriteLine("\nOs dois números são iguais\n");
// }


// // Leia a nota de um aluno e informe se ele está aprovado, em recuperação ou reprovado.


// Console.WriteLine("\nDigite a média de suas notas");
// double media = double.Parse(Console.ReadLine()!);

// if (media >= 7)
// {
//     Console.WriteLine("\nVocê está aprovado\n");
// }
// else if (media >= 4)
// {
//     Console.WriteLine("\nVocê está de recuperação\n");
// }
// else
// {
//     Console.WriteLine("\nVocê está reprovado\n");
// }


// // Leia a idade de uma pessoa e informe se ela é menor de idade, adulta ou idosa.


// Console.WriteLine("\nDigite a sua idade");
// int idade = int.Parse(Console.ReadLine()!);

// if (idade >= 60)
// {
//     Console.WriteLine("\nVocê é idoso\n");
// }
// else if (idade >= 18)
// {
//     Console.WriteLine("\nVocê é adulto\n");
// }
// else
// {
//     Console.WriteLine("\nVocê é menor de idade\n");
// }


// // Leia um número e informe se ele é positivo, negativo ou zero.


// Console.WriteLine("\nDigite um número");
// double pOuN = double.Parse(Console.ReadLine()!);

// if (pOuN > 0)
// {
//     Console.WriteLine("\nEste número é positivo");
// }
// else if (pOuN < 0)
// {
//     Console.WriteLine("\nEste número é negativo");
// }
// else 
// {
//     Console.WriteLine("\nEste número é neutro");
// }


//////////////////////////////////////////////////// 3. Estruturas de Repetição (for / while) ////////////////////////////////////////////////////


// // Mostre os números de 1 a 10 usando um laço.


// Console.WriteLine("Números de 1 a 10 decrescente:\n");
// for(int i = 10; i > 0; i--)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("\nNúmeros de 1 a 10 crescente:\n");
// for(int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine();


// // Mostre os números pares de 1 a 50.


// Console.WriteLine("\nNúmeros parse de 1 a 50:\n");
// for (int i = 1; i < 51; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }
// Console.WriteLine();


// // Leia um número e mostre a tabuada dele.


// Console.WriteLine("\nDigite um número");
// double tabuada = double.Parse(Console.ReadLine()!);
// Console.WriteLine();

// for (int i = 1; i < 11; i++)
// {
//     Console.WriteLine($"{tabuada} * {i} = {tabuada * i}");
// }
// Console.WriteLine();


// // Leia vários números até que o usuário digite 0 e mostre a soma de todos.


// double x = 1;
// double total = 0;

// while(x != 0)
// {
//     Console.WriteLine("Digite um número");
//     x = double.Parse(Console.ReadLine()!);

//     total += x;
// }
// Console.WriteLine("O total dos números que você digitou é = " + total);


// // Leia 5 números e informe quantos são positivos.


// int positivo = 0;
// double resposta = 0;
// for(int i = 1; i < 6; i++)
// {
//     Console.WriteLine($"Digite seu {i}° número");
//     resposta = double.Parse(Console.ReadLine()!);

//     if (resposta > 0)
//     {
//         positivo++;
//     }
// }
// Console.WriteLine($"Você digitou {positivo} número/s positivo/s\n");


//////////////////////////////////////////////////// 4. Estrutura de Decisão Múltipla (switch / case) ////////////////////////////////////////////////////


// // Crie um menu com as opções:

// // 1 – Somar
// // 2 – Subtrair
// // 3 – Multiplicar
// // 4 – Dividir

// // O usuário escolhe a opção e informa dois números.


// Console.WriteLine("\nDigite o número de qual operação deseja");

// Console.WriteLine("\n1 - Somar");
// Console.WriteLine("2 - Subtrair");
// Console.WriteLine("3 - Multiplicar");
// Console.WriteLine("4 - Dividir\n");

// string opcao = Console.ReadLine()!;

// if (opcao == "1")
// {
//     Console.WriteLine("Digite um número");
//     double n1 = double.Parse(Console.ReadLine()!);
//     Console.WriteLine("Digite outro número");
//     double n2 = double.Parse(Console.ReadLine()!);

//     Console.WriteLine($"Resultado: {n1 + n2}");
// }
// else if (opcao == "2")
// {
//     Console.WriteLine("Digite um número");
//     double n1 = double.Parse(Console.ReadLine()!);
//     Console.WriteLine("Digite outro número");
//     double n2 = double.Parse(Console.ReadLine()!);

//     Console.WriteLine($"Resultado: {n1 - n2}");
// }
// else if (opcao == "3")
// {
//     Console.WriteLine("Digite um número");
//     double n1 = double.Parse(Console.ReadLine()!);
//     Console.WriteLine("Digite outro número");
//     double n2 = double.Parse(Console.ReadLine()!);

//     Console.WriteLine($"Resultado: {n1 * n2}");
// }
// else if (opcao == "4")
// {
//     Console.WriteLine("Digite um número");
//     double n1 = double.Parse(Console.ReadLine()!);
//     Console.WriteLine("Digite outro número");
//     double n2 = double.Parse(Console.ReadLine()!);

//     Console.WriteLine($"Resultado: {n1 / n2}");
// }
// else
// {
//     Console.WriteLine("ERRO");
// }


// // Leia um número de 1 a 7 e informe o dia da semana correspondente.


// Console.WriteLine("Digite um número de 1 a 7");
// int dia = int.Parse(Console.ReadLine()!);

// switch (dia)
// {
//     case 1:
//     Console.WriteLine("O dia da semana correspondente é: Domingo\n");
//     break;

//     case 2:
//     Console.WriteLine("O dia da semana correspondente é: Segunda-Feira\n");
//     break;

//     case 3:
//     Console.WriteLine("O dia da semana correspondente é: Terça-Feira\n");
//     break;

//     case 4:
//     Console.WriteLine("O dia da semana correspondente é: Quarta-Feira\n");
//     break;

//     case 5:
//     Console.WriteLine("O dia da semana correspondente é: Quinta-Feira\n");
//     break;

//     case 6:
//     Console.WriteLine("O dia da semana correspondente é: Sexta-Feira\n");
//     break;

//     case 7:
//     Console.WriteLine("O dia da semana correspondente é: Sábado\n");
//     break;

//     default:
//     Console.WriteLine("ERRO\n");
//     break;
// }


// // Leia um código de produto e informe a categoria (ex: 1–Alimento, 2–Bebida, 3–Limpeza).


// Console.WriteLine("Digite o primeiro número do código do produto");
// int codigo = int.Parse(Console.ReadLine()!);

// Console.Write("Categoria do produto: ");
// switch (codigo)
// {
//     case 1:
//         Console.WriteLine("Alimento\n");
//         break;

//     case 2:
//         Console.WriteLine("Bebida\n");
//         break;

//     case 3:
//         Console.WriteLine("Limpeza\n");
//         break;

//     case 4:
//         Console.WriteLine("Entreterimento\n");
//         break;

//     case 5:
//         Console.WriteLine("Tempero\n");
//         break;

//     case 6:
//         Console.WriteLine("Recipiente\n");
//         break;

//     case 7:
//         Console.WriteLine("Eletrodoméstico\n");
//         break;

//     case 8:
//         Console.WriteLine("Congelado\n");
//         break;

//     case 9:
//         Console.WriteLine("Casa\n");
//         break;

//     default:
//         Console.WriteLine("ERRO\n");
//         break;
// }


//////////////////////////////////////////////////// 5. Lógica com Acumuladores e Contadores ////////////////////////////////////////////////////


// // Leia 10 números e informe:

// // a soma
// // a média
// // o maior número

// double soma = 0;
// double maior = 0;
// double x = 0;

// Console.WriteLine("Digite 10 números\n");
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Digite o {i + 1}° número");
//     x = double.Parse(Console.ReadLine()!);
//     soma += x;

//     if(maior < x)
//     {
//         maior = x;
//     }
// }

// Console.WriteLine($"\nA soma dos números digitados é = {soma}");
// Console.WriteLine($"A média dos números digitados é = {soma / 10}");
// Console.WriteLine($"\nO maior número digitado é = {maior}");


// // Leia idades até que seja digitado um valor negativo e informe a média das idades.


// int contador = 0;
// int idade = 0;
// double total = 0;

// while(idade < 0)
// {
//     Console.WriteLine("Digite uma idade");
//     idade = int.Parse(Console.ReadLine()!);

//     total += idade;
//     contador++;
// }

// Console.WriteLine($"A média das idades digitadas é = {total / contador}");


// // Leia vários números e informe quantos são pares e quantos são ímpares.


// double y = 1;
// int positivo = 0;
// int negativo = 0;

// while(y != 0)
// {
//     Console.WriteLine("\nDigite um número, para parar digite 0");
//     y = int.Parse(Console.ReadLine()!);
//     if(y > 0)
//     {
//         positivo++;
//     }
//     else if(y < 0)
//     {
//         negativo++;
//     }
// }

// Console.WriteLine($"\nQuantidade de números positivos digitados = {positivo}");
// Console.WriteLine($"Quantidade de números negativos digitados = {negativo}\n");


//////////////////////////////////////////////////// 6. Desafios de Lógica ////////////////////////////////////////////////////


// // Leia um número e informe se ele é primo.


// Console.WriteLine("Digite um número inteiro");
// int primo = int.Parse(Console.ReadLine()!);
// bool confirmacao = true;

// for (int i = 2; i < primo; i++)
// {
//     if (primo % i == 0)
//     {
//         confirmacao = false;
//     }
// }

// switch (confirmacao)
// {
//     case false:
//         Console.WriteLine("Seu número não é primo");
//         break;

//     default:
//         Console.WriteLine("Seu número é primo");
//         break;
// }



// // Leia um número e calcule o fatorial.


// Console.WriteLine("Digite um número inteiro");
// int fatorial = int.Parse(Console.ReadLine()!);

// if (fatorial <= 1)
// {
//     fatorial = 1;
// }
// else
// {
//     for (int i = fatorial; i > 1; i--)
//     {
//         fatorial = fatorial * (i - 1);
//     }
// }

// Console.WriteLine($"O fatorial do número digitado é = {fatorial}");


// // Leia uma senha e permita no máximo 3 tentativas.


// Console.WriteLine("Digite a senha");
// string senha = Console.ReadLine()!;
// bool bloqueio = false;

// for (int i = 3; i > 0; i--)
// {
//     if (senha != "1234")
//     {
//         Console.WriteLine("Acesso negado");
//         if (i == 1)
//         {
//             bloqueio = true;
//             break;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Logado com Sucesso");
//         break;
//     }
//     Console.WriteLine("Digite a senha novamente");
//     senha = Console.ReadLine()!;
// }
// if (bloqueio == true)
// {
//     Console.WriteLine("BLOQUEADO");
// }


// // Simule um caixa eletrônico que permite saques enquanto houver saldo.


// bool repitir = true;
// Console.WriteLine("\nDigite seu saldo");
// double saldo = double.Parse(Console.ReadLine()!);

// while (repitir)
// {
//     if( saldo > 10000000000000000000)
//     {
//         Console.WriteLine("Um mandato de prisão com seu nome foi enviado ao departamento de polícia mais próximo");
//         repitir = false;
//         break;
//     }
//     if( saldo > 1000000000)
//     {
//         Console.WriteLine("Você irá receber uma multa");
//         repitir = false;
//         break;
//     }
//     Console.WriteLine($"\nSaldo atual: R$ {saldo}");

//     Console.WriteLine("\n1 - Sacar\t2 - Depositar\n3 - Sair\n");
//     Console.Write("Digite o número da operação que deseja: ");
//     string resposta = Console.ReadLine()!;

//     switch (resposta)
//     {
//         case "1":
//             Console.Write("\nDigite o valor que deseja Sacar: R$ ");
//             double sacar = double.Parse(Console.ReadLine()!);  Thread.Sleep(500);
//             if(sacar > saldo)
//             {
//                 Console.WriteLine("\nNão foi possível sacar o dinheiro desejado");
//             }
//             else
//             {
//                 saldo -= sacar;  Thread.Sleep(500);
//                 Console.WriteLine("\nDinheiro sacado com sucesso");
//             }
//             break;

//         case "2":
//             Console.Write("\nDigite o valor que deseja depositar: R$ ");
//             double deposito = double.Parse(Console.ReadLine()!);
//             saldo += deposito; Thread.Sleep(1000);
//             Console.WriteLine("\nDinheiro depositado com sucesso");
//             break;

//         case "3":
//             Console.Write("\nTenha um ótimo dia!\n");
//             repitir = false;
//             break;

//         default:
//             Console.Write("\nOperação inválida");
//             break;
//     }
// }


// // Leia uma sequência de números e informe qual foi o maior valor digitado.


// double numero = 1;
// double maior = 0;
// while (numero != 0)
// {
//     Console.WriteLine("Digite um número, para parar o programa digite '0'");
//     numero = double.Parse(Console.ReadLine()!);

//     if (numero > maior)
//     {
//         maior = numero;
//     }
// }

// Console.WriteLine($"Seu maor número digitado é = {maior}");

