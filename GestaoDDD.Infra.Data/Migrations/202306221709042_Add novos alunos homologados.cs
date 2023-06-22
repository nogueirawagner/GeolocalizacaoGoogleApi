namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class Addnovosalunoshomologados : DbMigration
  {
    public override void Up()
    {
      Sql("delete from Aluno");
      Sql(@"

          SET IDENTITY_INSERT [dbo].[Aluno] ON 
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1919, N'10002237', N' Felipe Santos Magnani Carneiro ', N'Ampla', 121.12, 0, 121.12, 1)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1920, N'10019208', N' Marissol Silva Pontes ', N'PCD', 87.91, 0, 87.91, 1)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1921, N'10039605', N' Lays Venancio Lira ', N'PCD', 82.24, 0, 82.24, 2)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1922, N'10001286', N' Guilherme Augusto da Silva Bertaci ', N'Ampla', 117.81, 0, 117.81, 2)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1923, N'10061041', N' Jeancarlos da Silva Junior ', N'Ampla', 116.71, 0, 116.71, 3)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1924, N'10034800', N' Leonardo Romao Batista ', N'PCD', 81.26, 0, 81.26, 3)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1925, N'10054671', N' Gisele Silva Santos ', N'PCD', 78.81, 0, 78.81, 4)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1926, N'10060642', N' Gustavo Gualda Goncalves ', N'Ampla', 116.7, 0, 116.7, 4)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1927, N'10071520', N' Simone Freitas da Silva ', N'PCD', 77.61, 0, 77.61, 5)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1928, N'10032786', N' Renata Martino Caldeira ', N'Ampla', 116.34, 0, 116.34, 5)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1929, N'10035714', N' Pedro Hideu Iamada ', N'Ampla', 115.03, 0, 115.03, 6)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1930, N'10030585', N' Thiago Leao Pires ', N'PCD', 76.77, 0, 76.77, 6)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1931, N'10066211', N' Samara Alves de Oliveira Familiar ', N'PCD', 75.32, 0, 75.32, 7)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1932, N'10013978', N' Thaiane Vanessa Meira Nascente dos Santos ', N'Ampla', 113.84, 0, 113.84, 7)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1933, N'10044511', N' Thallita Raquel da Silva Mendes ', N'Ampla', 113.37, 0, 113.37, 8)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1934, N'10037805', N' Pablo Matos Cavalcante ', N'PCD', 72.42, 0, 72.42, 8)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1935, N'10024422', N' Eduardo Campos de Jesus ', N'PCD', 71.1, 0, 71.1, 9)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1936, N'10044600', N' Gabriel Lima Silva ', N'Ampla', 112.46, 0, 112.46, 9)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1937, N'10034498', N' Luiz Mauricio Soares de Andrade ', N'Ampla', 112.1, 0, 112.1, 10)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1938, N'10077354', N' Elaine de Azevedo Ribas ', N'PCD', 70.74, 0, 70.74, 10)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1939, N'10023420', N' Jeferson Cardoso Costa ', N'PCD', 69.95, 0, 69.95, 11)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1940, N'10016090', N' Guilherme Mendonca da Silva ', N'Ampla', 111.81, 0, 111.81, 11)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1941, N'10067732', N' Luana Narjara Carvalho dos Santos ', N'PCD', 68.37, 0, 68.37, 12)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1942, N'10026705', N' Anderson Bruno de Andrade Silva ', N'PCD', 68.07, 0, 68.07, 13)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1943, N'10022621', N' Camila Mota Silva ', N'Ampla', 111.62, 0, 111.62, 13)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1944, N'10032216', N' Luis Fernando Serrao Fabio ', N'Ampla', 110.94, 0, 110.94, 14)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1945, N'10040187', N' Thiago Oliveira Bedas', N'PCD', 67.39, 0, 67.39, 14)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1946, N'10022823', N' Roberto Pereira da Silva ', N'PCD', 67.26, 0, 67.26, 15)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1947, N'10026926', N' Thiago Bolelli Costa ', N'Ampla', 110.9, 0, 110.9, 15)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1948, N'10016703', N' Alexandre Oliveira Silva ', N'PCD', 67, 0, 67, 16)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1949, N'10021472', N' Bruno Ali Abou Ali ', N'Ampla', 110.78, 0, 110.78, 16)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1950, N'10006223', N' Isabela Brito Couto de Oliveira ', N'Ampla', 110.07, 0, 110.07, 17)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1951, N'10035302', N' Mario Augusto Paulino de Lima Filho ', N'PCD', 61.05, 0, 61.05, 17)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1952, N'10001524', N' Tamara da Silva Cardoso ', N'PCD', 55.26, 0, 55.26, 18)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1953, N'10072204', N' Eduardo Figueiredo Fialho ', N'Ampla', 109.74, 0, 109.74, 18)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1954, N'10002922', N' Sarah de Oliveira e Silva ', N'Ampla', 109.29, 0, 109.29, 19)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1955, N'10009781', N' Matheus Ulisses Pimenta ', N'Ampla', 109.15, 0, 109.15, 20)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1956, N'10030494', N' Micael Alves de Paula e Silva ', N'Ampla', 108.87, 0, 108.87, 21)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1957, N'10104731', N' Guilherme Henrique Soares Felix ', N'Ampla', 108.78, 0, 108.78, 22)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1958, N'10034214', N' Darlan Ferreira da Silva ', N'Ampla', 108.14, 0, 108.14, 23)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1959, N'10016396', N' Sara Evelin de Sales Oliveira ', N'Ampla', 107.97, 0, 107.97, 24)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1960, N'10004768', N' Lucas Fonseca Davila ', N'Ampla', 107.93, 0, 107.93, 25)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1961, N'10035635', N' Yuri Castello Branco Brito ', N'Ampla', 107.89, 0, 107.89, 26)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1962, N'10000830', N' Robson Rossi Silva de Mesquita ', N'Ampla', 107.87, 0, 107.87, 27)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1963, N'10002143', N' Webert Hudson Araujo Alquimim ', N'Ampla', 107.7, 0, 107.7, 28)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1964, N'10013190', N' Ciro Augusto Coelho de Almeida ', N'Ampla', 107.68, 0, 107.68, 29)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1965, N'10008917', N' Guilherme Pires Saraiva ', N'Ampla', 107.62, 0, 107.62, 30)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1966, N'10060711', N' Leticia Cantuaria Santos ', N'Ampla', 107.54, 0, 107.54, 31)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1967, N'10005025', N' Sabrina Stinghel Soares ', N'Ampla', 107.48, 0, 107.48, 32)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1968, N'10008777', N' Fabiane Cileia Oliveira Soares ', N'Ampla', 107.46, 0, 107.46, 33)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1969, N'10075529', N' Raianne Rocha Amorim ', N'Ampla', 107.39, 0, 107.39, 34)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1970, N'10023608', N' Joao Victor Couto de Resende Silva', N'Ampla', 107.26, 0, 107.26, 35)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1971, N'10026933', N' Edgar Bellini Xavier ', N'Ampla', 107.24, 0, 107.24, 36)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1972, N'10001622', N' Bruno da Silva Coelho ', N'Ampla', 107.2, 0, 107.2, 37)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1973, N'10010781', N' Gabriel Leite Monteiro Fortes ', N'Ampla', 107.16, 0, 107.16, 38)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1974, N'10002252', N' Carolina Rocha Parente ', N'Ampla', 107.11, 0, 107.11, 39)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1975, N'10001243', N' Pedro Gabriel Leobas Maracaipe ', N'Ampla', 107.11, 0, 107.11, 40)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1976, N'10003024', N' Lucas Dadona Chiaradia Braga ', N'Ampla', 106.95, 0, 106.95, 41)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1977, N'10003374', N' Gabriel Cavalcante Rodrigues ', N'Ampla', 106.92, 0, 106.92, 42)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1978, N'10000369', N' Rodrigo Tadeu Meyenberg ', N'Ampla', 106.91, 0, 106.91, 43)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1979, N'10011658', N' Robson Veloso Goes ', N'Ampla', 106.83, 0, 106.83, 44)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1980, N'10064043', N' Luiz Felipe Barbosa Pinheiro ', N'Ampla', 106.83, 0, 106.83, 45)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1981, N'10007155', N' Mateus Carvalho Xavier ', N'Ampla', 106.8, 0, 106.8, 46)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1982, N'10044799', N' Gabriel de Melo Tavares dos Santos ', N'Ampla', 106.78, 0, 106.78, 47)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1983, N'10078202', N' Fernando Henrique Laurenti Zaparoli ', N'Ampla', 106.78, 0, 106.78, 48)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1984, N'10006052', N' Andre Victor Goncales Rodrigues Rios ', N'Ampla', 106.63, 0, 106.63, 49)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1985, N'10025523', N' Humberto Gonczarowska Jorge ', N'Ampla', 106.59, 0, 106.59, 50)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1986, N'10061842', N' Jorge Eduardo Nunes Ribeiro ', N'Ampla', 106.54, 0, 106.54, 51)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1987, N'10026608', N' Arthur Galileu Veleci Tome ', N'Ampla', 106.52, 0, 106.52, 52)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1988, N'10000955', N' Matheus Costa de Freitas ', N'Ampla', 106.5, 0, 106.5, 53)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1989, N'10011108', N' Francinildo Costa Mesquita ', N'Ampla', 106.4, 0, 106.4, 54)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1990, N'10015900', N' Adalice Flavia Duarte de Medeiros ', N'Ampla', 106.39, 0, 106.39, 55)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1991, N'10042228', N' Luthiane Aparecida Silva ', N'Ampla', 106.32, 0, 106.32, 56)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1992, N'10007636', N' Katia de Carvalho Prado ', N'Ampla', 106.32, 0, 106.32, 57)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1993, N'10009660', N' Gun Jo ', N'Ampla', 106.23, 0, 106.23, 58)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1994, N'10007666', N' Bruno Favoretto Silva ', N'Ampla', 106.08, 0, 106.08, 59)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1995, N'10023456', N' Nathallia Franco Santos ', N'Ampla', 106.05, 0, 106.05, 60)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1996, N'10025143', N' Mariana da Silva Novaes ', N'Ampla', 106.02, 0, 106.02, 61)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1997, N'10020887', N' Philipp de Souza Ribeiro ', N'Ampla', 105.99, 0, 105.99, 62)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1998, N'10073307', N' Rebeka Dantas dosSantos Vilanova ', N'Ampla', 105.93, 0, 105.93, 63)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (1999, N'10055572', N' Ana Luisa Fernandes dos Reis ', N'Ampla', 105.79, 0, 105.79, 64)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2000, N'10039221', N' Aline Vitorassi Moreira ', N'Ampla', 105.78, 0, 105.78, 65)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2001, N'10098140', N' Eric Vonderscher ', N'Ampla', 105.78, 0, 105.78, 66)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2002, N'10060031', N' Lucas Pacheco Barreto ', N'Ampla', 105.69, 0, 105.69, 67)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2003, N'10030172', N' Guilherme Mendes Tavares ', N'Ampla', 105.68, 0, 105.68, 68)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2004, N'10005394', N' Rayssa Polianna Silva ', N'Ampla', 105.68, 0, 105.68, 69)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2005, N'10025275', N' Eduardo Eiler Batista de Araujo ', N'Ampla', 105.56, 0, 105.56, 70)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2006, N'10062303', N' Lucas da Silva Vieira ', N'Ampla', 105.51, 0, 105.51, 71)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2007, N'10000753', N' Tamires Jade Pereira da Silva ', N'Ampla', 105.42, 0, 105.42, 72)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2008, N'10036068', N' Alessandra Sousa da Silveira ', N'Ampla', 105.31, 0, 105.31, 73)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2009, N'10045080', N' Carolina de Oliveira Moura ', N'Ampla', 105.23, 0, 105.23, 74)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2010, N'10020026', N' Jose Luiz Neves dos Santos Junior ', N'Ampla', 105.22, 0, 105.22, 75)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2011, N'10042456', N' Mayara Costa Freire Vasconcellos Pitanga ', N'Ampla', 105.02, 0, 105.02, 76)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2012, N'10003351', N' Mayara Cristina Gomes Maia', N'Ampla', 104.91, 0, 104.91, 77)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2013, N'10009735', N' Diogo Andrade do Nascimento ', N'Ampla', 104.79, 0, 104.79, 78)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2014, N'10030798', N' Pedro Ribeiro Dornelas ', N'Ampla', 104.71, 0, 104.71, 79)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2015, N'10064148', N' William Radziavicius Santos Cavalheri ', N'Ampla', 104.65, 0, 104.65, 80)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2016, N'10009101', N' Leonardo Dias Carneiro ', N'Ampla', 104.63, 0, 104.63, 81)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2017, N'10051248', N' Bruna Ribeiro de Almeida ', N'Ampla', 104.53, 0, 104.53, 82)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2018, N'10060014', N' Gustavo Henrique Clement Souza ', N'Ampla', 104.45, 0, 104.45, 83)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2019, N'10025651', N' Marcia Vieira de Azevedo de Morais ', N'Ampla', 104.36, 0, 104.36, 84)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2020, N'10003796', N' Daniel Lelis de Oliveira ', N'Ampla', 104.33, 0, 104.33, 85)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2021, N'10037287', N' Joheser Wellington de Barros Pereira ', N'Ampla', 104.28, 0, 104.28, 87)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2022, N'10039479', N' Valeria Maria Rosa ', N'Ampla', 104.28, 0, 104.28, 88)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2023, N'10013616', N' Samuel Oliveira da Cunha ', N'Ampla', 104.21, 0, 104.21, 89)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2024, N'10007805', N' Sandra Cristina Cavalcante de Araujo ', N'Ampla', 104.02, 0, 104.02, 90)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2025, N'10006063', N' Marco Holetz de Toledo Lourenco ', N'Ampla', 103.94, 0, 103.94, 91)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2026, N'10000327', N' Leonardo Camargo de Moura Leocadio ', N'Ampla', 103.92, 0, 103.92, 92)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2027, N'10020542', N' Rafael Cavaignac Ribeiro Borges ', N'Ampla', 103.77, 0, 103.77, 93)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2028, N'10002486', N' Lucas Alves Dias ', N'Ampla', 103.75, 0, 103.75, 94)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2029, N'10049198', N' Pablo Felipe dos Santos ', N'Ampla', 103.73, 0, 103.73, 95)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2030, N'10043736', N' Matheus Franca dos Reis ', N'Ampla', 103.67, 0, 103.67, 96)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2031, N'10087130', N' Marcos Antonio Alves de Oliveira Pinto ', N'Ampla', 103.65, 0, 103.65, 97)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2032, N'10026511', N' Fernando Bergamo ', N'Ampla', 103.63, 0, 103.63, 98)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2033, N'10046745', N' Guilherme Hagen Evangelista da Silva ', N'Ampla', 103.51, 0, 103.51, 99)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2034, N'10070781', N' Bruna Monyque Borges Santos ', N'Ampla', 103.44, 0, 103.44, 100)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2035, N'10019156', N' Gabriel Resende Assis ', N'Ampla', 103.42, 0, 103.42, 101)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2036, N'10057242', N' Frederico Campos Leao ', N'Ampla', 103.37, 0, 103.37, 102)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2037, N'10062094', N' Gabriel Tolentino Costa Ferreira ', N'Ampla', 103.29, 0, 103.29, 103)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2038, N'10024179', N' Leonardo Carvalho de Medeiros ', N'Ampla', 103.26, 0, 103.26, 104)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2039, N'10055852', N' Marina Lemes Machado Gomes ', N'Ampla', 103.23, 0, 103.23, 105)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2040, N'10054140', N' Vitor Neves Ergang', N'Ampla', 103.2, 0, 103.2, 106)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2041, N'10081676', N' Gabriel Ferreira e Campos Pereira ', N'Ampla', 103.19, 0, 103.19, 107)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2042, N'10037118', N' Rodrigo Carlos de Almeida ', N'Ampla', 103.18, 0, 103.18, 108)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2043, N'10022160', N' Marcos de Biazi Goldberg ', N'Ampla', 103.17, 0, 103.17, 109)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2044, N'10068784', N' Igor Soto Silawsky ', N'Ampla', 103.15, 0, 103.15, 110)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2045, N'10005029', N' Hortensia Pereira de Souza ', N'Ampla', 103.14, 0, 103.14, 111)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2046, N'10055793', N' Igor Teixeira Pfrimer ', N'Ampla', 102.98, 0, 102.98, 112)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2047, N'10031571', N' Matheus Amaral Guimaraes ', N'Ampla', 102.98, 0, 102.98, 113)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2048, N'10023828', N' Ewerton Renan Aguiar de Sampaio ', N'Ampla', 102.9, 0, 102.9, 114)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2049, N'10027030', N' LeonardoMarinho Marques da Silva ', N'Ampla', 102.88, 0, 102.88, 115)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2050, N'10004713', N' Ana Luisa Sa de Oliveira ', N'Ampla', 102.87, 0, 102.87, 116)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2051, N'10093095', N' Andre Honorato Marins ', N'Ampla', 102.73, 0, 102.73, 117)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2052, N'10054585', N' Vitor Alves Fonseca de Oliveira ', N'Ampla', 102.73, 0, 102.73, 118)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2053, N'10088223', N' Gustavo Barbosa Machado ', N'Ampla', 102.67, 0, 102.67, 119)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2054, N'10012124', N' Ana Beatriz Guedes Cota ', N'Ampla', 102.62, 0, 102.62, 120)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2055, N'10059829', N' Thallys Deusdara Monsueth Alves ', N'Ampla', 102.6, 0, 102.6, 121)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2056, N'10014715', N' Felipe Magalhaes Alves ', N'Ampla', 102.53, 0, 102.53, 122)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2057, N'10010460', N' Lucas Silva Casadio ', N'Ampla', 102.53, 0, 102.53, 123)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2058, N'10042949', N' Wilquer Coelho dos Santos ', N'Ampla', 102.45, 0, 102.45, 124)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2059, N'10001332', N' Takuma Machado Scarponi Cruz ', N'Ampla', 102.42, 0, 102.42, 125)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2060, N'10014937', N' Joao Lucas Alexandre Nunes Galvao Ferreira ', N'Ampla', 102.36, 0, 102.36, 126)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2061, N'10007135', N' Renata Delfino Brito ', N'Ampla', 102.33, 0, 102.33, 127)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2062, N'10043650', N' Jose Lidberg Rocha Lima Filho ', N'Ampla', 102.29, 0, 102.29, 128)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2063, N'10006487', N' Andreia Moreira Cipriano ', N'Ampla', 102.22, 0, 102.22, 129)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2064, N'10013961', N' Luciana Nobrega ', N'Ampla', 102.18, 0, 102.18, 130)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2065, N'10014427', N' Kamila Rodrigues Barbosa ', N'Ampla', 102.14, 0, 102.14, 131)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2066, N'10050697', N' Gustavo Reis ', N'Ampla', 102.11, 0, 102.11, 132)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2067, N'10041615', N' Carlos Augusto de Carvalho Junior ', N'Ampla', 102.07, 0, 102.07, 133)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2068, N'10038961', N' Wellington Sousa de Oliveira ', N'Ampla', 102.06, 0, 102.06, 134)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2069, N'10047081', N' Maria Gerlane de Souza Silva ', N'Ampla', 101.98, 0, 101.98, 135)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2070, N'10096389', N' Mariana Koury Veloso ', N'Ampla', 101.98, 0, 101.98, 136)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2071, N'10009582', N' Nathalia Azarias de Souza ', N'Ampla', 101.97, 0, 101.97, 137)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2072, N'10020650', N' Danillo Franca Neves ', N'Ampla', 101.94, 0, 101.94, 138)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2073, N'10060343', N' Gabriel Salazar Maia ', N'Ampla', 101.91, 0, 101.91, 139)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2074, N'10030710', N' Sabrina da Costa Lopes Goncalo ', N'Ampla', 101.87, 0, 101.87, 140)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2075, N'10000775', N' Jasmine Frutuoso da Silva ', N'Ampla', 101.86, 0, 101.86, 141)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2076, N'10008489', N' Davi Spinola de Jesus Almeida ', N'Ampla', 101.74, 0, 101.74, 142)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2077, N'10011474', N' Lucas Vale Adjafre ', N'Ampla', 101.72, 0, 101.72, 143)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2078, N'10042894', N' Joao Lucas Santos Flores ', N'Ampla', 101.68, 0, 101.68, 146)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2079, N'10010668', N' Cauhe Lima Nogueira ', N'Ampla', 101.64, 0, 101.64, 147)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2080, N'10045938', N' Rodrigo Picinin Nascimento', N'Ampla', 101.63, 0, 101.63, 148)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2081, N'10001888', N' Paulo Henrique Fernandes Ribeiro Silva ', N'Ampla', 101.6, 0, 101.6, 149)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2082, N'10037385', N' Getulio Pedro de Melo Filho ', N'Ampla', 101.59, 0, 101.59, 150)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2083, N'10006204', N' Amanda Karla Sena Dourado ', N'Ampla', 101.57, 0, 101.57, 151)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2084, N'10035323', N' Guilherme Atila Martins Lacerda ', N'Ampla', 101.52, 0, 101.52, 152)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2085, N'10011747', N' Barbara Tobias da Fonseca ', N'Ampla', 101.51, 0, 101.51, 153)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2086, N'10008413', N' Brenda Bianca Neves Dias ', N'Ampla', 101.51, 0, 101.51, 154)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2087, N'10042332', N' Fernanda Gabriela de Souza Almeida e Abreu ', N'Ampla', 101.51, 0, 101.51, 155)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2088, N'10031251', N' Fabiola Imperiano Figueira ', N'Ampla', 101.47, 0, 101.47, 156)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2089, N'10005302', N' Luiza Holanda Barbosa Araujo ', N'Ampla', 101.43, 0, 101.43, 157)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2090, N'10070045', N' Fernando Cesar Pereira da Costa ', N'Ampla', 101.41, 0, 101.41, 158)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2091, N'10035747', N' Lucas Leal Lima de Abreu ', N'Ampla', 101.4, 0, 101.4, 159)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2092, N'10048196', N' Gabriela Moreno Gentilin de Menezes ', N'Ampla', 101.34, 0, 101.34, 160)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2093, N'10015929', N' Matheus Cordeiro Lima ', N'Ampla', 101.33, 0, 101.33, 161)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2094, N'10019723', N' Thiago Soares Ouriques ', N'Ampla', 101.32, 0, 101.32, 162)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2095, N'10012723', N' Natalia Lemos Penetra ', N'Ampla', 101.3, 0, 101.3, 163)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2096, N'10010288', N' Bruno Araujo Lima ', N'Ampla', 101.3, 0, 101.3, 164)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2097, N'10082563', N' Izadora Pimenta Rocha Carvalho ', N'Ampla', 101.27, 0, 101.27, 166)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2098, N'10019405', N' Pedro Augusto da Camara de Oliveira ', N'Ampla', 101.27, 0, 101.27, 167)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2099, N'10021102', N' Barbara Carvalho de Moura ', N'Ampla', 101.25, 0, 101.25, 168)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2100, N'10024702', N' Beatriz Machado Willman Saar ', N'Ampla', 101.19, 0, 101.19, 169)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2101, N'10002599', N' Lincoln Pinheiro de Oliveira ', N'Ampla', 101.17, 0, 101.17, 170)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2102, N'10015600', N' Damaris Moreira de Lima ', N'Ampla', 101.15, 0, 101.15, 171)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2103, N'10098927', N' Lucas de Alencar Oliveira ', N'Ampla', 101.11, 0, 101.11, 172)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2104, N'10012190', N' Eslen de Souza Araujo ', N'Ampla', 101.1, 0, 101.1, 173)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2105, N'10077141', N' Felipe Vargas Grey Tavares ', N'Ampla', 101.1, 0, 101.1, 174)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2106, N'10047638', N' Thiago de Lima Klen Barreto ', N'Ampla', 101.09, 0, 101.09, 175)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2107, N'10001272', N' Humberto Cezar Gama Guimaraes ', N'Ampla', 101.08, 0, 101.08, 176)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2108, N'10021856', N' Isabella dos Santos Silva ', N'Ampla', 100.97, 0, 100.97, 177)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2109, N'10026423', N' Vitor Rodrigues Santos ', N'Ampla', 100.89, 0, 100.89, 178)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2110, N'10021592', N' Diogenes Martins de Siqueira ', N'Ampla', 100.84, 0, 100.84, 179)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2111, N'10034505', N' Wanderson Souza Marques ', N'Ampla', 100.83, 0, 100.83, 180)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2112, N'10071023', N' Felippe Henrique Almada Albuquerque Moreira ', N'Ampla', 100.82, 0, 100.82, 181)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2113, N'10003681', N' Joao Pedro Oliveira Silva ', N'Ampla', 100.79, 0, 100.79, 182)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2114, N'10085602', N' Yuri Portugal Serrao Ramos', N'Ampla', 100.79, 0, 100.79, 183)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2115, N'10028974', N' Maiara Neri Josino ', N'Ampla', 100.75, 0, 100.75, 184)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2116, N'10055232', N' Lorenna de Souza Nascimento do Carmo ', N'Ampla', 100.73, 0, 100.73, 185)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2117, N'10009555', N' Roberta Almeida Silva Pereira ', N'Ampla', 100.73, 0, 100.73, 186)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2118, N'10008694', N' Mateus Oliveira Bistene ', N'Ampla', 100.72, 0, 100.72, 187)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2119, N'10024153', N' Carlos Magno Machado Lemos ', N'Ampla', 100.71, 0, 100.71, 188)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2120, N'10007783', N' Matheus Pereira Goncalves ', N'Ampla', 100.71, 0, 100.71, 189)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2121, N'10050369', N' Maxmyller Mourao Bezerra ', N'Ampla', 100.66, 0, 100.66, 190)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2122, N'10008798', N' Nathalia Malacrida de Araujo ', N'Ampla', 100.64, 0, 100.64, 191)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2123, N'10000320', N' Carolina Pinho de Castro ', N'Ampla', 100.59, 0, 100.59, 192)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2124, N'10076880', N' James Bernardes de Almeida Junior ', N'Ampla', 100.59, 0, 100.59, 193)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2125, N'10034236', N' Daniela Maia Baruzzi ', N'Ampla', 100.57, 0, 100.57, 194)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2126, N'10052103', N' Caroline Cerqueira Alves Ferreira ', N'Ampla', 100.53, 0, 100.53, 195)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2127, N'10021875', N' Arthur Araujo de Sousa ', N'Ampla', 100.51, 0, 100.51, 196)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2128, N'10007032', N' Adriana Santos de Jesus ', N'Ampla', 100.49, 0, 100.49, 197)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2129, N'10011060', N' Bruno Saboia Demeterco ', N'Ampla', 100.48, 0, 100.48, 198)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2130, N'10061864', N' Diego Aires Jacome ', N'Ampla', 100.48, 0, 100.48, 199)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2131, N'10003294', N' Sarah Gomes Barroso ', N'Ampla', 100.48, 0, 100.48, 200)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2132, N'10091776', N' Lhuan Terra Diego de Souza Gomes ', N'Ampla', 100.46, 0, 100.46, 201)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2133, N'10008837', N' Caroline Almeida Sodre ', N'Ampla', 100.44, 0, 100.44, 202)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2134, N'10013454', N' Silas Dantas Silva ', N'Ampla', 100.44, 0, 100.44, 203)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2135, N'10005967', N' Bernardo Carius Ceschini ', N'Ampla', 100.4, 0, 100.4, 204)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2136, N'10017551', N' Matheus Henrique Fernandes di Credico ', N'Ampla', 100.39, 0, 100.39, 205)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2137, N'10008164', N' Nayara da Silva Magalhaes ', N'Ampla', 100.38, 0, 100.38, 206)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2138, N'10039934', N' Jessica Karoline Nogueira da Silva ', N'Ampla', 100.37, 0, 100.37, 208)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2139, N'10023469', N' Lais de Sousa Lima Reboucas ', N'Ampla', 100.31, 0, 100.31, 211)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2140, N'10020622', N' Ana Paula Souto Villarinho ', N'Ampla', 100.3, 0, 100.3, 212)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2141, N'10029028', N' Fernanda Miranda de Souza ', N'Ampla', 100.24, 0, 100.24, 213)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2142, N'10033423', N' Matheus Lira Rodrigues ', N'Ampla', 100.22, 0, 100.22, 214)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2143, N'10086804', N' Philippe Frota Menezes ', N'Ampla', 100.2, 0, 100.2, 215)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2144, N'10028761', N' Raquel Carvalho Pereira ', N'Ampla', 100.18, 0, 100.18, 216)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2145, N'10099095', N' Joao Victor Tomaz Anacleto ', N'Ampla', 100.18, 0, 100.18, 217)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2146, N'10019704', N' Tamara Miranda Ferreira Figueiroa ', N'Ampla', 100.16, 0, 100.16, 218)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2147, N'10079723', N' Matheus Goncalves Pereira ', N'Ampla', 100.14, 0, 100.14, 219)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2148, N'10038558', N' Bruna Fagundes Perfeito ', N'Ampla', 100.11, 0, 100.11, 220)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2149, N'10033474', N' Pedro Henrique Silva Mariz ', N'Ampla', 100.09, 0, 100.09, 221)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2150, N'10011553', N' Tiago dos Santos Ferreira ', N'Ampla', 100.08, 0, 100.08, 222)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2151, N'10013477', N' Talita Silva Rodrigues ', N'Ampla', 100.04, 0, 100.04, 223)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2152, N'10023861', N' Thadeu Pessoa Passos Santos ', N'Ampla', 100.03, 0, 100.03, 224)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2153, N'10012062', N' Vitoria Hadassa de Souza Santos ', N'Ampla', 100.02, 0, 100.02, 225)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2154, N'10012902', N' Ludmilla Eleuterio Rodrigues ', N'Ampla', 100.02, 0, 100.02, 226)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2155, N'10081572', N' Luciana Graever de Medeiros ', N'Ampla', 99.97, 0, 99.97, 227)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2156, N'10000793', N' Francisco Jose Prezado Louro Marques ', N'Ampla', 99.96, 0, 99.96, 228)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2157, N'10024668', N' Stephano Praxedes Mendonca ', N'Ampla', 99.94, 0, 99.94, 229)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2158, N'10051492', N' Matheus Pedroso Dias ', N'Ampla', 99.89, 0, 99.89, 230)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2159, N'10000503', N' Breno Douglas Galvao de Paiva ', N'Ampla', 99.87, 0, 99.87, 231)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2160, N'10065056', N' Francisco Junior de Azevedo ', N'Ampla', 99.86, 0, 99.86, 232)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2161, N'10000749', N' Eduardo Naves Cardoso', N'Ampla', 99.85, 0, 99.85, 233)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2162, N'10030027', N' Ivan de Oliveira Lobo Neto ', N'Ampla', 99.84, 0, 99.84, 234)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2163, N'10083694', N' Leticia Batista Merencio de Lima ', N'Ampla', 99.83, 0, 99.83, 235)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2164, N'10049031', N' Lucas Souza Araujo ', N'Ampla', 99.81, 0, 99.81, 236)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2165, N'10000364', N' Leonardo Nunes da Silva ', N'Ampla', 99.8, 0, 99.8, 237)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2166, N'10047094', N' Diego Ramon Cordeiro Santos ', N'Ampla', 99.77, 0, 99.77, 238)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2167, N'10027209', N' Danillo Gaia Duarte de Lima ', N'Ampla', 99.72, 0, 99.72, 239)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2168, N'10011515', N' Fabiano Dutra de Azevedo ', N'Ampla', 99.72, 0, 99.72, 240)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2169, N'10001871', N' Felipe Schaper Ferraz ', N'Ampla', 99.72, 0, 99.72, 241)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2170, N'10045428', N' Danusa de Castro Fonseca ', N'Ampla', 99.71, 0, 99.71, 242)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2171, N'10009586', N' Brunno Nascimento Moura ', N'Ampla', 99.67, 0, 99.67, 243)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2172, N'10051340', N' Peterson de Lira Quirino ', N'Ampla', 99.67, 0, 99.67, 244)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2173, N'10040241', N' Rodrigo Santos Mendes ', N'Ampla', 99.64, 0, 99.64, 245)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2174, N'10061145', N' Lucas Gustavo Souza de Melo ', N'Ampla', 99.64, 0, 99.64, 246)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2175, N'10099986', N' Rafael Flores de Magalhaes ', N'Ampla', 99.63, 0, 99.63, 247)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2176, N'10014467', N' Flavio Winicius de Moraes Martins ', N'Ampla', 99.62, 0, 99.62, 248)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2177, N'10101429', N' Ellionay Sousa de Freitas', N'Ampla', 99.6, 0, 99.6, 249)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2178, N'10003244', N' Vinicius Tavares de Castro ', N'Ampla', 99.59, 0, 99.59, 250)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2179, N'10008827', N' Gabriel Lira do Nascimento ', N'Ampla', 99.58, 0, 99.58, 251)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2180, N'10026809', N' Manuella Maria Santos Miguel da Silva ', N'Ampla', 99.52, 0, 99.52, 252)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2181, N'10013790', N' Victor Baracho Alves ', N'Ampla', 99.49, 0, 99.49, 253)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2182, N'10021075', N' Caroline Gomes Carvalho ', N'Ampla', 99.44, 0, 99.44, 254)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2183, N'10075801', N' Gleisson Mateus de Souza ', N'Ampla', 99.43, 0, 99.43, 255)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2184, N'10055656', N' Patricia Merlim de Oliveira ', N'Ampla', 99.43, 0, 99.43, 256)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2185, N'10005402', N' Maximilian Emanuel Hierstetter ', N'Ampla', 99.42, 0, 99.42, 257)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2186, N'10038170', N' Thais Andreia de Souza Santos ', N'Ampla', 99.42, 0, 99.42, 258)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2187, N'10003749', N' Gabriel Arana da Silva ', N'Ampla', 99.36, 0, 99.36, 259)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2188, N'10076991', N' Cristina Spacki ', N'Ampla', 99.31, 0, 99.31, 260)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2189, N'10044006', N' Bruna Araujo Pinto ', N'Ampla', 99.3, 0, 99.3, 261)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2190, N'10018383', N' Felipe Mello Gonzaga ', N'Ampla', 99.28, 0, 99.28, 262)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2191, N'10002300', N' Betina Dall Oglio Stacke ', N'Ampla', 99.25, 0, 99.25, 265)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2192, N'10105083', N' Wallace Willian do Nascimento Macedo ', N'Ampla', 99.23, 0, 99.23, 266)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2193, N'10068922', N' Arthur Nobre Brito ', N'Ampla', 99.2, 0, 99.2, 267)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2194, N'10050665', N' Priscila Furtado de Oliveira ', N'Ampla', 99.18, 0, 99.18, 268)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2195, N'10024621', N' Rodrigo Luiz Caron Burda ', N'Ampla', 99.16, 0, 99.16, 269)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2196, N'10024436', N' Pedro Ciminelli de Araujo ', N'Ampla', 99.15, 0, 99.15, 270)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2197, N'10078109', N' Alexandre Gabriel Silva Rodrigues ', N'Ampla', 99.15, 0, 99.15, 271)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2198, N'10002689', N' Juliana do Carmo Mangueira Celestino ', N'Ampla', 99.15, 0, 99.15, 272)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2199, N'10004488', N' Rafael Tavares de Sa ', N'Ampla', 99.11, 0, 99.11, 273)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2200, N'10035949', N' Pedro Guilherme Feitoza Melo ', N'Ampla', 99.08, 0, 99.08, 274)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2201, N'10045067', N' Eduardo Dunck Oliveira ', N'Ampla', 99.08, 0, 99.08, 275)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2202, N'10010634', N' Camila Scarin Bezerra Mendes ', N'Ampla', 99.02, 0, 99.02, 276)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2203, N'10020117', N' Leticia Bettina Granados Goulart ', N'Ampla', 99.02, 0, 99.02, 277)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2204, N'10060464', N' Rafael Antunes dos Santos ', N'Ampla', 99.02, 0, 99.02, 278)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2205, N'10048884', N' Vitor Augusto Cardoso Silva ', N'Ampla', 99, 0, 99, 279)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2206, N'10066250', N' Gustavo de Souza Silva Seara ', N'Ampla', 98.99, 0, 98.99, 280)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2207, N'10043862', N' Marcella Hermida de Paula ', N'Ampla', 98.96, 0, 98.96, 281)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2208, N'10026540', N' Amanda Araujo de Oliveira e Souza ', N'Ampla', 98.96, 0, 98.96, 282)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2209, N'10035918', N' Ana Carolina Salazar Albuquerque ', N'Ampla', 98.9, 0, 98.9, 284)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2210, N'10075504', N' Vinicius Pataro Generoso Sales ', N'Ampla', 98.87, 0, 98.87, 285)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2211, N'10011848', N' Caroline Morais Martins ', N'Ampla', 98.83, 0, 98.83, 288)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2212, N'10105850', N' Mariana Rodrigues Leite Ribeiro ', N'Ampla', 98.82, 0, 98.82, 289)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2213, N'10080938', N' Caio Cesar Nogueira Claudino ', N'Ampla', 98.76, 0, 98.76, 290)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2214, N'10018720', N' Elica Rocha Rodrigues ', N'Ampla', 98.76, 0, 98.76, 291)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2215, N'10021131', N' Fernanda Martins Rocha ', N'Ampla', 98.75, 0, 98.75, 292)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2216, N'10002253', N' Fernanda Takako Hirayama ', N'Ampla', 98.75, 0, 98.75, 293)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2217, N'10083119', N' Allan dos Santos Silva ', N'Ampla', 98.74, 0, 98.74, 294)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2218, N'10005953', N' Priscilla Passos Lacerda de Araujo Gois ', N'Ampla', 98.74, 0, 98.74, 295)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2219, N'10014930', N' Victor Amorim de Carvalho ', N'Ampla', 98.69, 0, 98.69, 296)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2220, N'10034528', N' Marcos Wesley Brandinho Ribeiro ', N'Ampla', 98.68, 0, 98.68, 297)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2221, N'10002589', N' Luiz Eduardo Paes Pereira da Silva ', N'Ampla', 98.67, 0, 98.67, 298)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2222, N'10021710', N' Andrini Bethowen Bouzas de Oliveira ', N'Ampla', 98.67, 0, 98.67, 299)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2223, N'10016150', N' Davi Dantas Domingos ', N'Ampla', 98.61, 0, 98.61, 300)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2224, N'10083161', N' Ramon Fernandes Bastos Pinheiro ', N'Ampla', 98.6, 0, 98.6, 301)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2225, N'10013427', N' Denilson Santiago Barbosa ', N'Ampla', 98.59, 0, 98.59, 302)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2226, N'10028954', N' Pedro Sperchi Camilo ', N'Ampla', 98.57, 0, 98.57, 303)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2227, N'10032973', N' Vitor Alexandre Pereira ', N'Ampla', 98.55, 0, 98.55, 304)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2228, N'10015833', N' Arthur Gouvea Fernandes ', N'Ampla', 98.48, 0, 98.48, 306)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2229, N'10029952', N' Bruno Cesar Sampaio Ribeiro de Assis ', N'Ampla', 98.48, 0, 98.48, 307)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2230, N'10065004', N' Maira dos Santos Freitas ', N'Ampla', 98.48, 0, 98.48, 308)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2231, N'10000494', N' Igor Augusto Alves Dias ', N'Ampla', 98.47, 0, 98.47, 309)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2232, N'10000089', N' Eliane Santos Silva ', N'Ampla', 98.47, 0, 98.47, 310)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2233, N'10014703', N' Claudio da Silva Gomes Filho ', N'Ampla', 98.46, 0, 98.46, 311)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2234, N'10006040', N' Karolinne Araujo Souza ', N'Ampla', 98.46, 0, 98.46, 312)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2235, N'10064548', N' Washington Richel Saito da Silva ', N'Ampla', 98.46, 0, 98.46, 313)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2236, N'10009181', N' Joao Pedro Koerich ', N'Ampla', 98.4, 0, 98.4, 314)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2237, N'10002663', N' Ciro Camilo Santos Leal ', N'Ampla', 98.37, 0, 98.37, 315)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2238, N'10051880', N' Pedro de Freitas Neder ', N'Ampla', 98.35, 0, 98.35, 316)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2239, N'10055039', N' Ian Alvares dos Prazeres Filho ', N'Ampla', 98.32, 0, 98.32, 317)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2240, N'10021976', N' Angelina Segre Melhoranca ', N'Ampla', 98.31, 0, 98.31, 318)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2241, N'10035150', N' Paulo Rodrigues de Morais Junior ', N'Ampla', 98.29, 0, 98.29, 319)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2242, N'10024629', N' Marcondes Azevedo ', N'Ampla', 98.28, 0, 98.28, 320)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2243, N'10075461', N' Juliana Vieira Zuany ', N'Ampla', 98.24, 0, 98.24, 322)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2244, N'10045246', N' Ananda de Cassia do Nascimento Laurent Rocchi ', N'Ampla', 98.21, 0, 98.21, 323)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2245, N'10001539', N' Jouberth Maia Oliveira ', N'Ampla', 98.19, 0, 98.19, 324)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2246, N'10007325', N' Juliana Moreira Moraes ', N'Ampla', 98.17, 0, 98.17, 325)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2247, N'10003922', N' Winston Antonio Melo Severino ', N'Ampla', 98.16, 0, 98.16, 326)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2248, N'10002814', N' Carolina Farias Ferreira Moretto', N'Ampla', 98.14, 0, 98.14, 327)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2249, N'10077393', N' Gustavo de Almeida Ferreira ', N'Ampla', 98.11, 0, 98.11, 328)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2250, N'10012754', N' Diogo Martins Ferreira ', N'Ampla', 98.07, 0, 98.07, 329)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2251, N'10042244', N' Luiz Phellipe Ribeiro Rodrigues ', N'Ampla', 98.06, 0, 98.06, 330)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2252, N'10040277', N' Raquel de Freitas Lerback ', N'Ampla', 98.04, 0, 98.04, 331)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2253, N'10015257', N' Marco Antonio de Souza Watanabe ', N'Ampla', 98.03, 0, 98.03, 332)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2254, N'10007528', N' Lucas Henrique Rosa do Nascimento ', N'Ampla', 98.02, 0, 98.02, 333)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2255, N'10057539', N' Lucas Moraes Leocadio de Souza ', N'Ampla', 98.02, 0, 98.02, 334)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2256, N'10001042', N' Alexandre Gomes Serra ', N'Ampla', 98, 0, 98, 335)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2257, N'10053439', N' Marcelo Babilonia de Melo ', N'Ampla', 97.99, 0, 97.99, 336)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2258, N'10058083', N' Gerson Brian Gomes Evangelista ', N'Ampla', 97.95, 0, 97.95, 337)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2259, N'10041940', N' Leonardo Souza Medeiros ', N'Ampla', 97.93, 0, 97.93, 338)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2260, N'10048723', N' Cesar Alexandre Saraiva de Sousa', N'Ampla', 97.92, 0, 97.92, 339)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2261, N'10003020', N' Vinicius Moreira Lana ', N'Ampla', 97.89, 0, 97.89, 340)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2262, N'10021904', N' Arthur Simas Pinheiro', N'Ampla', 97.88, 0, 97.88, 341)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2263, N'10068379', N' Artur Tavares Pereira Soares ', N'Ampla', 97.88, 0, 97.88, 342)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2264, N'10023453', N' Matheus de Moraes Soares ', N'Ampla', 97.82, 0, 97.82, 343)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2265, N'10045945', N' Heitor Alves Rios Campos ', N'Ampla', 97.81, 0, 97.81, 344)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2266, N'10007454', N' Pedro Vitor Resende ', N'Ampla', 97.79, 0, 97.79, 345)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2267, N'10097640', N' Alexandre Mendonca Souto Lopes ', N'Ampla', 97.73, 0, 97.73, 346)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2268, N'10044911', N' Priscila Augusta Morgado Pessoa ', N'Ampla', 97.72, 0, 97.72, 347)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2269, N'10062554', N' Andre Frederico Barreto Leite ', N'Ampla', 97.69, 0, 97.69, 349)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2270, N'10010308', N' Igor Matheus Gomes Goncalves ', N'Ampla', 97.68, 0, 97.68, 350)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2271, N'10060962', N' Marcio Gadelha Vasconcelos ', N'Ampla', 97.67, 0, 97.67, 351)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2272, N'10026126', N' Ana Karolina Silva ', N'Ampla', 97.66, 0, 97.66, 352)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2273, N'10035941', N' Euzebio Alvarenga Santana', N'Ampla', 97.64, 0, 97.64, 353)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2274, N'10032383', N' Cainan de Negreiros Martins Leite ', N'Ampla', 97.58, 0, 97.58, 354)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2275, N'10063705', N' Mariana de Lima Campos ', N'Ampla', 97.55, 0, 97.55, 355)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2276, N'10021467', N' Lucas Barros Sales dos Santos ', N'Ampla', 97.5, 0, 97.5, 356)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2277, N'10091408', N' Alexia Grassuri Barreto de Oliveira Demori ', N'Ampla', 97.48, 0, 97.48, 357)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2278, N'10000149', N' Gabriela Marques de Moura Arruda ', N'Ampla', 97.46, 0, 97.46, 358)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2279, N'10006996', N' Higor Barbosa de Souza ', N'Ampla', 97.43, 0, 97.43, 359)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2280, N'10024641', N' Cirano de Macedo Teles Junior ', N'Ampla', 97.43, 0, 97.43, 360)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2281, N'10038467', N' Thalisson Rodrigues Mendes ', N'Ampla', 97.43, 0, 97.43, 361)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2282, N'10091890', N' Gabriel Trinca Dutra ', N'Ampla', 97.41, 0, 97.41, 363)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2283, N'10011159', N' Marianne Araujo Santos', N'Ampla', 97.41, 0, 97.41, 364)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2284, N'10013581', N' Guilherme Camargo Alves ', N'Ampla', 97.4, 0, 97.4, 365)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2285, N'10076110', N' Sergio Calderaro Gomes Pinto Junior ', N'Ampla', 97.34, 0, 97.34, 366)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2286, N'10022684', N' Tayssa Cordeiro de Oliveira ', N'Ampla', 97.33, 0, 97.33, 367)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2287, N'10010819', N' Thiago Fernandes Beserra ', N'Ampla', 97.33, 0, 97.33, 368)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2288, N'10029084', N' Lucas Nascimento Ferreira ', N'Ampla', 97.31, 0, 97.31, 369)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2289, N'10017604', N' Lucas Augusto Borges Pereira ', N'Ampla', 97.29, 0, 97.29, 370)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2290, N'10072081', N' Lucas Martins Ramalho ', N'Ampla', 97.28, 0, 97.28, 371)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2291, N'10004848', N' Joysse Vasconcelos Franca ', N'Ampla', 97.28, 0, 97.28, 372)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2292, N'10081029', N' Rodineli Mendes Moreira ', N'Ampla', 97.27, 0, 97.27, 373)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2293, N'10069097', N' Mateus Silva Luna ', N'Ampla', 97.25, 0, 97.25, 374)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2294, N'10033862', N' Felipe Henrique Teles de Faria de Souza ', N'Ampla', 97.25, 0, 97.25, 375)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2295, N'10071612', N' Felipe Jose Gustavo de Oliveira ', N'Ampla', 97.25, 0, 97.25, 376)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2296, N'10041198', N' Carlos Phelipe Matias e Silva ', N'Ampla', 97.24, 0, 97.24, 377)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2297, N'10034670', N' Luciano Teixeira Lara ', N'Ampla', 97.22, 0, 97.22, 378)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2298, N'10018848', N' Deivid Melo da Silva ', N'Ampla', 97.21, 0, 97.21, 379)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2299, N'10006474', N' Jessica Oliveira Shneider Nobre ', N'Ampla', 97.2, 0, 97.2, 380)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2300, N'10067233', N' Luana Gomes de Oliveira ', N'Ampla', 97.18, 0, 97.18, 381)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2301, N'10060247', N' Carlos Renato Brasil Junior ', N'Ampla', 97.14, 0, 97.14, 382)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2302, N'10029126', N' Wagner Alves Goncalves Nogueira ', N'Ampla', 97.14, 0, 97.14, 383)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2303, N'10009530', N' Thalia Soares de Souza ', N'Ampla', 97.12, 0, 97.12, 384)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2304, N'10043624', N' Marcia Ferreira Moraes ', N'Ampla', 97.12, 0, 97.12, 385)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2305, N'10030999', N' Victor Lopes Costa Serra ', N'Ampla', 97.11, 0, 97.11, 386)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2306, N'10016052', N' Fernanda Schreiber ', N'Ampla', 97.04, 0, 97.04, 387)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2307, N'10011480', N' Henrique Carreiro Duarte Araujo Pereira ', N'Ampla', 97.02, 0, 97.02, 388)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2308, N'10037952', N' Gabriel Carvalho Nunes Silva ', N'Ampla', 97, 0, 97, 389)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2309, N'10075760', N' Carolina Arruda dos Santos ', N'Ampla', 96.98, 0, 96.98, 390)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2310, N'10082496', N' Luiz Felipe Martins de Souza ', N'Ampla', 96.94, 0, 96.94, 391)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2311, N'10032581', N' Lais Santillo Morais ', N'Ampla', 96.9, 0, 96.9, 392)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2312, N'10057599', N' Randel Giordani Ferreira Montini ', N'Ampla', 96.89, 0, 96.89, 393)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2313, N'10054149', N' Karla Fernanda Soares ', N'Ampla', 96.87, 0, 96.87, 394)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2314, N'10006379', N' Marcus Fabricio do Amaral Moreira da Cunha ', N'Ampla', 96.86, 0, 96.86, 395)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2315, N'10003058', N' Rodrigo Melo de Oliveira ', N'Ampla', 96.86, 0, 96.86, 396)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2316, N'10105746', N' Kiane Santos Braga ', N'Ampla', 96.85, 0, 96.85, 397)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2317, N'10072551', N' Alice Ozorio de Almeida Lima ', N'Ampla', 96.85, 0, 96.85, 398)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2318, N'10059036', N' Daniel Souza Matos ', N'Ampla', 96.84, 0, 96.84, 399)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2319, N'10031133', N' Roberto Danilo Rodopiano Teixeira ', N'Ampla', 96.84, 0, 96.84, 400)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2320, N'10053328', N' Eduardo Fernandes Mariano ', N'Ampla', 96.83, 0, 96.83, 401)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2321, N'10073306', N' Renan Wilson Lopes Prudencio ', N'Ampla', 96.81, 0, 96.81, 402)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2322, N'10012919', N' Jefferson Beijamim dos Santos ', N'Ampla', 96.79, 0, 96.79, 403)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2323, N'10016568', N' Phelipe Ferreira Cabral ', N'Ampla', 96.78, 0, 96.78, 404)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2324, N'10038778', N' Robert da Silva Mello ', N'Ampla', 96.78, 0, 96.78, 405)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2325, N'10037198', N' Ewerton Cruz Soares ', N'Ampla', 96.77, 0, 96.77, 406)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2326, N'10021041', N' Arthur de Freitas Miranda ', N'Ampla', 96.76, 0, 96.76, 407)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2327, N'10050441', N' Nikolas Franklin Silva Santos', N'Ampla', 96.76, 0, 96.76, 408)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2328, N'10006483', N' Vinicios Alves Ferreira ', N'Ampla', 96.75, 0, 96.75, 409)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2329, N'10016214', N' Tiago Torres Braga ', N'Ampla', 96.73, 0, 96.73, 410)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2330, N'10031887', N' Roberto Matteus Bulcao dos Santos ', N'Ampla', 96.73, 0, 96.73, 411)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2331, N'10060829', N' Ludmila Daniele Lopes ', N'Ampla', 96.68, 0, 96.68, 412)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2332, N'10035851', N' Walter Aires da Silva ', N'Ampla', 96.67, 0, 96.67, 413)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2333, N'10040764', N' Beatriz Pereira Santos ', N'Ampla', 96.63, 0, 96.63, 415)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2334, N'10005485', N' Raphael Abreu de Barros Monteiro ', N'Ampla', 96.6, 0, 96.6, 416)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2335, N'10024854', N' Debora Tays Oliveira de Brito Marubayashi ', N'Ampla', 96.57, 0, 96.57, 417)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2336, N'10042867', N' Matheus de Carvalho Lima Rita ', N'Ampla', 96.56, 0, 96.56, 418)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2337, N'10036979', N' Luiz Claudio da Silva Medeiros Junior ', N'Ampla', 96.55, 0, 96.55, 419)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2338, N'10018735', N' Katheryne Ferreira Carvalhaes ', N'Ampla', 96.53, 0, 96.53, 420)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2339, N'10027634', N' Ricardo Pedrosa Dagosto ', N'Ampla', 96.51, 0, 96.51, 421)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2340, N'10050096', N' Thatiany Lopes de Oliveira ', N'Ampla', 96.51, 0, 96.51, 422)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2341, N'10021398', N' Sergio Ricardo Vieira Ponde Serra ', N'Ampla', 96.51, 0, 96.51, 423)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2342, N'10073642', N' Gustavo Ferreira Rodrigues ', N'Ampla', 96.5, 0, 96.5, 424)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2343, N'10080469', N' Vanessa Brunna da Silva Brito Alves ', N'Ampla', 96.49, 0, 96.49, 425)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2344, N'10005519', N' Felipe Chiarelli Linhares Titoneli ', N'Ampla', 96.47, 0, 96.47, 426)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2345, N'10049030', N' Alvaro Lopes Machado ', N'Ampla', 96.46, 0, 96.46, 427)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2346, N'10073858', N' Jorge Andre de Paiva Martins ', N'Ampla', 96.44, 0, 96.44, 428)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2347, N'10035946', N' Tales Henrique Andrade da Mota ', N'Ampla', 96.43, 0, 96.43, 429)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2348, N'10076654', N' Mariana Borges Araujo ', N'Ampla', 96.42, 0, 96.42, 430)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2349, N'10057763', N' Natalia Alcantara Ayres ', N'Ampla', 96.4, 0, 96.4, 431)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2350, N'10033240', N' Douglas Cantudo Goncalves ', N'Ampla', 96.4, 0, 96.4, 432)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2351, N'10010273', N' Mirian Sousa de Freitas ', N'Ampla', 96.39, 0, 96.39, 433)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2352, N'10015353', N' Priscila de Andrade Fernandes ', N'Ampla', 96.38, 0, 96.38, 434)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2353, N'10035723', N' Murilo Munhoz de Souza ', N'Ampla', 96.36, 0, 96.36, 435)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2354, N'10081708', N' Hugo Lopes Neves ', N'Ampla', 96.36, 0, 96.36, 436)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2355, N'10002615', N' Daniel Falcao da Rocha ', N'Ampla', 96.36, 0, 96.36, 437)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2356, N'10085743', N' Davi de Almeida Freitas ', N'Ampla', 96.34, 0, 96.34, 438)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2357, N'10047153', N' Augusto Luis Torquete de Oliveira ', N'Ampla', 96.31, 0, 96.31, 439)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2358, N'10093077', N' Felipe Figueira de Sales Pereira ', N'Ampla', 96.3, 0, 96.3, 440)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2359, N'10011683', N' Kevin Matheus Monteiro Leite ', N'Ampla', 96.3, 0, 96.3, 441)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2360, N'10029461', N' Nicolas de Castro Alves ', N'Ampla', 96.26, 0, 96.26, 442)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2361, N'10016369', N' Victor Emmanuel Delfino Aleixo ', N'Ampla', 96.2, 0, 96.2, 443)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2362, N'10045952', N' Vanderson Wallace Queiroz dos Santos ', N'Ampla', 96.14, 0, 96.14, 444)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2363, N'10104026', N' Romeu Gomes de Morais Filho ', N'Ampla', 96.13, 0, 96.13, 446)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2364, N'10041826', N' Vancleucyo Machado da Silva ', N'Ampla', 96.1, 0, 96.1, 447)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2365, N'10021307', N' Paulo Eduardo Lazar Meyer ', N'Ampla', 96.1, 0, 96.1, 448)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2366, N'10000948', N' Stephanie Correia Costa ', N'Ampla', 96.08, 0, 96.08, 449)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2367, N'10045292', N' Larissa Pires de Azevedo ', N'Ampla', 96.08, 0, 96.08, 450)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2368, N'10086884', N' Eric de Almeida Alvarenga ', N'Ampla', 96.07, 0, 96.07, 451)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2369, N'10067638', N' Ellen Pereira de Normando ', N'Ampla', 96.02, 0, 96.02, 452)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2370, N'10002238', N' Nailton Pereira Danesi Damacena ', N'Ampla', 96.02, 0, 96.02, 453)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2371, N'10035933', N' Hana Augusta de Andrade ', N'Ampla', 95.99, 0, 95.99, 454)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2372, N'10085299', N' Gabriel Ribeiro Braga ', N'Ampla', 95.97, 0, 95.97, 455)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2373, N'10005534', N' Marceu Silva Sa ', N'Ampla', 95.96, 0, 95.96, 456)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2374, N'10065964', N' Lucas Rodrigues de Araujo Ledo ', N'Ampla', 95.95, 0, 95.95, 457)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2375, N'10006062', N' Lais Bandeira Lopes ', N'Ampla', 95.94, 0, 95.94, 458)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2376, N'10032546', N' Igor Nunes Hoffmann ', N'Ampla', 95.93, 0, 95.93, 459)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2377, N'10011854', N' Pablo Araujo da Gama ', N'Ampla', 95.93, 0, 95.93, 460)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2378, N'10000903', N' Renan Henrique Santos Pereira ', N'Ampla', 95.9, 0, 95.9, 461)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2379, N'10022076', N' Mariana Rodrigues de Souza ', N'Ampla', 95.89, 0, 95.89, 462)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2380, N'10000883', N' Lucas Felipe Pereira Nunes ', N'Ampla', 95.87, 0, 95.87, 463)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2381, N'10019170', N' Gabriel Abi Chahin de Oliveira Ferreira ', N'Ampla', 95.85, 0, 95.85, 464)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2382, N'10079862', N' Ana Flavia Cardoso Almeida ', N'Ampla', 95.85, 0, 95.85, 465)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2383, N'10002741', N' Ana Gabriela Ferreira Miranda ', N'Ampla', 95.85, 0, 95.85, 466)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2384, N'10035133', N' Bruno Sartori de Campos ', N'Ampla', 95.83, 0, 95.83, 467)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2385, N'10001721', N' Thiago Henrique Doria de Oliveira ', N'Ampla', 95.81, 0, 95.81, 468)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2386, N'10048310', N' Thiago Veiga Vian ', N'Ampla', 95.79, 0, 95.79, 469)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2387, N'10001660', N' Edielle de Oliveira Lagares ', N'Ampla', 95.78, 0, 95.78, 470)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2388, N'10053124', N' David Eloi Nunes ', N'Ampla', 95.74, 0, 95.74, 471)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2389, N'10076866', N' Murilo Alencar Lopes ', N'Ampla', 95.73, 0, 95.73, 472)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2390, N'10016579', N' Pedro Lucas Elesbao Barbosa ', N'Ampla', 95.73, 0, 95.73, 473)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2391, N'10010290', N' Joao Luis MachadoVasconcelos ', N'Ampla', 95.72, 0, 95.72, 474)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2392, N'10028186', N' Amaury de Souza de Pontes ', N'Ampla', 95.69, 0, 95.69, 475)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2393, N'10069123', N' Alessandra Nascimento da Silva ', N'Ampla', 95.69, 0, 95.69, 476)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2394, N'10010193', N' Jullia da Mata Almeida ', N'Ampla', 95.68, 0, 95.68, 477)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2395, N'10020320', N' Marianna Silva Martins ', N'Ampla', 95.67, 0, 95.67, 478)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2396, N'10008973', N' Victor Santos Pimentel Rodrigues de Araujo ', N'Ampla', 95.63, 0, 95.63, 479)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2397, N'10067472', N' Jose de Alsimir Gomes Junior ', N'Ampla', 95.63, 0, 95.63, 480)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2398, N'10015924', N' Vylther Pereira da Silva ', N'Ampla', 95.58, 0, 95.58, 481)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2399, N'10092925', N' Vinicius Henrique de Oliveira Santos ', N'Ampla', 95.56, 0, 95.56, 482)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2400, N'10043752', N' Ramon Braga Trajano ', N'Ampla', 95.56, 0, 95.56, 483)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2401, N'10008414', N' Jorge Lucas Costa Santiago ', N'Ampla', 95.51, 0, 95.51, 484)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2402, N'10015933', N' Iracema Rocha Souza ', N'Ampla', 95.51, 0, 95.51, 485)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2403, N'10056157', N' Leonardo Alves de Oliva Passos ', N'Ampla', 95.49, 0, 95.49, 486)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2404, N'10053699', N' Barbara David Neves de Lima ', N'Ampla', 95.49, 0, 95.49, 487)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2405, N'10073947', N' Matheus Argolo Leao ', N'Ampla', 95.48, 0, 95.48, 488)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2406, N'10080383', N' Saulo Maciel Rodrigues ', N'Ampla', 95.48, 0, 95.48, 489)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2407, N'10066831', N' Rodrigo Matos Lobo de Souza ', N'Ampla', 95.47, 0, 95.47, 490)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2408, N'10043689', N' Yuri Armstrong Cantanhede', N'Ampla', 95.45, 0, 95.45, 491)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2409, N'10081546', N' Leandro Lima de Souza ', N'Ampla', 95.43, 0, 95.43, 492)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2410, N'10022675', N' Silvio Luis Martins Eleuterio ', N'Ampla', 95.4, 0, 95.4, 493)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2411, N'10012673', N' Guilherme Carneiro Sarmento ', N'Ampla', 95.38, 0, 95.38, 494)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2412, N'10034956', N' Marcelo Marques de Souza ', N'Ampla', 95.34, 0, 95.34, 495)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2413, N'10059658', N' Paula Prestes Azeredo ', N'Ampla', 95.33, 0, 95.33, 496)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2414, N'10054722', N' Andre Barbosa Botelho ', N'Ampla', 95.32, 0, 95.32, 497)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2415, N'10032690', N' Francisco Anderson Bezerra Rodrigues ', N'Ampla', 95.31, 0, 95.31, 498)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2416, N'10060395', N' Richard David Souza ', N'Ampla', 95.31, 0, 95.31, 499)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2417, N'10049415', N' Ana Clara Pimenta Freire ', N'Ampla', 95.24, 0, 95.24, 500)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2418, N'10023773', N' Tiago Matheus Lopes ', N'Ampla', 95.23, 0, 95.23, 501)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2419, N'10004797', N' Wallesson Faria de Jesus ', N'Ampla', 95.22, 0, 95.22, 502)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2420, N'10053430', N' Hiago Rogerio Ulhoa ', N'Ampla', 95.22, 0, 95.22, 503)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2421, N'10050195', N' David de Castro Martins ', N'Ampla', 95.22, 0, 95.22, 504)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2422, N'10033331', N' Antony Goncalves Carvalho ', N'Ampla', 95.21, 0, 95.21, 505)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2423, N'10004216', N' Juliano Brauller Macedo ', N'Ampla', 95.2, 0, 95.2, 506)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2424, N'10045181', N' Ramona Thorpe Lima', N'Ampla', 95.2, 0, 95.2, 507)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2425, N'10001702', N' Rafael Rodrigues Gouveia ', N'Ampla', 95.19, 0, 95.19, 508)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2426, N'10017072', N' Miguel Santos de Freitas ', N'Ampla', 95.19, 0, 95.19, 509)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2427, N'10067304', N' Jones de Araujo Pereira ', N'Ampla', 95.19, 0, 95.19, 510)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2428, N'10051105', N' Ana Gabriela Pereira da Silva ', N'Ampla', 95.18, 0, 95.18, 511)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2429, N'10026123', N' Lucas Ferreira Fernandes ', N'Ampla', 95.15, 0, 95.15, 512)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2430, N'10005106', N' Vitor Antonio Teixeira Rozendo ', N'Ampla', 95.14, 0, 95.14, 513)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2431, N'10045019', N' Vinicius Umbelino de Souza Ribeiro ', N'Ampla', 95.14, 0, 95.14, 514)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2432, N'10086144', N' Anderson Carvalho de Loiola ', N'Ampla', 95.13, 0, 95.13, 515)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2433, N'10080935', N' Fabio Soller Cruz de Souza ', N'Ampla', 95.13, 0, 95.13, 516)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2434, N'10055761', N' Franciele Zambone Silva ', N'Ampla', 95.12, 0, 95.12, 517)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2435, N'10046093', N' Barbara Elias Rodrigues ', N'Ampla', 95.12, 0, 95.12, 518)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2436, N'10027672', N' Roberto Miyazaki Ramos ', N'Ampla', 95.12, 0, 95.12, 519)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2437, N'10059504', N' Larissa Ellen Monteiro Maciel ', N'Ampla', 95.12, 0, 95.12, 520)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2438, N'10022865', N' Mateus Costa Patrocinio ', N'Ampla', 95.11, 0, 95.11, 521)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2439, N'10014040', N' Matheus Ribeiro Linhares ', N'Ampla', 95.08, 0, 95.08, 522)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2440, N'10060061', N' Amanda Almeida Costa ', N'Ampla', 95.07, 0, 95.07, 523)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2441, N'10071479', N' Leonan Bezerra Araujo ', N'Ampla', 95.06, 0, 95.06, 524)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2442, N'10000349', N' Daniella Montenegro Bazzi ', N'Ampla', 95.04, 0, 95.04, 525)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2443, N'10058504', N' Cicely Weluma Rossi de Lima ', N'Ampla', 95.01, 0, 95.01, 526)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2444, N'10032041', N' Alex de Alcantara Ramos ', N'Ampla', 95.01, 0, 95.01, 527)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2445, N'10002711', N' Paloma de Bustamante Carim ', N'Ampla', 95, 0, 95, 528)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2446, N'10042752', N' Luan Torres Topdjian ', N'Ampla', 94.96, 0, 94.96, 529)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2447, N'10036490', N' Camilla Amaro Santos ', N'Ampla', 94.96, 0, 94.96, 530)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2448, N'10076387', N' Maria Andressa Veloso ', N'Ampla', 94.95, 0, 94.95, 531)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2449, N'10079365', N' Vitor Birck ', N'Ampla', 94.93, 0, 94.93, 532)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2450, N'10062799', N' Jessica Machado Horn ', N'Ampla', 94.9, 0, 94.9, 533)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2451, N'10025931', N' Cesar Rodrigues de Queiroz Macedo ', N'Ampla', 94.9, 0, 94.9, 534)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2452, N'10074481', N' Yara Rodrigues Cardoso ', N'Ampla', 94.88, 0, 94.88, 535)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2453, N'10057522', N' Paula Reginatto Bau ', N'Ampla', 94.87, 0, 94.87, 536)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2454, N'10016295', N' Luiz de Jesus Nunes da Silva ', N'Ampla', 94.87, 0, 94.87, 537)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2455, N'10092406', N' Loren Lopes Machado ', N'Ampla', 94.87, 0, 94.87, 538)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2456, N'10060734', N' Alexandre Schmitz Hoff ', N'Ampla', 94.86, 0, 94.86, 539)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2457, N'10007292', N' Carlos Tadeu de Alencar Barreira Junior ', N'Ampla', 94.82, 0, 94.82, 541)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2458, N'10036387', N' Nilo Gomes Paiva ', N'Ampla', 94.82, 0, 94.82, 542)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2459, N'10058526', N' Catryna Garcia Camargos ', N'Ampla', 94.79, 0, 94.79, 543)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2460, N'10040911', N' Ana Carolina Miranda Abecassis ', N'Ampla', 94.78, 0, 94.78, 544)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2461, N'10018503', N' Higor Douglas Souza Costa ', N'Ampla', 94.78, 0, 94.78, 545)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2462, N'10068688', N' Diogo Silva Naves ', N'Ampla', 94.77, 0, 94.77, 546)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2463, N'10005121', N' Islla Pessoa Fernandes Torres ', N'Ampla', 94.76, 0, 94.76, 547)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2464, N'10029790', N' Filipe Augusto de Souza Viana ', N'Ampla', 94.75, 0, 94.75, 548)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2465, N'10062586', N' Arthur Nunes Correia ', N'Ampla', 94.75, 0, 94.75, 549)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2466, N'10044187', N' Alan Pedro Mendes Coelho ', N'Ampla', 94.75, 0, 94.75, 550)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2467, N'10005523', N' Alline Gomes Pereira ', N'Ampla', 94.74, 0, 94.74, 551)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2468, N'10000429', N' Danniel Dias Rocha ', N'Ampla', 94.74, 0, 94.74, 552)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2469, N'10012955', N' Leonardo Pedro Santos Liborio ', N'Ampla', 94.74, 0, 94.74, 553)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2470, N'10050828', N' Glaucimarlus Souza Ramos ', N'Ampla', 94.72, 0, 94.72, 554)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2471, N'10077467', N' Ana Paula Bombarda ', N'Ampla', 94.71, 0, 94.71, 555)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2472, N'10001574', N' Rodrigo Wallace Oliveira Santos ', N'Ampla', 94.69, 0, 94.69, 556)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2473, N'10000038', N' Ana Clara Nunes Mendes ', N'Ampla', 94.68, 0, 94.68, 558)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2474, N'10020609', N' Lidia Silva Saldanha ', N'Ampla', 94.64, 0, 94.64, 559)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2475, N'10054359', N' Manuela Mota ', N'Ampla', 94.62, 0, 94.62, 560)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2476, N'10061014', N' Fernanda Borges Barros ', N'Ampla', 94.62, 0, 94.62, 561)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2477, N'10091917', N' Ygor Pontes Oliveira de Souza', N'Ampla', 94.61, 0, 94.61, 562)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2478, N'10064716', N' ChristianBorges de Oliveira ', N'Ampla', 94.6, 0, 94.6, 563)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2479, N'10029881', N' Rebeca Bueno Bucci Py ', N'Ampla', 94.58, 0, 94.58, 564)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2480, N'10020031', N' Ananda Fernandes Constantino ', N'Ampla', 94.57, 0, 94.57, 565)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2481, N'10050894', N' Isabela Guimaraes Prado ', N'Ampla', 94.54, 0, 94.54, 566)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2482, N'10019492', N' Jessika Alves dos Santos ', N'Ampla', 94.53, 0, 94.53, 567)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2483, N'10071811', N' Luan Ribeiro Costa ', N'Ampla', 94.51, 0, 94.51, 568)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2484, N'10099045', N' Carla Nazareth Mendes Melo Barros ', N'Ampla', 94.5, 0, 94.5, 569)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2485, N'10049781', N' Joao Pedro Pires Sampaio ', N'Ampla', 94.49, 0, 94.49, 570)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2486, N'10016287', N' Rafaelly Hatherly Rodrigues ', N'Ampla', 94.44, 0, 94.44, 572)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2487, N'10005279', N' Gabriel Lemos de Oliveira ', N'Ampla', 94.43, 0, 94.43, 573)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2488, N'10029886', N' Luisa Morais Costa Teixeira ', N'Ampla', 94.42, 0, 94.42, 574)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2489, N'10068199', N' Debora Alves Sousa ', N'Ampla', 94.41, 0, 94.41, 575)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2490, N'10068392', N' Wender Henrique de Sousa Silva Starling ', N'Ampla', 94.4, 0, 94.4, 576)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2491, N'10005223', N' Raphael Pereira de Medeiros ', N'Ampla', 94.37, 0, 94.37, 577)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2492, N'10011447', N' Maybi Alfredo Fernandes ', N'Ampla', 94.36, 0, 94.36, 578)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2493, N'10000514', N' Iris Esteves Martins Pinto ', N'Ampla', 94.34, 0, 94.34, 579)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2494, N'10012610', N' Andre de Carvalho Pereira ', N'Ampla', 94.34, 0, 94.34, 580)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2495, N'10086809', N' Ana Paula Martins de Aguiar ', N'Ampla', 94.32, 0, 94.32, 581)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2496, N'10079476', N' Lucas Henrik Lira da Silva ', N'Ampla', 94.32, 0, 94.32, 582)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2497, N'10000919', N' Nicolas Miguel Oliveira de Lima ', N'Ampla', 94.3, 0, 94.3, 583)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2498, N'10016274', N' Yara Verlaine Cordeiro Matias ', N'Ampla', 94.3, 0, 94.3, 584)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2499, N'10065594', N' Aime Feitosa da Costa ', N'Ampla', 94.27, 0, 94.27, 585)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2500, N'10065184', N' Ingrid Moreira Felinto de Oliveira ', N'Ampla', 94.21, 0, 94.21, 587)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2501, N'10055695', N' Thiago Carvalho Santos de Souza ', N'Ampla', 94.19, 0, 94.19, 588)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2502, N'10066839', N' Susan Maky Karakida ', N'Ampla', 94.19, 0, 94.19, 589)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2503, N'10031045', N' Danielle Tuanny Alves Ferreira ', N'Ampla', 94.19, 0, 94.19, 590)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2504, N'10077571', N' Henrique Miquelissa Dalcomuni ', N'Ampla', 94.18, 0, 94.18, 591)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2505, N'10087825', N' Larissa Alves da Silva ', N'Ampla', 94.18, 0, 94.18, 592)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2506, N'10098652', N' Igor Bosco Soares ', N'Ampla', 94.17, 0, 94.17, 593)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2507, N'10061065', N' Davi de Souza Moreira ', N'Ampla', 94.16, 0, 94.16, 594)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2508, N'10066884', N' Alexandre Khoury Porto', N'Ampla', 94.14, 0, 94.14, 595)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2509, N'10044879', N' Isaac Lucas Sousa Alves Lima ', N'Ampla', 94.13, 0, 94.13, 596)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2510, N'10036846', N' Natan Rocha Ferreira ', N'Ampla', 94.13, 0, 94.13, 597)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2511, N'10078105', N' Fillipe Alexandrino Barbosa Figueiredo ', N'Ampla', 94.09, 0, 94.09, 598)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2512, N'10033064', N' Danielle Prado de Araujo ', N'Ampla', 94.07, 0, 94.07, 599)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2513, N'10049484', N' Mariana Alves Bontempo ', N'Ampla', 94.07, 0, 94.07, 600)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2514, N'10091099', N' Rhagi Anderson Lira Alvarenga ', N'Ampla', 94.06, 0, 94.06, 601)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2515, N'10007585', N' Raphael Costa Marques dos Santos ', N'Ampla', 94.02, 0, 94.02, 602)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2516, N'10070220', N' Milena Gomes Bezerra ', N'Ampla', 94, 0, 94, 603)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2517, N'10020659', N' Naissa de Sousa Araujo Alves ', N'Ampla', 93.99, 0, 93.99, 604)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2518, N'10054416', N' Thaynara Nunes Cardoso ', N'Ampla', 93.95, 0, 93.95, 605)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2519, N'10027442', N' Priscilla Mendes da Silva ', N'Ampla', 93.92, 0, 93.92, 606)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2520, N'10059163', N' Isabella Ribeiro Araujo ', N'Ampla', 93.92, 0, 93.92, 607)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2521, N'10068081', N' Jalles Moreira Rocha dos Santos ', N'Ampla', 93.88, 0, 93.88, 608)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2522, N'10006868', N' Mayara Leal Fernandes ', N'Ampla', 93.88, 0, 93.88, 609)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2523, N'10005309', N' Laura Maria Damascena Prado ', N'Ampla', 93.83, 0, 93.83, 610)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2524, N'10016005', N' Sahydi Tedesco Abrahao ', N'Ampla', 93.82, 0, 93.82, 611)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2525, N'10042800', N' Lionaria Karine de Morais ', N'Ampla', 93.81, 0, 93.81, 612)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2526, N'10044926', N' Jorge Luis Saturnino da Silva ', N'Ampla', 93.79, 0, 93.79, 613)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2527, N'10055957', N' Danyllo Cardoso Costa ', N'Ampla', 93.79, 0, 93.79, 614)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2528, N'10012569', N' Emilcy Felipe Cumpertino de Paula ', N'Ampla', 93.78, 0, 93.78, 615)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2529, N'10076691', N' Lucas Liberal ', N'Ampla', 93.76, 0, 93.76, 616)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2530, N'10012032', N' Bruna Dutra Donzelli ', N'Ampla', 93.73, 0, 93.73, 617)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2531, N'10026010', N' Danielle Pereira Gonzalez da Silva ', N'Ampla', 93.73, 0, 93.73, 618)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2532, N'10013313', N' Daniela de Paula ', N'Ampla', 93.73, 0, 93.73, 619)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2533, N'10041456', N' Cristian de Sousa Ramos ', N'Ampla', 93.72, 0, 93.72, 620)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2534, N'10012713', N' Leonardo de Moura ', N'Ampla', 93.72, 0, 93.72, 621)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2535, N'10005395', N' Mariana dos Santos Silva ', N'Ampla', 93.7, 0, 93.7, 623)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2536, N'10050556', N' Paloma Asenjo de Macedo ', N'Ampla', 93.7, 0, 93.7, 624)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2537, N'10005978', N' Eduardo Leal Trindade ', N'Ampla', 93.7, 0, 93.7, 625)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2538, N'10033616', N' Isabela Bastos Serwy ', N'Ampla', 93.68, 0, 93.68, 626)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2539, N'10062144', N' Jaquelline Barros de Oliveira ', N'Ampla', 93.65, 0, 93.65, 627)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2540, N'10017242', N' Leonardo Zarattini Martins', N'Ampla', 93.65, 0, 93.65, 628)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2541, N'10059429', N' Marcelo Barbosa Tavares ', N'Ampla', 93.64, 0, 93.64, 629)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2542, N'10028804', N' Amanda Cristina Lopes dos Santos ', N'Ampla', 93.64, 0, 93.64, 630)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2543, N'10006746', N' Giordano Bruno Maciel de Oliveira ', N'Ampla', 93.62, 0, 93.62, 631)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2544, N'10009418', N' Leticia de Aguiar Avelino da Silva ', N'Ampla', 93.61, 0, 93.61, 632)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2545, N'10020774', N' Tauane de Paula Guimaraes ', N'Ampla', 93.61, 0, 93.61, 633)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2546, N'10074226', N' Cleverson Aparecido Garcia Lara ', N'Ampla', 93.6, 0, 93.6, 634)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2547, N'10008013', N' Gustavo Marques de Azevedo ', N'Ampla', 93.54, 0, 93.54, 635)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2548, N'10014275', N' Juliana Pereira Moreira ', N'Ampla', 93.53, 0, 93.53, 636)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2549, N'10088140', N' Josefa Helena de Aguiar ', N'Ampla', 93.53, 0, 93.53, 637)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2550, N'10007509', N' Arielle Lima Celestino ', N'Ampla', 93.51, 0, 93.51, 638)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2551, N'10052229', N' Hugo Alves Feletti ', N'Ampla', 93.5, 0, 93.5, 639)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2552, N'10013138', N' Juliano Pereira dos Santos Abrahao ', N'Ampla', 93.49, 0, 93.49, 640)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2553, N'10008941', N' Paulo Vitor Ferreira Correa ', N'Ampla', 93.48, 0, 93.48, 641)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2554, N'10046475', N' Jeferson Neves da Silva ', N'Ampla', 93.47, 0, 93.47, 642)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2555, N'10040940', N' Virginia de Aguiar Rocha ', N'Ampla', 93.46, 0, 93.46, 643)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2556, N'10077118', N' Fernanda Pimentel Hermida Bernardes ', N'Ampla', 93.46, 0, 93.46, 644)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2557, N'10047785', N' Guilherme Henrique Pereira Ramos ', N'Ampla', 93.45, 0, 93.45, 645)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2558, N'10046573', N' Fernanda Vianna Couto ', N'Ampla', 93.43, 0, 93.43, 646)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2559, N'10008546', N' Andre Holanda Cavalcante Castellanos Hornos ', N'Ampla', 93.43, 0, 93.43, 647)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2560, N'10050396', N' Dyego Barros Luz ', N'Ampla', 93.42, 0, 93.42, 648)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2561, N'10042008', N' Marcus Vinicius Almeida Duarte ', N'Ampla', 93.42, 0, 93.42, 649)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2562, N'10041521', N' Joao Victor Carneiro Alves ', N'Ampla', 93.41, 0, 93.41, 650)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2563, N'10013071', N' Camila de Figueiredo Barbosa Bastos ', N'Ampla', 93.41, 0, 93.41, 651)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2564, N'10013825', N' Joao Felipe Nunes de Miranda ', N'Ampla', 93.38, 0, 93.38, 652)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2565, N'10081774', N' Samuel de Souza Almeida ', N'Ampla', 93.38, 0, 93.38, 653)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2566, N'10027864', N' Sergio Luiz Rosa Junior', N'Ampla', 93.37, 0, 93.37, 654)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2567, N'10009300', N' Valeria Ribeiro da Silva Rocha ', N'Ampla', 93.37, 0, 93.37, 655)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2568, N'10009823', N' Karen Alves Pereira ', N'Ampla', 93.36, 0, 93.36, 656)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2569, N'10072187', N' Adriano Tavares Araujo ', N'Ampla', 93.3, 0, 93.3, 657)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2570, N'10006435', N' Fernanda Lima Gomes de Matos ', N'Ampla', 93.29, 0, 93.29, 658)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2571, N'10040002', N' Matheus Lourenco Ghesso ', N'Ampla', 93.28, 0, 93.28, 659)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2572, N'10043806', N' Rodrigo William Silva de Oliveira ', N'Ampla', 93.24, 0, 93.24, 661)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2573, N'10007831', N' Henrique Luis Costa Gonzaga ', N'Ampla', 93.23, 0, 93.23, 662)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2574, N'10020765', N' Renata Augusto Vieira ', N'Ampla', 93.22, 0, 93.22, 663)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2575, N'10077908', N' Fernanda Maia Bravo Pinheiro ', N'Ampla', 93.22, 0, 93.22, 664)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2576, N'10007273', N' Gibran Daoud ', N'Ampla', 93.2, 0, 93.2, 665)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2577, N'10082863', N' Arthur de Lima Henriques da Silva ', N'Ampla', 93.2, 0, 93.2, 666)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2578, N'10015035', N' Leandro Martins de Sousa Franca ', N'Ampla', 93.2, 0, 93.2, 667)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2579, N'10018196', N' Luana Silva Oliveira ', N'Ampla', 93.15, 0, 93.15, 668)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2580, N'10069921', N' Tomaz Silva Gonzales ', N'Ampla', 93.15, 0, 93.15, 669)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2581, N'10046005', N' Lucas Moreira Rabelo ', N'Ampla', 93.13, 0, 93.13, 670)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2582, N'10039231', N' Guilherme Ribeiro de Araujo ', N'Ampla', 93.13, 0, 93.13, 671)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2583, N'10000947', N' Hugo Daniel Carvalho Pereira ', N'Ampla', 93.11, 0, 93.11, 672)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2584, N'10084191', N' Pedro de Queiroz Soares ', N'Ampla', 93.11, 0, 93.11, 673)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2585, N'10063291', N' Filipi Teles da Silva ', N'Ampla', 93.1, 0, 93.1, 674)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2586, N'10049511', N' Hyan Fellipe Maximo da Silva ', N'Ampla', 93.09, 0, 93.09, 675)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2587, N'10000544', N' Rafael Campos Marques da Costa ', N'Ampla', 93.06, 0, 93.06, 676)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2588, N'10031024', N' Semi Yussef Bjaije Junior ', N'Ampla', 93.06, 0, 93.06, 677)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2589, N'10021363', N' Paloma Pedroza de Sa Formiga ', N'Ampla', 93.05, 0, 93.05, 678)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2590, N'10016055', N' Fernanda Delgado de Vasconcelos ', N'Ampla', 93.04, 0, 93.04, 679)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2591, N'10064748', N' Maisa Sanches Fernandes de Carvalho ', N'Ampla', 93.03, 0, 93.03, 680)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2592, N'10070198', N' Lucas Gabriel de Sousa Lara ', N'Ampla', 93.03, 0, 93.03, 681)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2593, N'10099787', N' Mateus dos Santos Lopes Gomes ', N'Ampla', 93.02, 0, 93.02, 682)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2594, N'10011444', N' Arthur Uranio Mota Coutinho ', N'Ampla', 93.02, 0, 93.02, 683)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2595, N'10052242', N' Danylo Vieira Vasconcelos Oliveira ', N'Ampla', 93.01, 0, 93.01, 684)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2596, N'10044580', N' Isabela Provensani Valentim ', N'Ampla', 92.99, 0, 92.99, 685)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2597, N'10026603', N' Marina Neves de Loiola ', N'Ampla', 92.98, 0, 92.98, 686)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2598, N'10000214', N' Thais Yukiko Queiroz Fukuda ', N'Ampla', 92.98, 0, 92.98, 687)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2599, N'10056914', N' Renan de Sousa Oliveira ', N'Ampla', 92.97, 0, 92.97, 688)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2600, N'10020039', N' Raul Serido Lima ', N'Ampla', 92.95, 0, 92.95, 689)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2601, N'10018583', N' Diego Ribeiro de Souza ', N'Ampla', 92.93, 0, 92.93, 691)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2602, N'10005804', N' Ana Karoline Ferreira ', N'Ampla', 92.93, 0, 92.93, 692)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2603, N'10000436', N' Geislanio de Freitas Amancio ', N'Ampla', 92.92, 0, 92.92, 693)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2604, N'10011859', N' Matusalem Pacheco Lustosa Neto ', N'Ampla', 92.92, 0, 92.92, 694)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2605, N'10009156', N' Stephan Rodrigues Harabedian ', N'Ampla', 92.92, 0, 92.92, 695)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2606, N'10031351', N' Richard Soares Lustosa ', N'Ampla', 92.92, 0, 92.92, 696)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2607, N'10017647', N' Vinicius Fantin Zanatta ', N'Ampla', 92.9, 0, 92.9, 697)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2608, N'10020862', N' Andre Bilro Pereira de Araujo', N'Ampla', 92.89, 0, 92.89, 698)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2609, N'10039584', N' Diego Miranda Esteves ', N'Ampla', 92.87, 0, 92.87, 699)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2610, N'10009193', N' Pamela Cristina Martins da Silva ', N'Ampla', 92.87, 0, 92.87, 700)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2611, N'10003394', N' Natanael Silva Camargo ', N'Ampla', 92.87, 0, 92.87, 701)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2612, N'10085240', N' Laryssa Evelyn Guilardi Araujo ', N'Ampla', 92.87, 0, 92.87, 702)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2613, N'10043275', N' Rafael Maciel Nascimento ', N'Ampla', 92.84, 0, 92.84, 703)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2614, N'10054143', N' Wanderlan Fernandes Guedes Filho ', N'Ampla', 92.83, 0, 92.83, 704)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2615, N'10040844', N' Gustavo Latuf Ayres ', N'Ampla', 92.8, 0, 92.8, 706)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2616, N'10056148', N' Caio Santana Rodrigues de Lima ', N'Ampla', 92.79, 0, 92.79, 707)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2617, N'10007695', N' Mateus Ferreira Leandro de Oliveira ', N'Ampla', 92.78, 0, 92.78, 708)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2618, N'10063302', N' Paulo Augusto Morais de Oliveira ', N'Ampla', 92.78, 0, 92.78, 709)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2619, N'10039686', N' Marcela da Silva de Carvalho ', N'Ampla', 92.77, 0, 92.77, 710)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2620, N'10086362', N' Jose Ademir dos Santos Filho ', N'Ampla', 92.77, 0, 92.77, 711)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2621, N'10037365', N' Eduardo Schuabb Duarte ', N'Ampla', 92.77, 0, 92.77, 712)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2622, N'10065829', N' Pedro de Gusmao dos Reis ', N'Ampla', 92.76, 0, 92.76, 713)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2623, N'10030376', N' Leandro Xavier Rapini ', N'Ampla', 92.71, 0, 92.71, 714)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2624, N'10069819', N' Carina Cardoso Carrijo Lintomen Azevedo ', N'Ampla', 92.71, 0, 92.71, 715)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2625, N'10012939', N' Gabriela Tavares de Oliveira Ferreira ', N'Ampla', 92.7, 0, 92.7, 716)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2626, N'10086801', N' Daniel Duim ', N'Ampla', 92.69, 0, 92.69, 717)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2627, N'10029165', N' Natalia Sartori ', N'Ampla', 92.66, 0, 92.66, 718)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2628, N'10008727', N' Guilherme Cardoso de Lima ', N'Ampla', 92.65, 0, 92.65, 719)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2629, N'10029447', N' Carlos Henrique de Lucena Sampaio Junior ', N'Ampla', 92.64, 0, 92.64, 720)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2630, N'10012221', N' Artur Albuquerque de Queiroga ', N'Ampla', 92.62, 0, 92.62, 721)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2631, N'10031939', N' Francioli Tonin ', N'Ampla', 92.6, 0, 92.6, 722)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2632, N'10082094', N' Larissa Laiz Monteiro de Farias ', N'Ampla', 92.6, 0, 92.6, 723)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2633, N'10054044', N' Luan Vinicios Chagas ', N'Ampla', 92.59, 0, 92.59, 724)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2634, N'10029414', N' Kledson Willy dos Santos Ferreira ', N'Ampla', 92.55, 0, 92.55, 726)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2635, N'10017325', N' Erika Melo Nogueira ', N'Ampla', 92.53, 0, 92.53, 727)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2636, N'10009971', N' Diego Goncalves Ribeiro ', N'Ampla', 92.53, 0, 92.53, 728)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2637, N'10098824', N' Joao Lucas Magalini Zago ', N'Ampla', 92.49, 0, 92.49, 729)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2638, N'10074815', N' Jhemerson Soares Lisboa ', N'Ampla', 92.47, 0, 92.47, 730)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2639, N'10025038', N' Joao Victor Santiago Queiroz', N'Ampla', 92.47, 0, 92.47, 731)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2640, N'10088881', N' Bruno Batista Suehara ', N'Ampla', 92.47, 0, 92.47, 732)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2641, N'10057129', N' Antonio Gabriel Bini Augusto ', N'Ampla', 92.42, 0, 92.42, 733)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2642, N'10066392', N' Elineide Maheli de Oliveira Carvalho Zigunow ', N'Ampla', 92.42, 0, 92.42, 734)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2643, N'10038132', N' Genisson dos Reis Santos ', N'Ampla', 92.41, 0, 92.41, 735)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2644, N'10053500', N' Andre Augusto Braz Mota ', N'Ampla', 92.37, 0, 92.37, 736)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2645, N'10007387', N' Breno Macedo Aquery ', N'Ampla', 92.36, 0, 92.36, 737)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2646, N'10031960', N' Thiago de Souza Francisco ', N'Ampla', 92.35, 0, 92.35, 738)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2647, N'10059002', N' Leandro Simoes Dias ', N'Ampla', 92.34, 0, 92.34, 739)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2648, N'10014085', N' Amanda Valerio Olsen ', N'Ampla', 92.34, 0, 92.34, 740)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2649, N'10007878', N' Ajalmar Andrade Moura Segundo ', N'Ampla', 92.33, 0, 92.33, 741)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2650, N'10012173', N' Tais Bottecchia ', N'Ampla', 92.33, 0, 92.33, 742)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2651, N'10001949', N' Maiara Teodoro ', N'Ampla', 92.32, 0, 92.32, 743)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2652, N'10098138', N' Nathalia Micaelle Nunes de Oliveira ', N'Ampla', 92.31, 0, 92.31, 744)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2653, N'10039123', N' Michell Victor Matos Mourao ', N'Ampla', 92.3, 0, 92.3, 745)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2654, N'10013872', N' Ismael Rodrigues dos Santos ', N'Ampla', 92.29, 0, 92.29, 746)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2655, N'10069470', N' Lucas Magalhaes Prates de Lima ', N'Ampla', 92.27, 0, 92.27, 747)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2656, N'10030669', N' Raphael Nepomuceno de Menezes ', N'Ampla', 92.27, 0, 92.27, 748)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2657, N'10082307', N' Alan Guedes Siqueira ', N'Ampla', 92.27, 0, 92.27, 749)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2658, N'10036197', N' Mariana Pereira Batista ', N'Ampla', 92.26, 0, 92.26, 750)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2659, N'10001641', N' Melisa Adriana Silva Pimenta ', N'Ampla', 92.22, 0, 92.22, 751)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2660, N'10097154', N' Carla Geovana Chagas Pereira ', N'Ampla', 92.22, 0, 92.22, 752)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2661, N'10063966', N' Thales Luiz Melo Silva ', N'Ampla', 92.21, 0, 92.21, 753)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2662, N'10091029', N' Luciana Caetano Yamanaka ', N'Ampla', 92.2, 0, 92.2, 754)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2663, N'10020201', N' Pedro Alves Ferreira ', N'Ampla', 92.19, 0, 92.19, 755)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2664, N'10016035', N' Rafael Possatto da Silva ', N'Ampla', 92.17, 0, 92.17, 756)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2665, N'10022555', N' Julio Cesar Batista Leitao ', N'Ampla', 92.17, 0, 92.17, 757)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2666, N'10003927', N' Kleber Amano Cipriano ', N'Ampla', 92.14, 0, 92.14, 758)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2667, N'10015457', N' Thais Ribeiro Santiago ', N'Ampla', 92.12, 0, 92.12, 759)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2668, N'10052088', N' Diego Rafael Sena Gomes ', N'Ampla', 92.05, 0, 92.05, 760)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2669, N'10017398', N' Dayvisson de Paula Climaco', N'Ampla', 92.03, 0, 92.03, 761)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2670, N'10070741', N' Renan Emerson Oliveira Cavalcante ', N'Ampla', 92.01, 0, 92.01, 762)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2671, N'10047536', N' Thiago Melo Soares ', N'Ampla', 91.99, 0, 91.99, 763)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2672, N'10004957', N' Raianny Moreira Soares ', N'Ampla', 91.98, 0, 91.98, 764)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2673, N'10065570', N' Leandro Miranda Costa ', N'Ampla', 91.95, 0, 91.95, 765)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2674, N'10003525', N' Felipe Torres Martins de Serpa ', N'Ampla', 91.95, 0, 91.95, 766)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2675, N'10050489', N' Lucas Rodrigues Rego ', N'Ampla', 91.94, 0, 91.94, 768)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2676, N'10059650', N' Arthur Tamayo de Lima', N'Ampla', 91.92, 0, 91.92, 769)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2677, N'10055353', N' Ricardo da Silva Pereira Junior ', N'Ampla', 91.91, 0, 91.91, 771)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2678, N'10006574', N' Sandro Carvalho Kusano ', N'Ampla', 91.88, 0, 91.88, 772)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2679, N'10019587', N' Otavio Henrique Oliveira Ferreira ', N'Ampla', 91.86, 0, 91.86, 773)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2680, N'10002384', N' Raul Furieri Pignaton Camargo de Azevedo ', N'Ampla', 91.85, 0, 91.85, 774)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2681, N'10047326', N' Ismael Verissimo dos Santos Junior ', N'Ampla', 91.84, 0, 91.84, 775)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2682, N'10023217', N' Daniel Dias Ribeiro ', N'Ampla', 91.84, 0, 91.84, 776)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2683, N'10002262', N' Amana dos Santos Nesimi ', N'Ampla', 91.83, 0, 91.83, 777)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2684, N'10061459', N' Ilane Vieira Nunes ', N'Ampla', 91.83, 0, 91.83, 778)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2685, N'10055608', N' Joao Victor Carvalho Freire Bezerra ', N'Ampla', 91.82, 0, 91.82, 779)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2686, N'10030596', N' Elanio Cavalcante Fontenele ', N'Ampla', 91.77, 0, 91.77, 780)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2687, N'10001681', N' Marcelo dos Reis Brandao Rosa ', N'Ampla', 91.76, 0, 91.76, 782)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2688, N'10010832', N' Kassius Anchesqui Nardoto ', N'Ampla', 91.75, 0, 91.75, 783)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2689, N'10025593', N' Daniel Ghetti do Prado ', N'Ampla', 91.74, 0, 91.74, 784)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2690, N'10025957', N' Carolina Athayde Azambuja ', N'Ampla', 91.73, 0, 91.73, 785)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2691, N'10012306', N' Fabio de Godoy Penteado ', N'Ampla', 91.73, 0, 91.73, 786)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2692, N'10036306', N' Matheus Dantas Machado ', N'Ampla', 91.71, 0, 91.71, 788)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2693, N'10055438', N' Saulo Renan de Sousa e Silva ', N'Ampla', 91.71, 0, 91.71, 789)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2694, N'10031443', N' Elizabeth Cristina Tenreiro Cavalcante ', N'Ampla', 91.7, 0, 91.7, 790)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2695, N'10037100', N' Gabrielle Gomes da Silva ', N'Ampla', 91.67, 0, 91.67, 791)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2696, N'10005731', N' Lais Barreto de Araujo ', N'Ampla', 91.67, 0, 91.67, 792)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2697, N'10004709', N' Jessica Oliveira Neiva ', N'Ampla', 91.65, 0, 91.65, 793)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2698, N'10020521', N' Rafael Sampaio Braga ', N'Ampla', 91.65, 0, 91.65, 794)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2699, N'10018084', N' Cindy de Souza Tavares ', N'Ampla', 91.65, 0, 91.65, 795)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2700, N'10004508', N' Leonardo Meneses Cabral ', N'Ampla', 91.64, 0, 91.64, 796)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2701, N'10108417', N' Rodrigo Pereira Santos', N'Ampla', 91.63, 0, 91.63, 798)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2702, N'10073276', N' Alex Rosa de Jesus ', N'Ampla', 91.63, 0, 91.63, 799)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2703, N'10014688', N' Daniel Viny Dourado Costa ', N'Ampla', 91.61, 0, 91.61, 800)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2704, N'10067040', N' Bruno Bergamaschi Mazega ', N'Ampla', 91.61, 0, 91.61, 801)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2705, N'10007397', N' Luiz Tadeu Miranda da Silva ', N'Ampla', 91.6, 0, 91.6, 802)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2706, N'10011772', N' Solange Stefany de Faria ', N'Ampla', 91.54, 0, 91.54, 803)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2707, N'10009413', N' Dario Carlos Ribeiro Ramires Junior ', N'Ampla', 91.54, 0, 91.54, 804)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2708, N'10060836', N' Lucas da Costa Lima ', N'Ampla', 91.53, 0, 91.53, 805)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2709, N'10070759', N' Gibran Kahlil Gazel ', N'Ampla', 91.52, 0, 91.52, 806)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2710, N'10057541', N' Mateus Ribeiro Araujo ', N'Ampla', 91.5, 0, 91.5, 807)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2711, N'10032447', N' Joao Luiz Farinon ', N'Ampla', 91.5, 0, 91.5, 808)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2712, N'10003680', N' Julio Cesar Lima Madalena', N'Ampla', 91.5, 0, 91.5, 809)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2713, N'10021147', N' Gabriel Henrique Silva Araujo ', N'Ampla', 91.49, 0, 91.49, 810)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2714, N'10082231', N' Kemylla Passos Mesquita ', N'Ampla', 91.47, 0, 91.47, 811)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2715, N'10059697', N' Ronei Ademir Wolff Athayde Junior ', N'Ampla', 91.47, 0, 91.47, 812)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2716, N'10000074', N' Tomas Pinheiro Della Giustina ', N'Ampla', 91.46, 0, 91.46, 813)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2717, N'10058577', N' Juliana Bertoldo Alvares ', N'Ampla', 91.45, 0, 91.45, 814)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2718, N'10053221', N' Jose Igor Rocha de Moura ', N'Ampla', 91.43, 0, 91.43, 815)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2719, N'10055835', N' Daniel dos Anjos Gomes da Silva ', N'Ampla', 91.42, 0, 91.42, 816)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2720, N'10105811', N' Lucas Manoel Costa ', N'Ampla', 91.4, 0, 91.4, 817)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2721, N'10059435', N' Gabriel Ismael da Silva ', N'Ampla', 91.38, 0, 91.38, 818)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2722, N'10002030', N' Davi Teixeira e Silva ', N'Ampla', 91.38, 0, 91.38, 819)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2723, N'10017768', N' Manuel de Oliveira Vasconcelos Junior ', N'Ampla', 91.36, 0, 91.36, 820)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2724, N'10037112', N' Isabelle Nolasco de Oliveira ', N'Ampla', 91.35, 0, 91.35, 821)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2725, N'10000270', N' Cristiane Ferras Bolico Rodrigues da Silva ', N'Ampla', 91.34, 0, 91.34, 823)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2726, N'10008273', N' Adenilson Rutsatz ', N'Ampla', 91.34, 0, 91.34, 824)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2727, N'10017729', N' Bruno Uemura Ribeiro ', N'Ampla', 91.33, 0, 91.33, 825)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2728, N'10108961', N' Samuel Goncalves dos Santos ', N'Ampla', 91.33, 0, 91.33, 826)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2729, N'10001028', N' Maria Luiza Porfiro Estevao de Oliveira ', N'Ampla', 91.32, 0, 91.32, 827)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2730, N'10059212', N' Leonardo Leandro Furquim ', N'Ampla', 91.32, 0, 91.32, 828)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2731, N'10006869', N' Paulo Henrique de Oliveira Sousa ', N'Ampla', 91.31, 0, 91.31, 830)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2732, N'10030787', N' Isabela Marques Santos ', N'Ampla', 91.29, 0, 91.29, 831)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2733, N'10012630', N' Marcelo Rezende do Nascimento ', N'Ampla', 91.28, 0, 91.28, 832)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2734, N'10022391', N' Samuel da Silva Rodrigues ', N'Ampla', 91.28, 0, 91.28, 833)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2735, N'10097045', N' Leonardo de Oliveira Ramos', N'Ampla', 91.26, 0, 91.26, 834)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2736, N'10015593', N' Leonardo Soares Albuquerque ', N'Ampla', 91.25, 0, 91.25, 835)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2737, N'10014692', N' Yago de Mello Santos ', N'Ampla', 91.25, 0, 91.25, 836)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2738, N'10076115', N' Rafael Ferreira Dutra ', N'Ampla', 91.22, 0, 91.22, 837)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2739, N'10037673', N' Marcos Paulo Martins Luciano ', N'Ampla', 91.21, 0, 91.21, 838)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2740, N'10007414', N' Luiz Antonio Euzebio de Freitas Filho ', N'Ampla', 91.2, 0, 91.2, 839)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2741, N'10039365', N' Rodrigo Gabriel Costa Fortuna ', N'Ampla', 91.2, 0, 91.2, 840)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2742, N'10055844', N' Larissa Cardoso Lacerda ', N'Ampla', 91.17, 0, 91.17, 841)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2743, N'10054823', N' Vivian Moreira de Moura Maia ', N'Ampla', 91.16, 0, 91.16, 842)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2744, N'10043070', N' Carlos Fernando Rodrigues Santos Barbosa ', N'Ampla', 91.14, 0, 91.14, 843)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2745, N'10086689', N' Gabriel Nasser Saad Filho ', N'Ampla', 91.13, 0, 91.13, 844)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2746, N'10070261', N' Rafael Henrique Soares Nogueira Rocha ', N'Ampla', 91.13, 0, 91.13, 845)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2747, N'10060277', N' Rodrigo Goncalves Recalde ', N'Ampla', 91.12, 0, 91.12, 846)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2748, N'10044914', N' Luis Felipe Torres Caetano ', N'Ampla', 91.11, 0, 91.11, 847)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2749, N'10003335', N' Geanderson Ramos de Alencar ', N'Ampla', 91.11, 0, 91.11, 848)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2750, N'10027489', N' Flavio Toscano Alves ', N'Ampla', 91.1, 0, 91.1, 849)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2751, N'10006031', N' Amanda Juliana Rocha Araujo ', N'Ampla', 91.09, 0, 91.09, 850)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2752, N'10031054', N' Rodrigo Chogri Galli ', N'Ampla', 91.07, 0, 91.07, 852)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2753, N'10060776', N' Raquel Veras Valenca ', N'Ampla', 91.06, 0, 91.06, 853)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2754, N'10097750', N' Gabriela Teixeira Pazzine ', N'Ampla', 91.05, 0, 91.05, 854)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2755, N'10029743', N' Charlles Henrique Rodrigues Pereira ', N'Ampla', 91.04, 0, 91.04, 855)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2756, N'10058996', N' Alan Verlaine Dias Silva ', N'Ampla', 91.03, 0, 91.03, 856)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2757, N'10071326', N' Larissa Borges Fogaca ', N'Ampla', 91.03, 0, 91.03, 857)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2758, N'10012115', N' Guilherme Bicalho Monteiro de Castro ', N'Ampla', 91.03, 0, 91.03, 858)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2759, N'10084583', N' Pollyana Barros da Silva Pacheco ', N'Ampla', 91.01, 0, 91.01, 859)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2760, N'10066207', N' Werner Heisenberg Santos Figueiredo ', N'Ampla', 91.01, 0, 91.01, 860)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2761, N'10053367', N' Tayna Passos Nunes Leal ', N'Ampla', 91.01, 0, 91.01, 861)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2762, N'10005748', N' Diego Moreira Carmino ', N'Ampla', 91.01, 0, 91.01, 862)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2763, N'10003440', N' Eduardo Lucas de Sousa Borges ', N'Ampla', 91, 0, 91, 863)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2764, N'10051167', N' Tallys Henrique Crico Pimentel ', N'Ampla', 90.96, 0, 90.96, 864)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2765, N'10055332', N' Marcos Tadeu Souza Aquino ', N'Ampla', 90.96, 0, 90.96, 865)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2766, N'10003960', N' Samuel Silva Rocha Lima ', N'Ampla', 90.95, 0, 90.95, 866)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2767, N'10024477', N' Andrea Costa de Lucena ', N'Ampla', 90.95, 0, 90.95, 867)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2768, N'10008480', N' Ellyka de Queiroz Ornelas Araujo ', N'Ampla', 90.94, 0, 90.94, 868)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2769, N'10000040', N' Paulo Roberto Rodrigues da Silva ', N'Ampla', 90.93, 0, 90.93, 869)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2770, N'10013363', N' Matheus Nishiyama Pedroca ', N'Ampla', 90.93, 0, 90.93, 870)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2771, N'10011183', N' Alexandre Meirelles Martins ', N'Ampla', 90.92, 0, 90.92, 871)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2772, N'10019543', N' Monike Pontes Silva ', N'Ampla', 90.9, 0, 90.9, 872)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2773, N'10010241', N' Robson Albertassi ', N'Ampla', 90.88, 0, 90.88, 873)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2774, N'10025984', N' Anderson Garofalo Pinto ', N'Ampla', 90.87, 0, 90.87, 874)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2775, N'10031257', N' Carlos Fernando Costa Silva ', N'Ampla', 90.86, 0, 90.86, 875)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2776, N'10006470', N' Milena Guimaraes Oliveira ', N'Ampla', 90.86, 0, 90.86, 876)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2777, N'10007367', N' Karla Pereira Alves ', N'Ampla', 90.86, 0, 90.86, 877)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2778, N'10021047', N' Tainan Lima Bueno ', N'Ampla', 90.84, 0, 90.84, 878)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2779, N'10046944', N' Angelo Jose da Silva Filho ', N'Ampla', 90.82, 0, 90.82, 879)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2780, N'10035019', N' Allison Almeida Declie ', N'Ampla', 90.81, 0, 90.81, 880)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2781, N'10014617', N' Aluan Augusto de Melo Neves ', N'Ampla', 90.81, 0, 90.81, 881)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2782, N'10001420', N' Gregorio Fernandes Pimenta dos Anjos ', N'Ampla', 90.8, 0, 90.8, 882)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2783, N'10053819', N' Gilberto Andre da Costa Filho ', N'Ampla', 90.79, 0, 90.79, 883)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2784, N'10024893', N' Scarlet Pereira Pena ', N'Ampla', 90.77, 0, 90.77, 884)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2785, N'10015369', N' Camila Viviane Araujo dos Santos ', N'Ampla', 90.76, 0, 90.76, 885)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2786, N'10032780', N' Eduardo Marques de Souza ', N'Ampla', 90.75, 0, 90.75, 886)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2787, N'10026936', N' Diego Machado dos Santos ', N'Ampla', 90.74, 0, 90.74, 887)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2788, N'10028910', N' Carolyne Thaina de Holanda Cavalcante ', N'Ampla', 90.72, 0, 90.72, 889)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2789, N'10073138', N' Renan Hiroshi Kuba ', N'Ampla', 90.71, 0, 90.71, 890)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2790, N'10013026', N' Fernanda Caetano Raffs Strasser ', N'Ampla', 90.68, 0, 90.68, 891)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2791, N'10018115', N' Lucas Ribeiro de Miranda ', N'Ampla', 90.68, 0, 90.68, 892)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2792, N'10097142', N' Luciano Reis de Oliveira Silva ', N'Ampla', 90.68, 0, 90.68, 893)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2793, N'10064343', N' Raphael Santos Dantas ', N'Ampla', 90.68, 0, 90.68, 894)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2794, N'10031616', N' Joucafly Arruda Santos ', N'Ampla', 90.65, 0, 90.65, 895)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2795, N'10063368', N' Diego Batista Morais e Silva ', N'Ampla', 90.65, 0, 90.65, 896)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2796, N'10009814', N' Talita Guieiro Ribeiro Rocha', N'Ampla', 90.63, 0, 90.63, 897)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2797, N'10014465', N' Matheus Machado Mendes de Figueiredo ', N'Ampla', 90.61, 0, 90.61, 898)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2798, N'10005369', N' Wanderson Phelipe Soares de Franca ', N'Ampla', 90.59, 0, 90.59, 899)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2799, N'10044049', N' Rodrigo de Lima Rodrigues ', N'Ampla', 90.53, 0, 90.53, 900)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2800, N'10058769', N' Thayane Erika Cruz Maciel ', N'Ampla', 90.53, 0, 90.53, 901)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2801, N'10049778', N' Silas Edson Martins ', N'Ampla', 90.52, 0, 90.52, 902)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2802, N'10037693', N' Jessica Camargo de Amorim ', N'Ampla', 90.52, 0, 90.52, 903)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2803, N'10022011', N' Jaqueline Alves Alencar ', N'Ampla', 90.51, 0, 90.51, 904)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2804, N'10015503', N' Isabella Santos da Silva ', N'Ampla', 90.51, 0, 90.51, 905)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2805, N'10065333', N' Geisiane Peixoto Borges ', N'Ampla', 90.51, 0, 90.51, 906)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2806, N'10053254', N' Ana Paula Alvarenga Martins ', N'Ampla', 90.51, 0, 90.51, 907)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2807, N'10079222', N' Cynthia Magalhaes da Costa ', N'Ampla', 90.49, 0, 90.49, 908)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2808, N'10046722', N' Herbert Fraga Sousa de Oliveira ', N'Ampla', 90.48, 0, 90.48, 909)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2809, N'10025771', N' Sarah Paulino da Silva Melo ', N'Ampla', 90.47, 0, 90.47, 910)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2810, N'10040528', N' Thaina Caroline Eleto ', N'Ampla', 90.46, 0, 90.46, 911)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2811, N'10071025', N' Isabela Laus Saldanha ', N'Ampla', 90.46, 0, 90.46, 912)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2812, N'10074826', N' Tiago Guarda ', N'Ampla', 90.43, 0, 90.43, 913)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2813, N'10005198', N' Gabryella Melo Silveira ', N'Ampla', 90.42, 0, 90.42, 914)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2814, N'10015152', N' Gabriel de Campos Soares Lopes ', N'Ampla', 90.42, 0, 90.42, 915)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2815, N'10044541', N' Carlo Henrique Trajano Gontijo Moraes ', N'Ampla', 90.42, 0, 90.42, 916)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2816, N'10015698', N' Sharon Anne Nogueira Barros ', N'Ampla', 90.41, 0, 90.41, 917)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2817, N'10024684', N' Lenai Martins Oliveira ', N'Ampla', 90.39, 0, 90.39, 918)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2818, N'10008930', N' Aloisio Jose da Silva Junior', N'Ampla', 90.38, 0, 90.38, 919)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2819, N'10028855', N' Lorrayne Virote da Silva ', N'Ampla', 90.36, 0, 90.36, 920)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2820, N'10003124', N' Lisle Marina Araujo do Nascimento ', N'Ampla', 90.35, 0, 90.35, 921)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2821, N'10014097', N' Gabriela Alves Costa ', N'Ampla', 90.35, 0, 90.35, 922)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2822, N'10030564', N' Raissa Gomes Riotinto ', N'Ampla', 90.35, 0, 90.35, 923)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2823, N'10035122', N' Moacir Gomes Duarte Filho ', N'Ampla', 90.35, 0, 90.35, 924)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2824, N'10033863', N' Matheus de Oliveira Assis ', N'Ampla', 90.31, 0, 90.31, 925)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2825, N'10030060', N' Jose Igor Feitosa do Nascimento ', N'Ampla', 90.31, 0, 90.31, 926)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2826, N'10004031', N' Daniel Fonseca Pimentel ', N'Ampla', 90.28, 0, 90.28, 928)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2827, N'10020273', N' Renan Andre de Oliveira Soares ', N'Ampla', 90.27, 0, 90.27, 929)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2828, N'10053929', N' Bruno de Sousa Barros ', N'Ampla', 90.25, 0, 90.25, 930)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2829, N'10078993', N' Jessica Gomes de Almeida Maia ', N'Ampla', 90.25, 0, 90.25, 931)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2830, N'10049073', N' Joao Guilherme Martins Soares ', N'Ampla', 90.23, 0, 90.23, 932)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2831, N'10002759', N' Luiz Guilherme Campos de Oliveira ', N'Ampla', 90.18, 0, 90.18, 933)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2832, N'10034064', N' Marcos Henrique de Lima Souza ', N'Ampla', 90.13, 0, 90.13, 936)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2833, N'10055880', N' Jorge Henrique Neves Alcantara Junior ', N'Ampla', 90.13, 0, 90.13, 937)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2834, N'10025983', N' Andre Luis Areias de Moraes ', N'Ampla', 90.13, 0, 90.13, 938)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2835, N'10004645', N' Ana Clara de Almeida Bossi Guimaraes ', N'Ampla', 90.13, 0, 90.13, 939)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2836, N'10046562', N' Hyara Pereira Cumaru ', N'Ampla', 90.1, 0, 90.1, 940)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2837, N'10042309', N' Monique Temp da Silva ', N'Ampla', 90.1, 0, 90.1, 941)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2838, N'10079484', N' Vinicius Borges Miatelo ', N'Ampla', 90.09, 0, 90.09, 943)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2839, N'10033112', N' Salatiel Pereira de Freitas ', N'Ampla', 90.09, 0, 90.09, 944)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2840, N'10000230', N' Emely Crisley Florentino Lemos ', N'Ampla', 90.09, 0, 90.09, 945)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2841, N'10073716', N' Thamyrys dos Santos Araujo ', N'Ampla', 90.08, 0, 90.08, 946)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2842, N'10062483', N' William Araujo Moreira Nunes ', N'Ampla', 90.08, 0, 90.08, 947)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2843, N'10029562', N' Joao Vitor da Silva Morais ', N'Ampla', 90.04, 0, 90.04, 948)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2844, N'10005253', N' Pedro Henrique de Araujo Souza Junior ', N'Ampla', 90.03, 0, 90.03, 949)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2845, N'10085083', N' Mateus Henriques de Carvalho', N'Ampla', 90.02, 0, 90.02, 950)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2846, N'10070584', N' Maisa Gomes Chaves', N'Ampla', 90.02, 0, 90.02, 951)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2847, N'10085656', N' Diego Bezerra Barbosa ', N'Ampla', 90.02, 0, 90.02, 952)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2848, N'10037884', N' Dayane Lucia Pires Ferreira ', N'Ampla', 90.01, 0, 90.01, 953)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2849, N'10058830', N' Aline Machado dos Santos ', N'Ampla', 89.98, 0, 89.98, 954)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2850, N'10053403', N' Bruno Barbosa da Silva ', N'Ampla', 89.98, 0, 89.98, 955)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2851, N'10066533', N' Cintia Almeida Barbosa ', N'Ampla', 89.96, 0, 89.96, 956)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2852, N'10003274', N' Mateus Melo Souza ', N'Ampla', 89.95, 0, 89.95, 957)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2853, N'10058322', N' Arthur Machado Gomes Barbosa Souto ', N'Ampla', 89.93, 0, 89.93, 958)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2854, N'10009208', N' Ulysses de Oliveira Barbosa ', N'Ampla', 89.89, 0, 89.89, 959)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2855, N'10077154', N' Phelipe Sacramento Silva ', N'Ampla', 89.88, 0, 89.88, 960)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2856, N'10012700', N' Rafael Fleury Mainardi ', N'Ampla', 89.88, 0, 89.88, 961)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2857, N'10000197', N' Ana Jessica Figueiredo Dutra ', N'Ampla', 89.88, 0, 89.88, 962)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2858, N'10012441', N' Gabriel Paiva Brito ', N'Ampla', 89.87, 0, 89.87, 963)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2859, N'10050553', N' Jose Carlos Nogueira Ferreira ', N'Ampla', 89.85, 0, 89.85, 964)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2860, N'10083609', N' Felipe Franco do Vale ', N'Ampla', 89.84, 0, 89.84, 965)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2861, N'10052216', N' Thaynara Ferreira de Andrade ', N'Ampla', 89.84, 0, 89.84, 966)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2862, N'10004510', N' Alexandre Nepomuceno da Fonseca Meneses ', N'Ampla', 89.83, 0, 89.83, 967)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2863, N'10053883', N' Dante Akira Uwai ', N'Ampla', 89.82, 0, 89.82, 968)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2864, N'10011935', N' Luiz Henrique Rodrigues Muniz ', N'Ampla', 89.81, 0, 89.81, 969)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2865, N'10096774', N' Adriana Luiza de Oliveira Silva ', N'Ampla', 89.8, 0, 89.8, 970)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2866, N'10007541', N' Luiz Guilherme Araujo de Andrade ', N'Ampla', 89.79, 0, 89.79, 971)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2867, N'10001752', N' Vicente Resende Cardoso Filho ', N'Ampla', 89.75, 0, 89.75, 972)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2868, N'10025297', N' Barbara Rodrigues Sampaio ', N'Ampla', 89.73, 0, 89.73, 973)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2869, N'10069582', N' Caio Vinicius Aguiar de Andrade ', N'Ampla', 89.73, 0, 89.73, 974)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2870, N'10030612', N' Breno Vinicius de Sousa Duarte ', N'Ampla', 89.72, 0, 89.72, 975)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2871, N'10036667', N' Felipe Elias Menezes ', N'Ampla', 89.72, 0, 89.72, 976)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2872, N'10008648', N' Amanda Gomes Moreira ', N'Ampla', 89.71, 0, 89.71, 977)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2873, N'10026533', N' Joao Vitor Afonso Ribeiro de Oliveira ', N'Ampla', 89.71, 0, 89.71, 978)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2874, N'10019726', N' Hudson Henrique Calixto Eller ', N'Ampla', 89.71, 0, 89.71, 979)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2875, N'10068311', N' Jose Carlos Dias de Souza Junior ', N'Ampla', 89.66, 0, 89.66, 980)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2876, N'10078445', N' Felipe Goncalves Muniz ', N'Ampla', 89.65, 0, 89.65, 981)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2877, N'10061009', N' Fagner Galvao Fernandes ', N'Ampla', 89.62, 0, 89.62, 982)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2878, N'10028171', N' Egon Vinicius Dalinghaus ', N'Ampla', 89.62, 0, 89.62, 983)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2879, N'10057153', N' Joao Victor Nogueira Ribeiro Nunes Clemente ', N'Ampla', 89.61, 0, 89.61, 984)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2880, N'10031799', N' Guilherme Farias Prux ', N'Ampla', 89.61, 0, 89.61, 985)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2881, N'10067942', N' Lorrany Gregorio Magalhaes ', N'Ampla', 89.6, 0, 89.6, 986)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2882, N'10061338', N' Hebert Kley Lageano de Oliveira ', N'Ampla', 89.57, 0, 89.57, 987)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2883, N'10100683', N' Bruno Soares Santos Araujo ', N'Ampla', 89.57, 0, 89.57, 988)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2884, N'10016145', N' Thais Ferreira Ramos ', N'Ampla', 89.57, 0, 89.57, 989)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2885, N'10042798', N' Flavia Maria Alves Caetano ', N'Ampla', 89.56, 0, 89.56, 990)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2886, N'10011781', N' Paulo do Couto Naves ', N'Ampla', 89.53, 0, 89.53, 991)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2887, N'10052049', N' Ariana Engelmann Rodrigues Aragao ', N'Ampla', 89.51, 0, 89.51, 992)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2888, N'10038788', N' Guilherme Almeida de Brito Barutti ', N'Ampla', 89.51, 0, 89.51, 993)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2889, N'10103953', N' Jonatas Aryel de Araujo Silva ', N'Ampla', 89.51, 0, 89.51, 994)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2890, N'10077481', N' Handerson Jose dos Santos ', N'Ampla', 89.49, 0, 89.49, 995)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2891, N'10047420', N' Jhonatan Testa ', N'Ampla', 89.48, 0, 89.48, 996)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2892, N'10051563', N' Jamile Lobao Teixeira ', N'Ampla', 89.48, 0, 89.48, 997)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2893, N'10070990', N' Marco Aurelio Silva ', N'Ampla', 89.48, 0, 89.48, 998)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2894, N'10023180', N' Rafael da Silva Lopes ', N'Ampla', 89.47, 0, 89.47, 999)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2895, N'10011506', N' Jonathan Henrique Wanderley dos Santos ', N'Ampla', 89.47, 0, 89.47, 1000)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2896, N'10045352', N' Valter Rafael Souza Marques ', N'Ampla', 89.46, 0, 89.46, 1001)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2897, N'10000116', N' Yasmin Ramos Espicalsky ', N'Ampla', 89.45, 0, 89.45, 1002)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2898, N'10058364', N' Ariadna Jesus Lopes da Silva ', N'Ampla', 89.45, 0, 89.45, 1003)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2899, N'10035362', N' Lucas Augusto Abbott Jacob ', N'Ampla', 89.44, 0, 89.44, 1004)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2900, N'10070907', N' Lara Sena Scapetti Almeida ', N'Ampla', 89.43, 0, 89.43, 1005)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2901, N'10017407', N' Rafael da Silva Farias ', N'Ampla', 89.43, 0, 89.43, 1006)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2902, N'10030914', N' Francisco Eduardo Vieira de Araujo ', N'Ampla', 89.41, 0, 89.41, 1007)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2903, N'10092784', N' Marcos da Silveira Leal ', N'Ampla', 89.39, 0, 89.39, 1008)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2904, N'10038969', N' Patrick Cardoso dos Santos ', N'Ampla', 89.37, 0, 89.37, 1009)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2905, N'10020038', N' Natan Carlos da Cunha Costa ', N'Ampla', 89.36, 0, 89.36, 1010)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2906, N'10053094', N' Rafael Barbacena e Souza ', N'Ampla', 89.35, 0, 89.35, 1011)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2907, N'10015196', N' Joao Victor dos Santos Rodrigues ', N'Ampla', 89.35, 0, 89.35, 1012)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2908, N'10002523', N' Luiza Pinheiro Andrade Viana ', N'Ampla', 89.33, 0, 89.33, 1013)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2909, N'10021602', N' Joao Batista Sousa Monteiro Junior ', N'Ampla', 89.32, 0, 89.32, 1014)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2910, N'10007689', N' Eduardo Basilio de Albuquerque ', N'Ampla', 89.29, 0, 89.29, 1015)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2911, N'10077827', N' Thiago Baracho Goncalves ', N'Ampla', 89.29, 0, 89.29, 1016)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2912, N'10076448', N' Jorge Thiago Silva Silveira ', N'Ampla', 89.27, 0, 89.27, 1017)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2913, N'10005190', N' Joao Paulo Pinto Van Der Vliet ', N'Ampla', 89.25, 0, 89.25, 1018)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2914, N'10021154', N' Gisella Teixeira Guimaraes Moreira ', N'Ampla', 89.23, 0, 89.23, 1019)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2915, N'10028673', N' Celso Rafael de Melo Silva ', N'Ampla', 89.23, 0, 89.23, 1020)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2916, N'10020658', N' Plabyo Geanine Nunes de Oliveira ', N'Ampla', 89.23, 0, 89.23, 1021)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2917, N'10082497', N' Victor Castro da Costa ', N'Ampla', 89.23, 0, 89.23, 1022)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2918, N'10005857', N' Allan Cezar de Andrade Silva ', N'Ampla', 89.21, 0, 89.21, 1023)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2919, N'10041199', N' Danilo Feitoza Melo ', N'Ampla', 89.21, 0, 89.21, 1024)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2920, N'10048239', N' Ives Plinio de Jesus Oliveira ', N'Ampla', 89.2, 0, 89.2, 1025)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2921, N'10044808', N' Milena Ribeiro da Rocha ', N'Ampla', 89.2, 0, 89.2, 1026)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2922, N'10013602', N' Juliana Lopes Navarro ', N'Ampla', 89.19, 0, 89.19, 1027)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2923, N'10003590', N' Gustavo Cruz Damico Campello ', N'Ampla', 89.18, 0, 89.18, 1028)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2924, N'10011294', N' Rafael Lucas Souza ', N'Ampla', 89.18, 0, 89.18, 1029)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2925, N'10003320', N' Julia Beutel Semenzato Ferrer ', N'Ampla', 89.17, 0, 89.17, 1030)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2926, N'10055138', N' Dalila Vilas Boas Souza Magalhaes da Silva ', N'Ampla', 89.17, 0, 89.17, 1031)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2927, N'10029804', N' Adriane Godinho ', N'Ampla', 89.14, 0, 89.14, 1032)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2928, N'10021931', N' Yan Genaro Nakamura ', N'Ampla', 89.13, 0, 89.13, 1033)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2929, N'10065508', N' Iago Matteo Calleri ', N'Ampla', 89.12, 0, 89.12, 1034)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2930, N'10019459', N' Thiago Fogtman Steger ', N'Ampla', 89.1, 0, 89.1, 1035)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2931, N'10046951', N' Pedro Mauricio de Vargas Sanches ', N'Ampla', 89.08, 0, 89.08, 1036)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2932, N'10006242', N' Daniel Brant Llorente Barrio ', N'Ampla', 89.08, 0, 89.08, 1037)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2933, N'10045006', N' Filipe Humberto Oliveira Drumond Albuquerque ', N'Ampla', 89.08, 0, 89.08, 1038)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2934, N'10016543', N' Felipe Tobias Costa de Almeida ', N'Ampla', 89.08, 0, 89.08, 1039)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2935, N'10029680', N' Guilherme Augusto Lana Nonato ', N'Ampla', 89.06, 0, 89.06, 1040)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2936, N'10000558', N' Barbara Ranny de Oliveira Vieira da Silva ', N'Ampla', 89.05, 0, 89.05, 1041)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2937, N'10089266', N' Nathalia Martins Pereira dos Santos ', N'Ampla', 89.05, 0, 89.05, 1042)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2938, N'10010959', N' Luisa Viana Luniere de Azevedo ', N'Ampla', 89.05, 0, 89.05, 1043)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2939, N'10009092', N' Fernanda Rocha Vieira ', N'Ampla', 89.04, 0, 89.04, 1044)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2940, N'10067905', N' Julio Cesar Martins Vaz ', N'Ampla', 89.03, 0, 89.03, 1045)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2941, N'10001438', N' Gabriel Ribeiro de Araujo ', N'Ampla', 89.02, 0, 89.02, 1046)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2942, N'10026398', N' Ruda de Almeida Silva ', N'Ampla', 89.02, 0, 89.02, 1047)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2943, N'10082557', N' Marcos Andre Siqueira Lima ', N'Ampla', 88.99, 0, 88.99, 1048)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2944, N'10007751', N' Filipe de Oliveira Pereira ', N'Ampla', 88.99, 0, 88.99, 1049)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2945, N'10010539', N' Karen Rayane Lopes Alves ', N'Ampla', 88.98, 0, 88.98, 1050)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2946, N'10102333', N' Leonardo Yuji Kato Rodrigues ', N'Ampla', 88.97, 0, 88.97, 1051)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2947, N'10005186', N' Matheus Zuchelli Costa ', N'Ampla', 88.94, 0, 88.94, 1052)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2948, N'10076131', N' Paulo Ricardo Peixoto', N'Ampla', 88.93, 0, 88.93, 1053)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2949, N'10067228', N' Caio de Aguiar Pires Moreira ', N'Ampla', 88.93, 0, 88.93, 1054)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2950, N'10016941', N' Amanda Dornelas da Silveira ', N'Ampla', 88.92, 0, 88.92, 1055)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2951, N'10003740', N' Rafael Alves de Sousa Oliveira ', N'Ampla', 88.92, 0, 88.92, 1056)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2952, N'10089602', N' Murilo de Oliveira Marcirio ', N'Ampla', 88.92, 0, 88.92, 1057)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2953, N'10007714', N' Joao Henrique Ferreira Mendes ', N'Ampla', 88.91, 0, 88.91, 1058)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2954, N'10057557', N' Gustavo Carrilho Castro ', N'Ampla', 88.9, 0, 88.9, 1059)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2955, N'10028585', N' Jeferson Amorim Mamed ', N'Ampla', 88.89, 0, 88.89, 1060)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2956, N'10014194', N' Janaina de Souza Dourado Gomes ', N'Ampla', 88.83, 0, 88.83, 1061)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2957, N'10091375', N' Samuel Costa Falcao ', N'Ampla', 88.8, 0, 88.8, 1062)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2958, N'10007595', N' Franklin Delano Varela Amador ', N'Ampla', 88.79, 0, 88.79, 1063)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2959, N'10064356', N' Thais Manhaes Eleuterio ', N'Ampla', 88.76, 0, 88.76, 1064)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2960, N'10037698', N' Julia Morais Roriz dos Anjos ', N'Ampla', 88.75, 0, 88.75, 1065)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2961, N'10055523', N' Leandro Alberto da Cruz Demosthenes ', N'Ampla', 88.74, 0, 88.74, 1066)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2962, N'10016288', N' Vantuyler Borges de Morais ', N'Ampla', 88.73, 0, 88.73, 1067)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2963, N'10110644', N' Vinicius Belo Dutra ', N'Ampla', 88.72, 0, 88.72, 1068)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2964, N'10088898', N' Moises Loiola Heldeberto ', N'Ampla', 88.72, 0, 88.72, 1069)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2965, N'10052151', N' Gabriel Lima de Oliveira ', N'Ampla', 88.72, 0, 88.72, 1070)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2966, N'10066632', N' Juliane Barbosa Pereira ', N'Ampla', 88.7, 0, 88.7, 1071)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2967, N'10024904', N' Roberto Carlos Pereira Junior ', N'Ampla', 88.7, 0, 88.7, 1072)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2968, N'10080522', N' Thalitta Rodrigues Viana ', N'Ampla', 88.69, 0, 88.69, 1073)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2969, N'10064808', N' Eduardo Vieira de Araujo Junior', N'Ampla', 88.69, 0, 88.69, 1074)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2970, N'10097354', N' Filipe Lima Ribeiro ', N'Ampla', 88.68, 0, 88.68, 1075)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2971, N'10071050', N' Marco Aurelio Diniz Pereira ', N'Ampla', 88.68, 0, 88.68, 1076)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2972, N'10077425', N' Wilame da Silva Mendes ', N'Ampla', 88.67, 0, 88.67, 1077)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2973, N'10067867', N' Bruno Vinicius de Oliveira Andrade ', N'Ampla', 88.67, 0, 88.67, 1078)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2974, N'10047240', N' Victor Hugo Uchoa Tatagiba ', N'Ampla', 88.66, 0, 88.66, 1079)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2975, N'10009813', N' Daniely Bonfim de Sousa ', N'Ampla', 88.59, 0, 88.59, 1080)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2976, N'10062563', N' Nathalia da Conceicao Silva Dias ', N'Ampla', 88.57, 0, 88.57, 1081)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2977, N'10022971', N' Sabrina Alves de Oliveira Filincowsky ', N'Ampla', 88.56, 0, 88.56, 1082)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2978, N'10030058', N' Weslany Guimaraes dos Santos ', N'Ampla', 88.56, 0, 88.56, 1083)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2979, N'10033828', N' Amanda de Castro Bernardes ', N'Ampla', 88.56, 0, 88.56, 1084)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2980, N'10103331', N' Jose Ribamar Sousa Duarte Junior ', N'Ampla', 88.56, 0, 88.56, 1085)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2981, N'10019641', N' Gabriel Henrique Bragagnolo Chiaradia ', N'Ampla', 88.54, 0, 88.54, 1086)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2982, N'10065118', N' Beatriz Costa Soares ', N'Ampla', 88.52, 0, 88.52, 1087)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2983, N'10054129', N' Rodrigo Carvalho Araujo ', N'Ampla', 88.52, 0, 88.52, 1088)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2984, N'10105853', N' Gabriel de Andrade Paiva ', N'Ampla', 88.48, 0, 88.48, 1089)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2985, N'10023602', N' Gabriel Maiello Itaborahy Costa Ferreira ', N'Ampla', 88.46, 0, 88.46, 1090)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2986, N'10070102', N' Filipe Israel Azevedo ', N'Ampla', 88.46, 0, 88.46, 1091)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2987, N'10043901', N' Luiz Felipe Andrade Pires de Siqueira ', N'Ampla', 88.46, 0, 88.46, 1092)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2988, N'10002725', N' Livia Chaves Saito ', N'Ampla', 88.44, 0, 88.44, 1093)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2989, N'10006191', N' Lee Harrison Wall dos Santos ', N'Ampla', 88.43, 0, 88.43, 1094)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2990, N'10031391', N' Gabriel Barbosa da Silva ', N'Ampla', 88.42, 0, 88.42, 1095)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2991, N'10049375', N' Michelle Vilar da Silva Pimentel ', N'Ampla', 88.42, 0, 88.42, 1096)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2992, N'10009894', N' Fabiana de Oliveira Ozaka ', N'Ampla', 88.4, 0, 88.4, 1097)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2993, N'10076493', N' Lucas Cordeiro Silva ', N'Ampla', 88.37, 0, 88.37, 1098)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2994, N'10043547', N' Luis Felipe de Oliveira Dourado ', N'Ampla', 88.37, 0, 88.37, 1099)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2995, N'10010254', N' Rafael Goncalves Valenca ', N'Ampla', 88.37, 0, 88.37, 1100)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2996, N'10005020', N' Vanessa Batista Goncalves ', N'Ampla', 88.36, 0, 88.36, 1101)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2997, N'10000035', N' Humberto Alves Brito Sousa de Melo ', N'Ampla', 88.35, 0, 88.35, 1102)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2998, N'10001731', N' Felipe dos Santos Faria ', N'Ampla', 88.35, 0, 88.35, 1103)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (2999, N'10032820', N' Kenia Guimaraes de Amorim', N'Ampla', 88.31, 0, 88.31, 1104)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3000, N'10049427', N' Sedrick Pereira de Lima Junior ', N'Ampla', 88.31, 0, 88.31, 1105)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3001, N'10004346', N' Melissa Xavier Araujo ', N'Ampla', 88.26, 0, 88.26, 1106)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3002, N'10044759', N' Pedro Henrique Maciel ', N'Ampla', 88.24, 0, 88.24, 1107)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3003, N'10004243', N' Felipe Milhomem Ribeiro ', N'Ampla', 88.24, 0, 88.24, 1108)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3004, N'10061988', N' Hugo Vitor Alves Costa ', N'Ampla', 88.23, 0, 88.23, 1109)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3005, N'10005105', N' Danilo Fialho Severino ', N'Ampla', 88.22, 0, 88.22, 1110)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3006, N'10038784', N' Thiago Roris de Matos ', N'Ampla', 88.2, 0, 88.2, 1111)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3007, N'10026529', N' Rafael Oliveira Rodrigues', N'Ampla', 88.19, 0, 88.19, 1112)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3008, N'10079782', N' Carlos Alberto Alves de Lima Junior ', N'Ampla', 88.19, 0, 88.19, 1113)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3009, N'10001043', N' Lucas Lassi Puglia ', N'Ampla', 88.17, 0, 88.17, 1114)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3010, N'10034764', N' Pedro Delgado Alvim de Mello ', N'Ampla', 88.17, 0, 88.17, 1115)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3011, N'10020786', N' Maycon Patrick Dias ', N'Ampla', 88.17, 0, 88.17, 1116)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3012, N'10058745', N' Lucas Oliveira Pedreira ', N'Ampla', 88.15, 0, 88.15, 1117)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3013, N'10034454', N' Paulo Henrique Medeiros Macedo ', N'Ampla', 88.13, 0, 88.13, 1118)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3014, N'10046823', N' Eduardo Novakovski Machado ', N'Ampla', 88.12, 0, 88.12, 1119)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3015, N'10070129', N' Ingrid Medeiros Veras Rocha ', N'Ampla', 88.11, 0, 88.11, 1120)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3016, N'10010850', N' Fabio Cruz dos Reis ', N'Ampla', 88.1, 0, 88.1, 1121)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3017, N'10006270', N' Tarso Campos Andrea ', N'Ampla', 88.1, 0, 88.1, 1122)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3018, N'10033168', N' Maria Teresa Magalhaes Madureira ', N'Ampla', 88.09, 0, 88.09, 1123)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3019, N'10085220', N' Adriel Schumacher Fernandes da Silveira Martins ', N'Ampla', 88.09, 0, 88.09, 1124)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3020, N'10040421', N' Ingrid Fernanda de Sousa ', N'Ampla', 88.08, 0, 88.08, 1125)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3021, N'10055996', N' Lucielen Martins da Rocha ', N'Ampla', 88.02, 0, 88.02, 1126)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3022, N'10045320', N' Bruno Henrique Santos Cavalho ', N'Ampla', 88.02, 0, 88.02, 1127)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3023, N'10004960', N' Gabriel Botelho Mercon ', N'Ampla', 88.02, 0, 88.02, 1128)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3024, N'10008539', N' Felipe Douglas Santos da Silva ', N'Ampla', 87.99, 0, 87.99, 1129)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3025, N'10066179', N' Davson Bruno da Silva Melo ', N'Ampla', 87.97, 0, 87.97, 1130)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3026, N'10060726', N' Rafael Porciuncula Sales ', N'Ampla', 87.97, 0, 87.97, 1131)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3027, N'10016791', N' Eduardo Gorga Bortoletto ', N'Ampla', 87.95, 0, 87.95, 1132)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3028, N'10018724', N' Alexandre Magno Marques Rodrigues ', N'Ampla', 87.95, 0, 87.95, 1133)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3029, N'10001417', N' Elcinara da Silva Tenorio ', N'Ampla', 87.94, 0, 87.94, 1134)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3030, N'10021745', N' Julia de Castro Ferreira ', N'Ampla', 87.94, 0, 87.94, 1135)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3031, N'10018434', N' Yuri Soares Pinheiro', N'Ampla', 87.94, 0, 87.94, 1136)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3032, N'10001299', N' Israel Ferreira Soares ', N'Ampla', 87.92, 0, 87.92, 1137)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3033, N'10062080', N' Daniel Bernardo de Souza Santos ', N'Ampla', 87.91, 0, 87.91, 1138)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3034, N'10049089', N' Marcelo Correa dos Santos ', N'Ampla', 87.89, 0, 87.89, 1139)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3035, N'10027862', N' Augusto Cesar Lisboa Martins ', N'Ampla', 87.88, 0, 87.88, 1140)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3036, N'10071592', N' Leonardo Bertuol Guimaraes ', N'Ampla', 87.86, 0, 87.86, 1141)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3037, N'10039480', N' Luciano Beck Halfen da Porciuncula ', N'Ampla', 87.85, 0, 87.85, 1142)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3038, N'10079037', N' Lucas Moreira Lima ', N'Ampla', 87.83, 0, 87.83, 1143)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3039, N'10065640', N' Leandro Rafael do Nascimento Silva ', N'Ampla', 87.81, 0, 87.81, 1144)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3040, N'10025804', N' Danielle Moreira Clarindo ', N'Ampla', 87.81, 0, 87.81, 1145)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3041, N'10038585', N' Adriano Henrique Viana Martins ', N'Ampla', 87.8, 0, 87.8, 1146)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3042, N'10063336', N' Ramon de Medeiros Bahia ', N'Ampla', 87.8, 0, 87.8, 1147)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3043, N'10036786', N' Isadora Abdalla Amorim ', N'Ampla', 87.78, 0, 87.78, 1148)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3044, N'10021005', N' Amanda Soares de Souza ', N'Ampla', 87.74, 0, 87.74, 1149)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3045, N'10028637', N' Felipe Marques Figueira Barbosa ', N'Ampla', 87.74, 0, 87.74, 1150)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3046, N'10031165', N' Gustavo Alves Ferreira ', N'Ampla', 87.73, 0, 87.73, 1151)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3047, N'10042014', N' Markus Tiago Sonntag ', N'Ampla', 87.73, 0, 87.73, 1152)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3048, N'10083269', N' Carlos Henrique Catrinque Andrade ', N'Ampla', 87.71, 0, 87.71, 1153)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3049, N'10054677', N' Leticia Goncalves Valfre ', N'Ampla', 87.69, 0, 87.69, 1154)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3050, N'10001213', N' Dominique Heron da Silva Lorenzi ', N'Ampla', 87.68, 0, 87.68, 1155)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3051, N'10057631', N' Rafael Serejo de Jesus ', N'Ampla', 87.66, 0, 87.66, 1156)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3052, N'10002338', N' Cristiano Curado Abrantes Caetano ', N'Ampla', 87.64, 0, 87.64, 1157)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3053, N'10017484', N' Mateus Felippin de Albuquerque ', N'Ampla', 87.6, 0, 87.6, 1158)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3054, N'10059975', N' Ludimilla Batista Pinheiro Marques ', N'Ampla', 87.59, 0, 87.59, 1159)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3055, N'10070133', N' Ana Paula Nascimento da Silva Andrade ', N'Ampla', 87.59, 0, 87.59, 1160)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3056, N'10016809', N' Henrique Erik Damasceno Silva', N'Ampla', 87.59, 0, 87.59, 1161)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3057, N'10013117', N' Isabela Soares Oliveira Cancado Ferreira ', N'Ampla', 87.57, 0, 87.57, 1162)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3058, N'10012884', N' Pedro Henrique Paranagua de Castro ', N'Ampla', 87.56, 0, 87.56, 1163)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3059, N'10042040', N' Monica Gomes Muller ', N'Ampla', 87.56, 0, 87.56, 1164)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3060, N'10085698', N' Vanessa Maria da Silva Paiva ', N'Ampla', 87.56, 0, 87.56, 1165)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3061, N'10073494', N' Matheus Martins Cavalari Cardoso ', N'Ampla', 87.55, 0, 87.55, 1166)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3062, N'10011029', N' Juliana Bezerra Carneiro ', N'Ampla', 87.55, 0, 87.55, 1167)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3063, N'10009268', N' Ludimila Gomes de Amorim Mota ', N'Ampla', 87.55, 0, 87.55, 1168)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3064, N'10041943', N' Bernardo Moreira Pinto ', N'Ampla', 87.54, 0, 87.54, 1169)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3065, N'10080819', N' Carlos Augusto Bernardes Ribeiro ', N'Ampla', 87.53, 0, 87.53, 1170)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3066, N'10046921', N' Andre Luiz Barros Almeida ', N'Ampla', 87.53, 0, 87.53, 1171)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3067, N'10007279', N' Alisson Cardoso Pereira ', N'Ampla', 87.53, 0, 87.53, 1172)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3068, N'10011140', N' Maiko Alves de Castro ', N'Ampla', 87.5, 0, 87.5, 1173)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3069, N'10013934', N' Felipe Bergamaschi Brettas ', N'Ampla', 87.43, 0, 87.43, 1174)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3070, N'10048292', N' Jardel Cavalcante Rolim ', N'Ampla', 87.42, 0, 87.42, 1175)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3071, N'10046920', N' Gizele Pires Arruda Pereira da Silva', N'Ampla', 87.41, 0, 87.41, 1176)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3072, N'10025425', N' Sonia Cristina de Oliveira Guimaraes ', N'Ampla', 87.38, 0, 87.38, 1177)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3073, N'10002481', N' Thomas Jefferson Soares Lacerda ', N'Ampla', 87.38, 0, 87.38, 1178)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3074, N'10010902', N' Warley Jose Gimenes Pessanha ', N'Ampla', 87.35, 0, 87.35, 1179)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3075, N'10040419', N' Karolline Ambrosi Tosta ', N'Ampla', 87.35, 0, 87.35, 1180)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3076, N'10055143', N' Jhuly Kelly Ferreira Rodrigues ', N'Ampla', 87.34, 0, 87.34, 1181)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3077, N'10004787', N' Fabio da Silva Gomes ', N'Ampla', 87.33, 0, 87.33, 1182)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3078, N'10040298', N' Nathalia Fenner Saldanha ', N'Ampla', 87.33, 0, 87.33, 1183)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3079, N'10056508', N' Jackson dos Santos Anjos ', N'Ampla', 87.32, 0, 87.32, 1184)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3080, N'10001826', N' Humberto Solano de Freitas Junior ', N'Ampla', 87.32, 0, 87.32, 1185)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3081, N'10002876', N' Francisco de Assis de Oliveira Silva ', N'Ampla', 87.31, 0, 87.31, 1186)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3082, N'10039443', N' Rodrigo Antonio Vieira Rodrigues ', N'Ampla', 87.31, 0, 87.31, 1187)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3083, N'10071034', N' Mario Sergio Alves Elias ', N'Ampla', 87.3, 0, 87.3, 1188)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3084, N'10076450', N' Mateus Pinchemel de Andrade ', N'Ampla', 87.3, 0, 87.3, 1189)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3085, N'10012137', N' Joao Paulo Cardoso Zandonade ', N'Ampla', 87.28, 0, 87.28, 1190)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3086, N'10037276', N' Joao Vitor Fernandes de Oliveira ', N'Ampla', 87.23, 0, 87.23, 1191)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3087, N'10072159', N' Lucas Hideo Hataka Koyama ', N'Ampla', 87.17, 0, 87.17, 1192)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3088, N'10004288', N' Milene Prata de Souza ', N'Ampla', 87.17, 0, 87.17, 1193)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3089, N'10017070', N' Lucas Moreira da Mota ', N'Ampla', 87.15, 0, 87.15, 1194)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3090, N'10043618', N' Roberta Ligia Cavalcanti Lima ', N'Ampla', 87.12, 0, 87.12, 1195)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3091, N'10035251', N' Thamera Soares Souza ', N'Ampla', 87.12, 0, 87.12, 1196)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3092, N'10022458', N' Rodrigo de Oliveira Teixeira ', N'Ampla', 87.12, 0, 87.12, 1197)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3093, N'10102938', N' Tayrone Tadeu de Freitas Coelho ', N'Ampla', 87.03, 0, 87.03, 1198)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3094, N'10001814', N' Matheus Pinho Lins de Araujo ', N'Ampla', 87.03, 0, 87.03, 1199)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3095, N'10050001', N' Isabela Luisa Zardo e Silva ', N'Ampla', 87.03, 0, 87.03, 1200)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3096, N'10036030', N' Gabriel Henrique de Almeida ', N'Ampla', 87.01, 0, 87.01, 1201)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3097, N'10004244', N' Ana Clara Viana Lima ', N'Ampla', 87.01, 0, 87.01, 1202)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3098, N'10008064', N' Nathan Ranieri Santos Teofilo ', N'Ampla', 86.99, 0, 86.99, 1203)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3099, N'10014698', N' David Wilker da Silva Roma ', N'Ampla', 86.96, 0, 86.96, 1204)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3100, N'10016949', N' Enielle Donda Fernandes da Silva ', N'Ampla', 86.96, 0, 86.96, 1205)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3101, N'10081500', N' Pablo Alexandre Gomes e Silva ', N'Ampla', 86.95, 0, 86.95, 1206)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3102, N'10021757', N' Jader Batista Mendes ', N'Ampla', 86.91, 0, 86.91, 1207)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3103, N'10022419', N' Julia Scarponi Pinto Costa Pereira ', N'Ampla', 86.85, 0, 86.85, 1208)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3104, N'10022995', N' Rafael Salles Pereira', N'Ampla', 86.84, 0, 86.84, 1209)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3105, N'10035602', N' Rafaela Cordeiro Oliveira Ribeiro ', N'Ampla', 86.83, 0, 86.83, 1210)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3106, N'10063677', N' Ady Coutinho Solino ', N'Ampla', 86.81, 0, 86.81, 1211)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3107, N'10002265', N' Alex Alves Murray ', N'Ampla', 86.81, 0, 86.81, 1212)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3108, N'10011153', N' Fernanda Leal e Costa Bittencourt de Araujo ', N'Ampla', 86.8, 0, 86.8, 1213)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3109, N'10008422', N' Aramis Ferreira Silva ', N'Ampla', 86.79, 0, 86.79, 1214)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3110, N'10011671', N' Roberto Dutra da Silva Filho ', N'Ampla', 86.78, 0, 86.78, 1215)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3111, N'10041206', N' Sara da Silva Fernandes ', N'Ampla', 86.75, 0, 86.75, 1216)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3112, N'10006482', N' Nathalia Lauria do Nascimento ', N'Ampla', 86.74, 0, 86.74, 1217)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3113, N'10041718', N' Lucio Sidney de Oliveira Souza ', N'Ampla', 86.72, 0, 86.72, 1218)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3114, N'10067566', N' Guilherme Lino Santos Santana ', N'Ampla', 86.72, 0, 86.72, 1219)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3115, N'10011725', N' Alessandra Garcia Diniz ', N'Ampla', 86.7, 0, 86.7, 1220)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3116, N'10047512', N' Mirellen Mara Moreira ', N'Ampla', 86.7, 0, 86.7, 1221)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3117, N'10102979', N' Franciane Carina Gerioni ', N'Ampla', 86.66, 0, 86.66, 1222)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3118, N'10027561', N' Rayanne Gobbi de Carvalho Zumpano ', N'Ampla', 86.61, 0, 86.61, 1223)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3119, N'10018132', N' Bruno Beserra Assuncao ', N'Ampla', 86.6, 0, 86.6, 1224)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3120, N'10007097', N' Ana Carolina Cotta ', N'Ampla', 86.59, 0, 86.59, 1225)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3121, N'10014832', N' Rafael Fernando Mendonca de Alencar ', N'Ampla', 86.54, 0, 86.54, 1227)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3122, N'10023423', N' Juan Francisco Neves Tanajura ', N'Ampla', 86.54, 0, 86.54, 1228)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3123, N'10011181', N' Gabriela Gomes Guerra de Magalhaes ', N'Ampla', 86.53, 0, 86.53, 1229)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3124, N'10059307', N' Lucas Alves de Souza ', N'Ampla', 86.5, 0, 86.5, 1230)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3125, N'10009946', N' Willians Ribeiro de Campos ', N'Ampla', 86.44, 0, 86.44, 1231)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3126, N'10055134', N' Adriano Mateus de Souza Campos ', N'Ampla', 86.42, 0, 86.42, 1232)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3127, N'10007386', N' Daiele Ruana Lima dos Santos ', N'Ampla', 86.36, 0, 86.36, 1233)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3128, N'10023689', N' Paula Carolina Kraetzer de Oliveira ', N'Ampla', 86.3, 0, 86.3, 1235)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3129, N'10079371', N' Jean Ismael Agripino Ferreira dos Santos ', N'Ampla', 86.3, 0, 86.3, 1236)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3130, N'10030333', N' Tiago do Vale Araujo ', N'Ampla', 86.28, 0, 86.28, 1237)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3131, N'10021688', N' Yuri Araujo Coelho Penna ', N'Ampla', 86.25, 0, 86.25, 1239)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3132, N'10035024', N' Cinthia Barbosa da Silva ', N'Ampla', 86.25, 0, 86.25, 1240)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3133, N'10062285', N' Gabriela Araujo dos Santos Mesquita ', N'Ampla', 86.23, 0, 86.23, 1241)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3134, N'10038133', N' Andreza Santos de Mesquita Bomtempo ', N'Ampla', 86.22, 0, 86.22, 1242)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3135, N'10031087', N' Fernanda Maia Lacerda ', N'Ampla', 86.13, 0, 86.13, 1244)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3136, N'10020460', N' Nivaldo Batista de Oliveira Junior ', N'Ampla', 86.12, 0, 86.12, 1245)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3137, N'10008459', N' Frederico Silva Lopes Aguiar ', N'Ampla', 86.09, 0, 86.09, 1246)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3138, N'10013093', N' Bruno Haack de Arruda Dutra ', N'Ampla', 86.04, 0, 86.04, 1248)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3139, N'10010443', N' Francisco Jefferson da Silva ', N'Ampla', 86.03, 0, 86.03, 1249)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3140, N'10017571', N' Charles Henrique Souza de Jesus ', N'Ampla', 86.02, 0, 86.02, 1250)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3141, N'10021459', N' Marcelo Silva Alves ', N'Ampla', 86.02, 0, 86.02, 1251)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3142, N'10062811', N' Rafael Lima de Siqueira ', N'Ampla', 86.02, 0, 86.02, 1252)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3143, N'10101150', N' Paulo Raimundo de Paiva Arbues Carneiro ', N'Ampla', 85.97, 0, 85.97, 1253)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3144, N'10005197', N' Felipe Braga Viana ', N'Ampla', 85.96, 0, 85.96, 1254)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3145, N'10008573', N' Brunno Franca de Oliveira ', N'Ampla', 85.93, 0, 85.93, 1255)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3146, N'10007686', N' Juvenil Rodrigues da Cruz Junior ', N'Ampla', 85.84, 0, 85.84, 1256)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3147, N'10061672', N' Felipe de Almeida Cimas ', N'Ampla', 85.83, 0, 85.83, 1257)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3148, N'10069981', N' Camila Rodrigues Celestino ', N'Ampla', 85.81, 0, 85.81, 1258)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3149, N'10006489', N' Bruno Hebert de Almeida Nunes ', N'Ampla', 85.71, 0, 85.71, 1259)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3150, N'10023396', N' Joao Victor Diniz Campos Dias ', N'Ampla', 85.69, 0, 85.69, 1260)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3151, N'10008710', N' Caio Cesar Mascena Lima ', N'Ampla', 85.66, 0, 85.66, 1261)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3152, N'10004275', N' Anderson Cesar Pereira da Silva ', N'Ampla', 85.65, 0, 85.65, 1262)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3153, N'10002397', N' Elves Junior Medina Brandao ', N'Ampla', 85.65, 0, 85.65, 1263)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3154, N'10002350', N' Marcel Cerqueira de Souza Jatoba ', N'Ampla', 85.65, 0, 85.65, 1264)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3155, N'10060047', N' Paulo Henrique Queiroz Cavalcante ', N'Ampla', 85.59, 0, 85.59, 1265)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3156, N'10018145', N' Welerson Ferreira Abreu ', N'Ampla', 85.59, 0, 85.59, 1266)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3157, N'10010796', N' Fabiana Koffes Marinho ', N'Ampla', 85.59, 0, 85.59, 1267)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3158, N'10026596', N' Pedro Rocha de Freitas ', N'Ampla', 85.54, 0, 85.54, 1269)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3159, N'10046955', N' Manoel Carvalho Gontijo dos Santos ', N'Ampla', 85.5, 0, 85.5, 1270)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3160, N'10028382', N' Diana Nunes de Oliveira ', N'Ampla', 85.46, 0, 85.46, 1271)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3161, N'10009985', N' Rafael Pereira Nunes ', N'Ampla', 85.45, 0, 85.45, 1272)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3162, N'10001377', N' Leandro Binueza do Vale ', N'Ampla', 85.41, 0, 85.41, 1273)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3163, N'10015633', N' Renan Motta da Silva ', N'Ampla', 85.38, 0, 85.38, 1274)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3164, N'10013459', N' Joao Gabriel de Aguiar Carvalho ', N'Ampla', 85.37, 0, 85.37, 1275)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3165, N'10004473', N' Krisllayne de Oliveira Fernandes Caldas ', N'Ampla', 85.35, 0, 85.35, 1276)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3166, N'10058343', N' William Sales Ferreira do Carmo ', N'Ampla', 85.34, 0, 85.34, 1277)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3167, N'10099489', N' Hellen Noleto Pereira Costa ', N'Ampla', 85.33, 0, 85.33, 1278)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3168, N'10065168', N' Elias da Costa Belinazo ', N'Ampla', 85.21, 0, 85.21, 1279)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3169, N'10089200', N' Thomas Luciano Alves da Silva ', N'Ampla', 85.21, 0, 85.21, 1280)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3170, N'10012964', N' Vanderly Salvador de Queiroz ', N'Ampla', 85.18, 0, 85.18, 1281)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3171, N'10006101', N' Gustavo Gabriel Martins Ferreira ', N'Ampla', 85.17, 0, 85.17, 1282)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3172, N'10078977', N' Adriano Augusto Bliska ', N'Ampla', 85.17, 0, 85.17, 1283)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3173, N'10045553', N' Gabriel Moraes de Aquino ', N'Ampla', 85.15, 0, 85.15, 1284)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3174, N'10054498', N' Pedro Henrique Tavora Pereira Filho ', N'Ampla', 85.15, 0, 85.15, 1285)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3175, N'10032952', N' Gislene Ferreira Batista ', N'Ampla', 85.11, 0, 85.11, 1286)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3176, N'10049460', N' Cristian Ramos de Oliveira Grilo ', N'Ampla', 85.11, 0, 85.11, 1287)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3177, N'10075209', N' Paulo Mendes Florentino Filho ', N'Ampla', 85.08, 0, 85.08, 1288)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3178, N'10066668', N' Alyson Soares dos Santos ', N'Ampla', 85.05, 0, 85.05, 1289)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3179, N'10048444', N' Mateus Medeiros Alves Campos ', N'Ampla', 85.04, 0, 85.04, 1290)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3180, N'10014630', N' Phelipe Correia Costa ', N'Ampla', 85.03, 0, 85.03, 1291)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3181, N'10063225', N' Gustavo Goncalo Rodrigues ', N'Ampla', 85.03, 0, 85.03, 1292)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3182, N'10063605', N' Reison Vinicius Siqueira Cruz Rodrigues ', N'Ampla', 85.02, 0, 85.02, 1293)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3183, N'10025880', N' Alexandre Cyrino de Sousa ', N'Ampla', 85.01, 0, 85.01, 1294)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3184, N'10062388', N' Arthur Jorge Lins Mendonca ', N'Ampla', 84.94, 0, 84.94, 1295)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3185, N'10043628', N' Lucas Baldasso ', N'Ampla', 84.92, 0, 84.92, 1296)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3186, N'10003186', N' Diego Alves de Lima ', N'Ampla', 84.89, 0, 84.89, 1297)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3187, N'10015450', N' Victor de Sousa Passos ', N'Ampla', 84.88, 0, 84.88, 1298)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3188, N'10068965', N' Antonio Rafael Silva Brito ', N'Ampla', 84.86, 0, 84.86, 1299)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3189, N'10001369', N' Filipe Aguiar Rodrigues ', N'Ampla', 84.85, 0, 84.85, 1300)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3190, N'10009278', N' Giovanna Bampi ', N'Ampla', 84.82, 0, 84.82, 1301)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3191, N'10038368', N' Rayldon Ribeiro da Silva ', N'Ampla', 84.81, 0, 84.81, 1302)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3192, N'10012337', N' Auiris Ferreira da Silva ', N'Ampla', 84.79, 0, 84.79, 1303)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3193, N'10043706', N' Thiago Felix Borges ', N'Ampla', 84.78, 0, 84.78, 1304)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3194, N'10044039', N' Raquel Silva Moreira ', N'Ampla', 84.71, 0, 84.71, 1305)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3195, N'10006050', N' Ulisses Almeida Coutinho ', N'Ampla', 84.66, 0, 84.66, 1306)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3196, N'10010261', N' Gustavo Nunes Ribeiro ', N'Ampla', 84.65, 0, 84.65, 1307)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3197, N'10089670', N' Hugo de Oliveira Arruda Badin ', N'Ampla', 84.65, 0, 84.65, 1308)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3198, N'10001113', N' Frederico Augusto de Vasconcelos Ferreira ', N'Ampla', 84.63, 0, 84.63, 1309)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3199, N'10062056', N' Yuri Gustavo de Souza ', N'Ampla', 84.6, 0, 84.6, 1310)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3200, N'10006478', N' Cristiane Ximenes da Silva ', N'Ampla', 84.56, 0, 84.56, 1311)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3201, N'10044284', N' Heverlyn Dyanne Teles de Miranda ', N'Ampla', 84.46, 0, 84.46, 1312)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3202, N'10094378', N' Pablo Henrique da Cunha Silva ', N'Ampla', 84.45, 0, 84.45, 1313)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3203, N'10006215', N' Giovanna Pedroza Nunes de Oliveira ', N'Ampla', 84.42, 0, 84.42, 1314)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3204, N'10047516', N' Matheus de Siqueira Xavier ', N'Ampla', 84.38, 0, 84.38, 1315)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3205, N'10022167', N' Savio Preto Menezes ', N'Ampla', 84.28, 0, 84.28, 1316)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3206, N'10000508', N' Daiane Braz Neri ', N'Ampla', 84.27, 0, 84.27, 1318)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3207, N'10006450', N' Lucas de Santana Silva ', N'Ampla', 84.24, 0, 84.24, 1319)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3208, N'10017608', N' Gustavo Verissimo Guimaraes ', N'Ampla', 84.22, 0, 84.22, 1320)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3209, N'10030952', N' Diego Becker Griebler ', N'Ampla', 84.18, 0, 84.18, 1321)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3210, N'10018723', N' Isabela Silva Lara Reis ', N'Ampla', 84.09, 0, 84.09, 1322)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3211, N'10082966', N' Igor Rogerio Araujo de Sousa ', N'Ampla', 84.09, 0, 84.09, 1323)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3212, N'10088836', N' Danielly Quintas Cascelli de Azevedo ', N'Ampla', 84.08, 0, 84.08, 1324)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3213, N'10008613', N' Ivana Colares Mendes de Almeida ', N'Ampla', 84.03, 0, 84.03, 1325)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3214, N'10059992', N' Douglas de Sousa Bezerra ', N'Ampla', 84.01, 0, 84.01, 1326)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3215, N'10086869', N' Macelio Pedrosa Vieira ', N'Ampla', 83.95, 0, 83.95, 1327)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3216, N'10034944', N' Joao Paulo Lima Fernandes ', N'Ampla', 83.94, 0, 83.94, 1328)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3217, N'10016636', N' Alexandre Rabelo Tavares ', N'Ampla', 83.89, 0, 83.89, 1329)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3218, N'10054897', N' Thiago Garcia Rosa Zanandrea ', N'Ampla', 83.89, 0, 83.89, 1330)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3219, N'10046312', N' Thiago Coelho Ferrolho ', N'Ampla', 83.85, 0, 83.85, 1331)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3220, N'10063818', N' Erica Fonteneles de Souza ', N'Ampla', 83.78, 0, 83.78, 1332)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3221, N'10098487', N' Camylla Silva Batista ', N'Ampla', 83.75, 0, 83.75, 1333)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3222, N'10037076', N' Gabriela Araujo Correa ', N'Ampla', 83.75, 0, 83.75, 1334)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3223, N'10016131', N' Sandi Alves de Souza Pereira ', N'Ampla', 83.72, 0, 83.72, 1335)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3224, N'10037931', N' Barbara Xavier Cavalcanti ', N'Ampla', 83.71, 0, 83.71, 1336)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3225, N'10058436', N' Vinicius Mendonca Teixeira ', N'Ampla', 83.65, 0, 83.65, 1337)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3226, N'10030706', N' Marcos Henrique de Andrade ', N'Ampla', 83.58, 0, 83.58, 1338)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3227, N'10068723', N' Gabriela Soares de Rezende ', N'Ampla', 83.57, 0, 83.57, 1339)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3228, N'10069488', N' Vitor Manoel Borges Ferreira ', N'Ampla', 83.55, 0, 83.55, 1340)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3229, N'10063467', N' Joyce Bonfim Pessoa ', N'Ampla', 83.46, 0, 83.46, 1341)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3230, N'10045588', N' Romulo Flanegan Esperanca Campos ', N'Ampla', 83.39, 0, 83.39, 1342)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3231, N'10038964', N' Rodrigo Meneses Cabral ', N'Ampla', 83.38, 0, 83.38, 1343)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3232, N'10002787', N' Isaac Johnson Vasconcelos Elias ', N'Ampla', 83.32, 0, 83.32, 1344)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3233, N'10023308', N' Lurien Gomes do Carmo', N'Ampla', 83.24, 0, 83.24, 1345)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3234, N'10071435', N' Marilia Gabriela de Oliveira Ramos ', N'Ampla', 83.1, 0, 83.1, 1346)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3235, N'10065580', N' Leticia Lopes Campos ', N'Ampla', 83.09, 0, 83.09, 1347)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3236, N'10021053', N' Mario Luiz Rebelo Miquelino Cunha ', N'Ampla', 83.04, 0, 83.04, 1348)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3237, N'10019004', N' Ana Carolina Croner de Abreu ', N'Ampla', 82.65, 0, 82.65, 1349)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3238, N'10035972', N' Joao Paulo de CastroCarisio Ribeiro ', N'Ampla', 82.62, 0, 82.62, 1350)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3239, N'10088667', N'Eduardo Augusto Brandao Duarte ', N'Ampla', 82.44, 0, 82.44, 1351)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3240, N'10077057', N' Claudio Cristian de Souza Campos ', N'Ampla', 82.22, 0, 82.22, 1352)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3241, N'10061041', N' Jeancarlos da Silva Junior', N'Negros', 116.71, 0, 116.71, 1)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3242, N'10006223', N' Isabela Brito Couto de Oliveira', N'Negros', 110.07, 0, 110.07, 2)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3243, N'10001622', N' Bruno da Silva Coelho', N'Negros', 107.2, 0, 107.2, 3)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3244, N'10059829', N' Thallys Deusdara Monsueth Alves', N'Negros', 102.6, 0, 102.6, 4)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3245, N'10043650', N' Jose Lidberg Rocha Lima Filho', N'Negros', 102.29, 0, 102.29, 5)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3246, N'10010288', N' Bruno Araujo Lima', N'Negros', 101.3, 0, 101.3, 6)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3247, N'10012723', N' Natalia Lemos Penetra', N'Negros', 101.3, 0, 101.3, 7)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3248, N'10026423', N' Vitor Rodrigues Santos', N'Negros', 100.89, 0, 100.89, 8)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3249, N'10029028', N' Fernanda Miranda de Souza', N'Negros', 100.24, 0, 100.24, 9)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3250, N'10003244', N' Vinicius Tavares de Castro', N'Negros', 99.59, 0, 99.59, 10)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3251, N'10026809', N' Manuella Maria Santos Miguel da Silva', N'Negros', 99.52, 0, 99.52, 11)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3252, N'10105083', N' Wallace Willian do Nascimento Macedo', N'Negros', 99.23, 0, 99.23, 12)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3253, N'10029952', N' Bruno Cesar Sampaio Ribeiro de Assis', N'Negros', 98.48, 0, 98.48, 13)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3254, N'10015833', N' Arthur Gouvea Fernandes', N'Negros', 98.48, 0, 98.48, 14)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3255, N'10002663', N' Ciro Camilo Santos Leal ', N'Negros', 98.37, 0, 98.37, 15)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3256, N'10002814', N' Carolina Farias Ferreira Moretto', N'Negros', 98.14, 0, 98.14, 16)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3257, N'10077393', N' Gustavo de Almeida Ferreira', N'Negros', 98.11, 0, 98.11, 17)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3258, N'10007528', N' Lucas Henrique Rosa do Nascimento', N'Negros', 98.02, 0, 98.02, 18)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3259, N'10037198', N' Ewerton Cruz Soares', N'Negros', 96.77, 0, 96.77, 19)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3260, N'10058676', N' Rafael Pereira Felix', N'Negros', 96.29, 0, 96.29, 20)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3261, N'10023979', N' Ana Carolina Angelo Passos', N'Negros', 96.13, 0, 96.13, 21)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3262, N'10045660', N' Jackellyne Jenyffer Ferreira dos Santos', N'Negros', 96.1, 0, 96.1, 22)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3263, N'10002718', N' Kassia Karolliny Ribeiro Camilo', N'Negros', 95.47, 0, 95.47, 23)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3264, N'10025529', N' Beatriz Lisboa Veras', N'Negros', 95.36, 0, 95.36, 24)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3265, N'10041187', N' Gleodes Victor Duarte de Souza', N'Negros', 95.28, 0, 95.28, 25)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3266, N'10095054', N' Matheus Pereira Mendes', N'Negros', 95.25, 0, 95.25, 26)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3267, N'10016351', N' Moises de Almeida Bastos', N'Negros', 95.17, 0, 95.17, 27)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3268, N'10040610', N' Raphael Felipe de Moura dos Santos', N'Negros', 94.99, 0, 94.99, 28)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3269, N'10049134', N' Loise Kelem Oliveira da Hora', N'Negros', 94.98, 0, 94.98, 29)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3270, N'10032162', N' Leonardo de Melo Brito Junior', N'Negros', 94.92, 0, 94.92, 30)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3271, N'10002311', N' Fernanda Viana de Morais', N'Negros', 94.85, 0, 94.85, 31)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3272, N'10044432', N' Barbara Amanda Agustinho da Silva', N'Negros', 94.84, 0, 94.84, 32)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3273, N'10032796', N' Tiago Spindula Ferreira', N'Negros', 94.78, 0, 94.78, 33)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3274, N'10060163', N' Daniel Barrozo Lima ', N'Negros', 94.54, 0, 94.54, 34)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3275, N'10008416', N' Alisson Carlos Martins Felipe', N'Negros', 94.18, 0, 94.18, 35)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3276, N'10020468', N' Guilherme de Oliveira Santana', N'Negros', 93.73, 0, 93.73, 36)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3277, N'10078027', N' Geovani Urder de Andrade Aquino', N'Negros', 93.54, 0, 93.54, 37)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3278, N'10006816', N' Wesley dos Santos', N'Negros', 93.54, 0, 93.54, 38)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3279, N'10030677', N' Lenin Andrade de Souza Cerqueira', N'Negros', 93.54, 0, 93.54, 39)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3280, N'10018218', N' Lucas Neves Cardoso', N'Negros', 93.07, 0, 93.07, 40)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3281, N'10033541', N' Aline Mourao de Abreu', N'Negros', 92.97, 0, 92.97, 41)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3282, N'10064698', N' Tulio Andre Pereira de Oliveira', N'Negros', 92.74, 0, 92.74, 42)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3283, N'10060246', N' Joao Paulo de Sousa', N'Negros', 92.41, 0, 92.41, 43)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3284, N'10041872', N' Andressa Trindade de Lima', N'Negros', 92.38, 0, 92.38, 44)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3285, N'10011949', N' Igo Ferreira de Oliveira', N'Negros', 92.29, 0, 92.29, 45)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3286, N'10045061', N' Elison Rodrigues Carvalho dos Santos', N'Negros', 92.04, 0, 92.04, 46)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3287, N'10018823', N' Allisson Cardoso Ferreira', N'Negros', 91.88, 0, 91.88, 47)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3288, N'10065059', N' Jaine de Sousa Maciel', N'Negros', 91.88, 0, 91.88, 48)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3289, N'10090385', N' Julley Oliveira Alencar', N'Negros', 91.8, 0, 91.8, 49)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3290, N'10007233', N' Brendo Augusto dos Santos Tertuliano', N'Negros', 91.64, 0, 91.64, 50)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3291, N'10094893', N' Eunice Vitorio de Oliveira', N'Negros', 91.6, 0, 91.6, 51)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3292, N'10094212', N' Vinicius Drummond Silva Araujo', N'Negros', 91.6, 0, 91.6, 52)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3293, N'10048431', N' Jonatan Almeida Custodio', N'Negros', 91.51, 0, 91.51, 53)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3294, N'10091260', N' Marcelo Hipolito Dantas de Souza', N'Negros', 91.45, 0, 91.45, 54)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3295, N'10037712', N' Jaira Decia Conceicao Lima', N'Negros', 91.37, 0, 91.37, 55)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3296, N'10008635', N' Larissa Paes Landim Alves', N'Negros', 90.82, 0, 90.82, 56)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3297, N'10025618', N' Thiago dos Santos Silva', N'Negros', 90.6, 0, 90.6, 57)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3298, N'10070700', N' Marilia Parreira', N'Negros', 90.49, 0, 90.49, 58)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3299, N'10023195', N' Andre Felipe da Rocha de Souza', N'Negros', 89.88, 0, 89.88, 59)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3300, N'10037162', N' Guilherme Pinto Ribeiro', N'Negros', 89.73, 0, 89.73, 60)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3301, N'10010280', N' Mauricio Brayan Cruz Alves Martins', N'Negros', 89.54, 0, 89.54, 61)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3302, N'10057796', N' Lucas Vieira dos Santos', N'Negros', 89.37, 0, 89.37, 62)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3303, N'10018343', N' Matheus Silva Gomes', N'Negros', 89.11, 0, 89.11, 63)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3304, N'10003876', N' Alyne de Morais Santiago Gaia', N'Negros', 89.01, 0, 89.01, 64)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3305, N'10034241', N' Bruno Nunes Teixeira Ferreira', N'Negros', 88.94, 0, 88.94, 65)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3306, N'10099142', N' Francisco Adail Inacio de Sousa Junior', N'Negros', 88.94, 0, 88.94, 66)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3307, N'10072473', N' Rodrigo de Melo Pereira do Nascimento Costa', N'Negros', 88.89, 0, 88.89, 67)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3308, N'10007435', N' Daniel Lima das Virgens Ferreira', N'Negros', 88.85, 0, 88.85, 68)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3309, N'10060188', N' Glenda Gomes Silva Frank', N'Negros', 88.72, 0, 88.72, 69)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3310, N'10005655', N' Ulisses Antonio Pereira', N'Negros', 88.68, 0, 88.68, 70)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3311, N'10084488', N' Bruno Leonardo daConceicao Facanha', N'Negros', 88.56, 0, 88.56, 71)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3312, N'10003385', N' Adriana Luiza de Albuquerque Brito', N'Negros', 88.54, 0, 88.54, 72)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3313, N'10091226', N' Catiana Silveira de Souza Araujo', N'Negros', 88.5, 0, 88.5, 73)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3314, N'10013643', N' Weslen Ribeiro de Oliveira', N'Negros', 88.48, 0, 88.48, 74)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3315, N'10050965', N' Eduardo Dias de Oliveira Rosa', N'Negros', 88.24, 0, 88.24, 75)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3316, N'10059764', N' Vinicius dos Anjos Rodrigues', N'Negros', 88.16, 0, 88.16, 76)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3317, N'10047483', N' Taiane Baptista Goncalves', N'Negros', 88.12, 0, 88.12, 77)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3318, N'10023301', N' Gesomar Rodrigues de Franca', N'Negros', 88.05, 0, 88.05, 78)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3319, N'10020302', N' Monica Lins dos Santos', N'Negros', 87.92, 0, 87.92, 79)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3320, N'10038743', N' Larissa da Silva Marques', N'Negros', 87.86, 0, 87.86, 80)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3321, N'10030842', N' Lucas Fonseca da Silva', N'Negros', 87.56, 0, 87.56, 81)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3322, N'10020336', N' Marlos Angelo Silva Quirino', N'Negros', 87.56, 0, 87.56, 82)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3323, N'10003357', N' Victor Eduardo Menezes de Freitas', N'Negros', 87.14, 0, 87.14, 83)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3324, N'10023349', N' Emanuella Cunha de Barros Raposo Carneiro Lins', N'Negros', 87.09, 0, 87.09, 84)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3325, N'10066197', N' Victor Augusto Machado da Silva Andrade', N'Negros', 86.95, 0, 86.95, 85)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3326, N'10065339', N' Pedro Cesar Queiroz da Silva', N'Negros', 86.9, 0, 86.9, 86)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3327, N'10090583', N' Silvaldo Quirino Tavares', N'Negros', 86.82, 0, 86.82, 87)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3328, N'10052453', N' Daniel Barbosa de Sousa ', N'Negros', 86.82, 0, 86.82, 88)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3329, N'10040042', N' Ludimila de Oliveira Felix', N'Negros', 86.7, 0, 86.7, 89)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3330, N'10009617', N' Peterson da Cunha Estevan Costa', N'Negros', 86.66, 0, 86.66, 90)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3331, N'10063145', N' Rodolfo Alves Nascimento', N'Negros', 86.62, 0, 86.62, 91)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3332, N'10013837', N' Anderson Dutra Almeida', N'Negros', 86.45, 0, 86.45, 92)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3333, N'10016719', N' Welton Silva de Oliveira Pires', N'Negros', 86.32, 0, 86.32, 93)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3334, N'10023938', N' Renan Aruil de Sousa', N'Negros', 86.32, 0, 86.32, 94)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3335, N'10052126', N' Leonardo Pereira Dalmeida Franca', N'Negros', 86.31, 0, 86.31, 95)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3336, N'10002778', N' Marcelo Henrique da Silva Oliveira', N'Negros', 86.3, 0, 86.3, 96)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3337, N'10052747', N' Carolina Gomes dos Santos', N'Negros', 86.3, 0, 86.3, 97)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3338, N'10063058', N' Eloiza da Silva Pinheiro', N'Negros', 86.3, 0, 86.3, 98)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3339, N'10010498', N' Alisson Bruno Milanez Barros', N'Negros', 86.11, 0, 86.11, 99)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3340, N'10021577', N' Ingrid Lorena de Oliveira Silva Marques', N'Negros', 86, 0, 86, 100)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3341, N'10046871', N' Renato Carvalho de Souza', N'Negros', 85.99, 0, 85.99, 101)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3342, N'10004955', N' Keyla do Nascimento Rocha', N'Negros', 85.93, 0, 85.93, 102)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3343, N'10055315', N' Givanildo Barbosa Leal', N'Negros', 85.82, 0, 85.82, 103)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3344, N'10024503', N' Leia Pereira de Brito', N'Negros', 85.82, 0, 85.82, 104)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3345, N'10001603', N' Aluizio de Sousa Lustosa', N'Negros', 85.8, 0, 85.8, 105)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3346, N'10047490', N' Mario Junior Mendes da Silva', N'Negros', 85.79, 0, 85.79, 106)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3347, N'10057345', N' Edson Vieira de Morais', N'Negros', 85.73, 0, 85.73, 107)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3348, N'10038003', N' Kessy Diego Ribeiro Maia de Carvalho', N'Negros', 85.57, 0, 85.57, 108)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3349, N'10043029', N' Mayara Araujo Mendes', N'Negros', 85.48, 0, 85.48, 109)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3350, N'10064825', N' Fernanda Silva do Nascimento', N'Negros', 85.46, 0, 85.46, 110)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3351, N'10006354', N' Hebert Jorge Nunes da Silva Machado', N'Negros', 85.37, 0, 85.37, 111)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3352, N'10082887', N' Wanderson Gomes dos Santos', N'Negros', 85.27, 0, 85.27, 112)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3353, N'10086072', N' Lucas Florencio dos Santos Sampaio', N'Negros', 85.1, 0, 85.1, 113)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3354, N'10035276', N' Barbara Araujo Moura', N'Negros', 85.09, 0, 85.09, 114)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3355, N'10018231', N' Deviston Azeredo Silva', N'Negros', 85.07, 0, 85.07, 115)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3356, N'10007828', N' Lucas Araujo de Sa', N'Negros', 85.05, 0, 85.05, 116)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3357, N'10053117', N' Jorge Waschington do Carmo Junior', N'Negros', 84.95, 0, 84.95, 117)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3358, N'10035604', N' Jeferson Jesus de Aragao', N'Negros', 84.94, 0, 84.94, 118)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3359, N'10072113', N' Elton da Silva Candido', N'Negros', 84.9, 0, 84.9, 119)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3360, N'10008104', N' Dionisio Bispo de Oliveira Neto', N'Negros', 84.89, 0, 84.89, 120)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3361, N'10049338', N' Gustavo Araujo Lopes da Silva', N'Negros', 84.86, 0, 84.86, 121)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3362, N'10006667', N' Reisval da Silva Pereira Figueiredo', N'Negros', 84.82, 0, 84.82, 122)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3363, N'10050769', N' Leone Braga Teixeira', N'Negros', 84.72, 0, 84.72, 123)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3364, N'10029181', N' Hellen Pereira Santos', N'Negros', 84.71, 0, 84.71, 124)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3365, N'10040086', N' Jessica de Ornelis Borges', N'Negros', 84.57, 0, 84.57, 125)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3366, N'10077333', N' Jonathan Goncalves Dutra de Souza', N'Negros', 84.46, 0, 84.46, 126)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3367, N'10063532', N' Edilene Pereira de Oliveira', N'Negros', 84.4, 0, 84.4, 127)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3368, N'10034605', N' Marcelo Candido Pereira Lopes', N'Negros', 84.32, 0, 84.32, 128)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3369, N'10069241', N' Rock Ney Gomes dos Santos Junior', N'Negros', 84.17, 0, 84.17, 129)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3370, N'10030433', N' Sueli Rodrigues Louzeiro', N'Negros', 84.09, 0, 84.09, 130)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3371, N'10045133', N' Luan Sousa Dias Nogueira ', N'Negros', 84.08, 0, 84.08, 131)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3372, N'10089922', N' Luiz Ricardo Santana Neres ', N'Negros', 83.96, 0, 83.96, 132)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3373, N'10020164', N' Fernando Nascimento dos Santos ', N'Negros', 83.75, 0, 83.75, 133)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3374, N'10093803', N' Rodrigo de Almeida Romar ', N'Negros', 83.71, 0, 83.71, 134)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3375, N'10030724', N' Andressa Virginia Vieira Silva ', N'Negros', 83.71, 0, 83.71, 135)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3376, N'10052326', N' Leandro Amaral da Fonseca ', N'Negros', 83.7, 0, 83.7, 136)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3377, N'10064220', N' Aline Mendonca Batista Pister ', N'Negros', 83.65, 0, 83.65, 137)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3378, N'10013620', N' Magno Pires Cunha ', N'Negros', 83.61, 0, 83.61, 138)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3379, N'10051869', N' Daniele da Silva Rocha ', N'Negros', 83.6, 0, 83.6, 139)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3380, N'10027536', N' Sandoval Santana Meira Junior ', N'Negros', 83.59, 0, 83.59, 140)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3381, N'10025059', N' Iara Ferreira Barbosa ', N'Negros', 83.58, 0, 83.58, 141)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3382, N'10018902', N' Kelly Cruz da Silva ', N'Negros', 83.57, 0, 83.57, 142)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3383, N'10020423', N' Guilherme Vieira da Silva ', N'Negros', 83.56, 0, 83.56, 143)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3384, N'10003454', N' Izabelle Dias Silva ', N'Negros', 83.48, 0, 83.48, 144)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3385, N'10069922', N' Alan Moreira da Silva ', N'Negros', 83.35, 0, 83.35, 145)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3386, N'10036470', N' Sidney da Silva de Oliveira ', N'Negros', 83.32, 0, 83.32, 146)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3387, N'10078093', N' Cleber de Moura Tavares ', N'Negros', 83.31, 0, 83.31, 147)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3388, N'10029717', N' Nara Nubia Silva de Araujo ', N'Negros', 83.3, 0, 83.3, 148)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3389, N'10005733', N' Thales Junior Moreira da Silva ', N'Negros', 83.02, 0, 83.02, 149)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3390, N'10020297', N' Fabio de Almeida Soares ', N'Negros', 82.95, 0, 82.95, 150)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3391, N'10027422', N' Vinicius da Silva Costa ', N'Negros', 82.93, 0, 82.93, 151)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3392, N'10020366', N' Ana Gabriele Fereira Goncalves ', N'Negros', 82.91, 0, 82.91, 152)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3393, N'10100456', N' Monique Nascimento de Oliveira ', N'Negros', 82.9, 0, 82.9, 153)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3394, N'10037069', N' Higor Nunes Azevedo ', N'Negros', 82.84, 0, 82.84, 154)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3395, N'10045130', N' Felix Barbalho Neiva Junior ', N'Negros', 82.79, 0, 82.79, 155)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3396, N'10024099', N' Edinaldo da Silva Santos ', N'Negros', 82.78, 0, 82.78, 156)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3397, N'10055868', N' Felipe Rogerio de Oliveira ', N'Negros', 82.52, 0, 82.52, 157)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3398, N'10022721', N' Marcos Alexandre Sperandio Sabino ', N'Negros', 82.39, 0, 82.39, 158)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3399, N'10061982', N' Bruno Johnson dos Santos Lima ', N'Negros', 82.35, 0, 82.35, 159)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3400, N'10006438', N' Laura Ribeiro Lopes ', N'Negros', 82.3, 0, 82.3, 160)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3401, N'10032890', N' Tauan Moncores Duarte ', N'Negros', 82.29, 0, 82.29, 161)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3402, N'10078318', N' Clayton Rosa ', N'Negros', 82.16, 0, 82.16, 162)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3403, N'10024958', N' Diego Santos Moura ', N'Negros', 82.16, 0, 82.16, 163)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3404, N'10016002', N' Ana Paula Oliveira Nascimento ', N'Negros', 82.1, 0, 82.1, 164)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3405, N'10031997', N' Ronaldo Fernandes Branco Jr ', N'Negros', 82.02, 0, 82.02, 165)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3406, N'10075924', N' Tiago Silva Anunciacao ', N'Negros', 81.99, 0, 81.99, 166)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3407, N'10103286', N' Gabriel da Silva Pascoal ', N'Negros', 81.97, 0, 81.97, 167)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3408, N'10092524', N' Leticia Araujo Figueiredo ', N'Negros', 81.92, 0, 81.92, 168)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3409, N'10046789', N' Michael Ferreira Alves Lima ', N'Negros', 81.91, 0, 81.91, 169)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3410, N'10054039', N' Andre Luiz de Oliveira Barros ', N'Negros', 81.87, 0, 81.87, 170)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3411, N'10019378', N' Thiago Fernandes Caldas Souza ', N'Negros', 81.82, 0, 81.82, 171)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3412, N'10028703', N' Luis Fernando Alves da Silva ', N'Negros', 81.8, 0, 81.8, 172)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3413, N'10026453', N' Leandro da Silva Lima', N'Negros', 81.7, 0, 81.7, 173)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3414, N'10101769', N' Bruno Rafael Martins Pereira ', N'Negros', 81.69, 0, 81.69, 174)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3415, N'10067590', N' Alef Ferreira da Silva ', N'Negros', 81.64, 0, 81.64, 175)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3416, N'10030055', N' Fernando Magalhaes de Paulo ', N'Negros', 81.62, 0, 81.62, 176)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3417, N'10029833', N' Luisa Mansur Ferreira ', N'Negros', 81.49, 0, 81.49, 177)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3418, N'10084258', N' Alexsandro Lima Rocha ', N'Negros', 81.38, 0, 81.38, 178)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3419, N'10060388', N' Jessia Marcia Ferreira Silva ', N'Negros', 81.25, 0, 81.25, 179)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3420, N'10007488', N' Andressa Santos de Souza ', N'Negros', 81.23, 0, 81.23, 180)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3421, N'10075990', N' Max Macedo Cavalcante ', N'Negros', 81.21, 0, 81.21, 181)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3422, N'10087909', N' Jessica Sales Lemes ', N'Negros', 81.2, 0, 81.2, 182)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3423, N'10052921', N' Gabryella Alves da Silva ', N'Negros', 81.18, 0, 81.18, 183)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3424, N'10010823', N' Rayan Lucas Maranhao de Sousa ', N'Negros', 81.13, 0, 81.13, 184)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3425, N'10070881', N' Winston Luiz Prado de Sousa', N'Negros', 81.04, 0, 81.04, 185)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3426, N'10000296', N' Jonas Costa David ', N'Negros', 81.03, 0, 81.03, 186)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3427, N'10047237', N' Aristides dos Reis Pereira ', N'Negros', 80.88, 0, 80.88, 187)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3428, N'10028803', N' Carolaine Pinto Soares ', N'Negros', 80.75, 0, 80.75, 188)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3429, N'10035056', N' Samara Costa de Sousa ', N'Negros', 80.75, 0, 80.75, 189)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3430, N'10011825', N' Marcio Alan Souza Figueiredo ', N'Negros', 80.62, 0, 80.62, 190)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3431, N'10018402', N' Beiany Araujo Costa ', N'Negros', 80.61, 0, 80.61, 191)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3432, N'10077254', N' George de Araujo Santos ', N'Negros', 80.52, 0, 80.52, 192)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3433, N'10002815', N' Daniel Alves Pereira ', N'Negros', 80.42, 0, 80.42, 193)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3434, N'10036430', N' Ednei da Conceicao Sousa ', N'Negros', 80.36, 0, 80.36, 194)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3435, N'10071099', N' Denise de Jesus do Nascimento ', N'Negros', 80.36, 0, 80.36, 195)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3436, N'10043833', N' Dyego Jardim Mendonca ', N'Negros', 80.32, 0, 80.32, 196)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3437, N'10048680', N' Joao Pedro de Oliveira Alves de Castro ', N'Negros', 80.31, 0, 80.31, 197)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3438, N'10001027', N' Igor Marinho Santos ', N'Negros', 80.21, 0, 80.21, 198)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3439, N'10081467', N' Francilene Alves dos Santos ', N'Negros', 80.14, 0, 80.14, 199)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3440, N'10004549', N' Filipe Rhaony Araujo de Siqueira Dantas ', N'Negros', 80.12, 0, 80.12, 200)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3441, N'10073094', N' Edson Willy Cirqueira de Oliveira ', N'Negros', 80.12, 0, 80.12, 201)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3442, N'10094773', N' Irene Teixeira dos Santos', N'Negros', 80.11, 0, 80.11, 202)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3443, N'10017381', N' Marcos Heberth Soares da Silva', N'Negros', 80.02, 0, 80.02, 203)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3444, N'10016741', N' Mayara Serrano da Cunha Santos ', N'Negros', 80.01, 0, 80.01, 204)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3445, N'10059729', N' Eduardo Reis Pacheco ', N'Negros', 79.96, 0, 79.96, 205)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3446, N'10059906', N' Mario Henrique Menezes Santos ', N'Negros', 79.86, 0, 79.86, 206)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3447, N'10068470', N' Thiago Costa Marques ', N'Negros', 79.83, 0, 79.83, 207)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3448, N'10013710', N' Mayara Alves Barbosa Neres ', N'Negros', 79.82, 0, 79.82, 208)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3449, N'10033122', N' Marcelo Martins dos Santos ', N'Negros', 79.76, 0, 79.76, 209)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3450, N'10025940', N' Jessyca Lenne Ramos Chagas ', N'Negros', 79.74, 0, 79.74, 210)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3451, N'10029207', N' Deivid Barbosa dos Santos ', N'Negros', 79.74, 0, 79.74, 211)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3452, N'10001273', N' Ana Eloisa Pereira Lopes da Silva ', N'Negros', 79.72, 0, 79.72, 212)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3453, N'10005985', N' Gilvan Cupertino dos Santos ', N'Negros', 79.63, 0, 79.63, 213)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3454, N'10023537', N' Caio Kelvin dos Santos Melo ', N'Negros', 79.61, 0, 79.61, 214)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3455, N'10075236', N' Nayara Elaine Alves da Costa ', N'Negros', 79.47, 0, 79.47, 215)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3456, N'10055087', N' Talita da Cunha Sousa ', N'Negros', 79.18, 0, 79.18, 216)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3457, N'10076635', N' Josafa Goncalves dos Santos ', N'Negros', 79.18, 0, 79.18, 217)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3458, N'10108512', N' Adriano Reis dos Santos ', N'Negros', 79.18, 0, 79.18, 218)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3459, N'10088473', N' Alexandre Martins Barbosa ', N'Negros', 79.15, 0, 79.15, 219)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3460, N'10006335', N' Claudio Francisco dos Santos ', N'Negros', 78.98, 0, 78.98, 220)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3461, N'10111689', N' Vitor Rodrigues Silva de Souza ', N'Negros', 78.93, 0, 78.93, 221)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3462, N'10040988', N' Diego Mayer Viana Rocha ', N'Negros', 78.84, 0, 78.84, 222)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3463, N'10034013', N' Marianny Rosa Fernandes Ramos ', N'Negros', 78.82, 0, 78.82, 223)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3464, N'10063215', N' Alan Klinsmann Sousa Ferreira ', N'Negros', 78.8, 0, 78.8, 224)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3465, N'10019747', N' Joabson Alexandre Marques de Castro ', N'Negros', 78.78, 0, 78.78, 225)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3466, N'10011375', N' Rodrigo Carneiro de Melo ', N'Negros', 78.68, 0, 78.68, 226)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3467, N'10028136', N' Leandro Rocha da Silva ', N'Negros', 78.62, 0, 78.62, 227)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3468, N'10015831', N' Aylana Patricia Rodrigues Costa ', N'Negros', 78.53, 0, 78.53, 228)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3469, N'10080963', N' Joao Heverton de Jesus Nunes ', N'Negros', 78.32, 0, 78.32, 229)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3470, N'10057957', N' Leandro Ferreira da Mata ', N'Negros', 78.24, 0, 78.24, 230)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3471, N'10075154', N' Thiago Macedo de Carvalho ', N'Negros', 78.17, 0, 78.17, 231)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3472, N'10024367', N' Jemisson Rocha dos Santos ', N'Negros', 78.11, 0, 78.11, 232)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3473, N'10022927', N' Rafaela Cristina Magalhaes Gomes ', N'Negros', 78.02, 0, 78.02, 233)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3474, N'10045928', N' Lanaira Rodrigues da Silva ', N'Negros', 77.85, 0, 77.85, 234)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3475, N'10047981', N' Fabiula Sousa Tito ', N'Negros', 77.74, 0, 77.74, 235)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3476, N'10072068', N' Ananda Ramaiana Barbosa da Gama ', N'Negros', 77.7, 0, 77.7, 236)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3477, N'10011370', N' Rodrigo Pires Teodoro ', N'Negros', 77.69, 0, 77.69, 237)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3478, N'10026510', N' Maria do Socorro Rodrigues Barbosa ', N'Negros', 77.68, 0, 77.68, 238)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3479, N'10001718', N' Leandro dos Santos Sousa ', N'Negros', 77.62, 0, 77.62, 239)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3480, N'10072941', N' Amanda Menezes Silva do Nascimento Angelim ', N'Negros', 77.49, 0, 77.49, 240)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3481, N'10040412', N' Emerson Vieira dos Santos ', N'Negros', 77.4, 0, 77.4, 241)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3482, N'10096003', N' Gabriela Farias de Souza ', N'Negros', 77.36, 0, 77.36, 242)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3483, N'10086700', N' Jemerson de Carvalho Silva ', N'Negros', 77.3, 0, 77.3, 243)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3484, N'10057921', N' Danillo Cordeiro dos Santos de Santana ', N'Negros', 77.26, 0, 77.26, 244)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3485, N'10034215', N' Davidson Costa dos Santos ', N'Negros', 76.89, 0, 76.89, 245)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3486, N'10032346', N' Raysson Nogueira dos Santos', N'Negros', 76.66, 0, 76.66, 246)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3487, N'10039747', N' Pedro Henrique Mota de Azevedo', N'Negros', 76.59, 0, 76.59, 247)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3488, N'10064001', N' Saulo Yuri Oliveira Santos', N'Negros', 76.52, 0, 76.52, 248)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3489, N'10033322', N' Renato Melo dos Santos', N'Negros', 76.46, 0, 76.46, 249)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3490, N'10054983', N' Suzana Marques Brandao Santos', N'Negros', 76.27, 0, 76.27, 250)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3491, N'10032914', N' Greicy Kelly Pereira de Souza', N'Negros', 76.22, 0, 76.22, 251)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3492, N'10024057', N' Yan Lucca Souza Amorim', N'Negros', 76.18, 0, 76.18, 252)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3493, N'10093720', N' Tiago Lima Paraizo', N'Negros', 75.56, 0, 75.56, 253)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3494, N'10060875', N' Geraldo Matias Junior', N'Negros', 75.41, 0, 75.41, 254)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3495, N'10030164', N' Carlos Rafael Bessa da Silva', N'Negros', 75.34, 0, 75.34, 255)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3496, N'10081471', N' Guilherme Henrique Rodrigues Rabelo', N'Negros', 75.34, 0, 75.34, 256)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3497, N'10031030', N'Rebeca Lima Oliveira', N'Negros', 75.33, 0, 75.33, 257)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3498, N'10059450', N' Thayrine dos Santos Fagundes', N'Negros', 75.23, 0, 75.23, 258)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3499, N'10003224', N' Raphael Oliveira dos Santos', N'Negros', 74.88, 0, 74.88, 259)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3500, N'10017260', N' Thiago Santos de Sousa', N'Negros', 74.85, 0, 74.85, 260)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3501, N'10010102', N' Yasmin da Fonseca Santos', N'Negros', 74.6, 0, 74.6, 261)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3502, N'10001563', N' Miriam Roisman', N'SJA', 111.77, 0, 111.77, 12)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3503, N'10051049', N' Fernanda Duarte Franca de Castro', N'SJA', 104.3, 0, 104.3, 86)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3504, N'10027532', N' Mateus do Carmo Cunha', N'SJA', 101.72, 0, 101.72, 144)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3505, N'10006976', N' Lucas Gomes Marques', N'SJA', 101.68, 0, 101.68, 145)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3506, N'10009533', N' Karen Cristine Moreno de Medeiros Carvalho', N'SJA', 101.3, 0, 101.3, 165)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3507, N'10081019', N' Danilo Santiago Barbosa Silva', N'SJA', 100.38, 0, 100.38, 207)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3508, N'10056397', N' Nayara dos Santos Siqueira', N'SJA', 100.34, 0, 100.34, 209)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3509, N'10011926', N' Danilo Rigamonte Carneiro', N'SJA', 100.32, 0, 100.32, 210)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3510, N'10081568', N' Alane Goncalves Vieira', N'SJA', 99.28, 0, 99.28, 263)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3511, N'10048061', N' Jose Castanheira Clemente', N'SJA', 99.27, 0, 99.27, 264)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3512, N'10006952', N' Leonardo Esteves Ferreira Mendes', N'SJA', 98.96, 0, 98.96, 283)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3513, N'10007788', N' Marcelo Lirio Alves', N'SJA', 98.86, 0, 98.86, 286)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3514, N'10025783', N' Marco Thulio Silva Costa', N'SJA', 98.83, 0, 98.83, 287)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3515, N'10046410', N' Nilo Laercio de Abreu dos Santos', N'SJA', 98.55, 0, 98.55, 305)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3516, N'10001972', N' Lilian de Souza Carvalho', N'SJA', 98.26, 0, 98.26, 321)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3517, N'10053678', N' Deyse Gisele Rodrigues de Oliveira', N'SJA', 97.71, 0, 97.71, 348)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3518, N'10068142', N' Leandro Ribas Neves', N'SJA', 97.42, 0, 97.42, 362)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3519, N'10009821', N' Angelo Salvio Mendonca Negrao', N'SJA', 96.64, 0, 96.64, 414)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3520, N'10081325', N' Allan Leandro Bezerra do Nascimento', N'SJA', 96.14, 0, 96.14, 445)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3521, N'10024749', N' Bruno Chaves Ferreira Lima', N'SJA', 94.85, 0, 94.85, 540)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3522, N'10034482', N' Wesley de Oliveira Chaves', N'SJA', 94.69, 0, 94.69, 557)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3523, N'10002309', N' Ana Paula Resende', N'SJA', 94.46, 0, 94.46, 571)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3524, N'10005134', N' Erick Tavares de Abreu', N'SJA', 94.22, 0, 94.22, 586)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3525, N'10006611', N' Luisa Defranco Ferreira Peconick', N'SJA', 93.71, 0, 93.71, 622)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3526, N'10055705', N' Camilla Rinaldi de Oliveira', N'SJA', 93.26, 0, 93.26, 660)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3527, N'10000220', N' Henrique Alves Brito Sousa de Melo', N'SJA', 92.95, 0, 92.95, 690)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3528, N'10071526', N' Igor Gabriel Tinoco Gerardin Poirot Land', N'SJA', 92.81, 0, 92.81, 705)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3529, N'10052874', N' Pedro de Paula Filho', N'SJA', 92.59, 0, 92.59, 725)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3530, N'10007167', N' Joao Augusto M de Magalhaes', N'SJA', 91.95, 0, 91.95, 767)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3531, N'10039654', N' Joao Paulo Vaz Mendes', N'SJA', 91.92, 0, 91.92, 770)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3532, N'10023871', N' Leonardo Ayres Simi deCamargo', N'SJA', 91.77, 0, 91.77, 781)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3533, N'10089575', N' Marcelo Goncalves Moura', N'SJA', 91.72, 0, 91.72, 787)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3534, N'10061353', N' Mariana de Avila Palhares', N'SJA', 91.64, 0, 91.64, 797)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3535, N'10030392', N' Jessica Piva', N'SJA', 91.35, 0, 91.35, 822)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3536, N'10083405', N' Eduardo Clemente', N'SJA', 91.32, 0, 91.32, 829)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3537, N'10060996', N' Rebecca Araujo Viana', N'SJA', 91.09, 0, 91.09, 851)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3538, N'10056818', N' Filipe Araujo de Oliveira', N'SJA', 90.74, 0, 90.74, 888)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3539, N'10021806', N' Priscila Isaias da Silva', N'SJA', 90.29, 0, 90.29, 927)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3540, N'10075101', N' Vanessa Vitalino', N'SJA', 90.15, 0, 90.15, 934)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3541, N'10010342', N' Juliana Bona de Faria Pinto', N'SJA', 90.13, 0, 90.13, 935)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3542, N'10065837', N' Daniel Torres Carvello', N'SJA', 90.1, 0, 90.1, 942)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3543, N'10040019', N' Caio Magno Mendonca dos Santos', N'SJA', 86.58, 0, 86.58, 1226)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3544, N'10013060', N' Jose Alencar Lins da Cunha', N'SJA', 86.33, 0, 86.33, 1234)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3545, N'10020092', N' Bruna Caroline Nascimento Messias', N'SJA', 86.25, 0, 86.25, 1238)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3546, N'10014946', N' Diego dos Santos Tavares', N'SJA', 86.17, 0, 86.17, 1243)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3547, N'10031879', N' Clovis Rodrigues Pereira Neto', N'SJA', 86.08, 0, 86.08, 1247)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3548, N'10010063', N' Rafaela Balliana Braganca de Vasconcelos', N'SJA', 85.55, 0, 85.55, 1268)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3549, N'10004704', N' Rodrigo Lira Saraiva', N'SJA', 84.28, 0, 84.28, 1317)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3550, N'10081019', N' Danilo Santiago Barbosa Silva', N'SJN', 100.38, 0, 100.38, 9)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3551, N'10001972', N' Lilian de Souza Carvalho', N'SJN', 98.26, 0, 98.26, 17)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3552, N'10009271', N' Marcus Vinicius Correa de Macedo', N'SJN', 92.75, 0, 92.75, 44)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3553, N'10048862', N' Erika Helena Bomfim dos Santos', N'SJN', 90.93, 0, 90.93, 59)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3554, N'10092392', N' Jean Rodrigues Cardoso Santana', N'SJN', 89.93, 0, 89.93, 63)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3555, N'10040900', N' Patricia Medeiros da Silva Dias', N'SJN', 87.06, 0, 87.06, 90)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3556, N'10010381', N' Igor Magalhaes de Assis', N'SJN', 86.66, 0, 86.66, 97)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3557, N'10081973', N' Lucas Paulo da Silva Santos', N'SJN', 86.26, 0, 86.26, 106)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3558, N'10079120', N' Keila Moldes de Menezes', N'SJN', 85.3, 0, 85.3, 120)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3559, N'10055985', N' Italo de Farias Conceicao', N'SJN', 84.8, 0, 84.8, 132)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3560, N'10063633', N' Rebeca das Dores Lopes', N'SJN', 83.49, 0, 83.49, 154)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3561, N'10040572', N' Gabriel de Paula Lima', N'SJN', 82.99, 0, 82.99, 161)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3562, N'10072090', N' Kalitta Monique da Silva Duarte', N'SJN', 82.55, 0, 82.55, 169)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3563, N'10038540', N' Danniel Reis de Oliveira', N'SJN', 80.76, 0, 80.76, 201)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3564, N'10037339', N' Anderson Christian Barbosa Apostolo', N'SJN', 80.71, 0, 80.71, 204)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3565, N'10052148', N' Rene Rodrigues Ferreira Batista dos Santos', N'SJN', 79.04, 0, 79.04, 235)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3566, N'10059603', N' Gilvan da Costa Tavares', N'SJN', 78.32, 0, 78.32, 246)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3567, N'10047588', N' Kassia Thayna Madureira Ramos', N'SJN', 77.88, 0, 77.88, 251)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3568, N'10075717', N' Thiago Pereira Gomes', N'SJN', 77.44, 0, 77.44, 259)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3569, N'10018479', N' Anselmo Oliveira', N'SJN', 75.87, 0, 75.87, 272)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3570, N'10100179', N' Zenilton Galvao Nunes.', N'SJN', 75.73, 0, 75.73, 273)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3571, N'10020072', N' Jean Carlos Silva Medeiros', N'SJN', 74.92, 0, 74.92, 280)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3572, N'10025783', N' Marco Thulio Silva Costa ', N'SJD', 98.83, 0, 98.83, 1)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3573, N'10055324', N' Caio Vieira Florindo ', N'SJD', 73.17, 0, 73.17, 9)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3574, N'10058713', N' Carlos Danillo Costa Santos ', N'SJD', 71.98, 0, 71.98, 11)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3575, N'10027609', N' Marina Lemes de Carvalho ', N'SJD', 70.15, 0, 70.15, 14)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3576, N'10042565', N' Jacqueline Neves de Souza ', N'SJD', 68.17, 0, 68.17, 17)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3577, N'10020313', N' Fatima de Oliveira Jorge Campos ', N'SJD', 67.47, 0, 67.47, 19)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3578, N'10058270', N' Renata Ayres Costa', N'SJD', 66.76, 0, 66.76, 23)
          GO
          INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao]) VALUES (3579, N'10056434', N' Lucas Campolina Barbosa Melo ', N'SJD', 65.24, 0, 65.24, 24)
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
