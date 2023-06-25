using MovieManager;
//data
int choice = 0;
List<Folder> Folders = new List<Folder>();
MenuMethods MenuMethodsInvoker = new MenuMethods();

//Main Menu
while (true)
{
    Console.WriteLine("\n----------------MovieManager----------------");
    Console.WriteLine("Input your desired action as a whole number:");
    Console.WriteLine("1. Add a new folder for your movies");
    Console.WriteLine("2. Add a new movie to an existing folder");
    Console.WriteLine("3. Show all existing folder names");
    Console.WriteLine("4. Show movie list in a chosen folder");
    Console.WriteLine("5. Exit MovieManager");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            MenuMethodsInvoker.AddFolder(ref Folders);
            break;
        case 2:
            MenuMethodsInvoker.AddMovieToFolder(ref Folders);
            break;
        case 3:
            MenuMethodsInvoker.ShowFolderNames(Folders);
            break;
        case 4:
            MenuMethodsInvoker.ShowMovies(Folders);
            break;
        case 5:
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("INVALID COMMAND!");
            break;
    }
}