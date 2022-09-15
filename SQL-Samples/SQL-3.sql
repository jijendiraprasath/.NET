SELECT emp_fname,emp_lname

FROM  Employee
CROSS JOIN Department
WHERE DeptName= 'Research' OR DeptName='Account';