/*OOIA_create_tables.sql*/
/*Gestion Humana*/
create table especialidad(
	id_especialidad int auto_increment,
	nombre varchar(100),
	activo bool,

    	primary key (id_especialidad)
)engine = innodb;

create table persona(
	id_persona int auto_increment,
    	nombre varchar(150),
    	dni varchar(8),
    	fecha_nacimiento date,
	direccion varchar(150),
	correo varchar(150),

    	primary key(id_persona)
)engine = innodb;

create table miembro_pucp(
	id_miembro_pucp int auto_increment,
    	fid_persona int,
    	usuario varchar(150),
    	password varchar(150),
    	fecha_inclusion date,
    	imagen_perfil longblob,

    	primary key (id_miembro_pucp),
    	foreign key(fid_persona) references persona(id_persona)
)engine = innodb;

create table miembro_externo(
	id_miembro_externo int auto_increment,
    	fid_persona int,
    	telefono varchar(150),
    	ocupacion varchar(150),

    	primary key (id_miembro_externo),
    	foreign key(fid_persona) references persona(id_persona)
)engine = innodb;

create table alumno(
	id_alumno int auto_increment,
	fid_especialidad int,
    	fid_miembro_pucp int,
	codigo varchar(8),
    	craest decimal(4,2),
    	creditos_aprobados decimal(4,2),
	activo bool,
    
    	primary key(id_alumno),
    	foreign key(id_alumno) references miembro_pucp(id_miembro_pucp),
    	foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp),
	foreign key(fid_especialidad) references especialidad(id_especialidad)
)engine = innodb;

create table profesor(
	id_profesor int auto_increment,
	fid_miembro_pucp int,
    	fid_especialidad int,
    	facultad varchar(150),
    	categoria varchar(100),
    	activo bool,

    	primary key(id_profesor),
    	foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp),
    	foreign key(fid_especialidad) references especialidad(id_especialidad)
)engine = innodb;

create table psicologo(
	id_psicologo int auto_increment,
	fid_miembro_pucp int,
	rama varchar(100),
    	activo bool,

    	primary key(id_psicologo),
    	foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp)
)engine = innodb;

create table coordinador(
    	id_coordinador int auto_increment,
	fid_miembro_pucp int,
	rol varchar(100),
    	activo bool,

    	primary key(id_coordinador),
    	foreign key(fid_miembro_pucp) references miembro_pucp(id_miembro_pucp) 
)engine = innodb;

create table ponente(
	id_ponente int auto_increment,
    	fid_miembro_externo int,
	organizacion varchar(150),
    	activo bool,

    	primary key(id_ponente),
    	foreign key(fid_miembro_externo) references miembro_externo(id_miembro_externo)
)engine = innodb;


/*Gestión Académica*/
create table curso(
    	id_curso int auto_increment,
    	codigo_curso varchar(150),
    	nombre_curso varchar(150),
	creditos decimal(4,2),
    	activo bool,
    	primary key (id_curso)
)engine = innodb;

create table curso_llevado(
	id_curso_llevado int auto_increment,
	fid_alumno int,
    	fid_curso int,
    	ciclo varchar(100),
    	vez int,
    	nota_final decimal(2,2),
    	retirado bool,
    	formula_de_calificacion varchar(100),
    	primary key(id_curso_llevado),
    	foreign key (fid_alumno) references alumno(id_alumno),
    	foreign key (fid_curso) references curso(id_curso)
)engine = innodb;

create table evaluacion(
	id_evaluacion int auto_increment,
	fid_curso_llevado int,
    	tipo varchar(10),
    	nombre varchar(150),
    	nota int,
    	primary key(id_evaluacion),
    	foreign key (fid_curso_llevado) references curso_llevado(id_curso_llevado)
)engine = innodb;


/*Gestión Atención*/
create table codigo_atencion(
	id_codigo_atencion int auto_increment,
    	codigo varchar(100),
    	descripcion varchar(300),
	activo bool,
    	primary key(id_codigo_atencion)
)engine = innodb;

create table horario(
	id_horario int auto_increment,
    	dia int,
    	hora_inicio time,
    	hora_fin time,
	activo bool,
    	primary key(id_horario)
)engine = innodb;

create table horario_asesor(
	id_horario_asesor int auto_increment,
	fid_horario int,
	fid_asesor int,
    	estado varchar(50),
    	primary key(id_horario_asesor),
    	foreign key (fid_horario) references horario(id_horario),
    	foreign key (fid_asesor) references miembro_pucp(id_miembro_pucp)
)engine = innodb;

create table cita(
     	id_cita int auto_increment,
	fid_alumno int,
	tipo_asesor int, -- 0: profesor, 1: psicologo
	fid_asesor int,
    	fid_atencion int,
	fid_horario int,
    	fecha date,
    	motivo varchar(300),
	compromiso varchar(300),
    	asistio bool,
    	activo bool,

    	primary key(id_cita),
    	foreign key (fid_alumno) references alumno(id_alumno),
	foreign key (fid_asesor) references miembro_pucp(id_miembro_pucp),
    	foreign key (fid_horario) references horario(id_horario),
    	foreign key (fid_atencion) references codigo_atencion(id_codigo_atencion)
)engine = innodb;

create table encuesta(
	id_encuesta int auto_increment,
	fid_alumno int,
	tipo_asesor int,
    	fid_asesor int,
    	puntaje decimal(4,2),
    	descripcion varchar(300),
	activo bool,
    	primary key(id_encuesta),
    	foreign key(fid_alumno) references alumno(id_alumno),
    	foreign key(fid_asesor) references miembro_pucp(id_miembro_pucp)
)engine = innodb;


/*Gestión Eventos*/
create table categoria_evento(
	id_categoria_evento int auto_increment,
	nombre varchar(150),
	activo bool,
	primary key (id_categoria_evento)
)engine = innodb;

create table evento(
	id_evento int auto_increment,
	nombre varchar(150),
	descripcion varchar(250),
	fid_coordinador int,
	fid_categoria_evento int,
    	capacidad int,
    	cupo int,
    	fecha date,
    	hora_inicio time,
	hora_fin time,
	lugar varchar(150),
    	imagen longblob,
    	activo bool,

    	primary key(id_evento),
    	foreign key(fid_coordinador) references coordinador(id_coordinador),
	foreign key(fid_categoria_evento) references categoria_evento(id_categoria_evento)
)engine = innodb;

create table evento_alumno(
	id_evento_alumno int auto_increment,
    	fid_alumno int,
    	fid_evento int,
    	valoracion_ponentes int,
    	valoracion_evento int,
    	valoracion_utilidad int,
    	asistencia bool,
    	comentario varchar(200),
    	activo bool,
    	primary key(id_evento_alumno),
    	foreign key (fid_alumno) references alumno(id_alumno),
    	foreign key (fid_evento) references evento(id_evento)
)engine = innodb;

create table evento_ponente(
	id_evento_ponente int auto_increment,
	fid_ponente int,
    	fid_evento int,
	activo bool,
   	primary key(id_evento_ponente),
    	foreign key (fid_ponente) references ponente(id_ponente),
    	foreign key (fid_evento) references evento(id_evento)
)engine = innodb;