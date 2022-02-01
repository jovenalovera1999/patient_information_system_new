CREATE DEFINER=`root`@`localhost` PROCEDURE `update_patient`(pID INT(10), pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800), pGender VARBINARY(800), pAge VARBINARY(800),
pAddress VARBINARY(800), pBirthday DATE, pCellphoneNumber VARBINARY(800), pTelephoneNumber VARBINARY(800), pEmail VARBINARY(800), pUser VARBINARY(800), pPatient VARBINARY(800),
pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_patient(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.patients
    SET
	first_name = AES_ENCRYPT(pFirstName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    middle_name = AES_ENCRYPT(pMiddleName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    last_name = AES_ENCRYPT(pLastName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    gender = AES_ENCRYPT(pGender, 'j0v3ncut3gw4p0per0jok3l4ang'),
    age = AES_ENCRYPT(pAge, 'j0v3ncut3gw4p0per0jok3l4ang'),
    address = AES_ENCRYPT(pAddress, 'j0v3ncut3gw4p0per0jok3l4ang'),
	birthday = pBirthday,
    cellphone_number = AES_ENCRYPT(pCellphoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'),
    telephone_number = AES_ENCRYPT(pTelephoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'),
	email = AES_ENCRYPT(pEmail, 'j0v3ncut3gw4p0per0jok3l4ang')
	WHERE id = pID;
END