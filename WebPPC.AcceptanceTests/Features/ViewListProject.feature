Feature: US02WebPPCViewListProject
	Toi la nguoi dung
	Toi muon xem danh sach cac du an duoc giao dich

Background: following theo buoc tren
Given the following users
		| Email           | Password    | FullName          |
		| tmy@gmail.com   | 123456      | Trần Tiểu My      |
And the following projects
		| PropertyName   | Content                             | Price | Area   | BedRoom  | PackingPlace | Status_Name |
		| My My Villa    |Very close to the Super Market Co.op.| 5000  | 1200m2 | 6        | 2            | Chưa duyệt  |
		
@automation
Scenario: View List Projects
	Given Toi dang o trang chu
	And Toi di den dang nhap
	When Toi dang nhap email 'tmy@gmail.com' va '123456'
	Then Toi se thay duoc danh sach cac du an cua toi
	| PropertyName|
	| My My Villa |