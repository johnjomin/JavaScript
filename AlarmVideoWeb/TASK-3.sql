SELECT *
FROM Device
RIGHT JOIN DeviceCamera
ON DeviceCamera.DeviceID = Device.DeviceID
WHERE DeviceCamera.NAME LIKE 'Front%'