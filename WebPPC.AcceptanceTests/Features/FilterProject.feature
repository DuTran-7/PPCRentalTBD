Feature: FilterProject
	Toi la khach vang lai
	Toi muon tim kiem nhung du an theo nhung gi toi can


Background: 
	Given Duoi day la nhung du an co th duoc tim kiem
		| PropertyName           | Price | BedRoom | PackingPlace | BathRoom | Area   |
		| Bigroom with Riverview | 5000  | 6       | 2            | 4        | 1200m2 |

@automation
Scenario: Filter Project
	Given Toi dang o trang tim kiem du an
	When Toi nhap vao truong thong tin ten du an 'Bigroom with Riverview'
	Then Toi se thay duoc du an ma toi tim kiem
	| PropertyName           |
	| Bigroom with Riverview |

@automation
Scenario: Filter Project By Price
	Given Toi dang o trang tim kiem du an
	When Toi nhap thong tin gia du an '5000'
	Then Toi se thay duoc danh sach du an
	| Price  |
	| 5000   |

@automation
Scenario: Filter Project By BedRoom
	Given Toi dang o trang tim kiem du an
	When Toi nhap thong tin so phong ngu cua du an '6'
	Then Toi se thay duoc danh sach du an co chua so phong do
	| BedRoom  |
	| 6        |

@automation
Scenario: Filter Project By PackingPlace
	Given Toi dang o trang tim kiem du an
	When Toi nhap thong tin so PackingPlace cua du an '2'
	Then Toi se thay duoc danh sach du an co chua so packinglace do
	| PackingPalce  |
	| 2             |

@automation
Scenario: Filter Project By BathRoom
	Given Toi dang o trang tim kiem du an
	When Toi nhap thong tin so phong tam cua du an '4'
	Then Toi se thay duoc danh sach du an co chua so phong tam do
	| BathRoom  |
	| 4         |

@automation
Scenario: Filter Project By Area
	Given Toi dang o trang tim kiem du an
	When Toi nhap thong tin so dien tich cua du an '1200m2'
	Then Toi se thay duoc danh sach du an co chua so dien tich do
	| Area  |
	| 1200m2|