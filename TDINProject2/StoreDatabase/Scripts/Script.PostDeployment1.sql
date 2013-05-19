/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/* Book List */

INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('Great Expectations', 'Charles Dickens', 12.90);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('The Hunt for Red October', 'Tom Clancy', 8.70);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('Portugal e o Quinto Império por Cumprir', 'Rui Fonseca', 9.90);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('O Detective do Cosmos', 'Mani Bhaumik', 5.60);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('Brisingr', 'Christopher Paolini', 15.00);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('The Lord of the Rings: Two Towers', 'J. R. R. Tolkien', 10.50);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('A Conspiração', 'Dan Brown', 12.90);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('Uma Conspiração de Estúpidos', 'John Kennedy Toole', 11.90);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('A Viagem do Elefante', 'José Saramago', 8.30);
INSERT INTO [Book] ([Title], [Author], [Price]) VALUES ('The Godfather', 'Mario Puzo', 16.70);