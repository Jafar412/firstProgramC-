using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace userlogin
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the user name : ");
            string x = Console.ReadLine();
            var Connection = "mongodb://localhost";
            var client = new MongoClient(Connection);
            var Db = client.GetDatabase("users");
            var Collection = Db.GetCollection<BsonDocument>("accounts");
            var doc = Collection.Find(new BsonDocument("user", x)).ToList();

            if (doc.Count==0)
            {
                Console.WriteLine("The user is not found");
            }
            else
            {
                Console.WriteLine("The user is found");
            }

            Console.ReadLine();


        }
    }
}
