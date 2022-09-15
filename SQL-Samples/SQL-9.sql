select emp
--select *
from Employee  
Inner join Department  on Employee.dept=Department.Dept_no
WHERE DeptName='Marketing';