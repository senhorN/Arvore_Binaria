# Árvore binária 
#

### O que é uma árvore binária

<p> 
É uma árvore onde todos os nós que não são folha possuem dois filhos. Uma árvore binária completa de profundidade ‘d’ é uma árvore estritamente binária onde todas as folhas estão no nível ‘d’.
</p>

### Para que serve uma árvore binária?
<p>
Uma árvore binária serve para o armazenamento de dados na memória do computador e a sua subsequente recuperação. Em uma árvore binária de busca cada nó contém um campo chamado key, podendo haver outras informações, além dos ponteiros left e right.
</p>

### Principal característica de uma árvore binária completa
<p> 
Árvores binárias completas = são árvores binárias onde cada nó que não é folha possui exatos dois filhos. 
<br>
Percurso = são os algoritmos (normalmente algoritmos recursivos) que passam por todos os nós da árvore, existem 3 percursos recursivos principais: em ordem (simétrica), pré-ordem e pós-ordem.
</p>

### Os componentes de uma árvore binária

<p>
Árvore binária é uma estrutura de dados caracterizada por: Ou não tem elemento algum (árvore vazia). OU tem elemento distinto, denominado raiz, com dois apontamentos para duas estruturas diferentes, denominadas sub-árvore esquerda e sub-árvore direita.
</p>

### Percursos de uma árvore binária

<p>
A maioria dos percursos em árvores binárias são intrinsecamente recursivos, pois cada percurso se constitui em visitar nós especiais e subárvores (problemas menores). Percurso em pré-ordem; Percurso em ordem simétrica; 2 visitar a subárvore esquerda em pré-ordem; 3 visitar a subárvore direita em pré-ordem.
</p>

### Altura e Nível

<p>
A altura de uma árvore é a altura de da raiz
<br>
O nível de um nó x é o comprimento do caminho de x até a raiz

![image](https://user-images.githubusercontent.com/90424448/205473412-45a58b8c-4aa0-4cb7-8d57-348e3eff9d86.png)
<br>
`Você pode encontra em alguns artigos com nível representado por grau  `

</p>

### Imagens de árvore binária 

![image](https://user-images.githubusercontent.com/90424448/205473462-8b18ad38-9fd6-4c14-8eca-77dc3152d32f.png)
<br>
### Rerpesentação: Organização de diretórios e subdiretórios
![image](https://user-images.githubusercontent.com/90424448/205473523-97615fda-63bd-4c53-9319-ac95e93c9484.png)

#

### Métodos de caminhamento
<p>
- Caminhar sobre a árvore significa visitar todos os nós;
<br>
- Visitar significa acessar o nó de alguma forma;
</p>

### O método de caminhamento define a ordem das visitas
<p>
- No caso de uma lista encadeada não existem muitas opções;
<br>
- Mas existem várias opções no caso de uma árvore;
</p>

### Métodos usuais: 

<p>
- Pré-ordem;
<br>
- Em-ordem;
<br>
- Pós-ordem;
<br>
- Por nível;
</p>

### Vantagens e desvantagens 

<p>
Vantagens 
<br>
•	Custo de pesquisa O(log n) para o caso médio;
<br>
•	Custo de inserção e remoção: O(log n) para o caso médio;
<br>
•	Custo para obter os registros em ordem: O(n).
<br>

Desvantagens
<br>
•	Pior caso é O(n) tanto pesquisa quanto para inserção e remoção.
</p>

### Conclusão
<p>
A árvore binária tem sua definição recursiva, e por isto é muito utilizada na computação, também em análise de biologia computacional. O algoritmo constrói a paginação ótima quando isso é possível e propõe uma política eficiente para o preenchimento das páginas de uma árvore binária degenerada, baseada na aplicação de empacotamento unidimensional na franja da árvore.
</p>

### Referências 
<p>
https://definirtec.com/ampliar/1875/o-que-e-uma-arvore-binaria-completa
<br>
http://ww2.inf.ufg.br/~hebert/disc/aed1/AED1_10_Arvores.pdf
<br>
http://www.romulosilvadeoliveira.eng.br/discipli/cad-fei/Aula-EstruturasDados-10f-Arvore-binaria.pdf
<br>
http://www3.decom.ufop.br/toffolo/site_media/uploads/2013-1/bcc202/slides/20-21._arvores_(parte_1).pdf

</p>
