using System.Collections;

namespace buscaEmLargura
{
    // Classe que representa a Arvore
    public class ArvoreBinaria
    {
        public No raiz; // No da arvore

        // Construtor
        public ArvoreBinaria()
        {
            raiz = null; // No da arvore  comeca vazio
        }

        // Função para realizar a busca em largura na árvore binária
        public void BuscaEmLargura()
        {
            if (raiz == null)
                return;

            Queue<No> fila = new Queue<No>();
            fila.Enqueue(raiz);

            while (fila.Count != 0)
            {
                No tempNo = fila.Dequeue();
                Console.Write(tempNo.root + " ");

                if (tempNo.Esquerda != null)
                {
                    fila.Enqueue(tempNo.Esquerda);
                }
                if (tempNo.Direita != null)
                {
                    fila.Enqueue(tempNo.Direita);
                }

            }
        }

        // Função para inserir um número na árvore binária
        public void Inserir(int dado)
        {
            raiz = InserirRecursivo(raiz, dado);
        }

        private No InserirRecursivo(No raiz, int dado)
        {
            if (raiz == null)
            {
                raiz = new No(dado); //Colocando Valor no Root  da arvore
                return raiz;
            }

            if (dado < raiz.root) //Colocando Valor no Lado Esquerdo da arvore
            {
                raiz.Esquerda = InserirRecursivo(raiz.Esquerda, dado);
            }
                
            if (dado > raiz.root) //Colocando Valor no Lado Direito da arvore 
            {
                raiz.Direita = InserirRecursivo(raiz.Direita, dado);
            }
               

            return raiz;
        }

        // Função para verificar se um número está presente na árvore binária
        public bool Procurar(int numero)
        {
            return ProcurarRecursivo(raiz, numero);
        }

        private bool ProcurarRecursivo(No raiz, int numero)
        {
            if (raiz == null)
                return false;

            if (raiz.root == numero)
                return true;

            if (numero < raiz.root)
                return ProcurarRecursivo(raiz.Esquerda, numero);
            else
                return ProcurarRecursivo(raiz.Direita, numero);
        }
    }
}
