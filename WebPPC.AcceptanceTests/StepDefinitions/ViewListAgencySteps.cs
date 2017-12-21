using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebPPC.AcceptanceTests.Drivers.Agency;
using WebPPC.AcceptanceTests.Drivers.Property;

namespace WebPPC.AcceptanceTests.StepDefinitions
{
    [Binding, Scope(Tag = "automation")]
    public class ViewListAgencySteps
    {
        private readonly PropertyDrivers _projectdriver;
        private readonly AgencyDrivers _agencydriver ;


        public ViewListAgencySteps(PropertyDrivers Prodriver, AgencyDrivers Agdriver)
        {
            _projectdriver = Prodriver;
            _agencydriver = Agdriver;
        }

        [Given(@"Duoi day là nhung du an co th duoc tim kiem")]
        public void GivenDuoiDayLaNhungDuAnCoThDuocTimKiem(Table table)
        {
            //ScenarioContext.Current.Pending();
        }


        [Given(@"Toi dang o trang chu")]
        public void GivenToiDangOTrangChu()
        {
            _projectdriver.NavigateToHome();
        }

        [Given(@"Toi di den dang nhap")]
        public void GivenToiDiDenDangNhap()
        {
            _agencydriver.GotoLogin();
        }

        [When(@"Toi dang nhap email '(.*)' va '(.*)'")]
        public void WhenToiDangNhapEmailVa(string email, string password)
        {

            _agencydriver.Login(email, password);
        }

        [Then(@"Toi se thay duoc danh sach cac du an cua toi")]
        public void ThenToiSeThayDuocDanhSachCacDuAnCuaToi(Table shownProject)
        {
            _projectdriver.ShowDetail(shownProject);
        }

    }
}
