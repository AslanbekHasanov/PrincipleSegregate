//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace PrincipleSegregate
{
    internal interface ICloudStoregeProvider 
    {
        void StoreFile(string name);
        void GetFile(string name);
    }
}
