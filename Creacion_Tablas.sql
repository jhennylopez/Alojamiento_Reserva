-- 1. Crear la base de datos (Opcional, si no la has creado aún)
CREATE DATABASE SistemaReservasBD;
GO

USE SistemaReservasBD;
GO

-- 2. Crear tabla ADMINISTRADOR (Independiente)
CREATE TABLE Administrador (
    Id_administrador INT IDENTITY(1,1) PRIMARY KEY,
    Ci VARCHAR(10) UNIQUE NOT NULL,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    correo VARCHAR(150) UNIQUE NOT NULL,
    telefono VARCHAR(20),
    contrasena VARCHAR(255) NOT NULL,
    fecha_registro DATE DEFAULT GETDATE(),

    -- Validación para Cédula Ecuatoriana (10 dígitos exactos, solo números)
    CONSTRAINT CHK_Admin_CI CHECK (LEN(CI) = 10 AND CI NOT LIKE '%[^0-9]%')
);

-- 3. Crear tabla HUESPED (Independiente)
CREATE TABLE Huesped (
    Id_huesped INT IDENTITY(1,1) PRIMARY KEY,
    Ci VARCHAR(10) UNIQUE NOT NULL,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    correo VARCHAR(150) UNIQUE NOT NULL,
    telefono VARCHAR(20),
    contrasena VARCHAR(255) NOT NULL,

    -- Validación para Cédula Ecuatoriana (10 dígitos exactos, solo números)
    CONSTRAINT CHK_Huesped_CI CHECK (LEN(CI) = 10 AND CI NOT LIKE '%[^0-9]%')
);

-- 4. Crear tabla ALOJAMIENTO (Depende de Administrador)
CREATE TABLE Alojamiento (
    Id_alojamiento INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(500),
    ubicacion VARCHAR(255) NOT NULL,
    max_huespedes INT NOT NULL,
    num_habitaciones INT NOT NULL,
    num_banos INT NOT NULL,
    Id_administrador INT NOT NULL,
    
    -- Clave Foránea
    CONSTRAINT FK_Alojamiento_Admin FOREIGN KEY (Id_administrador) 
    REFERENCES Administrador(Id_administrador)
);

-- 5. Crear tabla IMAGEN_ALOJAMIENTO (Depende de Alojamiento)
CREATE TABLE Imagen_Alojamiento (
    Id_imagen INT IDENTITY(1,1) PRIMARY KEY,
    ruta_imagen VARCHAR(500) NOT NULL,
    Id_alojamiento INT NOT NULL,
    
    -- Clave Foránea
    CONSTRAINT FK_Imagen_Alojamiento FOREIGN KEY (Id_alojamiento) 
    REFERENCES Alojamiento(Id_alojamiento) ON DELETE CASCADE
);

-- 6. Crear tabla RESERVA (Depende de Huesped y Alojamiento)
CREATE TABLE Reserva (
    Id_reserva INT IDENTITY(1,1) PRIMARY KEY,
    fecha_ingreso DATE NOT NULL,
    fecha_salida DATE NOT NULL,
    numero_personas INT NOT NULL,
    tipo VARCHAR(50) NOT NULL, -- Ej: 'Completa', 'Compartida', 'Privada'
    Id_huesped INT NOT NULL,
    Id_alojamiento INT NOT NULL,
    
    -- Claves Foráneas
    CONSTRAINT FK_Reserva_Huesped FOREIGN KEY (Id_huesped) 
    REFERENCES Huesped(Id_huesped),
    
    CONSTRAINT FK_Reserva_Alojamiento FOREIGN KEY (Id_alojamiento) 
    REFERENCES Alojamiento(Id_alojamiento),

    -- Validaciones a nivel de base de datos
    CONSTRAINT CHK_Fechas_Reserva CHECK (fecha_salida > fecha_ingreso),
    CONSTRAINT CHK_Personas_Minimas CHECK (numero_personas > 0)
);
GO