CREATE DEFINER=`root`@`localhost` PROCEDURE `remove_symptom_in_consultation`(pID INT(10))
BEGIN
	DELETE FROM pis_db.symptoms
    WHERE id = pID;
END