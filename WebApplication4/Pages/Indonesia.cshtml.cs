using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class IndonesiaModel : PageModel
    {
        private readonly ILogger<IndonesiaModel> _logger;

        public IndonesiaModel(ILogger<IndonesiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable11"] = "Indonesia, officially the Republic of Indonesia, is an archipelagic country in Southeast Asia and Oceania between the Indian and Pacific oceans. \r\n    It consists of over 17,000 islands, including Sumatra, Java, Sulawesi, and parts of Borneo and New Guinea.";
            ViewData["Variable6"] = "Mandala Suci Wenara Wana, also known as Ubud Monkey Forest, is a sanctuary located at Padangtegal Ubud, Bali, Indonesia";
            ViewData["Variable7"] = "Borobudur, also transcribed Barabudur is a 9th-century Mahayana Buddhist temple in Magelang Regency, not far from the city \r\n            of Magelang and the town of Muntilan, in Central Java, Indonesia. It is the world's largest Buddhist temple";
            ViewData["Variable8"] = "Tanah Lot is located in Tabanan, only around 30 km away from Denpasar. The temple is located some 300 meters offshore. \r\n            The history of Tanah Lot temple was believed to date back to the 16th century, by Dang Hyang Nirartha, a respected \r\n            religious figure in Bali.";
            ViewData["Variable9"] = "Prambanan is a 9th-century Hindu temple compound in the Special Region of Yogyakarta, in southern Java, Indonesia, \r\n            dedicated to the Trimūrti, the expression of God as the Creator, the Preserver and the Destroyer.";
            ViewData["Variable10"] = "Uluwatu Temple is a Balinese Hindu sea temple located in Uluwatu. The temple is regarded as one of the sad kahyangan and \r\n            is dedicated to Sang Hyang Widhi Wasa in his manifestation as Rudra.";

        }
    }
}