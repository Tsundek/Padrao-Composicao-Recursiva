package br.com.fatec.Consumidor;

import java.util.ArrayList;
import java.util.List;

import javax.swing.JOptionPane;

import br.com.fatec.Calcular.CalcularValor;
import br.com.fatec.Desconto.Desconto;
import br.com.fatec.Desconto.DescontoPorcentagem;
import br.com.fatec.Desconto.DescontoValor;
import br.com.fatec.Desconto.SemDesconto;
import br.com.fatec.Produto.Produto;
import br.com.fatec.Produto.ProdutoComposto;
import br.com.fatec.Produto.ProdutoUnitario;

public class Carrinho {

	private List<Produto> itens;
	private List<CalcularValor> calculoValores;
	
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public Carrinho() {
		// TODO Auto-generated constructor stub
		itens= new ArrayList<>();
		calculoValores= new ArrayList();
	}
	
	public int menuEscolha()
	{
		int op=0;
		try {
		op=Integer.parseInt(JOptionPane.showInputDialog("---------------------------------------------------------"+
				"\n_______ Carrinho de Compras! _______"
				+ "\n---------------------------------------------------------\n"
				+ "1 - Inserir Produto Unitario\n"
				+ "2 - Inserir Kit de Produto\n"
				+ "3 - Mostra Preco total com o desconto\n"
				+ "0 - Sair\n---------------------------------------------------------\nEscolha a opção:"));
		
		return op;
		}catch (Exception e) {
			// TODO: handle exception
			this.menuEscolha();
			return -1;
			
		}
	}
	
	private Produto adicionarProduto()
	{
		@SuppressWarnings("unused")
		Produto produto;
		String nome, descricao;
		double valor=0;
		try {
			nome=JOptionPane.showInputDialog("Escreva o nome do produto:");
			descricao=JOptionPane.showInputDialog("Escreva a descricao do produto:");
			valor= Double.parseDouble(JOptionPane.showInputDialog("Digite o valor do produto:"));
		}catch (Exception e) {
			adicionarProduto();
			return null;
		}
		
		return produto= new ProdutoUnitario(nome, valor, descricao);
	}
	private Desconto adicionaDesconto()
	{
		int op=0;
		try {
			do {
				op= Integer.parseInt(JOptionPane.showInputDialog("Tipo de Desconto:\n"
					+ "1 - Sem Desconto\n"
					+ "2 - Desconto com porcentagem\n"
					+ "3 - Valor do Desconto\n"
					+ "Escolha:"));
	
			}while(op<1 && op>3);
		}catch (NullPointerException e) {
			return null;
		}catch (Exception e) {
			adicionaDesconto();
			return null;
		}
		if(op==1)
			return new SemDesconto();
		else if(op==2)
			return new DescontoPorcentagem();
		else
			return new DescontoValor();
		
	}
	public void adicionarProdutoUnitario()
	{
		Produto produto=adicionarProduto();
		CalcularValor calculo= new CalcularValor();
		calculo.setDesconto(adicionaDesconto());
		calculo.inserirDesconto(produto.getValor());
		
		calculoValores.add(calculo);
		itens.add(produto);
	}
	public void adicionarProdutoComposto()
	{
		List<Produto> produtos= new ArrayList<>();
		int op;
		String nome, descricao;
		nome=JOptionPane.showInputDialog("Escreva o nome do kit:");
		descricao=JOptionPane.showInputDialog("Digite o que tem dentro do kit:");
		do {
			
			produtos.add(adicionarProduto());
			op=Integer.parseInt(JOptionPane.showInputDialog("Deseja Inserir mais itens do kit?\n"
					+ "Digite 2 para sair e 1 para continuar:"));
		}while(op!=2);
		
		Produto kit= new ProdutoComposto(produtos, nome,descricao);
		CalcularValor calculo= new CalcularValor();
		calculo.setDesconto(adicionaDesconto());
		calculo.inserirDesconto(kit.getValor());
		
		calculoValores.add(calculo);
		itens.add(kit);
	}
	
	public void mostrarPrecoTotalComprar()
	{
		double valorTotal=0, valor=0;
		String r="";
		for(int x=0;x<itens.size();x++)
		{
			valor=calculoValores.get(x).calcularValorTotalDesconto(
						itens.get(x).getValor(),
						calculoValores.get(x).calcularDesconto());
			
			r+="Produto: "+itens.get(x).getNome()+
					"\nDescricão: "+itens.get(x).getDescricao()+
					"\nValor: "+valor+"\n------------------------------\n";
			valorTotal+=valor;
		}
		JOptionPane.showMessageDialog(null, "Itens:\n"+r+"\nValor total: "+valorTotal);
	}
}

