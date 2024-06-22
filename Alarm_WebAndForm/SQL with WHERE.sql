-- Retrieval of Device in which if all devices have a camera and exclude any that dont

SELECT *
FROM Device
RIGHT JOIN DeviceCamera
ON DeviceCamera.DeviceID = Device.DeviceID
WHERE DeviceCamera.DeviceID IS NOT NULL