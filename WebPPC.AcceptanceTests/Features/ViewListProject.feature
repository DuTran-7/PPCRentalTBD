﻿Feature: US02WebPPCViewListProject
	Toi la nguoi dung
	Toi muon xem danh sach cac du an duoc giao dich

Background:
Given the following projects
		| Name Project           | Content                             | Price | Area  | BedRoom | PathRoom | PackingPlace | Status_Name | Email         | 
		| Bigroom with Riverview |Very close to the Super Market Co.op.| 5000 | 1200m2 | 6       | 4        | 2            | Chưa duyệt  | tmy@gmail.com |
		

@automation
Scenario: View List of Agency Projects
	Given Toi dang o trang chu
	And Toi di den dang nhap
	When Toi dang nhap email 'tmy@gmail.com' va '123456'
	Then Toi se thay duoc danh sach cac du an cua toi
	| Name Project           | Content                             | Price | Area   | BedRoom | PathRoom | PackingPlace | Status_Name | Email         | 
	| Bigroom with Riverview |Very close to the Super Market Co.op.| 5000  | 1200m2 | 6       | 4        | 2            | Chưa duyệt  | tmy@gmail.com |