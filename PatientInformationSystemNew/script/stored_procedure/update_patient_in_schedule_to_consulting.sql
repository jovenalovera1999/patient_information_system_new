CREATE DEFINER=`root`@`localhost` PROCEDURE `update_patient_in_schedule_to_consulting`(pID INT(10))
BEGIN
	UPDATE pis_db.schedule
    SET status = AES_ENCRYPT('Consulting', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END