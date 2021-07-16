
CREATE PROCEDURE [dbo].GetGamesSummary   
    
AS   
BEGIn
  
select u.FirstName,u.LastName, count(*) games, AVG(score) average_score, MAX(score) max_score, MIN(score) min_score, max(start_date) last_played 
from Games g, Users u
where u.ID = g.userID 
group by u.FirstName,u.LastName
order by 3 desc;

END