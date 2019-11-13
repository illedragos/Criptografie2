using System;

namespace Criptografie2
{
    class Program
    {
        static void Main(string[] args)
        {
            JeffersonDisk J1 = new JeffersonDisk();
            char[,] Disk = new char[26, 36];
           // for (int i = 0; i < Disk.GetLength(0); i++)
           // {
                for (int j = 0; j < Disk.GetLength(1); j++)
                {
                   // int[] asci = new int[26]; // vectorul fix cu valorile ascii crescatoare
                    int aval =(int)'A';

                    for (int k = 0; k < 26; k++)
                    {
                        Disk[k,j] = (char)aval;
                       // asci[i] = aval;
                        aval++;
                    }

                    Random rand = new Random();
                    //amestecam 'vectorul' aleator, adica coloana din matrice
                    for (int k = 0; k < Disk.GetLength(0) - 1; k++)
                    {
                        int l = rand.Next(k, Disk.GetLength(0));
                        char temp = Disk[k, j];
                        Disk[k, j] = Disk[l, j];
                        Disk[l, j] = temp;
                    }
                }
            //}
            Console.WriteLine(J1.Encryption("CRIPTOGRAFIE", Disk, 1));
            Console.WriteLine(J1.Decryption(J1.Encryption("CRIPTOGRAFIE", Disk, 1), Disk,1));
        }
    }
}
