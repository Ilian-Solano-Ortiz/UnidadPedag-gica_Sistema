-- =====================================================
-- SP´s - Matricula
-- =====================================================


-- =====================================================
-- SP REGISTRAR MATRICULA
-- 0 = ya existe matrícula en este ciclo para este estudiante
-- 1 = matrícula registrada correctamente
-- 2 = Error al ingresar en alguna tabla
-- =====================================================

DELIMITER $$

CREATE PROCEDURE RegistrarMatricula(

    IN pIdUsuario INT,

    IN pCedulaEstudiante VARCHAR(20),
    IN pNombreEstudiante VARCHAR(100),
    IN pFechaNacimiento DATE,
    IN pDireccion VARCHAR(200),

    IN pCedulaEncargado VARCHAR(20),
    IN pNombreEncargado VARCHAR(100),
    IN pTelefonoEncargado VARCHAR(15),
    IN pParentesco VARCHAR(50),
    IN pLugarTrabajo VARCHAR(100),
    IN pCorreo VARCHAR(100),
    IN pNombreContactoEmergencia VARCHAR(100),
    IN pTelefonoEmergencia VARCHAR(15),

    IN pFechaMatricula VARCHAR(50),
    IN pAnnoLectivo VARCHAR(10),
    IN pNivelSeleccionado VARCHAR(50),
    IN pIdiomaElegido VARCHAR(50)
)
BEGIN

    DECLARE vIdEstudiante INT;
    DECLARE vIdEncargado INT;
    DECLARE vExisteMatricula INT;

    DECLARE vNuevoId BIGINT;
    DECLARE vBase BIGINT;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        SELECT 2 AS Resultado;
    END;

    START TRANSACTION;

    SELECT IdEstudiante
    INTO vIdEstudiante
    FROM Estudiante
    WHERE CedulaEstudiante = pCedulaEstudiante
    LIMIT 1;

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

    END IF;

    SELECT IdEncargado
    INTO vIdEncargado
    FROM Encargado
    WHERE CedulaEncargado = pCedulaEncargado
    LIMIT 1;

    IF vIdEncargado IS NULL THEN

        INSERT INTO Encargado(
            CedulaEncargado,
            NombreEncargado,
            TelefonoEncargado,
            Parentesco,
            LugarTrabajo,
            Correo,
            NombreContactoEmergencia,
            TelefonoEmergencia
        )
        VALUES(
            pCedulaEncargado,
            pNombreEncargado,
            pTelefonoEncargado,
            pParentesco,
            pLugarTrabajo,
            pCorreo,
            pNombreContactoEmergencia,
            pTelefonoEmergencia
        );

        SET vIdEncargado = LAST_INSERT_ID();

    END IF;


    IF NOT EXISTS (
        SELECT 1 
        FROM EstudianteEncargado
        WHERE IdEstudiante = vIdEstudiante
        AND IdEncargado = vIdEncargado
    ) THEN

        INSERT INTO EstudianteEncargado(
            IdEstudiante,
            IdEncargado
        )
        VALUES(
            vIdEstudiante,
            vIdEncargado
        );

    END IF;


    SELECT COUNT(*)
    INTO vExisteMatricula
    FROM Matricula
    WHERE IdEstudiante = vIdEstudiante
    AND AnnoLectivo = pAnnoLectivo;

    IF vExisteMatricula > 0 THEN

        ROLLBACK;
        SELECT 0 AS Resultado;

    ELSE


        SET vBase = CAST(pAnnoLectivo AS UNSIGNED) * 100000;

        SELECT IFNULL(MAX(IdMatricula), vBase)
        INTO vNuevoId
        FROM Matricula
        WHERE AnnoLectivo = pAnnoLectivo;

        SET vNuevoId = vNuevoId + 1;

        INSERT INTO Matricula(
            IdMatricula,
            IdUsuario,
            IdEstudiante,
            FechaMatricula,
            AnnoLectivo,
            NivelSeleccionado,
            IdiomaElegido
        )
        VALUES(
            vNuevoId,
            pIdUsuario,
            vIdEstudiante,
            pFechaMatricula,
            pAnnoLectivo,
            pNivelSeleccionado,
            pIdiomaElegido
        );

        COMMIT;

        SELECT 1 AS Resultado, vNuevoId AS IdMatricula;

    END IF;

END $$

DELIMITER ;


-- =====================================================
-- SP CONSULTAR MATRICULA
-- Busca por ID de matricula o por cedula de estudiante
-- =====================================================

DELIMITER $$

CREATE PROCEDURE BuscarMatricula(
    IN pIdMatricula BIGINT,
    IN pCedulaEstudiante VARCHAR(20)
)
BEGIN

    DECLARE vExiste INT;
    
    IF pIdMatricula IS NOT NULL AND pIdMatricula <> 0 THEN

        SELECT COUNT(*)
        INTO vExiste
        FROM Matricula
        WHERE IdMatricula = pIdMatricula;

        IF vExiste = 0 THEN
            SELECT 0 AS Resultado;
        ELSE

            SELECT 
                1 AS Resultado,
                m.IdMatricula,
                m.AnnoLectivo,
                m.FechaMatricula,
                m.NivelSeleccionado,
                m.IdiomaElegido,

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
                en.NombreContactoEmergencia,
                en.TelefonoEmergencia,

                u.IdUsuario,
                u.NombreUsuario,
                u.RolUsuario

            FROM Matricula m
            INNER JOIN Estudiante e ON m.IdEstudiante = e.IdEstudiante
            LEFT JOIN EstudianteEncargado ee ON e.IdEstudiante = ee.IdEstudiante
            LEFT JOIN Encargado en ON ee.IdEncargado = en.IdEncargado
            INNER JOIN Usuario u ON m.IdUsuario = u.IdUsuario
            WHERE m.IdMatricula = pIdMatricula;

        END IF;

    ELSEIF pCedulaEstudiante IS NOT NULL AND pCedulaEstudiante <> '' THEN

        SELECT COUNT(*)
        INTO vExiste
        FROM Matricula m
        INNER JOIN Estudiante e ON m.IdEstudiante = e.IdEstudiante
        WHERE e.CedulaEstudiante = pCedulaEstudiante;

        IF vExiste = 0 THEN
            SELECT 0 AS Resultado;
        ELSE

            SELECT 
                1 AS Resultado,
                m.IdMatricula,
                m.AnnoLectivo,
                m.FechaMatricula,
                m.NivelSeleccionado,
                m.IdiomaElegido,

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
                en.NombreContactoEmergencia,
                en.TelefonoEmergencia,

                u.IdUsuario,
                u.NombreUsuario,
                u.RolUsuario

            FROM Matricula m
            INNER JOIN Estudiante e ON m.IdEstudiante = e.IdEstudiante
            LEFT JOIN EstudianteEncargado ee ON e.IdEstudiante = ee.IdEstudiante
            LEFT JOIN Encargado en ON ee.IdEncargado = en.IdEncargado
            INNER JOIN Usuario u ON m.IdUsuario = u.IdUsuario
            WHERE e.CedulaEstudiante = pCedulaEstudiante;

        END IF;

    ELSE

        SELECT 0 AS Resultado;

    END IF;

END $$

DELIMITER ;

-- =====================================================
-- SP ELIMINAR MATRICULA
-- Elimina por ID de matricula o por cedula de estudiante
-- 0 = no existen matriculas
-- 1 = eliminado correctamente
-- 2 = error de ejecucion
-- =====================================================

DELIMITER $$

CREATE PROCEDURE EliminarMatricula(
    IN pIdMatricula BIGINT,
    IN pCedulaEstudiante VARCHAR(20)
)
BEGIN

    DECLARE vExiste INT DEFAULT 0;
    DECLARE vIdEstudiante INT DEFAULT NULL;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        SELECT 2 AS Resultado;
    END;

    START TRANSACTION;


    IF pIdMatricula IS NOT NULL AND pIdMatricula <> 0 THEN

        SELECT COUNT(*)
        INTO vExiste
        FROM Matricula
        WHERE IdMatricula = pIdMatricula;

        IF vExiste = 0 THEN
            ROLLBACK;
            SELECT 0 AS Resultado;
        ELSE

            DELETE FROM Matricula
            WHERE IdMatricula = pIdMatricula;

            COMMIT;
            SELECT 1 AS Resultado;

        END IF;


    ELSEIF pCedulaEstudiante IS NOT NULL AND pCedulaEstudiante <> '' THEN

        
        SELECT IdEstudiante
        INTO vIdEstudiante
        FROM Estudiante
        WHERE CedulaEstudiante = pCedulaEstudiante
        LIMIT 1;

        IF vIdEstudiante IS NULL THEN
            ROLLBACK;
            SELECT 0 AS Resultado;
        ELSE


            DELETE FROM Matricula
            WHERE IdEstudiante = vIdEstudiante;

            DELETE en
            FROM Encargado en
            INNER JOIN EstudianteEncargado ee 
                ON en.IdEncargado = ee.IdEncargado
            WHERE ee.IdEstudiante = vIdEstudiante
            AND NOT EXISTS (
                SELECT 1
                FROM EstudianteEncargado ee2
                WHERE ee2.IdEncargado = en.IdEncargado
                AND ee2.IdEstudiante <> vIdEstudiante
            );

            DELETE FROM EstudianteEncargado
            WHERE IdEstudiante = vIdEstudiante;

            DELETE FROM Estudiante
            WHERE IdEstudiante = vIdEstudiante;

            COMMIT;
            SELECT 1 AS Resultado;

        END IF;

    ELSE

        ROLLBACK;
        SELECT 0 AS Resultado;

    END IF;

END $$

DELIMITER ;


-- =====================================================
-- SP Listar Matriculas
-- =====================================================

DELIMITER $$

CREATE PROCEDURE ListarMatriculas()
BEGIN

    DECLARE vExiste INT;

    SELECT COUNT(*)
    INTO vExiste
    FROM Matricula;

    IF vExiste = 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        SELECT 
            1 AS Resultado,
            m.IdMatricula,
            m.AnnoLectivo,
            m.FechaMatricula,
            m.NivelSeleccionado,
            m.IdiomaElegido,

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
            en.NombreContactoEmergencia,
            en.TelefonoEmergencia,

            u.IdUsuario,
            u.NombreUsuario,
            u.RolUsuario

        FROM Matricula m
        INNER JOIN Estudiante e 
            ON m.IdEstudiante = e.IdEstudiante
        LEFT JOIN EstudianteEncargado ee 
            ON e.IdEstudiante = ee.IdEstudiante
        LEFT JOIN Encargado en 
            ON ee.IdEncargado = en.IdEncargado
        INNER JOIN Usuario u 
            ON m.IdUsuario = u.IdUsuario

        ORDER BY 
            m.AnnoLectivo DESC,
            m.IdMatricula DESC;

    END IF;

END $$

DELIMITER ;

