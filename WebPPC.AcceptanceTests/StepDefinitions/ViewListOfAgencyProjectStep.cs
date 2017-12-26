using TechTalk.SpecFlow;
using WebPPC.AcceptanceTests.Drivers.Agency;
using WebPPC.AcceptanceTests.Drivers.Property;
using WebPPC.Models;

namespace WebPPC.AcceptanceTests.StepDefinitions
{
    [Binding, Scope(Tag = "automation")]
    public class ViewListOfAgencyProjectStep
    {
        team12Entities db = new team12Entities();
        private readonly PropertyDrivers _projectdriver;
        private readonly AgencyDrivers _agencydriver;


        public ViewListOfAgencyProjectStep(PropertyDrivers Prodriver, AgencyDrivers Agdriver)
        {
            _projectdriver = Prodriver;
            _agencydriver = Agdriver;
        }
        [Given(@"the following sale")]
        public void GivenTheFollowingSale(Table user)
        {
            _agencydriver.User(user);
        }

        [Given(@"the following project of Agency")]
        public void GivenTheFollowingProjectOfAgency(Table project)
        {
            _projectdriver.Property(project);
        }

        [Given(@"Toi dang o homepage")]
        public void GivenToiDangOHomepage()
        {
            _projectdriver.NavigategoToHome();
        }

        [Given(@"Toi den dang nhap")]
        public void GivenToiDenDangNhap()
        {
            _agencydriver.GotoLogin();
        }

        [When(@"Toi dang nhap email '(.*)' va pass '(.*)'")]
        public void WhenToiDangNhapEmailVaPass(string email, string password)
        {
            _agencydriver.Login(email, password);
        }

        [Then(@"Toi se thay duoc danh sach du an cua tat ca cac sale")]
        public void ThenToiSeThayDuocDanhSachDuAnCuaTatCaCacSale(Table showProject)
        {
            _projectdriver.ShowListOfAgencyProject(showProject);
        }

        //[Given(@"the following sale")]
        //public void GivenTheFollowingSale(Table user)
        //{
        //    _agencydriver.User(user);
        //}

        //[Given(@"the following project of Agency")]
        //public void GivenTheFollowingProjectOfAgency(Table project)
        //{
        //    _projectdriver.Property(project);
        //}

        //[Given(@"Toi dang o homepage")]
        //public void GivenToiDangOHomepage()
        //{
        //    _projectdriver.NavigateToHome();
        //}

        //[Given(@"Toi den dang nhap")]
        //public void GivenToiDenDangNhap()
        //{
        //    _agencydriver.GotoLogin();
        //}


        //[When(@"Toi dang nhap email '(.*)' va pass '(.*)'")]
        //public void WhenToiDangNhapEmailVaPass(string email, string password)
        //{
        //    _agencydriver.Login(email, password);
        //}


        //[Then(@"Toi se thay duoc danh sach du an cua tat ca cac sale")]
        //public void ThenToiSeThayDuocDanhSachDuAnCuaTatCaCacSale(Table showProject)
        //{
        //    _projectdriver.ShowListOfProject(showProject);
        //}

    }
}
