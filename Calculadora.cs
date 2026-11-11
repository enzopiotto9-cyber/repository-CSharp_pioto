// namespace repository_C_;

// class Calculadora
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Hello, World!");

//         //aula 1 
//         //calculadora simples

//         //o usuario deve digitar os valores desejados , igual como seria em uma calculadora real.
//         //deve ser impreso na tela as opções de calculo.

//         //calculadora simples 
//         // 1. Imprime na tela as opções de cálculo
//         Console.WriteLine("=== CALCULADORA REAL ===");
//         Console.WriteLine("Escolha a operação desejada:");
//         Console.WriteLine("1. Soma (+)");
//         Console.WriteLine("2. Subtração (-)");
//         Console.WriteLine("3. Multiplicação (*)");
//         Console.WriteLine("4. Divisão (/)");
//         Console.WriteLine("========================");

//         // Ler a opção do usuário
//         Console.Write("Digite o número da operação (1/2/3/4): ");
//         string opcao = Console.ReadLine();

//         // Valida se a opção é válida antes de continuar
//         if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4")
//         {
//             Console.WriteLine("Opção inválida! O programa será encerrado.");
//             return;
//         }

//         // 2. O usuário digita os valores desejados
//         Console.Write("Digite o primeiro número: ");
//         double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Digite o segundo número: ");
//         double num2 = Convert.ToDouble(Console.ReadLine());

//         double resultado = 0;
//         string operacao = "";

//         // 3. Executa o cálculo baseado na escolha
//         switch (opcao)
//         {
//             case "1":
//                 resultado = num1 + num2;
//                 operacao = "+";
//                 break;
//             case "2":
//                 resultado = num1 - num2;
//                 operacao = "-";
//                 break;
//             case "3":
//                 resultado = num1 * num2;
//                 operacao = "*";
//                 break;
//             case "4":
//                 // Evita o erro de divisão por zero
//                 if (num2 == 0)
//                 {
//                     Console.WriteLine("Erro: Não é possível dividir por zero!");
//                     return;
//                 }
//                 resultado = num1 / num2;
//                 operacao = "/";
//                 break;
//         }

//         // 4. Imprime o resultado na tela
//         Console.WriteLine($"\nResultado: {num1} {operacao} {num2} = {resultado}");

//         // Mantém o console aberto até o usuário pressionar uma tecla
//         Console.WriteLine("\nPressione qualquer tecla para sair...");
//         Console.ReadKey();
//     }
// }
