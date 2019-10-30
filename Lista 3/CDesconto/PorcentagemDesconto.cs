/*
 * Created by SharpDevelop.
 * User: thiag_001
 * Date: 26/08/2019
 * Time: 17:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lista_3.CDesconto
{
	/// <summary>
	/// Description of PorcentagemDesconto.
	/// </summary>
	public class PorcentagemDesconto : IDesconto
	{
		private double porcentagem;
		public PorcentagemDesconto()
		{
		}

		#region IDesconto implementation

		public double CalcularDesconto(double valor1)
		{
			do{
				Console.Write("Digite a pocentagem do desconto: ");
				porcentagem=Double.Parse(Console.ReadLine());
				
			}while(porcentagem>0 && porcentagem<100);
			return (valor1*porcentagem)/100;
			
			              
		}

		#endregion
	}
}
