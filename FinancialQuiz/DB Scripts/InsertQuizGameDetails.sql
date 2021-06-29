CREATE PROCEDURE [dbo].[InsertQuizGameDetails]
    @UserId INT,   
    @Total_questions INT,
	@CategoryId INT,
	@AgeGroupId INT,
	@GameLevelId INT
AS   
BEGIN
   DECLARE @gameId INT;
   
  INSERT INTO Games
           (userID
           ,Start_Date
           ,Total_questions
           ,Completed_ind
           )
     VALUES
           (@UserId
           ,GETDATE()
           ,ISNULL(@Total_questions,5)
           ,'N'
           );
	
    SET @gameId = SCOPE_IDENTITY()
  
	insert into gameDetails(gameId,questionId)
  (select TOP(ISNULL(@Total_questions,5)) 
    @gameId,id from Questions
   where game_level_id = ISNULL(@GameLevelId, 1) 
   and category_id = ISNULL(@CategoryId, 1) 
   and age_range_id = ISNULL(@AgeGroupId, 1));
   
   select max(id) gameId from games where userID = @UserId;
  
end
GO
