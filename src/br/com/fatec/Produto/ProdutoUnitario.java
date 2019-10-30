package br.com.fatec.Produto;

public class ProdutoUnitario extends Produto {
	
	public ProdutoUnitario(String nome, double valor, String descricao) {
		// TODO Auto-generated constructor stub
		this.nome=nome;
		this.valor=valor;
		this.descricao=descricao;
		
	}

	@Override
	public double getValor() {
		// TODO Auto-generated method stub
		return valor;
	}
	
	
	

	
}
