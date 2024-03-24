//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using System;

namespace PrincipleSegregate
{
    internal class DigitalOcean : ICloudStoregeProvider 
    {
        public void GetFile(string name)
        {
            Console.WriteLine("Digital ocean: Fayl ochildi ");
        }

        public void StoreFile(string name)
        {
            Console.WriteLine("Digital ocean: Fayl saqlandi");
        }
    }
}

