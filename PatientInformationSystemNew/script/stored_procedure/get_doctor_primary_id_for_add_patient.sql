CREATE DEFINER=`root`@`localhost` PROCEDURE `get_doctor_primary_id_for_add_patient`(pDoctor VARBINARY(800))
BEGIN
	SELECT id
    FROM pis_db.users
    WHERE
    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', 
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') = pDoctor;
END