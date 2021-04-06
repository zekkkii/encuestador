create database  Encuestador
go

create table usuarios 
(
id int primary key identity,
nombre varchar(50),
apellido varchar(70),
usuario varchar(25),
user_password varchar(45)
)


create table encuesta
(
id int primary key identity,
nombre varchar(50)
)


create table preguntas
(
 id int primary key identity,
 id_encuesta int,
 pregunta varchar(200)
 foreign key( id_encuesta) references encuesta(id) 
)


create table respuestas
(
id int primary key identity,
respuesta varchar(350),
id_pregunta int,
id_persona int, 
id_encuesta int,
foreign key(id_pregunta) references preguntas(id),
foreign key(id_persona) references usuarios(id),
foreign key(id_encuesta) references encuesta(id)
)



create table personas_encuestadas
(
id int primary key identity,
id_persona int,
id_encuesta int,
foreign key(id_persona) references usuarios(id),
foreign key(id_encuesta) references encuesta(id)
)

select * from usuarios
select * from encuesta
select * from preguntas
select * from respuestas
select * from  personas_encuestadas

select P.pregunta as pregunta,respuesta 
from respuestas R
inner join 
preguntas P on P.id = R.id_pregunta 
inner join 
usuarios U  on U.id =  R.id_persona 
where id_persona = 


select id_persona, U.nombre from personas_encuestadas PE inner join usuarios U on U.id = PE.id_persona where id_encuesta =1


SELECT id_persona FROM personas_encuestadas WHERE id_persona = 1 and id_encuesta = 1 