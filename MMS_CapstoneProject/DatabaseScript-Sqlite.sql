DROP TABLE IF EXISTS ClientsEvents_TrackWorkers;
DROP TABLE IF EXISTS ClientEvents;
DROP TABLE IF EXISTS TrackWorkers;
DROP TABLE IF EXISTS Tracks;
DROP TABLE IF EXISTS Clients;

CREATE TABLE IF NOT EXISTS Clients (
	 ClientID INTEGER PRIMARY KEY,
	 Name TEXT NOT NULL,
	 PrimaryContactName TEXT NOT NULL,
	 PrimaryContactCell TEXT NOT NULL,
	 PrimaryContactEmail TEXT NOT NULL,
	 IsDeleted NUMERIC DEFAULT 0
);

CREATE TABLE IF NOT EXISTS Tracks (
	 TrackID INTEGER PRIMARY KEY,
	 Name TEXT NOT NULL,
	 /*configuration TEXT NOT NULL,*/
	 IsDeleted NUMERIC DEFAULT 0
);

CREATE TABLE IF NOT EXISTS TrackWorkers (
	 TrackWorkerID INTEGER PRIMARY KEY,
	 FirstName TEXT NOT NULL,
	 LastName TEXT NOT NULL,
	 Cell TEXT NOT NULL,
	 Email TEXT NOT NULL,
	 IsCapableCaptain NUMERIC NOT NULL,
	 IsDeleted NUMERIC DEFAULT 0
);
	 
CREATE TABLE IF NOT EXISTS ClientEvents (
	 ClientEventID INTEGER PRIMARY KEY,
	 ClientID INTEGER,
	 TrackID INTEGER,
	 Date TEXT NOT NULL,
	 WorkersRequested INTEGER NOT NULL,
	 IsLunchProvided NUMERIC NOT NULL,
	 IsUsingUpperPaddock NUMERIC NOT NULL,
	 IsUsingMiddlePaddock NUMERIC NOT NULL,
	 IsUsingLowerPaddock NUMERIC NOT NULL,
	 WorkerCalloutSent NUMERIC NOT NULL,
	 RequireSafetyDemo NUMERIC NOT NULL,
	 IsDeleted NUMERIC DEFAULT 0,
	 FOREIGN KEY(ClientId) REFERENCES Clients(ClientID)
	 FOREIGN KEY(TrackID) REFERENCES Tracks(TrackID)
);

CREATE TABLE IF NOT EXISTS ClientsEvents_TrackWorkers (
	ClientsEventID INTEGER REFERENCES ClientEvents(ClientEventID),
	TrackWorkerID INTEGER REFERENCES TrackWorkers(TrackWorkerID),
	IsApplied NUMERIC NOT NULL,
	IsSelected NUMERIC NOT NULL,
	IsPresent NUMERIC NOT NULL,
	PRIMARY KEY(ClientsEventID, TrackWorkerID)
);
