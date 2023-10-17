using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication4.Pages
{
    public class MalaysiaModel : PageModel
    {
        private readonly ILogger<MalaysiaModel> _logger;

        public MalaysiaModel(ILogger<MalaysiaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Variable0"] = "Malaysia is a federation of 13 states and three federal territories in Southeast Asia. It consists of two regions separated by the South China Sea and \r\n    is bordered by Brunei, Indonesia, and Thailand. Malaysia has a strategic location along the Strait of Malacca and the southern South China Sea.";
            ViewData["Variable1"] = "The Petronas Towers, also known as the Petronas Twin Towers and colloquially the KLCC Twin Towers, are an interlinked pair of 88-storey supertall \r\n            skyscrapers in Kuala Lumpur, Malaysia, standing at 451.9 metres.";
            ViewData["Variable2"] = "Legoland Malaysia Resort is a theme park in Iskandar Puteri, Johor, Malaysia. It opened on 15 September 2012 with over 40 interactive rides, \r\n            shows and attractions. It is the first Legoland theme park in Asia and sixth in the world upon its establishment.";
            ViewData["Variable3"] = "Batu Caves is a mogote that has a series of caves and cave temples in Gombak, Selangor, Malaysia. \r\n            It takes its name from the Malay word batu, meaning 'rock'. The cave complex is one of the most popular Hindu shrines outside India, and is dedicated to Murugan.";
            ViewData["Variable4"] = "Kuala Lumpur Tower, colloquially referred to as KL Tower, is a 6-storey, 421-metre-tall telecommunication tower in Kuala Lumpur, \r\n            Malaysia. It is the world's seventh-tallest tower and Malaysia and Southeast Asia's second tallest tower. Its construction was completed on 1994.";
            ViewData["Variable5"] = "Pavilion Kuala Lumpur, also known as Pavilion KL, is a shopping centre situated in the Bukit Bintang district in Kuala Lumpur, Malaysia.";
        }
    }
}