// See https://aka.ms/new-console-template for more information
// Creating a file system structure
using DesignPattern.Structural.Composite.Clients;

DirectoryClient root = new DirectoryClient("Root");
DirectoryClient documents = new DirectoryClient("Documents");
DirectoryClient downloads = new DirectoryClient("Downloads");

root.AddItem(documents);
root.AddItem(downloads);

documents.AddItem(new FileClient("Resume.docx"));
documents.AddItem(new FileClient("Report.pdf"));

downloads.AddItem(new FileClient("Setup.exe"));
downloads.AddItem(new FileClient("Document.txt"));

// Displaying the file system structure
root.Display(0);