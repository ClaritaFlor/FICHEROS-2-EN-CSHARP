/*
 * Created by SharpDevelop.
 * User: clarita
 * Date: 7/24/2018
 * Time: 8:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;

namespace Ficheros2
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Imprimir letras a
			try {
				Console.WriteLine("IMPRESION DE LETRAS a");
				string fileName4 = "refranes.txt";
				int letter = 0;
				FileStream stream4 = new FileStream(fileName4, FileMode.Open, FileAccess.Read);
				BinaryReader reader4 = new BinaryReader(stream4);

				while (letter != -1) {
					letter = reader4.Read();
					if (letter != -1) {
						if (letter == 97)
							Console.Write((char)letter);
					}
				}
				reader4.Close();
				stream4.Close();
				Console.WriteLine("");
			} catch {
				Console.WriteLine("Error");
			}
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			//contar letras a
			try {
				Console.WriteLine("");
				Console.WriteLine("CONTADOR DE LETRAS a");
				string fileName5 = "refranes.txt";
				int letter = 0;
				FileStream stream5 = new FileStream(fileName5, FileMode.Open, FileAccess.Read);
				BinaryReader reader5 = new BinaryReader(stream5);
				int contA=0;
				while (letter != -1) {
					letter = reader5.Read();
					if (letter != -1) {
						if (letter == 97)
							contA++;
					}
				}
				reader5.Close();
				stream5.Close();
				Console.WriteLine("Nro. de letras a: "+contA);
			} catch {
				Console.WriteLine("Error");
			}
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	}
}