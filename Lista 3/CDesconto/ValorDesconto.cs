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
	/// Description of ValorDesconto.
	/// </summary>
	public class ValorDesconto : IDesconto
	{
		public ValorDesconto()
		{
		}

        #region IDesconto implementation

        public double CalcularDesconto(double valor1)
		{
			double valor=0;
			do{
				Console.Write("Digite o valor do desconto: ");
				valor=Double.Parse(Console.ReadLine());
			}while(valor>0 && valor<valor1);
			return valor;
			
		}

		#endregion
	}
}
