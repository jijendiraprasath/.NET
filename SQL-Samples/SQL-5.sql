select project_name 
--select *
from Project  
Inner join Works_on  on Works_on.project_no=Project.project_no
GROUP BY project_name
          HAVING  COUNT('Clerk') > 2;