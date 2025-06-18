using Proxy;

var fileListing = new FileListing("file1.txt", "file2.txt", "file3.txt");

fileListing.ShowListing();

Console.WriteLine();

//The file contents are loaded only when needed
fileListing.ShowCombinedContents();