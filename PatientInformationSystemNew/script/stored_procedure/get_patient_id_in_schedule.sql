CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_id_in_schedule`(pID INT(10))
BEGIN
	SELECT CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.schedule
    WHERE id = pID;
END