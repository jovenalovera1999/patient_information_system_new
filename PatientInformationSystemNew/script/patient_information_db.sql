DROP DATABASE IF EXISTS pis_db;

CREATE DATABASE pis_db;

CREATE TABLE pis_db.users (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    user_id                             VARBINARY(800) NOT NULL,
    profile_picture                     BLOB DEFAULT NULL,
    username                            VARBINARY(800) NOT NULL,
    password                            VARBINARY(800) NOT NULL,
    first_name                          VARBINARY(800) NOT NULL,
    middle_name                         VARBINARY(800) DEFAULT NULL,
    last_name                           VARBINARY(800) NOT NULL,
    gender                              VARBINARY(800) NOT NULL,
    age                                 VARBINARY(800) NOT NULL,
    address                             VARBINARY(800) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(800) DEFAULT NULL,
    telephone_number                    VARBINARY(800) DEFAULT NULL,
    email                               VARBINARY(800) DEFAULT NULL,
    role                  				VARBINARY(800) NOT NULL,
    specialization                      VARBINARY(800) DEFAULT NULL,
    date                                DATETIME,
    PRIMARY KEY(id)
);

INSERT INTO pis_db.users(user_id, username, password, first_name, middle_name, last_name, gender, age, address, cellphone_number, 
telephone_number, email, role)
VALUES(
    AES_ENCRYPT('99999999999', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('admin', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('admin', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Joven Joshua', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Celiz', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Alovera', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Male', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('22', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('1696 San Roque St. Roxas City', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('09434071429', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('6210433', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('jovenalovera1999@gmail.com', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Administrator', 'j0v3ncut3gw4p0per0jok3l4ang')
);

INSERT INTO pis_db.users(user_id, username, password, first_name, last_name, gender, age, address, cellphone_number, 
telephone_number, email, role, specialization)
VALUES(
    AES_ENCRYPT('746394', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('doctor', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('doctor', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Jessie', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Bueno', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Male', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('31', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Mabini St. Roxas City', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('09736496845', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('6298463', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('jessiebueno@gmail.com', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Doctor', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Pediatric', 'j0v3ncut3gw4p0per0jok3l4ang')
);

CREATE TABLE pis_db.patients (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(800) NOT NULL,
    first_name                          VARBINARY(800) NOT NULL,
    middle_name                         VARBINARY(800) DEFAULT NULL,
    last_name                           VARBINARY(800) NOT NULL,
    gender                              VARBINARY(800) NOT NULL,
    age                                 VARBINARY(800) NOT NULL,
    address                             VARBINARY(800) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(800) DEFAULT NULL,
    telephone_number                    VARBINARY(800) DEFAULT NULL,
    email                               VARBINARY(800) DEFAULT NULL,
    status                              VARCHAR(800) DEFAULT 'Waiting',
    payment_status                      VARCHAR(800) DEFAULT 'Unpaid',
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.number_of_patients (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(800) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.vital_signs (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(800) NOT NULL,
    height                              VARBINARY(800) DEFAULT NULL,
    weight                              VARBINARY(800) NOT NULL,
    temperature                         VARBINARY(800) NOT NULL,
    pulse_rate                          VARBINARY(800) DEFAULT NULL,
    blood_pressure                      VARBINARY(800) DEFAULT NULL,
    date                                DATE,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.patient_doctor (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(800) NOT NULL,
    doctor                              VARBINARY(800) NOT NULL,
    date                                DATE,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.diagnosis (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(800) NOT NULL,
    diagnosis_id                        VARBINARY(800) NOT NULL,
    diagnosis                           VARBINARY(800) DEFAULT NULL,
    date                                DATE,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.symptoms (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(800) NOT NULL,
    symptoms_id                         VARBINARY(800) NOT NULL,
    symptoms                            VARBINARY(800) DEFAULT NULL,
    date                                DATE,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.prescriptions (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,    
    patient_id                          VARBINARY(800) NOT NULL,
    prescription_id                     VARBINARY(800) NOT NULL,
    prescriptions                       VARBINARY(800) DEFAULT NULL,
    date                                DATE,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.transactions (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(800) NOT NULL,
    receipt_no                          VARBINARY(800) NOT NULL,
    total_medical_fee                   VARBINARY(800) NOT NULL,
    discount                            VARBINARY(800) DEFAULT NULL,
    amount                              VARBINARY(800) NOT NULL,
    total_amount_paid                   VARBINARY(800) NOT NULL,
    `change`                            VARBINARY(800) DEFAULT NULL,
    date                                DATE,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.inventory (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    supply_id                           VARBINARY(800) NOT NULL,
    supply_name                         VARBINARY(800) NOT NULL,
    quantity                            VARBINARY(800) NOT NULL,
    expiration_date                     DATE,
    date                                DATE,
    PRIMARY KEY(id)
);

CREATE TABLE pis_db.inventory_incoming (
    id                                  INT(10) NOT NULL AUTO_INCREMENT,
    supply_id                           VARBINARY(800) NOT NULL,
    supply_name                         VARBINARY(800) NOT NULL,
    quantity                            VARBINARY(800) NOT NULL,
    expiration_date                     DATE,
    arrive_date                         DATE,
    date                                DATE,
    PRIMARY KEY(id)
);