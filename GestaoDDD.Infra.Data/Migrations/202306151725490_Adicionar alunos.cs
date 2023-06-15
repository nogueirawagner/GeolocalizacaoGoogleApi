namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class Adicionaralunos : DbMigration
  {
    public override void Up()
    {
      Sql(@"

        USE [GestaoDados]
        GO
        SET IDENTITY_INSERT [dbo].[Aluno] ON 
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (3, N'10002237', N' Felipe Santos Magnani Carneiro', N'Ampla', 121.12, 0, 121.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (4, N'10001286', N' Guilherme Augusto da Silva Bertaci', N'Ampla', 117.81, 0, 117.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (5, N'10061041', N' Jeancarlos da Silva Junior', N'Ampla', 116.71, 0, 116.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (6, N'10060642', N' Gustavo Gualda Goncalves', N'Ampla', 116.7, 0, 116.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (7, N'10032786', N' Renata Martino Caldeira', N'Ampla', 116.34, 0, 116.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (8, N'10035714', N' Pedro Hideu Iamada', N'Ampla', 115.03, 0, 115.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (9, N'10013978', N' Thaiane Vanessa Meira Nascente dos Santos', N'Ampla', 113.84, 0, 113.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (10, N'10044511', N' Thallita Raquel da Silva Mendes', N'Ampla', 113.37, 0, 113.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (11, N'10008877', N' Roberto Cesa', N'Ampla', 113.36, 0, 113.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (12, N'10044600', N' Gabriel Lima Silva', N'Ampla', 112.46, 0, 112.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (13, N'10034498', N' LuizMauricio Soares de Andrade', N'Ampla', 112.1, 0, 112.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (14, N'10016090', N' Guilherme Mendonca da Silva', N'Ampla', 111.81, 0, 111.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (15, N'10022621', N' Camila Mota Silva', N'Ampla', 111.62, 0, 111.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (16, N'10000573', N' Maria Eduarda Ferreira Mansur', N'Ampla', 111.44, 0, 111.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (17, N'10032216', N' Luis Fernando Serrao Fabio', N'Ampla', 110.94, 0, 110.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (18, N'10026926', N' Thiago Bolelli Costa', N'Ampla', 110.9, 0, 110.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (19, N'10012904', N' Yan Nunes Rangel Costa', N'Ampla', 110.84, 0, 110.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (20, N'10021472', N' Bruno Ali Abou Ali', N'Ampla', 110.78, 0, 110.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (21, N'10006223', N'Isabela Brito Couto de Oliveira', N'Ampla', 110.07, 0, 110.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (22, N'10072204', N' Eduardo Figueiredo Fialho', N'Ampla', 109.74, 0, 109.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (23, N'10002922', N'Sarah de Oliveira e Silva', N'Ampla', 109.29, 0, 109.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (24, N'10007092', N' Natalia de Araujo Matte', N'Ampla', 109.17, 0, 109.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (25, N'10009781', N' Matheus Ulisses Pimenta', N'Ampla', 109.15, 0, 109.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (26, N'10030494', N' Micael Alves de Paula e Silva', N'Ampla', 108.87, 0, 108.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (27, N'10104731', N' GuilhermeHenrique Soares Felix', N'Ampla', 108.78, 0, 108.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (28, N'10034214', N' Darlan Ferreira da Silva', N'Ampla', 108.14, 0, 108.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (29, N'10016396', N' Sara Evelinde Sales Oliveira', N'Ampla', 107.97, 0, 107.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (30, N'10004120', N' Laiane Silva Pereira', N'Ampla', 107.95, 0, 107.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (31, N'10004768', N' Lucas Fonseca Davila', N'Ampla', 107.93, 0, 107.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (32, N'10035635', N' Yuri Castello Branco Brito', N'Ampla', 107.89, 0, 107.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (33, N'10000830', N' Robson Rossi Silva deMesquita', N'Ampla', 107.87, 0, 107.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (34, N'10002143', N' Webert Hudson Araujo Alquimim', N'Ampla', 107.7, 0, 107.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (35, N'10013190', N' Ciro Augusto Coelho de Almeida', N'Ampla', 107.68, 0, 107.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (36, N'10008917', N' Guilherme Pires Saraiva', N'Ampla', 107.62, 0, 107.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (37, N'10060711', N' Leticia Cantuaria Santos', N'Ampla', 107.54, 0, 107.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (38, N'10005025', N' Sabrina Stinghel Soares', N'Ampla', 107.48, 0, 107.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (39, N'10008777', N' Fabiane Cileia Oliveira Soares', N'Ampla', 107.46, 0, 107.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (40, N'10001705', N' Filipi Cardoso Eleuterio', N'Ampla', 107.45, 0, 107.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (41, N'10075529', N' Raianne RochaAmorim', N'Ampla', 107.39, 0, 107.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (42, N'10023608', N' Joao Victor Couto de Resende Silva', N'Ampla', 107.26, 0, 107.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (43, N'10026933', N' Edgar BelliniXavier', N'Ampla', 107.24, 0, 107.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (44, N'10001622', N' Bruno da Silva Coelho', N'Ampla', 107.2, 0, 107.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (45, N'10010781', N' Gabriel Leite Monteiro Fortes', N'Ampla', 107.16, 0, 107.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (46, N'10002252', N' Carolina Rocha Parente', N'Ampla', 107.11, 0, 107.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (47, N'10001243', N' Pedro Gabriel Leobas Maracaipe', N'Ampla', 107.11, 0, 107.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (48, N'10003024', N' Lucas Dadona Chiaradia Braga', N'Ampla', 106.95, 0, 106.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (49, N'10003374', N' Gabriel Cavalcante Rodrigues', N'Ampla', 106.92, 0, 106.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (50, N'10000369', N' Rodrigo Tadeu Meyenberg', N'Ampla', 106.91, 0, 106.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (51, N'10064043', N' LuizFelipe Barbosa Pinheiro', N'Ampla', 106.83, 0, 106.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (52, N'10011658', N' Robson Veloso Goes', N'Ampla', 106.83, 0, 106.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (53, N'10007155', N' MateusCarvalho Xavier', N'Ampla', 106.8, 0, 106.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (54, N'10044799', N' Gabriel de Melo Tavares dos Santos', N'Ampla', 106.78, 0, 106.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (55, N'10078202', N' Fernando Henrique Laurenti Zaparoli', N'Ampla', 106.78, 0, 106.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (56, N'10006052', N' Andre Victor Goncales Rodrigues Rios', N'Ampla', 106.63, 0, 106.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (57, N'10025523', N' Humberto Gonczarowska Jorge', N'Ampla', 106.59, 0, 106.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (58, N'10061842', N' Jorge Eduardo NunesRibeiro', N'Ampla', 106.54, 0, 106.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (59, N'10026608', N' Arthur Galileu Veleci Tome', N'Ampla', 106.52, 0, 106.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (60, N'10000955', N' Matheus Costa deFreitas', N'Ampla', 106.5, 0, 106.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (61, N'10011108', N' Francinildo Costa Mesquita', N'Ampla', 106.4, 0, 106.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (62, N'10015900', N' Adalice Flavia Duartede Medeiros', N'Ampla', 106.39, 0, 106.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (63, N'10042228', N' Luthiane Aparecida Silva', N'Ampla', 106.32, 0, 106.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (64, N'10007636', N' Katia de CarvalhoPrado', N'Ampla', 106.32, 0, 106.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (65, N'10009660', N' Gun Jo', N'Ampla', 106.23, 0, 106.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (66, N'10007666', N' Bruno Favoretto Silva', N'Ampla', 106.08, 0, 106.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (67, N'10023456', N' Nathallia Franco Santos', N'Ampla', 106.05, 0, 106.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (68, N'10025143', N' Mariana da Silva Novaes', N'Ampla', 106.02, 0, 106.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (69, N'10020887', N' Philipp de Souza Ribeiro', N'Ampla', 105.99, 0, 105.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (70, N'10073307', N' Rebeka Dantas dos Santos Vilanova', N'Ampla', 105.93, 0, 105.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (71, N'10055572', N' Ana Luisa Fernandes dos Reis', N'Ampla', 105.79, 0, 105.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (72, N'10039221', N' Aline Vitorassi Moreira', N'Ampla', 105.78, 0, 105.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (73, N'10098140', N' Eric Vonderscher', N'Ampla', 105.78, 0, 105.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (74, N'10060031', N' Lucas Pacheco Barreto', N'Ampla', 105.69, 0, 105.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (75, N'10005394', N'Rayssa Polianna Silva', N'Ampla', 105.68, 0, 105.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (76, N'10030172', N' Guilherme Mendes Tavares', N'Ampla', 105.68, 0, 105.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (77, N'10025275', N'Eduardo Eiler Batista de Araujo', N'Ampla', 105.56, 0, 105.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (78, N'10060514', N' Pedro Henrique Penaforte Ximenes', N'Ampla', 105.53, 0, 105.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (79, N'10062303', N' Lucas da Silva Vieira', N'Ampla', 105.51, 0, 105.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (80, N'10000753', N' Tamires Jade Pereira da Silva', N'Ampla', 105.42, 0, 105.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (81, N'10036068', N' Alessandra Sousa da Silveira', N'Ampla', 105.31, 0, 105.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (82, N'10045080', N' Carolina de Oliveira Moura', N'Ampla', 105.23, 0, 105.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (83, N'10020026', N' Jose Luiz Neves dos Santos Junior', N'Ampla', 105.22, 0, 105.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (84, N'10042456', N' Mayara Costa Freire Vasconcellos Pitanga', N'Ampla', 105.02, 0, 105.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (85, N'10031285', N' Maria Cecilia Sampaio Watanabe', N'Ampla', 105, 0, 105)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (86, N'10003351', N' Mayara CristinaGomes Maia', N'Ampla', 104.91, 0, 104.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (87, N'10101022', N' Jessica de Moraes Pereira', N'Ampla', 104.91, 0, 104.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (88, N'10009735', N' Diogo Andradedo Nascimento', N'Ampla', 104.79, 0, 104.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (89, N'10030798', N' Pedro Ribeiro Dornelas', N'Ampla', 104.71, 0, 104.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (90, N'10064148', N' WilliamRadziavicius Santos Cavalheri', N'Ampla', 104.65, 0, 104.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (91, N'10009101', N' Leonardo Dias Carneiro', N'Ampla', 104.63, 0, 104.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (92, N'10033729', N'Yuri Nunes Rangel Costa', N'Ampla', 104.58, 0, 104.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (93, N'10051248', N' Bruna Ribeiro de Almeida', N'Ampla', 104.53, 0, 104.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (94, N'10060014', N'Gustavo Henrique Clement Souza', N'Ampla', 104.45, 0, 104.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (95, N'10017720', N' Danilo Simoes Nascimento', N'Ampla', 104.42, 0, 104.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (96, N'10025651', N' Marcia Vieira de Azevedo de Morais', N'Ampla', 104.36, 0, 104.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (97, N'10003796', N' Daniel Lelis de Oliveira', N'Ampla', 104.33, 0, 104.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (98, N'10039479', N' Valeria Maria Rosa', N'Ampla', 104.28, 0, 104.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (99, N'10037287', N' Joheser Wellington de Barros Pereira', N'Ampla', 104.28, 0, 104.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (100, N'10013616', N' Samuel Oliveira da Cunha', N'Ampla', 104.21, 0, 104.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (101, N'10014552', N' Joao Vitor Alencar de Oliveira', N'Ampla', 104.09, 0, 104.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (102, N'10013750', N' Bruno Toffano Seidel Calazans', N'Ampla', 104.04, 0, 104.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (103, N'10007805', N' Sandra Cristina Cavalcante deAraujo', N'Ampla', 104.02, 0, 104.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (104, N'10006063', N' Marco Holetz de Toledo Lourenco', N'Ampla', 103.94, 0, 103.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (105, N'10000327', N' LeonardoCamargo de Moura Leocadio', N'Ampla', 103.92, 0, 103.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (106, N'10020542', N' Rafael Cavaignac Ribeiro Borges', N'Ampla', 103.77, 0, 103.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (107, N'10002486', N' Lucas Alves Dias', N'Ampla', 103.75, 0, 103.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (108, N'10049198', N' Pablo Felipe dos Santos', N'Ampla', 103.73, 0, 103.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (109, N'10043736', N' Matheus Franca dos Reis', N'Ampla', 103.67, 0, 103.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (110, N'10087130', N' Marcos Antonio Alves de Oliveira Pinto', N'Ampla', 103.65, 0, 103.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (111, N'10026511', N' Fernando Bergamo', N'Ampla', 103.63, 0, 103.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (112, N'10046745', N' Guilherme Hagen Evangelista da Silva', N'Ampla', 103.51, 0, 103.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (113, N'10070781', N' Bruna Monyque Borges Santos', N'Ampla', 103.44, 0, 103.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (114, N'10019156', N' Gabriel Resende Assis', N'Ampla', 103.42, 0, 103.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (115, N'10057242', N' Frederico Campos Leao', N'Ampla', 103.37, 0, 103.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (116, N'10026894', N' David Pires Holanda Araujo', N'Ampla', 103.33, 0, 103.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (117, N'10062094', N' Gabriel Tolentino Costa Ferreira', N'Ampla', 103.29, 0, 103.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (118, N'10024179', N' Leonardo Carvalho de Medeiros', N'Ampla', 103.26, 0, 103.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (119, N'10055852', N' Marina Lemes Machado Gomes', N'Ampla', 103.23, 0, 103.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (120, N'10054140', N' Vitor Neves Ergang', N'Ampla', 103.2, 0, 103.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (121, N'10081676', N' Gabriel Ferreira e Campos Pereira', N'Ampla', 103.19, 0, 103.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (122, N'10037118', N' Rodrigo Carlos de Almeida', N'Ampla', 103.18, 0, 103.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (123, N'10022160', N' Marcos de Biazi Goldberg', N'Ampla', 103.17, 0, 103.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (124, N'10068784', N' Igor SotoSilawsky', N'Ampla', 103.15, 0, 103.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (125, N'10005029', N' Hortensia Pereira de Souza', N'Ampla', 103.14, 0, 103.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (126, N'10031571', N' Matheus Amaral Guimaraes', N'Ampla', 102.98, 0, 102.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (127, N'10055793', N' Igor Teixeira Pfrimer', N'Ampla', 102.98, 0, 102.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (128, N'10023828', N' Ewerton Renan Aguiarde Sampaio', N'Ampla', 102.9, 0, 102.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (129, N'10027030', N' Leonardo Marinho Marques da Silva', N'Ampla', 102.88, 0, 102.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (130, N'10004713', N' AnaLuisa Sa de Oliveira', N'Ampla', 102.87, 0, 102.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (131, N'10043824', N' Felipe Salgado de Padua', N'Ampla', 102.85, 0, 102.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (132, N'10025432', N' TharcisPereira do Sacramento', N'Ampla', 102.79, 0, 102.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (133, N'10093095', N' Andre Honorato Marins', N'Ampla', 102.73, 0, 102.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (134, N'10054585', N' VitorAlves Fonseca de Oliveira', N'Ampla', 102.73, 0, 102.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (135, N'10088223', N' Gustavo Barbosa Machado', N'Ampla', 102.67, 0, 102.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (136, N'10016630', N'Joao Antonio Calazans do Prado Carvalho', N'Ampla', 102.64, 0, 102.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (137, N'10012124', N' Ana Beatriz Guedes Cota', N'Ampla', 102.62, 0, 102.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (138, N'10059829', N' Thallys Deusdara Monsueth Alves', N'Ampla', 102.6, 0, 102.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (139, N'10009944', N' Matheus de Carvalho Lincoln', N'Ampla', 102.57, 0, 102.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (140, N'10014715', N' Felipe Magalhaes Alves', N'Ampla', 102.53, 0, 102.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (141, N'10010460', N' Lucas Silva Casadio', N'Ampla', 102.53, 0, 102.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (142, N'10042949', N' Wilquer Coelho dos Santos', N'Ampla', 102.45, 0, 102.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (143, N'10007191', N' Gustavo Brandao de Souza', N'Ampla', 102.45, 0, 102.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (144, N'10026270', N' Lucas Cesar Pacheco', N'Ampla', 102.43, 0, 102.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (145, N'10001332', N' Takuma Machado Scarponi Cruz', N'Ampla', 102.42, 0, 102.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (146, N'10014937', N' Joao Lucas Alexandre Nunes Galvao Ferreira', N'Ampla', 102.36, 0, 102.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (147, N'10007135', N' Renata DelfinoBrito', N'Ampla', 102.33, 0, 102.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (148, N'10043650', N' Jose Lidberg Rocha Lima Filho', N'Ampla', 102.29, 0, 102.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (149, N'10006487', N' Andreia MoreiraCipriano', N'Ampla', 102.22, 0, 102.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (150, N'10013961', N' Luciana Nobrega', N'Ampla', 102.18, 0, 102.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (151, N'10014427', N' Kamila Rodrigues Barbosa', N'Ampla', 102.14, 0, 102.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (152, N'10050697', N' Gustavo Reis', N'Ampla', 102.11, 0, 102.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (153, N'10041615', N' Carlos Augusto de Carvalho Junior', N'Ampla', 102.07, 0, 102.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (154, N'10038961', N' Wellington Sousa de Oliveira', N'Ampla', 102.06, 0, 102.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (155, N'10046627', N' Ivan Bispo Santos', N'Ampla', 102.04, 0, 102.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (156, N'10047081', N' Maria Gerlane de Souza Silva', N'Ampla', 101.98, 0, 101.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (157, N'10096389', N' Mariana Koury Veloso', N'Ampla', 101.98, 0, 101.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (158, N'10009582', N' Nathalia Azarias de Souza', N'Ampla', 101.97, 0, 101.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (159, N'10020650', N' Danillo Franca Neves', N'Ampla', 101.94, 0, 101.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (160, N'10060343', N' Gabriel Salazar Maia', N'Ampla', 101.91, 0, 101.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (161, N'10030710', N' Sabrina da Costa Lopes Goncalo', N'Ampla', 101.87, 0, 101.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (162, N'10000775', N' Jasmine Frutuoso da Silva', N'Ampla', 101.86, 0, 101.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (163, N'10008489', N' Davi Spinola de Jesus Almeida', N'Ampla', 101.74, 0, 101.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (164, N'10011474', N' Lucas Vale Adjafre', N'Ampla', 101.72, 0, 101.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (165, N'10068717', N' Julio Fernando Queiroz Machado', N'Ampla', 101.71, 0, 101.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (166, N'10042894', N' Joao Lucas Santos Flores', N'Ampla', 101.68, 0, 101.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (167, N'10010668', N' Cauhe Lima Nogueira', N'Ampla', 101.64, 0, 101.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (168, N'10045938', N' Rodrigo Picinin Nascimento', N'Ampla', 101.63, 0, 101.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (169, N'10001888', N' Paulo Henrique Fernandes Ribeiro Silva', N'Ampla', 101.6, 0, 101.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (170, N'10037385', N' Getulio Pedro de Melo Filho', N'Ampla', 101.59, 0, 101.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (171, N'10006204', N' Amanda Karla SenaDourado', N'Ampla', 101.57, 0, 101.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (172, N'10035323', N' Guilherme Atila Martins Lacerda', N'Ampla', 101.52, 0, 101.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (173, N'10042332', N' Fernanda Gabriela de Souza Almeida e Abreu', N'Ampla', 101.51, 0, 101.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (174, N'10011747', N' Barbara Tobias da Fonseca', N'Ampla', 101.51, 0, 101.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (175, N'10008413', N' Brenda Bianca Neves Dias', N'Ampla', 101.51, 0, 101.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (176, N'10031251', N' Fabiola Imperiano Figueira', N'Ampla', 101.47, 0, 101.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (177, N'10005302', N' Luiza Holanda Barbosa Araujo', N'Ampla', 101.43, 0, 101.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (178, N'10070045', N' Fernando Cesar Pereira da Costa', N'Ampla', 101.41, 0, 101.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (179, N'10035747', N' Lucas Leal Lima de Abreu', N'Ampla', 101.4, 0, 101.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (180, N'10070690', N' Henrique Magalhaes Dias', N'Ampla', 101.37, 0, 101.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (181, N'10012915', N' Arthur Carvalho Soares', N'Ampla', 101.37, 0, 101.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (182, N'10048196', N' Gabriela Moreno Gentilin de Menezes', N'Ampla', 101.34, 0, 101.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (183, N'10015929', N' Matheus Cordeiro Lima', N'Ampla', 101.33, 0, 101.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (184, N'10019723', N' Thiago SoaresOuriques', N'Ampla', 101.32, 0, 101.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (185, N'10010288', N' Bruno Araujo Lima', N'Ampla', 101.3, 0, 101.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (186, N'10012723', N' Natalia Lemos Penetra', N'Ampla', 101.3, 0, 101.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (187, N'10082563', N' Izadora Pimenta Rocha Carvalho', N'Ampla', 101.27, 0, 101.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (188, N'10019405', N' Pedro Augusto daCamara de Oliveira', N'Ampla', 101.27, 0, 101.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (189, N'10021102', N' Barbara Carvalho de Moura', N'Ampla', 101.25, 0, 101.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (190, N'10024702', N' BeatrizMachado Willman Saar', N'Ampla', 101.19, 0, 101.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (191, N'10002599', N' Lincoln Pinheiro de Oliveira', N'Ampla', 101.17, 0, 101.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (192, N'10015600', N'Damaris Moreira de Lima', N'Ampla', 101.15, 0, 101.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (193, N'10030261', N' Mariana Ribeiro Fortes Barbosa', N'Ampla', 101.14, 0, 101.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (194, N'10098927', N' Lucas de Alencar Oliveira', N'Ampla', 101.11, 0, 101.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (195, N'10004773', N' Flavio Barbosa da Silva Junior', N'Ampla', 101.11, 0, 101.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (196, N'10077141', N' Felipe Vargas Grey Tavares', N'Ampla', 101.1, 0, 101.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (197, N'10012190', N' Eslen de Souza Araujo', N'Ampla', 101.1, 0, 101.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (198, N'10047638', N' Thiago de Lima Klen Barreto', N'Ampla', 101.09, 0, 101.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (199, N'10001272', N' Humberto Cezar Gama Guimaraes', N'Ampla', 101.08, 0, 101.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (200, N'10021856', N' Isabella dos Santos Silva', N'Ampla', 100.97, 0, 100.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (201, N'10026423', N' Vitor Rodrigues Santos', N'Ampla', 100.89, 0, 100.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (202, N'10021592', N' Diogenes Martins de Siqueira', N'Ampla', 100.84, 0, 100.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (203, N'10034505', N' Wanderson Souza Marques', N'Ampla', 100.83, 0, 100.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (204, N'10071023', N' Felippe Henrique Almada Albuquerque Moreira', N'Ampla', 100.82, 0, 100.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (205, N'10085602', N' Yuri Portugal Serrao Ramos', N'Ampla', 100.79, 0, 100.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (206, N'10003681', N' Joao Pedro Oliveira Silva', N'Ampla', 100.79, 0, 100.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (207, N'10028974', N' MaiaraNeri Josino', N'Ampla', 100.75, 0, 100.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (208, N'10055232', N' Lorenna de Souza Nascimento do Carmo', N'Ampla', 100.73, 0, 100.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (209, N'10009555', N'Roberta Almeida Silva Pereira', N'Ampla', 100.73, 0, 100.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (210, N'10008694', N' Mateus Oliveira Bistene', N'Ampla', 100.72, 0, 100.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (211, N'10007783', N'Matheus Pereira Goncalves', N'Ampla', 100.71, 0, 100.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (212, N'10024153', N' Carlos Magno Machado Lemos', N'Ampla', 100.71, 0, 100.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (213, N'10050369', N' Maxmyller Mourao Bezerra', N'Ampla', 100.66, 0, 100.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (214, N'10008798', N' Nathalia Malacrida de Araujo', N'Ampla', 100.64, 0, 100.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (215, N'10076880', N' James Bernardes de Almeida Junior', N'Ampla', 100.59, 0, 100.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (216, N'10000320', N' Carolina Pinho de Castro', N'Ampla', 100.59, 0, 100.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (217, N'10023397', N' Pedro Ivo Marques de Melo', N'Ampla', 100.57, 0, 100.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (218, N'10034236', N' Daniela Maia Baruzzi', N'Ampla', 100.57, 0, 100.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (219, N'10052103', N' Caroline Cerqueira Alves Ferreira', N'Ampla', 100.53, 0, 100.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (220, N'10021875', N' Arthur Araujo deSousa', N'Ampla', 100.51, 0, 100.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (221, N'10007032', N' Adriana Santos de Jesus', N'Ampla', 100.49, 0, 100.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (222, N'10011060', N' Bruno Saboia Demeterco', N'Ampla', 100.48, 0, 100.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (223, N'10061864', N' Diego Aires Jacome', N'Ampla', 100.48, 0, 100.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (224, N'10003294', N' Sarah Gomes Barroso', N'Ampla', 100.48, 0, 100.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (225, N'10091776', N' Lhuan Terra Diego de Souza Gomes', N'Ampla', 100.46, 0, 100.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (226, N'10008837', N' Caroline AlmeidaSodre', N'Ampla', 100.44, 0, 100.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (227, N'10013454', N' Silas Dantas Silva', N'Ampla', 100.44, 0, 100.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (228, N'10005967', N' Bernardo Carius Ceschini', N'Ampla', 100.4, 0, 100.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (229, N'10017551', N' Matheus Henrique Fernandes di Credico', N'Ampla', 100.39, 0, 100.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (230, N'10008164', N' Nayara daSilva Magalhaes', N'Ampla', 100.38, 0, 100.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (231, N'10039934', N' Jessica Karoline Nogueira da Silva', N'Ampla', 100.37, 0, 100.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (232, N'10023469', N' Laisde Sousa Lima Reboucas', N'Ampla', 100.31, 0, 100.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (233, N'10017241', N' Henrique Figueiredo Coelho', N'Ampla', 100.3, 0, 100.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (234, N'10020622', N'Ana Paula Souto Villarinho', N'Ampla', 100.3, 0, 100.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (235, N'10029028', N' Fernanda Miranda de Souza', N'Ampla', 100.24, 0, 100.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (236, N'10033423', N'Matheus Lira Rodrigues', N'Ampla', 100.22, 0, 100.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (237, N'10086804', N' Philippe Frota Menezes', N'Ampla', 100.2, 0, 100.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (238, N'10099095', N' JoaoVictor Tomaz Anacleto', N'Ampla', 100.18, 0, 100.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (239, N'10028761', N' Raquel Carvalho Pereira', N'Ampla', 100.18, 0, 100.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (240, N'10036324', N'Rodolfo Pereira da Silva', N'Ampla', 100.17, 0, 100.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (241, N'10019704', N' Tamara Miranda Ferreira Figueiroa', N'Ampla', 100.16, 0, 100.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (242, N'10037603', N' Elder Carlos Melo', N'Ampla', 100.16, 0, 100.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (243, N'10079723', N' Matheus Goncalves Pereira', N'Ampla', 100.14, 0, 100.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (244, N'10038558', N' Bruna Fagundes Perfeito', N'Ampla', 100.11, 0, 100.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (245, N'10033474', N' Pedro Henrique Silva Mariz', N'Ampla', 100.09, 0, 100.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (246, N'10011553', N' Tiago dos Santos Ferreira', N'Ampla', 100.08, 0, 100.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (247, N'10013477', N' Talita Silva Rodrigues', N'Ampla', 100.04, 0, 100.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (248, N'10023861', N' Thadeu Pessoa Passos Santos', N'Ampla', 100.03, 0, 100.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (249, N'10012902', N' Ludmilla Eleuterio Rodrigues', N'Ampla', 100.02, 0, 100.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (250, N'10012062', N' Vitoria Hadassa de Souza Santos', N'Ampla', 100.02, 0, 100.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (251, N'10081572', N' Luciana Graever de Medeiros', N'Ampla', 99.97, 0, 99.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (252, N'10000793', N' Francisco Jose Prezado Louro Marques', N'Ampla', 99.96, 0, 99.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (253, N'10024668', N' Stephano Praxedes Mendonca', N'Ampla', 99.94, 0, 99.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (254, N'10051492', N' Matheus Pedroso Dias', N'Ampla', 99.89, 0, 99.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (255, N'10000503', N' Breno Douglas Galvao de Paiva', N'Ampla', 99.87, 0, 99.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (256, N'10065056', N' Francisco Junior de Azevedo', N'Ampla', 99.86, 0, 99.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (257, N'10000749', N' Eduardo Naves Cardoso', N'Ampla', 99.85, 0, 99.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (258, N'10030027', N' Ivan de Oliveira Lobo Neto', N'Ampla', 99.84, 0, 99.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (259, N'10083694', N' Leticia Batista Merencio de Lima', N'Ampla', 99.83, 0, 99.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (260, N'10049031', N' Lucas Souza Araujo', N'Ampla', 99.81, 0, 99.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (261, N'10000364', N' Leonardo Nunes da Silva', N'Ampla', 99.8, 0, 99.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (262, N'10047094', N' Diego Ramon Cordeiro Santos', N'Ampla', 99.77, 0, 99.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (263, N'10059673', N' Nathalia Xavier deAlcantara', N'Ampla', 99.75, 0, 99.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (264, N'10027209', N' Danillo Gaia Duarte de Lima', N'Ampla', 99.72, 0, 99.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (265, N'10001871', N' Felipe Schaper Ferraz', N'Ampla', 99.72, 0, 99.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (266, N'10011515', N' Fabiano Dutra de Azevedo', N'Ampla', 99.72, 0, 99.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (267, N'10045428', N' Danusa de Castro Fonseca', N'Ampla', 99.71, 0, 99.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (268, N'10009586', N' Brunno Nascimento Moura', N'Ampla', 99.67, 0, 99.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (269, N'10051340', N' Peterson de Lira Quirino', N'Ampla', 99.67, 0, 99.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (270, N'10061145', N' Lucas Gustavo Souza de Melo', N'Ampla', 99.64, 0, 99.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (271, N'10040241', N' Rodrigo Santos Mendes', N'Ampla', 99.64, 0, 99.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (272, N'10099986', N' Rafael Flores de Magalhaes', N'Ampla', 99.63, 0, 99.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (273, N'10014467', N' Flavio Winicius deMoraes Martins', N'Ampla', 99.62, 0, 99.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (274, N'10101429', N' Ellionay Sousa de Freitas', N'Ampla', 99.6, 0, 99.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (275, N'10003244', N' Vinicius Tavaresde Castro', N'Ampla', 99.59, 0, 99.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (276, N'10008827', N' Gabriel Lira do Nascimento', N'Ampla', 99.58, 0, 99.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (277, N'10038796', N' Ana Paula Silva deMendonca', N'Ampla', 99.54, 0, 99.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (278, N'10026809', N' Manuella Maria Santos Miguel da Silva', N'Ampla', 99.52, 0, 99.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (279, N'10013790', N' VictorBaracho Alves', N'Ampla', 99.49, 0, 99.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (280, N'10021075', N' Caroline Gomes Carvalho', N'Ampla', 99.44, 0, 99.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (281, N'10055656', N' Patricia Merlimde Oliveira', N'Ampla', 99.43, 0, 99.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (282, N'10075801', N' Gleisson Mateus de Souza', N'Ampla', 99.43, 0, 99.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (283, N'10038170', N' Thais Andreia deSouza Santos', N'Ampla', 99.42, 0, 99.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (284, N'10005402', N' Maximilian Emanuel Hierstetter', N'Ampla', 99.42, 0, 99.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (285, N'10003749', N' GabrielArana da Silva', N'Ampla', 99.36, 0, 99.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (286, N'10033493', N' Giovane Camargos Rezende de Lima', N'Ampla', 99.32, 0, 99.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (287, N'10076991', N'Cristina Spacki', N'Ampla', 99.31, 0, 99.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (288, N'10044006', N' Bruna Araujo Pinto', N'Ampla', 99.3, 0, 99.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (289, N'10018383', N' Felipe Mello Gonzaga', N'Ampla', 99.28, 0, 99.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (290, N'10002300', N' Betina Dall Oglio Stacke', N'Ampla', 99.25, 0, 99.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (291, N'10105083', N' Wallace Willian do Nascimento Macedo', N'Ampla', 99.23, 0, 99.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (292, N'10001015', N' Erik Henrique de Arruda Silva', N'Ampla', 99.22, 0, 99.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (293, N'10068922', N' Arthur Nobre Brito', N'Ampla', 99.2, 0, 99.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (294, N'10050665', N' Priscila Furtado de Oliveira', N'Ampla', 99.18, 0, 99.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (295, N'10024621', N' Rodrigo Luiz Caron Burda', N'Ampla', 99.16, 0, 99.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (296, N'10024436', N' Pedro Ciminelli de Araujo', N'Ampla', 99.15, 0, 99.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (297, N'10078109', N' Alexandre Gabriel Silva Rodrigues', N'Ampla', 99.15, 0, 99.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (298, N'10002689', N' Juliana do Carmo Mangueira Celestino', N'Ampla', 99.15, 0, 99.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (299, N'10004488', N' RafaelTavares de Sa', N'Ampla', 99.11, 0, 99.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (300, N'10035949', N' Pedro Guilherme Feitoza Melo', N'Ampla', 99.08, 0, 99.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (301, N'10045067', N' EduardoDunck Oliveira', N'Ampla', 99.08, 0, 99.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (302, N'10010634', N' Camila Scarin Bezerra Mendes', N'Ampla', 99.02, 0, 99.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (303, N'10020117', N' LeticiaBettina Granados Goulart', N'Ampla', 99.02, 0, 99.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (304, N'10060464', N' Rafael Antunes dos Santos', N'Ampla', 99.02, 0, 99.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (305, N'10048884', N'Vitor Augusto Cardoso Silva', N'Ampla', 99, 0, 99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (306, N'10066250', N' Gustavo de Souza Silva Seara', N'Ampla', 98.99, 0, 98.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (307, N'10043862', N' Marcella Hermida de Paula', N'Ampla', 98.96, 0, 98.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (308, N'10026540', N' Amanda Araujo de Oliveira e Souza', N'Ampla', 98.96, 0, 98.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (309, N'10035918', N' Ana Carolina Salazar Albuquerque', N'Ampla', 98.9, 0, 98.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (310, N'10075504', N' Vinicius Pataro Generoso Sales', N'Ampla', 98.87, 0, 98.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (311, N'10011848', N' Caroline Morais Martins', N'Ampla', 98.83, 0, 98.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (312, N'10105850', N' Mariana Rodrigues Leite Ribeiro', N'Ampla', 98.82, 0, 98.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (313, N'10080938', N' Caio Cesar Nogueira Claudino', N'Ampla', 98.76, 0, 98.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (314, N'10018720', N' Elica Rocha Rodrigues', N'Ampla', 98.76, 0, 98.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (315, N'10002253', N' Fernanda Takako Hirayama', N'Ampla', 98.75, 0, 98.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (316, N'10021131', N' Fernanda Martins Rocha', N'Ampla', 98.75, 0, 98.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (317, N'10005953', N' Priscilla Passos Lacerda de Araujo Gois', N'Ampla', 98.74, 0, 98.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (318, N'10083119', N' Allan dos Santos Silva', N'Ampla', 98.74, 0, 98.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (319, N'10014930', N' Victor Amorim de Carvalho', N'Ampla', 98.69, 0, 98.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (320, N'10019700', N' Natalia Alcantara daSilva Adjuto', N'Ampla', 98.69, 0, 98.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (321, N'10034528', N' Marcos Wesley Brandinho Ribeiro', N'Ampla', 98.68, 0, 98.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (322, N'10002589', N' Luiz Eduardo Paes Pereira da Silva', N'Ampla', 98.67, 0, 98.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (323, N'10021710', N' Andrini Bethowen Bouzas de Oliveira', N'Ampla', 98.67, 0, 98.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (324, N'10016150', N' Davi Dantas Domingos', N'Ampla', 98.61, 0, 98.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (325, N'10083161', N' Ramon Fernandes Bastos Pinheiro', N'Ampla', 98.6, 0, 98.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (326, N'10013427', N' Denilson Santiago Barbosa', N'Ampla', 98.59, 0, 98.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (327, N'10028954', N' Pedro Sperchi Camilo', N'Ampla', 98.57, 0, 98.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (328, N'10032973', N' Vitor Alexandre Pereira', N'Ampla', 98.55, 0, 98.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (329, N'10015833', N' Arthur Gouvea Fernandes', N'Ampla', 98.48, 0, 98.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (330, N'10065004', N' Maira dos Santos Freitas', N'Ampla', 98.48, 0, 98.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (331, N'10029952', N' Bruno Cesar Sampaio Ribeiro de Assis', N'Ampla', 98.48, 0, 98.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (332, N'10000089', N' Eliane Santos Silva', N'Ampla', 98.47, 0, 98.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (333, N'10000494', N' Igor Augusto Alves Dias', N'Ampla', 98.47, 0, 98.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (334, N'10006040', N' Karolinne Araujo Souza', N'Ampla', 98.46, 0, 98.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (335, N'10014703', N' Claudio da Silva Gomes Filho', N'Ampla', 98.46, 0, 98.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (336, N'10064548', N' Washington Richel Saito da Silva', N'Ampla', 98.46, 0, 98.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (337, N'10049400', N' Flavia Vieira da Silva', N'Ampla', 98.42, 0, 98.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (338, N'10009181', N' Joao Pedro Koerich', N'Ampla', 98.4, 0, 98.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (339, N'10002663', N' Ciro Camilo Santos Leal', N'Ampla', 98.37, 0, 98.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (340, N'10051880', N'Pedro de Freitas Neder', N'Ampla', 98.35, 0, 98.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (341, N'10055039', N' Ian Alvares dos Prazeres Filho', N'Ampla', 98.32, 0, 98.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (342, N'10021976', N'Angelina Segre Melhoranca', N'Ampla', 98.31, 0, 98.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (343, N'10035150', N' Paulo Rodrigues de Morais Junior', N'Ampla', 98.29, 0, 98.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (344, N'10024629', N' Marcondes Azevedo', N'Ampla', 98.28, 0, 98.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (345, N'10075461', N' Juliana Vieira Zuany', N'Ampla', 98.24, 0, 98.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (346, N'10020737', N' Thiago Tetsuyuki Takada Ito', N'Ampla', 98.22, 0, 98.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (347, N'10045246', N' Ananda de Cassia do Nascimento Laurent Rocchi', N'Ampla', 98.21, 0, 98.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (348, N'10001539', N' Jouberth Maia Oliveira', N'Ampla', 98.19, 0, 98.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (349, N'10007325', N' Juliana Moreira Moraes', N'Ampla', 98.17, 0, 98.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (350, N'10003922', N' Winston Antonio Melo Severino', N'Ampla', 98.16, 0, 98.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (351, N'10002814', N' Carolina Farias Ferreira Moretto', N'Ampla', 98.14, 0, 98.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (352, N'10077393', N' Gustavo de Almeida Ferreira', N'Ampla', 98.11, 0, 98.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (353, N'10012754', N' Diogo Martins Ferreira', N'Ampla', 98.07, 0, 98.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (354, N'10042244', N' Luiz Phellipe Ribeiro Rodrigues', N'Ampla', 98.06, 0, 98.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (355, N'10040277', N' Raquel de Freitas Lerback', N'Ampla', 98.04, 0, 98.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (356, N'10015257', N' Marco Antonio de Souza Watanabe', N'Ampla', 98.03, 0, 98.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (357, N'10007528', N' Lucas Henrique Rosado Nascimento', N'Ampla', 98.02, 0, 98.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (358, N'10057539', N' Lucas Moraes Leocadio de Souza', N'Ampla', 98.02, 0, 98.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (359, N'10001042', N'Alexandre Gomes Serra', N'Ampla', 98, 0, 98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (360, N'10055319', N' Amanda Rocha Lemos', N'Ampla', 98, 0, 98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (361, N'10053439', N'Marcelo Babilonia de Melo', N'Ampla', 97.99, 0, 97.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (362, N'10079223', N' Lucas Cunha Azevedo', N'Ampla', 97.97, 0, 97.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (363, N'10058083', N' Gerson Brian Gomes Evangelista', N'Ampla', 97.95, 0, 97.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (364, N'10041940', N' Leonardo Souza Medeiros', N'Ampla', 97.93, 0, 97.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (365, N'10048723', N' CesarAlexandre Saraiva de Sousa', N'Ampla', 97.92, 0, 97.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (366, N'10003020', N' Vinicius Moreira Lana', N'Ampla', 97.89, 0, 97.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (367, N'10068379', N' ArturTavares Pereira Soares', N'Ampla', 97.88, 0, 97.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (368, N'10021904', N' Arthur Simas Pinheiro', N'Ampla', 97.88, 0, 97.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (369, N'10023453', N' Matheusde Moraes Soares', N'Ampla', 97.82, 0, 97.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (370, N'10062450', N' Rayssa Goncalves Sabino', N'Ampla', 97.81, 0, 97.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (371, N'10045945', N' Heitor AlvesRios Campos', N'Ampla', 97.81, 0, 97.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (372, N'10007454', N' Pedro Vitor Resende', N'Ampla', 97.79, 0, 97.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (373, N'10097640', N' Alexandre Mendonca Souto Lopes', N'Ampla', 97.73, 0, 97.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (374, N'10044911', N' Priscila Augusta Morgado Pessoa', N'Ampla', 97.72, 0, 97.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (375, N'10062554', N' Andre Frederico Barreto Leite', N'Ampla', 97.69, 0, 97.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (376, N'10010308', N' Igor Matheus Gomes Goncalves', N'Ampla', 97.68, 0, 97.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (377, N'10060962', N'Marcio Gadelha Vasconcelos', N'Ampla', 97.67, 0, 97.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (378, N'10026126', N' Ana Karolina Silva', N'Ampla', 97.66, 0, 97.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (379, N'10035941', N' Euzebio Alvarenga Santana', N'Ampla', 97.64, 0, 97.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (380, N'10032383', N' Cainan de Negreiros Martins Leite', N'Ampla', 97.58, 0, 97.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (381, N'10063705', N'Mariana de Lima Campos', N'Ampla', 97.55, 0, 97.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (382, N'10088849', N' Alberto da Conceicao Azevedo', N'Ampla', 97.54, 0, 97.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (383, N'10021467', N' Lucas Barros Sales dos Santos', N'Ampla', 97.5, 0, 97.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (384, N'10091408', N' Alexia Grassuri Barreto de Oliveira Demori', N'Ampla', 97.48, 0, 97.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (385, N'10000149', N' Gabriela Marques de Moura Arruda', N'Ampla', 97.46, 0, 97.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (386, N'10006996', N' Higor Barbosa de Souza', N'Ampla', 97.43, 0, 97.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (387, N'10038467', N' Thalisson Rodrigues Mendes', N'Ampla', 97.43, 0, 97.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (388, N'10024641', N' Cirano de Macedo TelesJunior', N'Ampla', 97.43, 0, 97.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (389, N'10091890', N' Gabriel Trinca Dutra', N'Ampla', 97.41, 0, 97.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (390, N'10011159', N' Marianne Araujo Santos', N'Ampla', 97.41, 0, 97.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (391, N'10013581', N' Guilherme Camargo Alves', N'Ampla', 97.4, 0, 97.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (392, N'10058747', N' Barbara Nunes Silveira', N'Ampla', 97.4, 0, 97.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (393, N'10076110', N' Sergio Calderaro Gomes Pinto Junior', N'Ampla', 97.34, 0, 97.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (394, N'10022684', N' Tayssa Cordeiro de Oliveira', N'Ampla', 97.33, 0, 97.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (395, N'10010819', N' Thiago Fernandes Beserra', N'Ampla', 97.33, 0, 97.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (396, N'10029084', N' Lucas Nascimento Ferreira', N'Ampla', 97.31, 0, 97.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (397, N'10017604', N' Lucas Augusto Borges Pereira', N'Ampla', 97.29, 0, 97.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (398, N'10072081', N' Lucas Martins Ramalho', N'Ampla', 97.28, 0, 97.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (399, N'10004848', N' Joysse Vasconcelos Franca', N'Ampla', 97.28, 0, 97.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (400, N'10081029', N' Rodineli Mendes Moreira', N'Ampla', 97.27, 0, 97.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (401, N'10033862', N' Felipe Henrique Teles de Faria de Souza', N'Ampla', 97.25, 0, 97.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (402, N'10069097', N' Mateus Silva Luna', N'Ampla', 97.25, 0, 97.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (403, N'10071612', N' Felipe Jose Gustavo de Oliveira', N'Ampla', 97.25, 0, 97.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (404, N'10041198', N' Carlos Phelipe Matias e Silva', N'Ampla', 97.24, 0, 97.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (405, N'10034670', N' Luciano Teixeira Lara', N'Ampla', 97.22, 0, 97.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (406, N'10018848', N' Deivid Melo da Silva', N'Ampla', 97.21, 0, 97.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (407, N'10006474', N' Jessica Oliveira Shneider Nobre', N'Ampla', 97.2, 0, 97.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (408, N'10067233', N' Luana Gomes de Oliveira', N'Ampla', 97.18, 0, 97.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (409, N'10029126', N' Wagner Alves Goncalves Nogueira', N'Ampla', 97.14, 0, 97.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (410, N'10060247', N' Carlos Renato Brasil Junior', N'Ampla', 97.14, 0, 97.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (411, N'10043624', N' Marcia Ferreira Moraes', N'Ampla', 97.12, 0, 97.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (412, N'10009530', N' Thalia Soares de Souza', N'Ampla', 97.12, 0, 97.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (413, N'10030999', N' Victor Lopes Costa Serra', N'Ampla', 97.11, 0, 97.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (414, N'10016052', N' Fernanda Schreiber', N'Ampla', 97.04, 0, 97.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (415, N'10011480', N' Henrique Carreiro Duarte Araujo Pereira', N'Ampla', 97.02, 0, 97.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (416, N'10037952', N' Gabriel Carvalho Nunes Silva', N'Ampla', 97, 0, 97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (417, N'10075760', N' Carolina Arruda dos Santos', N'Ampla', 96.98, 0, 96.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (418, N'10008178', N' Felipe Paschoali deAlmeida', N'Ampla', 96.98, 0, 96.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (419, N'10082496', N' Luiz Felipe Martins de Souza', N'Ampla', 96.94, 0, 96.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (420, N'10032581', N' Lais Santillo Morais', N'Ampla', 96.9, 0, 96.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (421, N'10057599', N' Randel Giordani Ferreira Montini', N'Ampla', 96.89, 0, 96.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (422, N'10054149', N' Karla Fernanda Soares', N'Ampla', 96.87, 0, 96.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (423, N'10006379', N' Marcus Fabricio do Amaral Moreira da Cunha', N'Ampla', 96.86, 0, 96.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (424, N'10003058', N' Rodrigo Melo de Oliveira', N'Ampla', 96.86, 0, 96.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (425, N'10009826', N' Leticia Campos Callado', N'Ampla', 96.86, 0, 96.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (426, N'10105746', N' Kiane Santos Braga', N'Ampla', 96.85, 0, 96.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (427, N'10072551', N' Alice Ozorio de Almeida Lima', N'Ampla', 96.85, 0, 96.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (428, N'10059036', N' Daniel Souza Matos', N'Ampla', 96.84, 0, 96.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (429, N'10031133', N' Roberto Danilo Rodopiano Teixeira', N'Ampla', 96.84, 0, 96.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (430, N'10053328', N' Eduardo Fernandes Mariano', N'Ampla', 96.83, 0, 96.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (431, N'10073306', N' Renan Wilson Lopes Prudencio', N'Ampla', 96.81, 0, 96.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (432, N'10012919', N' Jefferson Beijamim dos Santos', N'Ampla', 96.79, 0, 96.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (433, N'10016568', N' Phelipe Ferreira Cabral', N'Ampla', 96.78, 0, 96.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (434, N'10038778', N' Robert da Silva Mello', N'Ampla', 96.78, 0, 96.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (435, N'10037198', N' Ewerton Cruz Soares', N'Ampla', 96.77, 0, 96.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (436, N'10050441', N' Nikolas Franklin SilvaSantos', N'Ampla', 96.76, 0, 96.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (437, N'10021041', N' Arthur de Freitas Miranda', N'Ampla', 96.76, 0, 96.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (438, N'10006483', N' Vinicios Alves Ferreira', N'Ampla', 96.75, 0, 96.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (439, N'10031887', N' Roberto Matteus Bulcao dos Santos', N'Ampla', 96.73, 0, 96.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (440, N'10016214', N' Tiago Torres Braga', N'Ampla', 96.73, 0, 96.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (441, N'10093932', N' Luis Augusto Parnow', N'Ampla', 96.71, 0, 96.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (442, N'10060829', N' Ludmila Daniele Lopes', N'Ampla', 96.68, 0, 96.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (443, N'10035851', N' Walter Aires da Silva', N'Ampla', 96.67, 0, 96.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (444, N'10024455', N' Victor de Souza Pereira Mesquita', N'Ampla', 96.67, 0, 96.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (445, N'10040764', N' Beatriz Pereira Santos', N'Ampla', 96.63, 0, 96.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (446, N'10005485', N' Raphael Abreu de Barros Monteiro', N'Ampla', 96.6, 0, 96.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (447, N'10024854', N' Debora Tays Oliveira de Brito Marubayashi', N'Ampla', 96.57, 0, 96.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (448, N'10042867', N' Matheus de Carvalho Lima Rita', N'Ampla', 96.56, 0, 96.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (449, N'10036979', N' Luiz Claudio da Silva Medeiros Junior', N'Ampla', 96.55, 0, 96.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (450, N'10011821', N' EdmilsonFelix Coelho Junior', N'Ampla', 96.55, 0, 96.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (451, N'10018735', N' Katheryne Ferreira Carvalhaes', N'Ampla', 96.53, 0, 96.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (452, N'10050096', N'Thatiany Lopes de Oliveira', N'Ampla', 96.51, 0, 96.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (453, N'10027634', N' Ricardo Pedrosa Dagosto', N'Ampla', 96.51, 0, 96.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (454, N'10021398', N'Sergio Ricardo Vieira Ponde Serra', N'Ampla', 96.51, 0, 96.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (455, N'10073642', N' Gustavo Ferreira Rodrigues', N'Ampla', 96.5, 0, 96.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (456, N'10080469', N' Vanessa Brunna da Silva Brito Alves', N'Ampla', 96.49, 0, 96.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (457, N'10005519', N' Felipe Chiarelli Linhares Titoneli', N'Ampla', 96.47, 0, 96.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (458, N'10049030', N' Alvaro Lopes Machado', N'Ampla', 96.46, 0, 96.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (459, N'10073858', N' Jorge Andre de Paiva Martins', N'Ampla', 96.44, 0, 96.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (460, N'10035946', N' Tales Henrique Andrade da Mota', N'Ampla', 96.43, 0, 96.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (461, N'10076654', N' Mariana Borges Araujo', N'Ampla', 96.42, 0, 96.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (462, N'10057763', N' Natalia Alcantara Ayres', N'Ampla', 96.4, 0, 96.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (463, N'10033240', N' Douglas Cantudo Goncalves', N'Ampla', 96.4, 0, 96.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (464, N'10010273', N' Mirian Sousa de Freitas', N'Ampla', 96.39, 0, 96.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (465, N'10015353', N' Priscila de Andrade Fernandes', N'Ampla', 96.38, 0, 96.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (466, N'10081708', N' Hugo Lopes Neves', N'Ampla', 96.36, 0, 96.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (467, N'10002615', N' Daniel Falcao da Rocha', N'Ampla', 96.36, 0, 96.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (468, N'10035723', N' Murilo Munhoz de Souza', N'Ampla', 96.36, 0, 96.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (469, N'10085743', N' Davi de Almeida Freitas', N'Ampla', 96.34, 0, 96.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (470, N'10068762', N' Gabriel Pires Neto', N'Ampla', 96.34, 0, 96.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (471, N'10009036', N' Samara Lisczkovski', N'Ampla', 96.34, 0, 96.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (472, N'10047153', N' AugustoLuis Torquete de Oliveira', N'Ampla', 96.31, 0, 96.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (473, N'10011683', N' Kevin Matheus Monteiro Leite', N'Ampla', 96.3, 0, 96.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (474, N'10093077', N'Felipe Figueira de Sales Pereira', N'Ampla', 96.3, 0, 96.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (475, N'10058676', N' Rafael Pereira Felix', N'Ampla', 96.29, 0, 96.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (476, N'10017198', N'Jefferson Paiva Nascimento', N'Ampla', 96.29, 0, 96.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (477, N'10029461', N' Nicolas de Castro Alves', N'Ampla', 96.26, 0, 96.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (478, N'10016369', N' VictorEmmanuel Delfino Aleixo', N'Ampla', 96.2, 0, 96.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (479, N'10014572', N' Daniel Alexandre Gomes Santana', N'Ampla', 96.2, 0, 96.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (480, N'10045952', N' Vanderson Wallace Queiroz dos Santos', N'Ampla', 96.14, 0, 96.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (481, N'10104026', N' Romeu Gomes de Morais Filho', N'Ampla', 96.13, 0, 96.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (482, N'10023979', N' Ana Carolina Angelo Passos', N'Ampla', 96.13, 0, 96.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (483, N'10045660', N' Jackellyne Jenyffer Ferreira dos Santos', N'Ampla', 96.1, 0, 96.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (484, N'10041826', N' Vancleucyo Machado da Silva', N'Ampla', 96.1, 0, 96.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (485, N'10021307', N' Paulo Eduardo Lazar Meyer', N'Ampla', 96.1, 0, 96.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (486, N'10000948', N' Stephanie Correia Costa', N'Ampla', 96.08, 0, 96.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (487, N'10045292', N' Larissa Pires deAzevedo', N'Ampla', 96.08, 0, 96.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (488, N'10075057', N' Nathalia Feitosa de Franca', N'Ampla', 96.07, 0, 96.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (489, N'10086884', N' Eric de AlmeidaAlvarenga', N'Ampla', 96.07, 0, 96.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (490, N'10002238', N' Nailton Pereira Danesi Damacena', N'Ampla', 96.02, 0, 96.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (491, N'10067638', N' Ellen Pereirade Normando', N'Ampla', 96.02, 0, 96.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (492, N'10035933', N' Hana Augusta de Andrade', N'Ampla', 95.99, 0, 95.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (493, N'10085299', N' Gabriel RibeiroBraga', N'Ampla', 95.97, 0, 95.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (494, N'10005534', N' Marceu Silva Sa', N'Ampla', 95.96, 0, 95.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (495, N'10065964', N' Lucas Rodrigues de Araujo Ledo', N'Ampla', 95.95, 0, 95.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (496, N'10006062', N' Lais Bandeira Lopes', N'Ampla', 95.94, 0, 95.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (497, N'10032546', N' Igor Nunes Hoffmann', N'Ampla', 95.93, 0, 95.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (498, N'10011854', N' Pablo Araujo da Gama', N'Ampla', 95.93, 0, 95.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (499, N'10000903', N' Renan Henrique Santos Pereira', N'Ampla', 95.9, 0, 95.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (500, N'10022076', N' Mariana Rodrigues de Souza', N'Ampla', 95.89, 0, 95.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (501, N'10000883', N' Lucas Felipe Pereira Nunes', N'Ampla', 95.87, 0, 95.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (502, N'10019170', N' Gabriel Abi Chahin de Oliveira Ferreira', N'Ampla', 95.85, 0, 95.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (503, N'10002741', N' Ana Gabriela Ferreira Miranda', N'Ampla', 95.85, 0, 95.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (504, N'10079862', N' Ana Flavia Cardoso Almeida', N'Ampla', 95.85, 0, 95.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (505, N'10035133', N' Bruno Sartori de Campos', N'Ampla', 95.83, 0, 95.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (506, N'10001721', N' Thiago Henrique Doria de Oliveira', N'Ampla', 95.81, 0, 95.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (507, N'10076857', N' Diego FernandesCaldeira', N'Ampla', 95.8, 0, 95.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (508, N'10048310', N' Thiago Veiga Vian', N'Ampla', 95.79, 0, 95.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (509, N'10001660', N' Edielle de Oliveira Lagares', N'Ampla', 95.78, 0, 95.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (510, N'10053124', N' David Eloi Nunes', N'Ampla', 95.74, 0, 95.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (511, N'10016579', N' Pedro Lucas Elesbao Barbosa', N'Ampla', 95.73, 0, 95.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (512, N'10076866', N' Murilo Alencar Lopes', N'Ampla', 95.73, 0, 95.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (513, N'10010290', N' Joao Luis Machado Vasconcelos', N'Ampla', 95.72, 0, 95.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (514, N'10069123', N' Alessandra Nascimento da Silva', N'Ampla', 95.69, 0, 95.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (515, N'10028186', N' Amaury de Souza de Pontes', N'Ampla', 95.69, 0, 95.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (516, N'10010193', N' Jullia da Mata Almeida', N'Ampla', 95.68, 0, 95.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (517, N'10020320', N' Marianna Silva Martins', N'Ampla', 95.67, 0, 95.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (518, N'10026901', N' Deivisson Montalvao de Araujo', N'Ampla', 95.64, 0, 95.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (519, N'10067472', N' Jose de Alsimir Gomes Junior', N'Ampla', 95.63, 0, 95.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (520, N'10008973', N' Victor Santos Pimentel Rodrigues de Araujo', N'Ampla', 95.63, 0, 95.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (521, N'10015924', N' Vylther Pereira daSilva', N'Ampla', 95.58, 0, 95.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (522, N'10088947', N' Welington Alencar Borges', N'Ampla', 95.57, 0, 95.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (523, N'10043752', N' Ramon Braga Trajano', N'Ampla', 95.56, 0, 95.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (524, N'10092925', N' Vinicius Henrique de Oliveira Santos', N'Ampla', 95.56, 0, 95.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (525, N'10033613', N' Farida de OliveiraLuz', N'Ampla', 95.53, 0, 95.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (526, N'10008414', N' Jorge Lucas Costa Santiago', N'Ampla', 95.51, 0, 95.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (527, N'10015933', N' Iracema Rocha Souza', N'Ampla', 95.51, 0, 95.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (528, N'10053699', N' Barbara David Neves de Lima', N'Ampla', 95.49, 0, 95.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (529, N'10056157', N' Leonardo Alves de OlivaPassos', N'Ampla', 95.49, 0, 95.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (530, N'10080383', N' Saulo Maciel Rodrigues', N'Ampla', 95.48, 0, 95.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (531, N'10073947', N' Matheus Argolo Leao', N'Ampla', 95.48, 0, 95.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (532, N'10002718', N' Kassia Karolliny Ribeiro Camilo', N'Ampla', 95.47, 0, 95.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (533, N'10066831', N' Rodrigo Matos Lobo deSouza', N'Ampla', 95.47, 0, 95.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (534, N'10043689', N' Yuri Armstrong Cantanhede', N'Ampla', 95.45, 0, 95.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (535, N'10081546', N' Leandro Lima deSouza', N'Ampla', 95.43, 0, 95.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (536, N'10022675', N' Silvio Luis Martins Eleuterio', N'Ampla', 95.4, 0, 95.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (537, N'10012673', N' Guilherme CarneiroSarmento', N'Ampla', 95.38, 0, 95.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (538, N'10032256', N' Bruno Araujo Lopes', N'Ampla', 95.37, 0, 95.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (539, N'10025529', N' Beatriz Lisboa Veras', N'Ampla', 95.36, 0, 95.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (540, N'10034956', N' Marcelo Marques de Souza', N'Ampla', 95.34, 0, 95.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (541, N'10059658', N' Paula Prestes Azeredo', N'Ampla', 95.33, 0, 95.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (542, N'10054722', N' Andre Barbosa Botelho', N'Ampla', 95.32, 0, 95.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (543, N'10032690', N' Francisco Anderson Bezerra Rodrigues', N'Ampla', 95.31, 0, 95.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (544, N'10060395', N' Richard David Souza', N'Ampla', 95.31, 0, 95.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (545, N'10041187', N' Gleodes Victor Duarte de Souza', N'Ampla', 95.28, 0, 95.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (546, N'10095054', N' Matheus Pereira Mendes', N'Ampla', 95.25, 0, 95.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (547, N'10049415', N' Ana Clara Pimenta Freire', N'Ampla', 95.24, 0, 95.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (548, N'10023773', N' Tiago Matheus Lopes', N'Ampla', 95.23, 0, 95.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (549, N'10050195', N' David de Castro Martins', N'Ampla', 95.22, 0, 95.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (550, N'10053430', N'Hiago Rogerio Ulhoa', N'Ampla', 95.22, 0, 95.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (551, N'10004797', N' Wallesson Faria de Jesus', N'Ampla', 95.22, 0, 95.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (552, N'10033331', N' AntonyGoncalves Carvalho', N'Ampla', 95.21, 0, 95.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (553, N'10045181', N' Ramona Thorpe Lima', N'Ampla', 95.2, 0, 95.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (554, N'10007093', N' AmandaAlbuquerque Diniz', N'Ampla', 95.2, 0, 95.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (555, N'10004216', N' Juliano Brauller Macedo', N'Ampla', 95.2, 0, 95.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (556, N'10001702', N' RafaelRodrigues Gouveia', N'Ampla', 95.19, 0, 95.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (557, N'10067304', N' Jones de Araujo Pereira', N'Ampla', 95.19, 0, 95.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (558, N'10017072', N' Miguel Santos de Freitas', N'Ampla', 95.19, 0, 95.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (559, N'10051105', N' Ana Gabriela Pereira da Silva', N'Ampla', 95.18, 0, 95.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (560, N'10016351', N' Moises deAlmeida Bastos', N'Ampla', 95.17, 0, 95.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (561, N'10026123', N' Lucas Ferreira Fernandes', N'Ampla', 95.15, 0, 95.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (562, N'10005106', N' Vitor AntonioTeixeira Rozendo', N'Ampla', 95.14, 0, 95.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (563, N'10045019', N' Vinicius Umbelino de Souza Ribeiro', N'Ampla', 95.14, 0, 95.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (564, N'10086144', N'Anderson Carvalho de Loiola', N'Ampla', 95.13, 0, 95.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (565, N'10080935', N' Fabio Soller Cruz de Souza', N'Ampla', 95.13, 0, 95.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (566, N'10055761', N'Franciele Zambone Silva', N'Ampla', 95.12, 0, 95.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (567, N'10027672', N' Roberto Miyazaki Ramos', N'Ampla', 95.12, 0, 95.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (568, N'10046093', N'Barbara Elias Rodrigues', N'Ampla', 95.12, 0, 95.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (569, N'10059504', N' Larissa Ellen Monteiro Maciel', N'Ampla', 95.12, 0, 95.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (570, N'10022865', N'Mateus Costa Patrocinio', N'Ampla', 95.11, 0, 95.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (571, N'10014040', N' Matheus Ribeiro Linhares', N'Ampla', 95.08, 0, 95.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (572, N'10060061', N'Amanda Almeida Costa', N'Ampla', 95.07, 0, 95.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (573, N'10071479', N' Leonan Bezerra Araujo', N'Ampla', 95.06, 0, 95.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (574, N'10000349', N' DaniellaMontenegro Bazzi', N'Ampla', 95.04, 0, 95.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (575, N'10058504', N' Cicely Weluma Rossi de Lima', N'Ampla', 95.01, 0, 95.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (576, N'10052729', N' ClaraLeonel Abreu', N'Ampla', 95.01, 0, 95.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (577, N'10032041', N' Alex de Alcantara Ramos', N'Ampla', 95.01, 0, 95.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (578, N'10002711', N' Paloma deBustamante Carim', N'Ampla', 95, 0, 95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (579, N'10040610', N' Raphael Felipe de Moura dos Santos', N'Ampla', 94.99, 0, 94.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (580, N'10049134', N' Loise Kelem Oliveira da Hora', N'Ampla', 94.98, 0, 94.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (581, N'10010437', N' Anderson Jose Alves de Oliveira', N'Ampla', 94.97, 0, 94.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (582, N'10042752', N' Luan Torres Topdjian', N'Ampla', 94.96, 0, 94.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (583, N'10036490', N' Camilla Amaro Santos', N'Ampla', 94.96, 0, 94.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (584, N'10076387', N'Maria Andressa Veloso', N'Ampla', 94.95, 0, 94.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (585, N'10079365', N' Vitor Birck', N'Ampla', 94.93, 0, 94.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (586, N'10032162', N' Leonardo de MeloBrito Junior', N'Ampla', 94.92, 0, 94.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (587, N'10062799', N' Jessica Machado Horn', N'Ampla', 94.9, 0, 94.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (588, N'10025931', N' Cesar Rodrigues deQueiroz Macedo', N'Ampla', 94.9, 0, 94.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (589, N'10074481', N' Yara Rodrigues Cardoso', N'Ampla', 94.88, 0, 94.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (590, N'10016295', N' Luiz de JesusNunes da Silva', N'Ampla', 94.87, 0, 94.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (591, N'10057522', N' Paula Reginatto Bau', N'Ampla', 94.87, 0, 94.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (592, N'10092406', N' Loren LopesMachado', N'Ampla', 94.87, 0, 94.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (593, N'10060734', N' Alexandre Schmitz Hoff', N'Ampla', 94.86, 0, 94.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (594, N'10002311', N' Fernanda Viana deMorais', N'Ampla', 94.85, 0, 94.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (595, N'10044432', N' Barbara Amanda Agustinho da Silva', N'Ampla', 94.84, 0, 94.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (596, N'10007292', N' Carlos Tadeude Alencar Barreira Junior', N'Ampla', 94.82, 0, 94.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (597, N'10036387', N' Nilo Gomes Paiva', N'Ampla', 94.82, 0, 94.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (598, N'10058526', N' CatrynaGarcia Camargos', N'Ampla', 94.79, 0, 94.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (599, N'10032796', N' Tiago Spindula Ferreira', N'Ampla', 94.78, 0, 94.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (600, N'10040911', N' Ana CarolinaMiranda Abecassis', N'Ampla', 94.78, 0, 94.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (601, N'10018503', N' Higor Douglas Souza Costa', N'Ampla', 94.78, 0, 94.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (602, N'10068688', N' Diogo SilvaNaves', N'Ampla', 94.77, 0, 94.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (603, N'10005121', N' Islla Pessoa Fernandes Torres', N'Ampla', 94.76, 0, 94.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (604, N'10062586', N' Arthur NunesCorreia', N'Ampla', 94.75, 0, 94.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (605, N'10044187', N' Alan Pedro Mendes Coelho', N'Ampla', 94.75, 0, 94.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (606, N'10029790', N' Filipe Augusto deSouza Viana', N'Ampla', 94.75, 0, 94.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (607, N'10091313', N' Sergio Luis Berto', N'Ampla', 94.75, 0, 94.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (608, N'10012955', N' Leonardo Pedro SantosLiborio', N'Ampla', 94.74, 0, 94.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (609, N'10000429', N' Danniel Dias Rocha', N'Ampla', 94.74, 0, 94.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (610, N'10005523', N' Alline Gomes Pereira', N'Ampla', 94.74, 0, 94.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (611, N'10050828', N' Glaucimarlus Souza Ramos', N'Ampla', 94.72, 0, 94.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (612, N'10077467', N' Ana Paula Bombarda', N'Ampla', 94.71, 0, 94.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (613, N'10001574', N' Rodrigo Wallace Oliveira Santos', N'Ampla', 94.69, 0, 94.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (614, N'10000038', N' Ana Clara Nunes Mendes', N'Ampla', 94.68, 0, 94.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (615, N'10020609', N' Lidia Silva Saldanha', N'Ampla', 94.64, 0, 94.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (616, N'10061014', N' Fernanda Borges Barros', N'Ampla', 94.62, 0, 94.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (617, N'10054359', N'Manuela Mota', N'Ampla', 94.62, 0, 94.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (618, N'10091917', N' Ygor Pontes Oliveira de Souza', N'Ampla', 94.61, 0, 94.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (619, N'10064716', N' ChristianBorges de Oliveira', N'Ampla', 94.6, 0, 94.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (620, N'10034507', N' Guilherme Macedo das Neves', N'Ampla', 94.59, 0, 94.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (621, N'10059682', N' GustavoLemos Quaranta', N'Ampla', 94.59, 0, 94.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (622, N'10029881', N' Rebeca Bueno Bucci Py', N'Ampla', 94.58, 0, 94.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (623, N'10020031', N' AnandaFernandes Constantino', N'Ampla', 94.57, 0, 94.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (624, N'10060163', N' Daniel Barrozo Lima', N'Ampla', 94.54, 0, 94.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (625, N'10050894', N' IsabelaGuimaraes Prado', N'Ampla', 94.54, 0, 94.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (626, N'10019492', N' Jessika Alves dos Santos', N'Ampla', 94.53, 0, 94.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (627, N'10071811', N' Luan RibeiroCosta', N'Ampla', 94.51, 0, 94.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (628, N'10099045', N' Carla Nazareth Mendes Melo Barros', N'Ampla', 94.5, 0, 94.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (629, N'10049781', N' Joao PedroPires Sampaio', N'Ampla', 94.49, 0, 94.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (630, N'10016287', N' Rafaelly Hatherly Rodrigues', N'Ampla', 94.44, 0, 94.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (631, N'10005279', N' Gabriel Lemosde Oliveira', N'Ampla', 94.43, 0, 94.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (632, N'10029886', N' Luisa Morais Costa Teixeira', N'Ampla', 94.42, 0, 94.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (633, N'10068199', N' Debora AlvesSousa', N'Ampla', 94.41, 0, 94.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (634, N'10068392', N' Wender Henrique de Sousa Silva Starling', N'Ampla', 94.4, 0, 94.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (635, N'10005223', N' RaphaelPereira de Medeiros', N'Ampla', 94.37, 0, 94.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (636, N'10011447', N' Maybi Alfredo Fernandes', N'Ampla', 94.36, 0, 94.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (637, N'10012610', N' Andre deCarvalho Pereira', N'Ampla', 94.34, 0, 94.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (638, N'10000514', N' Iris Esteves Martins Pinto', N'Ampla', 94.34, 0, 94.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (639, N'10079476', N' Lucas HenrikLira da Silva', N'Ampla', 94.32, 0, 94.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (640, N'10086809', N' Ana Paula Martins de Aguiar', N'Ampla', 94.32, 0, 94.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (641, N'10010582', N' AlexandreMaciel Silveira', N'Ampla', 94.3, 0, 94.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (642, N'10016274', N' Yara Verlaine Cordeiro Matias', N'Ampla', 94.3, 0, 94.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (643, N'10000919', N' NicolasMiguel Oliveira de Lima', N'Ampla', 94.3, 0, 94.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (644, N'10065594', N' Aime Feitosa da Costa', N'Ampla', 94.27, 0, 94.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (645, N'10010446', N' GlaucoAlves e Santos Junior', N'Ampla', 94.27, 0, 94.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (646, N'10065184', N' Ingrid Moreira Felinto de Oliveira', N'Ampla', 94.21, 0, 94.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (647, N'10055695', N'Thiago Carvalho Santos de Souza', N'Ampla', 94.19, 0, 94.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (648, N'10031045', N' Danielle Tuanny Alves Ferreira', N'Ampla', 94.19, 0, 94.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (649, N'10066839', N' Susan Maky Karakida', N'Ampla', 94.19, 0, 94.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (650, N'10087825', N' Larissa Alves da Silva', N'Ampla', 94.18, 0, 94.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (651, N'10008416', N'Alisson Carlos Martins Felipe', N'Ampla', 94.18, 0, 94.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (652, N'10077571', N' Henrique Miquelissa Dalcomuni', N'Ampla', 94.18, 0, 94.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (653, N'10022544', N' Iago de Oliveira Martins', N'Ampla', 94.17, 0, 94.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (654, N'10098652', N' Igor Bosco Soares', N'Ampla', 94.17, 0, 94.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (655, N'10061065', N'Davi de Souza Moreira', N'Ampla', 94.16, 0, 94.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (656, N'10066884', N' Alexandre Khoury Porto', N'Ampla', 94.14, 0, 94.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (657, N'10036846', N' Natan Rocha Ferreira', N'Ampla', 94.13, 0, 94.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (658, N'10044879', N' Isaac Lucas Sousa Alves Lima', N'Ampla', 94.13, 0, 94.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (659, N'10003176', N' ViniciusArcanjo Costa', N'Ampla', 94.11, 0, 94.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (660, N'10078105', N' Fillipe Alexandrino Barbosa Figueiredo', N'Ampla', 94.09, 0, 94.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (661, N'10004917', N'Lauren de Miranda Celestino', N'Ampla', 94.09, 0, 94.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (662, N'10033064', N' Danielle Prado de Araujo', N'Ampla', 94.07, 0, 94.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (663, N'10049484', N'Mariana Alves Bontempo', N'Ampla', 94.07, 0, 94.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (664, N'10091099', N' Rhagi Anderson Lira Alvarenga', N'Ampla', 94.06, 0, 94.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (665, N'10007585', N'Raphael Costa Marques dos Santos', N'Ampla', 94.02, 0, 94.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (666, N'10070220', N' Milena Gomes Bezerra', N'Ampla', 94, 0, 94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (667, N'10020659', N' Naissa de Sousa Araujo Alves', N'Ampla', 93.99, 0, 93.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (668, N'10054416', N' Thaynara Nunes Cardoso', N'Ampla', 93.95, 0, 93.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (669, N'10027442', N' Priscilla Mendes da Silva', N'Ampla', 93.92, 0, 93.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (670, N'10059163', N' Isabella Ribeiro Araujo', N'Ampla', 93.92, 0, 93.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (671, N'10068081', N' Jalles Moreira Rocha dos Santos', N'Ampla', 93.88, 0, 93.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (672, N'10006868', N' Mayara Leal Fernandes', N'Ampla', 93.88, 0, 93.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (673, N'10005309', N' Laura Maria Damascena Prado', N'Ampla', 93.83, 0, 93.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (674, N'10016005', N' Sahydi Tedesco Abrahao', N'Ampla', 93.82, 0, 93.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (675, N'10042800', N' Lionaria Karine de Morais', N'Ampla', 93.81, 0, 93.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (676, N'10055957', N' Danyllo Cardoso Costa', N'Ampla', 93.79, 0, 93.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (677, N'10044926', N' Jorge Luis Saturnino da Silva', N'Ampla', 93.79, 0, 93.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (678, N'10012569', N' Emilcy Felipe Cumpertino de Paula', N'Ampla', 93.78, 0, 93.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (679, N'10076691', N' Lucas Liberal', N'Ampla', 93.76, 0, 93.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (680, N'10020468', N' Guilherme de Oliveira Santana', N'Ampla', 93.73, 0, 93.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (681, N'10012032', N' Bruna Dutra Donzelli', N'Ampla', 93.73, 0, 93.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (682, N'10013313', N' Daniela de Paula', N'Ampla', 93.73, 0, 93.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (683, N'10026010', N' DaniellePereira Gonzalez da Silva', N'Ampla', 93.73, 0, 93.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (684, N'10041456', N' Cristian de Sousa Ramos', N'Ampla', 93.72, 0, 93.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (685, N'10012713', N'Leonardo de Moura', N'Ampla', 93.72, 0, 93.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (686, N'10050556', N' Paloma Asenjo de Macedo', N'Ampla', 93.7, 0, 93.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (687, N'10005978', N' EduardoLeal Trindade', N'Ampla', 93.7, 0, 93.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (688, N'10005395', N' Mariana dos Santos Silva', N'Ampla', 93.7, 0, 93.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (689, N'10033616', N' Isabela BastosSerwy', N'Ampla', 93.68, 0, 93.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (690, N'10017242', N' Leonardo Zarattini Martins', N'Ampla', 93.65, 0, 93.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (691, N'10062144', N' Jaquelline Barros deOliveira', N'Ampla', 93.65, 0, 93.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (692, N'10028804', N' Amanda Cristina Lopes dos Santos', N'Ampla', 93.64, 0, 93.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (693, N'10059429', N' MarceloBarbosa Tavares', N'Ampla', 93.64, 0, 93.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (694, N'10008236', N' Daniel de Macedo Souto', N'Ampla', 93.63, 0, 93.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (695, N'10006746', N' Giordano BrunoMaciel de Oliveira', N'Ampla', 93.62, 0, 93.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (696, N'10009418', N' Leticia de Aguiar Avelino da Silva', N'Ampla', 93.61, 0, 93.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (697, N'10020774', N'Tauane de Paula Guimaraes', N'Ampla', 93.61, 0, 93.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (698, N'10074226', N' Cleverson Aparecido Garcia Lara', N'Ampla', 93.6, 0, 93.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (699, N'10062409', N' Daniel Caetano de Oliveira', N'Ampla', 93.6, 0, 93.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (700, N'10006816', N' Wesley dos Santos', N'Ampla', 93.54, 0, 93.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (701, N'10078027', N'Geovani Urder de Andrade Aquino', N'Ampla', 93.54, 0, 93.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (702, N'10008013', N' Gustavo Marques de Azevedo', N'Ampla', 93.54, 0, 93.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (703, N'10030677', N' Lenin Andrade de Souza Cerqueira', N'Ampla', 93.54, 0, 93.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (704, N'10088140', N' Josefa Helena de Aguiar', N'Ampla', 93.53, 0, 93.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (705, N'10014275', N' Juliana Pereira Moreira', N'Ampla', 93.53, 0, 93.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (706, N'10007509', N' Arielle Lima Celestino', N'Ampla', 93.51, 0, 93.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (707, N'10034210', N'Gustavo Coelho Pavani Marinho', N'Ampla', 93.5, 0, 93.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (708, N'10052229', N' Hugo Alves Feletti', N'Ampla', 93.5, 0, 93.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (709, N'10013138', N'Juliano Pereira dos Santos Abrahao', N'Ampla', 93.49, 0, 93.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (710, N'10008941', N' Paulo Vitor Ferreira Correa', N'Ampla', 93.48, 0, 93.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (711, N'10046475', N' Jeferson Neves da Silva', N'Ampla', 93.47, 0, 93.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (712, N'10040940', N' Virginia de Aguiar Rocha', N'Ampla', 93.46, 0, 93.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (713, N'10077118', N' Fernanda Pimentel Hermida Bernardes', N'Ampla', 93.46, 0, 93.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (714, N'10047785', N' Guilherme Henrique PereiraRamos', N'Ampla', 93.45, 0, 93.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (715, N'10046573', N' Fernanda Vianna Couto', N'Ampla', 93.43, 0, 93.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (716, N'10008546', N' Andre Holanda CavalcanteCastellanos Hornos', N'Ampla', 93.43, 0, 93.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (717, N'10050396', N' Dyego Barros Luz', N'Ampla', 93.42, 0, 93.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (718, N'10042008', N' Marcus ViniciusAlmeida Duarte', N'Ampla', 93.42, 0, 93.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (719, N'10067945', N' Rafael da Silva Guerreiro', N'Ampla', 93.42, 0, 93.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (720, N'10041521', N' Joao VictorCarneiro Alves', N'Ampla', 93.41, 0, 93.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (721, N'10013071', N' Camila de Figueiredo Barbosa Bastos', N'Ampla', 93.41, 0, 93.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (722, N'10065420', N'Natalia Rocha Pimentel', N'Ampla', 93.39, 0, 93.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (723, N'10081774', N' Samuel de Souza Almeida', N'Ampla', 93.38, 0, 93.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (724, N'10013825', N' JoaoFelipe Nunes de Miranda', N'Ampla', 93.38, 0, 93.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (725, N'10009300', N' Valeria Ribeiro da Silva Rocha', N'Ampla', 93.37, 0, 93.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (726, N'10027864', N'Sergio Luiz Rosa Junior', N'Ampla', 93.37, 0, 93.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (727, N'10009823', N' Karen Alves Pereira', N'Ampla', 93.36, 0, 93.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (728, N'10073282', N' DouglasAntunis dos Santos', N'Ampla', 93.33, 0, 93.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (729, N'10072187', N' Adriano Tavares Araujo', N'Ampla', 93.3, 0, 93.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (730, N'10006435', N' FernandaLima Gomes de Matos', N'Ampla', 93.29, 0, 93.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (731, N'10040002', N' Matheus Lourenco Ghesso', N'Ampla', 93.28, 0, 93.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (732, N'10043806', N' RodrigoWilliam Silva de Oliveira', N'Ampla', 93.24, 0, 93.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (733, N'10007831', N' Henrique Luis Costa Gonzaga', N'Ampla', 93.23, 0, 93.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (734, N'10077908', N'Fernanda Maia Bravo Pinheiro', N'Ampla', 93.22, 0, 93.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (735, N'10020765', N' Renata Augusto Vieira', N'Ampla', 93.22, 0, 93.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (736, N'10015035', N'Leandro Martins de Sousa Franca', N'Ampla', 93.2, 0, 93.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (737, N'10007273', N' Gibran Daoud', N'Ampla', 93.2, 0, 93.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (738, N'10082863', N' Arthurde Lima Henriques da Silva', N'Ampla', 93.2, 0, 93.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (739, N'10047765', N' Yuri Davinci Nobre', N'Ampla', 93.16, 0, 93.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (740, N'10069921', N' TomazSilva Gonzales', N'Ampla', 93.15, 0, 93.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (741, N'10018196', N' Luana Silva Oliveira', N'Ampla', 93.15, 0, 93.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (742, N'10039231', N' Guilherme Ribeiro deAraujo', N'Ampla', 93.13, 0, 93.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (743, N'10046005', N' Lucas Moreira Rabelo', N'Ampla', 93.13, 0, 93.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (744, N'10084191', N' Pedro de Queiroz Soares', N'Ampla', 93.11, 0, 93.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (745, N'10000947', N' Hugo Daniel Carvalho Pereira', N'Ampla', 93.11, 0, 93.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (746, N'10063291', N' Filipi Teles da Silva', N'Ampla', 93.1, 0, 93.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (747, N'10008556', N' Bruna Barbosa Borges', N'Ampla', 93.1, 0, 93.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (748, N'10049511', N' Hyan Fellipe Maximo da Silva', N'Ampla', 93.09, 0, 93.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (749, N'10018218', N' Lucas Neves Cardoso', N'Ampla', 93.07, 0, 93.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (750, N'10031024', N' Semi Yussef Bjaije Junior', N'Ampla', 93.06, 0, 93.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (751, N'10000544', N' Rafael Campos Marques da Costa', N'Ampla', 93.06, 0, 93.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (752, N'10021363', N' Paloma Pedroza de Sa Formiga', N'Ampla', 93.05, 0, 93.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (753, N'10016055', N' Fernanda Delgado de Vasconcelos', N'Ampla', 93.04, 0, 93.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (754, N'10064748', N' Maisa Sanches Fernandes de Carvalho', N'Ampla', 93.03, 0, 93.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (755, N'10070198', N' Lucas Gabriel de Sousa Lara', N'Ampla', 93.03, 0, 93.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (756, N'10082889', N' HugoHenrique Carvalho Teles', N'Ampla', 93.03, 0, 93.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (757, N'10099787', N' Mateus dos Santos Lopes Gomes', N'Ampla', 93.02, 0, 93.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (758, N'10011444', N'Arthur Uranio Mota Coutinho', N'Ampla', 93.02, 0, 93.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (759, N'10052242', N' Danylo Vieira Vasconcelos Oliveira', N'Ampla', 93.01, 0, 93.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (760, N'10044580', N' Isabela Provensani Valentim', N'Ampla', 92.99, 0, 92.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (761, N'10026603', N' Marina Neves de Loiola', N'Ampla', 92.98, 0, 92.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (762, N'10000214', N' Thais Yukiko Queiroz Fukuda', N'Ampla', 92.98, 0, 92.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (763, N'10056914', N' Renan de Sousa Oliveira', N'Ampla', 92.97, 0, 92.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (764, N'10020039', N' Raul Serido Lima', N'Ampla', 92.95, 0, 92.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (765, N'10018583', N' Diego Ribeiro de Souza', N'Ampla', 92.93, 0, 92.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (766, N'10005804', N' AnaKaroline Ferreira', N'Ampla', 92.93, 0, 92.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (767, N'10009156', N' Stephan Rodrigues Harabedian', N'Ampla', 92.92, 0, 92.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (768, N'10000436', N'Geislanio de Freitas Amancio', N'Ampla', 92.92, 0, 92.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (769, N'10011859', N' Matusalem Pacheco Lustosa Neto', N'Ampla', 92.92, 0, 92.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (770, N'10031351', N' Richard Soares Lustosa', N'Ampla', 92.92, 0, 92.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (771, N'10017647', N' Vinicius Fantin Zanatta', N'Ampla', 92.9, 0, 92.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (772, N'10020862', N' Andre Bilro Pereira de Araujo', N'Ampla', 92.89, 0, 92.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (773, N'10009193', N' Pamela Cristina Martins da Silva', N'Ampla', 92.87, 0, 92.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (774, N'10003394', N' Natanael Silva Camargo', N'Ampla', 92.87, 0, 92.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (775, N'10085240', N' Laryssa Evelyn Guilardi Araujo', N'Ampla', 92.87, 0, 92.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (776, N'10039584', N' Diego Miranda Esteves', N'Ampla', 92.87, 0, 92.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (777, N'10043275', N' Rafael Maciel Nascimento', N'Ampla', 92.84, 0, 92.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (778, N'10054143', N' Wanderlan Fernandes Guedes Filho', N'Ampla', 92.83, 0, 92.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (779, N'10040844', N' Gustavo Latuf Ayres', N'Ampla', 92.8, 0, 92.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (780, N'10056148', N' Caio Santana Rodrigues de Lima', N'Ampla', 92.79, 0, 92.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (781, N'10063302', N' Paulo Augusto Morais de Oliveira', N'Ampla', 92.78, 0, 92.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (782, N'10007695', N' Mateus Ferreira Leandro de Oliveira', N'Ampla', 92.78, 0, 92.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (783, N'10037365', N' Eduardo SchuabbDuarte', N'Ampla', 92.77, 0, 92.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (784, N'10086362', N' Jose Ademir dos Santos Filho', N'Ampla', 92.77, 0, 92.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (785, N'10039686', N' Marcela da Silva deCarvalho', N'Ampla', 92.77, 0, 92.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (786, N'10065829', N' Pedro de Gusmao dos Reis', N'Ampla', 92.76, 0, 92.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (787, N'10064698', N' Tulio Andre Pereirade Oliveira', N'Ampla', 92.74, 0, 92.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (788, N'10009934', N' Thaiany da Silva Araujo', N'Ampla', 92.72, 0, 92.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (789, N'10069819', N' Carina Cardoso CarrijoLintomen Azevedo', N'Ampla', 92.71, 0, 92.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (790, N'10030376', N' Leandro Xavier Rapini', N'Ampla', 92.71, 0, 92.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (791, N'10012939', N' GabrielaTavares de Oliveira Ferreira', N'Ampla', 92.7, 0, 92.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (792, N'10086801', N' Daniel Duim', N'Ampla', 92.69, 0, 92.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (793, N'10029165', N' Natalia Sartori', N'Ampla', 92.66, 0, 92.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (794, N'10008727', N' Guilherme Cardoso de Lima', N'Ampla', 92.65, 0, 92.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (795, N'10029447', N' Carlos Henrique de LucenaSampaio Junior', N'Ampla', 92.64, 0, 92.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (796, N'10012221', N' Artur Albuquerque de Queiroga', N'Ampla', 92.62, 0, 92.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (797, N'10031939', N' FrancioliTonin', N'Ampla', 92.6, 0, 92.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (798, N'10082094', N' Larissa Laiz Monteiro de Farias', N'Ampla', 92.6, 0, 92.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (799, N'10054044', N' Luan ViniciosChagas', N'Ampla', 92.59, 0, 92.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (800, N'10029414', N' Kledson Willy dos Santos Ferreira', N'Ampla', 92.55, 0, 92.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (801, N'10017325', N' Erika MeloNogueira', N'Ampla', 92.53, 0, 92.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (802, N'10009971', N' Diego Goncalves Ribeiro', N'Ampla', 92.53, 0, 92.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (803, N'10098824', N' Joao Lucas MagaliniZago', N'Ampla', 92.49, 0, 92.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (804, N'10025038', N' Joao Victor Santiago Queiroz', N'Ampla', 92.47, 0, 92.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (805, N'10088881', N' Bruno Batista Suehara', N'Ampla', 92.47, 0, 92.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (806, N'10074815', N' Jhemerson Soares Lisboa', N'Ampla', 92.47, 0, 92.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (807, N'10066392', N' Elineide Maheli de OliveiraCarvalho Zigunow', N'Ampla', 92.42, 0, 92.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (808, N'10057129', N' Antonio Gabriel Bini Augusto', N'Ampla', 92.42, 0, 92.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (809, N'10038132', N' Genissondos Reis Santos', N'Ampla', 92.41, 0, 92.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (810, N'10060246', N' Joao Paulo de Sousa', N'Ampla', 92.41, 0, 92.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (811, N'10041872', N' Andressa Trindadede Lima', N'Ampla', 92.38, 0, 92.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (812, N'10053500', N' Andre Augusto Braz Mota', N'Ampla', 92.37, 0, 92.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (813, N'10007387', N' Breno Macedo Aquery', N'Ampla', 92.36, 0, 92.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (814, N'10031960', N' Thiago de Souza Francisco', N'Ampla', 92.35, 0, 92.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (815, N'10014085', N' Amanda Valerio Olsen', N'Ampla', 92.34, 0, 92.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (816, N'10059002', N' Leandro Simoes Dias', N'Ampla', 92.34, 0, 92.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (817, N'10012173', N' Tais Bottecchia', N'Ampla', 92.33, 0, 92.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (818, N'10007878', N'Ajalmar Andrade Moura Segundo', N'Ampla', 92.33, 0, 92.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (819, N'10001949', N' Maiara Teodoro', N'Ampla', 92.32, 0, 92.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (820, N'10098138', N'Nathalia Micaelle Nunes de Oliveira', N'Ampla', 92.31, 0, 92.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (821, N'10039123', N' Michell Victor Matos Mourao', N'Ampla', 92.3, 0, 92.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (822, N'10011949', N' Igo Ferreira de Oliveira', N'Ampla', 92.29, 0, 92.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (823, N'10013872', N' Ismael Rodrigues dos Santos', N'Ampla', 92.29, 0, 92.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (824, N'10082307', N' Alan Guedes Siqueira', N'Ampla', 92.27, 0, 92.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (825, N'10030669', N' Raphael Nepomuceno de Menezes', N'Ampla', 92.27, 0, 92.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (826, N'10069470', N' Lucas Magalhaes Prates de Lima', N'Ampla', 92.27, 0, 92.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (827, N'10036197', N' Mariana Pereira Batista', N'Ampla', 92.26, 0, 92.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (828, N'10001641', N' Melisa Adriana Silva Pimenta', N'Ampla', 92.22, 0, 92.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (829, N'10097154', N' Carla Geovana Chagas Pereira', N'Ampla', 92.22, 0, 92.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (830, N'10063966', N' Thales Luiz Melo Silva', N'Ampla', 92.21, 0, 92.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (831, N'10091029', N' Luciana Caetano Yamanaka', N'Ampla', 92.2, 0, 92.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (832, N'10020201', N' Pedro Alves Ferreira', N'Ampla', 92.19, 0, 92.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (833, N'10016035', N' Rafael Possatto da Silva', N'Ampla', 92.17, 0, 92.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (834, N'10022555', N'Julio Cesar Batista Leitao', N'Ampla', 92.17, 0, 92.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (835, N'10003927', N' Kleber Amano Cipriano', N'Ampla', 92.14, 0, 92.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (836, N'10015457', N' ThaisRibeiro Santiago', N'Ampla', 92.12, 0, 92.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (837, N'10052088', N' Diego Rafael Sena Gomes', N'Ampla', 92.05, 0, 92.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (838, N'10045061', N' ElisonRodrigues Carvalho dos Santos', N'Ampla', 92.04, 0, 92.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (839, N'10017398', N' Dayvisson de Paula Climaco', N'Ampla', 92.03, 0, 92.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (840, N'10070741', N' Renan Emerson Oliveira Cavalcante', N'Ampla', 92.01, 0, 92.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (841, N'10052940', N' Isabella Porfirio Rosa', N'Ampla', 92, 0, 92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (842, N'10047536', N' Thiago Melo Soares', N'Ampla', 91.99, 0, 91.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (843, N'10004957', N' Raianny Moreira Soares', N'Ampla', 91.98, 0, 91.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (844, N'10003525', N'Felipe Torres Martins de Serpa', N'Ampla', 91.95, 0, 91.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (845, N'10065570', N' Leandro Miranda Costa', N'Ampla', 91.95, 0, 91.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (846, N'10050489', N'Lucas Rodrigues Rego', N'Ampla', 91.94, 0, 91.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (847, N'10059650', N' Arthur Tamayo de Lima', N'Ampla', 91.92, 0, 91.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (848, N'10055353', N' Ricardo daSilva Pereira Junior', N'Ampla', 91.91, 0, 91.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (849, N'10062590', N' Jose Carlos Soares de Souza', N'Ampla', 91.9, 0, 91.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (850, N'10065059', N' Jaine deSousa Maciel', N'Ampla', 91.88, 0, 91.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (851, N'10018823', N' Allisson Cardoso Ferreira', N'Ampla', 91.88, 0, 91.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (852, N'10006574', N' Sandro Carvalho Kusano', N'Ampla', 91.88, 0, 91.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (853, N'10019587', N' Otavio Henrique Oliveira Ferreira', N'Ampla', 91.86, 0, 91.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (854, N'10002384', N' Raul FurieriPignaton Camargo de Azevedo', N'Ampla', 91.85, 0, 91.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (855, N'10004041', N' Marlon Danilo da Silva', N'Ampla', 91.84, 0, 91.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (856, N'10023217', N'Daniel Dias Ribeiro', N'Ampla', 91.84, 0, 91.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (857, N'10047326', N' Ismael Verissimo dos Santos Junior', N'Ampla', 91.84, 0, 91.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (858, N'10002262', N'Amana dos Santos Nesimi', N'Ampla', 91.83, 0, 91.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (859, N'10061459', N' Ilane Vieira Nunes', N'Ampla', 91.83, 0, 91.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (860, N'10055608', N' Joao VictorCarvalho Freire Bezerra', N'Ampla', 91.82, 0, 91.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (861, N'10090385', N' Julley Oliveira Alencar', N'Ampla', 91.8, 0, 91.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (862, N'10030596', N' ElanioCavalcante Fontenele', N'Ampla', 91.77, 0, 91.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (863, N'10001681', N' Marcelo dos Reis Brandao Rosa', N'Ampla', 91.76, 0, 91.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (864, N'10010832', N'Kassius Anchesqui Nardoto', N'Ampla', 91.75, 0, 91.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (865, N'10025593', N' Daniel Ghetti do Prado', N'Ampla', 91.74, 0, 91.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (866, N'10025957', N'Carolina Athayde Azambuja', N'Ampla', 91.73, 0, 91.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (867, N'10012306', N' Fabio de Godoy Penteado', N'Ampla', 91.73, 0, 91.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (868, N'10055438', N'Saulo Renan de Sousa e Silva', N'Ampla', 91.71, 0, 91.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (869, N'10036306', N' Matheus Dantas Machado', N'Ampla', 91.71, 0, 91.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (870, N'10031443', N'Elizabeth Cristina Tenreiro Cavalcante', N'Ampla', 91.7, 0, 91.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (871, N'10037100', N' Gabrielle Gomes da Silva', N'Ampla', 91.67, 0, 91.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (872, N'10005731', N' Lais Barreto de Araujo', N'Ampla', 91.67, 0, 91.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (873, N'10048768', N' Rodrigo Gregorio Botelho', N'Ampla', 91.66, 0, 91.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (874, N'10020521', N' Rafael Sampaio Braga', N'Ampla', 91.65, 0, 91.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (875, N'10004709', N' Jessica Oliveira Neiva', N'Ampla', 91.65, 0, 91.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (876, N'10018084', N'Cindy de Souza Tavares', N'Ampla', 91.65, 0, 91.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (877, N'10004508', N' Leonardo Meneses Cabral', N'Ampla', 91.64, 0, 91.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (878, N'10007233', N' Brendo Augusto dos Santos Tertuliano', N'Ampla', 91.64, 0, 91.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (879, N'10073276', N' Alex Rosa de Jesus', N'Ampla', 91.63, 0, 91.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (880, N'10108417', N' Rodrigo Pereira Santos', N'Ampla', 91.63, 0, 91.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (881, N'10067040', N' Bruno Bergamaschi Mazega', N'Ampla', 91.61, 0, 91.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (882, N'10014688', N' Daniel Viny Dourado Costa', N'Ampla', 91.61, 0, 91.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (883, N'10007397', N' Luiz Tadeu Miranda da Silva', N'Ampla', 91.6, 0, 91.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (884, N'10094893', N' Eunice Vitoriode Oliveira', N'Ampla', 91.6, 0, 91.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (885, N'10094212', N' Vinicius Drummond Silva Araujo', N'Ampla', 91.6, 0, 91.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (886, N'10095135', N' Luiz Robertodo Nascimento Junior', N'Ampla', 91.59, 0, 91.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (887, N'10009413', N' Dario Carlos Ribeiro Ramires Junior', N'Ampla', 91.54, 0, 91.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (888, N'10011772', N'Solange Stefany de Faria', N'Ampla', 91.54, 0, 91.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (889, N'10060836', N' Lucas da Costa Lima', N'Ampla', 91.53, 0, 91.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (890, N'10070759', N' Gibran Kahlil Gazel', N'Ampla', 91.52, 0, 91.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (891, N'10048431', N' Jonatan Almeida Custodio', N'Ampla', 91.51, 0, 91.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (892, N'10072784', N' Ana Carolina Maiade Freitas', N'Ampla', 91.51, 0, 91.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (893, N'10032447', N' Joao Luiz Farinon', N'Ampla', 91.5, 0, 91.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (894, N'10003680', N' Julio Cesar Lima Madalena', N'Ampla', 91.5, 0, 91.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (895, N'10057541', N' Mateus Ribeiro Araujo', N'Ampla', 91.5, 0, 91.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (896, N'10021147', N' Gabriel Henrique Silva Araujo', N'Ampla', 91.49, 0, 91.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (897, N'10101716', N' Eduardo de Oliveira Paes', N'Ampla', 91.48, 0, 91.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (898, N'10059697', N' Ronei Ademir Wolff Athayde Junior', N'Ampla', 91.47, 0, 91.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (899, N'10082231', N' Kemylla Passos Mesquita', N'Ampla', 91.47, 0, 91.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (900, N'10000074', N' Tomas Pinheiro DellaGiustina', N'Ampla', 91.46, 0, 91.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (901, N'10058577', N' Juliana Bertoldo Alvares', N'Ampla', 91.45, 0, 91.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (902, N'10091260', N' Marcelo Hipolito Dantasde Souza', N'Ampla', 91.45, 0, 91.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (903, N'10053221', N' Jose Igor Rocha de Moura', N'Ampla', 91.43, 0, 91.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (904, N'10055835', N' Daniel dos Anjos Gomes da Silva', N'Ampla', 91.42, 0, 91.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (905, N'10105811', N' Lucas Manoel Costa', N'Ampla', 91.4, 0, 91.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (906, N'10002030', N' Davi Teixeira e Silva', N'Ampla', 91.38, 0, 91.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (907, N'10059435', N' Gabriel Ismael da Silva', N'Ampla', 91.38, 0, 91.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (908, N'10037712', N' Jaira Decia Conceicao Lima', N'Ampla', 91.37, 0, 91.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (909, N'10017768', N' Manuel de Oliveira Vasconcelos Junior', N'Ampla', 91.36, 0, 91.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (910, N'10037112', N' Isabelle Nolasco de Oliveira', N'Ampla', 91.35, 0, 91.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (911, N'10008273', N' Adenilson Rutsatz', N'Ampla', 91.34, 0, 91.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (912, N'10000270', N' Cristiane Ferras BolicoRodrigues da Silva', N'Ampla', 91.34, 0, 91.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (913, N'10108961', N' Samuel Goncalves dos Santos', N'Ampla', 91.33, 0, 91.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (914, N'10017729', N' BrunoUemura Ribeiro', N'Ampla', 91.33, 0, 91.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (915, N'10059212', N' Leonardo Leandro Furquim', N'Ampla', 91.32, 0, 91.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (916, N'10001028', N' Maria LuizaPorfiro Estevao de Oliveira', N'Ampla', 91.32, 0, 91.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (917, N'10006869', N' Paulo Henrique de Oliveira Sousa', N'Ampla', 91.31, 0, 91.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (918, N'10030787', N' Isabela Marques Santos', N'Ampla', 91.29, 0, 91.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (919, N'10022391', N' Samuel da Silva Rodrigues', N'Ampla', 91.28, 0, 91.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (920, N'10012630', N' Marcelo Rezende do Nascimento', N'Ampla', 91.28, 0, 91.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (921, N'10097045', N' Leonardo de Oliveira Ramos', N'Ampla', 91.26, 0, 91.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (922, N'10015593', N' Leonardo Soares Albuquerque', N'Ampla', 91.25, 0, 91.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (923, N'10014692', N' Yago de Mello Santos', N'Ampla', 91.25, 0, 91.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (924, N'10076115', N' Rafael Ferreira Dutra', N'Ampla', 91.22, 0, 91.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (925, N'10037673', N' Marcos Paulo Martins Luciano', N'Ampla', 91.21, 0, 91.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (926, N'10007414', N' Luiz Antonio Euzebio de Freitas Filho', N'Ampla', 91.2, 0, 91.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (927, N'10039365', N' Rodrigo Gabriel Costa Fortuna', N'Ampla', 91.2, 0, 91.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (928, N'10055844', N' Larissa Cardoso Lacerda', N'Ampla', 91.17, 0, 91.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (929, N'10054823', N' Vivian Moreira de Moura Maia', N'Ampla', 91.16, 0, 91.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (930, N'10043070', N' Carlos Fernando Rodrigues Santos Barbosa', N'Ampla', 91.14, 0, 91.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (931, N'10086689', N' Gabriel NasserSaad Filho', N'Ampla', 91.13, 0, 91.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (932, N'10070261', N' Rafael Henrique Soares Nogueira Rocha', N'Ampla', 91.13, 0, 91.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (933, N'10060277', N'Rodrigo Goncalves Recalde', N'Ampla', 91.12, 0, 91.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (934, N'10044914', N' Luis Felipe Torres Caetano', N'Ampla', 91.11, 0, 91.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (935, N'10003335', N'Geanderson Ramos de Alencar', N'Ampla', 91.11, 0, 91.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (936, N'10027489', N' Flavio Toscano Alves', N'Ampla', 91.1, 0, 91.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (937, N'10005678', N' Lucas Vinicius Silva de Jesus', N'Ampla', 91.09, 0, 91.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (938, N'10006031', N' Amanda Juliana Rocha Araujo', N'Ampla', 91.09, 0, 91.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (939, N'10031054', N'Rodrigo Chogri Galli', N'Ampla', 91.07, 0, 91.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (940, N'10060776', N' Raquel Veras Valenca', N'Ampla', 91.06, 0, 91.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (941, N'10097750', N' Gabriela Teixeira Pazzine', N'Ampla', 91.05, 0, 91.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (942, N'10029743', N' Charlles Henrique Rodrigues Pereira', N'Ampla', 91.04, 0, 91.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (943, N'10058996', N' AlanVerlaine Dias Silva', N'Ampla', 91.03, 0, 91.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (944, N'10071326', N' Larissa Borges Fogaca', N'Ampla', 91.03, 0, 91.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (945, N'10012115', N' GuilhermeBicalho Monteiro de Castro', N'Ampla', 91.03, 0, 91.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (946, N'10005748', N' Diego Moreira Carmino', N'Ampla', 91.01, 0, 91.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (947, N'10053367', N' Tayna Passos Nunes Leal', N'Ampla', 91.01, 0, 91.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (948, N'10066207', N' Werner Heisenberg Santos Figueiredo', N'Ampla', 91.01, 0, 91.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (949, N'10084583', N' Pollyana Barros da Silva Pacheco', N'Ampla', 91.01, 0, 91.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (950, N'10003440', N' Eduardo Lucas de Sousa Borges', N'Ampla', 91, 0, 91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (951, N'10029702', N' Hebert da Silva Souza', N'Ampla', 90.98, 0, 90.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (952, N'10051167', N' Tallys Henrique Crico Pimentel', N'Ampla', 90.96, 0, 90.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (953, N'10055332', N' Marcos Tadeu Souza Aquino', N'Ampla', 90.96, 0, 90.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (954, N'10003960', N' Samuel Silva Rocha Lima', N'Ampla', 90.95, 0, 90.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (955, N'10024477', N' Andrea Costa de Lucena', N'Ampla', 90.95, 0, 90.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (956, N'10008480', N' Ellyka de Queiroz Ornelas Araujo', N'Ampla', 90.94, 0, 90.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (957, N'10000040', N' Paulo Roberto Rodrigues da Silva', N'Ampla', 90.93, 0, 90.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (958, N'10013363', N' Matheus Nishiyama Pedroca', N'Ampla', 90.93, 0, 90.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (959, N'10011183', N' Alexandre Meirelles Martins', N'Ampla', 90.92, 0, 90.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (960, N'10061638', N' Caio Campos Ferreira', N'Ampla', 90.91, 0, 90.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (961, N'10019543', N' Monike Pontes Silva', N'Ampla', 90.9, 0, 90.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (962, N'10010241', N' Robson Albertassi', N'Ampla', 90.88, 0, 90.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (963, N'10025984', N'Anderson Garofalo Pinto', N'Ampla', 90.87, 0, 90.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (964, N'10007367', N' Karla Pereira Alves', N'Ampla', 90.86, 0, 90.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (965, N'10006470', N' MilenaGuimaraes Oliveira', N'Ampla', 90.86, 0, 90.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (966, N'10059086', N' Debora Mayane de Avila Batista', N'Ampla', 90.86, 0, 90.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (967, N'10031257', N'Carlos Fernando Costa Silva', N'Ampla', 90.86, 0, 90.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (968, N'10021047', N' Tainan Lima Bueno', N'Ampla', 90.84, 0, 90.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (969, N'10046944', N' AngeloJose da Silva Filho', N'Ampla', 90.82, 0, 90.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (970, N'10008635', N' Larissa Paes Landim Alves', N'Ampla', 90.82, 0, 90.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (971, N'10035019', N' AllisonAlmeida Declie', N'Ampla', 90.81, 0, 90.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (972, N'10014617', N' Aluan Augusto de Melo Neves', N'Ampla', 90.81, 0, 90.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (973, N'10001420', N' GregorioFernandes Pimenta dos Anjos', N'Ampla', 90.8, 0, 90.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (974, N'10053819', N' Gilberto Andre da Costa Filho', N'Ampla', 90.79, 0, 90.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (975, N'10024893', N' Scarlet Pereira Pena', N'Ampla', 90.77, 0, 90.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (976, N'10015369', N' Camila Viviane Araujo dos Santos', N'Ampla', 90.76, 0, 90.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (977, N'10032780', N' Eduardo Marques de Souza', N'Ampla', 90.75, 0, 90.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (978, N'10026936', N' Diego Machado dos Santos', N'Ampla', 90.74, 0, 90.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (979, N'10028910', N' Carolyne Thaina de Holanda Cavalcante', N'Ampla', 90.72, 0, 90.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (980, N'10073138', N' Renan Hiroshi Kuba', N'Ampla', 90.71, 0, 90.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (981, N'10097142', N' Luciano Reis de Oliveira Silva', N'Ampla', 90.68, 0, 90.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (982, N'10018115', N' Lucas Ribeiro de Miranda', N'Ampla', 90.68, 0, 90.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (983, N'10064343', N' Raphael Santos Dantas', N'Ampla', 90.68, 0, 90.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (984, N'10013026', N' Fernanda Caetano Raffs Strasser', N'Ampla', 90.68, 0, 90.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (985, N'10031616', N' Joucafly Arruda Santos', N'Ampla', 90.65, 0, 90.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (986, N'10063368', N' Diego Batista Morais e Silva', N'Ampla', 90.65, 0, 90.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (987, N'10009814', N' Talita Guieiro Ribeiro Rocha', N'Ampla', 90.63, 0, 90.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (988, N'10014465', N' Matheus Machado Mendes de Figueiredo', N'Ampla', 90.61, 0, 90.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (989, N'10025618', N' Thiago dos Santos Silva', N'Ampla', 90.6, 0, 90.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (990, N'10005369', N' Wanderson PhelipeSoares de Franca', N'Ampla', 90.59, 0, 90.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (991, N'10058769', N' Thayane Erika Cruz Maciel', N'Ampla', 90.53, 0, 90.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (992, N'10044049', N' Rodrigo deLima Rodrigues', N'Ampla', 90.53, 0, 90.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (993, N'10049778', N' Silas Edson Martins', N'Ampla', 90.52, 0, 90.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (994, N'10037693', N' Jessica Camargo deAmorim', N'Ampla', 90.52, 0, 90.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (995, N'10065333', N' Geisiane Peixoto Borges', N'Ampla', 90.51, 0, 90.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (996, N'10015503', N' Isabella Santos da Silva', N'Ampla', 90.51, 0, 90.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (997, N'10022011', N' Jaqueline Alves Alencar', N'Ampla', 90.51, 0, 90.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (998, N'10053254', N' Ana Paula Alvarenga Martins', N'Ampla', 90.51, 0, 90.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (999, N'10077004', N' Gerson Eduardo Garcia Lodi', N'Ampla', 90.5, 0, 90.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1000, N'10070700', N' Marilia Parreira', N'Ampla', 90.49, 0, 90.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1001, N'10079222', N' Cynthia Magalhaes da Costa', N'Ampla', 90.49, 0, 90.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1002, N'10046722', N' Herbert Fraga Sousa de Oliveira', N'Ampla', 90.48, 0, 90.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1003, N'10025771', N' Sarah Paulino da Silva Melo', N'Ampla', 90.47, 0, 90.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1004, N'10083595', N' Mateus Barbosa Souza', N'Ampla', 90.47, 0, 90.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1005, N'10069786', N' William Miyata da Silva', N'Ampla', 90.47, 0, 90.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1006, N'10040528', N' Thaina Caroline Eleto', N'Ampla', 90.46, 0, 90.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1007, N'10071025', N' Isabela Laus Saldanha', N'Ampla', 90.46, 0, 90.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1008, N'10074826', N' Tiago Guarda', N'Ampla', 90.43, 0, 90.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1009, N'10015152', N' Gabrielde Campos Soares Lopes', N'Ampla', 90.42, 0, 90.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1010, N'10044541', N' Carlo Henrique Trajano Gontijo Moraes', N'Ampla', 90.42, 0, 90.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1011, N'10005198', N' Gabryella Melo Silveira', N'Ampla', 90.42, 0, 90.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1012, N'10015698', N' Sharon Anne Nogueira Barros', N'Ampla', 90.41, 0, 90.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1013, N'10024684', N' Lenai Martins Oliveira', N'Ampla', 90.39, 0, 90.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1014, N'10008930', N' Aloisio Jose da Silva Junior', N'Ampla', 90.38, 0, 90.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1015, N'10028855', N' Lorrayne Virote da Silva', N'Ampla', 90.36, 0, 90.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1016, N'10035122', N' Moacir Gomes Duarte Filho', N'Ampla', 90.35, 0, 90.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1017, N'10003124', N' Lisle Marina Araujo do Nascimento', N'Ampla', 90.35, 0, 90.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1018, N'10014097', N' Gabriela Alves Costa', N'Ampla', 90.35, 0, 90.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1019, N'10030564', N' Raissa Gomes Riotinto', N'Ampla', 90.35, 0, 90.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1020, N'10030060', N' Jose Igor Feitosa do Nascimento', N'Ampla', 90.31, 0, 90.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1021, N'10033863', N' Matheus de Oliveira Assis', N'Ampla', 90.31, 0, 90.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1022, N'10004031', N' Daniel Fonseca Pimentel', N'Ampla', 90.28, 0, 90.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1023, N'10020273', N' Renan Andre de Oliveira Soares', N'Ampla', 90.27, 0, 90.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1024, N'10053929', N' Bruno de Sousa Barros', N'Ampla', 90.25, 0, 90.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1025, N'10078993', N' Jessica Gomes de Almeida Maia', N'Ampla', 90.25, 0, 90.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1026, N'10049073', N' Joao Guilherme Martins Soares', N'Ampla', 90.23, 0, 90.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1027, N'10014543', N' Gabriel Nascimento da Silva', N'Ampla', 90.22, 0, 90.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1028, N'10063454', N' Ludmilla de Faria Assis', N'Ampla', 90.2, 0, 90.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1029, N'10002759', N' Luiz Guilherme Campos de Oliveira', N'Ampla', 90.18, 0, 90.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1030, N'10086877', N' GuilhermeFernandes Souza', N'Ampla', 90.15, 0, 90.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1031, N'10025983', N' Andre Luis Areias de Moraes', N'Ampla', 90.13, 0, 90.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1032, N'10034064', N' MarcosHenrique de Lima Souza', N'Ampla', 90.13, 0, 90.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1033, N'10055880', N' Jorge Henrique Neves Alcantara Junior', N'Ampla', 90.13, 0, 90.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1034, N'10004645', N' Ana Clara de Almeida Bossi Guimaraes', N'Ampla', 90.13, 0, 90.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1035, N'10046562', N' Hyara Pereira Cumaru', N'Ampla', 90.1, 0, 90.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1036, N'10042309', N' Monique Temp da Silva', N'Ampla', 90.1, 0, 90.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1037, N'10079484', N' Vinicius Borges Miatelo', N'Ampla', 90.09, 0, 90.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1038, N'10033112', N' Salatiel Pereira de Freitas', N'Ampla', 90.09, 0, 90.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1039, N'10000230', N' Emely Crisley Florentino Lemos', N'Ampla', 90.09, 0, 90.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1040, N'10062483', N' William Araujo Moreira Nunes', N'Ampla', 90.08, 0, 90.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1041, N'10073716', N' Thamyrys dos Santos Araujo', N'Ampla', 90.08, 0, 90.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1042, N'10029562', N' Joao Vitor da Silva Morais', N'Ampla', 90.04, 0, 90.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1043, N'10005253', N' Pedro Henrique de AraujoSouza Junior', N'Ampla', 90.03, 0, 90.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1044, N'10085656', N' Diego Bezerra Barbosa', N'Ampla', 90.02, 0, 90.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1045, N'10070584', N' Maisa Gomes Chaves', N'Ampla', 90.02, 0, 90.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1046, N'10085083', N' Mateus Henriques de Carvalho', N'Ampla', 90.02, 0, 90.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1047, N'10037884', N' Dayane Lucia Pires Ferreira', N'Ampla', 90.01, 0, 90.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1048, N'10012794', N' Rafaela Pereira Tostes', N'Ampla', 90.01, 0, 90.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1049, N'10058830', N' Aline Machado dos Santos', N'Ampla', 89.98, 0, 89.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1050, N'10053403', N' Bruno Barbosa da Silva', N'Ampla', 89.98, 0, 89.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1051, N'10066533', N' Cintia Almeida Barbosa', N'Ampla', 89.96, 0, 89.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1052, N'10003274', N' Mateus Melo Souza', N'Ampla', 89.95, 0, 89.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1053, N'10058322', N' Arthur Machado Gomes Barbosa Souto', N'Ampla', 89.93, 0, 89.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1054, N'10040206', N' Bruno Garcia Santana', N'Ampla', 89.93, 0, 89.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1055, N'10009208', N' Ulysses deOliveira Barbosa', N'Ampla', 89.89, 0, 89.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1056, N'10012700', N' Rafael Fleury Mainardi', N'Ampla', 89.88, 0, 89.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1057, N'10000197', N' Ana JessicaFigueiredo Dutra', N'Ampla', 89.88, 0, 89.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1058, N'10077154', N' Phelipe Sacramento Silva', N'Ampla', 89.88, 0, 89.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1059, N'10023195', N' AndreFelipe da Rocha de Souza', N'Ampla', 89.88, 0, 89.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1060, N'10012441', N' Gabriel Paiva Brito', N'Ampla', 89.87, 0, 89.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1061, N'10050553', N' JoseCarlos Nogueira Ferreira', N'Ampla', 89.85, 0, 89.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1062, N'10083609', N' Felipe Franco do Vale', N'Ampla', 89.84, 0, 89.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1063, N'10052216', N' Thaynara Ferreira de Andrade', N'Ampla', 89.84, 0, 89.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1064, N'10004510', N' Alexandre Nepomuceno da Fonseca Meneses', N'Ampla', 89.83, 0, 89.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1065, N'10053883', N' Dante Akira Uwai', N'Ampla', 89.82, 0, 89.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1066, N'10011935', N' Luiz Henrique Rodrigues Muniz', N'Ampla', 89.81, 0, 89.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1067, N'10096774', N' Adriana Luiza de Oliveira Silva', N'Ampla', 89.8, 0, 89.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1068, N'10007541', N' Luiz Guilherme Araujode Andrade', N'Ampla', 89.79, 0, 89.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1069, N'10001752', N' Vicente Resende Cardoso Filho', N'Ampla', 89.75, 0, 89.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1070, N'10025297', N' BarbaraRodrigues Sampaio', N'Ampla', 89.73, 0, 89.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1071, N'10069582', N' Caio Vinicius Aguiar de Andrade', N'Ampla', 89.73, 0, 89.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1072, N'10037162', N'Guilherme Pinto Ribeiro', N'Ampla', 89.73, 0, 89.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1073, N'10036667', N' Felipe Elias Menezes', N'Ampla', 89.72, 0, 89.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1074, N'10030612', N' BrenoVinicius de Sousa Duarte', N'Ampla', 89.72, 0, 89.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1075, N'10008648', N' Amanda Gomes Moreira', N'Ampla', 89.71, 0, 89.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1076, N'10026533', N' JoaoVitor Afonso Ribeiro de Oliveira', N'Ampla', 89.71, 0, 89.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1077, N'10019726', N' Hudson Henrique Calixto Eller', N'Ampla', 89.71, 0, 89.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1078, N'10068311', N' Jose Carlos Dias de Souza Junior', N'Ampla', 89.66, 0, 89.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1079, N'10078445', N' Felipe Goncalves Muniz', N'Ampla', 89.65, 0, 89.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1080, N'10028171', N' Egon Vinicius Dalinghaus', N'Ampla', 89.62, 0, 89.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1081, N'10061009', N' Fagner Galvao Fernandes', N'Ampla', 89.62, 0, 89.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1082, N'10057153', N' Joao Victor Nogueira Ribeiro Nunes Clemente', N'Ampla', 89.61, 0, 89.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1083, N'10031799', N' Guilherme Farias Prux', N'Ampla', 89.61, 0, 89.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1084, N'10067942', N' Lorrany Gregorio Magalhaes', N'Ampla', 89.6, 0, 89.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1085, N'10100683', N' Bruno Soares SantosAraujo', N'Ampla', 89.57, 0, 89.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1086, N'10016145', N' Thais Ferreira Ramos', N'Ampla', 89.57, 0, 89.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1087, N'10061338', N' Hebert Kley Lageano deOliveira', N'Ampla', 89.57, 0, 89.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1088, N'10042798', N' Flavia Maria Alves Caetano', N'Ampla', 89.56, 0, 89.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1089, N'10010280', N' Mauricio BrayanCruz Alves Martins', N'Ampla', 89.54, 0, 89.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1090, N'10011781', N' Paulo do Couto Naves', N'Ampla', 89.53, 0, 89.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1091, N'10052049', N' ArianaEngelmann Rodrigues Aragao', N'Ampla', 89.51, 0, 89.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1092, N'10103953', N' Jonatas Aryel de Araujo Silva', N'Ampla', 89.51, 0, 89.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1093, N'10038788', N' Guilherme Almeida de Brito Barutti', N'Ampla', 89.51, 0, 89.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1094, N'10077481', N' Handerson Jose dos Santos', N'Ampla', 89.49, 0, 89.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1095, N'10070990', N' Marco Aurelio Silva', N'Ampla', 89.48, 0, 89.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1096, N'10051563', N' Jamile Lobao Teixeira', N'Ampla', 89.48, 0, 89.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1097, N'10047420', N' Jhonatan Testa', N'Ampla', 89.48, 0, 89.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1098, N'10023180', N' Rafael da Silva Lopes', N'Ampla', 89.47, 0, 89.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1099, N'10011506', N' Jonathan Henrique Wanderley dos Santos', N'Ampla', 89.47, 0, 89.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1100, N'10045352', N' Valter Rafael Souza Marques', N'Ampla', 89.46, 0, 89.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1101, N'10058364', N' Ariadna Jesus Lopes da Silva', N'Ampla', 89.45, 0, 89.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1102, N'10000116', N' Yasmin Ramos Espicalsky', N'Ampla', 89.45, 0, 89.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1103, N'10020923', N' Filipe Vasconcelos Costa', N'Ampla', 89.44, 0, 89.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1104, N'10035362', N' Lucas Augusto Abbott Jacob', N'Ampla', 89.44, 0, 89.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1105, N'10017407', N' Rafael da Silva Farias', N'Ampla', 89.43, 0, 89.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1106, N'10070907', N' Lara Sena Scapetti Almeida', N'Ampla', 89.43, 0, 89.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1107, N'10101407', N' Leonardo Krausche', N'Ampla', 89.42, 0, 89.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1108, N'10030914', N' Francisco Eduardo Vieira de Araujo', N'Ampla', 89.41, 0, 89.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1109, N'10092784', N' Marcos da Silveira Leal', N'Ampla', 89.39, 0, 89.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1110, N'10057796', N' Lucas Vieira dos Santos', N'Ampla', 89.37, 0, 89.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1111, N'10038969', N' Patrick Cardoso dos Santos', N'Ampla', 89.37, 0, 89.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1112, N'10020038', N' Natan Carlos da Cunha Costa', N'Ampla', 89.36, 0, 89.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1113, N'10015196', N' Joao Victor dos Santos Rodrigues', N'Ampla', 89.35, 0, 89.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1114, N'10053094', N' Rafael Barbacena e Souza', N'Ampla', 89.35, 0, 89.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1115, N'10002523', N' Luiza Pinheiro Andrade Viana', N'Ampla', 89.33, 0, 89.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1116, N'10021602', N' Joao Batista Sousa MonteiroJunior', N'Ampla', 89.32, 0, 89.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1117, N'10007689', N' Eduardo Basilio de Albuquerque', N'Ampla', 89.29, 0, 89.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1118, N'10077827', N' Thiago BarachoGoncalves', N'Ampla', 89.29, 0, 89.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1119, N'10076448', N' Jorge Thiago Silva Silveira', N'Ampla', 89.27, 0, 89.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1120, N'10005190', N' Joao Paulo PintoVan Der Vliet', N'Ampla', 89.25, 0, 89.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1121, N'10020658', N' Plabyo Geanine Nunes de Oliveira', N'Ampla', 89.23, 0, 89.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1122, N'10021154', N' GisellaTeixeira Guimaraes Moreira', N'Ampla', 89.23, 0, 89.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1123, N'10028673', N' Celso Rafael de Melo Silva', N'Ampla', 89.23, 0, 89.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1124, N'10082497', N'Victor Castro da Costa', N'Ampla', 89.23, 0, 89.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1125, N'10041199', N' Danilo Feitoza Melo', N'Ampla', 89.21, 0, 89.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1126, N'10005857', N' Allan Cezarde Andrade Silva', N'Ampla', 89.21, 0, 89.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1127, N'10043955', N' Dyego Jose Holanda Pessoa', N'Ampla', 89.2, 0, 89.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1128, N'10048239', N' Ives Pliniode Jesus Oliveira', N'Ampla', 89.2, 0, 89.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1129, N'10044808', N' Milena Ribeiro da Rocha', N'Ampla', 89.2, 0, 89.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1130, N'10013602', N' Juliana LopesNavarro', N'Ampla', 89.19, 0, 89.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1131, N'10003590', N' Gustavo Cruz Damico Campello', N'Ampla', 89.18, 0, 89.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1132, N'10011294', N' Rafael LucasSouza', N'Ampla', 89.18, 0, 89.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1133, N'10055138', N' Dalila Vilas Boas Souza Magalhaes da Silva', N'Ampla', 89.17, 0, 89.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1134, N'10003320', N' JuliaBeutel Semenzato Ferrer', N'Ampla', 89.17, 0, 89.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1135, N'10029804', N' Adriane Godinho', N'Ampla', 89.14, 0, 89.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1136, N'10021931', N' Yan GenaroNakamura', N'Ampla', 89.13, 0, 89.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1137, N'10065508', N' Iago Matteo Calleri', N'Ampla', 89.12, 0, 89.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1138, N'10018343', N' Matheus Silva Gomes', N'Ampla', 89.11, 0, 89.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1139, N'10043852', N' Carolina Verlaine Costa Brandao', N'Ampla', 89.1, 0, 89.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1140, N'10019459', N' Thiago Fogtman Steger', N'Ampla', 89.1, 0, 89.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1141, N'10016543', N' Felipe Tobias Costa de Almeida', N'Ampla', 89.08, 0, 89.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1142, N'10045006', N' Filipe HumbertoOliveira Drumond Albuquerque', N'Ampla', 89.08, 0, 89.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1143, N'10046951', N' Pedro Mauricio de Vargas Sanches', N'Ampla', 89.08, 0, 89.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1144, N'10006242', N' Daniel Brant Llorente Barrio', N'Ampla', 89.08, 0, 89.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1145, N'10029680', N' Guilherme Augusto Lana Nonato', N'Ampla', 89.06, 0, 89.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1146, N'10089266', N' Nathalia Martins Pereira dos Santos', N'Ampla', 89.05, 0, 89.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1147, N'10000558', N' Barbara Ranny deOliveira Vieira da Silva', N'Ampla', 89.05, 0, 89.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1148, N'10010959', N' Luisa Viana Luniere de Azevedo', N'Ampla', 89.05, 0, 89.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1149, N'10009092', N'Fernanda Rocha Vieira', N'Ampla', 89.04, 0, 89.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1150, N'10067905', N' Julio Cesar Martins Vaz', N'Ampla', 89.03, 0, 89.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1151, N'10026398', N' Rudade Almeida Silva', N'Ampla', 89.02, 0, 89.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1152, N'10001438', N' Gabriel Ribeiro de Araujo', N'Ampla', 89.02, 0, 89.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1153, N'10003876', N' Alyne deMorais Santiago Gaia', N'Ampla', 89.01, 0, 89.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1154, N'10082557', N' Marcos Andre Siqueira Lima', N'Ampla', 88.99, 0, 88.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1155, N'10007751', N'Filipe de Oliveira Pereira', N'Ampla', 88.99, 0, 88.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1156, N'10010539', N' Karen Rayane Lopes Alves', N'Ampla', 88.98, 0, 88.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1157, N'10102333', N'Leonardo Yuji Kato Rodrigues', N'Ampla', 88.97, 0, 88.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1158, N'10005186', N' Matheus Zuchelli Costa', N'Ampla', 88.94, 0, 88.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1159, N'10076131', N'Paulo Ricardo Peixoto', N'Ampla', 88.93, 0, 88.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1160, N'10067228', N' Caio de Aguiar Pires Moreira', N'Ampla', 88.93, 0, 88.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1161, N'10016941', N'Amanda Dornelas da Silveira', N'Ampla', 88.92, 0, 88.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1162, N'10089602', N' Murilo de Oliveira Marcirio', N'Ampla', 88.92, 0, 88.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1163, N'10003740', N' Rafael Alves de Sousa Oliveira', N'Ampla', 88.92, 0, 88.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1164, N'10007714', N' Joao Henrique Ferreira Mendes', N'Ampla', 88.91, 0, 88.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1165, N'10057557', N' Gustavo Carrilho Castro', N'Ampla', 88.9, 0, 88.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1166, N'10028585', N' Jeferson Amorim Mamed', N'Ampla', 88.89, 0, 88.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1167, N'10072473', N' Rodrigo de Melo Pereira do Nascimento Costa', N'Ampla', 88.89, 0, 88.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1168, N'10007435', N' Daniel Lima das Virgens Ferreira', N'Ampla', 88.85, 0, 88.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1169, N'10014194', N' Janaina de Souza Dourado Gomes', N'Ampla', 88.83, 0, 88.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1170, N'10003962', N'Ygor Yuri Roza Pereira', N'Ampla', 88.82, 0, 88.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1171, N'10091375', N' Samuel Costa Falcao', N'Ampla', 88.8, 0, 88.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1172, N'10007595', N' FranklinDelano Varela Amador', N'Ampla', 88.79, 0, 88.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1173, N'10029676', N' Gustavo Lopes de Carvalho', N'Ampla', 88.76, 0, 88.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1174, N'10064356', N'Thais Manhaes Eleuterio', N'Ampla', 88.76, 0, 88.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1175, N'10037698', N' Julia Morais Roriz dos Anjos', N'Ampla', 88.75, 0, 88.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1176, N'10055523', N'Leandro Alberto da Cruz Demosthenes', N'Ampla', 88.74, 0, 88.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1177, N'10016288', N' Vantuyler Borges de Morais', N'Ampla', 88.73, 0, 88.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1178, N'10029062', N' Melina Brito de Souza', N'Ampla', 88.73, 0, 88.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1179, N'10088898', N' Moises Loiola Heldeberto', N'Ampla', 88.72, 0, 88.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1180, N'10110644', N' Vinicius Belo Dutra', N'Ampla', 88.72, 0, 88.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1181, N'10052151', N' Gabriel Lima de Oliveira', N'Ampla', 88.72, 0, 88.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1182, N'10024904', N'Roberto Carlos Pereira Junior', N'Ampla', 88.7, 0, 88.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1183, N'10066632', N' Juliane Barbosa Pereira', N'Ampla', 88.7, 0, 88.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1184, N'10064808', N'Eduardo Vieira de Araujo Junior', N'Ampla', 88.69, 0, 88.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1185, N'10080522', N' Thalitta Rodrigues Viana', N'Ampla', 88.69, 0, 88.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1186, N'10097354', N' Filipe Lima Ribeiro', N'Ampla', 88.68, 0, 88.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1187, N'10071050', N' Marco Aurelio Diniz Pereira', N'Ampla', 88.68, 0, 88.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1188, N'10005655', N' Ulisses Antonio Pereira', N'Ampla', 88.68, 0, 88.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1189, N'10067867', N' Bruno Vinicius de Oliveira Andrade', N'Ampla', 88.67, 0, 88.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1190, N'10077425', N' Wilame da Silva Mendes', N'Ampla', 88.67, 0, 88.67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1191, N'10047240', N' Victor Hugo Uchoa Tatagiba', N'Ampla', 88.66, 0, 88.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1192, N'10009813', N' Daniely Bonfim de Sousa', N'Ampla', 88.59, 0, 88.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1193, N'10062563', N' Nathalia da Conceicao Silva Dias', N'Ampla', 88.57, 0, 88.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1194, N'10033828', N' Amanda de Castro Bernardes', N'Ampla', 88.56, 0, 88.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1195, N'10030058', N' Weslany Guimaraes dosSantos', N'Ampla', 88.56, 0, 88.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1196, N'10103331', N' Jose Ribamar Sousa Duarte Junior', N'Ampla', 88.56, 0, 88.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1197, N'10022971', N' Sabrina Alvesde Oliveira Filincowsky', N'Ampla', 88.56, 0, 88.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1198, N'10019641', N' Gabriel Henrique Bragagnolo Chiaradia', N'Ampla', 88.54, 0, 88.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1199, N'10065118', N' Beatriz Costa Soares', N'Ampla', 88.52, 0, 88.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1200, N'10054129', N' Rodrigo Carvalho Araujo', N'Ampla', 88.52, 0, 88.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1201, N'10091226', N' Catiana Silveira de Souza Araujo', N'Ampla', 88.5, 0, 88.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1202, N'10105853', N' Gabriel de Andrade Paiva', N'Ampla', 88.48, 0, 88.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1203, N'10043901', N' Luiz Felipe Andrade Pires de Siqueira', N'Ampla', 88.46, 0, 88.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1204, N'10023602', N' Gabriel Maiello ItaborahyCosta Ferreira', N'Ampla', 88.46, 0, 88.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1205, N'10070102', N' Filipe Israel Azevedo', N'Ampla', 88.46, 0, 88.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1206, N'10002725', N' Livia Chaves Saito', N'Ampla', 88.44, 0, 88.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1207, N'10006191', N' Lee Harrison Wall dos Santos', N'Ampla', 88.43, 0, 88.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1208, N'10031391', N' Gabriel Barbosa da Silva', N'Ampla', 88.42, 0, 88.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1209, N'10049375', N' Michelle Vilar da Silva Pimentel', N'Ampla', 88.42, 0, 88.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1210, N'10009894', N' Fabiana de OliveiraOzaka', N'Ampla', 88.4, 0, 88.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1211, N'10076493', N' Lucas Cordeiro Silva', N'Ampla', 88.37, 0, 88.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1212, N'10010254', N' Rafael Goncalves Valenca', N'Ampla', 88.37, 0, 88.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1213, N'10043547', N' Luis Felipe de Oliveira Dourado', N'Ampla', 88.37, 0, 88.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1214, N'10005020', N' Vanessa BatistaGoncalves', N'Ampla', 88.36, 0, 88.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1215, N'10001731', N' Felipe dos Santos Faria', N'Ampla', 88.35, 0, 88.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1216, N'10000035', N' Humberto AlvesBrito Sousa de Melo', N'Ampla', 88.35, 0, 88.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1217, N'10049427', N' Sedrick Pereira de Lima Junior', N'Ampla', 88.31, 0, 88.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1218, N'10032820', N'Kenia Guimaraes de Amorim', N'Ampla', 88.31, 0, 88.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1219, N'10004346', N' Melissa Xavier Araujo', N'Ampla', 88.26, 0, 88.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1220, N'10044759', N'Pedro Henrique Maciel', N'Ampla', 88.24, 0, 88.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1221, N'10050965', N' Eduardo Dias de Oliveira Rosa', N'Ampla', 88.24, 0, 88.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1222, N'10004243', N'Felipe Milhomem Ribeiro', N'Ampla', 88.24, 0, 88.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1223, N'10061988', N' Hugo Vitor Alves Costa', N'Ampla', 88.23, 0, 88.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1224, N'10005105', N' DaniloFialho Severino', N'Ampla', 88.22, 0, 88.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1225, N'10038784', N' Thiago Roris de Matos', N'Ampla', 88.2, 0, 88.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1226, N'10026529', N' Rafael OliveiraRodrigues', N'Ampla', 88.19, 0, 88.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1227, N'10079782', N' Carlos Alberto Alves de Lima Junior', N'Ampla', 88.19, 0, 88.19)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1228, N'10034764', N' PedroDelgado Alvim de Mello', N'Ampla', 88.17, 0, 88.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1229, N'10020786', N' Maycon Patrick Dias', N'Ampla', 88.17, 0, 88.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1230, N'10001043', N' LucasLassi Puglia', N'Ampla', 88.17, 0, 88.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1231, N'10059764', N' Vinicius dos Anjos Rodrigues', N'Ampla', 88.16, 0, 88.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1232, N'10058745', N' Lucas OliveiraPedreira', N'Ampla', 88.15, 0, 88.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1233, N'10034454', N' Paulo Henrique Medeiros Macedo', N'Ampla', 88.13, 0, 88.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1234, N'10046823', N' Eduardo Novakovski Machado', N'Ampla', 88.12, 0, 88.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1235, N'10070129', N' Ingrid Medeiros Veras Rocha', N'Ampla', 88.11, 0, 88.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1236, N'10010850', N'Fabio Cruz dos Reis', N'Ampla', 88.1, 0, 88.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1237, N'10006270', N' Tarso Campos Andrea', N'Ampla', 88.1, 0, 88.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1238, N'10085220', N' Adriel Schumacher Fernandes da Silveira Martins', N'Ampla', 88.09, 0, 88.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1239, N'10033168', N' Maria Teresa Magalhaes Madureira', N'Ampla', 88.09, 0, 88.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1240, N'10072394', N' Melissa Kelly Ferreira Rangel', N'Ampla', 88.09, 0, 88.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1241, N'10040421', N' Ingrid Fernanda de Sousa', N'Ampla', 88.08, 0, 88.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1242, N'10023301', N' Gesomar Rodrigues de Franca', N'Ampla', 88.05, 0, 88.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1243, N'10055996', N' Lucielen Martins daRocha', N'Ampla', 88.02, 0, 88.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1244, N'10004960', N' Gabriel Botelho Mercon', N'Ampla', 88.02, 0, 88.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1245, N'10045320', N' Bruno Henrique SantosCavalho', N'Ampla', 88.02, 0, 88.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1246, N'10008539', N' Felipe Douglas Santos da Silva', N'Ampla', 87.99, 0, 87.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1247, N'10066179', N' Davson Brunoda Silva Melo', N'Ampla', 87.97, 0, 87.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1248, N'10060726', N' Rafael Porciuncula Sales', N'Ampla', 87.97, 0, 87.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1249, N'10018724', N' AlexandreMagno Marques Rodrigues', N'Ampla', 87.95, 0, 87.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1250, N'10016791', N' Eduardo Gorga Bortoletto', N'Ampla', 87.95, 0, 87.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1251, N'10018434', N'Yuri Soares Pinheiro', N'Ampla', 87.94, 0, 87.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1252, N'10001417', N' Elcinara da Silva Tenorio', N'Ampla', 87.94, 0, 87.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1253, N'10021745', N' Julia deCastro Ferreira', N'Ampla', 87.94, 0, 87.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1254, N'10020302', N' Monica Lins dos Santos', N'Ampla', 87.92, 0, 87.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1255, N'10001299', N' Israel FerreiraSoares', N'Ampla', 87.92, 0, 87.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1256, N'10019208', N' Marissol Silva Pontes*', N'Ampla', 87.91, 0, 87.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1257, N'10062080', N' Daniel Bernardo deSouza Santos', N'Ampla', 87.91, 0, 87.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1258, N'10049089', N' Marcelo Correa dos Santos', N'Ampla', 87.89, 0, 87.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1259, N'10027862', N' Augusto CesarLisboa Martins', N'Ampla', 87.88, 0, 87.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1260, N'10071592', N' Leonardo Bertuol Guimaraes', N'Ampla', 87.86, 0, 87.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1261, N'10039480', N' LucianoBeck Halfen da Porciuncula', N'Ampla', 87.85, 0, 87.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1262, N'10079037', N' Lucas Moreira Lima', N'Ampla', 87.83, 0, 87.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1263, N'10031501', N' BrunoSouza dos Reis', N'Ampla', 87.81, 0, 87.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1264, N'10053421', N' Joabe Medeiros Goncalves', N'Ampla', 87.81, 0, 87.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1265, N'10025804', N' DanielleMoreira Clarindo', N'Ampla', 87.81, 0, 87.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1266, N'10065640', N' Leandro Rafael do Nascimento Silva', N'Ampla', 87.81, 0, 87.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1267, N'10038585', N'Adriano Henrique Viana Martins', N'Ampla', 87.8, 0, 87.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1268, N'10063336', N' Ramon de Medeiros Bahia', N'Ampla', 87.8, 0, 87.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1269, N'10036786', N' Isadora Abdalla Amorim', N'Ampla', 87.78, 0, 87.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1270, N'10028637', N' Felipe Marques Figueira Barbosa', N'Ampla', 87.74, 0, 87.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1271, N'10021005', N' Amanda Soares de Souza', N'Ampla', 87.74, 0, 87.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1272, N'10042014', N' Markus Tiago Sonntag', N'Ampla', 87.73, 0, 87.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1273, N'10031165', N' Gustavo Alves Ferreira', N'Ampla', 87.73, 0, 87.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1274, N'10016726', N' Rafael Loureiro Coutinho', N'Ampla', 87.72, 0, 87.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1275, N'10083269', N' Carlos Henrique Catrinque Andrade', N'Ampla', 87.71, 0, 87.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1276, N'10054677', N' Leticia Goncalves Valfre', N'Ampla', 87.69, 0, 87.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1277, N'10001213', N' Dominique Heron da Silva Lorenzi', N'Ampla', 87.68, 0, 87.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1278, N'10057631', N' Rafael Serejo de Jesus', N'Ampla', 87.66, 0, 87.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1279, N'10002338', N' Cristiano Curado Abrantes Caetano', N'Ampla', 87.64, 0, 87.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1280, N'10017484', N' Mateus Felippin deAlbuquerque', N'Ampla', 87.6, 0, 87.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1281, N'10059975', N' Ludimilla Batista Pinheiro Marques', N'Ampla', 87.59, 0, 87.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1282, N'10016809', N' Henrique Erik Damasceno Silva', N'Ampla', 87.59, 0, 87.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1283, N'10070133', N' Ana Paula Nascimento da Silva Andrade', N'Ampla', 87.59, 0, 87.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1284, N'10013117', N' Isabela Soares Oliveira Cancado Ferreira', N'Ampla', 87.57, 0, 87.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1285, N'10012884', N' Pedro HenriqueParanagua de Castro', N'Ampla', 87.56, 0, 87.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1286, N'10042040', N' Monica Gomes Muller', N'Ampla', 87.56, 0, 87.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1287, N'10020336', N' MarlosAngelo Silva Quirino', N'Ampla', 87.56, 0, 87.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1288, N'10085698', N' Vanessa Maria da Silva Paiva', N'Ampla', 87.56, 0, 87.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1289, N'10030842', N' LucasFonseca da Silva', N'Ampla', 87.56, 0, 87.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1290, N'10009268', N' Ludimila Gomes de Amorim Mota', N'Ampla', 87.55, 0, 87.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1291, N'10011029', N'Juliana Bezerra Carneiro', N'Ampla', 87.55, 0, 87.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1292, N'10073494', N' Matheus Martins Cavalari Cardoso', N'Ampla', 87.55, 0, 87.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1293, N'10041943', N' Bernardo Moreira Pinto', N'Ampla', 87.54, 0, 87.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1294, N'10007279', N' Alisson Cardoso Pereira', N'Ampla', 87.53, 0, 87.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1295, N'10046921', N' Andre Luiz Barros Almeida', N'Ampla', 87.53, 0, 87.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1296, N'10080819', N' Carlos Augusto Bernardes Ribeiro', N'Ampla', 87.53, 0, 87.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1297, N'10011140', N' Maiko Alves de Castro', N'Ampla', 87.5, 0, 87.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1298, N'10013934', N' Felipe Bergamaschi Brettas', N'Ampla', 87.43, 0, 87.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1299, N'10048292', N' Jardel Cavalcante Rolim', N'Ampla', 87.42, 0, 87.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1300, N'10046920', N' Gizele Pires Arruda Pereira da Silva', N'Ampla', 87.41, 0, 87.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1301, N'10002481', N' Thomas Jefferson Soares Lacerda', N'Ampla', 87.38, 0, 87.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1302, N'10025425', N' Sonia Cristina de OliveiraGuimaraes', N'Ampla', 87.38, 0, 87.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1303, N'10032079', N' Giovanna de Azevedo Mello Gobbo', N'Ampla', 87.36, 0, 87.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1304, N'10040419', N'Karolline Ambrosi Tosta', N'Ampla', 87.35, 0, 87.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1305, N'10010902', N' Warley Jose Gimenes Pessanha', N'Ampla', 87.35, 0, 87.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1306, N'10055143', N' Jhuly Kelly Ferreira Rodrigues', N'Ampla', 87.34, 0, 87.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1307, N'10004787', N' Fabio da Silva Gomes', N'Ampla', 87.33, 0, 87.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1308, N'10040298', N' Nathalia Fenner Saldanha', N'Ampla', 87.33, 0, 87.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1309, N'10001826', N' Humberto Solano de Freitas Junior', N'Ampla', 87.32, 0, 87.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1310, N'10056508', N' Jackson dos Santos Anjos', N'Ampla', 87.32, 0, 87.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1311, N'10039443', N' Rodrigo Antonio Vieira Rodrigues', N'Ampla', 87.31, 0, 87.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1312, N'10002876', N' Francisco de Assis de Oliveira Silva', N'Ampla', 87.31, 0, 87.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1313, N'10071034', N' Mario Sergio AlvesElias', N'Ampla', 87.3, 0, 87.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1314, N'10076450', N' Mateus Pinchemel de Andrade', N'Ampla', 87.3, 0, 87.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1315, N'10012137', N' Joao PauloCardoso Zandonade', N'Ampla', 87.28, 0, 87.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1316, N'10037276', N' Joao Vitor Fernandes de Oliveira', N'Ampla', 87.23, 0, 87.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1317, N'10063214', N'Gabriela Alves Silva', N'Ampla', 87.18, 0, 87.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1318, N'10004288', N' Milene Prata de Souza', N'Ampla', 87.17, 0, 87.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1319, N'10072159', N' Lucas HideoHataka Koyama', N'Ampla', 87.17, 0, 87.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1320, N'10017070', N' Lucas Moreira da Mota', N'Ampla', 87.15, 0, 87.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1321, N'10022458', N' Rodrigo deOliveira Teixeira', N'Ampla', 87.12, 0, 87.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1322, N'10043618', N' Roberta Ligia Cavalcanti Lima', N'Ampla', 87.12, 0, 87.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1323, N'10035251', N' ThameraSoares Souza', N'Ampla', 87.12, 0, 87.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1324, N'10102938', N' Tayrone Tadeu de Freitas Coelho', N'Ampla', 87.03, 0, 87.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1325, N'10050001', N' IsabelaLuisa Zardo e Silva', N'Ampla', 87.03, 0, 87.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1326, N'10001814', N' Matheus Pinho Lins de Araujo', N'Ampla', 87.03, 0, 87.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1327, N'10036030', N' Gabriel Henrique de Almeida', N'Ampla', 87.01, 0, 87.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1328, N'10004244', N' Ana Clara Viana Lima', N'Ampla', 87.01, 0, 87.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1329, N'10008064', N'Nathan Ranieri Santos Teofilo', N'Ampla', 86.99, 0, 86.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1330, N'10014698', N' David Wilker da Silva Roma', N'Ampla', 86.96, 0, 86.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1331, N'10016949', N' Enielle Donda Fernandes da Silva', N'Ampla', 86.96, 0, 86.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1332, N'10081500', N' Pablo Alexandre Gomes e Silva', N'Ampla', 86.95, 0, 86.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1333, N'10021757', N' Jader Batista Mendes', N'Ampla', 86.91, 0, 86.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1334, N'10065339', N' Pedro Cesar Queiroz da Silva', N'Ampla', 86.9, 0, 86.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1335, N'10022419', N' Julia Scarponi Pinto Costa Pereira', N'Ampla', 86.85, 0, 86.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1336, N'10022995', N' Rafael Salles Pereira', N'Ampla', 86.84, 0, 86.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1337, N'10035602', N' Rafaela Cordeiro Oliveira Ribeiro', N'Ampla', 86.83, 0, 86.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1338, N'10090583', N' Silvaldo QuirinoTavares', N'Ampla', 86.82, 0, 86.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1339, N'10002265', N' Alex Alves Murray', N'Ampla', 86.81, 0, 86.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1340, N'10063677', N' Ady Coutinho Solino', N'Ampla', 86.81, 0, 86.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1341, N'10011153', N' Fernanda Leal e Costa Bittencourt de Araujo***', N'Ampla', 86.8, 0, 86.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1342, N'10008422', N' AramisFerreira Silva', N'Ampla', 86.79, 0, 86.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1343, N'10011671', N' Roberto Dutra da Silva Filho', N'Ampla', 86.78, 0, 86.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1344, N'10041206', N' Sara da SilvaFernandes', N'Ampla', 86.75, 0, 86.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1345, N'10006482', N' Nathalia Lauria do Nascimento', N'Ampla', 86.74, 0, 86.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1346, N'10067566', N' GuilhermeLino Santos Santana', N'Ampla', 86.72, 0, 86.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1347, N'10041718', N' Lucio Sidney de Oliveira Souza', N'Ampla', 86.72, 0, 86.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1348, N'10047512', N'Mirellen Mara Moreira', N'Ampla', 86.7, 0, 86.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1349, N'10011725', N' Alessandra Garcia Diniz', N'Ampla', 86.7, 0, 86.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1350, N'10009617', N'Peterson da Cunha Estevan Costa', N'Ampla', 86.66, 0, 86.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1351, N'10102979', N' Franciane Carina Gerioni', N'Ampla', 86.66, 0, 86.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1352, N'10027561', N' Rayanne Gobbi de Carvalho Zumpano', N'Ampla', 86.61, 0, 86.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1353, N'10018132', N' Bruno Beserra Assuncao', N'Ampla', 86.6, 0, 86.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1354, N'10007097', N' Ana Carolina Cotta', N'Ampla', 86.59, 0, 86.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1355, N'10023423', N' Juan Francisco Neves Tanajura', N'Ampla', 86.54, 0, 86.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1356, N'10014832', N' Rafael Fernando Mendonca de Alencar', N'Ampla', 86.54, 0, 86.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1357, N'10011181', N' Gabriela GomesGuerra de Magalhaes', N'Ampla', 86.53, 0, 86.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1358, N'10059307', N' Lucas Alves de Souza', N'Ampla', 86.5, 0, 86.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1359, N'10009946', N' WilliansRibeiro de Campos', N'Ampla', 86.44, 0, 86.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1360, N'10055134', N' Adriano Mateus de Souza Campos', N'Ampla', 86.42, 0, 86.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1361, N'10007386', N'Daiele Ruana Lima dos Santos', N'Ampla', 86.36, 0, 86.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1362, N'10078987', N' Carlos Calheiro de Lima', N'Ampla', 86.32, 0, 86.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1363, N'10079371', N' Jean Ismael Agripino Ferreira dos Santos', N'Ampla', 86.3, 0, 86.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1364, N'10063058', N' Eloiza da Silva Pinheiro', N'Ampla', 86.3, 0, 86.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1365, N'10023689', N' Paula Carolina Kraetzer de Oliveira', N'Ampla', 86.3, 0, 86.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1366, N'10030333', N' Tiago do Vale Araujo', N'Ampla', 86.28, 0, 86.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1367, N'10021688', N' Yuri Araujo Coelho Penna', N'Ampla', 86.25, 0, 86.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1368, N'10035024', N' Cinthia Barbosa da Silva', N'Ampla', 86.25, 0, 86.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1369, N'10062285', N' Gabriela Araujo dos Santos Mesquita', N'Ampla', 86.23, 0, 86.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1370, N'10038133', N' Andreza Santos de Mesquita Bomtempo', N'Ampla', 86.22, 0, 86.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1371, N'10077837', N' Lucas Vinicius Diniz Prado', N'Ampla', 86.22, 0, 86.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1372, N'10031087', N' Fernanda MaiaLacerda', N'Ampla', 86.13, 0, 86.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1373, N'10020460', N' Nivaldo Batista de Oliveira Junior', N'Ampla', 86.12, 0, 86.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1374, N'10010498', N' AlissonBruno Milanez Barros', N'Ampla', 86.11, 0, 86.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1375, N'10008459', N' Frederico Silva Lopes Aguiar', N'Ampla', 86.09, 0, 86.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1376, N'10013093', N'Bruno Haack de Arruda Dutra', N'Ampla', 86.04, 0, 86.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1377, N'10010443', N' Francisco Jefferson da Silva', N'Ampla', 86.03, 0, 86.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1378, N'10017571', N' Charles Henrique Souza de Jesus', N'Ampla', 86.02, 0, 86.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1379, N'10062811', N' Rafael Lima de Siqueira', N'Ampla', 86.02, 0, 86.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1380, N'10021459', N' Marcelo Silva Alves', N'Ampla', 86.02, 0, 86.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1381, N'10101150', N' Paulo Raimundo de Paiva Arbues Carneiro', N'Ampla', 85.97, 0, 85.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1382, N'10005197', N' Felipe Braga Viana', N'Ampla', 85.96, 0, 85.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1383, N'10008573', N' Brunno Franca de Oliveira', N'Ampla', 85.93, 0, 85.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1384, N'10004955', N' Keyla do Nascimento Rocha', N'Ampla', 85.93, 0, 85.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1385, N'10007686', N' Juvenil Rodrigues da Cruz Junior', N'Ampla', 85.84, 0, 85.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1386, N'10061672', N' Felipe de Almeida Cimas', N'Ampla', 85.83, 0, 85.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1387, N'10069981', N' Camila Rodrigues Celestino', N'Ampla', 85.81, 0, 85.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1388, N'10001603', N' Aluizio de Sousa Lustosa', N'Ampla', 85.8, 0, 85.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1389, N'10047490', N' Mario Junior Mendes da Silva', N'Ampla', 85.79, 0, 85.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1390, N'10006489', N' Bruno Hebert de Almeida Nunes', N'Ampla', 85.71, 0, 85.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1391, N'10023396', N' Joao Victor DinizCampos Dias', N'Ampla', 85.69, 0, 85.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1392, N'10008710', N' Caio Cesar Mascena Lima', N'Ampla', 85.66, 0, 85.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1393, N'10002397', N' Elves JuniorMedina Brandao', N'Ampla', 85.65, 0, 85.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1394, N'10002350', N' Marcel Cerqueira de Souza Jatoba', N'Ampla', 85.65, 0, 85.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1395, N'10004275', N'Anderson Cesar Pereira da Silva', N'Ampla', 85.65, 0, 85.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1396, N'10018145', N' Welerson Ferreira Abreu', N'Ampla', 85.59, 0, 85.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1397, N'10060047', N' Paulo Henrique Queiroz Cavalcante', N'Ampla', 85.59, 0, 85.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1398, N'10010796', N' Fabiana Koffes Marinho', N'Ampla', 85.59, 0, 85.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1399, N'10048023', N' Ulisses Alves da Conceicao', N'Ampla', 85.56, 0, 85.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1400, N'10026596', N' Pedro Rocha de Freitas', N'Ampla', 85.54, 0, 85.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1401, N'10046955', N' Manoel Carvalho Gontijo dos Santos', N'Ampla', 85.5, 0, 85.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1402, N'10028382', N' Diana Nunes de Oliveira', N'Ampla', 85.46, 0, 85.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1403, N'10009985', N' Rafael Pereira Nunes', N'Ampla', 85.45, 0, 85.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1404, N'10001377', N' Leandro Binueza do Vale', N'Ampla', 85.41, 0, 85.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1405, N'10056694', N' Mike Oneil Ferreira Almeida', N'Ampla', 85.41, 0, 85.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1406, N'10015633', N' Renan Motta da Silva', N'Ampla', 85.38, 0, 85.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1407, N'10013459', N' Joao Gabriel de Aguiar Carvalho', N'Ampla', 85.37, 0, 85.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1408, N'10004473', N' Krisllayne de OliveiraFernandes Caldas', N'Ampla', 85.35, 0, 85.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1409, N'10058343', N' William Sales Ferreira do Carmo', N'Ampla', 85.34, 0, 85.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1410, N'10099489', N'Hellen Noleto Pereira Costa', N'Ampla', 85.33, 0, 85.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1411, N'10082887', N' Wanderson Gomes dos Santos', N'Ampla', 85.27, 0, 85.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1412, N'10065168', N' Elias da Costa Belinazo', N'Ampla', 85.21, 0, 85.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1413, N'10089200', N' Thomas Luciano Alves da Silva', N'Ampla', 85.21, 0, 85.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1414, N'10012964', N' Vanderly Salvador de Queiroz', N'Ampla', 85.18, 0, 85.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1415, N'10078977', N' Adriano Augusto Bliska', N'Ampla', 85.17, 0, 85.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1416, N'10006101', N' Gustavo Gabriel Martins Ferreira', N'Ampla', 85.17, 0, 85.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1417, N'10045553', N' Gabriel Moraes de Aquino', N'Ampla', 85.15, 0, 85.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1418, N'10054498', N' Pedro Henrique Tavora Pereira Filho', N'Ampla', 85.15, 0, 85.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1419, N'10032952', N' Gislene Ferreira Batista', N'Ampla', 85.11, 0, 85.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1420, N'10049460', N' Cristian Ramos de Oliveira Grilo', N'Ampla', 85.11, 0, 85.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1421, N'10075209', N' Paulo MendesFlorentino Filho', N'Ampla', 85.08, 0, 85.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1422, N'10054682', N' Gustavo Mainenti Fontes', N'Ampla', 85.06, 0, 85.06)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1423, N'10066668', N' AlysonSoares dos Santos', N'Ampla', 85.05, 0, 85.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1424, N'10048444', N' Mateus Medeiros Alves Campos', N'Ampla', 85.04, 0, 85.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1425, N'10014630', N'Phelipe Correia Costa', N'Ampla', 85.03, 0, 85.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1426, N'10063225', N' Gustavo Goncalo Rodrigues', N'Ampla', 85.03, 0, 85.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1427, N'10063605', N'Reison Vinicius Siqueira Cruz Rodrigues', N'Ampla', 85.02, 0, 85.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1428, N'10025880', N' Alexandre Cyrino de Sousa', N'Ampla', 85.01, 0, 85.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1429, N'10053117', N' Jorge Waschington do Carmo Junior', N'Ampla', 84.95, 0, 84.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1430, N'10062388', N' Arthur Jorge Lins Mendonca', N'Ampla', 84.94, 0, 84.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1431, N'10035604', N' Jeferson Jesus de Aragao', N'Ampla', 84.94, 0, 84.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1432, N'10043628', N' Lucas Baldasso', N'Ampla', 84.92, 0, 84.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1433, N'10072113', N' Elton da Silva Candido', N'Ampla', 84.9, 0, 84.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1434, N'10003186', N' Diego Alves de Lima', N'Ampla', 84.89, 0, 84.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1435, N'10015450', N'Victor de Sousa Passos', N'Ampla', 84.88, 0, 84.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1436, N'10068965', N' Antonio Rafael Silva Brito', N'Ampla', 84.86, 0, 84.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1437, N'10001369', N' FilipeAguiar Rodrigues', N'Ampla', 84.85, 0, 84.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1438, N'10009278', N' Giovanna Bampi', N'Ampla', 84.82, 0, 84.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1439, N'10038368', N' Rayldon Ribeiro daSilva', N'Ampla', 84.81, 0, 84.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1440, N'10012337', N' Auiris Ferreira da Silva', N'Ampla', 84.79, 0, 84.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1441, N'10043706', N' Thiago Felix Borges', N'Ampla', 84.78, 0, 84.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1442, N'10044039', N' Raquel Silva Moreira', N'Ampla', 84.71, 0, 84.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1443, N'10006050', N' Ulisses Almeida Coutinho', N'Ampla', 84.66, 0, 84.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1444, N'10010261', N' Gustavo Nunes Ribeiro', N'Ampla', 84.65, 0, 84.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1445, N'10089670', N' Hugo de Oliveira Arruda Badin', N'Ampla', 84.65, 0, 84.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1446, N'10001113', N' Frederico Augusto de Vasconcelos Ferreira', N'Ampla', 84.63, 0, 84.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1447, N'10062056', N' Yuri Gustavo de Souza', N'Ampla', 84.6, 0, 84.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1448, N'10006478', N' Cristiane Ximenes da Silva', N'Ampla', 84.56, 0, 84.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1449, N'10044284', N' Heverlyn Dyanne Teles deMiranda', N'Ampla', 84.46, 0, 84.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1450, N'10077333', N' Jonathan Goncalves Dutra de Souza', N'Ampla', 84.46, 0, 84.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1451, N'10094378', N' PabloHenrique da Cunha Silva', N'Ampla', 84.45, 0, 84.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1452, N'10006215', N' Giovanna Pedroza Nunes de Oliveira', N'Ampla', 84.42, 0, 84.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1453, N'10047516', N' Matheus de Siqueira Xavier', N'Ampla', 84.38, 0, 84.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1454, N'10022167', N' Savio Preto Menezes', N'Ampla', 84.28, 0, 84.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1455, N'10000508', N' Daiane Braz Neri', N'Ampla', 84.27, 0, 84.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1456, N'10006450', N' Lucas de Santana Silva', N'Ampla', 84.24, 0, 84.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1457, N'10017608', N'Gustavo Verissimo Guimaraes', N'Ampla', 84.22, 0, 84.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1458, N'10030952', N' Diego Becker Griebler', N'Ampla', 84.18, 0, 84.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1459, N'10082966', N'Igor Rogerio Araujo de Sousa', N'Ampla', 84.09, 0, 84.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1460, N'10018723', N' Isabela Silva Lara Reis', N'Ampla', 84.09, 0, 84.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1461, N'10088836', N' Danielly Quintas Cascelli de Azevedo', N'Ampla', 84.08, 0, 84.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1462, N'10008613', N' Ivana Colares Mendes de Almeida', N'Ampla', 84.03, 0, 84.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1463, N'10059992', N' Douglas de Sousa Bezerra', N'Ampla', 84.01, 0, 84.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1464, N'10086869', N' Macelio Pedrosa Vieira', N'Ampla', 83.95, 0, 83.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1465, N'10034944', N' Joao Paulo Lima Fernandes', N'Ampla', 83.94, 0, 83.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1466, N'10054897', N' Thiago Garcia Rosa Zanandrea', N'Ampla', 83.89, 0, 83.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1467, N'10016636', N' Alexandre Rabelo Tavares', N'Ampla', 83.89, 0, 83.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1468, N'10046312', N' Thiago Coelho Ferrolho', N'Ampla', 83.85, 0, 83.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1469, N'10063818', N' Erica Fonteneles de Souza', N'Ampla', 83.78, 0, 83.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1470, N'10037076', N' Gabriela Araujo Correa', N'Ampla', 83.75, 0, 83.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1471, N'10098487', N' Camylla Silva Batista', N'Ampla', 83.75, 0, 83.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1472, N'10016131', N' Sandi Alves de Souza Pereira', N'Ampla', 83.72, 0, 83.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1473, N'10037931', N' Barbara Xavier Cavalcanti', N'Ampla', 83.71, 0, 83.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1474, N'10093803', N' Rodrigo de Almeida Romar', N'Ampla', 83.71, 0, 83.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1475, N'10058436', N' Vinicius Mendonca Teixeira', N'Ampla', 83.65, 0, 83.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1476, N'10051869', N' Daniele da Silva Rocha', N'Ampla', 83.6, 0, 83.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1477, N'10027536', N' Sandoval Santana Meira Junior', N'Ampla', 83.59, 0, 83.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1478, N'10030706', N' Marcos Henrique de Andrade', N'Ampla', 83.58, 0, 83.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1479, N'10068723', N' Gabriela Soares de Rezende', N'Ampla', 83.57, 0, 83.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1480, N'10069488', N' Vitor Manoel Borges Ferreira', N'Ampla', 83.55, 0, 83.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1481, N'10010497', N' Taian Cristal Ferreira Salles', N'Ampla', 83.55, 0, 83.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1482, N'10063467', N' Joyce Bonfim Pessoa', N'Ampla', 83.46, 0, 83.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1483, N'10045588', N' Romulo Flanegan Esperanca Campos', N'Ampla', 83.39, 0, 83.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1484, N'10038964', N' Rodrigo Meneses Cabral', N'Ampla', 83.38, 0, 83.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1485, N'10036470', N' Sidney da Silva de Oliveira', N'Ampla', 83.32, 0, 83.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1486, N'10002787', N' Isaac Johnson VasconcelosElias', N'Ampla', 83.32, 0, 83.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1487, N'10078093', N' Cleber de Moura Tavares', N'Ampla', 83.31, 0, 83.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1488, N'10023308', N' Lurien Gomes do Carmo', N'Ampla', 83.24, 0, 83.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1489, N'10055081', N' Felipe Lopes da Silva', N'Ampla', 83.21, 0, 83.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1490, N'10071435', N' Marilia Gabriela de OliveiraRamos', N'Ampla', 83.1, 0, 83.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1491, N'10065580', N' Leticia Lopes Campos', N'Ampla', 83.09, 0, 83.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1492, N'10021053', N' Mario Luiz RebeloMiquelino Cunha', N'Ampla', 83.04, 0, 83.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1493, N'10005733', N' Thales Junior Moreira da Silva', N'Ampla', 83.02, 0, 83.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1494, N'10013038', N' GlaucoMacedo Fonseca Neto Salzmann', N'Ampla', 82.79, 0, 82.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1495, N'10019004', N' Ana Carolina Croner de Abreu', N'Ampla', 82.65, 0, 82.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1496, N'10035972', N' Joao Paulo de Castro Carisio Ribeiro', N'Ampla', 82.62, 0, 82.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1497, N'10088667', N' Eduardo Augusto Brandao Duarte', N'Ampla', 82.44, 0, 82.44)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1498, N'10039605', N' Lays Venancio Lira*', N'Ampla', 82.24, 0, 82.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1499, N'10077057', N' Claudio Cristian de SouzaCampos', N'Ampla', 82.22, 0, 82.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1500, N'10034800', N' Leonardo Romao Batista*', N'Ampla', 81.26, 0, 81.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1501, N'10054671', N' Gisele Silva Santos*', N'Ampla', 78.81, 0, 78.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1502, N'10071520', N' Simone Freitas da Silva*', N'Ampla', 77.61, 0, 77.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1503, N'10030585', N' Thiago Leao Pires*', N'Ampla', 76.77, 0, 76.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1504, N'10105245', N' Pedro Henrique Duarte Medeiros de Brito*', N'Ampla', 76.43, 0, 76.43)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1505, N'10083428', N' Kelly Medeiros deSouto*', N'Ampla', 75.47, 0, 75.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1506, N'10066211', N' Samara Alves de Oliveira Familiar*', N'Ampla', 75.32, 0, 75.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1507, N'10037805', N' Pablo MatosCavalcante*', N'Ampla', 72.42, 0, 72.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1508, N'10024422', N' Eduardo Campos de Jesus*', N'Ampla', 71.1, 0, 71.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1509, N'10077354', N' Elaine deAzevedo Ribas*', N'Ampla', 70.74, 0, 70.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1510, N'10023420', N' Jeferson Cardoso Costa*', N'Ampla', 69.95, 0, 69.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1511, N'10067732', N' Luana NarjaraCarvalho dos Santos*', N'Ampla', 68.37, 0, 68.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1512, N'10026705', N' Anderson Bruno de Andrade Silva*', N'Ampla', 68.07, 0, 68.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1513, N'10040187', N' Thiago Oliveira Bedas*', N'Ampla', 67.39, 0, 67.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1514, N'10022823', N' Roberto Pereira da Silva*', N'Ampla', 67.26, 0, 67.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1515, N'10016703', N' Alexandre Oliveira Silva*', N'Ampla', 67, 0, 67)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1516, N'10035302', N' Mario Augusto Paulino de Lima Filho*', N'Ampla', 61.05, 0, 61.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1517, N'10001524', N' Tamara da Silva Cardoso*', N'Ampla', 55.26, 0, 55.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1518, N'10061041', N' Jeancarlos da Silva Junior', N'Negros', 116.71, 0, 116.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1519, N'10006223', N' Isabela Brito Couto de Oliveira', N'Negros', 110.07, 0, 110.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1520, N'10001622', N' Bruno da Silva Coelho', N'Negros', 107.2, 0, 107.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1521, N'10059829', N' Thallys Deusdara Monsueth Alves', N'Negros', 102.6, 0, 102.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1522, N'10043650', N' Jose Lidberg Rocha Lima Filho', N'Negros', 102.29, 0, 102.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1523, N'10010288', N' Bruno Araujo Lima', N'Negros', 101.3, 0, 101.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1524, N'10012723', N'Natalia Lemos Penetra', N'Negros', 101.3, 0, 101.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1525, N'10026423', N' Vitor Rodrigues Santos', N'Negros', 100.89, 0, 100.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1526, N'10029028', N' FernandaMiranda de Souza', N'Negros', 100.24, 0, 100.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1527, N'10003244', N' Vinicius Tavares de Castro', N'Negros', 99.59, 0, 99.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1528, N'10026809', N' Manuella Maria Santos Miguel da Silva', N'Negros', 99.52, 0, 99.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1529, N'10105083', N' Wallace Willian do Nascimento Macedo', N'Negros', 99.23, 0, 99.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1530, N'10015833', N' Arthur Gouvea Fernandes', N'Negros', 98.48, 0, 98.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1531, N'10029952', N' Bruno Cesar Sampaio Ribeiro de Assis', N'Negros', 98.48, 0, 98.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1532, N'10002663', N' Ciro Camilo Santos Leal', N'Negros', 98.37, 0, 98.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1533, N'10002814', N' Carolina Farias Ferreira Moretto', N'Negros', 98.14, 0, 98.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1534, N'10077393', N' Gustavo de Almeida Ferreira', N'Negros', 98.11, 0, 98.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1535, N'10007528', N' Lucas Henrique Rosa do Nascimento', N'Negros', 98.02, 0, 98.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1536, N'10037198', N' Ewerton Cruz Soares', N'Negros', 96.77, 0, 96.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1537, N'10058676', N' Rafael Pereira Felix', N'Negros', 96.29, 0, 96.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1538, N'10023979', N' Ana Carolina Angelo Passos', N'Negros', 96.13, 0, 96.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1539, N'10045660', N' Jackellyne Jenyffer Ferreira dos Santos', N'Negros', 96.1, 0, 96.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1540, N'10002718', N' Kassia Karolliny Ribeiro Camilo', N'Negros', 95.47, 0, 95.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1541, N'10025529', N' Beatriz Lisboa Veras', N'Negros', 95.36, 0, 95.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1542, N'10041187', N' Gleodes Victor Duarte de Souza', N'Negros', 95.28, 0, 95.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1543, N'10095054', N' Matheus Pereira Mendes', N'Negros', 95.25, 0, 95.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1544, N'10016351', N' Moises de Almeida Bastos', N'Negros', 95.17, 0, 95.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1545, N'10040610', N' Raphael Felipe de Moura dos Santos', N'Negros', 94.99, 0, 94.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1546, N'10049134', N' Loise Kelem Oliveira da Hora', N'Negros', 94.98, 0, 94.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1547, N'10032162', N' Leonardo de Melo Brito Junior', N'Negros', 94.92, 0, 94.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1548, N'10002311', N' Fernanda Viana de Morais', N'Negros', 94.85, 0, 94.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1549, N'10044432', N' Barbara Amanda Agustinho daSilva', N'Negros', 94.84, 0, 94.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1550, N'10032796', N' Tiago Spindula Ferreira', N'Negros', 94.78, 0, 94.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1551, N'10060163', N' Daniel Barrozo Lima', N'Negros', 94.54, 0, 94.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1552, N'10008416', N' Alisson Carlos Martins Felipe', N'Negros', 94.18, 0, 94.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1553, N'10020468', N' Guilherme de Oliveira Santana', N'Negros', 93.73, 0, 93.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1554, N'10006816', N' Wesley dos Santos', N'Negros', 93.54, 0, 93.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1555, N'10078027', N' Geovani Urder de Andrade Aquino', N'Negros', 93.54, 0, 93.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1556, N'10030677', N' Lenin Andrade de Souza Cerqueira', N'Negros', 93.54, 0, 93.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1557, N'10073282', N' Douglas Antunis dos Santos', N'Negros', 93.33, 0, 93.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1558, N'10018218', N' Lucas Neves Cardoso', N'Negros', 93.07, 0, 93.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1559, N'10033541', N' Aline Mourao de Abreu', N'Negros', 92.97, 0, 92.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1560, N'10064698', N'Tulio Andre Pereira de Oliveira', N'Negros', 92.74, 0, 92.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1561, N'10060246', N' Joao Paulo de Sousa', N'Negros', 92.41, 0, 92.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1562, N'10041872', N'Andressa Trindade de Lima', N'Negros', 92.38, 0, 92.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1563, N'10011949', N' Igo Ferreira de Oliveira', N'Negros', 92.29, 0, 92.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1564, N'10045061', N' ElisonRodrigues Carvalho dos Santos', N'Negros', 92.04, 0, 92.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1565, N'10065059', N' Jaine de Sousa Maciel', N'Negros', 91.88, 0, 91.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1566, N'10018823', N'Allisson Cardoso Ferreira', N'Negros', 91.88, 0, 91.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1567, N'10004041', N' Marlon Danilo da Silva', N'Negros', 91.84, 0, 91.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1568, N'10090385', N' JulleyOliveira Alencar', N'Negros', 91.8, 0, 91.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1569, N'10007233', N' Brendo Augusto dos Santos Tertuliano', N'Negros', 91.64, 0, 91.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1570, N'10094893', N'Eunice Vitorio de Oliveira', N'Negros', 91.6, 0, 91.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1571, N'10094212', N' Vinicius Drummond Silva Araujo', N'Negros', 91.6, 0, 91.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1572, N'10048431', N'Jonatan Almeida Custodio', N'Negros', 91.51, 0, 91.51)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1573, N'10091260', N' Marcelo Hipolito Dantas de Souza', N'Negros', 91.45, 0, 91.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1574, N'10037712', N'Jaira Decia Conceicao Lima', N'Negros', 91.37, 0, 91.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1575, N'10008635', N' Larissa Paes Landim Alves', N'Negros', 90.82, 0, 90.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1576, N'10025618', N' Thiagodos Santos Silva', N'Negros', 90.6, 0, 90.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1577, N'10070700', N' Marilia Parreira', N'Negros', 90.49, 0, 90.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1578, N'10083595', N' Mateus Barbosa Souza', N'Negros', 90.47, 0, 90.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1579, N'10086877', N' Guilherme Fernandes Souza', N'Negros', 90.15, 0, 90.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1580, N'10040206', N' Bruno Garcia Santana', N'Negros', 89.93, 0, 89.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1581, N'10023195', N' Andre Felipe da Rocha de Souza', N'Negros', 89.88, 0, 89.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1582, N'10037162', N' Guilherme Pinto Ribeiro', N'Negros', 89.73, 0, 89.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1583, N'10010280', N' Mauricio Brayan Cruz Alves Martins', N'Negros', 89.54, 0, 89.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1584, N'10057796', N' Lucas Vieira dos Santos', N'Negros', 89.37, 0, 89.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1585, N'10018343', N' Matheus Silva Gomes', N'Negros', 89.11, 0, 89.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1586, N'10003876', N' Alyne de Morais Santiago Gaia', N'Negros', 89.01, 0, 89.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1587, N'10099142', N' Francisco Adail Inacio de Sousa Junior', N'Negros', 88.94, 0, 88.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1588, N'10034241', N' Bruno Nunes Teixeira Ferreira', N'Negros', 88.94, 0, 88.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1589, N'10072473', N' Rodrigo de Melo Pereira do Nascimento Costa', N'Negros', 88.89, 0, 88.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1590, N'10003305', N' Florinda JoseNogueira', N'Negros', 88.86, 0, 88.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1591, N'10007435', N' Daniel Lima das Virgens Ferreira', N'Negros', 88.85, 0, 88.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1592, N'10060188', N' Glenda GomesSilva Frank', N'Negros', 88.72, 0, 88.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1593, N'10005655', N' Ulisses Antonio Pereira', N'Negros', 88.68, 0, 88.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1594, N'10084488', N' Bruno Leonardo daConceicao Facanha', N'Negros', 88.56, 0, 88.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1595, N'10003385', N' Adriana Luiza de Albuquerque Brito', N'Negros', 88.54, 0, 88.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1596, N'10091226', N'Catiana Silveira de Souza Araujo', N'Negros', 88.5, 0, 88.5)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1597, N'10013643', N' Weslen Ribeiro de Oliveira', N'Negros', 88.48, 0, 88.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1598, N'10050965', N'Eduardo Dias de Oliveira Rosa', N'Negros', 88.24, 0, 88.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1599, N'10059764', N' Vinicius dos Anjos Rodrigues', N'Negros', 88.16, 0, 88.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1600, N'10047483', N'Taiane Baptista Goncalves', N'Negros', 88.12, 0, 88.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1601, N'10023301', N' Gesomar Rodrigues de Franca', N'Negros', 88.05, 0, 88.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1602, N'10020302', N'Monica Lins dos Santos', N'Negros', 87.92, 0, 87.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1603, N'10038743', N' Larissa da Silva Marques', N'Negros', 87.86, 0, 87.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1604, N'10031501', N' BrunoSouza dos Reis', N'Negros', 87.81, 0, 87.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1605, N'10020336', N' Marlos Angelo Silva Quirino', N'Negros', 87.56, 0, 87.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1606, N'10030842', N' Lucas Fonsecada Silva', N'Negros', 87.56, 0, 87.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1607, N'10003357', N' Victor Eduardo Menezes de Freitas', N'Negros', 87.14, 0, 87.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1608, N'10023349', N' Emanuella Cunha de Barros Raposo Carneiro Lins', N'Negros', 87.09, 0, 87.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1609, N'10066197', N' Victor Augusto Machado da Silva Andrade', N'Negros', 86.95, 0, 86.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1610, N'10065339', N' Pedro Cesar Queiroz da Silva', N'Negros', 86.9, 0, 86.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1611, N'10090583', N' Silvaldo Quirino Tavares', N'Negros', 86.82, 0, 86.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1612, N'10052453', N' Daniel Barbosa de Sousa', N'Negros', 86.82, 0, 86.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1613, N'10040042', N' Ludimila de Oliveira Felix', N'Negros', 86.7, 0, 86.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1614, N'10009617', N' Peterson da Cunha Estevan Costa', N'Negros', 86.66, 0, 86.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1615, N'10063145', N' Rodolfo Alves Nascimento', N'Negros', 86.62, 0, 86.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1616, N'10013837', N' Anderson Dutra Almeida', N'Negros', 86.45, 0, 86.45)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1617, N'10016719', N' Welton Silva de Oliveira Pires', N'Negros', 86.32, 0, 86.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1618, N'10023938', N' Renan Aruil de Sousa', N'Negros', 86.32, 0, 86.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1619, N'10052126', N' Leonardo Pereira Dalmeida Franca', N'Negros', 86.31, 0, 86.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1620, N'10063058', N' Eloiza da Silva Pinheiro', N'Negros', 86.3, 0, 86.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1621, N'10052747', N' Carolina Gomes dos Santos', N'Negros', 86.3, 0, 86.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1622, N'10002778', N' Marcelo Henrique da Silva Oliveira', N'Negros', 86.3, 0, 86.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1623, N'10077837', N' Lucas Vinicius Diniz Prado', N'Negros', 86.22, 0, 86.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1624, N'10010498', N' Alisson Bruno Milanez Barros', N'Negros', 86.11, 0, 86.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1625, N'10021577', N' Ingrid Lorena de Oliveira SilvaMarques', N'Negros', 86, 0, 86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1626, N'10046871', N' Renato Carvalho de Souza', N'Negros', 85.99, 0, 85.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1627, N'10004955', N' Keyla do NascimentoRocha', N'Negros', 85.93, 0, 85.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1628, N'10055315', N' Givanildo Barbosa Leal', N'Negros', 85.82, 0, 85.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1629, N'10024503', N' Leia Pereira de Brito', N'Negros', 85.82, 0, 85.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1630, N'10001603', N' Aluizio de Sousa Lustosa', N'Negros', 85.8, 0, 85.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1631, N'10047490', N' Mario Junior Mendes da Silva', N'Negros', 85.79, 0, 85.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1632, N'10057345', N' Edson Vieira de Morais', N'Negros', 85.73, 0, 85.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1633, N'10038003', N' Kessy Diego Ribeiro Maia de Carvalho', N'Negros', 85.57, 0, 85.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1634, N'10048023', N' Ulisses Alves da Conceicao', N'Negros', 85.56, 0, 85.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1635, N'10043029', N' Mayara Araujo Mendes', N'Negros', 85.48, 0, 85.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1636, N'10064825', N' Fernanda Silva do Nascimento', N'Negros', 85.46, 0, 85.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1637, N'10006354', N' Hebert Jorge Nunes da SilvaMachado', N'Negros', 85.37, 0, 85.37)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1638, N'10082887', N' Wanderson Gomes dos Santos', N'Negros', 85.27, 0, 85.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1639, N'10086072', N' Lucas Florenciodos Santos Sampaio', N'Negros', 85.1, 0, 85.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1640, N'10035276', N' Barbara Araujo Moura', N'Negros', 85.09, 0, 85.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1641, N'10018231', N' DevistonAzeredo Silva', N'Negros', 85.07, 0, 85.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1642, N'10007828', N' Lucas Araujo de Sa', N'Negros', 85.05, 0, 85.05)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1643, N'10053117', N' Jorge Waschington doCarmo Junior', N'Negros', 84.95, 0, 84.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1644, N'10035604', N' Jeferson Jesus de Aragao', N'Negros', 84.94, 0, 84.94)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1645, N'10072113', N' Elton da SilvaCandido', N'Negros', 84.9, 0, 84.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1646, N'10008104', N' Dionisio Bispo de Oliveira Neto', N'Negros', 84.89, 0, 84.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1647, N'10049338', N' Gustavo AraujoLopes da Silva', N'Negros', 84.86, 0, 84.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1648, N'10006667', N' Reisval da Silva Pereira Figueiredo', N'Negros', 84.82, 0, 84.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1649, N'10050769', N' LeoneBraga Teixeira', N'Negros', 84.72, 0, 84.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1650, N'10029181', N' Hellen Pereira Santos', N'Negros', 84.71, 0, 84.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1651, N'10040086', N' Jessica de OrnelisBorges', N'Negros', 84.57, 0, 84.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1652, N'10077333', N' Jonathan Goncalves Dutra de Souza', N'Negros', 84.46, 0, 84.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1653, N'10063532', N' EdilenePereira de Oliveira', N'Negros', 84.4, 0, 84.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1654, N'10034605', N' Marcelo Candido Pereira Lopes', N'Negros', 84.32, 0, 84.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1655, N'10069241', N' RockNey Gomes dos Santos Junior', N'Negros', 84.17, 0, 84.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1656, N'10030433', N' Sueli Rodrigues Louzeiro', N'Negros', 84.09, 0, 84.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1657, N'10045133', N'Luan Sousa Dias Nogueira', N'Negros', 84.08, 0, 84.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1658, N'10089922', N' Luiz Ricardo Santana Neres', N'Negros', 83.96, 0, 83.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1659, N'10020164', N'Fernando Nascimento dos Santos', N'Negros', 83.75, 0, 83.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1660, N'10093803', N' Rodrigo de Almeida Romar', N'Negros', 83.71, 0, 83.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1661, N'10030724', N' Andressa Virginia Vieira Silva', N'Negros', 83.71, 0, 83.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1662, N'10052326', N' Leandro Amaral da Fonseca', N'Negros', 83.7, 0, 83.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1663, N'10064220', N' Aline Mendonca Batista Pister', N'Negros', 83.65, 0, 83.65)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1664, N'10013620', N' Magno Pires Cunha', N'Negros', 83.61, 0, 83.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1665, N'10051869', N' Daniele da Silva Rocha', N'Negros', 83.6, 0, 83.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1666, N'10027536', N' Sandoval Santana Meira Junior', N'Negros', 83.59, 0, 83.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1667, N'10025059', N' Iara Ferreira Barbosa', N'Negros', 83.58, 0, 83.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1668, N'10018902', N' Kelly Cruz da Silva', N'Negros', 83.57, 0, 83.57)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1669, N'10020423', N'Guilherme Vieira da Silva', N'Negros', 83.56, 0, 83.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1670, N'10003454', N' Izabelle Dias Silva', N'Negros', 83.48, 0, 83.48)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1671, N'10069922', N' Alan Moreirada Silva', N'Negros', 83.35, 0, 83.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1672, N'10036470', N' Sidney da Silva de Oliveira', N'Negros', 83.32, 0, 83.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1673, N'10078093', N' Cleber de MouraTavares', N'Negros', 83.31, 0, 83.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1674, N'10029717', N' Nara Nubia Silva de Araujo', N'Negros', 83.3, 0, 83.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1675, N'10005733', N' Thales Junior Moreirada Silva', N'Negros', 83.02, 0, 83.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1676, N'10028990', N' Vanessa Del Papa de Lacerda', N'Negros', 82.97, 0, 82.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1677, N'10020297', N' Fabio de AlmeidaSoares', N'Negros', 82.95, 0, 82.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1678, N'10027422', N' Vinicius da Silva Costa', N'Negros', 82.93, 0, 82.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1679, N'10020366', N' Ana Gabriele FereiraGoncalves', N'Negros', 82.91, 0, 82.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1680, N'10100456', N' Monique Nascimento de Oliveira', N'Negros', 82.9, 0, 82.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1681, N'10037069', N' Higor NunesAzevedo', N'Negros', 82.84, 0, 82.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1682, N'10045130', N' Felix Barbalho Neiva Junior', N'Negros', 82.79, 0, 82.79)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1683, N'10024099', N' Edinaldo da SilvaSantos', N'Negros', 82.78, 0, 82.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1684, N'10055868', N' Felipe Rogerio de Oliveira', N'Negros', 82.52, 0, 82.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1685, N'10022721', N' Marcos AlexandreSperandio Sabino', N'Negros', 82.39, 0, 82.39)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1686, N'10061982', N' Bruno Johnson dos Santos Lima', N'Negros', 82.35, 0, 82.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1687, N'10006438', N' LauraRibeiro Lopes', N'Negros', 82.3, 0, 82.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1688, N'10032890', N' Tauan Moncores Duarte', N'Negros', 82.29, 0, 82.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1689, N'10024958', N' Diego SantosMoura', N'Negros', 82.16, 0, 82.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1690, N'10078318', N' Clayton Rosa', N'Negros', 82.16, 0, 82.16)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1691, N'10016002', N' Ana Paula Oliveira Nascimento', N'Negros', 82.1, 0, 82.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1692, N'10031997', N' Ronaldo Fernandes Branco Jr', N'Negros', 82.02, 0, 82.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1693, N'10075924', N' Tiago Silva Anunciacao', N'Negros', 81.99, 0, 81.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1694, N'10103286', N' Gabriel da Silva Pascoal', N'Negros', 81.97, 0, 81.97)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1695, N'10092524', N' Leticia Araujo Figueiredo', N'Negros', 81.92, 0, 81.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1696, N'10046789', N' Michael Ferreira Alves Lima', N'Negros', 81.91, 0, 81.91)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1697, N'10073563', N' Lucas dos Santos Correia', N'Negros', 81.9, 0, 81.9)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1698, N'10054039', N' Andre Luiz de Oliveira Barros', N'Negros', 81.87, 0, 81.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1699, N'10019378', N' Thiago Fernandes Caldas Souza', N'Negros', 81.82, 0, 81.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1700, N'10028703', N' Luis Fernando Alves da Silva', N'Negros', 81.8, 0, 81.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1701, N'10026453', N' Leandro da Silva Lima', N'Negros', 81.7, 0, 81.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1702, N'10101769', N' Bruno Rafael Martins Pereira', N'Negros', 81.69, 0, 81.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1703, N'10067590', N' Alef Ferreira da Silva', N'Negros', 81.64, 0, 81.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1704, N'10030055', N' Fernando Magalhaes de Paulo', N'Negros', 81.62, 0, 81.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1705, N'10029833', N' Luisa Mansur Ferreira', N'Negros', 81.49, 0, 81.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1706, N'10084258', N' Alexsandro Lima Rocha', N'Negros', 81.38, 0, 81.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1707, N'10060388', N' Jessia Marcia Ferreira Silva', N'Negros', 81.25, 0, 81.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1708, N'10007488', N' Andressa Santos de Souza', N'Negros', 81.23, 0, 81.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1709, N'10075990', N' Max Macedo Cavalcante', N'Negros', 81.21, 0, 81.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1710, N'10087909', N' Jessica Sales Lemes', N'Negros', 81.2, 0, 81.2)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1711, N'10052921', N' Gabryella Alves da Silva', N'Negros', 81.18, 0, 81.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1712, N'10010823', N' Rayan Lucas Maranhao de Sousa', N'Negros', 81.13, 0, 81.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1713, N'10070881', N' Winston Luiz Prado de Sousa', N'Negros', 81.04, 0, 81.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1714, N'10000296', N' Jonas Costa David', N'Negros', 81.03, 0, 81.03)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1715, N'10047237', N' Aristides dos Reis Pereira', N'Negros', 80.88, 0, 80.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1716, N'10028803', N'Carolaine Pinto Soares', N'Negros', 80.75, 0, 80.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1717, N'10035056', N' Samara Costa de Sousa', N'Negros', 80.75, 0, 80.75)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1718, N'10011825', N' MarcioAlan Souza Figueiredo', N'Negros', 80.62, 0, 80.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1719, N'10018402', N' Beiany Araujo Costa', N'Negros', 80.61, 0, 80.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1720, N'10071476', N' JuscelinoCordeiro de Araujo Filho', N'Negros', 80.59, 0, 80.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1721, N'10077254', N' George de Araujo Santos', N'Negros', 80.52, 0, 80.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1722, N'10002815', N' DanielAlves Pereira', N'Negros', 80.42, 0, 80.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1723, N'10036430', N' Ednei da Conceicao Sousa', N'Negros', 80.36, 0, 80.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1724, N'10071099', N' Denise de Jesusdo Nascimento', N'Negros', 80.36, 0, 80.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1725, N'10043833', N' Dyego Jardim Mendonca', N'Negros', 80.32, 0, 80.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1726, N'10048680', N' Joao Pedro de Oliveira Alves de Castro', N'Negros', 80.31, 0, 80.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1727, N'10100199', N' Caio Cristhyan dos Santos Carvalho Silva', N'Negros', 80.23, 0, 80.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1728, N'10001027', N' Igor Marinho Santos', N'Negros', 80.21, 0, 80.21)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1729, N'10081467', N' Francilene Alves dos Santos', N'Negros', 80.14, 0, 80.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1730, N'10004549', N' Filipe Rhaony Araujo de Siqueira Dantas', N'Negros', 80.12, 0, 80.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1731, N'10073094', N' Edson Willy Cirqueira de Oliveira', N'Negros', 80.12, 0, 80.12)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1732, N'10094773', N' Irene Teixeira dos Santos***', N'Negros', 80.11, 0, 80.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1733, N'10017381', N' Marcos HeberthSoares da Silva', N'Negros', 80.02, 0, 80.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1734, N'10016741', N' Mayara Serrano da Cunha Santos', N'Negros', 80.01, 0, 80.01)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1735, N'10059729', N' EduardoReis Pacheco', N'Negros', 79.96, 0, 79.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1736, N'10059906', N' Mario Henrique Menezes Santos', N'Negros', 79.86, 0, 79.86)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1737, N'10068470', N' ThiagoCosta Marques', N'Negros', 79.83, 0, 79.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1738, N'10013710', N' Mayara Alves Barbosa Neres', N'Negros', 79.82, 0, 79.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1739, N'10033122', N' MarceloMartins dos Santos', N'Negros', 79.76, 0, 79.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1740, N'10029207', N' Deivid Barbosa dos Santos', N'Negros', 79.74, 0, 79.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1741, N'10025940', N' JessycaLenne Ramos Chagas', N'Negros', 79.74, 0, 79.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1742, N'10001273', N' Ana Eloisa Pereira Lopes da Silva', N'Negros', 79.72, 0, 79.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1743, N'10005985', N'Gilvan Cupertino dos Santos', N'Negros', 79.63, 0, 79.63)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1744, N'10023537', N' Caio Kelvin dos Santos Melo', N'Negros', 79.61, 0, 79.61)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1745, N'10075236', N' Nayara Elaine Alves da Costa', N'Negros', 79.47, 0, 79.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1746, N'10109325', N' Maria Fabricia Thayz Alves Cunha', N'Negros', 79.3, 0, 79.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1747, N'10108512', N' Adriano Reis dos Santos', N'Negros', 79.18, 0, 79.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1748, N'10055087', N' Talita da Cunha Sousa***', N'Negros', 79.18, 0, 79.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1749, N'10076635', N' Josafa Goncalves dos Santos', N'Negros', 79.18, 0, 79.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1750, N'10088473', N' Alexandre Martins Barbosa', N'Negros', 79.15, 0, 79.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1751, N'10006335', N' Claudio Francisco dos Santos', N'Negros', 78.98, 0, 78.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1752, N'10111689', N' Vitor Rodrigues Silva de Souza', N'Negros', 78.93, 0, 78.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1753, N'10040988', N' Diego Mayer Viana Rocha', N'Negros', 78.84, 0, 78.84)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1754, N'10034013', N' Marianny Rosa Fernandes Ramos', N'Negros', 78.82, 0, 78.82)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1755, N'10063215', N' Alan Klinsmann Sousa Ferreira', N'Negros', 78.8, 0, 78.8)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1756, N'10019747', N' Joabson AlexandreMarques de Castro', N'Negros', 78.78, 0, 78.78)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1757, N'10011375', N' Rodrigo Carneiro de Melo', N'Negros', 78.68, 0, 78.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1758, N'10028136', N' LeandroRocha da Silva', N'Negros', 78.62, 0, 78.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1759, N'10015831', N' Aylana Patricia Rodrigues Costa', N'Negros', 78.53, 0, 78.53)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1760, N'10080963', N' JoaoHeverton de Jesus Nunes', N'Negros', 78.32, 0, 78.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1761, N'10057957', N' Leandro Ferreira da Mata', N'Negros', 78.24, 0, 78.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1762, N'10075154', N'Thiago Macedo de Carvalho', N'Negros', 78.17, 0, 78.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1763, N'10024367', N' Jemisson Rocha dos Santos', N'Negros', 78.11, 0, 78.11)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1764, N'10022927', N'Rafaela Cristina Magalhaes Gomes', N'Negros', 78.02, 0, 78.02)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1765, N'10045928', N' Lanaira Rodrigues da Silva', N'Negros', 77.85, 0, 77.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1766, N'10047981', N' Fabiula Sousa Tito', N'Negros', 77.74, 0, 77.74)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1767, N'10072068', N' Ananda Ramaiana Barbosa da Gama', N'Negros', 77.7, 0, 77.7)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1768, N'10011370', N' Rodrigo Pires Teodoro', N'Negros', 77.69, 0, 77.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1769, N'10026510', N' Maria do Socorro Rodrigues Barbosa', N'Negros', 77.68, 0, 77.68)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1770, N'10001718', N' Leandro dos Santos Sousa', N'Negros', 77.62, 0, 77.62)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1771, N'10072941', N' Amanda Menezes Silva do NascimentoAngelim', N'Negros', 77.49, 0, 77.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1772, N'10040412', N' Emerson Vieira dos Santos', N'Negros', 77.4, 0, 77.4)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1773, N'10096003', N' Gabriela Farias deSouza', N'Negros', 77.36, 0, 77.36)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1774, N'10086700', N' Jemerson de Carvalho Silva', N'Negros', 77.3, 0, 77.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1775, N'10057921', N' Danillo Cordeiro dosSantos de Santana', N'Negros', 77.26, 0, 77.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1776, N'10034215', N' Davidson Costa dos Santos', N'Negros', 76.89, 0, 76.89)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1777, N'10032346', N' RayssonNogueira dos Santos', N'Negros', 76.66, 0, 76.66)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1778, N'10039747', N' Pedro Henrique Mota de Azevedo', N'Negros', 76.59, 0, 76.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1779, N'10064001', N'Saulo Yuri Oliveira Santos', N'Negros', 76.52, 0, 76.52)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1780, N'10033322', N' Renato Melo dos Santos', N'Negros', 76.46, 0, 76.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1781, N'10054983', N' SuzanaMarques Brandao Santos', N'Negros', 76.27, 0, 76.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1782, N'10032914', N' Greicy Kelly Pereira de Souza', N'Negros', 76.22, 0, 76.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1783, N'10024057', N'Yan Lucca Souza Amorim', N'Negros', 76.18, 0, 76.18)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1784, N'10093720', N' Tiago Lima Paraizo', N'Negros', 75.56, 0, 75.56)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1785, N'10060875', N' GeraldoMatias Junior', N'Negros', 75.41, 0, 75.41)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1786, N'10030164', N' Carlos Rafael Bessa da Silva', N'Negros', 75.34, 0, 75.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1787, N'10081471', N' GuilhermeHenrique Rodrigues Rabelo', N'Negros', 75.34, 0, 75.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1788, N'10031030', N' Rebeca Lima Oliveira', N'Negros', 75.33, 0, 75.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1789, N'10059450', N'Thayrine dos Santos Fagundes', N'Negros', 75.23, 0, 75.23)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1790, N'10003224', N' Raphael Oliveira dos Santos', N'Negros', 74.88, 0, 74.88)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1791, N'10017260', N' Thiago Santos de Sousa', N'Negros', 74.85, 0, 74.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1792, N'10010102', N' Yasmin da Fonseca Santos', N'Negros', 74.6, 0, 74.6)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1848, N'10001563', N' Miriam Roisman', N'SJ', 111.77, 0, 111.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1849, N'10051049', N' Fernanda Duarte Franca de Castro', N'SJ', 104.3, 0, 104.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1850, N'10027532', N' Mateus do Carmo Cunha', N'SJ', 101.72, 0, 101.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1851, N'10009533', N' Karen Cristine Moreno de Medeiros Carvalho', N'SJ', 101.3, 0, 101.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1852, N'10081019', N' Danilo Santiago Barbosa Silva', N'SJ', 100.38, 0, 100.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1853, N'10056397', N' Nayara dosSantos Siqueira', N'SJ', 100.34, 0, 100.34)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1854, N'10081568', N' Alane Goncalves Vieira', N'SJ', 99.28, 0, 99.28)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1855, N'10048061', N' Jose CastanheiraClemente', N'SJ', 99.27, 0, 99.27)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1856, N'10006952', N' Leonardo Esteves Ferreira Mendes', N'SJ', 98.96, 0, 98.96)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1857, N'10025783', N' MarcoThulio Silva Costa**', N'SJ', 98.83, 0, 98.83)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1858, N'10046410', N' Nilo Laercio de Abreu dos Santos', N'SJ', 98.55, 0, 98.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1859, N'10001972', N'Lilian de Souza Carvalho', N'SJ', 98.26, 0, 98.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1860, N'10053678', N' Deyse Gisele Rodrigues de Oliveira', N'SJ', 97.71, 0, 97.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1861, N'10068142', N' Leandro Ribas Neves', N'SJ', 97.42, 0, 97.42)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1862, N'10009821', N' Angelo Salvio Mendonca Negrao', N'SJ', 96.64, 0, 96.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1863, N'10081325', N' Allan Leandro Bezerra do Nascimento', N'SJ', 96.14, 0, 96.14)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1864, N'10024749', N' Bruno Chaves Ferreira Lima', N'SJ', 94.85, 0, 94.85)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1865, N'10034482', N' Wesley de Oliveira Chaves', N'SJ', 94.69, 0, 94.69)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1866, N'10002309', N' Ana Paula Resende', N'SJ', 94.46, 0, 94.46)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1867, N'10005134', N' Erick Tavares de Abreu', N'SJ', 94.22, 0, 94.22)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1868, N'10006611', N' Luisa Defranco Ferreira Peconick', N'SJ', 93.71, 0, 93.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1869, N'10055705', N' Camilla Rinaldi de Oliveira', N'SJ', 93.26, 0, 93.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1870, N'10000220', N' Henrique Alves Brito Sousa de Melo', N'SJ', 92.95, 0, 92.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1871, N'10071526', N' Igor Gabriel Tinoco Gerardin Poirot Land', N'SJ', 92.81, 0, 92.81)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1872, N'10052874', N' Pedro de Paula Filho', N'SJ', 92.59, 0, 92.59)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1873, N'10006067', N' Claudio Pereira dos Santos Filho', N'SJ', 92.07, 0, 92.07)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1874, N'10007167', N' Joao Augusto M deMagalhaes', N'SJ', 91.95, 0, 91.95)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1875, N'10039654', N' Joao Paulo Vaz Mendes', N'SJ', 91.92, 0, 91.92)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1876, N'10023871', N' Leonardo Ayres Simide Camargo', N'SJ', 91.77, 0, 91.77)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1877, N'10089575', N' Marcelo Goncalves Moura', N'SJ', 91.72, 0, 91.72)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1878, N'10061353', N' Mariana de AvilaPalhares', N'SJ', 91.64, 0, 91.64)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1879, N'10030392', N' Jessica Piva', N'SJ', 91.35, 0, 91.35)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1880, N'10083405', N' Eduardo Clemente', N'SJ', 91.32, 0, 91.32)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1881, N'10060996', N' Rebecca Araujo Viana', N'SJ', 91.09, 0, 91.09)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1882, N'10048862', N' Erika Helena Bomfim dos Santos', N'SJ', 90.93, 0, 90.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1883, N'10021806', N' Priscila Isaias da Silva', N'SJ', 90.29, 0, 90.29)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1884, N'10075101', N' Vanessa Vitalino', N'SJ', 90.15, 0, 90.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1885, N'10010342', N'Juliana Bona de Faria Pinto', N'SJ', 90.13, 0, 90.13)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1886, N'10065837', N' Daniel Torres Carvello', N'SJ', 90.1, 0, 90.1)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1887, N'10092392', N' JeanRodrigues Cardoso Santana', N'SJ', 89.93, 0, 89.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1888, N'10105692', N' Geovana Callasans Veras Pessoa', N'SJ', 88.54, 0, 88.54)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1889, N'10040019', N' Caio Magno Mendonca dos Santos', N'SJ', 86.58, 0, 86.58)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1890, N'10013060', N' Jose Alencar Lins da Cunha', N'SJ', 86.33, 0, 86.33)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1891, N'10020092', N' Bruna Caroline Nascimento Messias', N'SJ', 86.25, 0, 86.25)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1892, N'10014946', N' Diego dos Santos Tavares', N'SJ', 86.17, 0, 86.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1893, N'10031879', N' Clovis Rodrigues Pereira Neto', N'SJ', 86.08, 0, 86.08)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1894, N'10010063', N' Rafaela Balliana Bragancade Vasconcelos', N'SJ', 85.55, 0, 85.55)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1895, N'10055324', N' Caio Vieira Florindo*', N'SJ', 73.17, 0, 73.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1896, N'10058713', N' Carlos DanilloCosta Santos*', N'SJ', 71.98, 0, 71.98)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1897, N'10027609', N' Marina Lemes de Carvalho*', N'SJ', 70.15, 0, 70.15)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1898, N'10042565', N' JacquelineNeves de Souza*', N'SJ', 68.17, 0, 68.17)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1899, N'10020313', N' Fatima de Oliveira Jorge Campos*', N'SJ', 67.47, 0, 67.47)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1900, N'10058270', N'Renata Ayres Costa*', N'SJ', 66.76, 0, 66.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1901, N'10056434', N' Lucas Campolina Barbosa Melo*', N'SJ', 65.24, 0, 65.24)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1902, N'10081019', N' Danilo Santiago Barbosa Silva', N'SJNegros', 100.38, 0, 100.38)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1903, N'10001972', N' Lilian de Souza Carvalho', N'SJNegros', 98.26, 0, 98.26)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1904, N'10048862', N' Erika Helena Bomfim dos Santos', N'SJNegros', 90.93, 0, 90.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1905, N'10092392', N' Jean Rodrigues Cardoso Santana', N'SJNegros', 89.93, 0, 89.93)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1906, N'10040385', N' Filipe dos Santos Brandao', N'SJNegros', 87.31, 0, 87.31)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1907, N'10079120', N' Keila Moldes de Menezes', N'SJNegros', 85.3, 0, 85.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1908, N'10063633', N' Rebeca das Dores Lopes', N'SJNegros', 83.49, 0, 83.49)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1909, N'10040572', N' Gabriel de Paula Lima', N'SJNegros', 82.99, 0, 82.99)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1910, N'10050225', N' Rafael de Souza Duarte', N'SJNegros', 81.3, 0, 81.3)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1911, N'10038540', N' Danniel Reis de Oliveira', N'SJNegros', 80.76, 0, 80.76)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1912, N'10037339', N' Anderson Christian Barbosa Apostolo', N'SJNegros', 80.71, 0, 80.71)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1913, N'10052148', N' Rene Rodrigues Ferreira Batistados Santos', N'SJNegros', 79.04, 0, 79.04)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1914, N'10018479', N' Anselmo Oliveira', N'SJNegros', 75.87, 0, 75.87)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1915, N'10100179', N' Zenilton Galvao Nunes', N'SJNegros', 75.73, 0, 75.73)
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal]) VALUES (1916, N'10016220', N' Carlos Vinicius Alves Matos', N'SJNegros', 74.55, 0, 74.55)
        GO
        SET IDENTITY_INSERT [dbo].[Aluno] OFF
        GO




        ");
    }

    public override void Down()
    {
    }
  }
}
