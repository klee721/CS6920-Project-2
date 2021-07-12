
CREATE PROCEDURE [dbo].[EndQuiz]
 @gameId INT,
 @correctCount INT, 
 @missedCount INT,
 @score INT
    
AS   
BEGIn
 

update Games set questionsCorrect =  @correctCount, questionsMissed = @missedCount, score = @score, Completed_ind='Y'  where ID = @gameId;
SELECT 'True' as processed;
  
end
--exec EndQuiz @gameId=1,@correctCount = 3, @missedCount = 0, @score = 60;

