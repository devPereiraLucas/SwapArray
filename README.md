Este é um simples algoritmo de swap em array em c#.

O projeto esta rodando em .NET Core 8.0

Basta clonar o projeto e rodar o comando `dotnet run` no terminal.

O resultado será um array com os valores trocados de posição.

Exemplo: Hello World -> dlroW olleH

O algoritmo funciona da seguinte forma:

1. Recebe uma string como parametro.
2. Converte a string em um array de char.													
3. Chama a função SwapArray passando o array de char como parametro.
4. A funcão criar um pointeiro (finalPointer) que aponta para o final do array.
5. Cria um char temporario para armazenar o valor de um ponteiro.
6. Cria um loop com uma variavel de controle (initialPointer) que irá rodar até que o ponteiro finalPointer seja menor que o ponteiro inicial.	
7. A variavel temporaria recebe o valor do initialPointer e o initialPointer recebe o valor do finalPointer. Em seguida o finalPointer recebe o valor da variavel temporaria.				
8. O finalPointer é decrementado e o initialPointer é incrementado.	
9. Ao inicio de cada execução do loop, é verificado se o finalPointer é menor que o initialPointer. Se sim, o loop é encerrado.