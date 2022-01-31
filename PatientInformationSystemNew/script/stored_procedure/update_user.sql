CREATE DEFINER=`root`@`localhost` PROCEDURE `update_user`(pID INT(10), pProfilePicture BLOB, pUsername VARBINARY(800), pPassword VARBINARY(800), pFirstName VARBINARY(800), pMiddleName VARBINARY(800),
pLastName VARBINARY(800), pGender VARBINARY(800), pAge VARBINARY(800), pAddress VARBINARY(800), pBirthday DATE, pCellphoneNumber VARBINARY(800), pTelephoneNumber VARBINARY(800),
pEmail VARBINARY(800))
BEGIN
	UPDATE pis_db.users
        SET 
        profile_picture = pProfilePicture,
        username = AES_ENCRYPT(pUsername, 'j0v3ncut3gw4p0per0jok3l4ang'),
        password = AES_ENCRYPT(pPassword, 'j0v3ncut3gw4p0per0jok3l4ang'),
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