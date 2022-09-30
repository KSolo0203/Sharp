string path = @"G:\Мой диск\Учеба IT\CSharpRepo\Lection7";

CatalogInfo(path);

// DirectoryInfo dir = new DirectoryInfo(path);
// Console.WriteLine(dir.CreationTime);
// FileInfo[] file = dir.GetFiles();

// for (int i = 0; i < file.Length; i++)
// {
//     Console.WriteLine(file[i].Name);
// }

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}