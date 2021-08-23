namespace GFTSTART2_Etapa_Tecnica.questao3 {
    public class Questao3Test {
        public void RunTest() {
            Entregador correio = new Entregador();
            Morador[] moradores = new Morador[] {
                new Morador("15987654321", 200, true),
                new Morador("15941241323", 311, false),
                new Morador("15945341675", 542, false),
                new Morador("15968482384", 697, true),
                new Morador("15955433424", 753, false)
            };

            foreach (var morador in moradores) {
                correio.Entregar(morador);
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("Resultado esperado: entregou em 2 casa(s) de número ímpar");
            System.Console.WriteLine($"Resultado: entregou em {correio.EntreguesImpar} casa(s) de número ímpar");
        }


    }
}