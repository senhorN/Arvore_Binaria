using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreBinaria
{
    class tree
    {

        Noh raiz;
        Noh anterior;
        Noh atual;
        Noh pai;

        #region Criar
        public void criar()
        {
            //se raiz for diferente de vazio então
            if (raiz != null)
            {
                raiz = null;
            }
        }
        #endregion
        #region Inserir
        public void Inserir(int valor)
        {
            Noh nn = new Noh();

            if (raiz == null)
            {
                nn.Valor = valor;
                nn.Esquerda = null;
                nn.Direita = null;
                raiz = nn;

                Console.WriteLine("Alocado na raiz: " + nn.Valor);
            }
            else
            {
                atual = raiz;
                anterior = null;
                Procurar(atual, valor);
            }           
        }
        #endregion

        #region Procurar
        public void Procurar(Noh atual, int valor)
        {
            anterior = atual;
            pai = anterior;

            if (valor < atual.Valor)
            {
                atual = atual.Esquerda;

            }
            else
            {
                atual = atual.Direita;
            }
            if (atual != null)
            {
                Procurar(atual, valor);
            }
            else
            {
                Noh nn = new Noh();
                int verificar = 0;

                if (valor < anterior.Valor)
                {
                    nn.Valor = valor;
                    nn.Esquerda = null;
                    nn.Direita = null;
                    anterior.Esquerda = nn;

                    if (pai != null)
                    {
                        verificar = pai.Valor;
                    }
                    Console.WriteLine("Alocado a esquerda " + verificar + " valor: " + nn.Valor);
                }
                else
                {
                    nn.Valor = valor;
                    nn.Esquerda = null;
                    nn.Direita = null;
                    anterior.Direita = nn;

                    if (pai != null)
                    {
                        verificar = pai.Valor;
                    }
                    Console.WriteLine("Alocando a direita " + verificar + " valor: " + nn.Valor);
                }
            }
        }
        #endregion
    }
}
