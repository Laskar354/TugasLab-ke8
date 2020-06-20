using System;
using System.Collections.Generic;
using PolymorphCollection.ClassAnak;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection_2668
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tugas Lab 8 - Polymorphism, Abstraction, Collection\n");
            //object declaration
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2817";
            karyawanTetap.Nama = "Laskar";
            karyawanTetap.GajiBulanan = 2000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "19.11.2100";
            karyawanHarian.Nama = "Jihad";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 600000;

            Sales sales = new Sales();
            sales.Nik = "19.12.1032";
            sales.Nama = "La Ode";
            sales.JumlahPenjualan = 200;
            sales.Komisi = 1500;
            //

            //Object class collective
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            //

            //looping output
            int i = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.\tNIK: {1}\n\tNama: {2} \n\tGaji: {3:N0}\n",
                    i, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                i++;
            }
            
            Console.ReadKey();

        }
    }
}
