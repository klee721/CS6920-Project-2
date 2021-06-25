CREATE PROCEDURE InsertQuizGameDetails
    @UserId INT,   
    @Total_questions INT,
	@CategoryId INT,
	@AgeGroupId INT,
	@GameLevelId INT
AS   
BEGIn


  
   
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
		   

	insert into gameDetails(gameId,questionId)
  (select TOP(ISNULL(@Total_questions,5)) @UserId,id from Questions
   where game_level_id = ISNULL(@GameLevelId, 1) 
   and category_id = ISNULL(@CategoryId, 1) 
   and age_range_id = ISNULL(@AgeGroupId, 1));
   
   select max(id) from games where userID = @UserId;
  
end
