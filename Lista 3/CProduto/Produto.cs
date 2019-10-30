/*
 * Created by SharpDevelop.
 * User: thiag_001
 * Date: 26/08/2019
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Lista_3.CDesconto;

namespace Lista_3.CProduto
{
	/// <summary>
	/// Description of Produto.
	/// </summary>
	public class Produto
	{
		protected String nome;
		protected double valor;
		protected String descricao;
		protected IDesconto desconto;
		
		public Produto()
		{
		}
		
		public String getNome
		{
			get{return nome;}
		}
		public double getValor
		{
			get{return valor;}
		}
		public String getDescricao
		{
			get{return descricao;}
		}
		public IDesconto getIDesconto
        {
            set { desconto = value; }
        }
		public double ValorComDesconto()
		{
			return desconto.CalcularDesconto(valor);
		}
	}
}
