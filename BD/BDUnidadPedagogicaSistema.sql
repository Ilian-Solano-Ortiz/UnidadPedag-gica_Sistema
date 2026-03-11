CREATE DATABASE BDUnidadPedagogicaSistema;

USE BDUnidadPedagogicaSistema;

CREATE TABLE Usuario (
    IdUsuario INT AUTO_INCREMENT PRIMARY KEY,
    NombreUsuario VARCHAR(50) NOT NULL,
    ContrasenaUsuario VARCHAR(255) NOT NULL,
    RolUsuario VARCHAR(30) NOT NULL,
    CondicionAceptacion VARCHAR(20) NOT NULL
);

CREATE TABLE Estudiante (
    IdEstudiante INT AUTO_INCREMENT PRIMARY KEY,
    CedulaEstudiante VARCHAR(20) NOT NULL,
    NombreEstudiante VARCHAR(100) NOT NULL,
    FechaNacimiento VARCHAR(20) NOT NULL,
    Direccion VARCHAR(200) NOT NULL
);

CREATE TABLE Encargado (
    IdEncargado INT AUTO_INCREMENT PRIMARY KEY,
    CedulaEncargado VARCHAR(20) NOT NULL,
    NombreEncargado VARCHAR(100) NOT NULL,
    TelefonoEncargado VARCHAR(20) NOT NULL,
    Parentesco VARCHAR(50) NOT NULL,
    LugarTrabajo VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) NOT NULL,
    ComunicacionEmergencia VARCHAR(20) NOT NULL,
    TelefonoEmergencia VARCHAR(20) NOT NULL
);

CREATE TABLE CondicionesEstudiante (
    IdCondicionEstudiante INT AUTO_INCREMENT PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    TratamientoEstudiante VARCHAR(200),
    AlergicoMedicamento VARCHAR(200),
    EnfermedadEstudiante VARCHAR(200),
    AdecuacionAprobada VARCHAR(100),
    HoraTC VARCHAR(50),
    TipoBeca VARCHAR(50),
    NivelEstudiante VARCHAR(50),
    Beca VARCHAR(50),
    AdecuacionEstudiante VARCHAR(100),

    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante)
);

CREATE TABLE CondicionSocioEconomica (
    IdCondicionSE INT AUTO_INCREMENT PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    TieneBeca VARCHAR(20),
    TipoBeca VARCHAR(50),
    NucleoFamiliar VARCHAR(100),
    PagoPatronato VARCHAR(50),
    Monto VARCHAR(50),
    EducacionEncargado VARCHAR(100),

    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante)
);

CREATE TABLE Matricula (
    IdMatricula INT AUTO_INCREMENT PRIMARY KEY,
    IdUsuario INT NOT NULL,
    IdEstudiante INT NOT NULL,
    FechaMatricula VARCHAR(20) NOT NULL,
    AnnoLectivo VARCHAR(10),
    NivelSeleccionado VARCHAR(50) NOT NULL,
    IdiomaElegido VARCHAR(50) NOT NULL,

    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante)
);

CREATE TABLE EstudianteEncargado (
    IdRelacion INT AUTO_INCREMENT PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    IdEncargado INT NOT NULL,

    FOREIGN KEY (IdEstudiante) REFERENCES Estudiante(IdEstudiante),
    FOREIGN KEY (IdEncargado) REFERENCES Encargado(IdEncargado)
);


    