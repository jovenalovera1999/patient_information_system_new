CREATE DEFINER=`root`@`localhost` PROCEDURE `done_consulting`(pPatientID VARBINARY(800), pPatientFID INT(10), pFullName VARBINARY(800))
BEGIN
	INSERT INTO pis_db.number_of_patients(full_name)
    VALUES(
    AES_ENCRYPT(pFullName, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.vital_signs
    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    UPDATE pis_db.symptoms
	SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

	UPDATE pis_db.prescriptions
    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

	UPDATE pis_db.patients
    SET status = AES_ENCRYPT('Complete', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND 
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.schedule
    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND 
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';
END