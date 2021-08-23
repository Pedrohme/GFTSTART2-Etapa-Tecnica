using System;

namespace GFTSTART2_Etapa_Tecnica.questao2 {
    public static class Calculos {
        public static int Idade(int nascimento) {
            int atual = DateTime.Today.Year;
            if (nascimento > atual) {
                throw new ArgumentException("Data inválida");
            }
            return atual-nascimento;
        }

        public static int Idade(int nascimento, int atual) {
            if (nascimento > atual) {
                throw new ArgumentException("Data inválida");
            }
            return atual-nascimento;
        }

        public static double Imc(double altura, double peso) {
            return peso/(altura*altura);
        }
    }
}