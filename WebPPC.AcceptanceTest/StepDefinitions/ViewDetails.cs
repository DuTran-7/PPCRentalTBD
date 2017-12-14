using TechTalk.SpecFlow;
using System;
using WebPPC;
using WebPPC.AcceptanceTests.Driver.ViewDetails;
using WebPPC.UITests.Selenium.Support;
using WebPPC.Models;
using WebPPC.Controllers;
namespace WebPPC.AcceptanceTests.StepDefinitions
{
    [Binding, Scope(Tag = "automated")]
    public class ViewDetails
    {
        private readonly ViewDetailsDriver detailsDriver;
        string PropertyName;
        string Price;
        string Content;
        string District_ID;
        string Street_ID;
        string Ward_ID;
        string Bathroom;
        string Bedroom;
        string Area;
        string PackingPlace;
        string PropertyType_ID;
        string Email;
        string CreateAt;




        [Given(@"Co nhung du an sau")]
        public void GivenTheFollowingProjects(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Nguoi dung chon  ""(Details)""")]
        public void WhenUserClick(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Hien thi thong tin chi tiet du an")]
        public void ThenHienThiThongTinChiTietDuAn(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
