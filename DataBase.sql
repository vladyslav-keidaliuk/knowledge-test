CREATE TABLE users(
    FIO VARCHAR(100),
    Login VARCHAR(30),
    Password VARCHAR(30),
    Email VARCHAR(50),
    Score INT
);


CREATE TABLE Tasks(
    Number INT AUTO_INCREMENT PRIMARY KEY ,
    Theme TEXT,
    Code TEXT,
    Question Text,
    PossibleAnswer1 Text,
    PossibleAnswer2 Text,
    PossibleAnswer3 Text,
    PossibleAnswer4 Text,
    Answer Text
);
