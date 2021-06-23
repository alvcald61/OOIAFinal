drop trigger if exists profesores_horarios;
delimiter $
create trigger profesores_horarios 
after insert on profesor 
for each row
begin
declare x int;
set x = 1;
while x<=80 do 
	insert into horario_asesor(fid_horario,fid_asesor,estado) values (x,new.id_profesor,"ocupado");
end while;
end$


drop trigger if exists psicologo_horarios;
delimiter $
create trigger psicologo_horarios 
after insert on psicologo 
for each row
begin
declare x int;
set x = 1;
while x<=80 do 
	insert into horario_asesor(fid_horario,fid_asesor,estado) values (x,new.id_psicologo,"ocupado");
end while;
end$