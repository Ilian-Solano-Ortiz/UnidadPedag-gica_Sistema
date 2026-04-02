-- =====================================================
-- SP's - Usuarios
-- =====================================================


-- =====================================================
-- SP REGISTRAR USUARIO
-- 0 = usuario ya existe
-- 1 = usuario creado
-- =====================================================
-- CondicionAceptacion
-- PENDIENTE
-- ACEPTADO
-- RECHAZADO
-- =====================================================
-- CondicionLogin
-- CONECTADO
-- DESCONECTADO
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
            CondicionAceptacion,
            CondicionLogin
        )
        VALUES(
            pCedulaUsuario,
            pNombreUsuario,
            pContrasenaUsuario,
            pRolUsuario,
            "PENDIENTE",
            "DESCONECTADO"
        );

        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;


-- =====================================================
-- SP LOGIN USUARIO
-- 0 = usuario no existe
-- 1 = contraseña incorrecta
-- 2 = login correcto
-- 3 = usuario pendiente de aprobación
-- 4 = LoginUsuariousuario rechazado
-- 5 = Usuario ya conectado
-- =====================================================

DELIMITER $$
CREATE PROCEDURE LoginUsuario(
    IN pCedulaUsuario VARCHAR(20),
    IN pContrasenaUsuario VARCHAR(255)
)
BEGIN

    DECLARE vContrasena VARCHAR(255);
    DECLARE vEstadoAceptacion VARCHAR(30);
    DECLARE vEstadoLogin VARCHAR(30);
	DECLARE vRol VARCHAR(30);
    
    SELECT 
        ContrasenaUsuario, 
        CondicionAceptacion,
        CondicionLogin,
        RolUsuario
    INTO 
        vContrasena, 
        vEstadoAceptacion,
        vEstadoLogin,
        vRol
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario
    LIMIT 1;

    IF vContrasena IS NULL THEN
        SELECT 0 AS Resultado;
	ELSEIF vRol = 'Administrador' THEN
        IF vContrasena <> pContrasenaUsuario THEN
            SELECT 1 AS Resultado;
        ELSE
            UPDATE Usuario
            SET CondicionLogin = 'CONECTADO'
            WHERE CedulaUsuario = pCedulaUsuario;
            SELECT 2 AS Resultado;
        END IF;
        
    ELSEIF vEstadoAceptacion = 'PENDIENTE' THEN

        SELECT 3 AS Resultado;

    ELSEIF vEstadoAceptacion = 'RECHAZADO' THEN

        SELECT 4 AS Resultado;

    ELSEIF vEstadoLogin = 'CONECTADO' THEN

        SELECT 5 AS Resultado;

    ELSEIF vContrasena <> pContrasenaUsuario THEN

        SELECT 1 AS Resultado;

    ELSE

        UPDATE Usuario
        SET CondicionLogin = 'CONECTADO'
        WHERE CedulaUsuario = pCedulaUsuario;

        SELECT 2 AS Resultado;

    END IF;

END $$

DELIMITER ;


-- =====================================================
-- SP LOGOUT USUARIO
-- =====================================================

DELIMITER $$

CREATE PROCEDURE LogoutUsuario(
    IN pCedulaUsuario VARCHAR(20)
)
BEGIN

    UPDATE Usuario
    SET CondicionLogin = 'DESCONECTADO'
    WHERE CedulaUsuario = pCedulaUsuario;

    SELECT 1 AS Resultado;

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
        SET CondicionAceptacion = "ACEPTADO"
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
        SET CondicionAceptacion = "RECHAZADO"
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
        ContrasenaUsuario,
        RolUsuario,
        CondicionAceptacion,
        CondicionLogin
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario
    LIMIT 1;

END $$

DELIMITER ;


-- =====================================================
-- SP MODIFICAR USUARIO
-- 0 = Usuario no existe
-- 1 = Actualizado
-- 2 = Cedula nueva ya existe
-- =====================================================

DELIMITER $$

CREATE PROCEDURE ModificarUsuario(
    IN pCedulaActual VARCHAR(20),
    IN pNuevaCedula VARCHAR(20),
    IN pNombreUsuario VARCHAR(50),
    IN pRolUsuario VARCHAR(30)
)
BEGIN

    DECLARE vExiste INT;

    SELECT COUNT(*)
    INTO vExiste
    FROM Usuario
    WHERE CedulaUsuario = pCedulaActual;

    IF vExiste = 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        IF pNuevaCedula IS NOT NULL AND pNuevaCedula <> '' THEN

            IF EXISTS (
                SELECT 1 
                FROM Usuario 
                WHERE CedulaUsuario = pNuevaCedula
                AND CedulaUsuario <> pCedulaActual
            ) THEN

                SELECT 2 AS Resultado;
                LEAVE proc;

            END IF;

        END IF;

        UPDATE Usuario
        SET
            CedulaUsuario = IF(pNuevaCedula IS NULL OR pNuevaCedula = '', CedulaUsuario, pNuevaCedula),
            NombreUsuario = IF(pNombreUsuario IS NULL OR pNombreUsuario = '', NombreUsuario, pNombreUsuario),
            RolUsuario = IF(pRolUsuario IS NULL OR pRolUsuario = '', RolUsuario, pRolUsuario)
        WHERE CedulaUsuario = pCedulaActual;

        SELECT 1 AS Resultado;

    END IF;

END $$

DELIMITER ;


-- =====================================================
-- SP ELIMINAR USUARIO
-- 0 = Usuario no existe
-- 1 = Eliminado correctamente
-- 2 = Usuario esta logeado
-- =====================================================

DELIMITER $$

CREATE PROCEDURE EliminarUsuario(
    IN pCedulaUsuario VARCHAR(20)
)
BEGIN

    DECLARE vExiste INT;
    DECLARE vEstadoLogin VARCHAR(30);

    SELECT COUNT(*)
    INTO vExiste
    FROM Usuario
    WHERE CedulaUsuario = pCedulaUsuario;

    IF vExiste = 0 THEN

        SELECT 0 AS Resultado;

    ELSE

        SELECT CondicionLogin
        INTO vEstadoLogin
        FROM Usuario
        WHERE CedulaUsuario = pCedulaUsuario;

        IF vEstadoLogin = 'CONECTADO' THEN

            SELECT 2 AS Resultado;

        ELSE

            DELETE FROM Usuario
            WHERE CedulaUsuario = pCedulaUsuario;

            SELECT 1 AS Resultado;

        END IF;

    END IF;

END $$

DELIMITER ;



