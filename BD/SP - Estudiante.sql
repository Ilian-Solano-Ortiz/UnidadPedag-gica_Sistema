-- =====================================================
-- SP´s - Estudiante
-- =====================================================


-- =====================================================
-- SP - Obterner Encargados por estudiante
-- 0 = estudiante no existe o estudiante existe pero no tiene encargados
-- estudiante existe y tiene encargados
-- =====================================================

DELIMITER $$

CREATE PROCEDURE ObtenerEncargadosPorCedula(
    IN pCedulaEstudiante VARCHAR(20)
)
BEGIN

    DECLARE vIdEstudiante INT DEFAULT NULL;
    DECLARE vExiste INT DEFAULT 0;        

    -- Buscar el estudiante
    SELECT IdEstudiante
    INTO vIdEstudiante
    FROM Estudiante
    WHERE CedulaEstudiante = pCedulaEstudiante
    LIMIT 1;

    IF vIdEstudiante IS NULL THEN

        SELECT 0 AS Resultado;

    ELSE

        SELECT COUNT(*)
        INTO vExiste
        FROM EstudianteEncargado
        WHERE IdEstudiante = vIdEstudiante;

        IF vExiste = 0 THEN

            SELECT 0 AS Resultado;

        ELSE

            SELECT 
                en.IdEncargado,
                en.CedulaEncargado,
                en.NombreEncargado,
                en.TelefonoEncargado,
                en.Parentesco,
                en.LugarTrabajo,
                en.Correo,
                en.NombreContactoEmergencia,
                en.TelefonoContactoEmergencia

            FROM EstudianteEncargado ee
            INNER JOIN Encargado en 
                ON ee.IdEncargado = en.IdEncargado
            WHERE ee.IdEstudiante = vIdEstudiante;

        END IF;

    END IF;

END $$

DELIMITER ;

-- =====================================================
-- SP - Obterner datos estudiante
-- 0 = estudiante no existe o estudiante existe pero no tiene encargados
-- estudiante existe y tiene encargados
-- =====================================================

DELIMITER $$

CREATE PROCEDURE ObtenerEstudiante(
    IN pCedulaEstudiante VARCHAR(20)
)
BEGIN

    DECLARE vExiste INT;

    -- Verificar existencia
    SELECT COUNT(*)
    INTO vExiste
    FROM Estudiante
    WHERE CedulaEstudiante = pCedulaEstudiante;

    IF vExiste = 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        SELECT 
            IdEstudiante,
            CedulaEstudiante,
            NombreEstudiante,
            FechaNacimiento,
            Direccion
        FROM Estudiante
        WHERE CedulaEstudiante = pCedulaEstudiante;

    END IF;

END $$

DELIMITER ;


USE BD_Unidad_Pedagogica_Sistema;
DELIMITER $$

CREATE PROCEDURE RegistrarEstudianteExcel(
    IN pCedulaEstudiante VARCHAR(20),
    IN pNombreEstudiante VARCHAR(100),
    IN pDireccion VARCHAR(200),

    IN pCedulaEncargado VARCHAR(20),
    IN pNombreEncargado VARCHAR(100),
    IN pTelefonoEncargado VARCHAR(15)
)
BEGIN

    DECLARE vIdEstudiante INT;
    DECLARE vIdEncargado INT;
    DECLARE vExiste INT;

    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        SELECT 2 AS Resultado;
    END;

    START TRANSACTION;

    -- =========================
    -- VALIDAR ESTUDIANTE
    -- =========================
    SELECT IdEstudiante
    INTO vIdEstudiante
    FROM Estudiante
    WHERE CedulaEstudiante = pCedulaEstudiante
    LIMIT 1;

    IF vIdEstudiante IS NOT NULL THEN

        ROLLBACK;
        SELECT 0 AS Resultado;

    ELSE

        -- Insertar estudiante
        INSERT INTO Estudiante (
            CedulaEstudiante,
            NombreEstudiante,
            FechaNacimiento,
            Direccion
        )
        VALUES (
            pCedulaEstudiante,
            pNombreEstudiante,
            '', -- porque no viene en Excel
            pDireccion
        );

        SET vIdEstudiante = LAST_INSERT_ID();

        -- =========================
        -- VALIDAR ENCARGADO
        -- =========================
        SELECT IdEncargado
        INTO vIdEncargado
        FROM Encargado
        WHERE CedulaEncargado = pCedulaEncargado
        LIMIT 1;

        IF vIdEncargado IS NULL THEN

            INSERT INTO Encargado (
                CedulaEncargado,
                NombreEncargado,
                TelefonoEncargado,
                Parentesco,
                LugarTrabajo,
                Correo,
                NombreContactoEmergencia,
                TelefonoContactoEmergencia
            )
            VALUES (
                pCedulaEncargado,
                pNombreEncargado,
                pTelefonoEncargado,
                'No especificado',
                'No especificado',
                'No especificado',
                pNombreEncargado,
                pTelefonoEncargado
            );

            SET vIdEncargado = LAST_INSERT_ID();

        END IF;

        -- =========================
        -- RELACION
        -- =========================
        SELECT COUNT(*)
        INTO vExiste
        FROM EstudianteEncargado
        WHERE IdEstudiante = vIdEstudiante
        AND IdEncargado = vIdEncargado;

        IF vExiste = 0 THEN

            INSERT INTO EstudianteEncargado (
                IdEstudiante,
                IdEncargado
            )
            VALUES (
                vIdEstudiante,
                vIdEncargado
            );

        END IF;

        COMMIT;
        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;



