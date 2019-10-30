package br.com.fatec.Produto;

public abstract class Produto {
	 protected String nome;
	 protected String descricao;
	 protected double valor;

	 public abstract double getValor();
	 
	 public String getNome()
	 {
		 return nome;
	 }
	 public String getDescricao()
	 {
		 return descricao;
	 }
	
	 
	 
}
