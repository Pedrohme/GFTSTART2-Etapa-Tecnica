using System;

namespace GFTSTART2_Etapa_Tecnica.questao4 {
    public class TabelaDescontos {
        public static void ImprimirTabela(double valor) {
            if (valor < 0) {
                throw new ArgumentException("Valor inválido");
            }
            if (valor < 300) {
                System.Console.WriteLine($"{valor} - {0}% - {valor}");
            }
            else if (valor > 2200) {
                System.Console.WriteLine($"{valor} - {20}% - {valor * 0.8}");
            }
            else {
                int desconto = (int)(valor / 100) - 2;
                double valorFinal = valor * (1.0 - (desconto / 100.0));
                System.Console.WriteLine($"{valor} - {desconto}% - {valorFinal}");
            }
        }
    }
}