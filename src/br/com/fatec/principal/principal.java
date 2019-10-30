package br.com.fatec.principal;

import br.com.fatec.Consumidor.Carrinho;

public class principal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
			Carrinho c= new Carrinho();
			
			int op=0;
			do {
				op=c.menuEscolha();
				if(op==1)
					c.adicionarProdutoUnitario();
				else if(op==2)
					c.adicionarProdutoComposto();
				else if(op==3)
					c.mostrarPrecoTotalComprar();
				
			}while(op!=0);
	}

}
