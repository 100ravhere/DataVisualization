using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using DataVisualization.Models;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson.Serialization;


namespace DataVisualization.Controllers
{
    [ApiController]
    [Route("jsondata")]
    public class JsonController : Controller
    {
        public static IMongoCollection<Data> _jsonCollection;

        public JsonController()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");

            var mongoDatabase = mongoClient.GetDatabase("DataVisualization");

            _jsonCollection = mongoDatabase.GetCollection<Data>("datajson");

        }

        [HttpGet]
        public void FetchData(ref IList<Data> db)
        {
            IList<Data> datas = new List<Data>();
            db = _jsonCollection.Find( _ => true).ToList();
            Console.WriteLine("Hellofrom controller");
        }

    }

}