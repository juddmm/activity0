using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class ThailandModel : PageModel
    {
        private readonly ILogger<ThailandModel> _logger;

        public ThailandModel(ILogger<ThailandModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable24"] = "Thailand is home to Buddhist temples, exotic wildlife and spectacular islands. It is also known for its fascinating history, unique culture and delectable local food.\r\n    The tourism industry plays an important role in the Thai economy and contributes an estimated 18.4 percent to the national GDP.";
            ViewData["Variable25"] = "The Grand Palace complex was established in 1782 and it consists of not only royal and throne halls, but also a number of government offices as well as the\r\n            renowned Temple of the Emerald Buddha.";
            ViewData["Variable26"] = "Located in the historical center of Bangkok and within the grounds of the Grand Palace, the temple enshrines Phra Kaew Morakot (the Emerald Buddha),\r\n            the highly revered Buddha image meticulously carved from a single block of jade.";
            ViewData["Variable27"] = "Chiang Mai is a city in mountainous northern Thailand. Founded in 1296, it was capital of the independent Lanna Kingdom until 1558.";
            ViewData["Variable28"] = "The Sanctuary of Truth is an unfinished museum in Pattaya, Thailand designed by Thai businessman Lek Viriyaphan. \r\n            The museum structure is a hybrid of a temple and a castle that is themed on the Ayutthaya Kingdom and of Buddhist and Hindu beliefs.";
            ViewData["Variable29"] = "Wat Rong Khun, better known as the White Temple, is a Buddhist temple and one of the most recognizable temples in Pa O Don Chai, Mueang District, \r\n            Chiang Rai Province, Thailand.";

        }
    }
}