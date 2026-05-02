-- Script de creación de base de datos
-- Sistema de Gestión de Empleados
-- Tarea 3 | Christopher Duarte | C12585

CREATE DATABASE GestionEmpleadosDb;
GO

USE GestionEmpleadosDb;
GO

CREATE TABLE Empleados (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(80) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    Departamento NVARCHAR(MAX) NOT NULL,
    Salario DECIMAL(18,2) NOT NULL,
    FechaIngreso DATETIME2 NOT NULL,
    Activo BIT NOT NULL
);
GO

-- Datos iniciales (seed)
INSERT INTO Empleados (Nombre, Apellidos, Departamento, Salario, FechaIngreso, Activo) VALUES
('Ana', 'García López', 'TI', 850000, '2020-03-15', 1),
('Carlos', 'Rodríguez Mora', 'TI', 920000, '2019-07-01', 1),
('María', 'Fernández Castro', 'TI', 780000, '2021-01-10', 1),
('Luis', 'Martínez Pérez', 'Recursos Humanos', 700000, '2018-05-20', 1),
('Sofía', 'Vargas Jiménez', 'Recursos Humanos', 650000, '2022-02-28', 0),
('Pedro', 'Solís Campos', 'Finanzas', 1100000, '2017-09-05', 1),
('Laura', 'Núñez Bravo', 'Finanzas', 980000, '2020-11-03', 1),
('Diego', 'Arias Quesada', 'Ventas', 600000, '2023-04-17', 1),
('Valeria', 'Mora Sandoval', 'Ventas', 580000, '2023-06-01', 0),
('Andrés', 'Blanco Rojas', 'Operaciones', 750000, '2021-08-22', 1);
GO