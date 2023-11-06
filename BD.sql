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
    (1, 'Casa completa', 'Toda la propiedad está disponible para los huéspedes', 'casa-icono'),
    (2, 'Tamaño de 140 m²', 'Superficie de 140 metros cuadrados', 'tamaño-icono'),
    (3, 'Cocina', 'Cocina equipada para preparar alimentos', 'cocina-icono'),
    (4, 'Vista', 'Vistas escénicas o panorámicas', 'vista-icono'),
    (5, 'Jardín', 'Espacio al aire libre con jardín', 'jardin-icono'),
    (6, 'Piscina al aire libre', 'Piscina ubicada al aire libre', 'piscina-icono'),
    (7, 'Instalaciones para barbacoa', 'Área habilitada para hacer barbacoas', 'bbq-icono'),
    (8, 'Lavadora', 'Lavadora disponible para uso de los huéspedes', 'lavadora-icono'),
    (9, 'WiFi gratuito', 'Acceso gratuito a Internet inalámbrico', 'wifi-icono'),
    (10, 'Terraza', 'Espacio al aire libre para relajarse', 'terraza-icono'),
    (11, 'Aire acondicionado', 'Propiedad con sistema de aire acondicionado', 'aire-icono'),
    (12, 'TV de pantalla plana', 'Televisor con pantalla plana y variedad de canales', 'tv-icono'),
    (13, 'Estacionamiento gratuito', 'Estacionamiento disponible sin costo adicional', 'parking-icono'),
    (14, 'Baño privado', 'Habitación con baño exclusivo', 'bano-icono'),
    (15, 'Desayuno incluido', 'Desayuno proporcionado como parte del hospedaje', 'desayuno-icono'),
    (16, 'Acceso para personas con movilidad reducida', 'Instalaciones adaptadas para personas con movilidad reducida', 'movilidad-icono'),
    (17, 'Recepción 24 horas', 'Recepción disponible durante todo el día', 'recepcion-icono');

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