select
Catagory_name,
CatagoryId
from
Catagory


select
items_Name,
CatagoryId,
ItemsId
from
Items

select
A.CatagoryId,
A.Catagory_name,
B.items_Name,
B.CatagoryId
from
Catagory A
left join 
Items B on A.CatagoryId = B.CatagoryId
where
A.CatagoryId = 1
or B.CatagoryId = 2

