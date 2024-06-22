CREATE TABLE [dbo].[DeviceCamera] (
    [CameraNumber] INT          NOT NULL,
    [DeviceID]     INT          NOT NULL,
    [Name]         VARCHAR (40) NULL,
    PRIMARY KEY CLUSTERED ([CameraNumber] ASC),
    FOREIGN KEY ([DeviceID]) REFERENCES [dbo].[Device] ([DeviceID])
);

