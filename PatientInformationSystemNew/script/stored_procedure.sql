USE `pis_db`;
DROP procedure IF EXISTS `add_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_patient`(pDoctorFID INT(10), pPatientID VARBINARY(800), pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800), pGender VARBINARY(800),
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_vital_signs_in_add_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_vital_signs_in_add_patient`(pPatientFID INT(10), pHeight VARBINARY(800), pWeight VARBINARY(800), pTemperature VARBINARY(800), pPulseRate VARBINARY(800),
pBloodPressure VARBINARY(800))
BEGIN
	INSERT INTO pis_db.vital_signs(patient_fid, height, weight, temperature, pulse_rate, blood_pressure, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pHeight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pWeight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pTemperature, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pPulseRate, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pBloodPressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `back_patient_to_schedule_from_consultation`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `back_patient_to_schedule_from_consultation`(pPatientID VARBINARY(800), pPatientFID INT(10))
BEGIN
	DELETE FROM pis_db.prescriptions
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    UPDATE pis_db.schedule 
    SET status = AES_ENCRYPT('Waiting', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `delete_duplicate_patient_vital_signs_symptoms`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `delete_duplicate_patient_vital_signs_symptoms`(pPatientID VARBINARY(800), pPatientFID INT(10))
BEGIN
	DELETE FROM pis_db.vital_signs
    WHERE patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.symptoms
    WHERE patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.duplicate_patients
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `delete_patient_vital_signs_symptoms`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `delete_patient_vital_signs_symptoms`(pPatientID VARBINARY(800), pPatientFID INT(10))
BEGIN
	DELETE FROM pis_db.vital_signs
    WHERE patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.symptoms
    WHERE patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.patients
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `done_consulting`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `done_consulting`(pPatientID VARBINARY(800), pPatientFID INT(10), pFullName VARBINARY(800))
BEGIN
	INSERT INTO pis_db.number_of_patients(full_name)
    VALUES(
    AES_ENCRYPT(pFullName, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.vital_signs
    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    UPDATE pis_db.symptoms
	SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

	UPDATE pis_db.prescriptions
    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

	UPDATE pis_db.patients
    SET status = AES_ENCRYPT('Complete', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND 
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.schedule
    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND 
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_doctor_primary_id_for_add_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_doctor_primary_id_for_add_patient`(pDoctor VARBINARY(800))
BEGIN
	SELECT id
    FROM pis_db.users
    WHERE
    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', 
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') = pDoctor;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_in_schedule`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_in_schedule`(pPatientID VARBINARY(800))
BEGIN
	SELECT
	pis_db.patients.id,
    doctor_fid,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.patients
    INNER JOIN pis_db.vital_signs ON pis_db.patients.id = pis_db.vital_signs.id
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation' AND
    CAST(AES_DECRYPT(pis_db.vital_signs.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_id_in_schedule`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_id_in_schedule`(pID INT(10))
BEGIN
	SELECT CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.schedule
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_in_schedule`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_in_schedule`(pPatientID VARBINARY(800))
BEGIN
	SELECT
	pis_db.patients.id,
    doctor_fid,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.patients
    INNER JOIN pis_db.vital_signs ON pis_db.patients.id = pis_db.vital_signs.id
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation' AND
    CAST(AES_DECRYPT(pis_db.vital_signs.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_and_delete_patient_in_schedule`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_primary_id_and_delete_patient_in_schedule`(pPatientID VARBINARY(800))
BEGIN
	SELECT *
    FROM pis_db.patients
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    DELETE FROM pis_db.schedule
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_complete_and_delete_patient_in_schedule`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_primary_id_complete_and_delete_patient_in_schedule`(pPatientID VARBINARY(800))
BEGIN
	SELECT *
    FROM pis_db.patients
    WHERE
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';

    DELETE FROM pis_db.schedule
    WHERE
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_in_add_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_primary_id_in_add_patient`()
BEGIN
	SELECT id
    FROM pis_db.patients ORDER BY id DESC LIMIT 1;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_user`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_user`(pID INT(10))
BEGIN
	SELECT 
    id,
    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    profile_picture,
    CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_doctor_patients`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_doctor_patients`(pDoctorFID INT(10))
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_doctor_patients_in_schedule`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_doctor_patients_in_schedule`(pDoctorFID INT(10))
BEGIN
	SELECT
    id,
    doctor_fid,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    DATE_FORMAT(birthday, '%d %b %Y'),
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.schedule
	WHERE 
    doctor_fid = pDoctorFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting' OR
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`load_patient_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_patient_in_schedule`()
BEGIN
	SELECT
	id,
	doctor_fid,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    DATE_FORMAT(birthday, '%d %b %Y'),
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.schedule
    WHERE
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting' OR
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_patients`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_patients`()
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
    ORDER BY CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_symptoms_in_consultation`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_symptoms_in_consultation`(pPatientFID INT(10))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(symptoms, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.symptoms
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `remove_symptom_in_consultation`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `remove_symptom_in_consultation`(pID INT(10))
BEGIN
	DELETE FROM pis_db.symptoms
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `save_diagnosis_in_consultation`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `save_diagnosis_in_consultation`(pPatientFID INT(10), pDiagnosis VARBINARY(800))
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `save_prescription`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `save_prescription`(pPatientFID INT(10), pPrescriptions VARBINARY(800))
BEGIN
	INSERT INTO pis_db.prescriptions(patient_fid, prescriptions, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pPrescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang'));
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `save_symptoms_in_add_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `save_symptoms_in_add_patient`(pPatientFID INT(10), pSymptoms VARBINARY(800))
BEGIN
	INSERT INTO pis_db.symptoms(patient_fid, symptoms, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `sign_up`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `sign_up`(pUserID VARBINARY(800), pProfilePicture BLOB, pUsername VARBINARY(800), pPassword VARBINARY(800), pFirstName VARBINARY(800),
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_patient`(pID INT(10), pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800), pGender VARBINARY(800), pAge VARBINARY(800),
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_patient_in_schedule_to_consulting`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_patient_in_schedule_to_consulting`(pID INT(10))
BEGIN
	UPDATE pis_db.schedule
    SET status = AES_ENCRYPT('Consulting', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_symptom_in_consultation`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_symptom_in_consultation`(pID INT(10), pSymptoms VARBINARY(800))
BEGIN
	UPDATE pis_db.symptoms 
    SET 
    symptoms = AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_user`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_user`(pID INT(10), pProfilePicture BLOB, pUsername VARBINARY(800), pPassword VARBINARY(800), pFirstName VARBINARY(800), pMiddleName VARBINARY(800),
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `user_authentication`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `user_authentication`(pUsername VARBINARY(800), pPassword VARBINARY(800))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    profile_picture,
    CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pUsername AND 
    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPassword;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `user_authentication_for_admin_only`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `user_authentication_for_admin_only`(pUsername VARBINARY(800), pPassword VARBINARY(800))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    profile_picture,
    CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pUsername AND 
    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPassword;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_patient_duplicate`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_patient_duplicate` (pDoctorFID INT(10), pPatientID VARBINARY(800), pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800), pGender VARBINARY(800),
pAge VARBINARY(800), pAddress VARBINARY(800), pBirthday DATE, pCellphoneNumber VARBINARY(800), pTelephoneNumber VARBINARY(800), pEmail VARBINARY(800))
BEGIN
	INSERT INTO pis_db.duplicate_patients(patient_id, first_name, middle_name, last_name, gender, age, address, birthday, cellphone_number, telephone_number, email)
    VALUES(
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_complete_for_add_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_primary_id_complete_for_add_patient` (pDoctorFID INT(10), pPatientID VARBINARY(800))
BEGIN
	SELECT
    id
    FROM pis_db.patients
    WHERE
    doctor_fid = pDoctorFID AND
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `done_consulting_with_first_account_existing`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `done_consulting_with_first_account_existing` (pPatientID VARBINARY(800), pPatientFID INT(10), pFullName VARBINARY(800))
BEGIN
	INSERT INTO pis_db.number_of_patients(full_name)
    VALUES(
    AES_ENCRYPT(pFullName, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.vital_signs
    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

    UPDATE pis_db.symptoms
    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    patient_fid = pPatientFID AND
	CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

	UPDATE pis_db.prescriptions
    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
	WHERE
	patient_fid = pPatientFID AND
	CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

	DELETE FROM pis_db.schedule
	WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND 
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_existing_first_account_delete_duplicate`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_existing_first_account_delete_duplicate` (pPatientID VARBINARY(800), pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800),
pGender VARBINARY(800), pAge VARBINARY(800), pAddress VARBINARY(800), pBirthday VARBINARY(800), pCellphoneNumber VARBINARY(800), pTelephoneNumber VARBINARY(800),
pEmail VARBINARY(800))
BEGIN
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
    email = AES_ENCRYPT(pEmail, 'j0v3ncut3gw4p0per0jok3l4ang'),
    payment_status = AES_ENCRYPT('Unpaid', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
	CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';

    DELETE FROM pis_db.duplicate_patients
	WHERE
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
	CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_from_patients`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_primary_id_from_patients` (pPatientID VARBINARY(800))
BEGIN
	SELECT id
    FROM pis_db.patients
    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_first_account_existing_for_consulting`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_first_account_existing_for_consulting` (pPatientID VARBINARY(800))
BEGIN
	SELECT
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.duplicate_patients
    WHERE
	CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_vital_signs_with_first_account_existing`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_vital_signs_with_first_account_existing` (pPatientFID INT(10))
BEGIN
	SELECT
    CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.vital_signs
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient`(pID INT(10))
BEGIN
	SELECT 
    id,
    doctor_fid,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	birthday,
	CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.patients
	WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_doctor`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_patient_doctor` (pID INT(10))
BEGIN
	SELECT
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
	WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_patient_unpaid`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_patient_unpaid` ()
BEGIN
	SELECT
    pis_db.patients.id,
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
    CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(pis_db.users.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(pis_db.users.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(', CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') AS 'Doctor'
    FROM pis_db.patients
    INNER JOIN pis_db.users ON pis_db.patients.doctor_fid = pis_db.users.id
	WHERE
    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete' AND
    CAST(AES_DECRYPT(payment_status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Unpaid';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_payment_history`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_payment_history`(pPatientFID INT(10))
BEGIN
	SELECT
    pis_db.payment_transactions.id,
    CAST(AES_DECRYPT(receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(discount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(amount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(`change`, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(cashier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	DATE_FORMAT(pis_db.payment_transactions.date, '%Y/%m/%d')
    FROM pis_db.payment_transactions
    INNER JOIN pis_db.cashier ON pis_db.payment_transactions.id = pis_db.cashier.id
    WHERE patient_fid = pPatientFID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `save_payment`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `save_payment` (pPatientFID INT(10), pReceiptNo VARBINARY(800), pTotalMedicalFee VARBINARY(800), pDiscount VARBINARY(800),
pAmount VARBINARY(800), pTotalAmountPaid VARBINARY(800), pChange VARBINARY(800))
BEGIN
	INSERT INTO pis_db.payment_transactions(patient_fid, receipt_no, total_medical_fee, discount, amount,
    total_amount_paid, `change`)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pReceiptNo, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pTotalMedicalFee, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDiscount, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pAmount, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pTotalAmountPaid, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pChange, 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_payment_transaction_primary_id`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_payment_transaction_primary_id` ()
BEGIN
	SELECT *
    FROM pis_db.payment_transactions
    ORDER BY id DESC LIMIT 1;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `save_cashier_and_update_payment_status`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `save_cashier_and_update_payment_status` (pID INT(10), pTransactionFID INT(10), pCashier VARBINARY(800))
BEGIN
	INSERT INTO pis_db.cashier(transaction_fid, cashier)
    VALUES(
    pTransactionFID,
    AES_ENCRYPT(pCashier, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.patients
    SET payment_status = AES_ENCRYPT('Paid', 'j0v3ncut3gw4p0per0jok3l4ang') 
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_payment_transaction`;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_payment_transaction`(pID INT(10), pReceiptNo VARBINARY(800), pTotalMedicalFee VARBINARY(800), pDiscount VARBINARY(800),
pAmount VARBINARY(800), pTotalAmountPaid VARBINARY(800), pChange VARBINARY(800), pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_payment_transactions(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.payment_transactions
    SET
    receipt_no = AES_ENCRYPT(pReceiptNo, 'j0v3ncut3gw4p0per0jok3l4ang'),
    total_medical_fee = AES_ENCRYPT(pTotalMedicalFee, 'j0v3ncut3gw4p0per0jok3l4ang'),
    discount = AES_ENCRYPT(pDiscount, 'j0v3ncut3gw4p0per0jok3l4ang'),
    amount = AES_ENCRYPT(pAmount, 'j0v3ncut3gw4p0per0jok3l4ang'),
    total_amount_paid = AES_ENCRYPT(pTotalAmountPaid, 'j0v3ncut3gw4p0per0jok3l4ang'),
    `change` = AES_ENCRYPT(pChange, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_diagnosis`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_diagnosis` (pPatientFID INT(10))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
    DATE_FORMAT(date, '%Y/%m/%d')
    FROM pis_db.diagnosis 
    WHERE 
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Visible';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_diagnosis`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_diagnosis` (pPatientFID INT(10), pDiagnosis VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800),
pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_diagnosis(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.diagnosis(patient_fid, diagnosis, date)
    VALUES(
	pPatientFID,
    AES_ENCRYPT(pDiagnosis, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pDate
	);
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_diagnosis`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_diagnosis` (pID INT(10), pDiagnosis VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800), pPatient VARBINARY(800),
pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_diagnosis(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.diagnosis 
    SET 
    diagnosis = AES_ENCRYPT(pDiagnosis, 'j0v3ncut3gw4p0per0jok3l4ang'),
    date = pDate
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `remove_diagnosis`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`remove_diagnosis`;
;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `remove_diagnosis`(pID INT(10), pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_diagnosis(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

	DELETE FROM pis_db.diagnosis
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_symptoms`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_symptoms`(pPatientFID INT(10))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(symptoms, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
    DATE_FORMAT(date, '%Y/%m/%d') 
    FROM pis_db.symptoms 
    WHERE 
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Visible'
    ORDER BY date ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_symptom`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_symptom` (pPatientFID INT(10), pSymptoms VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800), pPatient VARBINARY(800),
pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_symptoms(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.symptoms(patient_fid, symptoms, date)
    VALUES(
	pPatientFID, 
    AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pDate
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_symptom_in_consultation`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_symptom_in_consultation` (pPatientFID INT(10), pSymptoms VARBINARY(800))
BEGIN
	INSERT INTO pis_db.symptoms(patient_fid, symptoms, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_symptom`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`update_symptom`;
;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_symptom`(pID INT(10), pSymptoms VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_symptoms(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.symptoms 
    SET 
    symptoms = AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
    date = pDate
    WHERE id = pID;
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `remove_symptom`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `remove_symptom` (pID INT(10), pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_symptoms(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

	DELETE FROM pis_db.symptoms
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_prescriptions`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_prescriptions` (pPatientFID INT(10))
BEGIN
	SELECT
    id,
	CAST(AES_DECRYPT(prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    DATE_FORMAT(date, '%Y/%m/%d')
    FROM pis_db.prescriptions
    WHERE
    patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Visible'
    ORDER BY date ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_prescription`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_prescription`(pPatientFID INT(10), pPrescriptions VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800), pPatient VARBINARY(800),
pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_prescriptions(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.prescriptions(patient_fid, prescriptions, date)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pPrescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pDate
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_prescription`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_prescription` (pID INT(10), pPrescriptions VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800), pPatient VARBINARY(800),
pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_prescriptions(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.prescriptions
    SET prescriptions = AES_ENCRYPT(pPrescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
    date = pDate
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `remove_prescription`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `remove_prescription` (pID INT(10), pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_prescriptions(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
	AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

	DELETE FROM pis_db.prescriptions
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_vital_signs`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_vital_signs` (pPatientFID INT(10))
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    DATE_FORMAT(date, '%Y/%m/%d')
	FROM pis_db.vital_signs
	WHERE patient_fid = pPatientFID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Visible'
    ORDER BY date ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_vital_signs`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_vital_signs` (pPatientFID INT(10), pHeight VARBINARY(800), pWeight VARBINARY(800), pTemperature VARBINARY(800),
pPulseRate VARBINARY(800), pBloodPressure VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_vital_signs(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.vital_signs(patient_fid, height, weight, temperature, pulse_rate, blood_pressure, date)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pHeight, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pWeight, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pTemperature, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPulseRate, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pBloodPressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pDate
	);
END$$

DELIMITER ;


USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`update_vital_signs`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_vital_signs`(pID INT(10), pHeight VARBINARY(800), pWeight VARBINARY(800), pTemperature VARBINARY(800), pPulseRate VARBINARY(800),
pBloodPressure VARBINARY(800), pDate TIMESTAMP, pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_vital_signs(user, patient, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.vital_signs
    SET
    height = AES_ENCRYPT(pHeight, 'j0v3ncut3gw4p0per0jok3l4ang'),
    weight = AES_ENCRYPT(pWeight, 'j0v3ncut3gw4p0per0jok3l4ang'),
    temperature = AES_ENCRYPT(pTemperature, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pulse_rate = AES_ENCRYPT(pPulseRate, 'j0v3ncut3gw4p0per0jok3l4ang'),
    blood_pressure = AES_ENCRYPT(pBloodPressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
	date = pDate
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `remove_vital_signs`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `remove_vital_signs` (pID INT(10), pUser VARBINARY(800), pPatient VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_vital_signs(user, patient, description)
	VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pPatient, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    DELETE FROM pis_db.vital_signs
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_doctors`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_doctors` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE
    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Doctor';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_doctor_primary_id`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_doctor_primary_id` (pDoctor VARBINARY(800))
BEGIN
	SELECT id
    FROM pis_db.users
    WHERE
    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', 
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') = pDoctor;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_doctor`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_doctor` (pID INT(10), pUserID VARBINARY(800), pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800), 
pGender VARBINARY(800), pAge VARBINARY(800), pAddress VARBINARY(800), pBirthday DATE, pCellphoneNumber VARBINARY(800), pTelephoneNumber VARBINARY(800), 
pEmail VARBINARY(800), pSpecialization VARBINARY(800))
BEGIN
	UPDATE pis_db.users
    SET
	user_id = AES_ENCRYPT(pUserUD, 'j0v3ncut3gw4p0per0jok3l4ang'),
    first_name = AES_ENCRYPT(pFirstName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    middle_name = AES_ENCRYPT(pMiddleName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    last_name = AES_ENCRYPT(pLastName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    gender = AES_ENCRYPT(pGender, 'j0v3ncut3gw4p0per0jok3l4ang'),
    age = AES_ENCRYPT(pAge, 'j0v3ncut3gw4p0per0jok3l4ang'),
    address = AES_ENCRYPT(pAddress, 'j0v3ncut3gw4p0per0jok3l4ang'),
    birthday = pBirthday,
    cellphone_number = AES_ENCRYPT(pCellphoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'),
    telephone_number = AES_ENCRYPT(pTelephoneNumber, 'j0v3ncut3gw4p0per0jok3l4ang'),
    email = AES_ENCRYPT(pEmail, 'j0v3ncut3gw4p0per0jok3l4ang'),
    specialization = AES_ENCRYPT(pSpecialization, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_user_id`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_user_id` (pUserID VARBINARY(800))
BEGIN
	SELECT *
    FROM pis_db.users
    WHERE CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pUserID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_username`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_username` (pUsername VARBINARY(800))
BEGIN
	SELECT * 
    FROM pis_db.users 
    WHERE CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pUsername;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_patient_id`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_patient_id` (pPatientID VARBINARY(800))
BEGIN
	SELECT *
    FROM pis_db.patients
    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_patient_complete`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_patient_complete` (pDoctorFID INT(10), pFirstName VARBINARY(800), pMiddleName VARBINARY(800),
pLastName VARBINARY(800))
BEGIN
	SELECT
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
	FROM pis_db.patients
    WHERE
    doctor_fid = pDoctorFID AND
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pFirstName AND
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pMiddleName AND
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pLastName AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_patient_complete_doctor`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_patient_complete_doctor` (pID INT(10))
BEGIN
	SELECT
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
	WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_patient_in_general`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_patient_in_general` (pPatientID VARBINARY(800))
BEGIN
	SELECT *
    FROM pis_db.patients
    WHERE
    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pPatientID AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_supply_name_without_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_supply_name_without_expiration` (pSupplier VARBINARY(800), pSupplyName VARBINARY(800))
BEGIN
	SELECT
    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
	FROM pis_db.inventory
    WHERE
    CAST(AES_DECRYPT(supplier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pSupplier AND
    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pSupplyName;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `duplicate_update_history_id`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `duplicate_update_history_id` (pUpdateID VARBINARY(800))
BEGIN
	SELECT *
    FROM pis_db.update_history
    WHERE CAST(AES_DECRYPT(update_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pUpdateID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_inventory`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_inventory` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(supply_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(supplier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    DATE_FORMAT(expiration_date, '%Y/%m/%d'),
    CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left')
    FROM pis_db.inventory
    ORDER BY CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_incoming_inventory`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_incoming_inventory` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(supply_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(supplier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    DATE_FORMAT(expiration_date, '%Y/%m/%d'),
    CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left'),
    DATE_FORMAT(arrive_date, '%Y/%m/%d'),
    CONCAT(DATEDIFF(arrive_date, NOW()), ' Days Left')
    FROM pis_db.inventory_incoming
    ORDER BY CONCAT(DATEDIFF(arrive_date, NOW()), ' Days Left') ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `supply_arrived_with_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `supply_arrived_with_expiration` (pID INT(10), pSupplier VARBINARY(800), pSupplyID VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pExpirationDate DATETIME)
BEGIN
	INSERT INTO pis_db.inventory(supplier, supply_id, supply_name, quantity, expiration_date)
    VALUES(
    AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
	AES_ENCRYPT(pSupplyID, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'), 
	AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    pExpirationDate);

    DELETE FROM pis_db.inventory_incoming
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `supply_arrived_without_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `supply_arrived_without_expiration` (pID INT(10), pSupplier VARBINARY(800), pSupplyID VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800))
BEGIN
	INSERT INTO pis_db.inventory(supplier, supply_id, supply_name, quantity)
    VALUES(
    AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyID, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'), 
    AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'));

    DELETE FROM pis_db.inventory_incoming
	WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_incoming_supplies_with_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_incoming_supplies_with_expiration` (pSupplier VARBINARY(800), pSupplyID VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pExpirationDate DATETIME, pArriveDate DATETIME, pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
	AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.inventory_incoming(supplier, supply_id, supply_name, quantity, expiration_date, arrive_date)
    VALUES(
    AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyID, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
	pExpirationDate,
    pArriveDate
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_incoming_supplies_without_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_incoming_supplies_without_expiration` (pSupplier VARBINARY(800), pSupplyID VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pArriveDate DATETIME, pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
	AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.inventory_incoming(supplier, supply_id, supply_name, quantity, arrive_date)
    VALUES(
    AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyID, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pArriveDate
    );
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_doctor_id`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_doctor_id`(pDoctorFID INT(10))
BEGIN
	SELECT CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE id = pDoctorFID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_supply_with_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_supply_with_expiration` (pSupplier VARBINARY(800), pSupplyID VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pExpirationDate DATETIME, pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
	AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    INSERT INTO pis_db.inventory(supplier, supply_id, supply_name, quantity, expiration_date)
    VALUES(
    AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyID, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
    pExpirationDate);
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_supply_without_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `add_supply_without_expiration` (pSupplier VARBINARY(800), pSupplyID VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
	);

	INSERT INTO pis_db.inventory(supplier, supply_id, supply_name, quantity)
    VALUES(
    AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyID, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'));
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_incoming_supply_with_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_incoming_supply_with_expiration` (pID INT(10), pSupplier VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pExpirationDate DATETIME, pArriveDate DATETIME, pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.inventory_incoming
    SET
    supplier = AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    supply_name = AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    quantity = AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
    expiration_date = pExpirationDate,
    arrive_date = pArriveDate
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_incoming_supply_without_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_incoming_supply_without_expiration` (pID INT(10), pSupplier VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pArriveDate DATETIME, pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.inventory_incoming
    SET
    supplier = AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    supply_name = AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    quantity = AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
    arrive_date = pArriveDate
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `save_manage_supplies_with_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `save_manage_supplies_with_expiration` (pID INT(10), pSupplier VARBINARY(800), pSupplyName VARBINARY(800), pQuantity VARBINARY(800),
pExpirationDate DATETIME, pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.inventory
    SET
    supplier = AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    supply_name = AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    quantity = AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
    expiration_date = pExpirationDate
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `save_manage_supplies_without_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `save_manage_supplies_without_expiration` (pID INT(10), pSupplier VARBINARY(800), pSupplyName VARBINARY(800), pQuantity VARBINARY(800),
pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
	AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.inventory
    SET
    supplier = AES_ENCRYPT(pSupplier, 'j0v3ncut3gw4p0per0jok3l4ang'),
    supply_name = AES_ENCRYPT(pSupplyName, 'j0v3ncut3gw4p0per0jok3l4ang'),
    quantity = AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_quantity_of_supply_from_incoming_supply`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_quantity_of_supply_from_incoming_supply` (pID INT(10), pSupplier VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.inventory
    SET quantity = AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    CAST(AES_DECRYPT(supplier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pSupplier AND
    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pSupplyName;

    DELETE FROM pis_db.inventory_incoming
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_quantity_of_existing_supply_without_expiration`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_quantity_of_existing_supply_without_expiration` (pSupplier VARBINARY(800), pSupplyName VARBINARY(800),
pQuantity VARBINARY(800), pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );  

    UPDATE pis_db.inventory
    SET quantity = AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE
    CAST(AES_DECRYPT(supplier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pSupplier AND
    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = pSupplyName;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `item_used`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `item_used` (pID INT(10), pQuantity VARBINARY(800), pUser VARBINARY(800), pIssuedTo VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, issued_to, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pIssuedTo, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

    UPDATE pis_db.inventory
    SET quantity = AES_ENCRYPT(pQuantity, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `delete_incoming_supply`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `delete_incoming_supply` (pID INT(10), pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
    );

	DELETE FROM pis_db.inventory_incoming
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `delete_supply`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `delete_supply` (pID INT(10), pUser VARBINARY(800), pDescription VARBINARY(800))
BEGIN
	INSERT INTO pis_db.update_history_inventory(user, description)
    VALUES(
    AES_ENCRYPT(pUser, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT(pDescription, 'j0v3ncut3gw4p0per0jok3l4ang')
	);
   
    DELETE FROM pis_db.inventory
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `search_patient`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `search_patient` (pKeyword VARCHAR(800))
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
    WHERE
    CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) LIKE pKeyword AND
    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete' OR
    CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) LIKE pKeyword AND
    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete' OR
    CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) LIKE pKeyword AND
    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete' OR
    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(pis_db.users.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(pis_db.users.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(', CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') LIKE pKeyword AND
    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete'
    ORDER BY CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `search_patient_by_doctor`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `search_patient_by_doctor` (pDoctorFID INT(10), pKeyword VARBINARY(800))
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
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) LIKE pKeyword AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete' OR
    doctor_fid = pDoctorFID AND
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) LIKE pKeyword AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete' OR
    doctor_fid = pDoctorFID AND
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) LIKE pKeyword AND
    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete'
    ORDER BY CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) ASC;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_total_patients_in_month`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_total_patients_in_month` (pMonth VARCHAR(55), pYear VARCHAR(55))
BEGIN
	SELECT COUNT(*)
    FROM pis_db.number_of_patients
    WHERE
    DATE_FORMAT(date, '%M') = pMonth AND
    DATE_FORMAT(date, '%Y') = pYear;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_total_patients_in_day`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_total_patients_in_day` (pMonth VARCHAR(55), pDay VARCHAR(55), pYear VARCHAR(55))
BEGIN
	SELECT COUNT(*)
    FROM pis_db.number_of_patients
    WHERE
    DATE_FORMAT(date, '%M') = pMonth AND
    DATE_FORMAT(date, '%d') = pDay AND
    DATE_FORMAT(date, '%Y') = pYear;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_total_patients_in_year`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_total_patients_in_year` (pYear VARCHAR(55))
BEGIN
	SELECT COUNT(*)
    FROM pis_db.number_of_patients
    WHERE
    DATE_FORMAT(date, '%Y') = pYear;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_overall_total_patients`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_overall_total_patients` ()
BEGIN
	SELECT COUNT(*)
    FROM pis_db.number_of_patients;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_total_sales_in_month`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_total_sales_in_month` (pMonth VARCHAR(55), pYear VARCHAR(55))
BEGIN
	SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
    FROM pis_db.payment_transactions
    WHERE
    DATE_FORMAT(date, '%M') = pMonth AND
    DATE_FORMAT(date, '%Y') = pYear;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_total_sales_in_day`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_total_sales_in_day` (pMonth VARCHAR(55), pDay VARCHAR(55), pYear VARCHAR(55))
BEGIN
	SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
    FROM pis_db.payment_transactions
	WHERE
    DATE_FORMAT(date, '%M') = pMonth AND
    DATE_FORMAT(date, '%d') = pDay AND
    DATE_FORMAT(date, '%Y') = pYear;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_total_sales_in_year`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_total_sales_in_year` (pYear VARCHAR(55))
BEGIN
	SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
    FROM pis_db.payment_transactions
    WHERE
    DATE_FORMAT(date, '%Y') = pYear;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `count_overall_total_sales`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `count_overall_total_sales` ()
BEGIN
	SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
    FROM pis_db.payment_transactions;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_patient_updates`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_patient_updates` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))
    FROM pis_db.update_history_patient;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_vital_signs_updates`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_vital_signs_updates` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))
    FROM pis_db.update_history_vital_signs;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_diagnosis_updates`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_diagnosis_updates` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))
    FROM pis_db.update_history_diagnosis;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_symptoms_update`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_symptoms_update` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))
    FROM pis_db.update_history_symptoms;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_prescriptions_updates`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_prescriptions_updates` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))
    FROM pis_db.update_history_prescriptions;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_payment_transaction_updates`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_payment_transaction_updates` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))
    FROM pis_db.update_history_payment_transactions;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_inventory_updates`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_inventory_updates` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(issued_to, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
	CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))
    FROM pis_db.update_history_inventory;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_doctor`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_doctor` (pID INT(10))
BEGIN
	SELECT
    id,
    profile_picture,
    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_select_doctors`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_select_doctors` ()
BEGIN
	SELECT CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ')')
    FROM pis_db.users
    WHERE CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Doctor';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `load_medical_staff`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `load_medical_staff` ()
BEGIN
	SELECT
    id,
    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE
    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Medical Staff';
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `get_medical_staff`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `get_medical_staff` (pID INT(10))
BEGIN
	SELECT
	id,
    profile_picture,
    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    birthday,
    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.users
    WHERE id = pID;
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `update_medical_staff`;

DELIMITER $$
USE `pis_db`$$
CREATE PROCEDURE `update_medical_staff` (pID INT(10), pUserID VARBINARY(800),
pFirstName VARBINARY(800), pMiddleName VARBINARY(800), pLastName VARBINARY(800), pGender VARBINARY(800), pAge VARBINARY(800),
pAddress VARBINARY(800), pBirthday DATE, pCellphoneNumber VARBINARY(800), pTelephoneNumber VARBINARY(800), pEmail VARBINARY(800))
BEGIN
	UPDATE pis_db.users
	SET
    user_id = AES_ENCRYPT(pUserID, 'j0v3ncut3gw4p0per0jok3l4ang'),
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
END$$

DELIMITER ;

