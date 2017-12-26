using TechTalk.SpecFlow;
using WebPPC.UITests.Selenium.Support;
using WebPPC.AcceptanceTests.Common;
using OpenQA.Selenium;
using System.Linq;
using WebPPC.Models;

namespace WebPPC.UITests.Selenium
{
    [Binding]
    class ViewListOfAgencyProject :SeleniumStepsBase
    {
        [Given(@"the following users")]
        public void GivenTheFollowingUsers(string email, string pass)
        {
            //Browser.User(email,pass);
        }

        [Given(@"the following projects")]
        public void GivenTheFollowingProjects(string propertyName)
        {
            //Browser.Property(propertyName);
        }

        [Given(@"Toi dang o trang chu")]
        public void GivenToiDangOTrangChu()
        {
            Browser.NavigateTo("Project");
        }

        [Given(@"Toi di den dang nhap")]
        public void GivenToiDiDenDangNhap()
        {
            Browser.NavigateTo("Agency/Login");
        }

        [When(@"Toi dang nhap email '(.*)' va '(.*)'")]
        public void WhenToiDangNhapEmailVa(string email, string password)
        {
            Browser.SetTextBoxValue("email", email);
            Browser.SetTextBoxValue("password", password);
            Browser.ClickButton("submit");
        }

        [Then(@"Toi se thay duoc danh sach cac du an cua toi")]
        public void ThenToiSeThayDuocDanhSachCacDuAnCuaToi(Table expectedProject)
        {
            //Arrange
            //var expectedTitles = expectedProject.Rows[0]["PropertyName"];
            var expectedTitles = expectedProject.Rows.Select(r => r["PropertyName"]);
            //Action
            var showProject = from row in Browser.FindElements(By.XPath("//table/tbody/tr"))
                             let propertyName = row.FindElement(By.Id("PropertyName")).Text
                             select new PROPERTY { PropertyName = propertyName };

            //Assert
            ProjectAssertions.HomeScreenShouldShow(showProject, expectedTitles);
        }
    }
}
