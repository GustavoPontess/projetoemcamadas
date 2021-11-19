CREATE DATABASE db3camadas; 
USE db3camadas; 

create table tbl_usuarios(
	id int not null auto_increment primary key,
    email varchar(50),
    senha varchar(6)
)engine = InnoDB;

CREATE TABLE tbl_Sorvetes
(
	id        INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	sabor	  VARCHAR(40) NOT NULL,
	marca	  VARCHAR(200) NOT NULL
)engine = InnoDB;

CREATE TABLE tbl_Avaliacao
(
	codigo		   INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    sabor		   VARCHAR(30),
    avaliacao	   varchar(100),
	idSorvete	   INT NOT NULL,
	FOREIGN KEY(idSorvete) REFERENCES tbl_Sorvetes(id)
)engine = InnoDB;

create table tbl_Sujestoes
(
	id int not null auto_increment primary key,
	sujestao varchar(100)
)engine = InnoDB;