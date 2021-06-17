/*OOIA_create_procedures.sql*/

/*Gestión Humana*/
-- ESPECIALIDAD
delimiter $
create procedure INSERTAR_ESPECIALIDAD(
	out _id_especialidad int,
	in _nombre varchar(150)
)
begin
	insert into especialidad(nombre, activo) values (_nombre, true);
end$

delimiter $
create procedure MODIFICAR_ESPECIALIDAD(
	in _id_especialidad int,
	in _nombre varchar(150)
)
begin
	update especialidad set nombre = _nombre
    	where id_especialidad = _id_especialidad;
end$

delimiter $
create procedure ELIMINAR_ESPECIALIDAD(
	in _id_especialidad int
)
begin
	update especialidad set activo = false
	where id_especialidad = _id_especialidad;
end$

delimiter $
create procedure LISTAR_ESPECIALIDAD(
)
begin
	select id_especialidad, nombre, activo
	from especialidad
	where activo = true;
end$

-- ALUMNO
delimiter $
create procedure INSERTAR_ALUMNO(
	out _id_alumno int,
	-- persona
    	in _nombre varchar(150),
	in _dni varchar(8),
    	in _fecha_nacimiento date,
    	in _direccion varchar(150),
	in _correo varchar(150),
	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
	in _imagen_perfil longblob,
    	-- alumno
	in _codigo varchar(8),
    	in _fid_especialidad int,
    	in _craest decimal(4,2),
    	in _creditos_aprobados decimal(10,2)
)
begin
	declare _id_persona int; 
    	declare _id_miembro_pucp int;
	-- persona
	insert into persona(nombre, dni, fecha_nacimiento, direccion, correo) 
    	values (_nombre, _dni, _fecha_nacimiento, _direccion, _correo);
	set _id_persona = @@last_insert_id;
	-- miembro--pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, MD5(_password), _fecha_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	-- alumno
    	insert into alumno(id_alumno, fid_miembro_pucp, codigo, fid_especialidad, craest, creditos_aprobados, activo)
    	values (_id_miembro_pucp,_id_miembro_pucp, _codigo, _fid_especialidad, _craest, _creditos_aprobados, true);
    	set _id_alumno = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_ALUMNO(
	in _id_alumno int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
    	in _imagen_perfil longblob,
	-- alumno
	in _codigo varchar(8),
    	in _fid_especialidad int,
    	in _craest decimal(4,2),
    	in _creditos_aprobados decimal(10,2)
)
begin
	declare aux_persona int;	
    	select  p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join alumno al on al.fid_miembro_pucp= mp.id_miembro_pucp
    	where al.id_alumno=_id_alumno;
    	-- persona
	update persona set nombre = _nombre,  dni = _dni,  edad = _edad, direccion = _direccion , correo=_correo
    	where id_persona = aux_persona;
     	-- miembro_pucp
	update miembro_pucp set usuario = _usuario, password = _password, fecha_inclusion = _fecha_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
    	-- alumno
    	update alumno set codigo = _codigo, fid_especialidad = _fid_especialidad, craest = _craest, creditos_aprobados = _creditos_aprobados
    	where id_alumno = _id_alumno;
end$

delimiter $
create procedure ELIMINAR_ALUMNO(
	in _id_alumno int
)
begin
	update alumno set activo  = false where id_alumno = _id_alumno;
end$

delimiter $
create procedure LISTAR_ALUMNO(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
           	a.id_alumno, a.codigo, a.fid_especialidad, e.nombre as nombre_especialidad, a.craest, a.creditos_aprobados
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join alumno a on a.fid_miembro_pucp = m.id_miembro_pucp
        inner join especialidad e on e.id_especialidad = a.fid_especialidad 
	where a.activo = true;
end$

delimiter $
create procedure LISTAR_ALUMNO_X_NOMBRE(
	in _nombre varchar(250)
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
           	a.id_alumno, a.codigo, a.fid_especialidad, e.nombre as nombre_especialidad, a.craest, a.creditos_aprobados
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join alumno a on a.fid_miembro_pucp = m.id_miembro_pucp
        inner join especialidad e on e.id_especialidad = a.fid_especialidad 
	where a.activo = true
	and (p.nombre LIKE CONCAT('%',_nombre,'%')) ;
end$


-- PROFESOR
delimiter $
create procedure INSERTAR_PROFESOR(
	out _id_profesor int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
    	in _imagen_perfil longblob,
	-- profesor
	in _fid_especialidad int,
    	in _facultad varchar(150),
    	in _categoria varchar(150)
)
begin
	declare _id_persona int;
    	declare _id_miembro_pucp int;
	-- persona
	insert into persona(nombre, dni, fecha_nacimiento, correo, direccion) 
    	values (_nombre, _dni, _fecha_nacimiento, _correo, _direccion);
	set _id_persona = @@last_insert_id;
	-- miembro_pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, MD5(_password), _fecha_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	-- profesor
    	insert into profesor(fid_miembro_pucp, fid_especialidad, facultad, categoria, activo)
    	values (_id_miembro_pucp, _fid_especialidad, _facultad, _categoria, true);
    	set _id_profesor = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_PROFESOR(
	in _id_profesor int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
    	in _imagen_perfil longblob,
	-- profesor
    	in _fid_especialidad int,
    	in _facultad varchar(150),
    	in _categoria varchar(150)
)
begin
	declare aux_persona  int;	
    	select  p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join profesor pr on pr.fid_miembro_pucp= mp.id_miembro_pucp
    	where pr.id_profesor=_id_profesor;
    	-- persona
    	update persona set nombre = _nombre,  dni = _dni,  fecha_nacimiento = _fecha_nacimiento, direccion = _direccion ,correo=_correo
    	where id_persona = aux_persona;
     	-- miembro_pucp
	update miembro_pucp set usuario = _usuario, password = MD5(_password), fecha_inclusion = _fecha_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
    	-- profesor
    	update profesor set fid_especialidad = _fid_especialidad, facultad = _facultad, categoria = _categoria
    	where id_profesor = _id_profesor;
end$

delimiter $
create procedure ELIMINAR_PROFESOR(
	in _id_profesor int
)
begin
	update profesor set activo = false where id_profesor = _id_profesor;
end$

delimiter $
create procedure LISTAR_PROFESOR(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
 		pr.id_profesor, e.id_especialidad, e.nombre as nombre_especialidad, pr.facultad, pr.categoria
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join profesor pr on pr.fid_miembro_pucp = m.id_miembro_pucp
       	inner join especialidad e on e.id_especialidad = pr.fid_especialidad
	where pr.activo = true;
end$

delimiter $
create procedure LISTAR_PROFESOR_X_NOMBRE(
	in _nombre varchar(250)
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
 		pr.id_profesor, e.id_especialidad, e.nombre as nombre_especialidad, pr.facultad, pr.categoria
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join profesor pr on pr.fid_miembro_pucp = m.id_miembro_pucp
       	inner join especialidad e on e.id_especialidad = pr.fid_especialidad
	where pr.activo = true
	and (p.nombre LIKE CONCAT('%',_nombre,'%'));
end$

-- PSICOLOGO
delimiter $
create procedure INSERTAR_PSICOLOGO(
	out _id_psicologo int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
    	in _imagen_perfil longblob,
	-- psicologo
	in _rama varchar(150)
)
begin
	declare _id_persona int;
    	declare _id_miembro_pucp int;
	-- persona
	insert into persona(nombre, dni, fecha_nacimiento, direccion, correo) 
    	values (_nombre, _dni, _fecha_nacimiento, _direccion, _correo);
	set _id_persona = @@last_insert_id;
	-- miembro_pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, MD5(_password), _fecha_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	-- psicologo
    	insert into psicologo(fid_miembro_pucp, rama, activo)
    	values (_id_miembro_pucp, _rama, true);
    	set _id_psicologo= @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_PSICOLOGO(
	in _id_psicologo int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
    	in _imagen_perfil longblob,
	-- psicologo
	in _rama varchar(150)
)
begin
	declare aux_persona int;	
    	select p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join psicologo ps on ps.fid_miembro_pucp= mp.id_miembro_pucp
    	where ps.id_psicologo=_id_psicologo;
	-- persona
    	update persona set nombre = _nombre,  dni = _dni,  fecha_nacimiento = _fecha_nacimiento, direccion = _direccion , correo=_correo
    	where id_persona = aux_persona;
     	-- miembro_pucp
	update miembro_pucp set usuario = _usuario, password = MD5(_password), fecha_inclusion = _fecha_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
	-- psicologo
	update psicologo set rama = _rama
	where id_psicologo = _id_psicologo;
end$

delimiter $
create procedure ELIMINAR_PSICOLOGO(
	in _id_psicologo int
)
begin
	update psicologo set activo = false where id_psicologo = _id_psicologo;
end$

delimiter $
create procedure LISTAR_PSICOLOGO(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
		ps.id_psicologo, ps.rama
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join psicologo ps on ps.fid_miembro_pucp = m.id_miembro_pucp
	where ps.activo = true;
end$

delimiter $
create procedure LISTAR_PSICOLOGO_X_NOMBRE(
	in _nombre varchar(250)
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
		ps.id_psicologo, ps.rama
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join psicologo ps on ps.fid_miembro_pucp = m.id_miembro_pucp
	where ps.activo = true
	and (p.nombre LIKE CONCAT('%',_nombre,'%'));
end$

-- COORDINADOR
delimiter $
create procedure INSERTAR_COORDINADOR(
	out _id_coordinador int,
	-- persona
	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
    	in _imagen_perfil longblob,
	-- coordinador
	in _rol varchar(150)
)
begin
	declare _id_persona int;
    	declare _id_miembro_pucp int;
	-- persona
	insert into persona(nombre, dni, fecha_nacimiento, direccion, correo) 
    	values (_nombre, _dni, _fecha_nacimiento, _direccion, _correo);
	set _id_persona = @@last_insert_id;
	-- miembro_pucp
    	insert into miembro_pucp(fid_persona, usuario, password, fecha_inclusion, imagen_perfil)
    	values (_id_persona, _usuario, MD5(_password), _fecha_inclusion, _imagen_perfil);
    	set _id_miembro_pucp = @@last_insert_id;
	-- coordinador
    	insert into coordinador(fid_miembro_pucp, rol, activo)
    	values (_id_miembro_pucp, _rol, true);
    	set _id_coordinador= @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_COORDINADOR(
	in _id_coordinador int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_pucp
    	in _usuario varchar(150),
    	in _password varchar(150),
    	in _fecha_inclusion date,
    	in _imagen_perfil longblob,
	-- coordinador
	in rol varchar(150)
)
begin
	declare aux_persona int;	
    	select p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_pucp mp on p.id_persona=mp.fid_persona
    	inner join coordinador a on a.fid_miembro_pucp= mp.id_miembro_pucp
    	where a.id_coordinador =_id_coordinador;
	-- persona
    	update persona set nombre = _nombre,  dni = _dni,  fecha_nacimiento = _fecha_nacimiento, direccion = _direccion, correo=_correo
    	where id_persona = aux_persona;
     	-- miembro_pucp
	update miembro_pucp set usuario = _usuario, password = MD5(_password), fecha_inclusion = _fecha_inclusion, imagen_perfil = _imagen_perfil
    	where fid_persona = aux_persona;
	-- coordinador
	update coordinador set rol = _rol
	where id_coordinador = _id_coordinador;
end$

delimiter $
create procedure ELIMINAR_COORDINADOR(
	in _id_coordinador int
)
begin
	update coordinador set activo = false where id_coordinador = _id_coordinador;
end$

delimiter $
create procedure LISTAR_COORDINADOR(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
		c.id_coordinador, c.rol
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join coordinador c on c.fid_miembro_pucp = m.id_miembro_pucp
	where c.activo = true;
end$

delimiter $
create procedure LISTAR_COORDINADOR_X_NOMBRE(
	in _nombre varchar(250)
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
		c.id_coordinador, c.rol
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join coordinador c on c.fid_miembro_pucp = m.id_miembro_pucp
	where c.activo = true
	and (p.nombre LIKE CONCAT('%',_nombre,'%'));
end$

-- PONENTE
delimiter $
create procedure INSERTAR_PONENTE(
	out _id_ponente int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_externo
    	in _telefono int,
	in _ocupacion varchar(150),
	-- ponente
	in _organizacion varchar(150)
)
begin
	declare _id_persona int;
    	declare _id_miembro_externo int;
	-- persona
	insert into persona(nombre, dni, fecha_nacimiento, direccion, correo) 
    	values (_nombre, _dni, _fecha_nacimiento, _direccion, _correo);
	set _id_persona = @@last_insert_id;
	-- miembro_externo
    	insert into miembro_externo(fid_persona, telefono, ocupacion)
    	values (_id_persona, _telefono, _ocupacion);
    	set _id_miembro_externo = @@last_insert_id;
	-- ponente
    	insert into ponente(fid_miembro_externo, organizacion, activo)
    	values (_id_miembro_externo, _organizacion, true);
    	set _id_ponente = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_PONENTE(
	in _id_ponente int,
	-- persona
    	in _nombre varchar(150),
    	in _dni varchar(8),
    	in _fecha_nacimiento date,
	in _direccion varchar(150),
    	in _correo varchar(150),
    	-- miembro_externo
    	in _telefono int,
    	in _ocupacion varchar(150),
	-- ponente
	in _organizacion varchar(150)
)
begin
    	declare aux_persona int;	
    	select p.id_persona into aux_persona
    	from persona p 
    	inner join miembro_externo  me on p.id_persona = me.fid_persona
    	inner join ponente po on po.fid_miembro_externo = me.id_miembro_externo
    	where p.id_ponente = _id_ponente;
    	-- persona
	update persona set nombre = _nombre,  dni = _dni, fecha_nacimiento = _fecha_nacimiento, direccion = _direccion , correo = _correo
    	where id_persona = aux_persona;
     	-- miembro_externo
	update miembro_externo set telefono = _telefono, ocupacion = _ocupacion
    	where fid_persona = aux_persona;
	-- ponente
	update ponente set organizacion = _organizacion
	where id_ponente = _id_ponente;
end$

delimiter $
create procedure ELIMINAR_PONENTE(
	in _id_invitado int
)
begin
	update invitado set activo = false where id_ponente = _id_ponente;
end$

delimiter $
create procedure LISTAR_PONENTE(
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		me.id_miembro_externo, me.telefono, me.ocupacion,
		po.id_ponente, po.organizacion
	from persona p 
	inner join miembro_externo me on p.id_persona = me.fid_persona
        inner join ponente po on po.fid_miembro_externo = me.id_miembro_externo
	where po.activo = true;
end$

delimiter $
create procedure LISTAR_PONENTE_X_NOMBRE(
	in _nombre varchar(250)
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		me.id_miembro_externo, me.telefono, me.ocupacion,
		po.id_ponente, po.organizacion
	from persona p 
	inner join miembro_externo me on p.id_persona = me.fid_persona
        inner join ponente po on po.fid_miembro_externo = me.id_miembro_externo
	where po.activo = true
	and (p.nombre LIKE CONCAT('%',_nombre,'%'));
end$


/*Gestión Académica*/
-- CURSO
delimiter $
create procedure INSERTAR_CURSO(
	out _id_curso int,
	in _codigo_curso varchar(100),
    	in _nombre_curso varchar(300),
	in _creditos decimal(4,2)
)
begin
	insert into curso(codigo_curso, nombre_curso, creditos, activo)
	values(_codigo_curso, _nombre_curso, _creditos, true);
	set _id_curso = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CURSO(
	in _id_curso int,
	in _codigo_curso varchar(100),
    	in _nombre_curso varchar(300),
	in _creditos decimal(4,2)
)
begin
	update curso set codigo_curso = _codigo_curso, nombre_curso =_nombre_curso, creditos = _creditos 
	where id_curso = _id_curso;
end$

delimiter $
create procedure ELIMINAR_CURSO(
	in _id_curso int
)
begin
	update curso set activo = false where id_curso = _id_curso;
end$

delimiter $
create procedure LISTAR_CURSO()
BEGIN
	select id_curso, codigo_curso, nombre_curso, creditos
	from curso
	where activo = true;
end$

-- CURSO_LLEVADO
delimiter $
create procedure INSERTAR_CURSO_LLEVADO(
	out _id_curso_llevado int,
    	in _fid_alumno int,
	in _fid_curso int,
    	in _ciclo varchar(100),
    	in _vez int,
    	in _nota_final DECIMAL(4,2),
    	in _retirado BOOLEAN,
    	in _formula_de_calificacion varchar(100)
)
begin
	insert into curso_llevado(fid_alumno, fid_curso, ciclo, vez, nota_final, retirado, formula_de_calificacion) 
    	values(_fid_alumno, _fid_curso, _ciclo, _vez, _nota_final, _retirado, _formula_de_calificacion);
	set _id_curso_llevado = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CURSO_LLEVADO(
	in _id_curso_llevado int,
    	in _fid_alumno int,
	in _fid_curso int,
    	in _ciclo varchar(100),	
    	in _vez int,
    	in _nota_final DECIMAL(4,2),
    	in _retirado BOOLEAN,
    	in _formula_de_calificacion varchar(100)
)
begin
	update curso_llevado set fid_alumno = _fid_alumno, fid_curso = _fid_curso, ciclo = _ciclo,
    	vez = _vez, nota_final = _nota_final, retirado = _retirado, formula_de_calificacion = _formula_de_calificacion 
    	where id_curso_llevado = _id_curso_llevado;
end$

delimiter $
create procedure LISTAR_CURSO_LLEVADO(
	in _id_alumno int
)
begin
	select cl.id_curso_llevado,c.id_curso ,c.codigo_curso, c.nombre_curso, cl.ciclo, cl.vez, cl.nota_final,
    	cl.retirado, cl.formula_de_calificacion
    	from curso_llevado cl inner join curso c on c.id_curso=cl.fid_curso
	where fid_alumno=_id_alumno;
end$

-- EVALUACION
delimiter $
create procedure INSERTAR_EVALUACION(
	out _id_evaluacion int,
    	in _fid_curso_llevado int,
    	in _tipo varchar(10),
    	in _nombre varchar(100),
    	in _nota int
)
begin
	insert into evaluacion(id_curso_llevado, tipo, nombre, nota) 
    	values(_fid_curso_llevado, _tipo, _nombre, _nota);
	set _id_evaluacion = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_EVALUACION(
	in _id_evaluacion int,
    	in _fid_curso_llevado int,
    	in _tipo varchar(10),
    	in _nombre varchar(100),
    	in _nota int
)
begin
	update evaluacion set fid_curso_llevado = _fid_curso_llevado, tipo =_tipo, nombre = _nombre, nota = _nota
    	where id_evaluacion = _id_evaluacion;
end$

delimiter $
create procedure LISTAR_EVALUCION(
	in _id_curso_llevado int
)
begin
	select id_evaluacion, tipo, nombre, nota
    	from evaluacion 
	where fid_curso_llevado = _id_curso_llevado;
end$

/*Gestión Atención*/
-- CODIGO_ATENCION
delimiter $
create procedure INSERTAR_CODIGO_ATENCION(
	out _id_codigo_atencion int,
	in _codigo varchar(100),
    	in _descripcion varchar(300)
)
begin
	insert into codigo_atencion(codigo, descripcion, activo)
	values(_codigo, _descripcion, true);
	set _id_codigo_atencion = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CODIGO_ATENCION(
	in _id_codigo_atencion int,
	in _codigo varchar(100),
    	in _descripcion varchar(300)
)
begin
	update codigo_atencion set codigo = _codigo, descripcion = _descripcion
	where id_codigo_atencion = _id_codigo_atencion;
end$


delimiter $
create procedure ELIMINAR_CODIGO_ATENCION(
	in _id_codigo_atencion int
)
begin
	update codigo_atencion set activo = false
	where id_codigo_atencion = _id_codigo_atencion;
end$

delimiter $
create procedure LISTAR_CODIGO_ATENCION()
begin
	select id_codigo_atencion, codigo, descripcion
	from codigo_atencion
	where activo = true;
end$

-- HORARIO
delimiter $
create procedure INSERTAR_HORARIO(
	out _id_horario int,
    	in _dia int,
    	in _hora_inicio time,
    	in _hora_fin time
)
begin
	insert into horario(dia,hora_inicio,hora_fin, activo) 
    	values(_dia,_hora_inicio,_hora_fin, true);
	set _id_horario = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_HORARIO(
	in _id_horario int,
    	in _dia int,
    	in _hora_inicio time,
    	in _hora_fin time
)
begin
	update horario set dia = _dia, hora_inicio=_hora_inicio, hora_fin = _hora_fin
    	where id_horario = _id_horario;
end$

delimiter $
create procedure ELIMINAR_HORARIO(
	in _id_horario int
)
begin
	update horario set activo = false where id_horario = _id_horario;
end$

delimiter $
create procedure LISTAR_HORARIO()
BEGIN
	select id_horario, dia, hora_inicio, hora_fin
    	from horario;
end$

--HORARIO_ASESOR
delimiter $
create procedure INSERTAR_HORARIO_ASESOR(
	out _id_horario_asesor int,
    	in _fid_horario int,
    	in _fid_asesor int,
    	in _estado int
)begin
	insert into horario_asesor(fid_horario, fid_asesor, estado, activo) 
    	values(_fid_horario, _fid_asesor, _estado, true);
	set _id_horario_asesor = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_HORARIO_ASESOR(
	in _id_horario_asesor int,
    	in _fid_horario int,
    	in _fid_asesor int,
    	in _estado int
)begin
	update horario_asesor set fid_horario = _fid_horario, fid_asesor = _fid_asesor, estado = _estado
    	where id_horario_asesor = _id_horario_asesor; 
end$

delimiter $
create procedure ELIMINAR_HORARIO_ASESOR(
	in _id_horario_asesor int
)
begin
	update horario_asesor set activo = false where id_horario_asesor = _id_horario_asesor;
end$

delimiter $
create procedure LISTAR_HORARIO_ASESOR(
	in _id_asesor int
)
BEGIN
	select 	ha.id_horario_asesor, ha.fid_asesor, ha.estado,
		h.id_horario, h.dia, h.hora_inicio, h.hora_fin	
    	from horario_asesor ha
	inner join horario h on ha.fid_horario = h.id_horario
    	where _id_asesor= ha.fid_asesor;
end$


-- CITA
delimiter $
create procedure INSERTAR_CITA(
    	out _id_cita int,
	in _fid_alumno int,
	in _tipo_asesor int,
	in _fid_asesor int,
    	in _fid_horario int,
	in _fid_atencion int,
    	in _fecha date,
    	in _motivo varchar(300),
	in _compromiso varchar(300)
)begin
	insert into cita(fid_alumno, tipo_asesor, fid_asesor, fid_atencion, fid_horario, fecha, motivo, compromiso, asistio, activo) 
    	values(_fid_alumno, _tipo_asesor, _fid_asesor, _fid_atencion, _fid_horario, _fecha, _motivo, _compromiso, false, true);
	set _id_cita = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CITA(
    	in _id_cita int,
	in _fid_alumno int,
	in _tipo_asesor int,
	in _fid_asesor int,
    	in _fid_horario int,
	in _fid_atencion int,
    	in _fecha date,
    	in _motivo varchar(300),
	in _compromiso varchar(300),
    	in _asistio bool
)begin
	update cita set fid_alumno = _fid_alumno, tipo_asesor = _tipo_asesor, fid_asesor = _fid_asesor, fid_horario=_fid_horario, fid_atencion=_fid_atencion, fecha = 		_fecha, motivo=_motivo, compromiso = _compromiso, asistio = _asistio
	where id_cita = _id_cita;
end$

delimiter $
create procedure ELIMINAR_CITA(
	in _id_cita int
)
BEGIN
	update cita set activo = 0 where id_cita = _id_cita;
end$

delimiter $
create procedure LISTAR_CITA_PENDIENTE(
	in _id_alumno int
)
begin
	select c.id_cita, c.fid_alumno, c.tipo_asesor, c.fid_asesor, c.fecha, c.motivo, c.compromiso, c.asistio, 
	h.id_horario, h.dia, h.hora_inicio, h.hora_fin,
	ca.id_codigo_atencion, ca.id_codigo, ca.descripcion
    	from cita c 
	inner join horario h on c.fid_horario = h.id_horario
    	inner join codigo_atencion ca on c.fid_atencion = ca.id_codigo_atencion
    	where c.fid_alumno=_id_alumno
	and c.fecha >= CURDATE();
end$

delimiter $
create procedure LISTAR_CITA_HISTORICO(
	in _id_alumno int
)
begin
	select c.id_cita, c.fid_alumno, c.tipo_asesor, c.fid_asesor, c.fecha, c.motivo, c.compromiso, c.asistio, 
	h.id_horario, h.dia, h.hora_inicio, h.hora_fin,
	ca.id_codigo_atencion, ca.id_codigo, ca.descripcion
    	from cita c 
	inner join horario h on c.fid_horario = h.id_horario
    	inner join codigo_atencion ca on c.fid_atencion = ca.id_codigo_atencion
    	where c.fid_alumno=_id_alumno
        and c.fecha < CURDATE();
end$

delimiter $
create procedure INSERTAR_ENCUESTA(
	out _id_encuesta int,
    	in _puntaje decimal(4,2),
    	in _descripcion varchar(300),
    	in _fid_alumno int,
	in _tipo_asesor int,
    	in _fid_asesor int
)
BEGIN
	insert into encuesta(puntaje, descripcion, fid_alumno, tipo_asesor, fid_asesor, activo) 
    	values( _puntaje, _descripcion, _fid_alumno, _tipo_asesor, _fid_asesor, true);
	SET _id_encuesta = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_ENCUESTA(
	in _id_encuesta int,
    	in _puntaje decimal(4,2),
    	in _descripcion varchar(300),
    	in _fid_alumno int,
	in _tipo_asesor int,
    	in _fid_asesor int
)
BEGIN
	update encuesta SET puntaje = _puntaje, descripcion=_descripcion, fid_alumno=_fid_alumno, tipo_asesor = _tipo_asesor,
    	fid_asesor=_fid_asesor where id_encuesta = _id_encuesta;
end$

delimiter $
create procedure ELIMINAR_ENCUESTA(
	in _id_encuesta int
)
BEGIN
	update encuesta set activo = 0 where id_encuesta = _id_encuesta;
end$

delimiter $
create procedure LISTAR_ENCUESTA(
)
BEGIN
	select id_encuesta, puntaje, descripcion, fid_alumno, tipo_asesor, fid_asesor
	from encuesta;
end$

delimiter $
create procedure LISTAR_ENCUESTA_X_ASESOR(
	in _id_asesor int
)
BEGIN
	select id_encuesta, puntaje, descripcion, fid_alumno, tipo_asesor, fid_asesor
	from encuesta
    	where fid_asesor=_id_asesor;
end$

delimiter $
create procedure LISTAR_ENCUESTA_X_ALUMNO(
	in _id_alumnor int
)
BEGIN
	select id_encuesta, puntaje, descripcion, fid_alumno, tipo_asesor, fid_asesor
	from encuesta
    	where fid_alumno=_id_alumno;
end$

/*Gestión Eventos*/
--CATEGORIA_EVENTO
delimiter $
create procedure INSERTAR_CATEGORIA_EVENTO(
	out _id_categoria_evento int,
	in _nombre varchar(150)
)
begin
	insert into categoria_evento(nombre, activo) values (_nombre, true);
    	set _id_categoria_evento = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_CATEGORIA_EVENTO(
	in _id_categoria_evento int,
	in _nombre varchar(150)
)
begin
	update categoria set nombre = _nombre
    	where id_categoria_evento = _id_categoria_evento;
end$

delimiter $
create procedure ELIMINAR_CATEGORIA_EVENTO(
	in _id_categoria_evento int
)
begin
	update categoria_evento set activo = false
	where id_categoria_evento = _id_categoria_evento;
end$

delimiter $
create procedure LISTAR_CATEGORIA_EVENTO(
)
begin
	select id_categoria_evento, nombre
	from categoria_evento
	where activo = true;
end$

--EVENTO
delimiter $
create procedure INSERTAR_EVENTO(
	out _id_evento int,
	in _nombre varchar(150),
	in _descripcion varchar(250),
	in _fid_coordinador int,
	in _fid_categoria_evento int,
    	in _capacidad int,
    	in _fecha date,
    	in _hora_inicio time,
	in _hora_fin time,
	in _lugar varchar(150),
    	in _imagen longblob
)begin
	insert into evento(nombre, descripcion, fid_coordinador, fid_categoria_evento, capacidad, cupo, fecha, hora_inicio, hora_fin, lugar, imagen, activo)
    	values (_nombre, _descripcion, _fid_coordinador, _fid_categoria_evento, _capacidad, 0, _fecha, _hora_inicio, _hora_fin, _lugar, _imagen, true);
	set _id_evento = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_EVENTO(
	in _id_evento int,
	in _nombre varchar(150),
	in _descripcion varchar(250),
	in _fid_coordinador int,
	in _fid_categoria_evento int,
    	in _capacidad int,
	in _cupo int,
    	in _fecha date,
    	in _hora_inicio time,
	in _hora_fin time,
	in _lugar varchar(150),
    	in _imagen longblob
)begin
	update evento set nombre = _nombre, descripcion = _descripcion, fid_coordinador = _fid_coordinador, fid_categoria_evento = 		_fid_categoria_evento, capacidad = _capacidad, cupo = _cupo, fecha = _fecha, hora_inicio = _hora_inicio, hora_fin = _hora_fin, lugar = 	_lugar, imagen = _imagen
	where id_evento = _id_evento;
end$

delimiter $
create procedure ELIMINAR_EVENTO(
    	in _id_evento int
)begin
	update evento set activo = false where id_evento = _id_evento;
end$

delimiter $
CREATE  PROCEDURE LISTAR_EVENTO_X_NOMBRE_CATEGORIA(
in _nombreCategoria varchar(250)
)
begin
	/*tabla evento*/
	select e.id_evento, e.nombre, e.lugar, e.capacidad, e.fecha, e.hora_inicio,e.hora_fin,e.descripcion,e.imagen,e.cupo,
    e.fid_coordinador, e.fid_categoria_evento, ce.nombre as nombre_categoria
    from evento e inner join coordinador c on e.fid_coordinador = c.id_coordinador
    inner join categoria_evento ce on ce.id_categoria_evento = e.fid_categoria_evento
    where  ((e.nombre LIKE CONCAT('%',_nombreCategoria,'%')) OR (ce.nombre LIKE CONCAT('%',_nombreCategoria,'%'))) and e.activo=1;
end$


--ENCUESTA_EVENTO
delimiter $
create procedure INSERTAR_EVENTO_ALUMNO(
	out _id_evento_alumno int,
    	in _fid_alumno int,
    	in _fid_evento int,
    	in _valoracion_ponentes int,
    	in _valoracion_evento int,
    	in _valoracion_utilidad int,
    	in _asistencia bool,
    	in _comentario varchar(200)
    	-- activo boolean
)begin
	insert into evento_alumno(fid_alumno, fid_evento, valoracion_ponentes, valoracion_evento, valoracion_utilidad, asistencia, 			comentario, activo) 
    	values( _fid_alumno, _fid_evento, _valoracion_ponentes, _valoracion_evento, _valoracion_utilidad, _asistencia, _comentario, true);
	set _id_evento_alumno = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_EVENTO_ALUMNO(
	in _id_evento_alumno int,
    	in _fid_alumno int,
   	in _fid_evento int,
    	in _valoracion_ponente int,
    	in _valoracion_evento int,
    	in _valoracion_utilidad int,
    	in _asistencia bool,
    	in _comentario varchar(200)
)begin
	update evento_alumno set fid_alumno = _fid_alumno, fid_evento = _fid_evento, 
    	valoracion_ponentes = _valoracion_ponentes,  valoracion_evento = _valoracion_evento,
    	valoracion_utilidad = _valoracion_utilidad, asistencia = _asistencia, comentario = _comentario
    	where id_evento_alumno = _id_evento_alumno;
end$

delimiter $
create procedure ELIMINAR_EVENTO_ALUMNO(
    	in _id_evento_alumno int
)begin
	update evento_alumno set activo = false where id_evento_alumno = _id_evento_alumno;
end$

delimiter $
create procedure LISTAR_EVENTO_ALUMNO(
	in _id_evento int
)begin
	select a.nombre as nombre_alumno, e.nombre as nombre_evento, ea.valoracion_ponentes, ea.valoracion_evento, ea.valoracion_utilidad, 	ea.asistencia, ea.comentario
	from evento_alumno ea
	inner join alumno a on ea.fid_alumno = a.id_alumno
	inner join evento e on ea.fid_evento = e.id_evento
	where activo = true
	and ea.fid_evento = _id_evento;
end$

-- EVENTO_PONENTE
delimiter $
create procedure INSERTAR_EVENTO_PONENTE(
	out _id_evento_ponente int,
    	in _fid_ponente int,
    	in _fid_evento int
    	-- activo boolean
)begin
	insert into evento_ponente(fid_ponente, fid_evento, activo) 
    	values( _fid_ponente, _fid_evento, true);
	set _id_evento_ponente = @@last_insert_id;
end$

delimiter $
create procedure MODIFICAR_EVENTO_PONENTE(
	in _id_evento_ponente int,
    	in _fid_ponente int,
    	in _fid_evento int
    	-- activo boolean
)begin
	update evento_ponente set fid_ponente = _fid_ponente
    	where id_evento_ponente = _id_evento_ponente;
end$

delimiter $
create procedure ELIMINAR_EVENTO_PONENTE(
    	in _id_evento int
        
)begin
	update evento_ponente set activo = false where fid_evento = _id_evento ;
end$

delimiter $
CREATE PROCEDURE LISTAR_EVENTO_PONENTE(
	in _id_evento int
)
begin
	select per.id_persona, me.id_miembro_externo, p.id_ponente, per.nombre as nombre_ponente, e.id_evento, e.nombre as nombre_evento
	from evento_ponente ep
	inner join ponente p on ep.fid_ponente = p.id_ponente
    inner join miembro_externo me on me.id_miembro_externo=p.fid_miembro_externo
    inner join persona per on per.id_persona=me.fid_persona
	inner join evento e on ep.fid_evento = e.id_evento
	where ep.activo = true
	and ep.fid_evento = _id_evento;
end$

delimiter $
create procedure autenticarUsuario(
in _usuario varchar(250),
in _password varchar(250)
)begin
select * 
from miembro_pucp
where usuario=_usuario and password=md5(_password);
end$


delimiter $
create procedure tipoUsuario(in _id_persona int)
begin
select  case
when _id_persona in 
(select p.id_persona
 from persona p 
 inner join miembro_pucp mp on mp.fid_persona=p.id_persona
 inner join alumno a on a.fid_miembro_pucp=mp.id_miembro_pucp) then 1
 when _id_persona in 
 (select p.id_persona
 from persona p 
 inner join miembro_pucp mp on mp.fid_persona=p.id_persona
 inner join profesor pr on pr.fid_miembro_pucp=mp.id_miembro_pucp) then 2
 when _id_persona in 
 (select p.id_persona
 from persona p 
 inner join miembro_pucp mp on mp.fid_persona=p.id_persona
 inner join psicologo ps on ps.fid_miembro_pucp=mp.id_miembro_pucp) then 3
 when _id_persona in 
 (select p.id_persona
 from persona p 
 inner join miembro_pucp mp on mp.fid_persona=p.id_persona
 inner join coordinador c on c.fid_miembro_pucp=mp.id_miembro_pucp) then 4
 end as tipo_de_usuario;
end$

delimiter $
create procedure LISTAR_ALUMNO_X_ID(
in _id int
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario,m.password, m.fecha_inclusion, m.imagen_perfil,
           	a.id_alumno, a.codigo, a.fid_especialidad, e.nombre as nombre_especialidad, a.craest, a.creditos_aprobados
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join alumno a on a.fid_miembro_pucp = m.id_miembro_pucp
        inner join especialidad e on e.id_especialidad = a.fid_especialidad 
	where a.activo = true and p.id_persona=_id;
end$
delimiter $
create procedure LISTAR_PROFESOR_X_ID(
in id int
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario,  m.password, m.fecha_inclusion, m.imagen_perfil,
 		pr.id_profesor, e.id_especialidad,e.nombre as nombre_especialidad, pr.facultad, pr.categoria
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join profesor pr on pr.fid_miembro_pucp = m.id_miembro_pucp
       	inner join especialidad e on e.id_especialidad = pr.fid_especialidad
	where pr.activo = true and p.id_persona=id;
end$
delimiter $
create procedure LISTAR_COORDINADOR_X_ID(
in id int
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
		c.id_coordinador, c.rol
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join coordinador c on c.fid_miembro_pucp = m.id_miembro_pucp
	where c.activo = true and p.id_persona=id;
end$
delimiter $
create procedure LISTAR_PSICOLOGO_X_ID(
in id int 
)begin
	select 	p.id_persona, p.nombre, p.dni, p.fecha_nacimiento, p.direccion, p.correo,
		m.id_miembro_pucp, m.usuario, m.password, m.fecha_inclusion, m.imagen_perfil,
		ps.id_psicologo, ps.rama
	from persona p 
	inner join miembro_pucp m on p.id_persona = m.fid_persona
        inner join psicologo ps on ps.fid_miembro_pucp = m.id_miembro_pucp
	where ps.activo = true and p.id_persona=id;
end$
