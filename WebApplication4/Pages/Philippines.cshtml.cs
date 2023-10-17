using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class PhilippinesModel : PageModel
    {
        private readonly ILogger<PhilippinesModel> _logger;

        public PhilippinesModel(ILogger<PhilippinesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable18"] = "The Philippines is an archipelago consisting of 7,100 islands with a total land area of approximately 300,000 square kilometers. \r\n    It has three major island groups-Luzon in the north, Visayas in the middle and Mindanao further down in the South. The current \r\n    population of the Philippines is about 80 million people..";
            ViewData["Variable19"] = "Palawan is westernmost province of the Philippines and is named after its largest island.\r\n            The archipelago comprises no less than 1,780 islands and islets across a 14,000-sq-km area, making it the largest province in the country.";
            ViewData["Variable20"] = "Siargao is an island of nine municipalities in the province of Surigao del Norte. Known as the “Surfing Capital of the Philippines”, \r\n            Siargao is mainly responsible for introducing surfing to the country.";
            ViewData["Variable21"] = "Batanes boasts its local attractions like historic churches, unique architecture of Ivatan houses, intermittent sandy beaches, countryside panoramic views,\r\n            rock formations and rugged terrains. GEOGRAPHY: Batanes is the smallest province of the Philippines, with a land mass only one third of that of Metro Manila.";
            ViewData["Variable22"] = "Boracay, one of the top Islands in the Philippines, is popular for its beaches and blessed with a long stretch of powdery white sand,\r\n            crystal clear and azure waters, and a stunning sunset. Boracay is the most iconic island in the Philipines and has won multiple awards in previous years.";
            ViewData["Variable23"] = "Bohol is the main island of Bohol Province, which also includes 75 smaller islands. The island lies southeast from Cebu Island and southwest of Leyte Island\r\n            in the Central Visayas region. This oval-shaped island is the tenth largest of the Philippine archipelago. Bohol is a haven of tropical natural beauty.";

        }
    }
}