namespace GFTSTART2_Etapa_Tecnica.questao1 {
    public class ColaboradorEnsSuperior : ColaboradorEnsBasico {
        public string Universidade { get; private set; }

        public ColaboradorEnsSuperior(string nome, string matricula, string escola, string universidade) : base(nome, matricula, escola) {
            Universidade = universidade;
        }
    }
}