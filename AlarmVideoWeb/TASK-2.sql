SELECT *
FROM Device
RIGHT JOIN DeviceCamera
ON DeviceCamera.DeviceID = Device.DeviceID
WHERE DeviceCamera.DeviceID IS NOT NULL