namespace PrincipleSegregate
{
    internal interface ICloudHostingProvider
    {
        void CreateServer(string region);
        void ListServers(string region);
    }
}
