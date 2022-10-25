string path = "D:\\";
Rekurs(path);
void Rekurs(string path)
{
    if (Directory.Exists(path) && path != "D:\\System Volume Information")
    {
        Console.WriteLine("Файлы: ");
        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
        Console.WriteLine("Подкатолог:");
        string[] dirs = Directory.GetDirectories(path);
        foreach (string dir in dirs)
        {
            Console.WriteLine(dir);
            Rekurs(dir);
        }
    }
}
