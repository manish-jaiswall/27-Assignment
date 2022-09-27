namespace Assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "C:\\Users\\manish.jaiswal\\OneDrive - Entain Group\\Documents\\12\\Assign3.txt";
               StreamReader sr = new StreamReader(path);
               while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("file not found");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found");
            }
        }
    }
}