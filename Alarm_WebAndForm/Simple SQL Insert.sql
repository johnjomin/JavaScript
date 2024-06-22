INSERT INTO DeviceCamera
  ( CameraNumber, DeviceID, Name )
VALUES
  (1, 1, 'Front Door'), 
  (2, 1, 'Back Door'), 
  (5, 2, 'Front Door'),
  (6, 2, 'Back Door'), 
  (2000, NULL, 'Front Door'),
  (2001, NULL, 'Back Door'), 
  ('Billy', 1984, 'Front Door'),
  ('Miranda', 1984, 'Back Door');


  INSERT INTO Device
  ( DeviceID, IPAddress, Name )
VALUES
  (001, 10.127.0.1, 'First_Device'), 
  (002, 10.127.0.2, 'Second_Device'), 
  (003, 10.127.0.3, 'Third_Device'),
  (1984, 10.127.1.1, '1984th_Device');