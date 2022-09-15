SELECT emp_no,Job

FROM Project 
CROSS JOIN Works_on
WHERE project_name= 'Gemini';