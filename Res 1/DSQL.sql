create table products 
( 
pID int primary key identity,
pName varchar(50),
pPrice float,
CategoryID int,
pImage image
)

Select pID, pName, pPrice, CategoryID, c.CatName from products p inner join category c on c.catID = p.CategoryID