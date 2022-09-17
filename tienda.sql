CREATE DATABASE tienda;
USE tienda;
CREATE TABLE producto(
idproducto INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
descripcion VARCHAR(100),
precio VARCHAR(20)
);

delimiter ;;
CREATE PROCEDURE insertarproducto(
IN _nombre VARCHAR(100),
IN _descripcion VARCHAR(100),
IN _precio VARCHAR(20),
IN _idproducto INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM producto WHERE nombre = _nombre INTO X;
if x=0 AND _idproducto < 0 then 
INSERT INTO producto VALUES(NULL,_nombre,_descripcion,_precio);
ELSE if x=0 AND _idproducto > 0 then
UPDATE producto SET nombre=_nombre,descripcion=_descripcion,precio=_precio WHERE idproducto=_idproducto;
ELSE
UPDATE producto SET nombre=_nombre WHERE idproducto=_idproducto;
END if;
END if;
END;;

DELETE PROCEDURE insertarproducto;

CALL insertarproducto('Galletas','sabor fresa','15',-1);
CALL insertarproducto('Agua','20 lrts','40',-1);


SELECT * FROM producto;

delimiter ;;
CREATE PROCEDURE deleteproducto(
IN _idproducto INT )
BEGIN 
DELETE FROM producto WHERE idproducto = _idproducto;
END;;
delet

delimiter ;;
CREATE PROCEDURE showproducto(
IN _nombre VARCHAR(50))
BEGIN 
SELECT * FROM producto WHERE nombre  LIKE _nombre ORDER BY nombre;
END;;
CALL showproducto('Galletas');
