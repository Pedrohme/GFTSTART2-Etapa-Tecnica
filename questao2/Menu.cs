using System;
using System.Collections;

namespace GFTSTART2_Etapa_Tecnica.questao2 {
    public class Menu {
        public void MainLoop() {
            int opcao = 0;

            while (opcao != 3) {
                System.Console.WriteLine("Selecione uma opção:");
                System.Console.WriteLine("1 - Calculo de Idade");
                System.Console.WriteLine("2 - Calculo de IMC");
                System.Console.WriteLine("3 - Sair");
                if (!int.TryParse(Console.ReadLine(), out opcao)) {
                    opcao = 0;
                }
                System.Console.WriteLine();

                switch (opcao) {
                    case 1:
                        System.Console.WriteLine("Insira o ano de nascimento: ");
                        if (!int.TryParse(Console.ReadLine(), out int nascimento)) {
                            System.Console.WriteLine("Valor inválido!");
                            break;
                        }
                        System.Console.WriteLine("Insira o ano atual: ");
                        if (!int.TryParse(Console.ReadLine(), out int atual)) {
                            System.Console.WriteLine("Valor inválido!");
                            break;
                        }
                        System.Console.WriteLine($"A idade é: {Calculos.Idade(nascimento, atual)}" + Environment.NewLine);
                        break;

                    case 2:
                        System.Console.WriteLine("Insira a altura da pessoa em metros: ");
                        if (!Double.TryParse(Console.ReadLine(), out double altura)) {
                            System.Console.WriteLine("Valor inválido!");
                            break;
                        }
                        System.Console.WriteLine("Insira o peso(massa) da pessoa em kilogramas: ");
                        if (!Double.TryParse(Console.ReadLine(), out double peso)) {
                            System.Console.WriteLine("Valor inválido!");
                            break;
                        }
                        System.Console.WriteLine($"O IMC da pessoa é: {Calculos.Imc(altura, peso)}" + Environment.NewLine);
                        break;

                    case 3:
                        System.Console.WriteLine("Finalizando programa..." + Environment.NewLine);
                        break;

                    default:
                        System.Console.WriteLine("Opcao inválida!");
                        opcao = 0;
                        break;
                }
            }
        }
    }
}