-- =====================================================
-- PROCEDIMIENTOS ALMACENADOS
-- =====================================================


-- =====================================================
-- SP LOGIN
-- 0 = usuario no existe
-- 1 = contraseña incorrecta
-- 2 = login correcto
-- 3 = usuario pendiente de aprobación
-- 4 = usuario rechazado
-- =====================================================

DELIMITER $$

CREATE PROCEDURE LoginUsuario(
    IN pCedulaUsuario VARCHAR(20),
    IN pContrasenaUsuario VARCHAR(255)
)
BEGIN

    DECLARE vContrasena VARCHAR(255);
    DECLARE vEstado TINYINT;

    SELECT ContrasenaUsuario, CondicionAceptacion
    INTO vContrasena, vEstado
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario
    LIMIT 1;

    IF vContrasena IS NULL THEN

        SELECT 0 AS Resultado;

    ELSEIF vEstado = 0 THEN

        SELECT 3 AS Resultado;

    ELSEIF vEstado = 2 THEN

        SELECT 4 AS Resultado;

    ELSEIF vContrasena <> pContrasenaUsuario THEN

        SELECT 1 AS Resultado;

    ELSE

        SELECT 2 AS Resultado;

    END IF;

END $$

DELIMITER ;



-- =====================================================
-- SP REGISTRAR USUARIO
-- 0 = usuario ya existe
-- 1 = usuario creado
-- =====================================================
-- CondicionAceptacion
-- 0 = creado
-- 1 = aceptado
-- 2 = rechazado
-- =====================================================

DELIMITER $$

CREATE PROCEDURE RegistrarUsuario(
    IN pCedulaUsuario VARCHAR(20),
    IN pNombreUsuario VARCHAR(50),
    IN pContrasenaUsuario VARCHAR(255),
    IN pRolUsuario VARCHAR(30)
)
BEGIN

    DECLARE vExiste INT;

    SELECT COUNT(*)
    INTO vExiste
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario;

    IF vExiste > 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        INSERT INTO Usuario(
            CedulaUsuario,
            NombreUsuario,
            ContrasenaUsuario,
            RolUsuario,
            CondicionAceptacion
        )
        VALUES(
            pCedulaUsuario,
            pNombreUsuario,
            pContrasenaUsuario,
            pRolUsuario,
            0
        );

        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;



-- =====================================================
-- SP CAMBIAR CONTRASEÑA
-- 0 = usuario no existe
-- 1 = contraseña actual incorrecta
-- 2 = contraseña cambiada correctamente
-- =====================================================

DELIMITER $$

CREATE PROCEDURE CambiarContrasena(
    IN pCedulaUsuario VARCHAR(20),
    IN pContrasenaActual VARCHAR(255),
    IN pContrasenaNueva VARCHAR(255)
)
BEGIN

    DECLARE vContrasena VARCHAR(255);

    SELECT ContrasenaUsuario
    INTO vContrasena
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario
    LIMIT 1;

    IF vContrasena IS NULL THEN

        SELECT 0 AS Resultado;

    ELSEIF vContrasena <> pContrasenaActual THEN

        SELECT 1 AS Resultado;

    ELSE

        UPDATE Usuario
        SET ContrasenaUsuario = pContrasenaNueva
        WHERE CedulaUsuario = pCedulaUsuario;

        SELECT 2 AS Resultado;

    END IF;

END $$

DELIMITER ;

-- =====================================================
-- SP RESETEAR CONTRASEÑA
-- 0 = usuario no existe
-- 1 = contraseña reseteada
-- =====================================================

DELIMITER $$

CREATE PROCEDURE ResetearContrasena(
    IN pCedulaUsuario VARCHAR(20)
)
BEGIN

    DECLARE vExiste INT;

    SELECT COUNT(*)
    INTO vExiste
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario;

    IF vExiste = 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        UPDATE Usuario
        SET ContrasenaUsuario = pCedulaUsuario
        WHERE CedulaUsuario = pCedulaUsuario;

        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;


-- =====================================================
-- SP ACEPTAR USUARIO 
-- 0 = usuario no existe
-- 1 = usuario aaceptado
-- =====================================================


DELIMITER $$

CREATE PROCEDURE AceptarUsuario(
    IN pCedulaUsuario VARCHAR(20)
)
BEGIN

    DECLARE vExiste INT;

    SELECT COUNT(*)
    INTO vExiste
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario;

    IF vExiste = 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        UPDATE Usuario
        SET CondicionAceptacion = 1
        WHERE CedulaUsuario = pCedulaUsuario;

        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;

-- =====================================================
-- SP RECHAZAR USUARIO 
-- 0 = usuario no existe
-- 1 = usuario rechazado
-- =====================================================


DELIMITER $$

CREATE PROCEDURE RechazarUsuario(
    IN pCedulaUsuario VARCHAR(20)
)
BEGIN

    DECLARE vExiste INT;

    SELECT COUNT(*)
    INTO vExiste
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario;

    IF vExiste = 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        UPDATE Usuario
        SET CondicionAceptacion = 2
        WHERE CedulaUsuario = pCedulaUsuario;

        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;


-- =====================================================
-- SP BUSCAR USUARIO POR CEDULA
-- Devuelve el usuario si existe
-- Si no existe devuelve 0 filas
-- =====================================================

DELIMITER $$

CREATE PROCEDURE BuscarUsuario(
    IN pCedulaUsuario VARCHAR(20)
)
BEGIN

    SELECT 
        IdUsuario,
        CedulaUsuario,
        NombreUsuario,
        RolUsuario,
        CondicionAceptacion
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario
    LIMIT 1;

END $$

DELIMITER ;

-- =====================================================
-- SP BUSCAR CARGAR DATOS ESTUDIANTE
-- Devuelve los datos del estudainte si existe
-- Si no existe devuelve 0 filas
-- =====================================================

DELIMITER $$

CREATE PROCEDURE CargarDatosEstudiante(
    IN pCedulaEstudiante VARCHAR(20)
)
BEGIN

    SELECT
        e.IdEstudiante,
        e.CedulaEstudiante,
        e.NombreEstudiante,
        e.FechaNacimiento,
        e.Direccion,

        en.IdEncargado,
        en.CedulaEncargado,
        en.NombreEncargado,
        en.TelefonoEncargado,
        en.Parentesco,
        en.LugarTrabajo,
        en.Correo,
        en.ComunicacionEmergencia,
        en.TelefonoEmergencia,

        ce.IdCondicionEstudiante,
        ce.TratamientoEstudiante,
        ce.AlergicoMedicamento,
        ce.EnfermedadEstudiante,
        ce.AdecuacionAprobada,
        ce.HoraTC,
        ce.TipoBeca,
        ce.NivelEstudiante,
        ce.Beca,
        ce.AdecuacionEstudiante,

        cs.IdCondicionSE,
        cs.TieneBeca,
        cs.TipoBeca AS TipoBecaSocioeconomica,
        cs.NucleoFamiliar,
        cs.PagoPatronato,
        cs.Monto,
        cs.EducacionEncargado

    FROM Estudiante e

    LEFT JOIN Encargado en
        ON e.IdEstudiante = en.IdEstudiante

    LEFT JOIN CondicionesEstudiante ce
        ON e.IdEstudiante = ce.IdEstudiante

    LEFT JOIN CondicionSocioEconomica cs
        ON e.IdEstudiante = cs.IdEstudiante

    WHERE e.CedulaEstudiante = pCedulaEstudiante
    LIMIT 1;

END $$

DELIMITER ;

-- =====================================================
-- SP REGISTRAR MATRICULA
-- HACE TODO EL PROCESO DE MATRICULA EN UNA SOLA EJECUCIÓN 
-- Si no existe el estudiante lo crea  y si existe actualiza todo y registra la matricula.
-- =====================================================
DELIMITER $$

CREATE PROCEDURE RegistrarMatricula(

-- =====================
-- DATOS ESTUDIANTE
-- =====================

IN pCedulaEstudiante VARCHAR(20),
IN pNombreEstudiante VARCHAR(100),
IN pFechaNacimiento DATE,
IN pDireccion VARCHAR(200),

-- =====================
-- DATOS ENCARGADO
-- =====================

IN pCedulaEncargado VARCHAR(20),
IN pNombreEncargado VARCHAR(100),
IN pTelefonoEncargado VARCHAR(15),
IN pParentesco VARCHAR(50),
IN pLugarTrabajo VARCHAR(100),
IN pCorreo VARCHAR(100),
IN pComunicacionEmergencia VARCHAR(20),
IN pTelefonoEmergencia VARCHAR(15),

-- =====================
-- CONDICIONES ESTUDIANTE
-- =====================

IN pTratamientoEstudiante VARCHAR(200),
IN pAlergicoMedicamento VARCHAR(200),
IN pEnfermedadEstudiante VARCHAR(200),
IN pAdecuacionAprobada TINYINT,
IN pHoraTC VARCHAR(50),
IN pTipoBeca VARCHAR(50),
IN pNivelEstudiante VARCHAR(50),
IN pBeca TINYINT,
IN pAdecuacionEstudiante VARCHAR(100),

-- =====================
-- CONDICION SOCIOECONOMICA
-- =====================

IN pTieneBeca TINYINT,
IN pTipoBecaSE VARCHAR(50),
IN pNucleoFamiliar INT,
IN pPagoPatronato TINYINT,
IN pMonto DECIMAL(10,2),
IN pEducacionEncargado VARCHAR(100),

-- =====================
-- DATOS MATRICULA
-- =====================

IN pIdUsuario INT,
IN pFechaMatricula DATE,
IN pAnnoLectivo VARCHAR(10),
IN pNivelSeleccionado VARCHAR(50),
IN pIdiomaElegido VARCHAR(50)

)

BEGIN

DECLARE vIdEstudiante INT;

START TRANSACTION;

-- =====================================
-- VERIFICAR SI EXISTE ESTUDIANTE
-- =====================================

SELECT IdEstudiante
INTO vIdEstudiante
FROM Estudiante
WHERE CedulaEstudiante = pCedulaEstudiante
LIMIT 1;

-- =====================================
-- SI NO EXISTE ESTUDIANTE
-- =====================================

IF vIdEstudiante IS NULL THEN

    INSERT INTO Estudiante(
        CedulaEstudiante,
        NombreEstudiante,
        FechaNacimiento,
        Direccion
    )
    VALUES(
        pCedulaEstudiante,
        pNombreEstudiante,
        pFechaNacimiento,
        pDireccion
    );

    SET vIdEstudiante = LAST_INSERT_ID();

    INSERT INTO Encargado(
        IdEstudiante,
        CedulaEncargado,
        NombreEncargado,
        TelefonoEncargado,
        Parentesco,
        LugarTrabajo,
        Correo,
        ComunicacionEmergencia,
        TelefonoEmergencia
    )
    VALUES(
        vIdEstudiante,
        pCedulaEncargado,
        pNombreEncargado,
        pTelefonoEncargado,
        pParentesco,
        pLugarTrabajo,
        pCorreo,
        pComunicacionEmergencia,
        pTelefonoEmergencia
    );

    INSERT INTO CondicionesEstudiante(
        IdEstudiante,
        TratamientoEstudiante,
        AlergicoMedicamento,
        EnfermedadEstudiante,
        AdecuacionAprobada,
        HoraTC,
        TipoBeca,
        NivelEstudiante,
        Beca,
        AdecuacionEstudiante
    )
    VALUES(
        vIdEstudiante,
        pTratamientoEstudiante,
        pAlergicoMedicamento,
        pEnfermedadEstudiante,
        pAdecuacionAprobada,
        pHoraTC,
        pTipoBeca,
        pNivelEstudiante,
        pBeca,
        pAdecuacionEstudiante
    );

    INSERT INTO CondicionSocioEconomica(
        IdEstudiante,
        TieneBeca,
        TipoBeca,
        NucleoFamiliar,
        PagoPatronato,
        Monto,
        EducacionEncargado
    )
    VALUES(
        vIdEstudiante,
        pTieneBeca,
        pTipoBecaSE,
        pNucleoFamiliar,
        pPagoPatronato,
        pMonto,
        pEducacionEncargado
    );

-- =====================================
-- SI EL ESTUDIANTE YA EXISTE
-- =====================================

ELSE

    UPDATE Estudiante
    SET
        NombreEstudiante = pNombreEstudiante,
        FechaNacimiento = pFechaNacimiento,
        Direccion = pDireccion
    WHERE IdEstudiante = vIdEstudiante;

    UPDATE Encargado
    SET
        CedulaEncargado = pCedulaEncargado,
        NombreEncargado = pNombreEncargado,
        TelefonoEncargado = pTelefonoEncargado,
        Parentesco = pParentesco,
        LugarTrabajo = pLugarTrabajo,
        Correo = pCorreo,
        ComunicacionEmergencia = pComunicacionEmergencia,
        TelefonoEmergencia = pTelefonoEmergencia
    WHERE IdEstudiante = vIdEstudiante;

    UPDATE CondicionesEstudiante
    SET
        TratamientoEstudiante = pTratamientoEstudiante,
        AlergicoMedicamento = pAlergicoMedicamento,
        EnfermedadEstudiante = pEnfermedadEstudiante,
        AdecuacionAprobada = pAdecuacionAprobada,
        HoraTC = pHoraTC,
        TipoBeca = pTipoBeca,
        NivelEstudiante = pNivelEstudiante,
        Beca = pBeca,
        AdecuacionEstudiante = pAdecuacionEstudiante
    WHERE IdEstudiante = vIdEstudiante;

    UPDATE CondicionSocioEconomica
    SET
        TieneBeca = pTieneBeca,
        TipoBeca = pTipoBecaSE,
        NucleoFamiliar = pNucleoFamiliar,
        PagoPatronato = pPagoPatronato,
        Monto = pMonto,
        EducacionEncargado = pEducacionEncargado
    WHERE IdEstudiante = vIdEstudiante;

END IF;

-- =====================================
-- REGISTRAR MATRICULA
-- =====================================

INSERT INTO Matricula(
    IdUsuario,
    IdEstudiante,
    FechaMatricula,
    AnnoLectivo,
    NivelSeleccionado,
    IdiomaElegido
)
VALUES(
    pIdUsuario,
    vIdEstudiante,
    pFechaMatricula,
    pAnnoLectivo,
    pNivelSeleccionado,
    pIdiomaElegido
);

COMMIT;

END $$

DELIMITER ;

-- =====================================================
-- SP ELIMINAR ESTUDIANTE
-- Borra todo lo relacionado a un estudiante matricula,condiciones y por ultimo al estudiante.
-- Condiciones: 0 = estudiante no eixtse ; 1 = Estudiante eliminado
-- =====================================================

DELIMITER $$

CREATE PROCEDURE EliminarEstudiante(
    IN pCedulaEstudiante VARCHAR(20)
)
BEGIN

    DECLARE vIdEstudiante INT;

    START TRANSACTION;

    SELECT IdEstudiante
    INTO vIdEstudiante
    FROM Estudiante
    WHERE CedulaEstudiante = pCedulaEstudiante
    LIMIT 1;

    IF vIdEstudiante IS NULL THEN

        SELECT 0 AS Resultado;

    ELSE

        DELETE FROM Matricula
        WHERE IdEstudiante = vIdEstudiante;

        DELETE FROM Encargado
        WHERE IdEstudiante = vIdEstudiante;

        DELETE FROM CondicionesEstudiante
        WHERE IdEstudiante = vIdEstudiante;

        DELETE FROM CondicionSocioEconomica
        WHERE IdEstudiante = vIdEstudiante;

        DELETE FROM Estudiante
        WHERE IdEstudiante = vIdEstudiante;

        COMMIT;

        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;