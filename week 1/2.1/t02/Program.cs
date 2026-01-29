static class Program
{
    static void Main()
    {
        List<string> fileList = [
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        ];

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);
        string confirm = "";

        // Your code goes here
        do
        {
            Console.WriteLine("Really delete this file? (y/n)");
            string? choice = Console.ReadLine();
            if (choice == "y" || choice == "n")
            {
                confirm = choice;
            }
        } while (confirm == "");

        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
    }
}
