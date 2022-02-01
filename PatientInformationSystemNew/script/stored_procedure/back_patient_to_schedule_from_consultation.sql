CREATE DEFINER=`root`@`localhost` PROCEDURE `back_patient_to_schedule_from_consultation`(pPatientID VARBINARY(800), pPatientFID INT(10))
BEGIN
	DELETE FROM pis_db.prescriptions
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    UPDATE pis_db.schedule 
    SET status = AES_ENCRYPT('Waiting', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';
END