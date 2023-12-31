-- Crear la base de datos
CREATE DATABASE ProyectoBD;

use ProyectoBD;

-- Crear la tabla 'rol'
CREATE TABLE rol (
    ID INT PRIMARY KEY,
    nombre VARCHAR(25) NOT NULL);

	-- Insert a la tabla 'rol'

insert into rol (ID, nombre)
VALUES  
(1, 'Administrador'),
(2, 'Usuario');

	-- Crear la tabla 'paises'

CREATE TABLE paises(
    ID INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Codigo CHAR(3));

	-- Insert a la tabla 'paises'

INSERT INTO paises (ID, Nombre, Codigo) VALUES 
(1,'Afghanistan','AFG'),
(2,'Aland Islands','ALA'),
(3,'Albania','ALB'),
(4,'Algeria','DZA'),
(5,'American Samoa','ASM'),
(6,'Andorra','AND'),
(7,'Angola','AGO'),
(8,'Anguilla','AIA'),
(9,'Antarctica','ATA'),
(10,'Antigua and Barbuda','ATG'),
(11,'Argentina','ARG'),
(12,'Armenia','ARM'),
(13,'Aruba','ABW'),
(14,'Australia','AUS'),
(15,'Austria','AUT'),
(16,'Azerbaijan','AZE'),
(17,'Bahamas','BHS'),
(18,'Bahrain','BHR'),
(19,'Bangladesh','BGD'),
(20,'Barbados','BRB'),
(21,'Belarus','BLR'),
(22,'Belgium','BEL'),
(23,'Belize','BLZ'),
(24,'Benin','BEN'),
(25,'Bermuda','BMU'),
(26,'Bhutan','BTN'),
(27,'Bolivia','BOL'),
(28,'Bonaire, Sint Eustatius and Saba','BES'),
(29,'Bosnia and Herzegovina','BIH'),
(30,'Botswana','BWA'),
(31,'Bouvet Island','BVT'),
(32,'Brazil','BRA'),
(33,'British Indian Ocean Territory','IOT'),
(34,'Brunei','BRN'),
(35,'Bulgaria','BGR'),
(36,'Burkina Faso','BFA'),
(37,'Burundi','BDI'),
(38,'Cambodia','KHM'),
(39,'Cameroon','CMR'),
(40,'Canada','CAN'),
(41,'Cape Verde','CPV'),
(42,'Cayman Islands','CYM'),
(43,'Central African Republic','CAF'),
(44,'Chad','TCD'),
(45,'Chile','CHL'),
(46,'China','CHN'),
(47,'Christmas Island','CXR'),
(48,'Cocos (Keeling) Islands','CCK'),
(49,'Colombia','COL'),
(50,'Comoros','COM'),
(51,'Congo','COG'),
(52,'Cook Islands','COK'),
(53,'Costa Rica','CRI'),
(54,'Ivory Coast','CIV'),
(55,'Croatia','HRV'),
(56,'Cuba','CUB'),
(57,'Curacao','CUW'),
(58,'Cyprus','CYP'),
(59,'Czech Republic','CZE'),
(60,'Democratic Republic of the Congo','COD'),
(61,'Denmark','DNK'),
(62,'Djibouti','DJI'),
(63,'Dominica','DMA'),
(64,'Dominican Republic','DOM'),
(65,'Ecuador','ECU'),
(66,'Egypt','EGY'),
(67,'El Salvador','SLV'),
(68,'Equatorial Guinea','GNQ'),
(69,'Eritrea','ERI'),
(70,'Estonia','EST'),
(71,'Ethiopia','ETH'),
(72,'Falkland Islands (Malvinas)','FLK'),
(73,'Faroe Islands','FRO'),
(74,'Fiji','FJI'),
(75,'Finland','FIN'),
(76,'France','FRA'),
(77,'French Guiana','GUF'),
(78,'French Polynesia','PYF'),
(79,'French Southern Territories','ATF'),
(80,'Gabon','GAB'),
(81,'Gambia','GMB'),
(82,'Georgia','GEO'),
(83,'Germany','DEU'),
(84,'Ghana','GHA'),
(85,'Gibraltar','GIB'),
(86,'Greece','GRC'),
(87,'Greenland','GRL'),
(88,'Grenada','GRD'),
(89,'Guadaloupe','GLP'),
(90,'Guam','GUM'),
(91,'Guatemala','GTM'),
(92,'Guernsey','GGY'),
(93,'Guinea','GIN'),
(94,'Guinea-Bissau','GNB'),
(95,'Guyana','GUY'),
(96,'Haiti','HTI'),
(97,'Heard Island and McDonald Islands','HMD'),
(98,'Honduras','HND'),
(99,'Hong Kong','HKG'),
(100,'Hungary','HUN'),
(101,'Iceland','ISL'),
(102,'India','IND'),
(103,'Indonesia','IDN'),
(104,'Iran','IRN'),
(105,'Iraq','IRQ'),
(106,'Ireland','IRL'),
(107,'Isle of Man','IMN'),
(108,'Israel','ISR'),
(109,'Italy','ITA'),
(110,'Jamaica','JAM'),
(111,'Japan','JPN'),
(112,'Jersey','JEY'),
(113,'Jordan','JOR'),
(114,'Kazakhstan','KAZ'),
(115,'Kenya','KEN'),
(116,'Kiribati','KIR'),
(117,'Kosovo','---'),
(118,'Kuwait','KWT'),
(119,'Kyrgyzstan','KGZ'),
(120,'Laos','LAO'),
(121,'Latvia','LVA'),
(122,'Lebanon','LBN'),
(123,'Lesotho','LSO'),
(124,'Liberia','LBR'),
(125,'Libya','LBY'),
(126,'Liechtenstein','LIE'),
(127,'Lithuania','LTU'),
(128,'Luxembourg','LUX'),
(129,'Macao','MAC'),
(130,'Macedonia','MKD'),
(131,'Madagascar','MDG'),
(132,'Malawi','MWI'),
(133,'Malaysia','MYS'),
(134,'Maldives','MDV'),
(135,'Mali','MLI'),
(136,'Malta','MLT'),
(137,'Marshall Islands','MHL'),
(138,'Martinique','MTQ'),
(139,'Mauritania','MRT'),
(140,'Mauritius','MUS'),
(141,'Mayotte','MYT'),
(142,'Mexico','MEX'),
(143,'Micronesia','FSM'),
(144,'Moldava','MDA'),
(145,'Monaco','MCO'),
(146,'Mongolia','MNG'),
(147,'Montenegro','MNE'),
(148,'Montserrat','MSR'),
(149,'Morocco','MAR'),
(150,'Mozambique','MOZ'),
(151,'Myanmar (Burma)','MMR'),
(152,'Namibia','NAM'),
(153,'Nauru','NRU'),
(154,'Nepal','NPL'),
(155,'Netherlands','NLD'),
(156,'New Caledonia','NCL'),
(157,'New Zealand','NZL'),
(158,'Nicaragua','NIC'),
(159,'Niger','NER'),
(160,'Nigeria','NGA'),
(161,'Niue','NIU'),
(162,'Norfolk Island','NFK'),
(163,'North Korea','PRK'),
(164,'Northern Mariana Islands','MNP'),
(165,'Norway','NOR'),
(166,'Oman','OMN'),
(167,'Pakistan','PAK'),
(168,'Palau','PLW'),
(169,'Palestine','PSE'),
(170,'Panama','PAN'),
(171,'Papua New Guinea','PNG'),
(172,'Paraguay','PRY'),
(173,'Peru','PER'),
(174,'Phillipines','PHL'),
(175,'Pitcairn','PCN'),
(176,'Poland','POL'),
(177,'Portugal','PRT'),
(178,'Puerto Rico','PRI'),
(179,'Qatar','QAT'),
(180,'Reunion','REU'),
(181,'Romania','ROU'),
(182,'Russia','RUS'),
(183,'Rwanda','RWA'),
(184,'Saint Barthelemy','BLM'),
(185,'Saint Helena','SHN'),
(186,'Saint Kitts and Nevis','KNA'),
(187,'Saint Lucia','LCA'),
(188,'Saint Martin','MAF'),
(189,'Saint Pierre and Miquelon','SPM'),
(190,'Saint Vincent and the Grenadines','VCT'),
(191,'Samoa','WSM'),
(192,'San Marino','SMR'),
(193,'Sao Tome and Principe','STP'),
(194,'Saudi Arabia','SAU'),
(195,'Senegal','SEN'),
(196,'Serbia','SRB'),
(197,'Seychelles','SYC'),
(198,'Sierra Leone','SLE'),
(199,'Singapore','SGP'),
(200,'Sint Maarten','SXM'),
(201,'Slovakia','SVK'),
(202,'Slovenia','SVN'),
(203,'Solomon Islands','SLB'),
(204,'Somalia','SOM'),
(205,'South Africa','ZAF'),
(206,'South Georgia and the South Sandwich Islands','SGS'),
(207,'South Korea','KOR'),
(208,'South Sudan','SSD'),
(209,'Spain','ESP'),
(210,'Sri Lanka','LKA'),
(211,'Sudan','SDN'),
(212,'Suriname','SUR'),
(213,'Svalbard and Jan Mayen','SJM'),
(214,'Swaziland','SWZ'),
(215,'Sweden','SWE'),
(216,'Switzerland','CHE'),
(217,'Syria','SYR'),
(218,'Taiwan','TWN'),
(219,'Tajikistan','TJK'),
(220,'Tanzania','TZA'),
(221,'Thailand','THA'),
(222,'Timor-Leste (East Timor)','TLS'),
(223,'Togo','TGO'),
(224,'Tokelau','TKL'),
(225,'Tonga','TON'),
(226,'Trinidad and Tobago','TTO'),
(227,'Tunisia','TUN'),
(228,'Turkey','TUR'),
(229,'Turkmenistan','TKM'),
(230,'Turks and Caicos Islands','TCA'),
(231,'Tuvalu','TUV'),
(232,'Uganda','UGA'),
(233,'Ukraine','UKR'),
(234,'United Arab Emirates','ARE'),
(235,'United Kingdom','GBR'),
(236,'United States','USA'),
(237,'United States Minor Outlying Islands','UMI'),
(238,'Uruguay','URY'),
(239,'Uzbekistan','UZB'),
(240,'Vanuatu','VUT'),
(241,'Vatican City','VAT'),
(242,'Venezuela','VEN'),
(243,'Vietnam','VNM'),
(244,'Virgin Islands, British','VGB'),
(245,'Virgin Islands, US','VIR'),
(246,'Wallis and Futuna','WLF'),
(247,'Western Sahara','ESH'),
(248,'Yemen','YEM'),
(249,'Zambia','ZMB'),
(250,'Zimbabwe','ZWE');


-- Crear la tabla 'amenidades'
CREATE TABLE amenidades (
    ID INT PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
	icono varchar(100) DEFAULT NULL
);

-- Inserts de la tabla 'amenidades'

INSERT INTO amenidades (ID, nombre, descripcion, icono) 
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

-- Crear la tabla 'estado'
CREATE TABLE estado (
    ID INT PRIMARY KEY,
    nombre VARCHAR(25) NOT NULL);

-- Insert a la tabla 'estado'

insert into estado (ID, nombre)
VALUES  
(0, 'Inactivo'),
(2, 'Activo'),
(3, 'Mantenimiento'),
(4, 'Completado'),
(5, 'Atrasado');


-- Crear la tabla 'usuarios'
CREATE TABLE usuarios (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(10) NOT NULL,
    nombre VARCHAR(25) NOT NULL,
    apellidos VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    contrasenna VARCHAR(12) NOT NULL,
	IdEstado INT DEFAULT 1,
    IdRol INT DEFAULT 2,
    FOREIGN KEY (IdRol) REFERENCES rol(ID),
	FOREIGN KEY (IdEstado) REFERENCES estado(ID));


-- Crear la tabla 'destino'
CREATE TABLE destino (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    pais VARCHAR(255) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
    precio MONEY,
    imagen VARCHAR(255), 
	IdEstado INT DEFAULT 1,
	FOREIGN KEY (IdEstado) REFERENCES estado(ID));

		-- Crear la tabla 'hoteles'
CREATE TABLE hoteles (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    descripcion VARCHAR(255) NOT NULL,
    precio MONEY NOT NULL,
    imagen VARCHAR(255) NOT NULL,
	IdPais int,
	IdAmenidades Int,
	IdEstado INT DEFAULT 1,
	FOREIGN KEY (IdEstado) REFERENCES estado(ID),
    FOREIGN KEY (IdAmenidades) REFERENCES amenidades(ID),
    FOREIGN KEY (IdPais) REFERENCES Paises(ID));

	-- Crear la tabla 'carro'
CREATE TABLE carros (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    marca VARCHAR(255) NOT NULL,
    modelo VARCHAR(255) NOT NULL,
    annio INT NOT NULL,
    imagen VARCHAR(255),
    precio MONEY,
	IdEstado INT DEFAULT 1,
	IdPais int,
	FOREIGN KEY (IdEstado) REFERENCES estado(ID),
	FOREIGN KEY (IdPais) REFERENCES Paises(ID));

		-- Crear la tabla 'vuelos'
CREATE TABLE vuelos (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATE NOT NULL,
	precio MONEY,
	IdEstado INT DEFAULT 1,
	IdPais int,
	FOREIGN KEY (IdEstado) REFERENCES estado(ID),
	FOREIGN KEY (IdPais) REFERENCES paises(ID));

		-- Crear la tabla 'tours'
CREATE TABLE tours (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
	descripcion VARCHAR(255) NOT NULL,
	imagen VARCHAR(255),
	precio MONEY,
	IdEstado INT DEFAULT 1,
	IdPais int,
	IdDestino BIGINT,
	FOREIGN KEY (IdEstado) REFERENCES estado(ID),
	FOREIGN KEY (IdDestino) REFERENCES destino(ID),
	FOREIGN KEY (IdPais) REFERENCES paises(ID));

	-- Crear la tabla 'reserva Hoteles'
CREATE TABLE reservaHoteles (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    IdHotel BIGINT NOT NULL,
	Fecha DATE NOT NULL,
    FOREIGN KEY (IdHotel) REFERENCES hoteles(ID)
);

-- Crear la tabla 'reserva Carros'
CREATE TABLE reservaCarros (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    IdCarro BIGINT NOT NULL,
	Fecha DATE NOT NULL,
    FOREIGN KEY (IdCarro) REFERENCES carros(ID)
);

-- Crear la tabla 'reserva Vuelos'
CREATE TABLE reservaVuelos (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    IdVuelos BIGINT NOT NULL,
	Fecha DATE NOT NULL,
    FOREIGN KEY (IdVuelos) REFERENCES vuelos(ID)
);

-- Crear la tabla 'reserva Tours'
CREATE TABLE reservaTours (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    IdTours BIGINT NOT NULL,
	Fecha DATE NOT NULL,
    FOREIGN KEY (IdTours) REFERENCES tours(ID)
);

		-- Crear la tabla 'rese�as'
CREATE TABLE resennas (
    ID BIGINT IDENTITY(1,1) PRIMARY KEY,
    titulo VARCHAR(255) NOT NULL,
	descripcion VARCHAR(255) NOT NULL,
    puntuacion DECIMAL(3, 2) NOT NULL,
	IdUser BIGINT,
	IdHotel BIGINT,
	FOREIGN KEY (IdUser) REFERENCES usuarios(ID),
	FOREIGN KEY (IdHotel) REFERENCES hoteles(ID));

select * from usuarios
select * from hoteles
select * from carros
select * from vuelos
select * from reservaHoteles
select * from reservaCarros
select * from reservaVuelos
select * from reservaTours

