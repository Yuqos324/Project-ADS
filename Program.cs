using System;

namespace ProjectADS
{
    class Program
    {
        static void Main(string[] args)
		{
			int pin=5234;
			int masukkan_pin;
			int pilihan;
			int jumlah_saldo=10000000;
			int jumlah_nominal;
			string jwb =null;

			Console.WriteLine("===================================================");
			Console.WriteLine("\tSelamat datang di program ATM Sederhana");
			Console.WriteLine("===================================================");
			Console.Write("\t\tMasukkan PIN = ");
			masukkan_pin=int.Parse(Console.ReadLine());
			Console.WriteLine("===================================================");

			if(masukkan_pin!=pin){
				Console.WriteLine("\t\tPin Anda salah");
				Console.WriteLine("===================================================");
			}else if(masukkan_pin==pin){
				do{
					Console.WriteLine("\t\tPilih transaksi");
					Console.WriteLine("\t\t1. Informasi Saldo");
					Console.WriteLine("\t\t2. Tarik Tunai");
					Console.Write("\t\tMasukkan pilihan: ");
					pilihan=int.Parse(Console.ReadLine());
					Console.WriteLine("===================================================");
						switch(pilihan){

						case 1:
						Console.Write("\tSaldo Anda saat ini: Rp "+jumlah_saldo);
						Console.WriteLine();
						Console.WriteLine("===================================================");
						Console.Write("     Apakah ingin melanjutkan transaksi? "            );
						jwb=(Console.ReadLine());
						Console.WriteLine("");
						break;

						case 2:
						Console.WriteLine("   Masukkan jumlah nominal yang ingin di tarik");
						Console.Write("\t\tMasukkan jumlah: ");
						{
							jumlah_nominal=int.Parse(Console.ReadLine());
							if(jumlah_saldo>=jumlah_nominal)
							{
								Console.WriteLine("===================================================");
								Console.WriteLine("\tSilakan ambil uangnya: Rp "+jumlah_nominal);
								jumlah_saldo = jumlah_saldo-jumlah_nominal;
								Console.WriteLine("---------------------------------------------------");
								Console.Write("\tSaldo Anda saat ini: Rp "+jumlah_saldo);
								Console.WriteLine();
								Console.WriteLine("===================================================");
								Console.Write("     Apakah ingin melanjutkan transaksi? "            );
								jwb=(Console.ReadLine());
							}else if(jumlah_saldo<jumlah_nominal){
								Console.WriteLine("===================================================");
								Console.WriteLine("\t\tSaldo Anda tidak mencukupi");
								Console.WriteLine("===================================================");
								Console.Write("     Apakah ingin melanjutkan transaksi? "            );
								jwb=(Console.ReadLine());
								Console.WriteLine("");
							}
						}
						break;
					}
				} while((jwb == "ya")||(jwb == "Ya"));
				Console.WriteLine("===================================================");	
				Console.WriteLine("     Terima kasih telah menggunakan program ini"    );
				Console.WriteLine("===================================================");		
			}
		}
	}
}

