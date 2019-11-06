using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografie2
{
    interface ICrypto
    {
        string Encryption(string clear_text, char[,] Disk, int key);
        string Decryption(string cript_text, char[,] Disk, int key);
    }
}
