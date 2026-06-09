
select
Catagory_Name,
CatagoryId
from
Catagory

select
items_Name,
ItemsId,
CatagoryId
from
Items

select
classroom,
blocks
from
Classes;

select
A.CatagoryId,
A.Catagory_name,
B.items_Name,
B.CatagoryId
classroom,
C.blocks
from
Classes C
inner join catagory A on C.Classroom = A.CatagoryId
inner join Items B on A.CatagoryId = B.CatagoryId
