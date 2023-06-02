using Newtonsoft.Json;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

class Programm
{
    //public class Post
    //{
    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //}
    //public class Comments
    //{
    //    public int Id { get; set; }
    //    public string? Body { get; set; }
    //    public int PostId { get; set; }
    //}
    //public class Profile
    //{
    //    public string Name { get; set; }
    //}
    //public class Base
    //{
    //    public List<Post> Posts { get; set; }
    //    public List<Comments> Comments { get; set; }
    //    public Profile Profile { get; set; }
    //}
    public static void Main(string[] args)
    {
        string url = "C:\\Users\\ABDULAZIZ1308\\MyLesson\\file.txt";
        string url2 = "C:\\Users\\ABDULAZIZ1308\\MyLesson\\File2.txt";
        StreamReader reader = new StreamReader(url);

        StreamWriter writer = new StreamWriter(url2);
        while (!reader.EndOfStream) // shartni to'g'irlang
        {
            string line = reader.ReadLine();
            double number = double.Parse(line);
            double root = Math.Sqrt(number);
            writer.Write(root);

        }
        Console.WriteLine("Файли як ба файли ду бо тартиби реша гузоронда шуд!");
        Console.WriteLine("======================================================");
        reader.Close();
        writer.Close();
    

        StreamReader streamReader = new StreamReader(url2);
        string line1 = streamReader.ReadToEnd();
        Console.WriteLine("Кийматхои файли ду:");
        Console.WriteLine(line1);
    }
}

    
