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

        //[Given(@"Duoi day la noi dung co th tim kiem du an")]
        //public void GivenDuoiDayLaNoiDungCoThTimKiemDuAn(Table filter)
        //{
        //    _projectdriver.Filter(filter);
        //}
        [Given(@"Duoi day la nhung du an co th duoc tim kiem")]
        public void GivenDuoiDayLaNhungDuAnCoThDuocTimKiem(Table filter)
        {
            //_projectdriver.Filter(filter);
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

        [Then(@"Toi se thay duoc du an ma toi tim kiem")]
        public void ThenToiSeThayDuocDuAnMaToiTimKiem(Table showProject)
        {
            _projectdriver.ShowListProject(showProject);
        }
        // filter by Price
        [When(@"Toi nhap thong tin gia du an '(.*)'")]
        public void WhenToiNhapThongTinGiaDuAn(string price)
        {
            _projectdriver.FilterByPrice(price);
        }

        [Then(@"Toi se thay duoc danh sach du an")]
        public void ThenToiSeThayDuocDanhSachDuAn(Table showProject)
        {
            _projectdriver.ShowListProjectByPrice(showProject);
        }

        [When(@"Toi nhap thong tin so phong ngu cua du an '(.*)'")]
        public void WhenToiNhapThongTinSoPhongNguCuaDuAn(string bedRoom)
        {
            _projectdriver.FilterByBedRoom(bedRoom);
        }
        [Then(@"Toi se thay duoc danh sach du an co chua so phong do")]
        public void ThenToiSeThayDuocDanhSachDuAnCoChuaSoPhongDo(Table showProjectByBedRoom)
        {
            _projectdriver.ShowListProjectByBedroom(showProjectByBedRoom);
        }
        ///
        [When(@"Toi nhap thong tin so PackingPlace cua du an '(.*)'")]
        public void WhenToiNhapThongTinSoPackingPlaceCuaDuAn(string packingpalce)
        {
            _projectdriver.FilterByPackingPlace(packingpalce);
        }

        [Then(@"Toi se thay duoc danh sach du an co chua so packinglace do")]
        public void ThenToiSeThayDuocDanhSachDuAnCoChuaSoPackinglaceDo(Table showProjectByPackingPlace)
        {
            _projectdriver.ShowListProjectByPackingPlace(showProjectByPackingPlace);
        }
        //        
        [When(@"Toi nhap thong tin so phong tam cua du an '(.*)'")]
        public void WhenToiNhapThongTinSoPhongTamCuaDuAn(string bathRoom)
        {
            _projectdriver.FilterByBathRoom(bathRoom);
        }

        [Then(@"Toi se thay duoc danh sach du an co chua so phong tam do")]
        public void ThenToiSeThayDuocDanhSachDuAnCoChuaSoPhongTamDo(Table showProjectByBathRoom)
        {
            _projectdriver.ShowListProjectByBathRoom(showProjectByBathRoom);
        }
        //        
        [When(@"Toi nhap thong tin so dien tich cua du an '(.*)'")]
        public void WhenToiNhapThongTinSoDienTichCuaDuAn(string area)
        {
            _projectdriver.FilterByArea(area);
        }

        [Then(@"Toi se thay duoc danh sach du an co chua so dien tich do")]
        public void ThenToiSeThayDuocDanhSachDuAnCoChuaSoDienTichDo(Table showprojectArea)
        {
            _projectdriver.ShowListProjectByArea(showprojectArea);
        }


    }
}
