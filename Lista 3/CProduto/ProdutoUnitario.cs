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
	/// Description of ProdutoUnitario.
	/// </summary>
	public class ProdutoUnitario : Produto
	{
		public ProdutoUnitario(String nome, double valor,String descricao, IDesconto desco)
		{
			this.nome= nome;
			this.valor=valor;
			this.desconto=desco;
			this.descricao=descricao;
		}

		#region implemented abstract members of Produto

		public double valorTotal()
		{
			return valor;
		}

		#endregion
	}
}
