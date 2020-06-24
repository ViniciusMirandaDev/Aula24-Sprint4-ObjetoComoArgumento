using System;
using System.Collections.Generic;

namespace Aula24_Sprint4_ObjetoComoArgumento
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto){
            carrinho.Add( produto);
        }
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }
        public void MostrarProdutos(){
            if(carrinho != null){

                foreach(Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"R$ {p.Preco.ToString("n2")} - {p.Nome}");
                    Console.ResetColor();
                }
            }
            MostrarTotal();
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor= ConsoleColor.Green;

            if(carrinho != null)
            {
                foreach(Produto p in carrinho){
                    ValorTotal += p.Preco;
                }
                System.Console.WriteLine($"Total do carrinnho R$ {ValorTotal.ToString("n2")}");
            }else{
                System.Console.WriteLine($"Seu carrinho ainda está vazio!");
            }
            Console.ResetColor();    
        }
        public void AlterarItem(int _codigo, Produto _novoproduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoproduto.Preco;
        }

    }
}