create database  Encuestador
go

create table usuarios 
(
id int identity,
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
foreign key(id_pregunta) references preguntas(id)
)



insert into encuesta(nombre) values ('los tapones en SD')
insert into preguntas(pregunta, id_encuesta) values ('Cree que es justo esto de abortar?',() )

select * from encuesta
select * from preguntas

SELECT IDENT_CURRENT('encuesta')
