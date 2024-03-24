//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

namespace PrincipleSegregate
{
    internal interface ICloudHostingProvider
    {
        void CreateServer(string region);
        void ListServers(string region);
    }
}
