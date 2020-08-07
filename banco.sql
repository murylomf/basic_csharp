CREATE DATABASE fr_consultori;
USE fr_consultori;


CREATE TABLE tbCategoria (
    idCategoria  INT IDENTITY(1,1) NOT NULL  PRIMARY KEY,
    dscCategoria NVARCHAR (50) NOT NULL
);


CREATE TABLE tbProduto (
    idProduto   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nmProduto   VARCHAR (50) NOT NULL,
    idCategoria INT          NOT NULL
);


CREATE TABLE usurario ( 
    username VARCHAR(50) NOT NULL PRIMARY KEY,
    password VARCHAR(50) NOT NULL,
    type varchar (10) NOT NULL

);

ALTER TABLE tbProduto
ADD CONSTRAINT FK_tbProduto_tbCategoria FOREIGN KEY (idCategoria) REFERENCES tbCategoria(idCategoria);