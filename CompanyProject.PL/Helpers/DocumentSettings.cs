using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace CompanyProject.PL.Helpers
{
    public static class DocumentSettings
    {
     public static string UploadFile(IFormFile file, string FolderName)
        {
          string FolderPath=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\Files",FolderName);
          string FileName = $"{Guid.NewGuid()} {file.FileName}";
          string FilePath=Path.Combine(FolderPath,FileName);
            using var fs = new FileStream(FilePath, FileMode.Create);
            file.CopyTo(fs);
            return FileName;
        }
    }
}
