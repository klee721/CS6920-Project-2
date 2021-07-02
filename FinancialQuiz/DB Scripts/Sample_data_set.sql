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


INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,2,'Average net worth of renters is $5,600 while average net worth of homeowners is $216,000','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,4,'Your take-home pay from your job is less than the total amount you earn. Which of the following best describes what is taken out of your total pay?  ','Federal income tax, sales tax and social security contribution  ','Federal income tax, property tax, Medicare and social security contributions  ','Federal income tax, social security, and Medicare contributions ','Social security and Medicare contributions   ','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,4,'Buying a single company''s stock usually provides a safer return than a stock mutual fund.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,4,'What is the largest index in the world?',' S&P 500 (SPX)','Russel 1000','DAX','SX5E','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,4,'Many savings programs are protected by the Federal government against loss. Which of the following is not?  ','Bond issued by one of the 50 states ','Certificate of deposit at the bank   ','U.S. Treasury bond  ','U.S. Savings bond   ','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,4,'Suppose you need to borrow 100 US dollars. Which is the lower amount to pay back: 105 US dollars or 100 US dollars plus three percent?','105 US dollars','100 US dollars plus three percent','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Who insures your stocks in the stock market?','The Federal Deposit Insurance Corporation','The Securities and Exchange Commission','The U.S. Department of the Treasury',' No one','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,4,4,'If you open a checking account, you always must open a saving account with the same bank.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,4,'Which of the following best describes the primary sources of income for most people aged 20-35?  ','Profits from business','Dividends and interest  ','Rents   ','Salaries, wages, and tips','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Which of the following is true about sales taxes?  ','The federal government will deduct it from your paycheck  ','It makes things more expensive for you to buy','You don''t have to pay the tax if your income is very low   ','The national sales tax percentage rate is 6%  ','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,4,'Under which of the following circumstances would it be financially beneficial for you to borrow money to buy something now and repay it with future income ','When you really need a two-week vacation   ','When some new clothes you like go on sale  ','When the interest on the loan is greater than the interest you get on your savings   ',' When you need to buy a car to get a much better paying job','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Which of the following statements is true?   ','Your bad loan payment record with one bank will not be considered if you apply to another bank for a loan  ','People have so many loans it is very unlikely that one bank will know your history with another bank  ','Banks and other lenders share the credit history of their borrowers with each other and are likely to know of any loan payments that you have missed','If you missed a payment more than two years ago, it cannot be considered in a loan decision','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Retirement income paid by a company is called:   ','Social security  ','Rents and profits   ','Pension','401(k)  ','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Which of the following statements is not correct about most ATM cards?   ','You must have a bank account to have an ATM card   ','You can generally get cash 24 hours a day  ','You can generally obtain information concerning your bank balance at an ATM machine  ','You can get cash anywhere in the world with no fee ','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'High school students can open a bank account at any age.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,3,'Imagine that the interest rate on your savings account is 1 percent a year and inflation is 2 percent a year. After one year, would the money in the account buy more than it does today, exactly the same or less than today?','More','Same','Less','I don''t know','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,5,3,'If you purchase a bond and interest rates rise, what will happen to the price of the bond?','Rise','Stay the same','Fall','No relationship','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,5,3,'What is the average annual rate of inflation for college tuition around the country?','0.02','0.06','0.08','0.11','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,3,'Jerry has a good job on the production line of a factory in his hometown. During the past year or two, the state in which Jerry lives has been raising taxes on its businesses to the point where they are much higher than in neighboring states. What effect is this likely to have on Jerry''s job?  ','He is likely to get a large raise to offset the effect of the higher taxes   ','Higher business taxes can''t have any effect on Jerry''s job   ','Higher business taxes will cause more businesses to move into Jerry''s state, raising wages  ','Jerry''s company may consider moving to a lower-tax state, threatening Jerry''s job','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,3,'Suppose over the next 10 years the prices of the things you buy double. If your income also doubles, will you be able to buy less than you can buy today, the same as you can buy today, or more than you can buy today?','Less','The same','More','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,3,'If inflation is anticipated,','it is costless to society.','it costs less to society than if unanticipated.','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,3,'If the inflation rate is anticipated,','Inflation may not be a major problem.','People will hold more cash than they want to hold.','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,3,'The consumer price index','Measures the cost of an unchanging basket of goods and services.','Does not take into account relative price changes and, therefore, is biased.','Does not completely account for quality changes and, therefore, is biased.','All of the above.','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,4,3,'Which of the following types of investments would best protect the purchasing power of a family''s savings in the event of a sudden increase in inflation?   ','U.S. Government Savings bond','Certificate of deposit   ','25-year corporate bond   ','House financed with a fixed rate mortgage','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,3,'Inflation can cause difficulty in many ways. Which group would have the greatest problem during periods of inflation? ','Young couples with no children who both work  ','Young working couples with children  ','Older working couples saving for retirement   ','Older people living on fixed retirement income','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,3,'Why can’t you buy me what Emma’s parents bought her?','All moms and dads have same values','No family is the same and every family has their own priorities','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,3,'Why bank is important? ','Safeguard your cash','Use debit and credit card services','Facilitate financial transactions and invest your money','All of the above','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,3,'Why can’t we get money from ATM whenever we want?','Money is a limited resource','Money is an unlimited resource','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,3,'Challenges and limitations for individuals who don''t have a bank account','Insuring your money','Using cash for day-to-day expenses','','All of the above','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,3,'Students can get enough financial aid to cover the educational cost of most colleges.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,3,'High school graduates must attend college if they wish for successful financial futures.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,3,'If a student between age 14-17 requests to open a checking, savings, or money market accounts, a parent or a legal guardian must be named as a joint account holder.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,3,'Students whose parents make too much money cannot receive any student financial aid.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,2,'If your credit card was lost or stolen and used to charge items you didn''t authorize, you are responsible for what amount?','Up to $50','Up to $100','Up to $500','All unauthorized charges','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,2,'Suppose you owe $1,000 on a loan and the interest rate you are charged is 20% per year compounded annually. If you didn''t pay anything off, at this interest rate, how many years would it take for the amount you owe to double?','Less than 2 years','2 to 4 years','5 to 9 years','10 or more years','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,2,'What affects the amount of interest that you would pay on a loan?','Your credit rating','How much you borrow','How long you take to repay the loan','All of the above','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,2,'What is a credit report?','A list of your financial assets and liabilities','A monthly credit card statement','A loan and bill payment history','A credit line with a financial institution','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,4,2,'Which of the following can hurt your credit rating/credit score?','Making late payments on loans and debts','Staying in one job too long','Living in the same location too long','Using your credit card frequently for purchases','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,2,'In terms of credit, what does APR stand for?','Annual Percentage Rate','Annual Penalty Rate','Annual Payment Rate','Annual Payoff Rate','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,4,2,'Negative financial information (excluding bankruptcy) can stay on your credit report for:',' 2 years',' 5 years',' 7 years',' 9 years','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,2,' A 15-year mortgage typically requires higher monthly payments than a 30-year mortgage but the total interest over the life of the loan will be less.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,4,2,' How many days does a creditor have to acknowledge your written complaint about a billing error?','30 days','60 days','90 days','120 days','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,5,2,'What do "points" refer to in the home mortgage application process','One point equals 1% of the purpose price, paid to the seller','One point equals 1% of the purchase price, paid to the lender','One point equals 1% of the loan amount, paid to the seller',' One point equals 1% of the loan amount, paid to the lender','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,5,2,'A reverse mortgage is:','A rising debt loan','Only available to someone 62 years of age or older','Generally not tied to income','All of the above','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,1,'Suppose you have $100 in a savings account earning 2 percent interest a year. After five years, how much would you have?','102','More than $102','Less than $102','I don’t know','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,1,'Federal law gives you three days to cancel the purchase of a new or used car from a dealer.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,1,'The type of car you own affects the price you pay for auto insurance','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,1,'Each state has a law that lets pharmacists substitute less expensive generic drugs for many brand name products.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,1,'By using unit pricing at the grocery store, you can easily compare the cost of any brand and any package size.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,1,'All telephone numbers that begin with an "8" are toll-free.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,1,'The recommended gasoline for most cars is regular octane','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,1,'The "Rule of 72" tells you how long it will take to double your money','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,1,'Many people put aside money to take care of unexpected expenses. If Pedro and Susanna have money put aside for emergencies, in which of the following forms would it be of LEAST benefit to them if they needed it right away?  ','Checking account  ','Savings account ','Stocks','Invested in a down payment on the house','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,1,'Tim and Rebecca just got a baby. They received money as baby gifts and want to put it away for the baby''s education. Which of the following is likely to have the highest growth over the next 18 years?  ','U.S. government bond  ','Checking account  ','Savings account   ','Stocks','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,1,'If you have caused an accident, which type of automobile insurance would cover damage to your own car?   ','Collision   ','Comprehensive  ','Term','Liability','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,1,'Mike has saved $6,000 for his college expenses by working part-time. He plans to start college next year and needs all of the money he saved. Which of the following is the safest place for his college money?  ','Locked in his closet at home  ','Stocks','Bank savings account','Corporate bonds  ','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,1,'If you went to college and earned a four-year degree, how much more money could you expect to earn than if you only had a high school diploma?   ','About 10 times as much  ','A lot more, about 70% more  ','A little more, about 20% more   ','No more, I would make about the same either way ','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,1,'Bob and Cindy are the same age. At age 25, Cindy began saving $2,000 a year while Bob saved nothing. At age 50, Bob realized that he needed money for retirement and started saving about $4,000 per year while Cindy kept saving her $2,000. Now they are both 75 years old. Who has the most money in his or her retirement account? ','Bob, because he saved more each year   ','Cindy, because her money has grown for a longer time at compound interest ','They would each have the same amount because they put away exactly the same  ','Cindy, because she has put away more money ','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,1,'Jack and Ron are young men. Each has a good credit history. They work at the same company and make approximately the same salary. Jack has borrowed $2,500 to buy a car. Ron has borrowed $2,500 to take a foreign vacation. Who is likely to pay the lowest finance charge?   ','They will both pay the same because they have almost identical financial backgrounds   ','Ron will pay less because people who travel overseas are better risks ','Jack will pay less because the car is collateral for the loan','They will both pay the same because the rate is set by law','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,1,'Heather and Alexis are employed by the same company and earn the same pay. Heather spends her free time taking work-related classes to improve her computers skills, while Alexis spends her free time socializing with friends and working out at a fitness center. After five years, what is likely to be true?  ','Alexis will make more because she is more social   ','Heather and Alexis will continue to make the same money  ','Heather will make more money because she is more valuable to her company  ','Alexis will make more because Heather is likely to be laid off   ','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,4,'A checking account is also called a transactional account because','It is used to pay bills','Amount is never constant','It requires a minimum balance to open account','It earns interest','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,2,4,'Unbanked individuals can conduct financial transactions using ','Cash','Prepaid debit cards','Payday loan services','All the above','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Typically, you must be at least 18 years old to apply for a credit card. If you are under 21 years old, and you do not have an independent income, which of the credit card type you can receive?','Authorized credit card user','Secured credit card','Both A & B','None. You must be 21 to get any type of credit cards','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'The difference between a debit card and a credit card account is from which source the cards pull the money.  A debit card takes money from your bank account (money that you have) while a credit card is borrowed money charged to your account (money you must pay back plus applicable interest).','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'A checking account is a basic type of bank account that allows you to deposit money, keep it safe, transfer money to checking account, and/or withdraw funds, all while earning interest. It does not allow account holders to write checks or pay bills.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Credit card is a specific bank account against which checks can be drawn by the account depositor.  ','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'What is the U.S. Federal Reserve Bank?','Commercial/Retail Bank','Investment Bank','Central Bank','','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'Two of the most common types of banks are ','Commercial/Retail and Investment Banks','Credit Uniouns and Commercial Banks','Central Banks and Credit Unions','Central Banks and Investment Banks','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,3,4,'… is an electronic banking outlet that allows customers to complete basic transactions without the aid of a branch representative or teller. ','Online banking','Automated teller machine (ATM)','Money market account','Certificate of Deposit (CD)','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (1,4,4,'Which of the following is correct?','Banks are driven by making profit for their shareholders','Credit Unions are owned by members/ de facto owners','Both A & B','Neither A or B','C');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,4,'In 2018, the number of States in the US who required a course in financial literacy for high school students according to EEC was','','','','','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,4,'Banking is defined as the business activity of accepting and safeguarding money owned by other individuals and entities, and then lending out this money in order to conduct economic activities such as making profit or simply covering operating expenses. ','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,4,'Routing number is used to determine where to route funds to or from for each financial institution.  Routing numbers of each financial institution are available to public and point to the institution receiving funds','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,4,'Online banking is a method of banking in which transactions are conducted electronically using a device such as a computer or a cell phone. Many banks and credit unions also offer secure online banking services to their customers/ de facto owners.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,4,'Payroll direct deposit allows your employer to deposit your earnings electronically into your bank account which allows you to get to your money faster than having to deposit a paper check and wait for it to clear before you can access available funds.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,2,4,'… is a saving certificate with a fixed maturity date and specified fixed interest rate that can be issued in any denomination aside from minimum investment requirements. ','Money market account','Payroll direct deposit','Checking account','Certificate of Deposit','D');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,4,'A routing number of a bank is public, but an account number is private.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,4,'Most banks and credit unions offer students friendly accounts among other services.','True','False','','','A');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,4,4,'Banks and Credit Unions are insured by The Federal Deposit Insurance Corporation.','True','False','','','B');
INSERT INTO Questions (Age_range_id,Game_Level_ID,Category_ID,Description,OptionA,OptionB,OptionC,OptionD,Correct_Option) VALUES (2,3,4,'Currency stability in the USA is the main responsibility of which type of banks?','Commercial','Retail','Investment','Central','D');
