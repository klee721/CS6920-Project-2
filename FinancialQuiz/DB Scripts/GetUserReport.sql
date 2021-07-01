CREATE PROCEDURE [dbo].[GetUserReport]   
    @UserId int
AS   
BEGIn
  
  select Id
       , start_date
	   , end_date
	   , Total_questions
	   , Completed_ind
	   , questionsCorrect
	   , questionsMissed
	   , round(ISNULL(questionsCorrect,0)*100/Total_questions, 2) score_percentage 
from Games 
where USERID = @UserId
and questionsCorrect is not null;

END