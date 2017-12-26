using WebPPC.Models;
using TechTalk.SpecFlow;

namespace WebPPC.AcceptanceTests.Support
{
    [Binding]
    public class DatabaseTools
    {
        [BeforeScenario]
        public void CleanDatabase()
        {
            using (var db = new team12Entities())
            {
               // db.OrderLines.RemoveRange(db.OrderLines);
               // db.Orders.RemoveRange(db.Orders);
               // db.PROPERTies.RemoveRange(db.PROPERTies);
               
                //db.SaveChanges();
            }
        }
    }
}
