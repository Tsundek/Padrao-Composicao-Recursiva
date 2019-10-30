/*
 * Created by SharpDevelop.
 * User: thiag_001
 * Date: 26/08/2019
 * Time: 17:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lista_3.CProduto
{
	/// <summary>
	/// Description of ProdutoComposto.
	/// </summary>
	public class ProdutoComposto : Produto
	{
		List<Produto> produtos;
		public ProdutoComposto(List<Produto> produtos)
		{
			this.produtos=produtos;
		}
		
		#region implemented abstract members of Produto

		public double valorTotal()
		{
			double valorTotal=0;
			for(int x=0;x<produtos.Count;x++)
			{
				valorTotal+=produtos[x].getValor;
			}
			return valorTotal;
		}

		#endregion
	}
}
