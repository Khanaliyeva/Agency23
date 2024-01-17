namespace Agency23.Heplers
{
    public static class FileManager
    {
        public static string Upload(this IFormFile file, string envPath, string folderPath)
        {
            if (!Directory.Exists(envPath + folderPath))
            {
                Directory.CreateDirectory(envPath + folderPath);
            }
            string fileName = file.FileName;
            string filePath=envPath + folderPath+fileName;
            using(FileStream fileStream=new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            return fileName;
        }

        public static void DeleteFile(this string imgUrl, string envPath, string folderName)
        {
            string filePath=envPath+folderName+imgUrl;
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
