//Considerei que a questao 1 não necessitava de outros métodos, apenas o modelo das classes e os construtores.
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