/*
 * Created by SharpDevelop.
 * User: thiag_001
 * Date: 26/08/2019
 * Time: 18:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Lista_3.CConsumidor;
using Lista_3.CDesconto;
using Lista_3.CProduto;

namespace Lista_3.CConsumidor
{
	/// <summary>
	/// Description of Carrinho.
	/// </summary>
	public class Carrinho
	{
		List<Produto> itens=null;
		public Carrinho()
		{
			itens= new List<Produto>();
		}
		public int menuCarrinho()
		{
			Console.Clear();
			int escolha=0;
			
			try{
				Console.Write("Escolha as opções:\n1- Inserir produto Unitario"+
				                  "\n2- Inserir produto composto:");
				escolha=int.Parse(Console.ReadLine());
			
			}catch(FormatException ex){
				Console.WriteLine();
				this.menuCarrinho();
			}
			return escolha;
		}
		public void adicionarProdutoComposto()
		{
			
				List<Produto> produtos= new List<Produto>();
				Produto produtosComp;
				String op;
				
				do{
					Console.WriteLine();
					var p= adicionarProduto();
					if(p!=null)
						produtos.Add(p);
						
					Console.Write("Deseja continuar S(Sim) ou N(Não):");
					op=Console.ReadLine().ToUpper();
						
				}while(op.Equals("S"));
				
				if(produtos.Count!=0){
					produtosComp= new ProdutoComposto(produtos);
					itens.Add(produtosComp);
				}
				
				Console.WriteLine(itens.Count);			
			
		}
		public void adicionarProdutoUnitario()
		{
			itens.Add(adicionarProduto());
		}
		private Produto adicionarProduto()
		{
			int op=0;
			Produto produto;
			String nome="",desc="";
			double valor=0;
			
			Console.Write("Nome do produto: ");
			nome= Console.ReadLine();
			Console.Write("Descricão do produto:");
			desc=Console.ReadLine();
			Console.Write("Valor do produto:");
			try{
			valor= Double.Parse(Console.ReadLine());
			Console.Write("Tipo de Desconto:\n1- Sem Desconto"+
						       "\n2- Com Porcentagem"+
						       "\n3- Com desconto de valor:");
			op= int.Parse(Console.ReadLine());
			}catch(FormatException ex){
				Console.WriteLine("Erro");
				return null;
			}
			
			if(nome!=null && valor>0 && desc!=null){
				if(op==1)
				{
					produto= new ProdutoUnitario(nome,valor,desc,new SemDesconto());
					Console.WriteLine("Inserirdo com sucesso");
					return produto;
				}
				else if(op==2)
				{
					produto= new ProdutoUnitario(nome,valor,desc,new PorcentagemDesconto());
					Console.WriteLine("Inserirdo com sucesso");
					return produto;
				}
				else if(op==3)
				{
					produto= new ProdutoUnitario(nome,valor,desc,new ValorDesconto());
					Console.WriteLine("Inserirdo com sucesso");
					return produto;
				}
				return null;
			}else{
				return null;
			}
			
			
			
		}
		
		public void mostrarConta()
		{
			double valorTotal=0;
			Console.Clear();
			for(int x=0;x<itens.Count;x++)
			{
				if(itens[x] is ProdutoUnitario)
				{
					ProdutoUnitario produto = (ProdutoUnitario)itens[x];
					valorTotal=produto.valorTotal();
				}
				if(itens[x] is ProdutoComposto)
				{
					ProdutoComposto produto = (ProdutoComposto)itens[x];
					valorTotal+=produto.valorTotal();
				}
			}
			Console.WriteLine(valorTotal);
			
		}
		
		
		
	}
}
