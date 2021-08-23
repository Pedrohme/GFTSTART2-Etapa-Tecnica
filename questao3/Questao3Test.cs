namespace GFTSTART2_Etapa_Tecnica.questao3 {
    public class Questao3Test {
        public void RunTest() {
            Entregador correio = new Entregador();
            Morador[] moradores = new Morador[] {
                new Morador("15987654321", 200, true), //casa par, possui cachorro = não entrega
                new Morador("15941241323", 311, false),//casa impar, nao possui cachorro = entrega
                new Morador("15945341675", 542, false),//casa par, nao possui cachorro = entrega
                new Morador("15968482384", 697, true), //casa impar, possui cachorro = não entrega
                new Morador("15955433424", 753, false) //casa impar, nao possui cachorro = não entrega
            };
            //total: 3 casas entregues, sendo 2 impares

            foreach (var morador in moradores) {
                correio.Entregar(morador);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Resultado esperado: entregou em 2 casa(s) de número ímpar");
            System.Console.WriteLine($"Resultado: entregou em {correio.EntreguesImpar} casa(s) de número ímpar");
        }


    }
}