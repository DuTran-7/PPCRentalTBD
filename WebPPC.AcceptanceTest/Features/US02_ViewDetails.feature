#add @web tag to run the search tests with Selenium automation

#@automated
@web
Feature: US02 - Property Details
Toi muon xem chi tiet thong tin cua mot du an bat dong san.

Background:
	Given the following property
	| Property		     | Price |			                      Content                                                 | District |  Ward   |     Street   |Bathroom|Bedroom|Area |PackingPlace|Property Type    |         Email          |CreateAt             |
	| PIS TOP APARTMENT  | 10000 |The surrounding neighborhood is very much localized with  a great number of local shops,|   Ba Vi  |Tay Dang |Dien Vien Thon|   3    |   3   |120m2|      1     |     Aparment    |lythihuyenchau@gmail.com|11/9/2017 12:00:00 AM|
								  cafes and restaurants all within minutes walk of the apartment. There is also a large     
								  daily market close by where you can buy groceries, home appliances and clothing.
	

Scenario:Toi o trang chu
		 Toi chon du an can xem
		 Toi nhan detail 
		 Xuat hien trang web hien thi thong tin chi tiet du an

	




	Examples:
	Given the following property
	| Property		     | Price |			                      Content                                                 | District |  Ward   |     Street   |Bathroom|Bedroom|Area |PackingPlace|Property Type  |         Email          |CreateAt             |
	| PIS TOP APARTMENT  | 10000 |The surrounding neighborhood is very much localized with  a great number of local shops,|   Ba Vi  |Tay Dang |Dien Vien Thon|   3    |   3   |120m2|      1     |  Aparment     |lythihuyenchau@gmail.com|11/9/2017 12:00:00 AM|
								  cafes and restaurants all within minutes walk of the apartment. There is also a large     
								  daily market close by where you can buy groceries, home appliances and clothing.
	