namespace GFTSTART2_Etapa_Tecnica.questao1 {
    public class ColaboradorEnsBasico : ColaboradorBase {
        public string Escola { get; private set; }

        public ColaboradorEnsBasico(string nome, string matricula, string escola) : base(nome, matricula) {
            Escola = escola;
        }
    }
}