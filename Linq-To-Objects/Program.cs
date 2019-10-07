using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;

namespace Linq_To_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { -5 , -4 , -3 , -2 , -1 , 0 , 1 , 2 , 3 , 4 , 5 , 100 , 200 , 300 , -1000, 1,2,3,4,5 };
            string str = "dsgkælsdkglædskgkkLÆSDKGØÆWSHÆEMRHÆMERÆMJEQÅPDDOSPÅOWLWQWLYKÆH";
            List<string> cities = new List<string>() {"ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI",
                                                      "AMSTERDAM", "ABU DHABI", "PARIS" };
            string str0 = "DET her er et STYKKE TEKST med BLANDET casing.";
            //FindEvenNumbersQuerySyntax(numbers);
            //NumberOrcurrence(numbers);
            //WordOrcurrence(str);
            //PrintWordsAssignment44(cities);
            //PrintUppercaseWords(str0);
            //GetDataFromFilmDB();
              GetDataFromNorthwindDB();



            Console.ReadKey();
        }

        private static void FindEvenNumbersQuerySyntax(List<int> numbers)
        {
            Console.WriteLine("LINQ Query Syntax - Find All Even Numbers In A List\n");

            var result = from n in numbers
                         where n % 2 == 0
                         select n;
            var resultMethodSyntax = numbers.Where(n => n % 2 == 0);
            foreach (var number in resultMethodSyntax)
            {
                Console.WriteLine($"{number}");
            }
        }

        private static void NumberOrcurrence(List<int> numbers)
        {
            var res = from n in numbers
                      group n by n into nrcount
                      select new { nrcount.Key, numcount = nrcount.Count() };
            
            numbers.Sort();
            Console.WriteLine("\n");
            foreach (var n in numbers.GroupBy(n => n))
            {
                Console.WriteLine("{0} - {1}", n.Key, n.Count());
            }
            Console.WriteLine("\n");
            foreach (var number in res)
            {
                Console.WriteLine("{0} - {1}", number.Key, number.numcount);
            }
        }

        private static void WordOrcurrence(string str)
        {
            var res = from s in str
                         group s by s into wdcount
                         select new { wdcount.Key, wordcount = wdcount.Count() };

            foreach (var strr in res)
            {
                Console.WriteLine("{0} - {1}", strr.Key, strr.wordcount);
            }

            Console.WriteLine("\n");
            foreach (var s in str.GroupBy(s => s))
            {
                Console.WriteLine("{0} - {1}", s.Key, s.Count());
            }
            Console.WriteLine("\n");
        }

        private static void PrintWordsAssignment44(List<string> cities)
        {
            var res = from c in cities
                      where c.StartsWith("N")
                      && c.EndsWith("I")
                      select c;
            var resres = cities.Where(c => c.StartsWith("N")
                      && c.EndsWith("I"));
            foreach (var c in resres)
            {
                Console.WriteLine(c);
            }
        }

        private static void PrintUppercaseWords(string str0)
        {
            List<string> resNew = str0.Split(' ').Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal)).ToList();
            foreach (var item in resNew)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private static void GetDataFromFilmDB()
        {
            using (DataContext db = new DataContext("Server=10.205.48.42,49172;Database=Film;User Id=AspIT;Password=Server2012") )
            {
                Table<ClassFilm> Films = db.GetTable<ClassFilm>();
                IQueryable<ClassFilm> custQueryNew = Films.Where(x => x.filmid > 0);
                foreach (ClassFilm nf in custQueryNew)
                {
                    Console.WriteLine($"{nf.filmid},{nf.titel},{nf.land},{nf.genre},{nf.oscars}");
                }
            }
        }

        private static void GetDataFromDBFilmDBWithOneAndLessThanFourOscars()
        {
            using (DataContext db = new DataContext("Server=10.205.48.42,49172;Database=Film;User Id=AspIT;Password=Server2012"))
            {
                Table<ClassFilm> Films = db.GetTable<ClassFilm>();

                IQueryable<ClassFilm> custQueryNew = Films.Where(x => x.oscars > 0).Where(x => x.oscars < 4);
                foreach (ClassFilm nf in custQueryNew)
                {
                    Console.WriteLine($"{nf.filmid},{nf.titel},{nf.land},{nf.genre},{nf.oscars}");
                }
            }
        }
        private static void GetDataFromNorthwindDB()
        {
            using (DataContext db = new DataContext("Server=10.205.48.42,49172;Database=Northwind;User Id=AspIT;Password=Server2012"))
            {
                Table<ClassCustomer> Customers = db.GetTable<ClassCustomer>();
                IQueryable<ClassCustomer> custQueryNew = Customers.Where(x => x.City == "London");

                foreach (ClassCustomer nf in custQueryNew)
                {
                    Console.WriteLine($"{nf.Address},{nf.City},{nf.CompanyName},{nf.ContactName},{nf.ContactTitle},{nf.Country},{nf.CustomerID},{nf.Fax},{nf.Phone},{nf.PostalCode},{nf.Region}");
                }
            }
        }
    }
}