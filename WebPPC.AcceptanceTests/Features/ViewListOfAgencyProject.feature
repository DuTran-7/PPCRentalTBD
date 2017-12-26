Feature: ViewListOfAgencyProject
	Toi la Sale
	Toi muon nhin thay duoc danh sach cua cac Agency


Background: Toi co danh sach nhung du an nhu sau
	Given the following sale
		| Email                      | Password    | FullName          |
		| lythihuyenchau@gmail.com   | 123456      | Ly Chau      |
And the following project of Agency
		| PropertyName		     | Content                             | Price | Area   | BedRoom  | PackingPlace | Status_Name |
		| Bigroom with Riverview |Very close to the Super Market Co.op.| 5000  | 1200m2 | 6        | 2            | Chưa duyệt  |
@automation
Scenario: View List Of Agency Project
	Given Toi dang o homepage
	And Toi den dang nhap
	When Toi dang nhap email 'lythihuyenchau@gmail.com' va pass '123456'
	Then Toi se thay duoc danh sach du an cua tat ca cac sale
	| PropertyName           |
	| Bigroom with Riverview |
