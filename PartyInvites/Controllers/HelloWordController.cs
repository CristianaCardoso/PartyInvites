using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PartyInvites.Controllers
{
    public class HelloWordController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()


        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome()
        {
            string message;

            int hour = DateTime.Now.Hour;  //vai buscar a hora atual

            //verificar se é de dia
            if (hour >=6 && hour <12 )
            {
                message = "Good morning";
            }
            else if (hour >= 12 && hour < 20)
            { 
                message = "Good afternoon"; 
            } else 
            { message = "Good evening";
            

        }

        //6-12 dia
        //12-20 tarde
        //20- noite

        ViewBag.Message = message;

            return View() ;
        }
    }
}
