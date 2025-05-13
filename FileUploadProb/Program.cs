using System;
using System.IO;

class FileUploadService
{
    private const int MaxFileSize = 5 * 1024 * 1024; // 5 MB
    private static readonly string[] AllowedExtensions = { ".pdf", ".docx" };

    public void UploadFile(string filePath)
    {
        try
        {
            // Check if file exists
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                throw new Exception("No file selected or file does not exist. Please upload a valid document.");
            }

            // Get file info
            FileInfo fileInfo = new FileInfo(filePath);

            // Check file size
            if (fileInfo.Length > MaxFileSize)
            {
                throw new Exception($"File size exceeds the 5 MB limit. Your file is {(fileInfo.Length / (1024 * 1024.0)):F2} MB.");
            }

            // Check file extension
            string extension = fileInfo.Extension.ToLower();
            if (Array.IndexOf(AllowedExtensions, extension) == -1)
            {
                throw new Exception($"Unsupported file type '{extension}'. Only PDF and DOCX files are allowed.");
            }

            // Simulate file processing
            Console.WriteLine($"File '{fileInfo.Name}' uploaded successfully and is being processed.");
        }
        catch (Exception ex)
        {
            // Handle errors and provide feedback to the user
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        FileUploadService fileUploadService = new FileUploadService();

        Console.WriteLine("Enter the file path to upload:");
        string filePath = Console.ReadLine();

        fileUploadService.UploadFile(filePath);
    }
}