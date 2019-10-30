package br.com.fatec.Produto;

import java.util.List;

public class ProdutoComposto extends Produto {
	private List<Produto> produtos;
	public ProdutoComposto(List<Produto> produtos, String nome, String descricao) {
		// TODO Auto-generated constructor stub
		this.produtos=produtos;
		this.nome=nome;
		this.descricao=descricao;
	}
	
	public List<Produto> getProdutos()
	{
		return produtos;
	}

	@Override
	public double getValor() {
		// TODO Auto-generated method stub
		double valorTotal=0;
		for(int x=0;x<produtos.size();x++)
		{
			valorTotal+=produtos.get(x).getValor();
		}
		return valorTotal;
	}
	

}
