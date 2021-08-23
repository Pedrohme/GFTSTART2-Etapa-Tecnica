using System;
using GFTSTART2_Etapa_Tecnica.questao2;
using GFTSTART2_Etapa_Tecnica.questao3;
using GFTSTART2_Etapa_Tecnica.questao4;

namespace GFTSTART2_Etapa_Tecnica {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Escolha a questao (de 2 a 4): ");
            if (int.TryParse(Console.ReadLine(), out int questao)) {
                switch (questao) {
                    case 2:
                        Menu questao2 = new Menu();
                        questao2.MainLoop();
                        break;

                    case 3:
                        Questao3Test questao3 = new Questao3Test();
                        questao3.RunTest();
                        break;

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
