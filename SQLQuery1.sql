CREATE TABLE voters (
	id		int			NOT NULL	PRIMARY KEY		IDENTITY,
	fname	varchar(50)	NOT NULL,
	lname	varchar(50)	NOT NULL,
	party	varchar(3)	NOT NULL
);

INSERT INTO voters (fname, lname, party)
VALUES
	('Bob', 'Smith', 'RED'),
	('Alice', 'Way', 'RED'),
	('Arnold', 'Truman', 'BLU'),
	('Stacy', 'Goldberg', 'RED'),
	('Pierre', 'Juneaux', 'BLU')