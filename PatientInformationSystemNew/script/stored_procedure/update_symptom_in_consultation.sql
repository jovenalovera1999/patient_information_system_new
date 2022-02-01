CREATE DEFINER=`root`@`localhost` PROCEDURE `update_symptom_in_consultation`(pID INT(10), pSymptoms VARBINARY(800))
BEGIN
	UPDATE pis_db.symptoms 
    SET 
    symptoms = AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END