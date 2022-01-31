CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_primary_id_in_add_patient`()
BEGIN
	SELECT id
    FROM pis_db.patients ORDER BY id DESC LIMIT 1;
END