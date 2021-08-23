namespace GFTSTART2_Etapa_Tecnica.questao2 {
    public static class Calculos {
        public static int Idade(int nascimento, int atual) {
            return atual-nascimento;
        }

        public static double Imc(double altura, double peso) {
            return peso/(altura*altura);
        }
    }
}