
-- Select
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers


Select * from Customers where City = 'Berlin'

-- case insensitive
selEct * from products where categoryId = 1 or categoryId = 3


selEct * from products where categoryId = 1 and UnitPrice >= 10


select * from Products where CategoryID = 1 order by UnitPrice desc -- ascending, descending

Select count(*) Adet from Products where CategoryId = 2

Select CategoryId, count(*) from Products where UnitPrice>20 group by CategoryId having count(*)<10







