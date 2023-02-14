﻿CREATE TABLE NEWDISASTER(

ID INT NOT NULL PRIMARY KEY IDENTITY,
DESCRIPTION VARCHAR(255) NOT NULL,
REQAIDTYPE VARCHAR(255) NOT NULL,
DISASTERLOC VARCHAR(255) NOT NULL,
DISASTERSTARTDATE VARCHAR(255) NOT NULL,
DISASTERENDDATE VARCHAR(255) NOT NULL,
ALLOCATEMONEY VARCHAR(50) NOT NULL,
ALLOCATEGOODS VARCHAR(50) NOT NULL,
CREATED_AT DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP

);

INSERT INTO NEWDISASTER (DESCRIPTION, REQAIDTYPE, DISASTERLOC, DISASTERSTARTDATE, DISASTERENDDATE)
VALUES
('TORNADO', 'MEDICAL', 'JOHANNESBUG', '24 FEB 2022', '26 FEB 2022');