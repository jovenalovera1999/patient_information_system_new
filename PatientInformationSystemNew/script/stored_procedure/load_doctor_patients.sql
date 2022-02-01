CREATE DEFINER=`root`@`localhost` PROCEDURE `load_doctor_patients`(pDoctorFID INT(10))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    DATE_FORMAT(date, '%Y/%m/%d')
    FROM pis_db.patients
    WHERE
    doctor_fid = pDoctorFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete'
    ORDER BY first_name ASC;
END