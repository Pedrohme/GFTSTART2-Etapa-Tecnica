using System;
using GFTSTART2_Etapa_Tecnica.questao2;
using GFTSTART2_Etapa_Tecnica.questao3;
using GFTSTART2_Etapa_Tecnica.questao4;

//Considerei que a questao 1 não necessitava de outros métodos, apenas o modelo das classes e os construtores.
namespace GFTSTART2_Etapa_Tecnica {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Escolha a questao (de 2 a 4): ");
            if (int.TryParse(Console.ReadLine(), out int questao)) {
                switch (questao) {
                    //implementacao em questao2/
                    case 2:
                        Menu questao2 = new Menu();
                        questao2.MainLoop();
                        break;

                    //implementacao do teste em questao3/Questao3Test.cs
                    case 3:
                        Questao3Test questao3 = new Questao3Test();
                        questao3.RunTest();
                        break;

                    //implementacao em questao4/
                    case 4:
                        System.Console.WriteLine("Digite um valor da compra: ");
                        if (Double.TryParse(Console.ReadLine(), out double valor)) {
                            TabelaDescontos.ImprimirTabela(valor);
                        }
                        else {
                            System.Console.WriteLine("Valor inválido");
                        }
                        break;

                    default:
                        System.Console.WriteLine("opcao invalida");
                        break;
                }
            }
            else {
                System.Console.WriteLine("opcao invalida");
            }

        }
    }
}
