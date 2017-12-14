using System;
using TechTalk.SpecFlow;
using WebPPC.AcceptanceTest.Driver.AdminDriver;
using WebPPC.AcceptanceTest.Driver.HomeDrivers;

namespace WebPPC.AcceptanceTest.StepDefinitions
{
    [Binding]
    public class ViewListProjectOfAgencySteps
    {
        private readonly Home _home;
        private readonly Admin _admin;
        [Given(@"Toi dang o giao dien trang chu")]
        public void GivenToiDangOGiaoDienTrangChu()
        {
            _home.Index();
        }
        
        [When(@"Toi chuyen den giao dien admin")]
        public void WhenToiChuyenDenGiaoDienAdmin()
        {
            _admin.Index();
        }
        
        [Then(@"He thong hien thi danh sach cac du an cua Agency")]
        public void ThenHeThongHienThiDanhSachCacDuAnCuaAgency()
        {
            _admin.ShowProject();
        }
    }
}
