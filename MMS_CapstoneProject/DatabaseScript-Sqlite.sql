DROP TABLE IF EXISTS ClientsEvents_TrackWorkers;
DROP TABLE IF EXISTS ClientEvents;
DROP TABLE IF EXISTS TrackWorkers;
DROP TABLE IF EXISTS Tracks;
DROP TABLE IF EXISTS Clients;

CREATE TABLE IF NOT EXISTS Clients (
	 id INTEGER PRIMARY KEY,
	 name TEXT NOT NULL,
	 primaryContactName TEXT NOT NULL,
	 primaryContactCell TEXT NOT NULL,
	 primaryContactEmail TEXT NOT NULL,
	 isDeleted NUMERIC DEFAULT 0);

CREATE TABLE IF NOT EXISTS Tracks (
	 id INTEGER PRIMARY KEY,
	 name TEXT NOT NULL,
	 /*configuration TEXT NOT NULL,*/
	 isDeleted NUMERIC DEFAULT 0);

CREATE TABLE IF NOT EXISTS TrackWorkers (
	 id INTEGER PRIMARY KEY,
	 firstName TEXT NOT NULL,
	 lastName TEXT NOT NULL,
	 cell TEXT NOT NULL,
	 email TEXT NOT NULL,
	 isCapableCaptain NUMERIC NOT NULL,
	 isDeleted NUMERIC DEFAULT 0);
	 
CREATE TABLE IF NOT EXISTS ClientEvents (
	 id INTEGER PRIMARY KEY,
	 clientId INTEGER,
	 trackId INTEGER,
	 date TEXT NOT NULL,
	 workersRequested INTEGER NOT NULL,
	 isLunchProvided NUMERIC NOT NULL,
	 isUsingUpperPaddock NUMERIC NOT NULL,
	 isUsingMiddlePaddock NUMERIC NOT NULL,
	 isUsingLowerPaddock NUMERIC NOT NULL,
	 workerCalloutSent NUMERIC NOT NULL,
	 requireSafetyDemo NUMERIC NOT NULL,
	 isDeleted NUMERIC DEFAULT 0,
	 FOREIGN KEY(clientId) REFERENCES Clients(id)
	 FOREIGN KEY(trackId) REFERENCES Tracks(id));

CREATE TABLE IF NOT EXISTS ClientsEvents_TrackWorkers (
clientsEventsId INTEGER REFERENCES ClientEvents(id),
trackWorkersId INTEGER REFERENCES TrackWorkers(id),
isAssigned NUMERIC NOT NULL,
PRIMARY KEY(ClientsEventsId, TrackWorkersId));
