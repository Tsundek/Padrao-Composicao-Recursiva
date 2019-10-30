package br.com.fatec.Calcular;

import br.com.fatec.Desconto.Desconto;

public class CalcularValor {

	private Desconto desconto;
	public double calcularValorTotalDesconto(double valor, double desconto)
	{
		return valor-desconto;
	}
	public void setDesconto(Desconto desconto)
	{
		this.desconto=desconto;
	}
	public double calcularDesconto()
	{
		return desconto.calcularDesconto();
	}
	
	public void inserirDesconto(double valor)
	{
		desconto.inserirParamentroDesconto(valor);
	}
}
