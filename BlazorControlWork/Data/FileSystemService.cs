using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace BlazorControlWork.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(string path, string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFS.UploadFromStream(name, fs);
            }
        }

        public void DownloadToLocal(User user, string path)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream(path, FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName(user.PathImage, fs);
            }
        }
    }
}
//$"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}DeserializedBall.jpg"