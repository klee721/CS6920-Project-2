CREATE PROCEDURE GetGameQuestion
@gameId INT,   
    @questionNumber INT
    
AS   
BEGIn

  
select q.Id, q.Description, q.OptionA, q.OptionB, q.OptionC, q.OptionD from (SELECT ROW_NUMBER() OVER(ORDER BY questionID DESC) 
    AS RowNumber,  
    QuestionID
	from gamedetails where gameId = @gameId) a, Questions q where q.ID = a.QuestionID and rownumber = @questionNumber;

  
end
--exec GetGameQuestion  @gameId=1, @questionNumber=2;