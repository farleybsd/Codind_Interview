namespace buscaEmLargura
{
    // Classe que representa o no de uma Arvore
    public class No
    {
        public int root; // Dados para cada No da Arvore
        public No Esquerda, Direita; // O no da Direita e o no da Esquerda

        public No(int item)
        {
            root = item; // Recebe o valor do construtor
            Esquerda = Direita = null; // Inicar sem os ramos da esquerda e da Direita
        }
    }
}
