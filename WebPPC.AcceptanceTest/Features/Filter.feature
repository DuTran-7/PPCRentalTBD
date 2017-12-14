#add @web tag to run the search tests with Selenium automation

#@web
Feature: FilterSearch
	cho phep nguoi dung tim kiem du an theo Name, Price, Bedroom, Bathroom, Packing Place, Area

Background: nguoi dung dang o Search cua page
	Given co du lieu chinh
	| ID | PropertyName                                 | Avatar                                  | Property_ID | Street_ID | Ward_ID | District_ID | Price  | Area  | Bedroom | Bathroom | PackingPlace | UserID |
	| 11 | PIS Top Apartment                            | PIS_6656-Edit-stamp.jpg                 | 1           | 748       | 2       | 2           | 10000  | 120m2 | 3       | 3        | 1            | 1      |
	| 12 | ICON 56 – Modern Style Apartment             | PIS_7432-Edit-stamp.jpg                 | 2           | 750       | 3       | 2           | 30000  | 130m2 | 2       | 4        | 1            | 1      |
	| 13 | PIS Serviced Apartment – Boho Style          | PIS_4622-Edit.jpg                       | 2           | 749       | 4       | 2           | 70000  | 120m2 | 3       | 2        | 1            | 1      |
	| 14 | Bigroom with Riverview                       | PIS_4622-Edit.jpg                       | 3           | 752       | 5       | 2           | 90000  | 200m2 | 2       | 3        | 1            | 1      |
	| 15 | PIS Serviced Apartment – Style 3             | PIS3611.jpg                             | 3           | 755       | 33      | 3           | 30000  | 130m2 | 2       | 4        | 1            | 1      |
	| 16 | Vinhomes Central Park L2 – Duong’s Apartment | PIS_7389-Edit-stamp.jpg                 | 2           | 756       | 34      | 3           | 110000 | 150m2 | 4       | 2        | 1            | 1      |
	| 17 | Saigon Pearl Ruby Block                      | PIS_7319-Edit-stamp.jpg                 | 1           | 758       | 35      | 3           | 30000  | 130m2 | 3       | 3        | 1            | 1      |
	| 18 | Nguyen Dinh Chinh – Duplex with Balcony      | PIS_6706-Edit-stamp.jpg                 | 1           | 760       | 36      | 3           | 200000 | 120m2 | 3       | 2        | 2            | 1      |
	| 19 | Sunshine Ben Thanh                           | sunshine-benthanh-cityhome-10-stamp.jpg | 3           | 754       | 40      | 3           | 40000  | 130m2 | 2       | 2        | 2            | 1      |

@mytag
Scenario: cho phep nguoi dung tim du an theo Name, Price, Bedroom, Bathroom, Packing Place, Area
	Given cho phep nguoi dung nhap lieu 'name'
	Then hien thi danh sach du an vua duoc go
	| PropertyName                                 | Price  | Area  | Bedroom | Bathroom | PackingPlace |
	| PIS Top Apartment                            | 10000  | 120m2 | 3       | 3        | 1            |
	| ICON 56 – Modern Style Apartment             | 30000  | 130m2 | 2       | 4        | 1            |
	| PIS Serviced Apartment – Boho Style          | 70000  | 120m2 | 3       | 2        | 1            |
	| Bigroom with Riverview                       | 90000  | 200m2 | 2       | 3        | 1            |
	| PIS Serviced Apartment – Style 3             | 30000  | 130m2 | 2       | 4        | 1            |
	| Vinhomes Central Park L2 – Duong’s Apartment | 110000 | 150m2 | 4       | 2        | 1            |
	| Saigon Pearl Ruby Block                      | 30000  | 130m2 | 3       | 3        | 1            |
	| Nguyen Dinh Chinh – Duplex with Balcony      | 200000 | 120m2 | 3       | 2        | 1            |
	| Sunshine Ben Thanh                           | 400000 | 130m2 | 2       | 2        | 2            |

	