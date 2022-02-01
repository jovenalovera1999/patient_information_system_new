CREATE DEFINER=`root`@`localhost` PROCEDURE `save_prescription`(pPatientFID INT(10), pPrescriptions VARBINARY(800))
BEGIN
	INSERT INTO pis_db.prescriptions(patient_fid, prescriptions, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pPrescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang'));
END