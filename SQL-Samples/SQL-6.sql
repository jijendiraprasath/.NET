SELECT emp_fname,emp_lname 
FROM Employee
 INNER JOIN Works_on
 INNER JOIN Project
 --ON Employee.emp= Works_on.emp_no
 ON Project.project_no= Works_on.project_no 
 ON Works_on.emp_no=Employee.emp
 WHERE Job='manager' AND project_name='Mercury';