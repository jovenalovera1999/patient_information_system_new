DROP DATABASE IF EXISTS patient_information_system_db;

CREATE DATABASE patient_information_system_db;

CREATE TABLE patient_information_system_db.users (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    user_id                             VARCHAR(16) NOT NULL,
    profile_picture                     BLOB DEFAULT NULL,
    username                            VARCHAR(55) NOT NULL,
    password                            VARCHAR(55) NOT NULL,
    first_name                          VARCHAR(55) NOT NULL,
    middle_name                         VARCHAR(55) DEFAULT NULL,
    last_name                           VARCHAR(55) NOT NULL,
    gender                              VARCHAR(55) NOT NULL,
    age                                 INT(3) NOT NULL,
    birthday                            DATE DEFAULT NULL,
    address                             VARCHAR(55) NOT NULL,
    cellphone_number                    VARCHAR(55) DEFAULT NULL,
    telephone_number                    VARCHAR(55) DEFAULT NULL,
    email                               VARCHAR(55) DEFAULT NULL,
    role                  				VARCHAR(55) NOT NULL,
    specialization                      VARCHAR(55) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

INSERT INTO patient_information_system_db.users(user_id, profile_picture, username, password, first_name, middle_name, last_name, age, birthday, address, 
cellphone_number, telephone_number, email, role, specialization)
VALUES(
    AES_ENCRYPT('99999999999', 'jovencutegwapo123'), 
    NULL, 
    AES_ENCRYPT('admin', 'jovencutegwapo123'),
    AES_ENCRYPT('admin', 'jovencutegwapo123'),
    AES_ENCRYPT('Joven Joshua', 'jovencutegwapo123'),
    AES_ENCRYPT('Celiz', 'jovencutegwapo123'),
    AES_ENCRYPT('Alovera', 'jovencutegwapo123'),
    22,
    NULL,
    AES_ENCRYPT('1696 San Roque St. Roxas City', 'jovencutegwapo123'),
    AES_ENCRYPT('09434071429', 'jovencutegwapo123'),
    AES_ENCRYPT('6210433', 'jovencutegwapo123'),
    AES_ENCRYPT('jovenalovera1999@gmail.com', 'jovencutegwapo123'),
    AES_ENCRYPT('Administrator', 'jovencutegwapo123'),
    NULL
);

CREATE TABLE patient_information_system_db.waiting_list (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARCHAR(16) NOT NULL,
    first_name                          VARCHAR(55) NOT NULL,
    middle_name                         VARCHAR(55) DEFAULT NULL,
    last_name                           VARCHAR(55) NOT NULL,
    gender                              VARCHAR(55) NOT NULL,
    age                                 INT(3) NOT NULL,
    address                             VARCHAR(55) NOT NULL,
    cellphone_number                    VARCHAR(55) DEFAULT NULL,
    telephone_number                    VARCHAR(55) DEFAULT NULL,
    email                               VARCHAR(55) DEFAULT NULL,
    doctor                              VARCHAR(55) NOT NULL,
    status                              VARCHAR(55) DEFAULT 'Waiting',
    PRIMARY KEY (id)
);

CREATE TABLE patient_information_system_db.patients (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARCHAR(16) NOT NULL,
    first_name                          VARCHAR(55) NOT NULL,
    middle_name                         VARCHAR(55) DEFAULT NULL,
    last_name                           VARCHAR(55) NOT NULL,
    gender                              VARCHAR(55) NOT NULL,
    age                                 INT(3) NOT NULL,
    address                             VARCHAR(55) NOT NULL,
    cellphone_number                    VARCHAR(55) DEFAULT NULL,
    telephone_number                    VARCHAR(55) DEFAULT NULL,
    email                               VARCHAR(55) DEFAULT NULL,
    doctor                              VARCHAR(55) NOT NULL,
    payment_status                      VARCHAR(55) DEFAULT 'Unpaid',
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_system_db.vital_signs (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARCHAR(55) NOT NULL,
    height                              DOUBLE DEFAULT NULL,
    weight                              DOUBLE DEFAULT NULL,
    temperature                         DOUBLE DEFAULT NULL,
    pulse_rate                          DOUBLE DEFAULT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_system_db.diagnosis (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARCHAR(16) NOT NULL,
    diagnosis                           VARCHAR(55) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_system_db.symptoms (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARCHAR(16) NOT NULL,
    symptoms                            VARCHAR(55) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_system_db.prescriptions (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARCHAR(16) NOT NULL,
    prescriptions                       VARCHAR(300) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_system_db.transactions (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    patient_id                          VARCHAR(16) NOT NULL,
    receipt_no                          VARCHAR(16) NOT NULL,
    full_name                           VARCHAR(55) NOT NULL,
    doctor                              VARCHAR(55) NOT NULL,
    total_medical_fee                   DOUBLE NOT NULL,
    discount                            VARCHAR(55) DEFAULT NULL,
    amount                              DOUBLE NOT NULL,
    total_amount_paid                   DOUBLE NOT NULL,
    `change`                            DOUBLE DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);

CREATE TABLE patient_information_system_db.inventory (
    id                                  INT(16) NOT NULL AUTO_INCREMENT,
    supply_id                           VARCHAR(16) NOT NULL,
    supply_name                         VARCHAR(55) NOT NULL,
    quantity                            INT(16) NOT NULL,
    expiration_date                     DATE DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY(id)
);