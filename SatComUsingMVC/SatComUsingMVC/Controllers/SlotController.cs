using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SatComUsingMVC.Controllers
{
    public class SlotController : Controller
    {
        // GET: Slot
        
        public ActionResult Index()
        {
            return View();
        }
        
        //       
        // GET: /Store/    
        /*   
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        */
        //       
        // GET: /Store/Browse       
        public string Browse()
        {
            return "Hello from Store.Browse()";
        }       
        //       
        // GET: /Store/Details       
        public string Details()
        {
            return "Hello from Store.Details()";
        } 
    }
}