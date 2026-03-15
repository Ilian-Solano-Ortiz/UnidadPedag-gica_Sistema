CREATE DATABASE BD_Unidad_Pedagogica_Sistema;

USE BD_Unidad_Pedagogica_Sistema;

CREATE TABLE Usuario (
    IdUsuario INT AUTO_INCREMENT PRIMARY KEY,
    CedulaUsuario VARCHAR(20) NOT NULL UNIQUE,
    NombreUsuario VARCHAR(50) NOT NULL,
    ContrasenaUsuario VARCHAR(255) NOT NULL,
    RolUsuario VARCHAR(30) NOT NULL,
    CondicionAceptacion TINYINT NOT NULL
);

CREATE TABLE Estudiante (
    IdEstudiante INT AUTO_INCREMENT PRIMARY KEY,
    CedulaEstudiante VARCHAR(20) NOT NULL UNIQUE,
    NombreEstudiante VARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Direccion VARCHAR(200) NOT NULL
);

CREATE TABLE Encargado (
    IdEncargado INT AUTO_INCREMENT PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    CedulaEncargado VARCHAR(20) NOT NULL,
    NombreEncargado VARCHAR(100) NOT NULL,
    TelefonoEncargado VARCHAR(15) NOT NULL,
    Parentesco VARCHAR(50) NOT NULL,
    LugarTrabajo VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) NOT NULL,
    ComunicacionEmergencia VARCHAR(20) NOT NULL,
    TelefonoEmergencia VARCHAR(15) NOT NULL,

    INDEX (IdEstudiante),

    FOREIGN KEY (IdEstudiante)
    REFERENCES Estudiante(IdEstudiante)
    ON UPDATE CASCADE
);

CREATE TABLE CondicionesEstudiante (
    IdCondicionEstudiante INT AUTO_INCREMENT PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    TratamientoEstudiante VARCHAR(200),
    AlergicoMedicamento VARCHAR(200),
    EnfermedadEstudiante VARCHAR(200),

    AdecuacionAprobada TINYINT,
    HorasTC VARCHAR(50),

    TipoBeca VARCHAR(50),
    NivelEstudiante VARCHAR(50),

    Beca TINYINT,
    AdecuacionEstudiante VARCHAR(100),

    INDEX (IdEstudiante),

    FOREIGN KEY (IdEstudiante)
    REFERENCES Estudiante(IdEstudiante)
    ON UPDATE CASCADE
);

CREATE TABLE CondicionSocioEconomica (
    IdCondicionSE INT AUTO_INCREMENT PRIMARY KEY,
    IdEstudiante INT NOT NULL,

    TieneBeca TINYINT,
    TipoBeca VARCHAR(50),

    NucleoFamiliar INT,

    PagoPatronato TINYINT,
    Monto DECIMAL(10,2),

    EducacionEncargado VARCHAR(100),

    INDEX (IdEstudiante),

    FOREIGN KEY (IdEstudiante)
    REFERENCES Estudiante(IdEstudiante)
    ON UPDATE CASCADE
);

CREATE TABLE Matricula (
    IdMatricula INT AUTO_INCREMENT PRIMARY KEY,
    IdUsuario INT NOT NULL,
    IdEstudiante INT NOT NULL,

    FechaMatricula DATE NOT NULL,
    AnnoLectivo VARCHAR(10),

    NivelSeleccionado VARCHAR(50) NOT NULL,
    IdiomaElegido VARCHAR(50) NOT NULL,

    UNIQUE (IdEstudiante, AnnoLectivo),

    INDEX (IdUsuario),
    INDEX (IdEstudiante),

    FOREIGN KEY (IdUsuario)
    REFERENCES Usuario(IdUsuario)
    ON UPDATE CASCADE,

    FOREIGN KEY (IdEstudiante)
    REFERENCES Estudiante(IdEstudiante)
    ON UPDATE CASCADE
);


    