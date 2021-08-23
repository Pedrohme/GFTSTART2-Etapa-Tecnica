namespace GFTSTART2_Etapa_Tecnica.questao3 {
    public class Entregador {
        public int EntreguesImpar { get; set; }

        public Entregador() {
            EntreguesImpar = 0;
        }

        public bool Entregar(Morador m) {
            if (!m.TemCachorro) {
                System.Console.WriteLine("Entrega a correspondência");
                if (m.NumResidencia % 2 != 0) {
                    this.EntreguesImpar++;
                }
                return true;
            }
            else {
                System.Console.WriteLine("Não Entrega a correspondência");
                return false;
            }
        }
    }
}