DROP DATABASE IF EXISTS patient_information_db;

CREATE DATABASE patient_information_db;

CREATE TABLE patient_information_db.users (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    user_id                             VARBINARY(55) NOT NULL,
    profile_picture                     BLOB DEFAULT NULL,
    username                            VARBINARY(55) NOT NULL,
    password                            VARBINARY(55) NOT NULL,
    first_name                          VARBINARY(55) NOT NULL,
    middle_name                         VARBINARY(55) DEFAULT NULL,
    last_name                           VARBINARY(55) NOT NULL,
    gender                              VARBINARY(55) NOT NULL,
    age                                 INT(3) NOT NULL,
    address                             VARBINARY(55) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(55) DEFAULT NULL,
    telephone_number                    VARBINARY(55) DEFAULT NULL,
    email                               VARBINARY(55) DEFAULT NULL,
    role                  				VARBINARY(55) NOT NULL,
    specialization                      VARBINARY(55) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

INSERT INTO patient_information_db.users(user_id, username, password, first_name, middle_name, last_name, gender, age, address, cellphone_number, 
telephone_number, email, role)
VALUES(
    AES_ENCRYPT('99999999999', 'jovencutegwapo123'),
    AES_ENCRYPT('admin', 'jovencutegwapo123'),
    AES_ENCRYPT('admin', 'jovencutegwapo123'),
    AES_ENCRYPT('Joven Joshua', 'jovencutegwapo123'),
    AES_ENCRYPT('Celiz', 'jovencutegwapo123'),
    AES_ENCRYPT('Alovera', 'jovencutegwapo123'),
    AES_ENCRYPT('Male', 'jovencutegwapo123'),
    22,
    AES_ENCRYPT('1696 San Roque St. Roxas City', 'jovencutegwapo123'),
    AES_ENCRYPT('09434071429', 'jovencutegwapo123'),
    AES_ENCRYPT('6210433', 'jovencutegwapo123'),
    AES_ENCRYPT('jovenalovera1999@gmail.com', 'jovencutegwapo123'),
    AES_ENCRYPT('Administrator', 'jovencutegwapo123')
);

CREATE TABLE patient_information_db.waiting_list (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(55) NOT NULL,
    first_name                          VARBINARY(55) NOT NULL,
    middle_name                         VARBINARY(55) DEFAULT NULL,
    last_name                           VARBINARY(55) NOT NULL,
    gender                              VARBINARY(55) NOT NULL,
    age                                 INT(3) NOT NULL,
    address                             VARBINARY(55) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(55) DEFAULT NULL,
    telephone_number                    VARBINARY(55) DEFAULT NULL,
    email                               VARBINARY(55) DEFAULT NULL,
    height                              DOUBLE DEFAULT NULL,
    weight                              DOUBLE NOT NULL,
    temperature                         DOUBLE NOT NULL,
    pulse_rate                          DOUBLE DEFAULT NULL,
    blood_pressure                      DOUBLE DEFAULT NULL,
    doctor                              VARBINARY(55) NOT NULL,
    status                              VARBINARY(55) DEFAULT 'Waiting',
    PRIMARY KEY (id)
);

CREATE TABLE patient_information_db.patients (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(55) NOT NULL,
    first_name                          VARBINARY(55) NOT NULL,
    middle_name                         VARBINARY(55) DEFAULT NULL,
    last_name                           VARBINARY(55) NOT NULL,
    gender                              VARBINARY(55) NOT NULL,
    age                                 INT(3) NOT NULL,
    address                             VARBINARY(55) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(55) DEFAULT NULL,
    telephone_number                    VARBINARY(55) DEFAULT NULL,
    email                               VARBINARY(55) DEFAULT NULL,
    height                              DOUBLE DEFAULT NULL,
    weight                              DOUBLE DEFAULT NULL,
    temperature                         DOUBLE DEFAULT NULL,
    pulse_rate                          DOUBLE DEFAULT NULL,
    blood_pressure                      DOUBLE DEFAULT NULL,
    doctor                              VARBINARY(55) NOT NULL,
    payment_status                      VARBINARY(55) DEFAULT 'Unpaid',
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_db.diagnosis (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(55) NOT NULL,
    diagnosis                           VARBINARY(55) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_db.symptoms (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(55) NOT NULL,
    symptoms                            VARBINARY(55) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_db.prescriptions (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(55) NOT NULL,
    prescriptions                       VARBINARY(500) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_db.transactions (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(55) NOT NULL,
    receipt_no                          VARBINARY(55) NOT NULL,
    first_name                          VARBINARY(55) NOT NULL,
    middle_name                         VARBINARY(55) DEFAULT NULL,
    last_name                           VARBINARY(55) NOT NULL,
    doctor                              VARBINARY(55) NOT NULL,
    total_medical_fee                   DOUBLE NOT NULL,
    discount                            VARBINARY(55) DEFAULT NULL,
    amount                              DOUBLE NOT NULL,
    total_amount_paid                   DOUBLE NOT NULL,
    `change`                            DOUBLE DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_db.inventory (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    supply_id                           VARBINARY(55) NOT NULL,
    supply_name                         VARBINARY(55) NOT NULL,
    quantity                            INT(16) NOT NULL,
    expiration_date                     DATE,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);