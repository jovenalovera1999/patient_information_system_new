CREATE DEFINER=`root`@`localhost` PROCEDURE `load_symptoms_in_consultation`(pPatientFID INT(10))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(symptoms, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.symptoms
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END