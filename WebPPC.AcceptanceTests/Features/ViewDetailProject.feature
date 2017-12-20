Feature: ViewDetailProject
	Toi la nguoi dung
	Toi muon nhin thay duoc chi tiet cua tung du an

Background:
Given the following projects
		| PropertyName           | Content                             | Price | Area  | BedRoom | PathRoom | PackingPlace | Status_Name |  
		| Bigroom with Riverview |Very close to the Super Market Co.op.| 5000 | 1200m2 | 6       | 4        | 2            | Chưa duyệt  | 

@automation
Scenario: View Detail Project
	Given Toi dang o trang chu chua cac du an
	When Toi chon muc chi tiet cua du an 'Bigroom with Riverview'
	Then Toi se thay duoc chi tiet du an ma toi da chọn
	| PropertyName           |
	| Bigroom with Riverview |
