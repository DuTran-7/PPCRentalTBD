
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebPPC.Models;
using WebPPC.Controllers;
using System.Web.Mvc;
using TechTalk.SpecFlow;



namespace WebPPC.AcceptanceTest.Driver.Fillter
{
    public class FilterDriver
    {
        public void InsertData(Table projectCC)
        {
            using (team12Entities db  = new team12Entities())
            {
                foreach(var item in projectCC)
                {
                    
                }
            }     
        }
    }
}
