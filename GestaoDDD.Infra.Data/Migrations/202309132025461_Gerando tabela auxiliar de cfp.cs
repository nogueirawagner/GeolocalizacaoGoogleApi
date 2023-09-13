namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class Gerandotabelaauxiliardecfp : DbMigration
  {
    public override void Up()
    {
      Sql(@"

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuxiliarCFP](
	[Inscricao] [float] NULL,
	[Nome] [nvarchar](255) NULL,
	[Nota] [float] NULL,
	[Concorrencia] [nvarchar](255) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015900, N' Adalice Flavia Duarte de Medeiros', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008273, N' Adenilson Rutsatz', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10096774, N' Adriana Luiza de Oliveira Silva', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007032, N' Adriana Santos de Jesus', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029804, N' Adriane Godinho', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078977, N' Adriano Augusto Bliska', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038585, N' Adriano Henrique Viana Martins', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055134, N' Adriano Mateus de Souza Campos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072187, N' Adriano Tavares Araujo', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085220, N' Adriel Schumacher Fernandes da Silveira Martins', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063677, N' Ady Coutinho Solino', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065594, N' Aime Feitosa da Costa', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007878, N' Ajalmar Andrade Moura Segundo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082307, N' Alan Guedes Siqueira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044187, N' Alan Pedro Mendes Coelho', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058996, N' Alan Verlaine Dias Silva', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011725, N' Alessandra Garcia Diniz', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069123, N' Alessandra Nascimento da Silva', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036068, N' Alessandra Sousa da Silveira', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002265, N' Alex Alves Murray', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032041, N' Alex de Alcantara Ramos', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073276, N' Alex Rosa de Jesus', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025880, N' Alexandre Cyrino de Sousa', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078109, N' Alexandre Gabriel Silva Rodrigues', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001042, N' Alexandre Gomes Serra', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066884, N' Alexandre Khoury Porto', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018724, N' Alexandre Magno Marques Rodrigues', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011183, N' Alexandre Meirelles Martins', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10097640, N' Alexandre Mendonca SoutoLopes', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004510, N' Alexandre Nepomuceno da Fonseca Meneses', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016636, N' Alexandre Rabelo Tavares', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060734, N' Alexandre Schmitz Hoff', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091408, N' Alexia Grassuri Barreto de Oliveira Demori', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072551, N' Alice Ozorio de Almeida Lima', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058830, N' Aline Machado dos Santos', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039221, N' Aline Vitorassi Moreira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007279, N' Alisson Cardoso Pereira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005857, N' Allan Cezar de Andrade Silva', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10083119, N' Allan dos Santos Silva', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005523, N' Alline Gomes Pereira', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035019, N' Allison Almeida Declie', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008930, N' Aloisio Jose da Silva Junior', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014617, N' Aluan Augusto de Melo Neves', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049030, N' Alvaro Lopes Machado', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066668, N' Alyson Soares dos Santos', 37.63, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002262, N' Amana dos Santos Nesimi', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060061, N' Amanda Almeida Costa', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026540, N' Amanda Araujo de Oliveira e Souza', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028804, N' Amanda Cristina Lopes dos Santos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033828, N' Amanda de Castro Bernardes', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016941, N' Amanda Dornelas da Silveira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008648, N' Amanda Gomes Moreira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006031, N' Amanda Juliana Rocha Araujo', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006204, N' Amanda Karla Sena Dourado', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021005, N' Amanda Soares de Souza', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014085, N' Amanda Valerio Olsen', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028186, N' Amaury de Souza de Pontes', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012124, N' Ana Beatriz Guedes Cota', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007097, N' Ana Carolina Cotta', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019004, N' Ana Carolina Croner de Abreu', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040911, N' Ana Carolina Miranda Abecassis', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035918, N' Ana Carolina Salazar Albuquerque', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004645, N' Ana Clara de Almeida Bossi Guimaraes', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000038, N' Ana Clara Nunes Mendes', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049415, N' Ana Clara Pimenta Freire', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004244, N' Ana Clara Viana Lima', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079862, N' Ana Flavia Cardoso Almeida', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002741, N' Ana Gabriela Ferreira Miranda', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051105, N' Ana Gabriela Pereira da Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000197, N' Ana Jessica Figueiredo Dutra', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026126, N' Ana Karolina Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005804, N' Ana Karoline Ferreira', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055572, N' Ana Luisa Fernandes dos Reis', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004713, N' Ana Luisa Sa de Oliveira', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053254, N' Ana Paula Alvarenga Martins', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077467, N' Ana Paula Bombarda', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086809, N' Ana Paula Martins de Aguiar', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070133, N' Ana Paula Nascimento da Silva Andrade', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020622, N' Ana Paula Souto Villarinho', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045246, N' Ananda de Cassia do Nascimento Laurent Rocchi', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020031, N' AnandaFernandes Constantino', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086144, N' Anderson Carvalho de Loiola', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004275, N' Anderson Cesar Pereira da Silva', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025984, N' Anderson Garofalo Pinto', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053500, N' Andre Augusto Braz Mota', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054722, N' Andre Barbosa Botelho', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020862, N' Andre Bilro Pereira de Araujo', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012610, N' Andre de Carvalho Pereira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062554, N' Andre Frederico Barreto Leite', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008546, N' Andre Holanda Cavalcante Castellanos Hornos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10093095, N' Andre Honorato Marins', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025983, N' Andre Luis Areias de Moraes', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046921, N' Andre Luiz Barros Almeida', 36.08, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006052, N' Andre Victor Goncales Rodrigues Rios', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024477, N' Andrea Costa de Lucena', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006487, N' Andreia Moreira Cipriano', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038133, N' Andreza Santos de Mesquita Bomtempo', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021710, N' Andrini Bethowen Bouzas de Oliveira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021976, N' Angelina Segre Melhoranca', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046944, N' Angelo Jose da Silva Filho', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057129, N' Antonio Gabriel Bini Augusto', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068965, N' Antonio Rafael Silva Brito', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033331, N' Antony Goncalves Carvalho', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058364, N' Ariadna Jesus Lopes da Silva', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052049, N' Ariana Engelmann Rodrigues Aragao', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007509, N' Arielle Lima Celestino', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021875, N' Arthur Araujo de Sousa', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021041, N' Arthur de Freitas Miranda', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082863, N' Arthur de Lima Henriques da Silva', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026608, N' Arthur Galileu Veleci Tome', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015833, N' Arthur Gouvea Fernandes', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062388, N' Arthur Jorge Lins Mendonca', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058322, N' Arthur Machado Gomes Barbosa Souto', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068922, N' Arthur Nobre Brito', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062586, N' Arthur Nunes Correia', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021904, N' Arthur Simas Pinheiro', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059650, N' Arthur Tamayo de Lima', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011444, N' Arthur Uranio Mota Coutinho', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012221, N' Artur Albuquerque de Queiroga', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068379, N' Artur Tavares Pereira Soares', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027862, N' Augusto Cesar Lisboa Martins', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047153, N' Augusto Luis Torquete de Oliveira', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012337, N' Auiris Ferreira da Silva', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021102, N' Barbara Carvalho de Moura', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053699, N' Barbara David Neves de Lima', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046093, N' Barbara Elias Rodrigues', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000558, N' Barbara Ranny de Oliveira Vieira da Silva', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025297, N' Barbara Rodrigues Sampaio', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011747, N' Barbara Tobias da Fonseca', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037931, N' Barbara Xavier Cavalcanti', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065118, N' Beatriz Costa Soares', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024702, N' Beatriz Machado Willman Saar', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040764, N' Beatriz Pereira Santos', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005967, N' Bernardo Carius Ceschini', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041943, N' Bernardo Moreira Pinto', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002300, N' Betina Dall Oglio Stacke', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008413, N' Brenda Bianca Neves Dias', 37.63, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000503, N' Breno Douglas Galvao de Paiva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030612, N' Breno Vinicius de Sousa Duarte', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044006, N' Bruna Araujo Pinto', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012032, N' Bruna Dutra Donzelli', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038558, N' Bruna Fagundes Perfeito', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070781, N' Bruna Monyque Borges Santos', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051248, N' Bruna Ribeiro de Almeida', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008573, N' Brunno Franca de Oliveira', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009586, N' Brunno Nascimento Moura', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021472, N' Bruno Ali Abou Ali', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010288, N' Bruno Araujo Lima', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053403, N' Bruno Barbosa da Silva', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10088881, N' Bruno Batista Suehara', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067040, N' Bruno Bergamaschi Mazega', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018132, N' Bruno Beserra Assuncao', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029952, N' Bruno Cesar Sampaio Ribeiro de Assis', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001622, N' Bruno da Silva Coelho', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053929, N' Bruno de Sousa Barros', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013093, N' Bruno Haack de Arruda Dutra', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006489, N' Bruno Hebert de Almeida Nunes', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045320, N' Bruno Henrique Santos Cavalho', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011060, N' Bruno Saboia Demeterco', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035133, N' Bruno Sartori de Campos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10100683, N' Bruno Soares Santos Araujo', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017729, N' Bruno Uemura Ribeiro', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067867, N' Bruno Vinicius de Oliveira Andrade', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032383, N' Cainan de Negreiros Martins Leite', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008710, N' Caio Cesar Mascena Lima', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10080938, N' Caio Cesar Nogueira Claudino', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067228, N' Caio de Aguiar Pires Moreira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10056148, N' Caio Santana Rodrigues de Lima', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069582, N' Caio Vinicius Aguiar de Andrade', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013071, N' Camila de Figueiredo Barbosa Bastos', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022621, N' Camila Mota Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069981, N' Camila Rodrigues Celestino', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015369, N' Camila Viviane Araujo dos Santos', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036490, N' Camilla Amaro Santos', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10098487, N' Camylla Silva Batista', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069819, N' Carina Cardoso Carrijo Lintomen Azevedo', 50, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10099045, N' Carla Nazareth Mendes Melo Barros', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079782, N' Carlos Alberto Alves de Lima Junior', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10080819, N' Carlos Augusto Bernardes Ribeiro', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041615, N' Carlos Augusto de Carvalho Junior', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043070, N' Carlos Fernando Rodrigues Santos Barbosa', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10083269, N' Carlos Henrique Catrinque Andrade', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029447, N' Carlos Henrique de Lucena Sampaio Junior', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024153, N' Carlos Magno Machado Lemos', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041198, N' Carlos Phelipe Matias e Silva', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007292, N' Carlos Tadeu de Alencar Barreira Junior', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075760, N' Carolina Arruda dos Santos', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025957, N' Carolina Athayde Azambuja', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045080, N' Carolina de Oliveira Moura', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002814, N' Carolina Farias Ferreira Moretto', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002252, N' Carolina Rocha Parente', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008837, N' Caroline Almeida Sodre', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052103, N' Caroline Cerqueira Alves Ferreira', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021075, N' Caroline Gomes Carvalho', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011848, N' Caroline Morais Martins', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028910, N' Carolyne Thaina de Holanda Cavalcante', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058526, N' Catryna Garcia Camargos', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010668, N' Cauhe Lima Nogueira', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028673, N' Celso Rafael de Melo Silva', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048723, N' Cesar Alexandre Saraiva de Sousa', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025931, N' Cesar Rodrigues de Queiroz Macedo', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017571, N' Charles Henrique Souza de Jesus', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064716, N' Christian Borges de Oliveira', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058504, N' Cicely Weluma Rossi de Lima', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018084, N' Cindy de Souza Tavares', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035024, N' Cinthia Barbosa da Silva', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066533, N' Cintia Almeida Barbosa', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024641, N' Cirano de Macedo Teles Junior', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013190, N' Ciro Augusto Coelho de Almeida', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002663, N' Ciro Camilo Santos Leal', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077057, N' Claudio Cristian de Souza Campos', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014703, N' Claudio da Silva Gomes Filho', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10074226, N' Cleverson Aparecido Garcia Lara', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041456, N' Cristian de Sousa Ramos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049460, N' Cristian Ramos de Oliveira Grilo', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000270, N' Cristiane Ferras Bolico Rodrigues da Silva', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006478, N' Cristiane Ximenes da Silva', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002338, N' Cristiano Curado Abrantes Caetano', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079222, N' Cynthia Magalhaes da Costa', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000508, N' Daiane Braz Neri', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007386, N' Daiele Ruana Lima dos Santos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055138, N' Dalila Vilas Boas Souza Magalhaes da Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015600, N' Damaris Moreira de Lima', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062080, N' Daniel Bernardo de Souza Santos', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006242, N' Daniel Brant Llorente Barrio', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023217, N' Daniel Dias Ribeiro', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055835, N' Daniel dos Anjos Gomes da Silva', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086801, N'Daniel Duim', 48.97, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002615, N' Daniel Falcao da Rocha', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004031, N' Daniel Fonseca Pimentel', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003796, N' Daniel Lelis de Oliveira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059036, N' Daniel Souza Matos', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014688, N' Daniel Viny Dourado Costa', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013313, N' Daniela de Paula', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034236, N' Daniela Maia Baruzzi', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000349, N' Daniella Montenegro Bazzi', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025804, N' Danielle Moreira Clarindo', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026010, N' Danielle Pereira Gonzalez da Silva', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033064, N' Danielle Prado de Araujo', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031045, N' Danielle Tuanny Alves Ferreira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10088836, N' Danielly Quintas Cascelli de Azevedo', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009813, N' Daniely Bonfim de Sousa', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020650, N' Danillo Franca Neves', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027209, N' Danillo Gaia Duarte de Lima', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041199, N' Danilo Feitoza Melo', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005105, N' Danilo Fialho Severino', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000429, N' Danniel Dias Rocha', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053883, N' Dante Akira Uwai', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045428, N' Danusa de Castro Fonseca', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055957, N' Danyllo Cardoso Costa', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052242, N' Danylo Vieira Vasconcelos Oliveira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009413, N' Dario Carlos Ribeiro Ramires Junior', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016150, N' Davi Dantas Domingos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085743, N' Davi de Almeida Freitas', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061065, N' Davi de Souza Moreira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008489, N' Davi Spinola de Jesus Almeida', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002030, N' Davi Teixeira e Silva', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050195, N' David de Castro Martins', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053124, N' David Eloi Nunes', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014698, N' David Wilker da Silva Roma', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066179, N' Davson Bruno da Silva Melo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037884, N' Dayane Lucia Pires Ferreira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017398, N' Dayvisson de Paula Climaco', 34.02, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068199, N' Debora Alves Sousa', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024854, N' Debora Tays Oliveira de Brito Marubayashi', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018848, N' Deivid Melo da Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013427, N' Denilson Santiago Barbosa', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028382, N' Diana Nunes de Oliveira', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061864, N' Diego Aires Jacome', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003186, N' Diego Alves de Lima', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063368, N' Diego Batista Morais e Silva', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030952, N' Diego Becker Griebler', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085656, N' Diego Bezerra Barbosa', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014946, N' Diego dos Santos Tavares', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009971, N' Diego Goncalves Ribeiro', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026936, N' Diego Machado dos Santos', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005748, N' Diego Moreira Carmino', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052088, N' Diego Rafael Sena Gomes', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047094, N' Diego Ramon Cordeiro Santos', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018583, N' Diego Ribeiro de Souza', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021592, N' Diogenes Martins de Siqueira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009735, N' Diogo Andrade do Nascimento', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012754, N' Diogo Martins Ferreira', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068688, N' Diogo Silva Naves', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001213, N' Dominique Heron da Silva Lorenzi', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033240, N' Douglas Cantudo Goncalves', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059992, N' Douglas de Sousa Bezerra', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050396, N' Dyego Barros Luz', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026933, N' Edgar Bellini Xavier', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001660, N' Edielle de Oliveira Lagares', 35.57, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10088667, N' Eduardo Augusto Brandao Duarte', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007689, N' Eduardo Basilio de Albuquerque', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045067, N' Eduardo Dunck Oliveira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025275, N' Eduardo Eiler Batista de Araujo', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053328, N' Eduardo Fernandes Mariano', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072204, N' Eduardo Figueiredo Fialho', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005978, N' Eduardo Leal Trindade', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003440, N' Eduardo Lucas de Sousa Borges', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032780, N' Eduardo Marques de Souza', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000749, N' Eduardo Naves Cardoso', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046823, N' Eduardo Novakovski Machado', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037365, N' Eduardo Schuabb Duarte', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064808, N' Eduardo Vieira de Araujo Junior', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028171, N' Egon Vinicius Dalinghaus', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030596, N' Elanio Cavalcante Fontenele', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001417, N' Elcinara da Silva Tenorio', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000089, N' Eliane Santos Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065168, N' Elias da Costa Belinazo', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018720, N' Elica Rocha Rodrigues', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066392, N' Elineide Maheli de Oliveira Carvalho Zigunow', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031443, N' Elizabeth Cristina Tenreiro Cavalcante', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067638, N' Ellen Pereira de Normando', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10101429, N' Ellionay Sousa de Freitas', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008480, N' Ellyka de Queiroz Ornelas Araujo', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002397, N' Elves Junior Medina Brandao', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000230, N' Emely Crisley Florentino Lemos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012569, N' Emilcy Felipe Cumpertino de Paula', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016949, N' Enielle Donda Fernandes da Silva', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086884, N' Eric de Almeida Alvarenga', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10098140, N' Eric Vonderscher', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063818, N' Erica Fonteneles de Souza', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017325, N' Erika Melo Nogueira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012190, N' Eslen de Souza Araujo', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035941, N' Euzebio Alvarenga Santana', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037198, N' Ewerton Cruz Soares', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023828, N' Ewerton Renan Aguiar de Sampaio', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009894, N' Fabiana de Oliveira Ozaka', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010796, N' Fabiana Koffes Marinho', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008777, N' Fabiane Cileia Oliveira Soares', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011515, N' Fabiano Dutra de Azevedo', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010850, N' Fabio Cruz dos Reis', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004787, N' Fabio da Silva Gomes', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012306, N' Fabio de Godoy Penteado', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10080935, N' Fabio Soller Cruz de Souza', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061009, N' Fagner Galvao Fernandes', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013934, N' Felipe Bergamaschi Brettas', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005197, N' Felipe Braga Viana', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005519, N' Felipe Chiarelli Linhares Titoneli', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061672, N' Felipe de Almeida Cimas', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001731, N' Felipe dos Santos Faria', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008539, N' Felipe Douglas Santos da Silva', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036667, N' Felipe Elias Menezes', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10093077, N' Felipe Figueira de Sales Pereira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10083609, N' Felipe Franco do Vale', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078445, N' Felipe Goncalves Muniz', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033862, N' Felipe Henrique Teles de Faria de Souza', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071612, N' Felipe Jose Gustavo de Oliveira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014715, N' Felipe Magalhaes Alves', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028637, N' Felipe Marques Figueira Barbosa', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018383, N' Felipe Mello Gonzaga', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004243, N' Felipe Milhomem Ribeiro', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002237, N' Felipe Santos Magnani Carneiro', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001871, N' Felipe Schaper Ferraz', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016543, N' Felipe Tobias Costa de Almeida', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003525, N' Felipe Torres Martins de Serpa', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077141, N' Felipe Vargas Grey Tavares', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071023, N' Felippe Henrique Almada Albuquerque Moreira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061014, N' Fernanda Borges Barros', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013026, N' Fernanda Caetano Raffs Strasser', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016055, N' Fernanda Delgado de Vasconcelos', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042332, N' Fernanda Gabriela de Souza Almeida e Abreu', 49.48, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006435, N' Fernanda Lima Gomes de Matos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077908, N' Fernanda Maia Bravo Pinheiro', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021131, N' Fernanda Martins Rocha', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029028, N' Fernanda Miranda de Souza', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077118, N' Fernanda Pimentel Hermida Bernardes', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009092, N' Fernanda Rocha Vieira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016052, N' FernandaSchreiber', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002253, N' Fernanda Takako Hirayama', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046573, N' Fernanda Vianna Couto', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026511, N' Fernando Bergamo', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070045, N' Fernando Cesar Pereira da Costa', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078202, N' Fernando Henrique Laurenti Zaparoli', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001369, N' Filipe Aguiar Rodrigues', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029790, N' Filipe Augusto de Souza Viana', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007751, N' Filipe de Oliveira Pereira', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045006, N' Filipe Humberto Oliveira Drumond Albuquerque', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070102, N' Filipe Israel Azevedo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10097354, N' Filipe Lima Ribeiro', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063291, N' Filipi Teles da Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078105, N' Fillipe Alexandrino Barbosa Figueiredo', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042798, N' Flavia Maria Alves Caetano', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027489, N' Flavio Toscano Alves', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014467, N' Flavio Winicius de Moraes Martins', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10102979, N' Franciane Carina Gerioni', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055761, N' Franciele Zambone Silva', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011108, N' Francinildo Costa Mesquita', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031939, N' Francioli Tonin', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032690, N' Francisco Anderson Bezerra Rodrigues', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002876, N' Francisco de Assis de Oliveira Silva', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030914, N' Francisco Eduardo Vieira de Araujo', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010443, N' Francisco Jefferson da Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000793, N' Francisco Jose Prezado Louro Marques', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065056, N' Francisco Junior de Azevedo', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007595, N' Franklin Delano Varela Amador', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057242, N' Frederico Campos Leao', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008459, N' Frederico Silva Lopes Aguiar', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019170, N' Gabriel Abi Chahin de Oliveira Ferreira', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003749, N' Gabriel Arana da Silva', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004960, N'Gabriel Botelho Mercon', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037952, N' Gabriel Carvalho Nunes Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003374, N' Gabriel Cavalcante Rodrigues', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10105853, N' Gabriel de Andrade Paiva', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015152, N' Gabriel de Campos Soares Lopes', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044799, N' Gabriel de Melo Tavares dos Santos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081676, N' Gabriel Ferreira e Campos Pereira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019641, N' Gabriel Henrique Bragagnolo Chiaradia', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036030, N' Gabriel Henrique de Almeida', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021147, N' Gabriel Henrique Silva Araujo', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059435, N' Gabriel Ismael da Silva', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010781, N' Gabriel Leite Monteiro Fortes', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005279, N' Gabriel Lemos de Oliveira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052151, N' Gabriel Lima de Oliveira', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044600, N' Gabriel Lima Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008827, N' Gabriel Lira do Nascimento', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023602, N' Gabriel Maiello Itaborahy Costa Ferreira', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045553, N' Gabriel Moraes de Aquino', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086689, N' Gabriel Nasser Saad Filho', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019156, N' Gabriel Resende Assis', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085299, N' Gabriel Ribeiro Braga', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001438, N' Gabriel Ribeiro de Araujo', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060343, N' Gabriel Salazar Maia', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062094, N' Gabriel Tolentino Costa Ferreira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091890, N' Gabriel Trinca Dutra', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014097, N' Gabriela Alves Costa', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037076, N' Gabriela Araujo Correa', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062285, N' Gabriela Araujo dos Santos Mesquita', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011181, N' Gabriela Gomes Guerra de Magalhaes', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000149, N' Gabriela Marques de Moura Arruda', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048196, N' Gabriela Moreno Gentilin de Menezes', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068723, N' Gabriela Soares de Rezende', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012939, N' Gabriela Tavares de Oliveira Ferreira', 48.97, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10097750, N' Gabriela Teixeira Pazzine', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037100, N' Gabrielle Gomes da Silva', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005198, N' Gabryella Melo Silveira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003335, N' Geanderson Ramos de Alencar', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065333, N' Geisiane Peixoto Borges', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000436, N' Geislanio de Freitas Amancio', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038132, N' Genisson dos Reis Santos', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058083, N' Gerson Brian Gomes Evangelista', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037385, N' Getulio Pedro de Melo Filho', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007273, N' Gibran Daoud', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070759, N' Gibran Kahlil Gazel', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053819, N' Gilberto Andre da Costa Filho', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006746, N' Giordano Bruno Maciel de Oliveira', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006215, N' Giovanna Pedroza Nunes de Oliveira', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021154, N' Gisella Teixeira Guimaraes Moreira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032952, N' Gislene Ferreira Batista', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046920, N' Gizele Pires Arruda Pereira da Silva', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050828, N' Glaucimarlus Souza Ramos', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075801, N' Gleisson Mateus de Souza', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001420, N' Gregorio Fernandes Pimenta dos Anjos', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038788, N' Guilherme Almeida de Brito Barutti', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035323, N' Guilherme Atila Martins Lacerda', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001286, N' Guilherme Augusto da Silva Bertaci', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029680, N' Guilherme Augusto Lana Nonato', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012115, N' Guilherme Bicalho Monteiro de Castro', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013581, N' Guilherme Camargo Alves', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012673, N' Guilherme Carneiro Sarmento', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031799, N' Guilherme Farias Prux', 37.63, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046745, N' Guilherme Hagen Evangelista da Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047785, N' Guilherme Henrique Pereira Ramos', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10104731, N' Guilherme Henrique Soares Felix', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067566, N' Guilherme Lino Santos Santana', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030172, N' Guilherme Mendes Tavares', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016090, N' Guilherme Mendonca da Silva', 49.48, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008917, N' Guilherme Pires Saraiva', 48.97, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039231, N' Guilherme Ribeiro de Araujo', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031165, N' Gustavo Alves Ferreira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10088223, N' Gustavo Barbosa Machado', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057557, N' Gustavo Carrilho Castro', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003590, N' Gustavo Cruz Damico Campello', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077393, N' Gustavo de Almeida Ferreira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066250, N' Gustavo de Souza Silva Seara', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073642, N' Gustavo Ferreira Rodrigues', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063225, N' Gustavo Goncalo Rodrigues', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060642, N' Gustavo Gualda Goncalves', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060014, N' Gustavo Henrique Clement Souza', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040844, N' Gustavo Latuf Ayres', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008013, N' Gustavo Marques de Azevedo', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010261, N' Gustavo Nunes Ribeiro', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050697, N' Gustavo Reis', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017608, N' Gustavo Verissimo Guimaraes', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035933, N' Hana Augusta de Andrade', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077481, N' Handerson Jose dos Santos', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061338, N' Hebert Kley Lageano de Oliveira', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045945, N' Heitor Alves Rios Campos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10099489, N' Hellen Noleto Pereira Costa', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011480, N' Henrique Carreiro Duarte Araujo Pereira', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016809, N' Henrique Erik Damasceno Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077571, N' Henrique Miquelissa Dalcomuni', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046722, N' Herbert Fraga Sousa de Oliveira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044284, N' Heverlyn Dyanne Teles de Miranda', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053430, N' Hiago Rogerio Ulhoa', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006996, N' Higor Barbosa de Souza', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018503, N' Higor Douglas Souza Costa', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005029, N' Hortensia Pereira de Souza', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019726, N' Hudson Henrique Calixto Eller', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052229, N' Hugo Alves Feletti', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000947, N' Hugo Daniel Carvalho Pereira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10089670, N' Hugo de Oliveira Arruda Badin', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081708, N' Hugo Lopes Neves', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061988, N' Hugo Vitor Alves Costa', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000035, N' HumbertoAlves Brito Sousa de Melo', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001272, N' Humberto Cezar Gama Guimaraes', 48.97, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025523, N' Humberto Gonczarowska Jorge', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001826, N' Humberto Solano de Freitas Junior', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049511, N' Hyan Fellipe Maximo da Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046562, N' Hyara Pereira Cumaru', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065508, N' Iago Matteo Calleri', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055039, N' Ian Alvares dos Prazeres Filho', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000494, N' Igor Augusto Alves Dias', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10098652, N' Igor Bosco Soares', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010308, N' Igor Matheus Gomes Goncalves', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032546, N' Igor Nunes Hoffmann', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082966, N' Igor Rogerio Araujo de Sousa', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068784, N' Igor Soto Silawsky', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055793, N' Igor Teixeira Pfrimer', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061459, N' Ilane Vieira Nunes', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040421, N' Ingrid Fernanda de Sousa', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065184, N' Ingrid Moreira Felinto de Oliveira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015933, N' Iracema Rocha Souza', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000514, N' Iris Esteves Martins Pinto', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002787, N' Isaac Johnson Vasconcelos Elias', 37.63, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044879, N' Isaac Lucas Sousa Alves Lima', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033616, N' Isabela Bastos Serwy', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006223, N' Isabela Brito Couto de Oliveira', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050894, N' Isabela Guimaraes Prado', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071025, N' Isabela Laus Saldanha', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050001, N' Isabela Luisa Zardo e Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030787, N' Isabela Marques Santos', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044580, N' Isabela Provensani Valentim', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018723, N' Isabela Silva Lara Reis', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013117, N' Isabela Soares Oliveira Cancado Ferreira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021856, N' Isabella dos Santos Silva', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059163, N' Isabella Ribeiro Araujo', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015503, N' Isabella Santos da Silva', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037112, N' Isabelle Nolasco de Oliveira', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036786, N' Isadora Abdalla Amorim', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005121, N' Islla Pessoa Fernandes Torres', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013872, N' Ismael Rodrigues dos Santos', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047326, N' Ismael Verissimo dos Santos Junior', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001299, N' Israel Ferreira Soares', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030027, N' Ivan de Oliveira Lobo Neto', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008613, N' Ivana Colares Mendes de Almeida', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048239, N' Ives Plinio de Jesus Oliveira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082563, N' Izadora Pimenta Rocha Carvalho', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10056508, N' Jackson dos Santos Anjos', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021757, N' Jader Batista Mendes', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068081, N' Jalles Moreira Rocha dos Santos', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076880, N' James Bernardes de Almeida Junior', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051563, N' Jamile Lobao Teixeira', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014194, N' Janaina de Souza Dourado Gomes', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022011, N' Jaqueline Alves Alencar', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062144, N' Jaquelline Barros de Oliveira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048292, N' Jardel Cavalcante Rolim', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000775, N' Jasmine Frutuoso da Silva', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079371, N' Jean Ismael Agripino Ferreira dos Santos', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061041, N' Jeancarlos da Silva Junior', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028585, N' Jeferson Amorim Mamed', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046475, N' Jeferson Neves da Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012919, N' Jefferson Beijamim dos Santos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078993, N' Jessica Gomes de Almeida Maia', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039934, N' Jessica Karoline Nogueira da Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062799, N' Jessica Machado Horn', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004709, N' Jessica Oliveira Neiva', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006474, N' Jessica Oliveira Shneider Nobre', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019492, N' Jessika Alves dos Santos', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10074815, N' Jhemerson Soares Lisboa', 37.63, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047420, N' Jhonatan Testa', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055143, N' Jhuly Kelly Ferreira Rodrigues', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021602, N' Joao Batista Sousa Monteiro Junior', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013825, N' Joao Felipe Nunes de Miranda', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013459, N' Joao Gabriel de Aguiar Carvalho', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049073, N' Joao Guilherme Martins Soares', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007714, N' Joao Henrique Ferreira Mendes', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10098824, N' Joao Lucas Magalini Zago', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042894, N' Joao Lucas Santos Flores', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010290, N' Joao Luis Machado Vasconcelos', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032447, N' Joao Luiz Farinon', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012137, N' Joao Paulo Cardoso Zandonade', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035972, N' Joao Paulo de Castro Carisio Ribeiro', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005190, N' Joao Paulo Pinto Van Der Vliet', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009181, N' Joao Pedro Koerich', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049781, N' Joao Pedro Pires Sampaio', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041521, N' Joao Victor Carneiro Alves', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055608, N' Joao Victor Carvalho Freire Bezerra', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023608, N' Joao Victor Couto de Resende Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023396, N' Joao Victor Diniz Campos Dias', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015196, N' Joao Victor dos Santos Rodrigues', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025038, N' Joao Victor Santiago Queiroz', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10099095, N' Joao Victor Tomaz Anacleto', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026533, N' Joao Vitor Afonso Ribeiro de Oliveira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029562, N' Joao Vitor da Silva Morais', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037276, N' Joao Vitor Fernandes de Oliveira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037287, N' Joheser Wellington de Barros Pereira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10103953, N' Jonatas Aryel de Araujo Silva', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011506, N' Jonathan Henrique Wanderley dos Santos', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067304, N' Jones de Araujo Pereira', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073858, N' Jorge Andre de Paiva Martins', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061842, N' Jorge Eduardo Nunes Ribeiro', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055880, N' Jorge Henrique Neves Alcantara Junior', 36.08, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008414, N' Jorge Lucas Costa Santiago', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044926, N' Jorge Luis Saturnino da Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076448, N' Jorge Thiago Silva Silveira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086362, N' Jose Ademir dos Santos Filho', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068311, N' Jose Carlos Dias de Souza Junior', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050553, N' Jose Carlos Nogueira Ferreira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067472, N' Jose de Alsimir Gomes Junior', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030060, N' Jose IgorFeitosa do Nascimento', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053221, N' Jose Igor Rocha de Moura', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043650, N' Jose Lidberg Rocha Lima Filho', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020026, N' Jose Luiz Neves dos Santos Junior', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10103331, N' Jose Ribamar Sousa Duarte Junior', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10088140, N' Josefa Helena de Aguiar', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001539, N' Jouberth Maia Oliveira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031616, N' Joucafly Arruda Santos', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063467, N' Joyce Bonfim Pessoa', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004848, N' Joysse Vasconcelos Franca', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023423, N' Juan Francisco Neves Tanajura', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003320, N' Julia Beutel Semenzato Ferrer', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021745, N' Julia de Castro Ferreira', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037698, N' Julia Morais Roriz dos Anjos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022419, N' Julia Scarponi Pinto Costa Pereira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058577, N' Juliana Bertoldo Alvares', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011029, N' Juliana Bezerra Carneiro', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002689, N' Juliana do Carmo Mangueira Celestino', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013602, N' Juliana Lopes Navarro', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007325, N' Juliana MoreiraMoraes', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014275, N' Juliana Pereira Moreira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075461, N' Juliana Vieira Zuany', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066632, N' Juliane Barbosa Pereira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004216, N' Juliano Brauller Macedo', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013138, N' Juliano Pereira dos Santos Abrahao', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022555, N' Julio Cesar Batista Leitao', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003680, N' Julio Cesar Lima Madalena', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067905, N' Julio Cesar Martins Vaz', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010193, N' Jullia da Mata Almeida', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007686, N' Juvenil Rodrigues da Cruz Junior', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014427, N' Kamila Rodrigues Barbosa', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009823, N' Karen Alves Pereira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010539, N' Karen Rayane Lopes Alves', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054149, N' KarlaFernanda Soares', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007367, N' Karla Pereira Alves', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006040, N' Karolinne Araujo Souza', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040419, N' Karolline Ambrosi Tosta', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010832, N' Kassius Anchesqui Nardoto', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018735, N' Katheryne Ferreira Carvalhaes', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007636, N' Katia de Carvalho Prado', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082231, N' Kemylla Passos Mesquita', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032820, N' Kenia Guimaraes de Amorim', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011683, N' Kevin Matheus Monteiro Leite', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10105746, N' Kiane Santos Braga', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003927, N' Kleber Amano Cipriano', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029414, N' Kledson Willy dos Santos Ferreira', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004473, N' Krisllayne de Oliveira Fernandes Caldas', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006062, N' Lais Bandeira Lopes', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005731, N' Lais Barreto de Araujo', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023469, N' Lais de Sousa Lima Reboucas', 48.97, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032581, N' Lais Santillo Morais', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070907, N' Lara Sena Scapetti Almeida', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10087825, N' Larissa Alves da Silva', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071326, N' Larissa Borges Fogaca', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055844, N' Larissa Cardoso Lacerda', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059504, N' Larissa Ellen Monteiro Maciel', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082094, N' Larissa Laiz Monteiro de Farias', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045292, N' Larissa Pires de Azevedo', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085240, N' Laryssa Evelyn Guilardi Araujo', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005309, N' Laura Maria Damascena Prado', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055523, N' Leandro Alberto da Cruz Demosthenes', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001377, N' Leandro Binueza do Vale', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081546, N' Leandro Lima de Souza', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015035, N' Leandro Martins de Sousa Franca', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065570, N' Leandro Miranda Costa', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065640, N' Leandro Rafael do Nascimento Silva', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059002, N' Leandro Simoes Dias', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030376, N' Leandro Xavier Rapini', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006191, N' Lee Harrison Wall dos Santos', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024684, N' Lenai Martins Oliveira', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071479, N' Leonan Bezerra Araujo', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10056157, N' Leonardo Alves de Oliva Passos', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071592, N' Leonardo Bertuol Guimaraes', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000327, N' Leonardo Camargo de Moura Leocadio', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024179, N' Leonardo Carvalho de Medeiros', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012713, N' Leonardo de Moura', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10097045, N' Leonardo de Oliveira Ramos', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009101, N' Leonardo Dias Carneiro', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059212, N' Leonardo Leandro Furquim', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027030, N' Leonardo Marinho Marquesda Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004508, N' Leonardo Meneses Cabral', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000364, N' Leonardo Nunes da Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012955, N' Leonardo Pedro Santos Liborio', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015593, N' Leonardo Soares Albuquerque', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041940, N' Leonardo Souza Medeiros', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10102333, N' Leonardo Yuji Kato Rodrigues', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017242, N' Leonardo Zarattini Martins', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10083694, N' Leticia Batista Merencio de Lima', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020117, N' Leticia Bettina Granados Goulart', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060711, N' Leticia Cantuaria Santos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054677, N' Leticia Goncalves Valfre', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065580, N' Leticia Lopes Campos', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091776, N' Lhuan Terra Diego de Souza Gomes', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020609, N' Lidia Silva Saldanha', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002599, N' Lincoln Pinheiro de Oliveira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042800, N' Lionaria Karine de Morais', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003124, N' Lisle Marina Araujo do Nascimento', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002725, N' Livia Chaves Saito', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10092406, N' Loren Lopes Machado', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055232, N' Lorenna de Souza Nascimento do Carmo', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067942, N' Lorrany Gregorio Magalhaes', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028855, N' Lorrayne Virote da Silva', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071811, N' Luan Ribeiro Costa', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042752, N' Luan Torres Topdjian', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067233, N' Luana Gomes de Oliveira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018196, N' Luana Silva Oliveira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059307, N' Lucas Alves de Souza', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002486, N' Lucas Alves Dias', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017604, N' Lucas Augusto Borges Pereira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043628, N' Lucas Baldasso', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021467, N' Lucas Barros Sales dos Santos', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076493, N' Lucas Cordeiro Silva', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060836, N' Lucas da Costa Lima', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062303, N' Lucas da Silva Vieira', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003024, N' Lucas Dadona Chiaradia Braga', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10098927, N' Lucas de Alencar Oliveira', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006450, N' Lucas de Santana Silva', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000883, N' Lucas Felipe Pereira Nunes', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026123, N' Lucas Ferreira Fernandes', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004768, N' Lucas Fonseca Davila', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070198, N' Lucas Gabriel de Sousa Lara', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061145, N' Lucas Gustavo Souza de Melo', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079476, N' Lucas Henrik Lira da Silva', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007528, N' Lucas Henrique Rosa do Nascimento', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072159, N' Lucas Hideo Hataka Koyama', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001043, N' Lucas Lassi Puglia', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076691, N' Lucas Liberal', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069470, N' Lucas Magalhaes Prates de Lima', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072081, N' Lucas Martins Ramalho', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057539, N' Lucas Moraes Leocadio de Souza', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017070, N' Lucas Moreira da Mota', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079037, N' Lucas Moreira Lima', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046005, N' Lucas Moreira Rabelo', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029084, N' Lucas Nascimento Ferreira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058745, N' Lucas Oliveira Pedreira', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060031, N' Lucas Pacheco Barreto', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018115, N' Lucas Ribeiro de Miranda', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065964, N' Lucas Rodrigues de Araujo Ledo', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050489, N' Lucas Rodrigues Rego', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010460, N' Lucas Silva Casadio', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049031, N' Lucas Souza Araujo', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011474, N' Lucas Vale Adjafre', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091029, N' Luciana Caetano Yamanaka', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081572, N' Luciana Graever de Medeiros', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013961, N' Luciana Nobrega', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039480, N' Luciano Beck Halfen da Porciuncula', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10097142, N' Luciano Reis de Oliveira Silva', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055996, N' Lucielen Martins da Rocha', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059975, N' Ludimilla Batista Pinheiro Marques', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060829, N' Ludmila Daniele Lopes', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012902, N' Ludmilla Eleuterio Rodrigues', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043547, N' Luis Felipe de Oliveira Dourado', 33.51, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044914, N' Luis Felipe Torres Caetano', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032216, N' Luis Fernando Serrao Fabio', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029886, N' Luisa Morais Costa Teixeira', 48.97, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010959, N' Luisa Viana Luniere de Azevedo', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007414, N' Luiz Antonio Euzebio de Freitas Filho', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036979, N' Luiz Claudio da Silva Medeiros Junior', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016295, N' Luiz de Jesus Nunes da Silva', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002589, N' Luiz Eduardo Paes Pereira da Silva', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043901, N' Luiz Felipe Andrade Pires de Siqueira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064043, N' Luiz Felipe Barbosa Pinheiro', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082496, N' Luiz Felipe Martins de Souza', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007541, N' Luiz Guilherme Araujo de Andrade', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002759, N' Luiz Guilherme Campos de Oliveira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011935, N' Luiz Henrique Rodrigues Muniz', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034498, N' Luiz Mauricio Soares de Andrade', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042244, N' Luiz Phellipe Ribeiro Rodrigues', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007397, N' Luiz Tadeu Miranda da Silva', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005302, N' Luiza Holanda Barbosa Araujo', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002523, N' Luiza Pinheiro Andrade Viana', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023308, N' Lurien Gomes do Carmo', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042228, N' Luthiane Aparecida Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086869, N' Macelio Pedrosa Vieira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028974, N' Maiara Neri Josino', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001949, N' Maiara Teodoro', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011140, N' Maiko Alves de Castro', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065004, N' Maira dos Santos Freitas', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070584, N' Maisa Gomes Chaves', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064748, N' Maisa Sanches Fernandes de Carvalho', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046955, N' Manoel Carvalho Gontijo dos Santos', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017768, N' Manuel de Oliveira Vasconcelos Junior', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054359, N' Manuela Mota', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026809, N' Manuella Maria Santos Miguel da Silva', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002350, N' Marcel Cerqueira de Souza Jatoba', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039686, N' Marcela da Silva de Carvalho', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053439, N' Marcelo Babilonia de Melo', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059429, N' Marcelo Barbosa Tavares', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049089, N' Marcelo Correa dos Santos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001681, N' Marcelo dos Reis Brandao Rosa', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034956, N' Marcelo Marques de Souza', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012630, N' Marcelo Rezende do Nascimento', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021459, N' Marcelo Silva Alves', 37.63, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005534, N' Marceu Silva Sa', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043624, N' Marcia Ferreira Moraes', 49.48, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025651, N' Marcia Vieira de Azevedo de Morais', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060962, N' Marcio Gadelha Vasconcelos', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015257, N' Marco Antonio de Souza Watanabe', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071050, N' Marco Aurelio Diniz Pereira', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070990, N' Marco Aurelio Silva', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006063, N' Marco Holetz de Toledo Lourenco', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024629, N' Marcondes Azevedo', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082557, N' Marcos Andre Siqueira Lima', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10087130, N' Marcos Antonio Alves de Oliveira Pinto', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10092784, N' Marcos da Silveira Leal', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022160, N' Marcos de Biazi Goldberg', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030706, N' Marcos Henrique de Andrade', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034064, N' Marcos Henrique de Lima Souza', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037673, N' Marcos Paulo Martins Luciano', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055332, N' Marcos Tadeu Souza Aquino', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034528, N' Marcos Wesley Brandinho Ribeiro', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006379, N' Marcus Fabricio do Amaral Moreira da Cunha', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042008, N' Marcus Vinicius Almeida Duarte', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076387, N' Maria Andressa Veloso', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047081, N' Maria Gerlane de Souza Silva', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001028, N' Maria Luiza Porfiro Estevao deOliveira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033168, N' Maria Teresa Magalhaes Madureira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076654, N' Mariana Borges Araujo', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025143, N' Mariana da Silva Novaes', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063705, N' Mariana de Lima Campos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005395, N' Mariana dos Santos Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10096389, N' Mariana Koury Veloso', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036197, N' Mariana Pereira Batista', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022076, N' Mariana Rodrigues de Souza', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020320, N' Marianna Silva Martins', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011159, N' Marianne Araujo Santos', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071435, N' Marilia Gabriela de Oliveira Ramos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055852, N' Marina Lemes Machado Gomes', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026603, N' Marina Neves de Loiola', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021053, N' Mario Luiz Rebelo Miquelino Cunha', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071034, N' Mario Sergio Alves Elias', 35.57, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042014, N' Markus Tiago Sonntag', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007155, N' Mateus Carvalho Xavier', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022865, N' Mateus Costa Patrocinio', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10099787, N' Mateus dos Santos Lopes Gomes', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017484, N' Mateus Felippin de Albuquerque', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085083, N' Mateus Henriques de Carvalho', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048444, N' Mateus Medeiros Alves Campos', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003274, N' Mateus Melo Souza', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076450, N' Mateus Pinchemel de Andrade', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057541, N' Mateus Ribeiro Araujo', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069097, N' Mateus Silva Luna', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031571, N' Matheus Amaral Guimaraes', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073947, N' Matheus Argolo Leao', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000955, N' Matheus Costa de Freitas', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036306, N' Matheus Dantas Machado', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042867, N' Matheus de Carvalho Lima Rita', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023453, N' Matheus de Moraes Soares', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033863, N' Matheus de Oliveira Assis', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043736, N' Matheus Franca dos Reis', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079723, N' Matheus Goncalves Pereira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017551, N' Matheus Henrique Fernandes di Credico', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033423, N' Matheus Lira Rodrigues', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040002, N' Matheus Lourenco Ghesso', 37.63, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014465, N' Matheus Machado Mendes de Figueiredo', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073494, N' Matheus Martins Cavalari Cardoso', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013363, N' Matheus Nishiyama Pedroca', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051492, N' Matheus Pedroso Dias', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007783, N' Matheus Pereira Goncalves', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001814, N' Matheus Pinho Lins de Araujo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014040, N' Matheus Ribeiro Linhares', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009781, N' Matheus Ulisses Pimenta', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005186, N' Matheus Zuchelli Costa', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011859, N' Matusalem PachecoLustosa Neto', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005402, N' Maximilian Emanuel Hierstetter', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050369, N' Maxmyller Mourao Bezerra', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042456, N' Mayara Costa Freire Vasconcellos Pitanga', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003351, N' Mayara Cristina Gomes Maia', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006868, N' Mayara Leal Fernandes', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011447, N' Maybi Alfredo Fernandes', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020786, N' Maycon Patrick Dias', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001641, N' Melisa Adriana Silva Pimenta', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004346, N' Melissa Xavier Araujo', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030494, N' Micael Alves de Paula e Silva', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039123, N' Michell Victor Matos Mourao', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049375, N' Michelle Vilar da Silva Pimentel', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017072, N' Miguel Santos de Freitas', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070220, N' Milena Gomes Bezerra', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006470, N' Milena Guimaraes Oliveira', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044808, N' Milena Ribeiro da Rocha', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004288, N' Milene Prata de Souza', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047512, N' Mirellen Mara Moreira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010273, N' Mirian Sousa de Freitas', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035122, N' Moacir Gomes Duarte Filho', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10088898, N' Moises Loiola Heldeberto', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019543, N' Monike Pontes Silva', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042309, N' Monique Temp da Silva', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076866, N' Murilo Alencar Lopes', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10089602, N' Murilo de Oliveira Marcirio', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035723, N' Murilo Munhoz de Souza', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002238, N' Nailton Pereira Danesi Damacena', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020659, N' Naissa de Sousa Araujo Alves', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057763, N' Natalia Alcantara Ayres', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012723, N' Natalia Lemos Penetra', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029165, N' Natalia Sartori', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020038, N' Natan Carlos da Cunha Costa', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036846, N' Natan Rocha Ferreira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003394, N' Natanael Silva Camargo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009582, N' Nathalia Azarias de Souza', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062563, N' Nathalia da Conceicao Silva Dias', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040298, N' Nathalia Fenner Saldanha', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006482, N' Nathalia Lauria do Nascimento', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008798, N' Nathalia Malacrida de Araujo', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10089266, N' Nathalia Martins Pereira dos Santos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10098138, N' Nathalia Micaelle Nunes de Oliveira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023456, N' Nathallia Franco Santos', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008064, N' Nathan Ranieri Santos Teofilo', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10056397, N' Nayara dos Santos Siqueira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029461, N' Nicolas de Castro Alves', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000919, N' Nicolas Miguel Oliveira de Lima', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036387, N' Nilo Gomes Paiva', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020460, N' Nivaldo Batista de Oliveira Junior', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019587, N' Otavio Henrique Oliveira Ferreira', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081500, N' Pablo Alexandre Gomes e Silva', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011854, N' Pablo Araujo da Gama', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049198, N' Pablo Felipe dos Santos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10094378, N' Pablo Henrique da Cunha Silva', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050556, N' Paloma Asenjo de Macedo', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002711, N' Paloma de Bustamante Carim', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021363, N' Paloma Pedroza de Sa Formiga', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009193, N' Pamela Cristina Martins da Silva', 48.97, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055656, N' Patricia Merlim de Oliveira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038969, N' Patrick Cardoso dos Santos', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023689, N' Paula Carolina Kraetzer de Oliveira', 49.48, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059658, N' Paula Prestes Azeredo', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057522, N' Paula Reginatto Bau', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063302, N' Paulo Augusto Morais de Oliveira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011781, N' Paulo do Couto Naves', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021307, N' Paulo Eduardo Lazar Meyer', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006869, N' Paulo Henrique de Oliveira Sousa', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001888, N' Paulo Henrique Fernandes Ribeiro Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034454, N' Paulo Henrique Medeiros Macedo', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060047, N' Paulo Henrique Queiroz Cavalcante', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075209, N' Paulo Mendes Florentino Filho', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10101150, N' Paulo Raimundo de Paiva Arbues Carneiro', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076131, N' Paulo Ricardo Peixoto', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000040, N' Paulo Roberto Rodrigues da Silva', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035150, N' Paulo Rodrigues de Morais Junior', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008941, N' Paulo Vitor Ferreira Correa', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020201, N' Pedro Alves Ferreira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019405, N' Pedro Augusto da Camara de Oliveira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024436, N' Pedro Ciminelli de Araujo', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065829, N' Pedro de Gusmao dos Reis', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10084191, N' Pedro de Queiroz Soares', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034764, N' Pedro Delgado Alvim de Mello', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001243, N' Pedro Gabriel Leobas Maracaipe', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035949, N' Pedro Guilherme Feitoza Melo', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005253, N' Pedro Henrique de Araujo Souza Junior', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044759, N' Pedro Henrique Maciel', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012884, N' Pedro Henrique Paranagua de Castro', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033474, N' Pedro Henrique Silva Mariz', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054498, N' Pedro Henrique Tavora Pereira Filho', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035714, N' Pedro Hideu Iamada', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046951, N' Pedro Mauricio de Vargas Sanches', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030798, N' Pedro Ribeiro Dornelas', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026596, N' Pedro Rocha de Freitas', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028954, N' PedroSperchi Camilo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007454, N' Pedro Vitor Resende', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051340, N' Peterson de Lira Quirino', 36.08, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014630, N' Phelipe Correia Costa', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077154, N' Phelipe Sacramento Silva', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020887, N' Philipp de Souza Ribeiro', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086804, N' Philippe Frota Menezes', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10084583, N' Pollyana Barros da Silva Pacheco', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044911, N' Priscila Augusta Morgado Pessoa', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015353, N' Priscila de Andrade Fernandes', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027442, N' Priscilla Mendes da Silva', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005953, N' Priscilla Passos Lacerda de Araujo Gois', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003740, N' Rafael Alves de Sousa Oliveira', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060464, N' Rafael Antunes dos Santos', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053094, N' Rafael Barbacena e Souza', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000544, N' Rafael Campos Marques da Costa', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017407, N' Rafael da Silva Farias', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023180, N' Rafael da Silva Lopes', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014832, N' Rafael Fernando Mendonca de Alencar', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076115, N' Rafael Ferreira Dutra', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012700, N' Rafael Fleury Mainardi', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10099986, N' Rafael Flores de Magalhaes', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010254, N' Rafael Goncalves Valenca', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070261, N' Rafael Henrique Soares Nogueira Rocha', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062811, N' Rafael Lima de Siqueira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011294, N' Rafael Lucas Souza', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043275, N' Rafael Maciel Nascimento', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026529, N' Rafael Oliveira Rodrigues', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009985, N' Rafael Pereira Nunes', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060726, N' Rafael Porciuncula Sales', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001702, N' Rafael Rodrigues Gouveia', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022995, N' Rafael Salles Pereira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020521, N' Rafael Sampaio Braga', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057631, N' Rafael Serejo de Jesus', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004488, N' Rafael Tavares de Sa', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016287, N' Rafaelly Hatherly Rodrigues', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075529, N' Raianne Rocha Amorim', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004957, N' Raianny Moreira Soares', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030564, N' Raissa Gomes Riotinto', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043752, N' Ramon Braga Trajano', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063336, N' Ramon de Medeiros Bahia', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10083161, N' Ramon Fernandes Bastos Pinheiro', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045181, N' Ramona Thorpe Lima', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057599, N' Randel Giordani Ferreira Montini', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005485, N' Raphael Abreu de Barros Monteiro', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007585, N' Raphael Costa Marques dos Santos', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030669, N' Raphael Nepomuceno de Menezes', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005223, N' Raphael Pereira de Medeiros', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064343, N' Raphael Santos Dantas', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028761, N' Raquel Carvalho Pereira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040277, N' Raquel de Freitas Lerback', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044039, N' Raquel Silva Moreira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060776, N' Raquel Veras Valenca', 35.57, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002384, N' Raul Furieri Pignaton Camargo de Azevedo', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027561, N' Rayanne Gobbi de Carvalho Zumpano', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038368, N' Rayldon Ribeiro da Silva', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005394, N' Rayssa Polianna Silva', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029881, N' Rebeca Bueno Bucci Py', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060996, N' Rebecca Araujo Viana', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073307, N' Rebeka Dantas dos Santos Vilanova', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063605, N' Reison Vinicius Siqueira Cruz Rodrigues', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020273, N' Renan Andre de Oliveira Soares', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10056914, N' Renan de Sousa Oliveira', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070741, N' Renan Emerson Oliveira Cavalcante', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000903, N' Renan Henrique Santos Pereira', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073138, N' Renan Hiroshi Kuba', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015633, N' Renan Motta da Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073306, N' Renan Wilson Lopes Prudencio', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020765, N' Renata Augusto Vieira', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007135, N' Renata Delfino Brito', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032786, N' Renata Martino Caldeira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091099, N' Rhagi Anderson Lira Alvarenga', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055353, N' Ricardo da Silva Pereira Junior', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027634, N' Ricardo Pedrosa Dagosto', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060395, N' Richard David Souza', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031351, N' Richard Soares Lustosa', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038778, N' Robert da Silva Mello', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009555, N' Roberta Almeida Silva Pereira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043618, N' Roberta Ligia Cavalcanti Lima', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024904, N' Roberto Carlos Pereira Junior', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031133, N' Roberto Danilo Rodopiano Teixeira', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011671, N' Roberto Dutra da Silva Filho', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027672, N' Roberto Miyazaki Ramos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010241, N' Robson Albertassi', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000830, N' Robson Rossi Silva de Mesquita', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011658, N' Robson Veloso Goes', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081029, N' Rodineli Mendes Moreira', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039443, N' Rodrigo Antonio Vieira Rodrigues', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054129, N' Rodrigo Carvalho Araujo', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031054, N' Rodrigo Chogri Galli', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044049, N' Rodrigo de Lima Rodrigues', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022458, N' Rodrigo de Oliveira Teixeira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039365, N' Rodrigo Gabriel Costa Fortuna', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060277, N' Rodrigo Goncalves Recalde', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024621, N' Rodrigo Luiz Caron Burda', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066831, N' Rodrigo Matos Lobo de Souza', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003058, N' Rodrigo Melo de Oliveira', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038964, N' Rodrigo Meneses Cabral', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10108417, N' Rodrigo Pereira Santos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045938, N' Rodrigo Picinin Nascimento', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040241, N' Rodrigo Santos Mendes', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000369, N' Rodrigo Tadeu Meyenberg', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001574, N' Rodrigo Wallace Oliveira Santos', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043806, N' Rodrigo William Silva de Oliveira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10104026, N' Romeu Gomes de Morais Filho', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059697, N' Ronei Ademir Wolff Athayde Junior', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026398, N' Ruda de Almeida Silva', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022971, N' Sabrina Alves de Oliveira Filincowsky', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030710, N' Sabrina da Costa Lopes Goncalo', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005025, N' Sabrina Stinghel Soares', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016005, N' Sahydi Tedesco Abrahao', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033112, N' Salatiel Pereira de Freitas', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091375, N' Samuel Costa Falcao', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022391, N' Samuel da Silva Rodrigues', 36.6, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081774, N' Samuel de Souza Almeida', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10108961, N' Samuel Goncalves dos Santos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013616, N' Samuel Oliveira da Cunha', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003960, N' Samuel Silva Rocha Lima', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016131, N' Sandi Alves de Souza Pereira', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007805, N' Sandra Cristina Cavalcante de Araujo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006574, N' Sandro Carvalho Kusano', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041206, N' Sara da Silva Fernandes', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016396, N' Sara Evelin de Sales Oliveira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002922, N' Sarah de Oliveira e Silva', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003294, N' Sarah Gomes Barroso', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025771, N' Sarah Paulino da Silva Melo', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10080383, N' Saulo Maciel Rodrigues', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055438, N' Saulo Renan de Sousa e Silva', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022167, N' Savio Preto Menezes', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024893, N' Scarlet Pereira Pena', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049427, N' Sedrick Pereira de Lima Junior', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031024, N' Semi Yussef Bjaije Junior', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076110, N' Sergio Calderaro Gomes Pinto Junior', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027864, N' Sergio Luiz Rosa Junior', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021398, N' Sergio Ricardo Vieira Ponde Serra', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015698, N' Sharon Anne Nogueira Barros', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013454, N' Silas Dantas Silva', 38.14, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049778, N' Silas Edson Martins', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022675, N' Silvio Luis Martins Eleuterio', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011772, N' Solange Stefany de Faria', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025425, N' Sonia Cristina de Oliveira Guimaraes', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000948, N' Stephanie Correia Costa', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024668, N' Stephano Praxedes Mendonca', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066839, N' Susan Maky Karakida', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021047, N' Tainan Lima Bueno', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012173, N' Tais Bottecchia', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001332, N' Takuma Machado Scarponi Cruz', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035946, N' Tales Henrique Andrade da Mota', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009814, N' Talita Guieiro Ribeiro Rocha', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013477, N' Talita Silva Rodrigues', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051167, N' Tallys Henrique Crico Pimentel', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019704, N' Tamara Miranda Ferreira Figueiroa', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000753, N' Tamires Jade Pereira da Silva', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006270, N' Tarso Campos Andrea', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020774, N' Tauane de Paula Guimaraes', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053367, N' Tayna Passos Nunes Leal', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10102938, N' Tayrone Tadeu de Freitas Coelho', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022684, N' Tayssa Cordeiro de Oliveira', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023861, N' Thadeu Pessoa Passos Santos', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013978, N' Thaiane Vanessa Meira Nascente dos Santos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040528, N' Thaina Caroline Eleto', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038170, N' Thais Andreia de Souza Santos', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016145, N' Thais Ferreira Ramos', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064356, N' Thais Manhaes Eleuterio', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015457, N' Thais Ribeiro Santiago', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000214, N' Thais Yukiko Queiroz Fukuda', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063966, N' Thales Luiz Melo Silva', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009530, N' Thalia Soares de Souza', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038467, N' Thalisson Rodrigues Mendes', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10080522, N' Thalitta Rodrigues Viana', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044511, N' Thallita Raquel da Silva Mendes', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059829, N' Thallys Deusdara Monsueth Alves', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035251, N' Thamera Soares Souza', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073716, N' Thamyrys dos Santos Araujo', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058769, N' Thayane Erika Cruz Maciel', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052216, N' Thaynara Ferreira de Andrade', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054416, N' Thaynara Nunes Cardoso', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077827, N' Thiago Baracho Goncalves', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026926, N' Thiago Bolelli Costa', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046312, N' Thiago Coelho Ferrolho', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047638, N' Thiago de Lima Klen Barreto', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031960, N' Thiago de Souza Francisco', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043706, N' Thiago FelixBorges', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010819, N' Thiago Fernandes Beserra', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019459, N' Thiago Fogtman Steger', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054897, N' Thiago Garcia Rosa Zanandrea', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001721, N' Thiago Henrique Doria de Oliveira', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047536, N' Thiago Melo Soares', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038784, N' Thiago Roris de Matos', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019723, N' Thiago Soares Ouriques', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048310, N' Thiago Veiga Vian', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10089200, N' Thomas Luciano Alves da Silva', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011553, N' Tiago dos Santos Ferreira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10074826, N' Tiago Guarda', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023773, N' Tiago Matheus Lopes', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016214, N' Tiago Torres Braga', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000074, N' Tomas Pinheiro Della Giustina', 32.47, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069921, N' Tomaz Silva Gonzales', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006050, N' Ulisses Almeida Coutinho', 47.94, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009208, N' Ulysses de Oliveira Barbosa', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039479, N' Valeria Maria Rosa', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009300, N' Valeria Ribeiro da Silva Rocha', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045352, N' Valter Rafael Souza Marques', 37.11, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041826, N' Vancleucyo Machado da Silva', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012964, N' Vanderly Salvador de Queiroz', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045952, N' Vanderson Wallace Queiroz dos Santos', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005020, N' Vanessa Batista Goncalves', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10080469, N' Vanessa Brunna da Silva Brito Alves', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085698, N' Vanessa Maria da Silva Paiva', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016288, N' Vantuyler Borges de Morais', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001752, N' Vicente Resende Cardoso Filho', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014930, N' Victor Amorim de Carvalho', 39.69, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013790, N' Victor Baracho Alves', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082497, N' Victor Castro da Costa', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015450, N' Victor de Sousa Passos', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016369, N' Victor Emmanuel Delfino Aleixo', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047240, N' Victor Hugo Uchoa Tatagiba', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030999, N' Victor Lopes Costa Serra', 40.72, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008973, N' Victor Santos Pimentel Rodrigues de Araujo', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006483, N' Vinicios Alves Ferreira', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10110644, N' Vinicius Belo Dutra', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079484, N' Vinicius Borges Miatelo', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017647, N' Vinicius Fantin Zanatta', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10092925, N' Vinicius Henrique de Oliveira Santos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058436, N' Vinicius Mendonca Teixeira', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003020, N' Vinicius Moreira Lana', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075504, N' Vinicius Pataro Generoso Sales', 46.91, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003244, N' Vinicius Tavares de Castro', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045019, N' Vinicius Umbelino de Souza Ribeiro', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040940, N' Virginia de Aguiar Rocha', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032973, N' Vitor Alexandre Pereira', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054585, N' Vitor Alves Fonseca de Oliveira', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005106, N' Vitor Antonio Teixeira Rozendo', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048884, N' Vitor Augusto Cardoso Silva', 38.66, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079365, N' Vitor Birck', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069488, N' Vitor Manoel Borges Ferreira', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054140, N' Vitor Neves Ergang', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026423, N' Vitor Rodrigues Santos', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012062, N' Vitoria Hadassa de Souza Santos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054823, N' Vivian Moreira de Moura Maia', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015924, N' Vylther Pereira da Silva', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029126, N' Wagner Alves Goncalves Nogueira', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10105083, N' Wallace Willian do Nascimento Macedo', 48.45, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004797, N' Wallesson Faria de Jesus', 43.3, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035851, N' Walter Aires da Silva', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054143, N' Wanderlan Fernandes Guedes Filho', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005369, N' Wanderson Phelipe Soares de Franca', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034505, N' Wanderson Souza Marques', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010902, N' Warley Jose Gimenes Pessanha', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064548, N' Washington Richel Saito da Silva', 41.75, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002143, N' Webert Hudson Araujo Alquimim', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018145, N' Welerson Ferreira Abreu', 44.33, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038961, N' Wellington Sousa de Oliveira', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068392, N' Wender Henrique de Sousa Silva Starling', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030058, N' Weslany Guimaraes dos Santos', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077425, N' Wilame da Silva Mendes', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062483, N' William Araujo Moreira Nunes', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064148, N' William Radziavicius Santos Cavalheri', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058343, N' William Sales Ferreira do Carmo', 41.24, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009946, N' Willians Ribeiro de Campos', 45.88, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042949, N' Wilquer Coelho dos Santos', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003922, N' Winston Antonio Melo Severino', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10014692, N' Yago de Mello Santos', 40.21, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10074481, N' Yara Rodrigues Cardoso', 45.36, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016274, N' Yara Verlaine Cordeiro Matias', 47.42, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091917, N' Ygor Pontes Oliveira de Souza', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021688, N' Yuri Araujo Coelho Penna', 39.18, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043689, N' Yuri Armstrong Cantanhede', 43.81, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035635, N' Yuri Castello Branco Brito', 46.39, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062056, N' Yuri Gustavo de Souza', 42.78, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10085602, N' Yuri Portugal Serrao Ramos', 44.85, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018434, N' Yuri Soares Pinheiro', 42.27, N'Ampla')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026705, N' Anderson Bruno de Andrade Silva', 39.69, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024422, N' Eduardo Campos de Jesus', 42.27, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077354, N' Elaine de Azevedo Ribas', 43.81, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054671, N' Gisele Silva Santos', 44.33, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023420, N' JefersonCardoso Costa', 37.63, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039605, N' Lays Venancio Lira', 42.78, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034800, N' Leonardo Romao Batista', 40.72, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067732, N' Luana Narjara Carvalho dos Santos', 42.27, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035302, N' Mario Augusto Paulino de Lima Filho', 34.02, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019208, N' Marissol Silva Pontes', 38.14, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037805, N' Pablo Matos Cavalcante', 37.63, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10105245, N' Pedro Henrique Duarte Medeiros de Brito', 40.72, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022823, N' Roberto Pereira da Silva', 38.66, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066211, N'Samara Alves de Oliveira Familiar', 39.18, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071520, N' Simone Freitas da Silva', 40.21, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001524, N' Tamara da Silva Cardoso', 37.11, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030585, N' Thiago Leao Pires', 43.81, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040187, N' Thiago Oliveira Bedas', 45.88, N'PCD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003385, N' Adriana Luiza de Albuquerque Brito', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10108512, N' Adriano Reis dos Santos', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069922, N' Alan Moreira da Silva', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10067590, N' Alef Ferreira da Silva', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10088473, N' Alexandre Martins Barbosa', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10084258, N' Alexsandro Lima Rocha', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064220, N' Aline Mendonca Batista Pister', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033541, N' Aline Mourao de Abreu', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010498, N' Alisson Bruno Milanez Barros', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008416, N' Alisson Carlos Martins Felipe', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018823, N' Allisson Cardoso Ferreira', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001603, N' Aluizio de Sousa Lustosa', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003876, N' Alyne de Morais Santiago Gaia', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023979, N' Ana Carolina Angelo Passos', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001273, N' Ana Eloisa Pereira Lopes da Silva', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016002, N' Ana Paula Oliveira Nascimento', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072068, N' Ananda Ramaiana Barbosa da Gama', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013837, N' Anderson Dutra Almeida', 47.94, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023195, N' Andre Felipe da Rocha de Souza', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054039, N' Andre Luiz de Oliveira Barros', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007488, N' Andressa Santos de Souza', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041872, N' Andressa Trindade de Lima', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030724, N' Andressa Virginia Vieira Silva', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047237, N' Aristides dos Reis Pereira', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015833, N' Arthur Gouvea Fernandes', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10015831, N' Aylana Patricia Rodrigues Costa', 39.18, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10044432, N' Barbara Amanda Agustinho da Silva', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035276, N' Barbara Araujo Moura', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018402, N' Beiany Araujo Costa', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007233, N' Brendo Augusto dos Santos Tertuliano', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010288, N' Bruno Araujo Lima', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029952, N' Bruno Cesar Sampaio Ribeiro de Assis', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001622, N' Bruno da Silva Coelho', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10084488, N' Bruno Leonardo da Conceicao Facanha', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034241, N' Bruno Nunes Teixeira Ferreira', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10101769, N' Bruno Rafael Martins Pereira', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023537, N' Caio Kelvin dos Santos Melo', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030164, N' Carlos Rafael Bessa da Silva', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028803, N' Carolaine Pinto Soares', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002814, N' Carolina Farias Ferreira Moretto', 47.42, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052747, N' Carolina Gomes dos Santos', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091226, N' Catiana Silveira de Souza Araujo', 39.69, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002663, N' Ciro Camilo Santos Leal', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006335, N' Claudio Francisco dos Santos', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078318, N' Clayton Rosa', 38.66, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078093, N' Cleber deMoura Tavares', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002815, N' Daniel Alves Pereira', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052453, N' Daniel Barbosa de Sousa', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060163, N' Daniel Barrozo Lima', 48.45, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007435, N' Daniel Lima das Virgens Ferreira', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051869, N' Daniele da Silva Rocha', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057921, N' Danillo Cordeiro dos Santos de Santana', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034215, N' Davidson Costa dos Santos', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029207, N' Deivid Barbosa dos Santos', 37.11, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071099, N' Denise de Jesus do Nascimento', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018231, N' Deviston Azeredo Silva', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040988, N' Diego Mayer Viana Rocha', 37.11, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024958, N' Diego Santos Moura', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008104, N' Dionisio Bispo de Oliveira Neto', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043833, N' Dyego Jardim Mendonca', 47.94, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063532, N' Edilene Pereira de Oliveira', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024099, N' Edinaldo da Silva Santos', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036430, N' Ednei da Conceicao Sousa', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057345, N' Edson Vieira de Morais', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073094, N' Edson Willy Cirqueira de Oliveira', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059729, N' Eduardo Reis Pacheco', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045061, N' Elison Rodrigues Carvalho dos Santos', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063058, N' Eloiza da Silva Pinheiro', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072113, N' Elton da Silva Candido', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023349, N' Emanuella Cunha de Barros Raposo Carneiro Lins', 47.94, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040412, N' Emerson Vieira dos Santos', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10094893, N' Eunice Vitorio de Oliveira', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037198, N' Ewerton Cruz Soares', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020297, N' Fabio de Almeida Soares', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047981, N' Fabiula Sousa Tito', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055868, N' Felipe Rogerio de Oliveira', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045130, N' Felix Barbalho Neiva Junior', 38.66, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029028, N' Fernanda Miranda de Souza', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064825, N' Fernanda Silva do Nascimento', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002311, N' Fernanda Viana de Morais', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030055, N' Fernando Magalhaes de Paulo', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020164, N' Fernando Nascimento dos Santos', 37.63, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004549, N' Filipe Rhaony Araujo de Siqueira Dantas', 37.63, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081467, N' Francilene Alves dos Santos', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10099142, N' Francisco Adail Inacio de Sousa Junior', 38.66, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10103286, N' Gabriel da Silva Pascoal', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10096003, N' Gabriela Farias de Souza', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052921, N' Gabryella Alves da Silva', 39.69, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077254, N' George de Araujo Santos', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10078027, N' Geovani Urder de Andrade Aquino', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060875, N' Geraldo Matias Junior', 37.11, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023301, N' Gesomar Rodrigues de Franca', 48.45, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005985, N' Gilvan Cupertino dos Santos', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060188, N' Glenda Gomes Silva Frank', 39.18, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10041187, N' Gleodes Victor Duarte de Souza', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032914, N' Greicy Kelly Pereira de Souza', 35.05, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020468, N' Guilherme de Oliveira Santana', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081471, N' Guilherme Henrique Rodrigues Rabelo', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037162, N' Guilherme Pinto Ribeiro', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020423, N' Guilherme Vieira da Silva', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049338, N' Gustavo Araujo Lopes da Silva', 47.42, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077393, N' Gustavo de Almeida Ferreira', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006354, N' Hebert Jorge Nunes da Silva Machado', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029181, N' Hellen Pereira Santos', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037069, N' Higor Nunes Azevedo', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025059, N' Iara Ferreira Barbosa', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001027, N' Igor Marinho Santos', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021577, N' Ingrid Lorena de Oliveira Silva Marques', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10094773, N' Irene Teixeira dos Santos', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006223, N' Isabela Brito Couto de Oliveira', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003454, N' Izabelle Dias Silva', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045660, N' Jackellyne Jenyffer Ferreira dos Santos', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065059, N' Jaine de Sousa Maciel', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10037712, N' Jaira Decia Conceicao Lima', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061041, N' Jeancarlos da Silva Junior', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035604, N' Jeferson Jesus de Aragao', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086700, N' Jemerson de Carvalho Silva', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024367, N' Jemisson Rocha dos Santos', 39.69, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060388, N' Jessia Marcia Ferreira Silva', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040086, N' Jessica de Ornelis Borges', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10087909, N' Jessica Sales Lemes', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025940, N' Jessyca Lenne Ramos Chagas', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019747, N' Joabson Alexandre Marques de Castro', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10080963, N' Joao Heverton de Jesus Nunes', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10060246, N' Joao Paulo de Sousa', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048680, N' Joao Pedro de Oliveira Alves de Castro', 37.63, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000296, N' Jonas Costa David', 36.6, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10048431, N' Jonatan Almeida Custodio', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10077333, N' Jonathan Goncalves Dutra de Souza', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053117, N' Jorge Waschington do Carmo Junior', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10076635, N' Josafa Goncalves dos Santos', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043650, N' Jose Lidberg Rocha Lima Filho', 39.69, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079120, N' Keila Moldes de Menezes', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018902, N' Kelly Cruz da Silva', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038003, N' Kessy Diego Ribeiro Maia de Carvalho', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004955, N' Keyla do Nascimento Rocha', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045928, N' Lanaira Rodrigues da Silva', 38.66, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038743, N' Larissa da Silva Marques', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008635, N' Larissa Paes Landim Alves', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006438, N' Laura Ribeiro Lopes', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052326, N' Leandro Amaral da Fonseca', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026453, N' Leandro da Silva Lima', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001718, N' Leandro dos Santos Sousa', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057957, N' Leandro Ferreira da Mata', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028136, N' Leandro Rocha da Silva', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024503, N' Leia Pereira de Brito', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030677, N' Lenin Andrade de Souza Cerqueira', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032162, N' Leonardo de Melo Brito Junior', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052126, N' Leonardo Pereira Dalmeida Franca', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10050769, N' Leone Braga Teixeira', 39.18, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10092524, N' Leticia Araujo Figueiredo', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10049134, N' Loise Kelem Oliveira da Hora', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10045133, N' Luan Sousa Dias Nogueira', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007828, N' Lucas Araujo de Sa', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10086072, N' Lucas Florencio dos Santos Sampaio', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030842, N' Lucas Fonseca da Silva', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007528, N' Lucas Henrique Rosa do Nascimento', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018218, N' Lucas Neves Cardoso', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10057796, N' Lucas Vieira dos Santos', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040042, N' Ludimila de Oliveira Felix', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028703, N' Luis Fernando Alves da Silva', 38.66, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10029833, N' Luisa Mansur Ferreira', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10089922, N' Luiz Ricardo Santana Neres', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013620, N' Magno Pires Cunha', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026809, N' Manuella Maria Santos Miguel da Silva', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034605, N' Marcelo Candido Pereira Lopes', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002778, N' Marcelo Henrique da Silva Oliveira', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10091260, N' Marcelo Hipolito Dantas de Souza', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033122, N' Marcelo Martins dos Santos', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011825, N' Marcio Alan Souza Figueiredo', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10022721, N' Marcos Alexandre Sperandio Sabino', 33.51, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017381, N' Marcos Heberth Soares da Silva', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026510, N' Maria do Socorro Rodrigues Barbosa', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034013, N' Marianny Rosa Fernandes Ramos', 39.69, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070700, N' Marilia Parreira', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059906, N' Mario Henrique Menezes Santos', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047490, N' Mario Junior Mendes da Silva', 36.08, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020336, N' Marlos Angelo Silva Quirino', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10095054, N' Matheus Pereira Mendes', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018343, N' Matheus Silva Gomes', 36.08, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010280, N' Mauricio Brayan Cruz Alves Martins', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075990, N' Max Macedo Cavalcante', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013710, N' Mayara Alves Barbosa Neres', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10043029, N' Mayara Araujo Mendes', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016741, N' Mayara Serrano da Cunha Santos', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046789, N' Michael Ferreira Alves Lima', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016351, N' Moises de Almeida Bastos', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020302, N' Monica Lins dos Santos', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10012723, N' Natalia Lemos Penetra', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075236, N' Nayara Elaine Alves da Costa', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065339, N' Pedro Cesar Queiroz da Silva', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039747, N' Pedro Henrique Mota de Azevedo', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009617, N' Peterson da Cunha Estevan Costa', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058676, N' Rafael Pereira Felix', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040610, N' Raphael Felipe de Moura dos Santos', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003224, N' Raphael Oliveira dos Santos', 36.6, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010823, N' Rayan Lucas Maranhao de Sousa', 37.63, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032346, N' Raysson Nogueira dos Santos', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031030, N' Rebeca Lima Oliveira', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006667, N' Reisval da Silva Pereira Figueiredo', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023938, N' Renan Aruil de Sousa', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046871, N' Renato Carvalho de Souza', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10033322, N' Renato Melo dos Santos', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10069241, N' Rock Ney Gomes dos Santos Junior', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10063145, N' Rodolfo Alves Nascimento', 36.6, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011375, N' Rodrigo Carneiro de Melo', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10093803, N' Rodrigo de Almeida Romar', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072473, N' Rodrigo de Melo Pereira do Nascimento Costa', 39.69, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011370, N' Rodrigo Pires Teodoro', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031997, N' Ronaldo Fernandes Branco Jr', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10035056, N' Samara Costa de Sousa', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027536, N' Sandoval Santana Meira Junior', 42.78, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064001, N' Saulo Yuri Oliveira Santos', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10036470, N' Sidney da Silva de Oliveira', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10090583, N' Silvaldo Quirino Tavares', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10054983, N' Suzana Marques Brandao Santos', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047483, N' Taiane Baptista Goncalves', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055087, N' Talita da Cunha Sousa', 44.85, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032890, N' Tauan Moncores Duarte', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005733, N' Thales Junior Moreira da Silva', 37.63, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059829, N' Thallys Deusdara Monsueth Alves', 43.81, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059450, N' Thayrine dos Santos Fagundes', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068470, N' Thiago Costa Marques', 41.75, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025618, N' Thiago dos Santos Silva', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10019378, N' Thiago Fernandes Caldas Souza', 42.27, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075154, N' Thiago Macedo de Carvalho', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10017260, N' Thiago Santos de Sousa', 38.14, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10093720, N' Tiago Lima Paraizo', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075924, N' Tiago Silva Anunciacao', 41.24, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10032796, N' Tiago Spindula Ferreira', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10064698, N' Tulio Andre Pereira de Oliveira', 46.91, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005655, N' Ulisses Antonio Pereira', 38.66, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10066197, N' Victor Augusto Machado da Silva Andrade', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003357, N' Victor Eduardo Menezes de Freitas', 46.39, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027422, N' Vinicius da Silva Costa', 47.42, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059764, N' Vinicius dos Anjos Rodrigues', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10094212, N' Vinicius Drummond Silva Araujo', 45.88, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10003244, N' Vinicius Tavares de Castro', 48.45, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10026423, N' Vitor Rodrigues Santos', 44.33, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10111689, N' Vitor Rodrigues Silva de Souza', 38.66, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10105083, N' Wallace Willian do Nascimento Macedo', 48.45, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10082887, N' Wanderson Gomes dos Santos', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016719, N' Welton Silva de Oliveira Pires', 45.36, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013643, N' Weslen Ribeiro de Oliveira', 47.94, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006816, N' Wesley dos Santos', 43.3, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10070881, N' Winston Luiz Prado de Sousa', 40.72, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010102, N' Yasmin da Fonseca Santos', 40.21, N'Negros')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081568, N' Alane Goncalves Vieira', 47.42, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081325, N' Allan Leandro Bezerra do Nascimento', 43.81, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10002309, N' Ana Paula Resende', 36.08, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009821, N' Angelo Salvio Mendonca Negrao', 44.85, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020092, N' Bruna Caroline Nascimento Messias', 39.69, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10024749, N' Bruno Chaves Ferreira Lima', 42.27, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040019, N' Caio Magno Mendonca dos Santos', 43.3, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055705, N' Camilla Rinaldi de Oliveira', 35.57, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006067, N' Claudio Pereira dos Santos Filho', 39.18, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10031879, N' Clovis Rodrigues Pereira Neto', 46.39, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10065837, N' Daniel Torres Carvello', 41.75, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011926, N' Danilo Rigamonte Carneiro', 43.3, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081019, N' Danilo Santiago Barbosa Silva', 39.69, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10074322, N' Dario Roberto Costa Gomes', 34.02, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10053678, N' Deyse Gisele Rodrigues de Oliveira', 47.94, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10083405, N' Eduardo Clemente', 34.54, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10079477, N' Elisa Maria Reisdorfer', 43.3, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10005134, N' Erick Tavares de Abreu', 44.33, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10051049, N' Fernanda Duarte Franca de Castro', 40.72, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075174, N' Fernando Jose de Araujo Franca', 43.3, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10056818, N' Filipe Araujo de Oliveira', 46.39, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10000220, N' Henrique Alves Brito Sousa de Melo', 43.3, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10071526, N' Igor Gabriel Tinoco Gerardin Poirot Land', 45.36, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10030392, N' Jessica Piva', 43.81, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007167, N' Joao Augusto M de Magalhaes', 41.24, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10039654, N' Joao Paulo Vaz Mendes', 40.21, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10013060, N' Jose Alencar Lins da Cunha', 46.91, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010342, N' Juliana Bona de Faria Pinto', 44.85, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10008190, N' Leandro Domingues de Sousa', 42.27, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10068142, N' Leandro Ribas Neves', 45.88, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10023871, N' Leonardo Ayres Simi de Camargo', 46.91, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006952, N' Leonardo Esteves Ferreira Mendes', 46.91, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001972, N' Lilian de Souza Carvalho', 37.63, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006976, N' Lucas Gomes Marques', 46.39, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10006611, N' LuisaDefranco Ferreira Peconick', 42.78, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10089575, N' Marcelo Goncalves Moura', 42.27, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10007788, N' Marcelo Lirio Alves', 39.69, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025783, N' Marco Thulio Silva Costa', 34.02, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10061353, N' Mariana de Avila Palhares', 40.21, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027532, N' Mateus do Carmo Cunha', 39.18, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001563, N' Miriam Roisman', 43.3, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10046410, N' Nilo Laercio de Abreu dos Santos', 43.81, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052874, N' Pedro de Paula Filho', 41.75, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10021806, N' Priscila Isaias da Silva', 42.27, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10004704, N' Rodrigo Lira Saraiva', 44.33, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075101, N' Vanessa Vitalino', 47.42, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10034482, N' Wesley de Oliveira Chaves', 46.91, N'SJA')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10016703, N' Alexandre Oliveira Silva', 39.18, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10055324, N' Caio Vieira Florindo', 41.24, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10058713, N' Carlos Danillo Costa Santos', 36.08, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020313, N' Fatima de Oliveira Jorge Campos', 34.02, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10042565, N' Jacqueline Neves de Souza', 37.63, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10056434, N' Lucas Campolina Barbosa Melo', 34.02, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10025783, N' Marco Thulio Silva Costa', 34.02, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10027609, N' Marina Lemes de Carvalho', 39.18, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10074044, N' Tiago Pereira de Souza', 40.72, N'SJD')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10073077, N' Alefe Paulo Xavier da Silva', 41.75, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10062765, N' Andre Alves Rabelo', 45.88, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10018479, N' Anselmo Oliveira', 42.27, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10047717, N' Daniel Jose da Fonseca Souza', 38.66, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081019, N' Danilo Santiago Barbosa Silva', 39.69, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10038540, N' Danniel Reis de Oliveira', 40.72, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10010833, N' Douglas Carvalho do Nascimento', 38.14, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040572, N' Gabriel de Paula Lima', 39.69, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10020072, N' Jean Carlos Silva Medeiros', 45.36, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10092392, N' Jean Rodrigues Cardoso Santana', 40.72, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10072090, N' Kalitta Monique da Silva Duarte', 42.78, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10001972, N' Lilian de Souza Carvalho', 37.63, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10028255, N' Lorenna de Sousa Oliveira', 43.3, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10081973, N' Lucas Paulo da Silva Santos', 40.21, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10059390, N' Luis Miguel Fructuoso Ferreira', 35.05, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10009271, N' Marcus Vinicius Correa de Macedo', 44.85, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10040900, N' Patricia Medeiros da Silva Dias', 42.78, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10052148, N' Rene Rodrigues Ferreira Batista dos Santos', 42.27, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10084775, N' Sebastiao Ramalho da Silva Junior', 40.21, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10075717, N' Thiago Pereira Gomes', 42.78, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10011810, N' Willian Douglas de Sousa Coelho', 43.3, N'SJN')
GO
INSERT [dbo].[AuxiliarCFP] ([Inscricao], [Nome], [Nota], [Concorrencia]) VALUES (10100179, N' Zenilton Galvao Nunes', 38.66, N'SJN')
GO


");

      Sql(@"update a set
	            a.NotaEtapa2 = ap.Nota,
	            a.NotaFinal = a.NotaFinal + ap.Nota 
            from Aluno a 
	            left join AuxiliarCFP ap on ap.Inscricao = a.Inscricao
            where 
            a.Cargo = 'Agente'
            and ap.Inscricao is not null");
    }

    public override void Down()
    {
    }
  }
}
