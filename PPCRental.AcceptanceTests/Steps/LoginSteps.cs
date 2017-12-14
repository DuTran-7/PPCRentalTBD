using System;
using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Driver.Home;
using PPCRental.AcceptanceTests.Driver.Login;

namespace PPCRental.AcceptanceTests.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly HomeDriver _home;
        private readonly LoginDriver _login;
        [Given(@"Agency dang o trang chu")]
        public void GivenAgencyDangOTrangChu()
        {
            _home.index();
        }
        
        [When(@"Agency nhan vao muc sign in")]
        public void WhenAgencyNhanVaoMucSignIn()
        {
            _home.PressSignin();
        }
        
        [Then(@"man hinh hien thi view signin")]
        public void ThenManHinhHienThiViewSignin()
        {
            _login.index();
        }
    }
}
