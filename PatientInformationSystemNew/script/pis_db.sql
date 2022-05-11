DROP DATABASE IF EXISTS pis_db;

CREATE DATABASE pis_db;

CREATE TABLE pis_db.users (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user_id                             VARBINARY(255) NOT NULL,
    profile_picture                     BLOB DEFAULT NULL,
    username                            VARBINARY(255) NOT NULL,
    password                            VARBINARY(255) NOT NULL,
    first_name                          VARBINARY(255) NOT NULL,
    middle_name                         VARBINARY(255) DEFAULT NULL,
    last_name                           VARBINARY(255) NOT NULL,
    gender                              VARBINARY(255) NOT NULL,
    age                                 VARBINARY(255) NOT NULL,
    address                             VARBINARY(255) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(255) DEFAULT NULL,
    telephone_number                    VARBINARY(255) DEFAULT NULL,
    email                               VARBINARY(255) DEFAULT NULL,
    role                  				VARBINARY(255) NOT NULL,
    specialization                      VARBINARY(255) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
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
    AES_ENCRYPT('57657', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('doctor', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('doctor', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Jessie', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Bueno', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Male', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('31', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Mabini St. Roxas City', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('09734063476', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('628783', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('jessiebueno@gmail.com', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Doctor', 'j0v3ncut3gw4p0per0jok3l4ang'),
    AES_ENCRYPT('Pediatric', 'j0v3ncut3gw4p0per0jok3l4ang')
);

CREATE TABLE pis_db.schedule (
    id                                  INT NOT NULL AUTO_INCREMENT,
    doctor_fid                          INT NOT NULL,
    patient_id                          VARBINARY(255) NOT NULL,
    first_name                          VARBINARY(255) NOT NULL,    
    middle_name                         VARBINARY(255) DEFAULT NULL,
    last_name                           VARBINARY(255) NOT NULL,
    gender                              VARBINARY(255) NOT NULL,
    birthday                            DATE,
    status                              VARBINARY(255) DEFAULT AES_ENCRYPT('Waiting', 'j0v3ncut3gw4p0per0jok3l4ang'),
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(doctor_fid) REFERENCES pis_db.users(id)
);

CREATE TABLE pis_db.patients (
    id                                  INT NOT NULL AUTO_INCREMENT,
    doctor_fid                          INT NOT NULL,
    patient_id                          VARBINARY(255) NOT NULL,
    first_name                          VARBINARY(255) NOT NULL,
    middle_name                         VARBINARY(255) DEFAULT NULL,
    last_name                           VARBINARY(255) NOT NULL,
    gender                              VARBINARY(255) NOT NULL,
    age                                 VARBINARY(255) NOT NULL,
    address                             VARBINARY(255) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(255) DEFAULT NULL,
    telephone_number                    VARBINARY(255) DEFAULT NULL,
    email                               VARBINARY(255) DEFAULT NULL,
    status                              VARBINARY(255) DEFAULT AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang'),
    payment_status                      VARBINARY(255) DEFAULT AES_ENCRYPT('Unpaid', 'j0v3ncut3gw4p0per0jok3l4ang'),
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(doctor_fid) REFERENCES pis_db.users(id)
);

CREATE TABLE pis_db.duplicate_patients (
    id                                  INT NOT NULL AUTO_INCREMENT,
    patient_id                          VARBINARY(255) NOT NULL,
    first_name                          VARBINARY(255) NOT NULL,
    middle_name                         VARBINARY(255) DEFAULT NULL,
    last_name                           VARBINARY(255) NOT NULL,
    gender                              VARBINARY(255) NOT NULL,
    age                                 VARBINARY(255) NOT NULL,
    address                             VARBINARY(255) NOT NULL,
    birthday                            DATE,
    cellphone_number                    VARBINARY(255) DEFAULT NULL,
    telephone_number                    VARBINARY(255) DEFAULT NULL,
    email                               VARBINARY(255) DEFAULT NULL,
    status                              VARBINARY(255) DEFAULT AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang'),
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.number_of_patients (
    id                                  INT NOT NULL AUTO_INCREMENT,
    doctor_fid                          INT NOT NULL,
    full_name                           VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(doctor_fid) REFERENCES pis_db.users(id)
);

CREATE TABLE pis_db.vital_signs (
    id                                  INT NOT NULL AUTO_INCREMENT,
    patient_fid                         INT NOT NULL,
    height                              VARBINARY(255) DEFAULT NULL,
    weight                              VARBINARY(255) NOT NULL,
    temperature                         VARBINARY(255) NOT NULL,
    pulse_rate                          VARBINARY(255) DEFAULT NULL,
    blood_pressure                      VARBINARY(255) DEFAULT NULL,
    status                              VARBINARY(255) DEFAULT AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang'),
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(patient_fid) REFERENCES pis_db.patients(id)
);

CREATE TABLE pis_db.diagnosis (
    id                                  INT NOT NULL AUTO_INCREMENT,
    patient_fid                         INT NOT NULL,
    diagnosis                           VARBINARY(255) DEFAULT NULL,
    status                              VARBINARY(255) DEFAULT AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang'),
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(patient_fid) REFERENCES pis_db.patients(id)
);

CREATE TABLE pis_db.symptoms (
    id                                  INT NOT NULL AUTO_INCREMENT,
    patient_fid                         INT NOT NULL,
    symptoms                            VARBINARY(255) DEFAULT NULL,
    status                              VARBINARY(255) DEFAULT AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang'),
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(patient_fid) REFERENCES pis_db.patients(id)
);

CREATE TABLE pis_db.prescriptions (
    id                                  INT NOT NULL AUTO_INCREMENT,    
    patient_fid                         INT NOT NULL,
    prescriptions                       VARBINARY(255) DEFAULT NULL,
    status                              VARBINARY(255) DEFAULT AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang'),
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(patient_fid) REFERENCES pis_db.patients(id)
);

CREATE TABLE pis_db.payment_transactions (
    id                                  INT NOT NULL AUTO_INCREMENT,
    patient_fid                         INT NOT NULL,
    receipt_no                          VARBINARY(255) NOT NULL,
    total_medical_fee                   VARBINARY(255) NOT NULL,
    discount                            VARBINARY(255) DEFAULT NULL,
    amount                              VARBINARY(255) NOT NULL,
    total_amount_paid                   VARBINARY(255) NOT NULL,
    `change`                            VARBINARY(255) DEFAULT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(patient_fid) REFERENCES pis_db.patients(id)
);

CREATE TABLE pis_db.cashier (
    id                                  INT NOT NULL AUTO_INCREMENT,
    transaction_fid                     INT NOT NULL,
    cashier                             VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id),
                                        FOREIGN KEY(transaction_fid) REFERENCES pis_db.payment_transactions(id)
);

CREATE TABLE pis_db.inventory (
    id                                  INT NOT NULL AUTO_INCREMENT,
    supplier                            VARBINARY(255) NOT NULL,
    supply_id                           VARBINARY(255) NOT NULL,
    supply_name                         VARBINARY(255) NOT NULL,
    quantity                            VARBINARY(255) NOT NULL,
    expiration_date                     DATETIME,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.inventory_incoming (
    id                                  INT NOT NULL AUTO_INCREMENT,
    supplier                            VARBINARY(255) NOT NULL,
    supply_id                           VARBINARY(255) NOT NULL,
    supply_name                         VARBINARY(255) NOT NULL,
    quantity                            VARBINARY(255) NOT NULL,
    expiration_date                     DATETIME,
    arrive_date                         DATETIME,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.update_history_patient (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user                                VARBINARY(255) NOT NULL,
    patient                             VARBINARY(255) NOT NULL,
    description                         VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.update_history_inventory (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user                                VARBINARY(255) NOT NULL,
    issued_to                           VARBINARY(255) NOT NULL,
    description                         VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.update_history_vital_signs (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user                                VARBINARY(255) NOT NULL,
    patient                             VARBINARY(255) NOT NULL,
    description                         VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.update_history_diagnosis (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user                                VARBINARY(255) NOT NULL,
    patient                             VARBINARY(255) NOT NULL,
    description                         VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.update_history_symptoms (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user                                VARBINARY(255) NOT NULL,
    patient                             VARBINARY(255) NOT NULL,
    description                         VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.update_history_prescriptions (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user                                VARBINARY(255) NOT NULL,
    patient                             VARBINARY(255) NOT NULL,
    description                         VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);

CREATE TABLE pis_db.update_history_payment_transactions (
    id                                  INT NOT NULL AUTO_INCREMENT,
    user                                VARBINARY(255) NOT NULL,
    patient                             VARBINARY(255) NOT NULL,
    description                         VARBINARY(255) NOT NULL,
    date                                TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                                        PRIMARY KEY(id)
);