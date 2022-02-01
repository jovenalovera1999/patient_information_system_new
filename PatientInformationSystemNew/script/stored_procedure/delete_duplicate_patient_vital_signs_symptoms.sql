CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_duplicate_patient_vital_signs_symptoms`(pPatientID VARBINARY(800), pPatientFID INT(10))
BEGIN
	DELETE FROM pis_db.vital_signs
    WHERE patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.symptoms
    WHERE patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.duplicate_patients
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END