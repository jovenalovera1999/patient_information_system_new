CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_primary_id_complete_and_delete_patient_in_schedule`(pPatientID VARBINARY(800))
BEGIN
	SELECT *
    FROM pis_db.patients
    WHERE
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';

    DELETE FROM pis_db.schedule
    WHERE
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting';
END