/*
 * Created by SharpDevelop.
 * User: thiag_001
 * Date: 26/08/2019
 * Time: 17:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Lista_3.CConsumidor;

namespace Lista_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Carrinho carrinho= new Carrinho();
			
			int op=carrinho.menuCarrinho();
			switch(op){
				case 1:
					carrinho.adicionarProdutoUnitario();
					break;
				case 2:
					carrinho.adicionarProdutoComposto();
					break;
				case 3:
					carrinho.mostrarConta();
					break;
			}
			
			Console.ReadKey(true);
		}
	}
}