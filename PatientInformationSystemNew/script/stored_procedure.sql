USE `pis_db`;
DROP procedure IF EXISTS `add_patient`;

DELIMITER $$
USE `pis_db`$$
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
END$$

DELIMITER ;

USE `pis_db`;
DROP procedure IF EXISTS `add_vital_signs_in_add_patient`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`add_vital_signs_in_add_patient`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_vital_signs_in_add_patient`(pPatientFID INT(10), pHeight VARBINARY(800), pWeight VARBINARY(800), pTemperature VARBINARY(800), pPulseRate VARBINARY(800),
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
;

USE `pis_db`;
DROP procedure IF EXISTS `back_patient_to_schedule_from_consultation`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`back_patient_to_schedule_from_consultation`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `back_patient_to_schedule_from_consultation`(pPatientID VARBINARY(800), pPatientFID INT(10))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `delete_duplicate_patient_vital_signs_symptoms`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`delete_duplicate_patient_vital_signs_symptoms`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_duplicate_patient_vital_signs_symptoms`(pPatientID VARBINARY(800), pPatientFID INT(10))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `delete_patient_vital_signs_symptoms`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`delete_patient_vital_signs_symptoms`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `delete_patient_vital_signs_symptoms`(pPatientID VARBINARY(800), pPatientFID INT(10))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `done_consulting`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`done_consulting`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `done_consulting`(pPatientID VARBINARY(800), pPatientFID INT(10), pFullName VARBINARY(800))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `get_doctor_primary_id_for_add_patient`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_doctor_primary_id_for_add_patient`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_doctor_primary_id_for_add_patient`(pDoctor VARBINARY(800))
BEGIN
	SELECT id
    FROM pis_db.users
    WHERE
    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', 
    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',
    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') = pDoctor;
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_from_in_schedule`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_patient_from_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_from_in_schedule`(pPatientID VARBINARY(800))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_id_in_schedule`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_patient_id_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_id_in_schedule`(pID INT(10))
BEGIN
	SELECT CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
    FROM pis_db.schedule
    WHERE id = pID;
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_in_schedule`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_patient_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_in_schedule`(pPatientID VARBINARY(800))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_and_delete_patient_in_schedule`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_patient_primary_id_and_delete_patient_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_primary_id_and_delete_patient_in_schedule`(pPatientID VARBINARY(800))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_complete_and_delete_patient_in_schedule`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_patient_primary_id_complete_and_delete_patient_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_primary_id_complete_and_delete_patient_in_schedule`(pPatientID VARBINARY(800))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `get_patient_primary_id_in_add_patient`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_patient_primary_id_in_add_patient`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_patient_primary_id_in_add_patient`()
BEGIN
	SELECT id
    FROM pis_db.patients ORDER BY id DESC LIMIT 1;
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `get_user`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`get_user`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_user`(pID INT(10))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `load_doctor_patients`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`load_doctor_patients`;
;

DELIMITER $$
USE `pis_db`$$
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
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `load_doctor_patients_in_schedule`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`load_doctor_patients_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `load_doctor_patients_in_schedule`(pDoctorFID INT(10))
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
;


USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`load_patient_in_schedule`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `load_patient_in_schedule`()
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
;

USE `pis_db`;
DROP procedure IF EXISTS `load_patients`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`load_patients`;
;

DELIMITER $$
USE `pis_db`$$
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
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `load_symptoms_in_consultation`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`load_symptoms_in_consultation`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `load_symptoms_in_consultation`(pPatientFID INT(10))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `remove_symptom_in_consultation`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`remove_symptom_in_consultation`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `remove_symptom_in_consultation`(pID INT(10))
BEGIN
	DELETE FROM pis_db.symptoms
    WHERE id = pID;
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `save_diagnosis_in_consultation`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`save_diagnosis_in_consultation`;
;

DELIMITER $$
USE `pis_db`$$
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
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `save_prescription`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`save_prescription`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `save_prescription`(pPatientFID INT(10), pPrescriptions VARBINARY(800))
BEGIN
	INSERT INTO pis_db.prescriptions(patient_fid, prescriptions, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pPrescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang'));
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `save_symptoms_in_add_patient`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`save_symptoms_in_add_patient`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `save_symptoms_in_add_patient`(pPatientFID INT(10), pSymptoms VARBINARY(800))
BEGIN
	INSERT INTO pis_db.symptoms(patient_fid, symptoms, status)
    VALUES(
    pPatientFID,
    AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
    );
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `sign_up`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`sign_up`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sign_up`(pUserID VARBINARY(800), pProfilePicture BLOB, pUsername VARBINARY(800), pPassword VARBINARY(800), pFirstName VARBINARY(800),
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
;

USE `pis_db`;
DROP procedure IF EXISTS `update_patient`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`update_patient`;
;

DELIMITER $$
USE `pis_db`$$
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
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `update_patient_in_schedule_to_consulting`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`update_patient_in_schedule_to_consulting`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_patient_in_schedule_to_consulting`(pID INT(10))
BEGIN
	UPDATE pis_db.schedule
    SET status = AES_ENCRYPT('Consulting', 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `update_symptom_in_consultation`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`update_symptom_in_consultation`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_symptom_in_consultation`(pID INT(10), pSymptoms VARBINARY(800))
BEGIN
	UPDATE pis_db.symptoms 
    SET 
    symptoms = AES_ENCRYPT(pSymptoms, 'j0v3ncut3gw4p0per0jok3l4ang')
    WHERE id = pID;
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `update_user`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`update_user`;
;

DELIMITER $$
USE `pis_db`$$
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
END$$

DELIMITER ;
;

USE `pis_db`;
DROP procedure IF EXISTS `user_authentication`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`user_authentication`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `user_authentication`(pUsername VARBINARY(800), pPassword VARBINARY(800))
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
;

USE `pis_db`;
DROP procedure IF EXISTS `user_authentication_for_admin_only`;

USE `pis_db`;
DROP procedure IF EXISTS `pis_db`.`user_authentication_for_admin_only`;
;

DELIMITER $$
USE `pis_db`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `user_authentication_for_admin_only`(pUsername VARBINARY(800), pPassword VARBINARY(800))
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
;

