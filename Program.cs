using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice_06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();
            peoples.Add(new People() { Name = "Yerbol", Age = 15 });
            peoples.Add(new People() { Name = "Adilet", Age = 17 });
            peoples.Add(new People() { Name = "Igor", Age = 16 });

            var xml = new XElement("Peoples", peoples.Select(x => new XElement("person",
                new XAttribute("name", x.Name), new XAttribute("age", x.Age))));

            using(StreamWriter streamWriter = new StreamWriter("people.xml"))
            {
                streamWriter.Write(xml);
            }

            using(StreamReader streamReader = new StreamReader("people.xml"))
            {
                string root = streamReader.ReadLine();
                string element1 = streamReader.ReadLine();
                string element2 = streamReader.ReadLine();
                string element3 = streamReader.ReadLine();
                string rootEnd = streamReader.ReadLine();

                Console.WriteLine(root);
                Console.WriteLine($"\t{element1}");
                Console.WriteLine($"\t{element2}");
                Console.WriteLine($"\t{element3}");
                Console.WriteLine(rootEnd);
            }
            Console.ReadLine();
        }
    }
}
