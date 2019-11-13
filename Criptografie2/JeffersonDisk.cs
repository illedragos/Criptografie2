using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografie2
{
    class JeffersonDisk : ICrypto
    {
        public string Decryption(string cript_text, char[,] Disk, int key)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < cript_text.Length; j++)
            {
                for (int i = 0; i < Disk.GetLength(0); i++)
                    if (Disk[i, j] == cript_text[j])
                        if (i != 0)
                            sb.Append(Disk[i - key, j]);//modular
                        else
                            sb.Append(Disk[Disk.GetLength(0)-1, j]);
            }
            return sb.ToString();
        }

        public string Encryption(string clear_text, char[,] Disk, int key)
        {
            string ln = "   ";
            for (int i = 0; i < Disk.GetLength(0); i++)
            {
                Console.Write(i);
                Console.Write(ln);
                if (i == 9)
                    ln = "  ";
                for (int j = 0; j < Disk.GetLength(1); j++)
                    Console.Write(Disk[i, j]+" ");
                Console.WriteLine();
            }
                    StringBuilder sb = new StringBuilder();
            for (int j = 0; j < clear_text.Length; j++)
            {
                for (int i = 0; i < Disk.GetLength(0); i++)
                    if (Disk[i, j] == clear_text[j])
                        if (i != Disk.GetLength(0) - 1)
                        sb.Append(Disk[i+key,j]);
                        else
                        sb.Append(Disk[0,j]);//revizuit
            }
            return sb.ToString();
        }
    }
}
