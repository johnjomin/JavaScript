CREATE TABLE [dbo].[Device] (
    [DeviceID]  INT          NOT NULL,
    [IPAddress] VARCHAR (30) NULL,
    [Name]      VARCHAR (40) NULL,
    PRIMARY KEY CLUSTERED ([DeviceID] ASC)
);

