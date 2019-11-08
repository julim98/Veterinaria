--CREATE DATABASE _BD_VETERINARIA;
USE _BD_VETERINARIA;
CREATE TABLE laboratorios (
   id_laboratorio int IDENTITY (0, 1) PRIMARY KEY,
   razon_social varchar(15) NOT NULL,
   direccion varchar(20) NOT NULL
);

CREATE TABLE due�os (
   id_due�o int IDENTITY (0, 1) PRIMARY KEY,
   nombre varchar(15) NOT NULL,
   apellido varchar(15) NOT NULL,
   telefono int
);

CREATE TABLE vacunas (
   id_vacuna int IDENTITY (0, 1) PRIMARY KEY,
   descripcion text
);

CREATE TABLE sintomas (
   id_sintoma int IDENTITY (0, 1) PRIMARY KEY,
   descripcion text
);

CREATE TABLE diagnosticos (
   id_diagnostico int IDENTITY (0, 1) PRIMARY KEY,
   descripcion text
);

CREATE TABLE razas (
   id_raza int IDENTITY (0, 1) PRIMARY KEY,
   denominacion varchar(20) NOT NULL,   
   nota_cuidados text   
);

CREATE TABLE medicamentos (
   id_medicamento int IDENTITY (0, 1) PRIMARY KEY,
   nombre_med varchar(15) NOT NULL,
   id_laboratorio int NOT NULL,
   descripcion text,   
   fecha_ultima_compra date,
   FOREIGN KEY (id_laboratorio) REFERENCES laboratorios(id_laboratorio)
);

CREATE TABLE empleados (
   tipo_doc int NOT NULL,
   nro_doc int NOT NULL,
   id_sucursal int NOT NULL,
   nombre varchar(15) NOT NULL,
   apellido varchar(15) NOT NULL,
   fecha_nacimiento date NOT NULL,
   fecha_ingreso date NOT NULL,
   matricula integer,   
   PRIMARY KEY (tipo_doc, nro_doc)      
);

CREATE TABLE sucursales (
   id_sucursal int IDENTITY (0, 1) PRIMARY KEY,
   nombre varchar(15) NOT NULL,
   tipo_doc_supervisor int , 
   nro_doc_supervisor int,
   tipo_doc_supervisor_suplente int, 
   nro_doc_supervisor_suplente int,
   FOREIGN KEY (tipo_doc_supervisor, nro_doc_supervisor) REFERENCES empleados(tipo_doc, nro_doc),
   FOREIGN KEY (tipo_doc_supervisor_suplente, nro_doc_supervisor_suplente) REFERENCES empleados(tipo_doc, nro_doc)
);

CREATE TABLE perros (
   nro_historia_clinica int IDENTITY (1, 1),
   id_sucursal int NOT NULL,    
   id_raza int NOT NULL,		
   id_due�o int NOT NULL,
   nombre varchar(15) NOT NULL,
   fecha_nacimiento date NOT NULL,   
   peso decimal NOT NULL,
   altura decimal NOT NULL, 
   PRIMARY KEY (nro_historia_clinica, id_sucursal),
   FOREIGN KEY (id_raza) REFERENCES razas(id_raza),
   FOREIGN KEY (id_sucursal) REFERENCES sucursales(id_sucursal),
   FOREIGN KEY (id_due�o) REFERENCES due�os(id_due�o)   
);

CREATE TABLE calendario_vac (
   nro_historia_clinica int NOT NULL,
   id_sucursal int NOT NULL,
   id_vacuna int NOT NULL,  
   tipo_doc_empleado int NOT NULL, 
   nro_doc_empleado int NOT NULL,
   fecha_prevista date,
   fecha_real date NOT NULL,   
   dosis varchar(50),
   PRIMARY KEY (nro_historia_clinica, id_sucursal, id_vacuna),
   FOREIGN KEY (id_sucursal) REFERENCES sucursales(id_sucursal),
   FOREIGN KEY (id_vacuna) REFERENCES vacunas(id_vacuna),
   FOREIGN KEY (tipo_doc_empleado, nro_doc_empleado) REFERENCES empleados(tipo_doc, nro_doc)   
);

CREATE TABLE consultas (
   nro_historia_clinica int NOT NULL,
   id_sucursal int NOT NULL,
   id_consulta int NOT NULL,   
   tipo_doc_empleado int NOT NULL, 
   nro_doc_empleado int NOT NULL,
   fecha_entrada datetime NOT NULL,
   fecha_salida datetime,
   PRIMARY KEY (nro_historia_clinica, id_sucursal, id_consulta),
   FOREIGN KEY (nro_historia_clinica, id_sucursal) REFERENCES perros(nro_historia_clinica, id_sucursal),
   FOREIGN KEY (id_sucursal) REFERENCES sucursales(id_sucursal),   
   FOREIGN KEY (tipo_doc_empleado, nro_doc_empleado) REFERENCES empleados(tipo_doc, nro_doc)   
);

CREATE TABLE sintomas_consulta (
   nro_historia_clinica int NOT NULL,
   id_sucursal inT NOT NULL,
   id_consulta int NOT NULL,
   id_sintoma int NOT NULL,
   PRIMARY KEY (nro_historia_clinica, id_sucursal, id_consulta, id_sintoma),
   FOREIGN KEY (nro_historia_clinica, id_sucursal, id_consulta) REFERENCES consultas(nro_historia_clinica, id_sucursal, id_consulta),
   FOREIGN KEY (id_sintoma) REFERENCES sintomas(id_sintoma)   
);

CREATE TABLE diagnostico_consulta (
   nro_historia_clinica int NOT NULL,
   id_sucursal int NOT NULL,
   id_consulta int NOT NULL,
   id_diagnostico int NOT NULL,
   PRIMARY KEY (nro_historia_clinica, id_sucursal, id_consulta),
   FOREIGN KEY (nro_historia_clinica, id_sucursal, id_consulta) REFERENCES consultas(nro_historia_clinica, id_sucursal, id_consulta),
   FOREIGN KEY (id_diagnostico) REFERENCES diagnosticos(id_diagnostico)   
);

CREATE TABLE medicamentos_consulta (
   nro_historia_clinica int NOT NULL,
   id_sucursal int NOT NULL,
   id_consulta int NOT NULL,
   id_medicamento int NOT NULL,
   dosis varchar(50),
   periocidad varchar(50),
   PRIMARY KEY (nro_historia_clinica, id_sucursal, id_consulta, id_medicamento),
   FOREIGN KEY (id_sucursal) REFERENCES sucursales(id_sucursal),
   FOREIGN KEY (nro_historia_clinica, id_sucursal) REFERENCES perros(nro_historia_clinica, id_sucursal)    
);

CREATE TABLE medicamentos_sucursal (
   id_medicamento int NOT NULL,
   id_sucursal int NOT NULL,   
   stock_actual int,
   stock_minimo int,
   PRIMARY KEY (id_medicamento, id_sucursal),
   FOREIGN KEY (id_sucursal) REFERENCES sucursales(id_sucursal),
   FOREIGN KEY (id_medicamento) REFERENCES medicamentos(id_medicamento)  
);

ALTER TABLE empleados ADD FOREIGN KEY (id_sucursal) REFERENCES sucursales(id_sucursal);

CREATE TABLE tipos_documentos (
	id_tipo_documento INT IDENTITY(0,1),
	nombre_tipo_doc CHAR(20),
	CONSTRAINT id_documento PRIMARY KEY (id_tipo_documento)
);

ALTER TABLE empleados ADD CONSTRAINT empleados_fk_tipo_doc FOREIGN KEY (tipo_doc) REFERENCES tipos_documentos(id_tipo_documento);

INSERT INTO tipos_documentos (nombre_tipo_doc)
	VALUES ('DNI'), ('Otro');