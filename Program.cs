using System;

namespace ObjetoseArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto prod1 = new Produto("Relogio",1 ,50.00f);
            Produto prod2 = new Produto("Mesa de vidro",2 ,200.99f);
            Produto prod3 = new Produto("Televisão 4k LG",3 ,5000.99f);
            Produto prod4 = new Produto("Radio",4 ,40.99f);

            cart.Adicionar(prod1);
            cart.Adicionar(prod2);
            cart.Adicionar(prod3);
            cart.Adicionar(prod4);

            cart.Deletar(prod3);

            Produto prodAlterado = new Produto("Televisão 4k LG", 3, 4000.99f);
            cart.Alterar(4, prodAlterado);

            cart.Ler();
            cart.MostrarTotal();
        }
    }
}
