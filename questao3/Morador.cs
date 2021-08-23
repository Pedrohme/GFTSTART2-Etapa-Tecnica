namespace GFTSTART2_Etapa_Tecnica.questao3 {
    public class Morador {
        //propriedades automaticas (auto-implemented properties) em C# automaticamente implementam campos privados com os métodos acessores desejados
        public string Telefone { get; set; }
        public int NumResidencia { get; set; }
        public bool TemCachorro { get; set; }

        public Morador(string telefone, int numResidencia, bool temCachorro) {
            Telefone = telefone;
            NumResidencia = numResidencia;
            TemCachorro = temCachorro;
        }
    }
}