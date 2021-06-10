insert into Age_range (name, Description) values ('8-11','Age Group 8 years to 11 years');
insert into Age_range (name, Description) values ('12-16','Age Group 12 years to 16 years');

insert into category (name, Description) values ('Setting goals','Category to set the Goals');
insert into category (name, Description) values ('Loan/Rent','Rent or Loan Category');
insert into category (name, Description) values ('Inflation','Category related to Infaltion');
insert into category (name, Description) values ('Personal Financial Challenge','Category related to individuals financial challenges');

insert into game_level (name, Description) values ('Beginner','Beginner');
insert into game_level (name, Description) values ('Easy','Easy');
insert into game_level (name, Description) values ('Normal','Normal');
insert into game_level (name, Description) values ('Hard','Hard');
insert into game_level (name, Description) values ('Very hard','Very hard');

INSERT INTO Users (LastName,FirstName,Age,UserName,passwordHash ,Admin_ind) VALUES ('Lauren','hughes',18,'Lauren',HASHBYTES('SHA2_512','test123'),'N');
INSERT INTO Users (LastName,FirstName,Age,UserName,passwordHash ,Admin_ind) VALUES ('Laura','M',28,'Laura',HASHBYTES('SHA2_512','test4321'),'Y');
INSERT INTO Users (LastName,FirstName,Age,UserName,passwordHash ,Admin_ind) VALUES ('doe','b',12,'doe',HASHBYTES('SHA2_512','test1234'),'N');
INSERT INTO Users (LastName,FirstName,Age,UserName,passwordHash ,Admin_ind) VALUES ('jane','richard',32,'jane',HASHBYTES('SHA2_512','test1234'),'Y');
INSERT INTO Users (LastName,FirstName,Age,UserName,passwordHash ,Admin_ind) VALUES ('Sam','wilson',11,'Sam',HASHBYTES('SHA2_512','test1234'),'N');

INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,1,'Many celebrities, professional athletes, and entrepreneurs—people who can afford to live their desired lifestyles—have goals for their personal and professional achievements.  Why do these successful people set goals? ','Goal-setting allows them to measure progress toward accomplishments or lifestyle changes they desire.','  Setting goals provides them with direction.','Goal-setting gives them an opportunity to show off to others.','Both “a” and “b.”','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,1,1,'Why would I want to improve my credit score? ','To save money when purchasing a car with a loan.','To earn more interest on investments.','To help you get a job, because many employers check their prospective employees’ credit.','Both “a” and “c.”','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,1,'Which of the following states the five important components of a good goal? ','General, revised, active, safe, sound.','Written, clear timeline, research-based, influenced by family, influenced by friends.','Specific, measurable, achievable, realistic, time-driven.','None of the above.','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,1,1,'From the following list, choose the two best suggestions for building and maintaining a good credit rating. ','Have money in savings and protect against identity theft.','Keep your debt low and pay your bills on time.','Make safe investments and set clear financial goals','None of the above','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,2,'When you purchase a brand-new car','You own an asset that is likely to appreciate in value.','Your net worth will probably decrease immediately by at least 5% of the car’s purchase price.','You will receive reduced auto insurance rates compared to older-model used cars.','You will receive lower registration rates compared to older-model used cars.','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,1,2,'The best time to shop for a car loan is…','At the dealership when you are purchasing the car.','Before you start searching for a car.','Once you find a car on which you want to make an offer ','It’s always best to pay cash for your car.','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,5,2,'How do you calculate the cost of renting a place to live in order to determine whether renting is an option for you?','Add the rent plus all the additional expenses of renting a place to determine whether the total aligns with your personal finance objectives','Estimate the exact rent costs and the cost of utilities.','Identify the exact amount of rent that is owed each month to a landlord.','List all the components of the rent amount you will pay to the landlord.','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,5,2,'What should you research and be prepared to pay prior to moving into a rental property?','Current month’s rent','Expenses associated with establishing utilities.','Security deposit.','All of the above.','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,2,'Loan payments are based on:','Interest Rate','Length of the Loan','A & B',' APR plus A & B','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,2,'Which loan term is best if you want to reduce the total amount you will repay over the life of the loan? ','3-year','5-year','7-year','10-year','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,5,2,'What is the most important financial consideration when deciding whether to take out a college loan? ','The school you attend','Your GPA and college testing scores','The return on investment you’ll receive from obtaining the degree ','Whether you live on-campus or off-campus','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,2,'If you are unable to pay off the entire balance you owe in credit card debt, the best way to pay off the balance is to _____.','Pay off the card with the lowest balance first.','Pay more than the minimum monthly payments on all your credit cards.','Pay the maximum your budget allows on the card with the highest interest rate.','Pay the maximum payment on the card with the highest balance.','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,3,'If the current inflation rate is at 3%...','Investments in securities (stock market, mutual funds) adjust to market conditions by 3%.','401k plans adjust to market conditions by 3%','My net income needs to increase by 3% to maintain my current lifestyle.','My savings need to increase by 3% to maintain my current lifestyle.','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,1,3,'If inflation is at 2%, in what option below are you most likely to lose 2% purchasing power?','Cash','Stock Market','Real estate','Commodities','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,4,'What is risk-based pricing?','The cost of the deductible and premium added together.','The amount of money the insurance company pays toward your claim and the adjustment to your interest rate made by your lender.','Basing your insurance or loan pricing on the risk you pose to the company.','All of the above.','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,1,4,'Which of the following categories influence your FICO score?','Outstanding debt','Payment history','Types of credit used','All of the above.','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,4,'What four main areas do lenders review to qualify a loan applicant?','Credit, cash, education, and income.','Equity, credit history, assets, and debt-to-income ratio. ','Equity, cash on hand, asset report scoring, and debt-to-income ratio','Liquidity, credit history, asset report scoring, and debt-to-income ratio','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,4,'The biggest risk of owning long-term bonds for capital preservation is','Falling interest rates','Rising interest rates','Falling dollar','Real estate valuation','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,5,4,'It is recommended that you do your taxes yourself, unless managing them is really difficult without a tax professional’s help.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,1,4,'A checking account is a good option for: More than one answer may be correct. ','Earning interest at higher rates','Earning interest at higher rates and long-term investments','Depositing paychecks','Depositing paychecks and paying bills ','D');