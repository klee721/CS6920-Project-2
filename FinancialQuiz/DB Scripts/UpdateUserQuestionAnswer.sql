CREATE PROCEDURE UpdateUserQuestionAnswer
 @gameId INT,   
 @questionId INT,
 @userOption varchar(1)	
    
AS   
BEGIn

  
update GameDetails set userOption =  @userOption where gameID = @gameId and QuestionID = @questionId;

select userOption from GameDetails where gameID = @gameId and QuestionID = @questionId;
  
end
--exec UpdateUserQuestionAnswer @gameId=1,@questionId=1, @userOption='B';

