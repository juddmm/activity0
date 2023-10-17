using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class IndiaModel : PageModel
    {
        private readonly ILogger<IndiaModel> _logger;

        public IndiaModel(ILogger<IndiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable12"] = "India is part of the continent of Asia. Most of India forms a peninsula, which means it is surrounded by water on three sides. \r\n    The world's highest mountain range, the Himalaya, rises in the north. The southeast is bordered by the Bay of Bengal, and the southwest is \r\n    bordered by the Arabian Sea.";
            ViewData["Variable13"] = "The Taj Mahal is an ivory-white marble mausoleum on the south bank of the Yamuna river in the Indian city of Agra. \r\n            It was commissioned in 1632 by the Mughal emperor, Shah Jahan (reigned from 1628 to 1658), to house the tomb of his favourite wife, Mumtaz Mahal.";
            ViewData["Variable14"] = "One of the top tourist attractions of Jaipur, the huge Amer Palace Fort sits atop a small hill, and is located at a distance about 11 km from the main city. The magnificent Amer Fort is an extensive palace complex that has been built with pale yellow and pink sandstone, and with white marble.";
            ViewData["Variable15"] = "The Red Fort Complex was built as the palace fort of Shahjahanabad – the new capital of the fifth Mughal Emperor of India, Shah Jahan.";
            ViewData["Variable16"] = "Agra Fort is a historical fort in the city of Agra in India. It was the main residence of the emperors of the Mughal Dynasty till 1638, \r\n            when the capital was shifted from Agra to Delhi. The Agra fort is a UNESCO World Heritage site.It is about 2.5 km northwest of its more famous sister \r\n            monument, the Taj Mahal.";
            ViewData["Variable17"] = "Bohol is the main island of Bohol Province, which also includes 75 smaller islands. The island lies southeast from Cebu Island and southwest of Leyte Island\r\n            in the Central Visayas region. This oval-shaped island is the tenth largest of the Philippine archipelago. Bohol is a haven of tropical natural beauty.";
        }
    }
}