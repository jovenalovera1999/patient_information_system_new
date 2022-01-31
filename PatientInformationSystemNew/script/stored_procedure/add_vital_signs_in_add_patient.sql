CREATE DEFINER=`root`@`localhost` PROCEDURE `add_vital_signs_in_add_patient`(pPatientFID INT(10), pHeight VARBINARY(800), pWeight VARBINARY(800), pTemperature VARBINARY(800), pPulseRate VARBINARY(800),
pBloodPressure VARBINARY(800))
BEGIN
	INSERT INTO pis_db.vital_signs(patient_fid, height, weight, temperature, pulse_rate, blood_pressure, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pHeight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pWeight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pTemperature, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pPulseRate, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pBloodPressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END