package br.com.fatec.Desconto;

import javax.swing.JOptionPane;

public class DescontoValor implements Desconto {

	private double desconto=0;
	

	@Override
	public double calcularDesconto() {
		// TODO Auto-generated method stub
		return desconto;
	}

	@Override
	public void inserirParamentroDesconto(double valor) {
		// TODO Auto-generated method stub
		try {
			do {
				desconto=Double.parseDouble(JOptionPane.showInputDialog("Escreva o valor do desconto:"));
				System.out.println(desconto+" > "+valor);
			}while(desconto>valor);
		}catch(Exception e)
		{
			inserirParamentroDesconto(valor);
		}
	}

}
