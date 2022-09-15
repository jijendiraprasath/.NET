Select e.emp_fname,e.emp_lname 
from Employee 
e join Works_on w1 on e.emp=w1.emp_no 
inner join Works_on w2 on w1.enter_date=w2.enter_date