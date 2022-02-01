CREATE DEFINER=`root`@`localhost` PROCEDURE `load_patients`()
BEGIN
	SELECT
    pis_db.patients.id,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
    CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pis_db.patients.gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(pis_db.users.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(pis_db.users.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(', CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') AS 'Doctor',
    DATE_FORMAT(pis_db.patients.date, '%Y/%m/%d')
    FROM pis_db.patients
    INNER JOIN pis_db.users ON pis_db.patients.doctor_fid = pis_db.users.id
    WHERE CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete'
    ORDER BY pis_db.patients.first_name ASC;
END