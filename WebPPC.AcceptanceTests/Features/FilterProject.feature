Feature: FilterProject
	Toi la khach vang lai
	Toi muon tim kiem nhung du an theo nhung gi toi can


Background: 
	Given Duoi day là nhung du an co th duoc tim kiem
		| PropertyName           | Price | Bedroom | PackingPlace | Bathroom | Area   |
		| Bigroom with Riverview | 5000  | 6       | 2            | 4        | 1200m2 |

@automation
Scenario: Filter Project
	Given Toi dang o trang tim kiem du an
	When Toi nhap vao truong thong tin ten du an 'Bigroom with Riverview'
	Then Toi se thay duoc du an ma toi tim kiem
	| PropertyName           |
	| Bigroom with Riverview |
