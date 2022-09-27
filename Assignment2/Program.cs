namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\manish.jaiswal\\OneDrive - Entain Group\\Documents\\Training\\12\\old.txt";

            FileStream f1 = new FileStream(path, FileMode.OpenOrCreate);

            StreamWriter sw = new StreamWriter(f1);
            sw.WriteLine( "This progam is to move file from location to another");
            sw.WriteLine("Hello");

            string path2 = "C:\\Users\\manish.jaiswal\\OneDrive - Entain Group\\Documents\\Training\\12\\new.txt";

            FileStream f2 = new FileStream(path2, FileMode.OpenOrCreate);

            StreamWriter sw2 = new StreamWriter(f2);
            StreamReader sr = new StreamReader(f1);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                s = sr.ReadLine();
                sw2.WriteLine(s);
            }
            f1.Close();
            f2.Close();
            File.Move(path2, "C:\\Users\\manish.jaiswal\\OneDrive - Entain Group\\Documents\\Training\\11\\new.txt");
            
        }
    }
}