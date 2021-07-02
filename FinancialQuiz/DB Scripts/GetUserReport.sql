CREATE PROCEDURE [dbo].[GetUserReport]   
    @UserId int
AS   
BEGIn
  
select id, start_date, ISNULL(end_date,Start_Date) end_date, Total_questions, ISNULL(Completed_ind,'') as Completed_ind, sum(correct) as questionsCorrect, ISNULL(questionsMissed,0) as questionsMissed, (ISNULL(sum(correct),0) * 100/Total_questions) as score_percentage  from (select g.*, gd.userOption, q.Correct_Option,
    CASE when (gd.userOption = q.Correct_Option) then 1 
			else 0  end as correct
from games g, GameDetails gd, Questions q 
where g.ID = gd.gameID and gd.QuestionID = q.ID 
and g.userID = @UserId) as a group by id, start_date, end_date, total_questions, completed_ind, questionsMissed;

END