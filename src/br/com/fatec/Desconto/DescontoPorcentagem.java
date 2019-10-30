package br.com.fatec.Desconto;

import javax.swing.JOptionPane;

public class DescontoPorcentagem implements Desconto {

	private double porcentagem=0;
	private double valor=0;
	
	@Override
	public double calcularDesconto() {
		// TODO Auto-generated method stub
		
		return (valor*porcentagem)/100;
	}

	@Override
	public void inserirParamentroDesconto(double valor) {
		// TODO Auto-generated method stub
		try {
			do {
				porcentagem=Double.parseDouble(JOptionPane.showInputDialog("Escreva o valor da porcentagem:"));
			}while(porcentagem<1 && porcentagem>=100);
		}catch(Exception e)
		{
			inserirParamentroDesconto(valor);
		}
		this.valor=valor;
	}

}
