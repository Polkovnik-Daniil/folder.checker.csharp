while (true)
{
    try
    {
        Console.Write("Enter folder path: ");
        string? path = Console.ReadLine();
        Console.Write("Enter file path:   ");
        string? file = Console.ReadLine();
        bool isExistFolder = Directory.Exists(path);
        if (path == null || path == "" || !isExistFolder)
        {
            throw new Exception("Folder is not exists!");
        }
        if (file == null || file == "")
        {
            throw new Exception("File path is uncorrect!");
        }
        DirectoryInfo directory = new DirectoryInfo(path);
        FileInfo[] Files = directory.GetFiles("*.*");
        using (StreamWriter writer = File.AppendText(file))
        {
            foreach (FileInfo File in Files)
            {
                writer.WriteLine(File.Name);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Thread.Sleep(10000);
    Console.Clear();
}

