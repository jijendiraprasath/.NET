select emp 
from Employee 
where dept in(select Dept_no from Department where DeptName='Marketing' );