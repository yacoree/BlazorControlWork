using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace BlazorControlWork.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream("C:\\Users\\vglif\\Pictures\\Roblox/RobloxScreenShot20221014_211523792.png", FileMode.Open))
            {
                gridFS.UploadFromStream("sss.jpg", fs);
            }
        }

        public void DownloadToLocal()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}DeserializedBall.jpg", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName("sss.jpg", fs);
            }
        }
    }
}
