CREATE PROCEDURE `sign_up` (pUserID VARBINARY(800), pProfilePicture BLOB, pUsername VARBINARY(800), pPassword VARBINARY(800), pFirstName VARBINARY(800),
pMiddleName VARBINARY(800), pLastName VARBINARY(800), pGender VARBINARY(800), pAge VARBINARY(800), pAddress VARBINARY(800), pBirthday DATE, pCellphoneNumber VARBINARY(800),
pTelephoneNumber VARBINARY(800), pEmail VARBINARY(800), pRole VARBINARY(800), pSpecialization VARBINARY(800))
BEGIN
	INSERT INTO pis_db.users(user_id, profile_picture, username, password, first_name, middle_name, 
    last_name, gender, age, address, birthday, cellphone_number, telephone_number, email, role, specialization)
    VALUES(
    AES_ENCRYPT(pUserID, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pProfilePicture,
    AES_ENCRYPT(pUsername, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPassword, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pFirstName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pMiddleName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pLastName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pGender, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pAge, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pAddress, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pBirthday,
    AES_ENCRYPT(pCellphoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pTelephoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pEmail, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pRole, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSpecialization, 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END
