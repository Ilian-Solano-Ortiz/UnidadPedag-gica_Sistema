CREATE DATABASE BD_Unidad_Pedagogica_Sistema;

USE BD_Unidad_Pedagogica_Sistema;

-- =========================================
-- TABLA USUARIO
-- =========================================
CREATE TABLE Usuario (
    IdUsuario INT AUTO_INCREMENT PRIMARY KEY,
    CedulaUsuario VARCHAR(20) NOT NULL UNIQUE,
    NombreUsuario VARCHAR(50) NOT NULL,
    ContrasenaUsuario VARCHAR(255) NOT NULL,
    RolUsuario VARCHAR(30) NOT NULL,
    CondicionAceptacion VARCHAR(30) NOT NULL,
    CondicionLogin VARCHAR(30) NOT NULL
);

-- =========================================
-- TABLA ESTUDIANTE
-- =========================================
CREATE TABLE Estudiante (
    IdEstudiante INT AUTO_INCREMENT PRIMARY KEY,
    CedulaEstudiante VARCHAR(20) NOT NULL UNIQUE,
    NombreEstudiante VARCHAR(100) NOT NULL,
    FechaNacimiento VARCHAR(30) NOT NULL,
    Direccion VARCHAR(200) NOT NULL
);

-- =========================================
-- TABLA ENCARGADO (CORREGIDA)
-- Se elimina relación directa con Estudiante
-- =========================================
CREATE TABLE Encargado (
    IdEncargado INT AUTO_INCREMENT PRIMARY KEY,
    CedulaEncargado VARCHAR(20) NOT NULL UNIQUE,
    NombreEncargado VARCHAR(100) NOT NULL,
    TelefonoEncargado VARCHAR(15) NOT NULL,
    Parentesco VARCHAR(50) NOT NULL,
    LugarTrabajo VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) NOT NULL,
    NombreContactoEmergencia VARCHAR(100) NOT NULL,
    TelefonoContactoEmergencia VARCHAR(15) NOT NULL
);

-- =========================================
-- TABLA MATRICULA
-- =========================================
CREATE TABLE Matricula (
    IdMatricula BIGINT PRIMARY KEY,
    IdUsuario INT NOT NULL,
    IdEstudiante INT NOT NULL,

    FechaMatricula VARCHAR(50) NOT NULL,
    AnnoLectivo VARCHAR(10) NOT NULL,

    NivelSeleccionado VARCHAR(50) NOT NULL,
    IdiomaElegido VARCHAR(50) NOT NULL,

    UNIQUE (IdEstudiante, AnnoLectivo),

    INDEX (IdUsuario),
    INDEX (IdEstudiante),

    FOREIGN KEY (IdUsuario)
        REFERENCES Usuario(IdUsuario)
        ON UPDATE CASCADE
        ON DELETE CASCADE,

    FOREIGN KEY (IdEstudiante)
        REFERENCES Estudiante(IdEstudiante)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- =========================================
-- TABLA RELACION ESTUDIANTE - ENCARGADO
-- =========================================
CREATE TABLE EstudianteEncargado (
    IdRelacion INT AUTO_INCREMENT PRIMARY KEY,
    IdEstudiante INT NOT NULL,
    IdEncargado INT NOT NULL,

    UNIQUE (IdEstudiante, IdEncargado),

    FOREIGN KEY (IdEstudiante)
        REFERENCES Estudiante(IdEstudiante)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    FOREIGN KEY (IdEncargado)
        REFERENCES Encargado(IdEncargado)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);







    