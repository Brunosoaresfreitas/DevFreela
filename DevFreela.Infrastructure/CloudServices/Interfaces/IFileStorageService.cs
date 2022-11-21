namespace DevFreela.Infrastructure.CloudServices.Interfaces
{
    internal interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}
