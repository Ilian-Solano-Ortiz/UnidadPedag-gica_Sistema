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

    DECLARE vIdEstudiante INT;
    DECLARE vExiste INT;

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
                en.TelefonoEmergencia

            FROM EstudianteEncargado ee
            INNER JOIN Encargado en 
                ON ee.IdEncargado = en.IdEncargado
            WHERE ee.IdEstudiante = vIdEstudiante;

        END IF;

    END IF;

END $$

DELIMITER ;

