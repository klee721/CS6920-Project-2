CREATE PROCEDURE [dbo].[UpdateUserQuestionAnswer]
 @gameId INT,   
 @questionId INT,
 @userOption varchar(1)
    
AS   
BEGIn
DECLARE @correctCount INT;
SET @correctCount = (SELECT count(1) from Questions where id = @questionId and Correct_Option = @userOption);

 
  
update GameDetails set userOption =  @userOption  where gameID = @gameId and QuestionID = @questionId;
update Games set questionsCorrect =  questionsCorrect + @correctCount  where ID = @gameId;

select userOption from GameDetails where gameID = @gameId and QuestionID = @questionId;
  
end
--exec UpdateUserQuestionAnswer @gameId=1,@questionId=1, @userOption='B';

