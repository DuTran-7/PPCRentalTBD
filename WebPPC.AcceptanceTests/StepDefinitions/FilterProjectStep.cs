using TechTalk.SpecFlow;
using WebPPC.AcceptanceTests.Drivers.Agency;
using WebPPC.AcceptanceTests.Drivers.Property;

namespace WebPPC.AcceptanceTests.StepDefinitions
{
    [Binding, Scope(Tag = "automation")]
    class FilterProjectStep
    {
        private readonly PropertyDrivers _projectdriver;
        private readonly AgencyDrivers _agencydriver;


        public FilterProjectStep(PropertyDrivers Prodriver, AgencyDrivers Agdriver)
        {
            _projectdriver = Prodriver;
            _agencydriver = Agdriver;
        }

        [Given(@"Duoi day la noi dung co th tim kiem du an")]
        public void GivenDuoiDayLaNoiDungCoThTimKiemDuAn(Table table)
        {
           
        }

        [Given(@"Toi dang o trang tim kiem du an")]
        public void GivenToiDangOTrangTimKiemDuAn()
        {
            _projectdriver.NavigateToSearch();
        }

        [When(@"Toi nhap vao truong thong tin ten du an '(.*)'")]
        public void WhenToiNhapVaoTruongThongTinTenDuAn(string propertyName)
        {
            _agencydriver.FilterProject(propertyName);
        }

        //[Then(@"Toi se thay duoc du an ma toi tim kiem")]
        //public void ThenToiSeThayDuocDuAnMaToiTimKiem(Table showProject)
        //{
        //    _projectdriver.ShowListProject(showProject);
        //}
        [Given(@"Duoi day là nhung du an co th duoc tim kiem")]
        public void GivenDuoiDayLaNhungDuAnCoThDuocTimKiem(Table showProject)
        {
            //ScenarioContext.Current.Pending();
            _projectdriver.ShowListProject(showProject);
        }

    }
}
