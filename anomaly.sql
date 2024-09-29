USE master
GO
IF EXISTS (SELECT 'True' FROM sys.databases WHERE name = 'anomalies')
BEGIN
ALTER DATABASE anomalies set single_user with rollback immediate
DROP DATABASE anomalies
END
GO
CREATE DATABASE anomalies
GO
ALTER authorization on database::anomalies to sa

USE anomalies 
GO

CREATE TABLE topic(
						id_topic int PRIMARY KEY,
						name_topic char(80)

					)

GO
CREATE TABLE bot(
						id_bot int PRIMARY KEY,
						name_bot char(40) UNIQUE,
						id_topic int FOREIGN KEY REFERENCES topic (id_topic)

				)


GO
CREATE TABLE chat_session( 
						
						id_ses int PRIMARY KEY,
						time_stamp time,
						chat_length int,
						nr_messages int,
						id_bot int FOREIGN KEY REFERENCES bot (id_bot),
						id_anomaly int FOREIGN KEY REFERENCES anomaly (id_anomaly)

						)

GO
CREATE TABLE Rating(id_r int PRIMARY KEY,
					prcntg int
					)


GO
CREATE TABLE queries(
						id_q int PRIMARY KEY,
						problem char(50),
						frqncy int

						)

GO
CREATE TABLE General_analysis(
								id_g int PRIMARY KEY,
								response char(50),
								nr int
								)


GO
INSERT INTO topic(id_topic, name_topic) VALUES
				 (1, 'Technology'), 
				 (2, 'Health'), 
				 (3, 'Politics'), 
				 (4, 'Environment'), 
				 (5, 'Education'), 
				 (6, 'Entertainment'), 
				 (7, 'Sports'), 
				 (8, 'Business'), 
				 (9, 'Science'), 
				 (10, 'Lifestyle')



GO
INSERT INTO  General_analysis(id_g, response, nr) VALUES
							 (1, 'TotalResponses', 184),
							 (2, 'StraightResponses', 20),
							 (3, 'RepetitiveResponses', 18),
							 (4, 'MisinterpretedQueries', 27),
							 (5, 'UnnecessaryDetails', 0),
							 (6, 'ClarificationsRequests', 18),
							 (7, 'InapropriateResponses', 13)
						

GO
INSERT INTO Rating(id_r, prcntg) VALUES
				  (1, 87),
				  (2, 13)



GO
INSERT INTO queries (id_q, problem, frqncy)  VALUES
					(1,'InapropriateQueriesCount', 4),
					(2,'RepeatedQueries', 24),
					(3,'ShallowQueries',13),
					(4, 'TotalQueries', 88)
