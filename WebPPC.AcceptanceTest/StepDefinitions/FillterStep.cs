using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace WebPPC.AcceptanceTest.StepDefinitions
{
    [Binding]
    public sealed class FillterStep
    {
        public readonly Driver.Fillter.FilterDriver _driver;

        [Given(@"co du lieu chinh")]
        public void GivenCoDuLieuChinh(Table Project)
        {
            _driver.InsertData(Project);
        }


        [Given(@"cho phep nguoi dung nhap lieu '(.*)'")]
        public void GivenChoPhepNguoiDungNhapLieu(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"hien thi danh sach du an vua duoc go")]
        public void ThenHienThiDanhSachDuAnVuaDuocGo(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
