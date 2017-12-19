using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPPC.Controllers;
using System.Web.Mvc;
using TechTalk.SpecFlow;
using WebPPC.AcceptanceTests.Support;
using WebPPC.Models;
using WebPPC.AcceptanceTests.Common;
using FluentAssertions;

namespace WebPPC.AcceptanceTests.Drivers.Property
{
    public class PropertyDrivers
    {
        private ActionResult _result;

        public void NavigateToHome()
        {
            using (var controller = new AgencyController())
            {
                _result = controller.Login();
            }
        }

        public void ShowProject(IEnumerable<string> expectedTitles)
        {
            //Act
            var shownProject = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(shownProject, expectedTitles);
        }

        public void ClickDetail(string propertyName)
        {
            var db = new team12Entities();

            int id = db.PROPERTies.FirstOrDefault(r => r.PropertyName == propertyName).ID;

            using (var controller = new ProjectController())
            {
                _result = controller.Detail(id);
            }
        }
        public void ShowDetail(Table expectedDetail)
        {
            //ShowProject(expectedProjet.Rows.Select(r => r["Title"]));
            //Arrange
            var expectedDetails = expectedDetail.Rows.Single();

            //Actual
            var actualProjectDetails = _result.Model<PROPERTY>();

            //Assert
            actualProjectDetails.Should().Match<PROPERTY>(
                b => b.PropertyName == expectedDetails["PropertyName"]);
        }
    }
}
