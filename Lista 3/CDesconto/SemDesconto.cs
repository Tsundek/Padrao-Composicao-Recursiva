/*
 * Created by SharpDevelop.
 * User: thiag_001
 * Date: 26/08/2019
 * Time: 17:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Lista_3.CDesconto
{
	/// <summary>
	/// Description of SemDesconto.
	/// </summary>
	public class SemDesconto : IDesconto
	{
		public SemDesconto()
		{
		}

		#region IDesconto implementation

		public double CalcularDesconto(double valor1)
		{
			return 0;
		}

		#endregion
	}
}
