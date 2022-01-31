CREATE DEFINER=`root`@`localhost` PROCEDURE `add_patient`(pDoctorFID INT(10), pPatientID VARBINARY(800), pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800), pGender VARBINARY(800),
pAge VARBINARY(800), pAddress VARBINARY(800), pBirthday DATE, pCellphoneNumber VARBINARY(800), pTelephoneNumber VARBINARY(800), pEmail VARBINARY(800))
BEGIN
	INSERT INTO pis_db.patients(doctor_fid, patient_id, first_name, middle_name, last_name, gender, age, address, birthday,
    cellphone_number, telephone_number, email)
    VALUES(
    pDoctorFID,
    AES_ENCRYPT(pPatientID, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pFirstName, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pMiddleName, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pLastName, 'j0v3ncut3gw4p0per0jok3l4ang'), 
	AES_ENCRYPT(pGender, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pAge, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pAddress, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    pBirthday, 
    AES_ENCRYPT(pCellphoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pTelephoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pEmail, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.schedule(doctor_fid, patient_id, first_name, middle_name, last_name, gender, birthday)
    VALUES(
    pDoctorFID,
    AES_ENCRYPT(pPatientID, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pFirstName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pMiddleName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pLastName, 'j0v3ncut3gw4p0per0jok3l4ang'),
	AES_ENCRYPT(pGender, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pBirthday
    );
END