using TechTalk.SpecFlow;
using WebPPC.AcceptanceTests.Drivers.Agency;
using WebPPC.AcceptanceTests.Drivers.Property;

namespace WebPPC.AcceptanceTests.StepDefinitions
{
    [Binding, Scope(Tag = "automation")]
    class ViewDetailProjectStep
    {
        private readonly PropertyDrivers _projectdriver;
        private readonly AgencyDrivers _agencydriver;


        public ViewDetailProjectStep(PropertyDrivers Prodriver, AgencyDrivers Agdriver)
        {
            _projectdriver = Prodriver;
            _agencydriver = Agdriver;
        }

        [Given(@"Toi dang o trang chu chua cac du an")]
        public void GivenToiDangOTrangChuChuaCacDuAn()
        {
            _projectdriver.NavigateToHome();
        }

        [When(@"Toi chon muc chi tiet cua du an '(.*)'")]
        public void WhenToiChonMucChiTietCuaDuAn(string propertyName)
        {
            _projectdriver.ClickDetail(propertyName);
        }

        [Then(@"Toi se thay duoc chi tiet du an ma toi da chọn")]
        public void ThenToiSeThayDuocChiTietDuAnMaToiDaChọn(Table showDetail)
        {
            _projectdriver.ShowDetail(showDetail);
        }


    }
}
