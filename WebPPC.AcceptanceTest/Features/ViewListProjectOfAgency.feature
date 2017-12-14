Feature: ViewListProjectOfAgency
	Danh cho Sale
	Toi muon nhin thay cac du an cua Agency khi toi vao giao dien Admin

@mytag
Scenario: Hien thi danh sach cac du an cua Agency
	Given Toi dang o giao dien trang chu
	When Toi chuyen den giao dien admin
	Then He thong hien thi danh sach cac du an cua Agency
