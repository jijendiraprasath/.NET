SELECT * 
FROM Project
 INNER JOIN Works_on
 ON Project.project_no= Works_on.project_no;
 --SELECT *
--FROM Project;
--SELECT *
--FROM Works_on
SELECT * FROM Project 
CROSS JOIN Works_on
