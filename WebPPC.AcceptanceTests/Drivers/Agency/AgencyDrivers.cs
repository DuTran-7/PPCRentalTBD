using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using WebPPC.Models;
using WebPPC.Controllers;
using System.Web.Mvc;
using WebPPC.AcceptanceTests.Common;
using WebPPC.AcceptanceTests.Support;
using System;
using Moq;
using System.Web;
using System.Web.Routing;
using System.Web.SessionState;

namespace WebPPC.AcceptanceTests.Drivers.Agency
{
    public class AgencyDrivers
    {
        team12Entities db = new team12Entities();
        private ActionResult _result;
        public void GotoLogin()
        {
            var controller = GetAgencyController(null);
            _result = controller.Login();
        }

        public void Login(string email, string password)
        {
            var routeData = new RouteData();
            routeData.Values.Add("action", "List");
            routeData.Values.Add("controller", "Project");

            var agencyController = GetAgencyController(routeData);

            _result = agencyController.Login(email, password);

            if (((RedirectToRouteResult)_result).RouteValues["action"].Equals("List"))
            {
                var projectController = GetProjectController();

                _result = projectController.List();

                var shownProperties = _result.Model<IEnumerable<PROPERTY>>();
                ScenarioContext.Current.Add("agencyProperty", shownProperties);
            }
        }

        public void User(Table user)
        {
            USER u = new USER();
            u.Email = user.Rows[0]["Email"];
            u.Password = user.Rows[0]["Password"];
            u.FullName = user.Rows[0]["FullName"];
            db.USERs.Add(u);
            db.SaveChanges();
            var userID = db.USERs.ToList().FirstOrDefault(n => n.Email == user.Rows[0]["Email"]).ID;
        }

        public void FilterProject(string propertyName)
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Search(propertyName, null, null, null, null,null);
            }
        }

        private static AgencyController GetAgencyController(RouteData routedata)
        {
            var controller = new AgencyController();
            HttpContextStub.SetupController(controller, routedata);
            return controller;
        }

        private static ProjectController GetProjectController()
        {
            var controller = new ProjectController();
            HttpContextStub.SetupController(controller);
            return controller;
        }
    }
}
