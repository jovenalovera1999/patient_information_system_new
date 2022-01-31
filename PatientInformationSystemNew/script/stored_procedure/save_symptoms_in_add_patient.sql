CREATE DEFINER=`root`@`localhost` PROCEDURE `save_symptoms_in_add_patient`(pPatientFID INT(10), pSymptoms VARBINARY(800))
BEGIN
	INSERT INTO pis_db.symptoms(patient_fid, symptoms, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END