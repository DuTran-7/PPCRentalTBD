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
        team12Entities db = new team12Entities();
        private ActionResult _result;

        public void NavigateToPostProject()
        {
            using (var controller = new ProjectController())
            {
                _result = controller.PostProject();
            }
        }

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

        public void SaveProject()
        {
            //Arange
            var exProperty = ScenarioContext.Current.Get<PROPERTY>("Property");

            //Act
            var actProperty = db.PROPERTies.Single(x => x.PropertyName.Equals(exProperty.PropertyName));

            //Assert
            ProjectAssertions.HomeScreenShouldShow(exProperty, actProperty);
        }

        public void InsertProject(Table duAn)
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

        public void NavigategoToHome()
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Index();
            }
        }

        public void ShowListOfAgencyProject(Table showProject)
        {
            //Arrange
            var expectedProjects = showProject.Rows.Select(r => r["PropertyName"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
        }

        public void FilterByBedRoom(string bedRoom)
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Search(bedRoom, null, null, null, null, null);
            }
        }

        public void ShowListProjectByBedroom(Table showProjectByBedRoom)
        {
            //Arrange
            var expectedProjects = showProjectByBedRoom.Rows.Select(r => r["BedRoom"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
        }

        public void FilterByPackingPlace(string packingpalce)
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Search(packingpalce, null, null, null, null, null);
            }
        }

        public void ShowListProjectByPackingPlace(Table showProjectByPackingPlace)
        {
            //Arrange
            var expectedProjects = showProjectByPackingPlace.Rows.Select(r => r["PackingPace"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
        }

        public void FilterByBathRoom(string bathRoom)
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Search(bathRoom, null, null, null, null, null);
            }
        }

        public void ShowListProjectByBathRoom(Table showProjectByBathRoom)
        {
            //Arrange
            var expectedProjects = showProjectByBathRoom.Rows.Select(r => r["BathRoom"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
        }

        public void FilterByArea(string area)
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Search(area, null, null, null, null, null);
            }
        }

        public void ShowListProjectByArea(Table showprojectArea)
        {
            //Arrange
            var expectedProjects = showprojectArea.Rows.Select(r => r["Area"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
        }

        //public void Filter(Table filter)
        //{
        //    PROPERTY pro = new PROPERTY();
        //    pro.PropertyName = filter.Rows[0]["PropertyName"];
        //    pro.Price = int.Parse(filter.Rows[0]["Price"]);
        //    pro.BedRoom = int.Parse(filter.Rows[0]["BedRoom"]);
        //    pro.PackingPlace = int.Parse(filter.Rows[0]["PackingPlace"]);
        //    pro.BathRoom = int.Parse(filter.Rows[0]["BathRoom"]);
        //    pro.Area = filter.Rows[0]["Area"];
        //    db.PROPERTies.Add(pro);
        //    db.SaveChanges();
        //    var propertyID = db.PROPERTies.ToList().FirstOrDefault(u => u.PropertyName == filter.Rows[0]["PropertyName"]).ID;
        //}

        public void NavigateHome()
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Index();
            }
        }

        public void FilterByPrice(string price)
        {
            using (var controller = new ProjectController())
            {
                _result = controller.Search(price, null, null, null, null, null);
            }
        }

        public void ShowListProjectByPrice(Table showProject)
        {
            //Arrange
            var expectedProjects = showProject.Rows.Select(r => r["Price"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
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

        public void Property(Table project)
        {
            PROPERTY p = new PROPERTY();
            p.PropertyName = project.Rows[0]["PropertyName"];
            p.Content = project.Rows[0]["Content"];
            p.Price = int.Parse(project.Rows[0]["Price"]);
            p.Area = project.Rows[0]["Area"];
            p.BedRoom = int.Parse(project.Rows[0]["BedRoom"]);
            p.PackingPlace = int.Parse(project.Rows[0]["PackingPlace"]);
            p.Status_ID = db.PROJECT_STATUS.ToList().FirstOrDefault(s => s.Status_Name == project.Rows[0]["Status_Name"]).ID;
            db.PROPERTies.Add(p);
            db.SaveChanges();
            var propertyID = db.PROPERTies.ToList().FirstOrDefault(u => u.PropertyName == project.Rows[0]["PropertyName"]).ID;
        }

        public void ShowListProject(Table showProject)
        {
            //Arrange
            var expectedProjects = showProject.Rows.Select(r => r["PropertyName"]);
            //Actual
            var actualProjects = _result.Model<IEnumerable<PROPERTY>>();
            //Assert
            ProjectAssertions.HomeScreenShouldShow(actualProjects, expectedProjects);
        }

        public void ShowListOfProject(Table showProject)
        {
            //Arrange
            var expectedProjects = showProject.Rows.Select(r => r["PropertyName"]);           
            //Actual
            var actualProjects = ScenarioContext.Current.Get<IEnumerable<PROPERTY>>("agencyProperty");
            //var actualProjects = result;
            
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
