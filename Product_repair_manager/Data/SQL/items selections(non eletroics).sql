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

where
CatagoryId in (2,3)
order by
CatagoryId desc;