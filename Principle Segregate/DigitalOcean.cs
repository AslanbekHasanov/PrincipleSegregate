using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

