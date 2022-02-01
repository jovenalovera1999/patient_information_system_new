CREATE DEFINER=`root`@`localhost` PROCEDURE `save_diagnosis_in_consultation`(pPatientFID INT(10), pDiagnosis VARBINARY(800))
BEGIN
	DELETE FROM pis_db.diagnosis
	WHERE
	patient_fid = pPatientFID AND
	CAST(AES_DECRYPT(diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pDiagnosis AND
	CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

	INSERT INTO pis_db.diagnosis(patient_fid, diagnosis)
	VALUES(
	pPatientFID,
	AES_ENCRYPT(pDiagnosis, 'j0v3ncut3gw4p0per0jok3l4ang')
	);
END