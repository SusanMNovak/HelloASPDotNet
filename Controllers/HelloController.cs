using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNet.Controllers
{
    public class HelloController : Controller
    {
        //GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='english' selected>English</option>" +
                "<option value='spanish'>Spanish</spanish>" +
                "<option value='bosnian'>Bosnian</option>" +
                "<option value='vietnamese'>Vietnamese</option>" +
                "<option value='slovak'>Slovak</option></select>" +
                "<input type='submit' value='Greet Me!'/>" +
                "</form>";

            return Content(html, "text/html");

        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string language = "english")
        {
            return Content(CreateMessage(name, language));

        }

        public static string CreateMessage(string name, string language)
        {
            string helloTranslation = "";
            /* switch (language)
             {
                 case "slovak":
                     helloTranslation = "Dobry Den ";
                     break;
                 case "spanish":
                     helloTranslation = "Hola ";
                     break;
                 case "bosnian":
                     helloTranslation = "Zdravo ";
                     break;
                 case "vietnamese":
                     helloTranslation = "Xin Chao ";
                     break;
                 case "english":
                     helloTranslation = "Hello ";
                     break;
             }*/

            if (language == "slovak")
            {
                helloTranslation = "Dobry Den ";
            }

            else if (language == "spanish")
            {
                helloTranslation = "Hola ";
            }

            else if (language == "bosnian")
            {
                helloTranslation = "Zdravo ";
            }

            else if (language == "vietnamese")
            {
                helloTranslation = "Xin Chao ";
            }

                //Default English
            else
            {
                helloTranslation = "Hello ";
            }

            return helloTranslation + name;

           
        }


    }
}

