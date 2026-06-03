select
Catagory_Name,
CatagoryId
from
Catagory

select
items_Name,
CatagoryId
from
Items

select
damage_type,
severity
from
Item_damages
order by
severity

select
fixed_report,
item_status
from
damages_report
order by
item_status

select
items_Name,
severity,
item_status
from
Items,
Item_damages,
damages_report
group by 
items_Name,
severity,
item_status
order by
severity
