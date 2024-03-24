namespace PrincipleSegregate
{
    internal interface ICloudStoregeProvider 
    {
        void StoreFile(string name);
        void GetFile(string name);
    }
}
