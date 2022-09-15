select enter_date 
from Works_on  
Inner join Employee  on Works_on.emp_no=Employee.emp
WHERE Job='Clerk' AND dept='d1';