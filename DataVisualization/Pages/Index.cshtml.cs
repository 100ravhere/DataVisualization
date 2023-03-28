using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataVisualization.Controllers;
using DataVisualization.Models;
namespace DataVisualization.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Data> db;
        public string abc = "hello";
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            JsonController obj = new JsonController();
            db = new List<Data>();
            obj.FetchData(ref db);
            Console.WriteLine(db);
            Console.WriteLine("Hello");

        }

    }
}