CREATE TABLE Song(
	songId INTEGER AUTO_INCREMENT,
	title VARCHAR(255),
	artist VARCHAR(255),
	PRIMARY KEY(songId));

CREATE TABLE Contributor(
	contributorId INTEGER AUTO_INCREMENT,
	fname VARCHAR(255),
	lname VARCHAR(255),
	PRIMARY KEY(contributorId));

CREATE TABLE Contribution(
	contributionId INTEGER AUTO_INCREMENT,
	contributorId INTEGER,
	songId INTEGER,
	contributed VARCHAR(255),
	PRIMARY KEY(contributionId),
	FOREIGN KEY(contributorId) REFERENCES Contributor(contributorId),
	FOREIGN KEY(songId) REFERENCES Song(songId));

CREATE TABLE User(
	userId INTEGER AUTO_INCREMENT,
	fname VARCHAR(255),
	lname VARCHAR(255),
	PRIMARY KEY(userId));

CREATE TABLE KaraokeTrack(
	trackId INTEGER AUTO_INCREMENT,
	songId INTEGER,
	version INTEGER,
	PRIMARY KEY(trackId),
	FOREIGN KEY(songId) REFERENCES Song(songId));

CREATE TABLE FreeQueue(
	queueId INTEGER AUTO_INCREMENT,
	trackId INTEGER,
	userId INTEGER,
	time VARCHAR(255),
	isPlayed VARCHAR(255),
	PRIMARY KEY(queueId),
	FOREIGN KEY(trackId) REFERENCES KaraokeTrack(trackId),
	FOREIGN KEY(userId) REFERENCES User(userId));

CREATE TABLE PaidQueue(
	queueId INTEGER AUTO_INCREMENT,
	trackId INTEGER,
	userId INTEGER,
	payAmount DECIMAL(4,2),
	time VARCHAR(255),
	isPlayed VARCHAR(255),
	PRIMARY KEY(queueId),
	FOREIGN KEY(trackId) REFERENCES KaraokeTrack(trackId),
	FOREIGN KEY(userId) REFERENCES User(userId));
