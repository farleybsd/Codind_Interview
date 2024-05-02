/*
 A busca em largura é como explorar um labirinto com uma abordagem metódica e paciente. Você começa no ponto de partida e verifica todos os corredores próximos antes de avançar para os mais distantes. É como se você marcasse cada corredor que visita com uma tinta colorida, garantindo que nenhum seja esquecido. Essa técnica garante que você encontre o caminho mais curto para o seu destino, embora às vezes possa levar mais tempo se o labirinto for muito complexo. É como um jogo de esconde-esconde onde você verifica cada esconderijo antes de procurar em outros lugares.
*/

using buscaEmLargura;

// Input
List<int> numeros = new List<int>() { 5, 3, 8, 2, 4, 7, 9 };

// Criando objeto Arvore
ArvoreBinaria arvore = new ArvoreBinaria();

// Colocando Valores na Arvore
foreach (int numero in numeros)
{
    arvore.Inserir(numero);
}

Console.WriteLine("Busca em Largura na árvore binária:");

//BuscaEmLargura
arvore.BuscaEmLargura();

int numeroProcurado = 7;

if (arvore.Procurar(numeroProcurado))
    Console.WriteLine($"\nO número {numeroProcurado} está presente na árvore.");
else
    Console.WriteLine($"\nO número {numeroProcurado} não está presente na árvore.");