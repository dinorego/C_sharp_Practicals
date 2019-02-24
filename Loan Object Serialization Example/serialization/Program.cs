using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace serialization
{
    public class Book
    {
            public String title;
        public double taxnumber;
    };

    
    class Program
    {
        static void Main(string[] args)
        {
            ReadXML();
            /*
            Loan TestLoan = new Loan(10000.0, 0.075, 36, "Neil Black");
            const string FileName = @"../../../SavedLoan.bin";
            if (File.Exists(FileName))
            {
                Console.WriteLine("Reading saved file");
                Stream openFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                TestLoan = (Loan) deserializer.Deserialize(openFileStream);
                TestLoan.TimeLastLoaded = DateTime.Now;
                openFileStream.Close();
            }

            TestLoan.PropertyChanged += (_, __) => Console.WriteLine($"New customer value: {TestLoan.Customer}");

            TestLoan.Customer = "Henry Clay";
            Console.WriteLine(TestLoan.InterestRate);
            TestLoan.InterestRate = 6.1;
            Console.WriteLine(TestLoan.InterestRate);
            */


        }

        public static void ReadXML()
        {
            // First write something so that there is something to read ...  
            var b = new Book { title = "Serialization Overview", taxnumber= 10.8939 };
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(Book));
            var wfile = new System.IO.StreamWriter(@"c:\temp\SerializationOverview.xml");
            writer.Serialize(wfile, b);
            wfile.Close();

            // Now we can read the serialized book ...  
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Book));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"c:\temp\SerializationOverview.xml");
            Book overview = (Book)reader.Deserialize(file);
            file.Close();

            Console.WriteLine(overview.title);

        }

    }


}
