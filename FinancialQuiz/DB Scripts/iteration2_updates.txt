ALTER TABLE games ALTER COLUMN end_Date DATE NULL;

ALter table users Alter column

ALTER TABLE [dbo].[Users] DROP CONSTRAINT [UK_Users];

delete from users where username in (select username from users group by username having count(*) >1);

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UK_Users1] UNIQUE NONCLUSTERED 
(
	UserName ASC
);