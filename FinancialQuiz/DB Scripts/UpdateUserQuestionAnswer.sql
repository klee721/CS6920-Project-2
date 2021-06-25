CREATE PROCEDURE UpdateUserQuestionAnswer
 @gameId INT,   
 @questionId INT,
 @userOption varchar(1)	
    
AS   
BEGIn

  
update GameDetails set userOption =  @userOption where gameID = @gameId and QuestionID = @questionId;

  
end
