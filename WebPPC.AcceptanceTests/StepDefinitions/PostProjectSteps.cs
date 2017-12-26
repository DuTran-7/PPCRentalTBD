using System;
using TechTalk.SpecFlow;
using WebPPC.AcceptanceTests.Drivers.Agency;
using WebPPC.AcceptanceTests.Drivers.Property;

namespace WebPPC.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class PostProjectSteps
    {
        private readonly PropertyDrivers _projectdriver;
        private readonly AgencyDrivers _agencydriver;

        [Given(@"Toi dang o trang dang du an")]
        public void GivenToiDangOTrangDangDuAn()
        {
            _projectdriver.NavigateToPostProject();
        }
        
        [Given(@"Toi da dang nhap vao he thong voi tai khoan ""(.*)"",""(.*)""")]
        public void GivenToiDaDangNhapVaoHeThongVoiTaiKhoan(string email, int pw)
        {
            _agencydriver.Login(email,pw.ToString());
        }
        
        [When(@"Toi dang du an theo thong tin sau")]
        public void WhenToiDangDuAnTheoThongTinSau(Table duAn)
        {
            _projectdriver.InsertProject(duAn);
        }
        
        [Then(@"Du an da duoc dang len database")]
        public void ThenDuAnDaDuocDangLenDatabase()
        {
            _projectdriver.SaveProject();
        }
    }
}
