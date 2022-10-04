select products.ProductName as urunadi , sum([Order Details].UnitPrice*[Order Details].Quantity) as [kazanilan toplam Miktar] 
from Products inner join [Order Details] on Products.ProductID=[Order Details].ProductID inner join Orders on [Order Details].OrderID=Orders.OrderID  
group by Products.ProductName order by ProductName