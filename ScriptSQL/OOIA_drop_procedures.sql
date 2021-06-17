/*OOIA_drop_procedures.sql*/

/*Gestión Humana*/
-- ESPECIALIDAD
drop procedure if exists INSERTAR_ESPECIALIDAD;
drop procedure if exists MODIFICAR_ESPECIALIDAD;
drop procedure if exists ELIMINAR_ESPECIALIDAD;
drop procedure if exists LISTAR_ESPECIALIDAD;
-- COORDINADOR
drop procedure if exists INSERTAR_COORDINADOR;
drop procedure if exists MODIFICAR_COORDINADOR;
drop procedure if exists ELIMINAR_COORDINADOR;
drop procedure if exists LISTAR_COORDINADOR;
drop procedure if exists LISTAR_COORDINADOR_X_NOMBRE;

-- ALUMNO
drop procedure if exists INSERTAR_ALUMNO;
drop procedure if exists MODIFICAR_ALUMNO;
drop procedure if exists ELIMINAR_ALUMNO;
drop procedure if exists LISTAR_ALUMNO;
drop procedure if exists LISTAR_ALUMNO_X_NOMBRE;
-- PROFESOR
drop procedure if exists INSERTAR_PROFESOR;
drop procedure if exists MODIFICAR_PROFESOR;
drop procedure if exists ELIMINAR_PROFESOR;
drop procedure if exists LISTAR_PROFESOR;
drop procedure if exists LISTAR_PROFESOR_X_NOMBRE;
-- PSICOLOGO
drop procedure if exists INSERTAR_PSICOLOGO;
drop procedure if exists MODIFICAR_PSICOLOGO;
drop procedure if exists ELIMINAR_PSICOLOGO;
drop procedure if exists LISTAR_PSICOLOGO;
drop procedure if exists LISTAR_PSICOLOGO_X_NOMBRE;
-- PONENTE
drop procedure if exists INSERTAR_PONENTE;
drop procedure if exists MODIFICAR_PONENTE;
drop procedure if exists ELIMINAR_PONENTE;
drop procedure if exists LISTAR_PONENTE;
drop procedure if exists LISTAR_PONENTE_X_NOMBRE;

/*Gestión Académica*/
-- CURSO
drop procedure if exists INSERTAR_CURSO;
drop procedure if exists MODIFICAR_CURSO;
drop procedure if exists ELIMINAR_CURSO;
drop procedure if exists LISTAR_CURSO;
-- CURSO_LLEVADO
drop procedure if exists INSERTAR_CURSO_LLEVADO;
drop procedure if exists MODIFICAR_CURSO_LLEVADO;
drop procedure if exists LISTAR_CURSO_LLEVADO;
-- EVALUACION
drop procedure if exists INSERTAR_EVALUACION;
drop procedure if exists MODIFICAR_EVALUACION;
drop procedure if exists LISTAR_EVALUCION;

/*Gestión Atención*/
-- CODIGO_ATENCION
drop procedure if exists INSERTAR_CODIGO_ATENCION;
drop procedure if exists MODIFICAR_CODIGO_ATENCION;
drop procedure if exists ELIMINAR_CODIGO_ATENCION;
drop procedure if exists LISTAR_CODIGO_ATENCION;
-- HORARIO_ASESOR
drop procedure if exists INSERTAR_HORARIO_ASESOR;
drop procedure if exists MODIFICAR_HORARIO_ASESOR;
drop procedure if exists ELIMINAR_HORARIO_ASESOR;
drop procedure if exists LISTAR_HORARIO_ASESOR;
-- HORARIO
drop procedure if exists INSERTAR_HORARIO;
drop procedure if exists MODIFICAR_HORARIO;
drop procedure if exists ELIMINAR_HORARIO;
drop procedure if exists LISTAR_HORARIO;
-- CITA
drop procedure if exists INSERTAR_CITA;
drop procedure if exists MODIFICAR_CITA;
drop procedure if exists ELIMINAR_CITA;
drop procedure if exists LISTAR_CITA_HISTORICO;
drop procedure if exists LISTAR_CITA_PENDIENTE;
-- ENCUESTA
drop procedure if exists INSERTAR_ENCUESTA;
drop procedure if exists MODIFICAR_ENCUESTA;
drop procedure if exists ELIMINAR_ENCUESTA;
drop procedure if exists LISTAR_ENCUESTA;
drop procedure if exists LISTAR_ENCUESTA_X_ASESOR;
drop procedure if exists LISTAR_ENCUESTA_X_ALUMNO;

/*Gestión Eventos*/
-- CATEGORIA_EVENTO
drop procedure if exists INSERTAR_CATEGORIA_EVENTO;
drop procedure if exists MODIFICAR_CATEGORIA_EVENTO;
drop procedure if exists ELIMINAR_CATEGORIA_EVENTO;
drop procedure if exists LISTAR_CATEGORIA_EVENTO;
-- EVENTO
drop procedure if exists INSERTAR_EVENTO;
drop procedure if exists MODIFICAR_EVENTO;
drop procedure if exists ELIMINAR_EVENTO;
drop procedure if exists LISTAR_EVENTO;
-- EVENTO_ALUMNO
drop procedure if exists INSERTAR_EVENTO_ALUMNO;
drop procedure if exists MODIFICAR_EVENTO_ALUMNO;
drop procedure if exists ELIMINAR_EVENTO_ALUMNO;
drop procedure if exists LISTAR_EVENTO_ALUMNO;
-- EVENTO_PONENTE
drop procedure if exists INSERTAR_EVENTO_PONENTE;
drop procedure if exists MODIFICAR_EVENTO_PONENTE;
drop procedure if exists ELIMINAR_EVENTO_PONENTE;
drop procedure if exists LISTAR_EVENTO_PONENTE;
drop procedure if exists LISTAR_EVENTO_X_NOMBRE_CATEGORIA;