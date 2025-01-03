	create database projectss
	use projectss
	======================================================================================================================================================

	CREATE TABLE IntQuestions (
		Id INT PRIMARY KEY,
		QuestionText VARCHAR(MAX),
		Option1 VARCHAR(MAX),
		Option2 VARCHAR(MAX),
		Option3 VARCHAR(MAX),
		Option4 VARCHAR(MAX),
		CorrectAnswer VARCHAR(MAX)
	);


	Create PROCEDURE InsertQuestion
		@Id INT,
		@QuestionText VARCHAR(MAX),
		@Option1 VARCHAR(MAX),
		@Option2 VARCHAR(MAX),
		@Option3 VARCHAR(MAX),
		@Option4 VARCHAR(MAX),
		@CorrectAnswer VARCHAR(MAX)
	AS
	BEGIN
		INSERT INTO IntQuestions (Id, QuestionText, Option1, Option2, Option3, Option4, CorrectAnswer)
		VALUES (@Id, @QuestionText, @Option1, @Option2, @Option3, @Option4, @CorrectAnswer);
	END;

	Delete from IntQuestions
	-- Inserting Question 1
	EXEC InsertQuestion
		@Id = 1,
		@QuestionText = '1, 2, 4, 7, 11, 16, ….',
		@Option1 = '22',
		@Option2 = '23',
		@Option3 = '21',
		@Option4 = '25',
		@CorrectAnswer = '22';

	-- Inserting Question 2
	EXEC InsertQuestion
		@Id = 2,
		@QuestionText = 'aa, bb, cc, …….',
		@Option1 = 'gg',
		@Option2 = 'jj',
		@Option3 = 'dd',
		@Option4 = 'ff',
		@CorrectAnswer = 'dd';

	-- Inserting Question 3
	EXEC InsertQuestion
		@Id = 3,
		@QuestionText = 'Which sign does not belong in this series? +, – , /, x,@',
		@Option1 = '+',
		@Option2 = '@',
		@Option3 = '/',
		@Option4 = '–',
		@CorrectAnswer = '@';

	-- Inserting Question 4
	EXEC InsertQuestion
		@Id = 4,
		@QuestionText = '0.1, 0.10, 0.100, ….',
		@Option1 = '0.01',
		@Option2 = '0.1000',
		@Option3 = '0.0001',
		@Option4 = '0.001',
		@CorrectAnswer = '0.0001';

	-- Inserting Question 5
	EXEC InsertQuestion
		@Id = 5,
		@QuestionText = 'If 2 points define a line, 3 points define :',
		@Option1 = 'a car',
		@Option2 = 'a word',
		@Option3 = 'a lake',
		@Option4 = 'a plane',
		@CorrectAnswer = 'a plane';

	-- Continue inserting questions 6 through 75 in a similar manner...
	-- Inserting Question 6
	EXEC InsertQuestion
		@Id = 6,
		@QuestionText = 'On which side of a chicken are the most feathers?',
		@Option1 = 'Left Side',
		@Option2 = 'Right Side',
		@Option3 = 'Inside',
		@Option4 = 'Outside',
		@CorrectAnswer = 'Outside';

	-- Inserting Question 7
	EXEC InsertQuestion
		@Id = 7,
		@QuestionText = 'a, d, g, j, …..',
		@Option1 = 'm',
		@Option2 = 'n',
		@Option3 = 'v',
		@Option4 = 't',
		@CorrectAnswer = 'm';

	-- Inserting Question 8
	EXEC InsertQuestion
		@Id = 8,
		@QuestionText = 'What is the diameter of a boxing ring?',
		@Option1 = '12 Feet',
		@Option2 = '12 Sq feet',
		@Option3 = '12 Yards',
		@Option4 = 'No answer is correct',
		@CorrectAnswer = 'No answer is correct';

	-- Inserting Question 9
	EXEC InsertQuestion
		@Id = 9,
		@QuestionText = 'Is it allowed for a man to marry his widow’s sister?',
		@Option1 = 'Yes',
		@Option2 = 'No',
		@Option3 = 'Only in some religions',
		@Option4 = 'Not possible at all',
		@CorrectAnswer = 'Not possible at all';

	-- Inserting Question 10
	EXEC InsertQuestion
		@Id = 10,
		@QuestionText = 'A, D, B, E, C, ……',
		@Option1 = 'J',
		@Option2 = 'H',
		@Option3 = 'F',
		@Option4 = 'E',
		@CorrectAnswer = 'F';

	-- Inserting Question 11
	EXEC InsertQuestion
		@Id = 11,
		@QuestionText = '6, 10, 16, 24, 34, …..',
		@Option1 = '33',
		@Option2 = '46',
		@Option3 = '47',
		@Option4 = '45',
		@CorrectAnswer = '46';

	-- Inserting Question 12
	EXEC InsertQuestion
		@Id = 12,
		@QuestionText = '1, 6, 2, 5, 3, 4, 4, ……',
		@Option1 = '2',
		@Option2 = '3',
		@Option3 = '4',
		@Option4 = '7',
		@CorrectAnswer = '3';

	-- Inserting Question 13
	EXEC InsertQuestion
		@Id = 13,
		@QuestionText = '1, 3, 2, 4, 6, ……..',
		@Option1 = '9',
		@Option2 = '6',
		@Option3 = '5',
		@Option4 = '7',
		@CorrectAnswer = '5';

	-- Inserting Question 14
	EXEC InsertQuestion
		@Id = 14,
		@QuestionText = 'Zoology is to monkey, as botany is to :',
		@Option1 = 'rose',
		@Option2 = 'mouse',
		@Option3 = 'student',
		@Option4 = 'bottle',
		@CorrectAnswer = 'rose';

	-- Inserting Question 15
	-- Inserting Question 16
	EXEC InsertQuestion
		@Id = 15,
		@QuestionText = 'What goes round the world but stays in a corner?',
		@Option1 = 'Envelope',
		@Option2 = 'Post Card',
		@Option3 = 'Pigeon',
		@Option4 = 'Stamp',
		@CorrectAnswer = 'Pigeon';

	-- Inserting Question 17
	EXEC InsertQuestion
		@Id = 16,
		@QuestionText = '5, 1, 4, 2, 3, 3, …..',
		@Option1 = '5',
		@Option2 = '2',
		@Option3 = '4',
		@Option4 = '3',
		@CorrectAnswer = '2';

	-- Inserting Question 18
	-- Inserting Question 19
	EXEC InsertQuestion
		@Id = 17,
		@QuestionText = 'Brine is to salt, as punch is to :',
		@Option1 = 'hit',
		@Option2 = 'sugar',
		@Option3 = 'Judy',
		@Option4 = 'water',
		@CorrectAnswer = 'water';

	-- Inserting Question 20
	EXEC InsertQuestion
		@Id = 18,
		@QuestionText = '80, 40, 20, 10, 5, ….',
		@Option1 = '0.5',
		@Option2 = '2.5',
		@Option3 = '0',
		@Option4 = 'b and c',
		@CorrectAnswer = '2.5';

	-- Inserting Question 23
	EXEC InsertQuestion
		@Id = 19,
		@QuestionText = 'Which article is most commonly used as cosmetic analyzer?',
		@Option1 = 'Shampoo',
		@Option2 = 'Face Cream',
		@Option3 = 'Tibbat Snow',
		@Option4 = 'Mirror',
		@CorrectAnswer = 'Mirror';

	-- Inserting Question 24
	EXEC InsertQuestion
		@Id = 20,
		@QuestionText = 'How many months have 28 days?',
		@Option1 = '1',
		@Option2 = '3',
		@Option3 = '2',
		@Option4 = 'All',
		@CorrectAnswer = 'All';

		

	-- Inserting Question 26
	EXEC InsertQuestion
		@Id = 21,
		@QuestionText = '2, 3, 5, 9, 17, …..',
		@Option1 = '33',
		@Option2 = '32',
		@Option3 = '30',
		@Option4 = '31',
		@CorrectAnswer = '33';

	-- Inserting Question 27
	EXEC InsertQuestion
		@Id = 22,
		@QuestionText = 'In this group, which object does not belong :',
		@Option1 = 'banana',
		@Option2 = 'computer',
		@Option3 = 'television',
		@Option4 = 'radio',
		@CorrectAnswer = 'banana';

	-- Inserting Question 28
	EXEC InsertQuestion
		@Id = 23,
		@QuestionText = 'If you rearrange the letters “ANICH”, you would have the name of a/an:',
		@Option1 = 'Fruit',
		@Option2 = 'City',
		@Option3 = 'Country',
		@Option4 = 'Ocean',
		@CorrectAnswer = 'City';

	-- Inserting Question 30
	EXEC InsertQuestion
		@Id = 24,
		@QuestionText = '1, 2, 3, 4, …….',
		@Option1 = '5',
		@Option2 = '6',
		@Option3 = '1',
		@Option4 = '7',
		@CorrectAnswer = '1';


	
	-- Inserting Question 35
	EXEC InsertQuestion
		@Id = 25,
		@QuestionText = 'Which letter does not belong in this series? Q, P, O, N, X, M',
		@Option1 = 'N',
		@Option2 = 'P',
		@Option3 = 'O',
		@Option4 = 'X',
		@CorrectAnswer = 'X';


	-- Inserting Question 40
	EXEC InsertQuestion
		@Id = 26,
		@QuestionText = 'm, j, g, d, ……',
		@Option1 = 'a',
		@Option2 = 'd',
		@Option3 = 'e',
		@Option4 = 'c',
		@CorrectAnswer = 'a';

	-- Inserting Question 41
	EXEC InsertQuestion
		@Id = 27,
		@QuestionText = 'i, g, e, …….',
		@Option1 = 'c',
		@Option2 = 'd',
		@Option3 = 'b',
		@Option4 = 'a',
		@CorrectAnswer = 'c';

	-- Inserting Question 42
	EXEC InsertQuestion
		@Id = 28,
		@QuestionText = '10 multiplied by 1/2 plus 10 is?',
		@Option1 = '20',
		@Option2 = '15',
		@Option3 = '5',
		@Option4 = '25',
		@CorrectAnswer = '15';

	-- Inserting Question 43
	EXEC InsertQuestion
		@Id = 29,
		@QuestionText = 'Bicycle is to ride, as car is to :',
		@Option1 = 'buy',
		@Option2 = 'fly',
		@Option3 = 'wash',
		@Option4 = 'drive',
		@CorrectAnswer = 'drive';

	-- Inserting Question 44
	EXEC InsertQuestion
		@Id = 30,
		@QuestionText = 'In this group, which word does not belong?',
		@Option1 = 'Cup',
		@Option2 = 'Pot',
		@Option3 = 'Jug',
		@Option4 = 'banana',
		@CorrectAnswer = 'banana';

	-- Inserting Question 45
	EXEC InsertQuestion
		@Id = 31,
		@QuestionText = '1, 3, 5, 7, …….',
		@Option1 = '5',
		@Option2 = '11',
		@Option3 = '7',
		@Option4 = '9',
		@CorrectAnswer = '9';

		-- Inserting Question 46
	EXEC InsertQuestion
		@Id = 32,
		@QuestionText = '1, 6, 2, 5, 3, 4, 4, ……',
		@Option1 = '2',
		@Option2 = '3',
		@Option3 = '4',
		@Option4 = '7',
		@CorrectAnswer = '3';

	-- Inserting Question 47
	EXEC InsertQuestion
		@Id = 33,
		@QuestionText = '1, 3, 2, 4, 6, ……..',
		@Option1 = '9',
		@Option2 = '6',
		@Option3 = '5',
		@Option4 = '7',
		@CorrectAnswer = '5';

	-- Inserting Question 48
	EXEC InsertQuestion
		@Id = 34,
		@QuestionText = 'Zoology is to monkey, as botany is to :',
		@Option1 = 'rose',
		@Option2 = 'mouse',
		@Option3 = 'student',
		@Option4 = 'bottle',
		@CorrectAnswer = 'rose';

	-- Inserting Question 50
	EXEC InsertQuestion
		@Id = 35,
		@QuestionText = 'What goes round the world but stays in a corner?',
		@Option1 = 'Envelope',
		@Option2 = 'Post Card',
		@Option3 = 'Pigeon',
		@Option4 = 'Stamp',
		@CorrectAnswer = 'Pigeon';

	-- Inserting Question 51
	EXEC InsertQuestion
		@Id = 36,
		@QuestionText = '5, 1, 4, 2, 3, 3, …..',
		@Option1 = '5',
		@Option2 = '2',
		@Option3 = '4',
		@Option4 = '3',
		@CorrectAnswer = '2';

	-- Inserting Question 53
	EXEC InsertQuestion
		@Id = 37,
		@QuestionText = 'Brine is to salt, as punch is to :',
		@Option1 = 'hit',
		@Option2 = 'sugar',
		@Option3 = 'Judy',
		@Option4 = 'water',
		@CorrectAnswer = 'water';

	-- Inserting Question 54
	EXEC InsertQuestion
		@Id = 38,
		@QuestionText = '80, 40, 20, 10, 5, ….',
		@Option1 = '0.5',
		@Option2 = '2.5',
		@Option3 = '0',
		@Option4 = 'b and c',
		@CorrectAnswer = '2.5';

	-- Inserting Question 57
	EXEC InsertQuestion
		@Id = 39,
		@QuestionText = 'Which article is most commonly used as a cosmetic analyzer?',
		@Option1 = 'Shampoo',
		@Option2 = 'Face Cream',
		@Option3 = 'Tibbat Snow',
		@Option4 = 'Mirror',
		@CorrectAnswer = 'Mirror';

	-- Inserting Question 58
	EXEC InsertQuestion
		@Id = 40,
		@QuestionText = 'How many months have 28 days?',
		@Option1 = '1',
		@Option2 = '3',
		@Option3 = '2',
		@Option4 = 'All',
		@CorrectAnswer = 'All';

	-- Inserting Question 60
	EXEC InsertQuestion
		@Id = 41,
		@QuestionText = '2, 3, 5, 9, 17, …..',
		@Option1 = '33',
		@Option2 = '32',
		@Option3 = '30',
		@Option4 = '31',
		@CorrectAnswer = '33';

	-- Inserting Question 61
	EXEC InsertQuestion
		@Id = 42,
		@QuestionText = 'In this group, which object does not belong :',
		@Option1 = 'banana',
		@Option2 = 'computer',
		@Option3 = 'television',
		@Option4 = 'radio',
		@CorrectAnswer = 'banana';

	-- Inserting Question 62
	EXEC InsertQuestion
		@Id = 43,
		@QuestionText = 'If you rearrange the letters "ANICH", you would have the name of a/an:',
		@Option1 = 'Fruit',
		@Option2 = 'City',
		@Option3 = 'Country',
		@Option4 = 'Ocean',
		@CorrectAnswer = 'City';

	-- Inserting Question 64
	EXEC InsertQuestion
		@Id = 44,
		@QuestionText = '1, 2, 3, 4, …….',
		@Option1 = '5',
		@Option2 = '6',
		@Option3 = '1',
		@Option4 = '7',
		@CorrectAnswer = '1';

	-- Inserting Question 65
	EXEC InsertQuestion
		@Id = 45,
		@QuestionText = 'Akbar says his grandfather is only six years older than his father. Akbar’s father is 40 and his grandfather,
		on his mother’s side, is 46 The grandfather was 20 when Akbar’s mother was born and she was 16 when Akbar was born. What is the age of Akbar?',
		@Option1 = '8',
		@Option2 = '9',
		@Option3 = '10',
		@Option4 = '7',
		@CorrectAnswer = '9';

	
	==============================================================================================================================================================================================================================
	select * from NonVerbalQuestions
	CREATE TABLE NonVerbalQuestions (
		Id INT PRIMARY KEY,
		Option1 VARCHAR(MAX),
		Option2 VARCHAR(MAX),
		Option3 VARCHAR(MAX),
		Option4 VARCHAR(MAX),
		CorrectAnswer VARCHAR(MAX)
	);

	-- Create the stored procedure
	Create PROCEDURE InsertNonVerbalQuestion
		@Id INT,
		@Option1 VARCHAR(MAX),
		@Option2 VARCHAR(MAX),
		@Option3 VARCHAR(MAX),
		@Option4 VARCHAR(MAX),
		@CorrectAnswer VARCHAR(MAX)
	AS
	BEGIN
		INSERT INTO NonVerbalQuestions (Id, Option1, Option2, Option3, Option4, CorrectAnswer)
		VALUES (@Id, @Option1, @Option2, @Option3, @Option4, @CorrectAnswer);
	END;

	-- Execute the stored procedure
	EXEC InsertNonVerbalQuestion
		@Id = 1,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '1';

	EXEC InsertNonVerbalQuestion
		@Id = 2,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '4';

	EXEC InsertNonVerbalQuestion
		@Id = 3,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '2';

	EXEC InsertNonVerbalQuestion
		@Id = 4,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '2';

	EXEC InsertNonVerbalQuestion
		@Id = 5,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '1';

	EXEC InsertNonVerbalQuestion
		@Id = 6,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '2';

	EXEC InsertNonVerbalQuestion
		@Id = 7,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '2';

	EXEC InsertNonVerbalQuestion
		@Id = 8,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3,4',
		@Option4 = '5',
		@CorrectAnswer = '5';

	EXEC InsertNonVerbalQuestion
		@Id = 9,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '3';

	EXEC InsertNonVerbalQuestion
		@Id = 10,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '4';

	EXEC InsertNonVerbalQuestion
		@Id = 11,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '4';

	EXEC InsertNonVerbalQuestion
		@Id = 12,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '2';

	EXEC InsertNonVerbalQuestion
		@Id = 13,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '3';

	EXEC InsertNonVerbalQuestion
		@Id = 14,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '1';

	EXEC InsertNonVerbalQuestion
		@Id = 15,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '3';

	EXEC InsertNonVerbalQuestion
		@Id = 16,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '1';

	EXEC InsertNonVerbalQuestion
		@Id = 17,
		@Option1 = '1',
		@Option2 = '2',
		@Option3 = '3',
		@Option4 = '4',
		@CorrectAnswer = '4';
	==================================================================================================================================
	CREATE TABLE AccQuestions (
		Id INT PRIMARY KEY,
		QuestionText VARCHAR(MAX),
		Option1 VARCHAR(MAX),
		Option2 VARCHAR(MAX),
		Option3 VARCHAR(MAX),
		Option4 VARCHAR(MAX),
		CorrectAnswer VARCHAR(MAX)
	);
	-- Insert  procedure
	CREATE PROCEDURE InsertAccQuestion
		@Id INT,
		@QuestionText VARCHAR(MAX),
		@Option1 VARCHAR(MAX),
		@Option2 VARCHAR(MAX),
		@Option3 VARCHAR(MAX),
		@Option4 VARCHAR(MAX),
		@CorrectAnswer VARCHAR(MAX)
	AS
	BEGIN
		INSERT INTO AccQuestions (Id, QuestionText, Option1, Option2, Option3, Option4, CorrectAnswer)
		VALUES (@Id, @QuestionText, @Option1, @Option2, @Option3, @Option4, @CorrectAnswer);
	END;
	delete from AccQuestions
	-- Insert Math questions
	EXEC InsertAccQuestion
		@Id = 1,
		@QuestionText = 'What is 2 + 2?',
		@Option1 = '3',
		@Option2 = '4',
		@Option3 = '5',
		@Option4 = '6',
		@CorrectAnswer = '4';

	EXEC InsertAccQuestion
		@Id = 2,
		@QuestionText = 'What is the square root of 16?',
		@Option1 = '2',
		@Option2 = '3',
		@Option3 = '4',
		@Option4 = '5',
		@CorrectAnswer = '4';

	-- Insert Physics questions
	EXEC InsertAccQuestion
		@Id = 3,
		@QuestionText = 'What is the unit of force in the SI system?',
		@Option1 = 'Joule',
		@Option2 = 'Newton',
		@Option3 = 'Watt',
		@Option4 = 'Volt',
		@CorrectAnswer = 'Newton';

	EXEC InsertAccQuestion
		@Id = 4,
		@QuestionText = 'Which law states that for every action, there is an equal and opposite reaction?',
		@Option1 = 'Newton''s First Law',
		@Option2 = 'Newton''s Second Law',
		@Option3 = 'Newton''s Third Law',
		@Option4 = 'Newton''s Law of Universal Gravitation',
		@CorrectAnswer = 'Newton''s Third Law';

	-- Insert General Knowledge questions
	EXEC InsertAccQuestion
		@Id = 5,
		@QuestionText = 'What is the capital city of France?',
		@Option1 = 'Paris',
		@Option2 = 'Rome',
		@Option3 = 'Berlin',
		@Option4 = 'Madrid',
		@CorrectAnswer = 'Paris';

	EXEC InsertAccQuestion
		@Id = 6,
		@QuestionText = 'Which planet is known as the Red Planet?',
		@Option1 = 'Venus',
		@Option2 = 'Mars',
		@Option3 = 'Jupiter',
		@Option4 = 'Saturn',
		@CorrectAnswer = 'Mars';

	-- Insert Pakistan Armed Forces questions
	EXEC InsertAccQuestion
		@Id = 7,
		@QuestionText = 'Who is the current Chief of Army Staff of Pakistan?',
		@Option1 = 'General Qamar Javed Bajwa',
		@Option2 = 'General Raheel Sharif',
		@Option3 = 'General Ashfaq Parvez Kayani',
		@Option4 = 'General Pervez Musharraf',
		@CorrectAnswer = 'General Qamar Javed Bajwa';

	EXEC InsertAccQuestion
		@Id = 8,
		@QuestionText = 'Which branch of Pakistan Armed Forces deals with naval operations?',
		@Option1 = 'Pakistan Army',
		@Option2 = 'Pakistan Navy',
		@Option3 = 'Pakistan Air Force',
		@Option4 = 'Pakistan Rangers',
		@CorrectAnswer = 'Pakistan Navy';

		-- Insert more Math questions
	EXEC InsertAccQuestion
		@Id = 9,
		@QuestionText = 'What is the value of pi (π) to two decimal places?',
		@Option1 = '3.14',
		@Option2 = '3.16',
		@Option3 = '3.18',
		@Option4 = '3.12',
		@CorrectAnswer = '3.14';

	EXEC InsertAccQuestion
		@Id = 10,
		@QuestionText = 'What is the next number in the sequence: 2, 4, 6, 8, ___?',
		@Option1 = '10',
		@Option2 = '12',
		@Option3 = '14',
		@Option4 = '16',
		@CorrectAnswer = '10';

	-- Insert more Physics questions
	EXEC InsertAccQuestion
		@Id = 11,
		@QuestionText = 'Which of the following is not a fundamental particle?',
		@Option1 = 'Electron',
		@Option2 = 'Proton',
		@Option3 = 'Neutron',
		@Option4 = 'Photon',
		@CorrectAnswer = 'Photon';

	EXEC InsertAccQuestion
		@Id = 12,
		@QuestionText = 'What is the unit of electrical resistance?',
		@Option1 = 'Ohm',
		@Option2 = 'Volt',
		@Option3 = 'Ampere',
		@Option4 = 'Watt',
		@CorrectAnswer = 'Ohm';

	-- Insert more General Knowledge questions
	EXEC InsertAccQuestion
		@Id = 13,
		@QuestionText = 'What is the longest river in the world?',
		@Option1 = 'Nile',
		@Option2 = 'Amazon',
		@Option3 = 'Yangtze',
		@Option4 = 'Mississippi',
		@CorrectAnswer = 'Nile';

	EXEC InsertAccQuestion
		@Id = 14,
		@QuestionText = 'Who wrote the novel "To Kill a Mockingbird"?',
		@Option1 = 'Harper Lee',
		@Option2 = 'J.K. Rowling',
		@Option3 = 'Stephen King',
		@Option4 = 'Charles Dickens',
		@CorrectAnswer = 'Harper Lee';

	-- Insert more Pakistan Armed Forces questions
	EXEC InsertAccQuestion
		@Id = 15,
		@QuestionText = 'What is the motto of Pakistan Air Force?',
		@Option1 = 'Faith, Unity, Discipline',
		@Option2 = 'Shaheen: Istaqlal, Himmat, Junoon',
		@Option3 = 'Sacrifice, Unity, Faith',
		@Option4 = 'Junoobi Pakistan Air Force',
		@CorrectAnswer = 'Shaheen: Istaqlal, Himmat, Junoon';

	EXEC InsertAccQuestion
		@Id = 16,
		@QuestionText = 'When was Pakistan Navy established?',
		@Option1 = '1945',
		@Option2 = '1947',
		@Option3 = '1949',
		@Option4 = '1951',
		@CorrectAnswer = '1947';

	-- Insert more Math questions
	EXEC InsertAccQuestion
		@Id = 17,
		@QuestionText = 'What is the square of 12?',
		@Option1 = '144',
		@Option2 = '156',
		@Option3 = '168',
		@Option4 = '180',
		@CorrectAnswer = '144';

	-- Insert more Physics questions
	EXEC InsertAccQuestion
		@Id = 18,
		@QuestionText = 'What is the SI unit of energy?',
		@Option1 = 'Joule',
		@Option2 = 'Watt',
		@Option3 = 'Volt',
		@Option4 = 'Newton',
		@CorrectAnswer = 'Joule';

	-- Insert more General Knowledge questions
	EXEC InsertAccQuestion
		@Id = 19,
		@QuestionText = 'Who painted the Mona Lisa?',
		@Option1 = 'Leonardo da Vinci',
		@Option2 = 'Pablo Picasso',
		@Option3 = 'Vincent van Gogh',
		@Option4 = 'Michelangelo',
		@CorrectAnswer = 'Leonardo da Vinci';

	-- Insert more Pakistan Armed Forces questions
	EXEC InsertAccQuestion
		@Id = 20,
		@QuestionText = 'Who is the current Chief of Naval Staff of Pakistan?',
		@Option1 = 'Admiral Muhammad Amjad Khan Niazi',
		@Option2 = 'Admiral Zafar Mahmood Abbasi',
		@Option3 = 'Admiral Asif Sandila',
		@Option4 = 'Admiral Muhammad Zakaullah',
		@CorrectAnswer = 'Admiral Muhammad Amjad Khan Niazi';
	

	====================================================================================================================================================================
	---Registration Table--------------
	Create TABLE PakistanNavy (
		ID INT PRIMARY KEY IDENTITY(1080000,1),
		ForcetoApply NVARCHAR(MAX),
		Name NVARCHAR(MAX),
		Fname NVARCHAR(MAX),
		CNIC NVARCHAR(MAX),
		FCNIC NVARCHAR(MAX),
		Gender NVARCHAR(MAX),
		Status NVARCHAR(MAX),
		Religion NVARCHAR(MAX),
		Province NVARCHAR(MAX),
		Domicile NVARCHAR(MAX),
		DOB NVARCHAR(MAX),
		Email NVARCHAR(MAX),
		PostalAddress NVARCHAR(MAX),
		PermanentAddress NVARCHAR(MAX),
		CandidateMobile NVARCHAR(MAX),
		FatherMobile NVARCHAR(MAX),
		personImg varchar(50)
	);

	CREATE PROCEDURE SearchPakistanNavyByCNIC
		@CNIC NVARCHAR(MAX)
	AS
	BEGIN
		-- Select all columns from PakistanNavy where CNIC matches the input parameter
		SELECT 
			ID,
			ForcetoApply,
			Name,
			Fname,
			CNIC,
			FCNIC,
			Gender,
			Status,
			Religion,
			Province,
			Domicile,
			DOB,
			Email,
			PostalAddress,
			PermanentAddress,
			CandidateMobile,
			FatherMobile
			  FROM 
			PakistanNavy
		WHERE 
			CNIC = @CNIC;
	END;

	CREATE PROCEDURE RegisterCandidate
		@ForcetoApply NVARCHAR(MAX),
		@Name NVARCHAR(MAX),
		@Fname NVARCHAR(MAX),
		@CNIC NVARCHAR(MAX),
		@FCNIC NVARCHAR(MAX),
		@Gender NVARCHAR(MAX),
		@Status NVARCHAR(MAX),
		@Religion NVARCHAR(MAX),
		@Province NVARCHAR(MAX),
		@Domicile NVARCHAR(MAX),
		@DOB NVARCHAR(MAX),
		@Email NVARCHAR(MAX),
		@PostalAddress NVARCHAR(MAX),
		@PermanentAddress NVARCHAR(MAX),
		@CandidateMobile NVARCHAR(MAX),
		@FatherMobile NVARCHAR(MAX),
		@personImg VARCHAR(50)
	AS
	BEGIN
		INSERT INTO PakistanNavy (
			ForcetoApply,
			Name,
			Fname,
			CNIC,
			FCNIC,
			Gender,
			Status,
			Religion,
			Province,
			Domicile,
			DOB,
			Email,
			PostalAddress,
			PermanentAddress,
			CandidateMobile,
			FatherMobile,
			personImg
		)
		VALUES (
			@ForcetoApply,
			@Name,
			@Fname,
			@CNIC,
			@FCNIC,
			@Gender,
			@Status,
			@Religion,
			@Province,
			@Domicile,
			@DOB,
			@Email,
			@PostalAddress,
			@PermanentAddress,
			@CandidateMobile,
			@FatherMobile,
			@personImg
		);
	END;

	CREATE VIEW ViewRegistration AS
	SELECT 
		ID,
		ForcetoApply,
		Name,
		Fname,
		CNIC,
		FCNIC,
		Gender,
		Status,
		Religion,
		Province,
		Domicile,
		DOB,
		Email,
		PostalAddress,
		PermanentAddress,
		CandidateMobile,
		FatherMobile
	FROM PakistanNavy;

	select * from ViewRegistration
	drop view PakistanNavy
	======================================================================================================
	---Clear Test  Canidate

	CREATE TABLE ClearTest (
		ID INT PRIMARY KEY FOREIGN KEY REFERENCES PakistanNavy(ID),
		CNIC NVARCHAR(50),
		ForcetoApply NVARCHAR(MAX)
	);


	CREATE PROCEDURE InsertClearTestID
		@ID INT,
		@CNIC NVARCHAR(50),
		@ForcetoApply NVARCHAR(MAX)
	AS
	BEGIN
		-- Insert logic here
		INSERT INTO ClearTest (ID, CNIC, ForcetoApply)
		VALUES (@ID, @CNIC, @ForcetoApply)
	END

		select * from ClearTest

	===============================================================================================
	--Medical Test

	CREATE TABLE MedicalTest (
		ID INT PRIMARY KEY FOREIGN KEY REFERENCES ClearTest(ID),
		CNIC NVARCHAR(MAX) NOT NULL,
		DateOfTest NVARCHAR(MAX) NOT NULL,
		ConductingDoctor VARCHAR(100) NOT NULL,
		VisionTest VARCHAR(50) NOT NULL,
		HearingTest VARCHAR(50) NOT NULL,
		BloodPressure VARCHAR(50) NOT NULL,
		Height FLOAT NOT NULL,
		Weight FLOAT NOT NULL,
		BMI FLOAT NOT NULL,
		Allergies VARCHAR(255),
		PastMedicalHistory VARCHAR(255),
		TestRemarks VARCHAR(255)
	);


	CREATE PROCEDURE InsertMedicalTest
		@ID INT,
		@CNIC NVARCHAR(MAX),
		@DateOfTest NVARCHAR(MAX),
		@ConductingDoctor VARCHAR(100),
		@VisionTest VARCHAR(50),
		@HearingTest VARCHAR(50),
		@BloodPressure VARCHAR(50),
		@Height FLOAT,
		@Weight FLOAT,
		@BMI FLOAT,
		@Allergies VARCHAR(255),
		@PastMedicalHistory VARCHAR(255),
		@TestRemarks VARCHAR(255)
	AS
	BEGIN
		INSERT INTO MedicalTest (ID, CNIC, DateOfTest, ConductingDoctor, VisionTest, HearingTest, BloodPressure, Height, Weight, BMI, Allergies, PastMedicalHistory, TestRemarks)
		VALUES (@ID, @CNIC, @DateOfTest, @ConductingDoctor, @VisionTest, @HearingTest, @BloodPressure, @Height, @Weight, @BMI, @Allergies, @PastMedicalHistory, @TestRemarks);
	END

	-- Procedure to search TestRemarks by ID
CREATE PROCEDURE SearchMedicalTestRemarks
    @ID INT
AS
BEGIN
    SELECT TestRemarks
    FROM MedicalTest
    WHERE ID = @ID;
END;


	CREATE PROCEDURE UpdateMedicalTest
		@ID INT,
		@CNIC NVARCHAR(MAX),
		@DateOfTest NVARCHAR(MAX),
		@ConductingDoctor VARCHAR(100),
		@VisionTest VARCHAR(50),
		@HearingTest VARCHAR(50),
		@BloodPressure VARCHAR(50),
		@Height FLOAT,
		@Weight FLOAT,
		@BMI FLOAT,
		@Allergies VARCHAR(255),
		@PastMedicalHistory VARCHAR(255),
		@TestRemarks VARCHAR(255)
	AS
	BEGIN
		UPDATE MedicalTest
		SET DateOfTest = @DateOfTest,
			ConductingDoctor = @ConductingDoctor,
			VisionTest = @VisionTest,
			HearingTest = @HearingTest,
			BloodPressure = @BloodPressure,
			Height = @Height,
			Weight = @Weight,
			BMI = @BMI,
			Allergies = @Allergies,
			PastMedicalHistory = @PastMedicalHistory,
			TestRemarks = @TestRemarks
		WHERE ID = @ID AND CNIC = @CNIC;
	END

	-- Create procedure to search data by ID
CREATE PROCEDURE Search_data
    @SearchID INT
AS
BEGIN
    SELECT 
        ID,
        CNIC,
        DateOfTest,
        ConductingDoctor,
        VisionTest,
        HearingTest,
        BloodPressure,
        Height,
        Weight,
        BMI,
        Allergies,
        PastMedicalHistory,
        TestRemarks
    FROM 
        MedicalTest
    WHERE 
        ID = @SearchID;
END;

--CREATE A VIEW TO DISPLAY  RECORD
	CREATE VIEW MedicalTest_View AS
SELECT 
    ID,
    CNIC,
    DateOfTest,
    ConductingDoctor,
    VisionTest,
    HearingTest,
    BloodPressure,
    Height,
    Weight,
    BMI,
    Allergies,
    PastMedicalHistory,
    TestRemarks
FROM MedicalTest;
Select * from MedicalTest
==============================================================================================
----ADMIN TABLE
CREATE TABLE Admin (
    ID INT PRIMARY KEY,
    Password NVARCHAR(MAX) NOT NULL,
    TeamName NVARCHAR(MAX) NOT NULL
);
--Procedure to insert
-- Create Admin table
Create TABLE MedicalAdmin (
    ID INT PRIMARY KEY,
    Password NVARCHAR(MAX) NOT NULL,
    TeamName NVARCHAR(MAX) NOT NULL
);

Create VIEW MedicalAdmin_View AS
SELECT 
    ID,
    Password,
    TeamName
FROM MedicalAdmin;

-- Create procedure to insert data into Admin table
 CREATE PROCEDURE InsertMedicalAdminData
    @ID INT,
    @Password NVARCHAR(MAX),
    @TeamName NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO MedicalAdmin (ID, Password, TeamName)
    VALUES (@ID, @Password, @TeamName);
END;

-- Insert sample data for demonstration
-- Insert first set of data
EXEC InsertMedicalAdminData @ID = 500080, @Password = 'password1', @TeamName = 'Alpha Team';

-- Insert second set of data
EXEC InsertMedicalAdminData @ID = 700045, @Password = 'password2', @TeamName = 'Bravo Team';

-- Insert third set of data
EXEC InsertMedicalAdminData @ID = 677777, @Password = 'password3', @TeamName = 'Charlie Team';

-- Insert fourth set of data
EXEC InsertMedicalAdminData @ID = 101010, @Password = 'password4', @TeamName = 'Delta Team';

Select * from MedicalAdmin
Select * from MedicalAdmin_View
============================================================================================
----Create Admin of Physical Test
Create TABLE PhysicalTestAdmin (
    ID INT PRIMARY KEY,
    Password NVARCHAR(MAX) NOT NULL,
    TeamName NVARCHAR(MAX) NOT NULL
);

---View

CREATE VIEW PhysicalTestAdmin_View AS
SELECT 
    ID,
    Password,
    TeamName
FROM PhysicalTestAdmin;

--procedure
 CREATE PROCEDURE InsertPhysicalTestAdmin
    @ID INT,
    @Password NVARCHAR(MAX),
    @TeamName NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO PhysicalTestAdmin (ID, Password, TeamName)
    VALUES (@ID, @Password, @TeamName);
END;

EXEC InsertPhysicalTestAdmin @ID = 100080, @Password = 'password1', @TeamName = 'Alpha Team';

-- Insert second set of data
EXEC InsertPhysicalTestAdmin @ID = 100040, @Password = 'password2', @TeamName = 'Bravo Team';

-- Insert third set of data
EXEC InsertPhysicalTestAdmin @ID = 177777, @Password = 'password3', @TeamName = 'Charlie Team';

-- Insert fourth set of data
EXEC InsertPhysicalTestAdmin @ID = 121010, @Password = 'password4', @TeamName = 'Delta Team';

Select * from PhysicalTestAdmin_View
Select * from PhysicalTestAdmin
============================================================================================
-----Physical Test Table

	CREATE TABLE PhysicalTest (
    ID INT PRIMARY KEY FOREIGN KEY REFERENCES ClearTest(ID),
    CNIC NVARCHAR(MAX) NOT NULL,
    DateOfTest NVARCHAR(MAX) NOT NULL,
    Incharge VARCHAR(100) NOT NULL,
    RunningTiming VARCHAR(50) NOT NULL,
    PushUps VARCHAR(50) NOT NULL,
    SitUps VARCHAR(50) NOT NULL,
    ChinUps VARCHAR(50) NOT NULL,
    TestRemarks VARCHAR(255)
);

---View of the table

CREATE VIEW PhysicalTest_View AS
SELECT 
    ID,
    CNIC,
    DateOfTest,
    Incharge,
    RunningTiming,
    PushUps,
    SitUps,
    ChinUps,
    TestRemarks
FROM PhysicalTest;

---PROCEDURE TO INSERT
CREATE PROCEDURE InsertPhysicalTest
    @ID INT,
    @CNIC NVARCHAR(MAX),
    @DateOfTest NVARCHAR(MAX),
    @Incharge VARCHAR(100),
    @RunningTiming VARCHAR(50),
    @PushUps VARCHAR(50),
    @SitUps VARCHAR(50),
    @ChinUps VARCHAR(50),
    @TestRemarks VARCHAR(255)
AS
BEGIN
    INSERT INTO PhysicalTest (ID, CNIC, DateOfTest, Incharge, RunningTiming, PushUps, SitUps, ChinUps, TestRemarks)
    VALUES (@ID, @CNIC, @DateOfTest, @Incharge, @RunningTiming, @PushUps, @SitUps, @ChinUps, @TestRemarks);
END;

-----update procedure
CREATE PROCEDURE UpdatePhysicalTest
    @ID INT,
    @DateOfTest NVARCHAR(MAX),
    @Incharge VARCHAR(100),
    @RunningTiming VARCHAR(50),
    @PushUps VARCHAR(50),
    @SitUps VARCHAR(50),
    @ChinUps VARCHAR(50),
    @TestRemarks VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PhysicalTest
    SET 
        DateOfTest = @DateOfTest,
        Incharge = @Incharge,
        RunningTiming = @RunningTiming,
        PushUps = @PushUps,
        SitUps = @SitUps,
        ChinUps = @ChinUps,
        TestRemarks = @TestRemarks
    WHERE 
        ID = @ID;
END;
----Search procedure
CREATE PROCEDURE SearchPhysicalTestByID
    @ID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        ID,
        CNIC,
        DateOfTest,
        Incharge,
        RunningTiming,
        PushUps,
        SitUps,
        ChinUps,
        TestRemarks
    FROM 
        PhysicalTest
    WHERE 
        ID = @ID;
END;

CREATE PROCEDURE SearchTestRemarksByID
    @ID INT
AS
BEGIN
    SELECT TestRemarks
    FROM PhysicalTest
    WHERE ID = @ID;
END;

Select * from MedicalTest

Select * from PhysicalTest
Select * from PhysicalTest_View



=============================================================================================
----FinalResult
-- Create the FinalResult table
Create TABLE FinalResult (
    ID INT FOREIGN KEY REFERENCES ClearTest(ID),
    CNIC NVARCHAR(MAX) NOT NULL,
    DateOfTest NVARCHAR(MAX) NOT NULL,
    Incharge VARCHAR(100) NOT NULL,
    ConductingDoctor VARCHAR(100) NOT NULL,
    PhysicalTestRemarks VARCHAR(255),
    MedicalTestRemarks VARCHAR(255),
    CombinedRemarks AS CASE 
        WHEN PhysicalTestRemarks = 'Pass' AND MedicalTestRemarks = 'Fit' THEN 'Pass'
        ELSE 'Fail'
    END,
    PRIMARY KEY (ID)
);

Create PROCEDURE PopulateFinalResult
AS
BEGIN
    INSERT INTO FinalResult (ID, CNIC, DateOfTest, Incharge, ConductingDoctor, PhysicalTestRemarks, MedicalTestRemarks)
    SELECT 
        p.ID,
        c.CNIC,
        p.DateOfTest,
        p.Incharge,
        m.ConductingDoctor,
        p.TestRemarks AS PhysicalTestRemarks,
        m.TestRemarks AS MedicalTestRemarks
    FROM PhysicalTest p
    JOIN MedicalTest m ON p.ID = m.ID
    JOIN ClearTest c ON p.ID = c.ID
    WHERE p.TestRemarks = 'Pass' AND m.TestRemarks = 'Fit'
    AND NOT EXISTS (
        SELECT 1
        FROM FinalResult f
        WHERE f.ID = p.ID
    );
END;
select * from FinalResult 
Select * from Medical

CREATE VIEW		 AS
SELECT 
    ID,
    CNIC,
    DateOfTest,
    Incharge,
    ConductingDoctor,
    PhysicalTestRemarks,
    MedicalTestRemarks,
    CombinedRemarks
FROM FinalResult;

CREATE PROCEDURE SearchFinalResultByID
    @ID INT
AS
BEGIN
    SELECT 
        ID,	
        CNIC,
        DateOfTest,
        Incharge,
        ConductingDoctor,
        PhysicalTestRemarks,
        MedicalTestRemarks,
        CombinedRemarks
    FROM FinalResult
    WHERE ID = @ID;
END;

CREATE PROCEDURE SearchCombinedRemarksByID
    @ID INT
AS
BEGIN
    DECLARE @CombinedRemarks VARCHAR(10);

    SELECT 
        @CombinedRemarks = CombinedRemarks
    FROM FinalResult
    WHERE ID = @ID;
    SELECT @CombinedRemarks AS CombinedRemarks;
END;
EXEC  PopulateFinalResult




===========================================================================================
-----SelectionAdmin

Create TABLE FinalSelectionAdmin (
    ID INT PRIMARY KEY,
    Password NVARCHAR(MAX) NOT NULL,
    TeamName NVARCHAR(MAX) NOT NULL
);

Create VIEW FinalSelectionAdmin_View AS
SELECT 
    ID,
    Password,
   TeamName
FROM FinalSelectionAdmin;

-- Create procedure to insert data into Admin table
 CREATE PROCEDURE InsertFinalSelectionAdmin
    @ID INT,
    @Password NVARCHAR(MAX),
    @TeamName NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO FinalSelectionAdmin (ID, Password, TeamName)
    VALUES (@ID, @Password, @TeamName);
END;

-- Insert sample data for demonstration
-- Insert first set of data
EXEC InsertFinalSelectionAdmin @ID = 1111, @Password = 'password1', @TeamName = 'Alpha Team';

-- Insert second set of data
EXEC InsertFinalSelectionAdmin @ID = 2222, @Password = 'password2', @TeamName = 'Bravo Team';

-- Insert third set of data
EXEC InsertFinalSelectionAdmin @ID = 3333, @Password = 'password3', @TeamName = 'Charlie Team';
============================================================================================














-----Triggers
=====================================================================================

CREATE TABLE AuditPakistanNavy (
    AuditID INT PRIMARY KEY IDENTITY,
    Operation VARCHAR(255),
    RecordID INT,
    AuditTime DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Create a view to retrieve audit logs from AuditPakistanNavy table
CREATE VIEW vw_AuditPakistanNavy
AS
SELECT 
    AuditID,
    Operation,
    RecordID,
    AuditTime
FROM 
    AuditPakistanNavy;


-- Example INSERT statement into PakistanNavy
INSERT INTO PakistanNavy (ForcetoApply, Name, Fname, CNIC, FCNIC, Gender, Status, Religion, Province, Domicile, DOB, Email, PostalAddress, PermanentAddress, CandidateMobile, FatherMobile)
VALUES ('Navy', 'Ahad', 'Rehan', '12345-6789123-1', '98765-4321987-1', 'Male', 'Non Married', 'Islam', 'Sindh', 'Karachi', '1990-01-01', 'ahad@example.com', '123 Street', '456 Avenue', '9876543210', '9876543211');

-- After this insert, the audit_for_PakistanNavy trigger will automatically insert a record into AuditPakistanNavy table.
	
	======================================================================================================
CREATE TABLE AuditClearTest (
    AuditID INT PRIMARY KEY IDENTITY,
    Operation VARCHAR(255),
    RecordID INT,
    AuditTime DATETIME DEFAULT CURRENT_TIMESTAMP
);


CREATE TRIGGER trg_AuditInsert_ClearTest
ON ClearTest
AFTER INSERT
AS 
BEGIN
    DECLARE @Operation VARCHAR(255) = 'INSERT';
    DECLARE @RecordID INT;
    
    -- Get the inserted record's ID
    SELECT @RecordID = i.ID FROM inserted i;
    
    -- Insert a record into the audit table
    INSERT INTO AuditClearTest (Operation, RecordID, AuditTime)
    VALUES (@Operation, @RecordID, CURRENT_TIMESTAMP);
END;

-- Create a view to retrieve audit logs from AuditClearTest table
CREATE VIEW vw_AuditClearTest
AS
SELECT 
    AuditID,
    Operation,
    RecordID,
    AuditTime
FROM 
    AuditClearTest;

	INSERT INTO ClearTest (ID, CNIC, ForcetoApply)
		VALUES (1080005, 12345-6789123-1,'Pakistan Navy')
	
	Select * from AuditClearTest 
	----clearTestPakistanNavy
	========================================================================
	CREATE TABLE MedicalTestAudit (
    AuditID INT PRIMARY KEY IDENTITY,
    Operation VARCHAR(50),
    RecordID INT,
    CNIC NVARCHAR(MAX),
    AuditTime DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TRIGGER trg_MedicalTestAudit
ON MedicalTest
AFTER INSERT, UPDATE
AS
BEGIN
    -- Insert audit record for inserted rows
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        INSERT INTO MedicalTestAudit (Operation, RecordID, CNIC, AuditTime)
        SELECT 
            CASE
                WHEN EXISTS (SELECT * FROM deleted WHERE deleted.ID = inserted.ID) THEN 'UPDATE'
                ELSE 'INSERT'
            END,
            inserted.ID,
            inserted.CNIC,
            CURRENT_TIMESTAMP
        FROM inserted;
    END

    -- Insert audit record for updated rows
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        INSERT INTO MedicalTestAudit (Operation, RecordID, CNIC, AuditTime)
        SELECT 
            'UPDATE',
            deleted.ID,
            deleted.CNIC,
            CURRENT_TIMESTAMP
        FROM deleted;
    END
END;

EXEC InsertMedicalTest
    @ID = 1080005,
    @CNIC = '12345-6789123-1',
    @DateOfTest = '2024-06-14',
    @ConductingDoctor = 'Dr. Ahmed',
    @VisionTest = '20/20',
    @HearingTest = 'Normal',
    @BloodPressure = '120/80',
    @Height = 180.0,
    @Weight = 75.0,
    @BMI = 23.1,
    @Allergies = 'None',
    @PastMedicalHistory = 'No significant history',
    @TestRemarks = 'Fit';

	INSERT INTO PhysicalTest (ID, CNIC, DateOfTest, Incharge, RunningTiming, PushUps, SitUps, ChinUps, TestRemarks)
VALUES 
(1080005, '12345-6789123-1', '2024-06-14', 'Incharge Officer A', '15:30', '20', '25', '10', 'Pass');

-- Create a view to retrieve audit logs from MedicalTestAudit table
CREATE VIEW vw_MedicalTestAudit
AS
SELECT 
    AuditID,
    Operation,
    RecordID,
    CNIC,
    AuditTime
FROM 
    MedicalTestAudit;
	Select * From vw_MedicalTestAudit
	================================================================================
	CREATE TABLE FinalResultAudit (
    AuditID INT PRIMARY KEY IDENTITY,
    Operation VARCHAR(50),
    RecordID INT,
    CNIC NVARCHAR(MAX),
    AuditTime DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Create a view to retrieve audit logs from FinalResultAudit table
CREATE VIEW vw_FinalResultAudit
AS
SELECT 
    AuditID,
    Operation,
    RecordID,
    CNIC,
    AuditTime
FROM 
    FinalResultAudit;


	CREATE TRIGGER trg_AuditFinalResult
ON FinalResult
AFTER INSERT
AS
BEGIN
    DECLARE @Operation VARCHAR(50), @RecordID INT, @CNIC NVARCHAR(MAX);

    SET @Operation = 'INSERT';

    SELECT @RecordID = i.ID, @CNIC = i.CNIC
    FROM inserted i;

    INSERT INTO FinalResultAudit (Operation, RecordID, CNIC, AuditTime)
    VALUES (@Operation, @RecordID, @CNIC, CURRENT_TIMESTAMP);
END;

Select * from FinalResultAudit

=============================================================================
CREATE TABLE ISSBREG (
		ID INT PRIMARY KEY IDENTITY(1,1),
		ForcetoApply NVARCHAR(MAX),
		Name NVARCHAR(MAX),
		Fname NVARCHAR(MAX),
		CNIC NVARCHAR(MAX),
		FCNIC NVARCHAR(MAX),
		Gender NVARCHAR(MAX),
		Status NVARCHAR(MAX),
		Religion NVARCHAR(MAX),
		Province NVARCHAR(MAX),
		Domicile NVARCHAR(MAX),
		DOB NVARCHAR(MAX),
		Email NVARCHAR(MAX),
		PostalAddress NVARCHAR(MAX),
		PermanentAddress NVARCHAR(MAX),
		CandidateMobile NVARCHAR(MAX),
		FatherMobile NVARCHAR(MAX)
		
	);
select * from ISSBREG

CREATE PROCEDURE SearchIDByCNIC
    @CNIC NVARCHAR(MAX)
AS
BEGIN
    SELECT ID
    FROM ISSBREG
    WHERE CNIC = @CNIC;
END;
================================================================================
CREATE TABLE Psyctest (
    ID INT PRIMARY KEY FOREIGN KEY REFERENCES ISSBREG(ID),
    CNIC NVARCHAR(MAX),
    TestDateTime DATETIME DEFAULT GETDATE()
);

CREATE PROCEDURE InsertIntoPsyctest
    @ID INT,
    @CNIC NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Psyctest (ID, CNIC)
    VALUES (@ID, @CNIC);
    SELECT @@IDENTITY AS 'InsertedID'; -- Optional: Return the inserted ID
END;


CREATE PROCEDURE CheckCNICExistence
		@CNIC VARCHAR(20)
	AS
	BEGIN
		SET NOCOUNT ON;
    
		DECLARE @Count INT;
    
		SELECT @Count = COUNT(*) FROM ISSBREG WHERE CNIC = @CNIC;
    
		SELECT @Count AS 'Count';
	END



		