namespace GFTSTART2_Etapa_Tecnica.questao1 {
    public class ColaboradorBase {
        public string Nome { get; private set; }
        public string Matricula { get; private set; }

        public ColaboradorBase(string nome, string matricula) {
            Nome = nome;
            Matricula = matricula;
        }
    }
}