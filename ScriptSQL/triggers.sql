drop trigger if exists profesores_horarios;
delimiter $
create trigger profesores_horarios 
after insert on profesor 
for each row
begin
declare x int;
set x = 1;
while x<=90 do 
	insert into horario_asesor(fid_horario,fid_asesor,estado) values (x,new.fid_miembro_pucp,"ocupado");
    set x=x+1;
end while;
end$

delimiter ;
drop trigger if exists psicologo_horarios;
delimiter $
create trigger psicologo_horarios 
after insert on psicologo 
for each row
begin
declare x int;
set x = 1;
while x<=90 do 
	insert into horario_asesor(fid_horario,fid_asesor,estado) values (x,new.fid_miembro_pucp,"ocupado");
    set x=x+1;
end while;
end$

delimiter ;
drop trigger if exists eliminar_asocioados_evento;

delimiter $
create trigger eliminar_asocioados_evento 
after update on evento
for each row
begin
if new.activo = false then 
update  evento_alumno e set e.activo=false where  e.fid_eveto=new.id_evento;
update evento_ponente ep set ep.activo=false where ep.fid_evento=new.id_evento;
end if;
end$


delimiter ;
drop trigger if exists eliminar_asocioados_alumno;

delimiter $
create trigger eliminar_asocioados_alumno 
after update on alumno
for each row
begin
	if new.activo = false then 
		update  cita c set c.activo=false where c.fid_alumno=new.id_alumno;
		#update  curso cu set cu.activo=false where c.fid_alumno=new.id_alumno; 
        update  encuesta e set e.activo=false where e.fid_alumno=new.id_alumno;
        update  evento_alumno ea set ea.activo=false where ea.fid_alumno=new.id_alumno;
	end if;
end$