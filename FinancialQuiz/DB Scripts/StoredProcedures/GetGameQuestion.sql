/****** Object:  StoredProcedure [dbo].[GetGameQuestion]    Script Date: 7/2/2021 11:11:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetGameQuestion]
@gameId INT,   
    @questionNumber INT
    
AS   
BEGIn

  
select q.Id, q.Description, q.OptionA, q.OptionB, q.OptionC, q.OptionD , q.Correct_Option  from (SELECT ROW_NUMBER() OVER(ORDER BY questionID DESC) 
    AS RowNumber,  
    QuestionID
	from gamedetails where gameId = @gameId) a, Questions q where q.ID = a.QuestionID and rownumber = @questionNumber;

  
end
--exec GetGameQuestion  @gameId=1, @questionNumber=2;