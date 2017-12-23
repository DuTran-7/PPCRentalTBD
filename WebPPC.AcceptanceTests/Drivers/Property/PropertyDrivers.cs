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
        team12Entities db = new team12Entities();
        public void NavigateToHome()
        {
            using (var controller = new AgencyController())
            {
                _result = controller.Login();
            }
        }

        internal void NavigateToPostProject()
        {
            using (var controller = new ProjectController())
            {
                _result = controller.PostProject();
            }
        }

        public void ShowProject(IEnumerable<string> expectedTitles)
        {
            //Act
            var shownProject = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(shownProject, expectedTitles);
        }

        internal void InsertProject(Table duAn)
        {
            var row = duAn.Rows[0];
            var databro = new PROPERTY
            {
                PropertyName = row["PropertyName"],
                Avatar = row["Avatar"],
                BedRoom = int.Parse(row["BedRoom"]),
                PropertyType_ID = int.Parse(row["Property_Type"]),
                BathRoom = int.Parse(row["BathRoom"]),
                Content = row["Content"],
                Area = row["BathRoom"],
                District_ID = int.Parse(row["District"]),
                Ward_ID = int.Parse(row["Ward"]),
                Street_ID = int.Parse(row["Street"])
            };
            db.PROPERTies.Add(databro);
            db.SaveChanges();
            ScenarioContext.Current.Add("Property", databro);
        }

        internal void SaveProject()
        {
            //Arange
            var exProperty = ScenarioContext.Current.Get<PROPERTY>("Property");

            //Act
            var actProperty = db.PROPERTies.Single(x => x.PropertyName.Equals(exProperty.PropertyName));

            //Assert
            ProjectAssertions.HomeScreenShouldShow(exProperty, actProperty);
        }

        public void NavigateHome()
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Index();
            }
        }

        public void NavigateToSearch()
        {
            using (var controller = new ProjectController())
            {
                _result = controller.SearchI();
            }
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

        public void ShowListProject(Table showProject)
        {
            //Arrange
            var expectedProjects = showProject.Rows.Select(r => r["PropertyName"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<WebPPC.Models.PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
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
