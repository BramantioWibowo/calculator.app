using System;
					
public class Program
{
	private double tambah (double a, double b){
 	
	return ( a + b );
	}
	
	private double kurang (double a, double b ){
	return ( a - b );
	}
	
	private double kali (double a, double b ){
	return ( a * b );
	}
	
	private double bagi (double a, double b ){
	return (a / b );
	}
	
	public void Main()
	{
		
		double bil1, bil2;
		char pilihan;

		Console.WriteLine("Program Kalkulator Sederhana	");
		Console.WriteLine("Masukan Pilihan ");
		Console.WriteLine("(A) Penjumlahan  (B) Pengurangan	");
		Console.WriteLine("(C) Perkalian	(D) Pembagian	");
		Console.WriteLine(" Masukan Pilihan		: ");
		pilihan = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("\n");

		if ( pilihan == 'A' || pilihan == 'a' ) {
			Console.WriteLine("Masukan Bilangan pertama : ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Masukan Bilangan kedua : ");
			bil2 = Convert.ToDouble(Console.ReadLine());;
			Console.WriteLine("Hasilnya Adalah : "+tambah(bil1,bil2)+" ");
			
		}
		
		else if ( pilihan == 'B' || pilihan == 'b' ) {
			Console.WriteLine("Masukan Bilangan pertama : ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Masukan Bilangan kedua : ");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hasilnya Adalah : "+kurang(bil1,bil2)+" ");
		}
		
		else if ( pilihan == 'c' || pilihan == 'C' ) {
			Console.WriteLine("Masukan Bilangan pertama : ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Masukan Bilangan kedua : ");
			bil2 =  Convert.ToDouble(Console.ReadLine());;
			Console.WriteLine("Hasilnya Adalah : "+kali(bil1,bil2)+" ");
			
		}
		
		else if ( pilihan == 'D' || pilihan == 'd' ) {
			Console.WriteLine("Masukan Bilangan pertama : ");
			bil1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Masukan Bilangan kedua : ");
			bil2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Hasilnya Adalah : "+bagi(bil1,bil2)+" ");
		}
		
		
	}
}