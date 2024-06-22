-- Get Device Details of all Device which have a camera name with "Front"

SELECT *
FROM Device
RIGHT JOIN DeviceCamera
ON DeviceCamera.DeviceID = Device.DeviceID
WHERE DeviceCamera.NAME LIKE 'Front%' AND Device.DeviceID IS NOT NULL