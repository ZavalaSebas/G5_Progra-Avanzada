-- Crear la base de datos
CREATE DATABASE ProyectoBD;

use ProyectoBD;

-- Crear la tabla 'rol'
CREATE TABLE rol (
    ID BIGINT PRIMARY KEY,
    nombre VARCHAR(25) NOT NULL
);

insert into rol (ID, nombre)
VALUES  
(1, 'Administrador'),
(2, 'Usuario');

-- Crear la tabla 'usuarios'
CREATE TABLE usuarios (
    IDUser BIGINT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(10) NOT NULL,
    nombre VARCHAR(25) NOT NULL,
    apellidos VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    contrasenna VARCHAR(12) NOT NULL,
	estado BIT DEFAULT 1 NOT NULL,
    IDRol BIGINT DEFAULT 2,
    FOREIGN KEY (IDRol) REFERENCES rol(ID)
);


-- Crear la tabla 'destino'
CREATE TABLE destino (
    IDDestino BIGINT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    pais VARCHAR(255) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
    precio MONEY,
    imagen VARCHAR(255)
);

-- Crear la tabla 'reserva'
CREATE TABLE reserva (
    ID BIGINT PRIMARY KEY,
    TIPO INT NOT NULL,
    IDUser BIGINT NOT NULL,
    IDDestino BIGINT NOT NULL,
    salida DATE NOT NULL,
    entrada DATE NOT NULL,
    FOREIGN KEY (IDUser) REFERENCES usuarios(IDUser),
    FOREIGN KEY (IDDestino) REFERENCES destino(IDDestino)
);

-- Crear la tabla 'reservaCarro'
CREATE TABLE reservaCarro (
    IDCarro BIGINT PRIMARY KEY NOT NULL,
    IDReserva BIGINT NOT NULL,
    FOREIGN KEY (IDReserva) REFERENCES reserva(ID)
);

-- Crear la tabla 'reservaHotel'
CREATE TABLE reservaHotel (
    IDHotel BIGINT PRIMARY KEY NOT NULL,
    IDReserva BIGINT NOT NULL,
    FOREIGN KEY (IDReserva) REFERENCES reserva(ID)
);

-- Crear la tabla 'carro'
CREATE TABLE carro (
    ID BIGINT PRIMARY KEY NOT NULL,
    marca VARCHAR(255) NOT NULL,
    modelo VARCHAR(255) NOT NULL,
    annio INT NOT NULL,
    imagen VARCHAR(255),
    precio MONEY,
    disponibilidad BIT
);

-- Crear la tabla 'amenidades'
CREATE TABLE amenidades (
    IDAmenidades INT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
	icono varchar(100) DEFAULT NULL
);

-- Inserts de la tabla 'amenidades'

INSERT INTO amenidades (IDAmenidades, nombre, descripcion, icono) 
VALUES
    (1, 'Casa completa', 'Toda la propiedad est� disponible para los hu�spedes', 'casa-icono'),
    (2, 'Tama�o de 140 m�', 'Superficie de 140 metros cuadrados', 'tama�o-icono'),
    (3, 'Cocina', 'Cocina equipada para preparar alimentos', 'cocina-icono'),
    (4, 'Vista', 'Vistas esc�nicas o panor�micas', 'vista-icono'),
    (5, 'Jard�n', 'Espacio al aire libre con jard�n', 'jardin-icono'),
    (6, 'Piscina al aire libre', 'Piscina ubicada al aire libre', 'piscina-icono'),
    (7, 'Instalaciones para barbacoa', '�rea habilitada para hacer barbacoas', 'bbq-icono'),
    (8, 'Lavadora', 'Lavadora disponible para uso de los hu�spedes', 'lavadora-icono'),
    (9, 'WiFi gratuito', 'Acceso gratuito a Internet inal�mbrico', 'wifi-icono'),
    (10, 'Terraza', 'Espacio al aire libre para relajarse', 'terraza-icono'),
    (11, 'Aire acondicionado', 'Propiedad con sistema de aire acondicionado', 'aire-icono'),
    (12, 'TV de pantalla plana', 'Televisor con pantalla plana y variedad de canales', 'tv-icono'),
    (13, 'Estacionamiento gratuito', 'Estacionamiento disponible sin costo adicional', 'parking-icono'),
    (14, 'Ba�o privado', 'Habitaci�n con ba�o exclusivo', 'bano-icono'),
    (15, 'Desayuno incluido', 'Desayuno proporcionado como parte del hospedaje', 'desayuno-icono'),
    (16, 'Acceso para personas con movilidad reducida', 'Instalaciones adaptadas para personas con movilidad reducida', 'movilidad-icono'),
    (17, 'Recepci�n 24 horas', 'Recepci�n disponible durante todo el d�a', 'recepcion-icono');

	-- Crear la tabla 'hoteles'
CREATE TABLE hoteles (
    ID INT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    pais VARCHAR(255) NOT NULL,
    puntuacion DECIMAL(3, 2) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
    precio MONEY NOT NULL,
    imagen VARCHAR(255) NOT NULL,
	IdAmenidades Int,
    FOREIGN KEY (IdAmenidades) REFERENCES amenidades(IDAmenidades)
);


select * from usuarios

select * from hoteles