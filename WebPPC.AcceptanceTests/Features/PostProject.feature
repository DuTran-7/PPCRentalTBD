Feature: PostProject
	Toi la Agency
	Toi muon dang du an cua toi len website

Scenario: Dang du an thanh cong
	Given Toi dang o trang dang du an
	And Toi da dang nhap vao he thong voi tai khoan "dutest","1"
	When Toi dang du an theo thong tin sau 
	|PropertyName|Avatar         |Property_Type|District|Ward       |Street  |Area|BedRoom|BathRoom|Content|
	|Villa of du |dutestimg1.jpg |1            |Ba Vì   |TT Tây Đằng|Đảo Ngắn|10  |4      |4       |Done   |
	Then Du an da duoc dang len database

