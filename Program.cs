namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                string path = "C:\\Users\\manish.jaiswal\\OneDrive - Entain Group\\Documents\\12\\Assign3.txt";
                StreamWriter sw=new StreamWriter(path);
                sw.WriteLine("hello");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NotSupportedException ex)
            {
                Console.Write(ex.Message);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
