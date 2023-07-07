drop table if exists contatos;
create table if not exists contatos(
id serial primary key,
	name varchar(50),
	image varchar(100),
	telefone varchar(50),
	email varchar(50)
);
select * from contatos;