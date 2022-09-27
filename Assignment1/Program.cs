using System.Globalization;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\manish.jaiswal\\OneDrive - Entain Group\\Documents\\Training\\12\\PeopleInfo";
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.Create();
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter your name");
                string filename=Console.ReadLine();
                string f= path+"\\"+filename+".txt";
                FileStream f1=new FileStream(f, FileMode.OpenOrCreate);

                StreamWriter sw=new StreamWriter(f1);
                Console.WriteLine("Enter your age");
                int age=Convert.ToInt32(Console.ReadLine());
                sw.WriteLine("Age" + age);

                Console.WriteLine("Enter your Language");
                string lang=Console.ReadLine();
                sw.WriteLine("Language is" + lang);

                Console.WriteLine("Enter your Place");
                string place = Console.ReadLine();
                sw.WriteLine("Place is" + place);

                sw.Close();
                f1.Close();


            }

        }
    }
}