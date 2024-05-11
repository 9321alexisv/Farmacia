-- Crear la base de datos "farmacia_candelaria_dev"
--CREATE DATABASE farmacia;

-- Usar la base de datos "farmacia"
--\c farmacia_candelaria_dev;

-- Crear tabla Proveedor
CREATE TABLE proveedor (
    id_proveedor SERIAL,
    empresa VARCHAR(100) NOT NULL,
    telefono VARCHAR(15),
    nit VARCHAR(20) UNIQUE,
    representante VARCHAR(100),
    CONSTRAINT pk_proveedor PRIMARY KEY (id_proveedor)
);

-- Crear tabla Cliente
CREATE TABLE cliente (
    id_cliente SERIAL,
    nombre VARCHAR(100) NOT NULL,
    telefono VARCHAR(15),
    nit VARCHAR(20) UNIQUE,
    CONSTRAINT pk_cliente PRIMARY KEY (id_cliente)
);

-- Crear tabla Producto
CREATE TABLE producto (
    id_producto SERIAL,
    id_proveedor INT NOT NULL,
    nombre VARCHAR(250) NOT NULL,
    precio_compra NUMERIC(10, 2) NOT NULL,
    precio_venta NUMERIC(10, 2) NOT NULL,
    stock INT NOT NULL,
    CONSTRAINT pk_producto PRIMARY KEY (id_producto),
    CONSTRAINT fk_producto_proveedor FOREIGN KEY (id_proveedor) REFERENCES proveedor(id_proveedor)
);

-- Crear tabla Compra
CREATE TABLE compra (
    id_compra SERIAL,
    fecha DATE NOT NULL,
    CONSTRAINT pk_compra PRIMARY KEY (id_compra),
);

-- Crear tabla Detalle Compra
CREATE TABLE detalle_compra (
    id_detalle_compra SERIAL,
    id_compra INT NOT NULL,
    id_producto INT NOT NULL,
    precio_compra NUMERIC(10, 2) NOT NULL,
    precio_venta NUMERIC(10, 2) NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT pk_detallecompra PRIMARY KEY (id_detalle_compra),
    CONSTRAINT fk_detallecompra_compra FOREIGN KEY (id_compra) REFERENCES compra(id_compra),
    CONSTRAINT fk_detallecompra_producto FOREIGN KEY (id_producto) REFERENCES producto(id_producto)
);

-- Crear tabla Venta
CREATE TABLE venta (
    id_venta SERIAL,
    id_cliente INT NOT NULL,
    fecha DATE NOT NULL,
    CONSTRAINT pk_venta PRIMARY KEY (id_venta),
    CONSTRAINT fk_venta_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
);

-- Crear tabla Detalle Venta
CREATE TABLE detalle_venta (
    id_detalle_venta SERIAL,
    id_venta INT NOT NULL,
    id_producto INT NOT NULL,
    precio_venta NUMERIC(10, 2) NOT NULL,
    cantidad INT NOT NULL,
    CONSTRAINT pk_detalleventa PRIMARY KEY (id_detalle_venta),
    CONSTRAINT fk_detalleventa_venta FOREIGN KEY (id_venta) REFERENCES venta(id_venta),
    CONSTRAINT fk_detallevnetas_producto FOREIGN KEY (id_producto) REFERENCES producto(id_producto)
);
