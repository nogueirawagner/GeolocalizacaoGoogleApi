namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class adicionandoescrivaes : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        SET IDENTITY_INSERT [dbo].[Aluno] ON 
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3591, N'10024163', N' Gibran Daoud', N'Ampla', 125.35, 0, 125.35, 1, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3592, N'10001723', N' Fernanda Martins Rocha', N'Ampla', 121.52, 0, 121.52, 2, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3593, N'10002184', N' Pedro Vitor Resende', N'Ampla', 121.02, 0, 121.02, 3, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3594, N'10049866', N' Victor Vasconcelos Alves', N'Ampla', 120.78, 0, 120.78, 4, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3595, N'10050684', N' Marcos Antonio Alves de Oliveira Pinto', N'Ampla', 119.1, 0, 119.1, 5, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3596, N'10008110', N' Jessica de Jesus Pinto', N'Ampla', 118.45, 0, 118.45, 6, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3597, N'10002641', N' Yan Nunes Rangel Costa', N'Ampla', 118.3, 0, 118.3, 7, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3598, N'10031628', N' Filipe Humberto Oliveira Drumond Albuquerque', N'Ampla', 117.35, 0, 117.35, 8, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3599, N'10008019', N' Angelina Segre Melhoranca', N'Ampla', 117.31, 0, 117.31, 9, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3600, N'10047695', N' Thiago Fernandes Beserra', N'Ampla', 116.71, 0, 116.71, 10, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3601, N'10052920', N' Pablo Felipe dos Santos', N'Ampla', 116.32, 0, 116.32, 11, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3602, N'10034437', N' Cesar Rodrigues de Queiroz Macedo', N'Ampla', 116.08, 0, 116.08, 12, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3603, N'10045128', N' Elvys Joubert Calai Bitencourt', N'Ampla', 116.04, 0, 116.04, 13, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3604, N'10007579', N' Ana Clara de Almeida Bossi Guimaraes', N'Ampla', 115.99, 0, 115.99, 14, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3605, N'10000839', N' Elisangela Maria Andrioli', N'Ampla', 115.89, 0, 115.89, 15, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3606, N'10039490', N' Jefferson Paiva Nascimento', N'Ampla', 115.79, 0, 115.79, 16, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3607, N'10034983', N' Davi Angelo do Rego Negreiros', N'Ampla', 115.77, 0, 115.77, 17, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3608, N'10010155', N' Jhuly Kelly Ferreira Rodrigues', N'Ampla', 115.69, 0, 115.69, 18, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3609, N'10007752', N' Fernanda Schreiber', N'Ampla', 115.35, 0, 115.35, 19, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3610, N'10011455', N' Carolina Pinho de Castro', N'Ampla', 115.29, 0, 115.29, 20, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3611, N'10049186', N' Carlos Magno Machado Lemos', N'Ampla', 115.28, 0, 115.28, 21, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3612, N'10038469', N' Gabriel Rodrigues Soares', N'Ampla', 115.14, 0, 115.14, 22, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3613, N'10011846', N' Joao Pedro Koerich', N'Ampla', 114.63, 0, 114.63, 23, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3614, N'10011351', N' Matheus Costa de Freitas', N'Ampla', 114.51, 0, 114.51, 24, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3615, N'10035216', N' Gabryella Melo Silveira', N'Ampla', 114.23, 0, 114.23, 25, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3616, N'10004750', N' Hugo de Miranda Taglialegna', N'Ampla', 114.15, 0, 114.15, 26, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3617, N'10037163', N' Eunice Vitorio de Oliveira', N'Ampla', 114.05, 0, 114.05, 27, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3618, N'10068820', N' Amanda Dornelas da Silveira', N'Ampla', 113.94, 0, 113.94, 28, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3619, N'10009001', N' Pedro Henrique Mundel da Silva', N'Ampla', 113.84, 0, 113.84, 29, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3620, N'10006771', N' Thaynna Correa de Oliveira', N'Ampla', 113.71, 0, 113.71, 30, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3621, N'10018818', N' Mayra Lacerda Gomes', N'Ampla', 113.51, 0, 113.51, 31, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3622, N'10006283', N' Daniela Nogueira de Resende Lopes', N'Ampla', 113.3, 0, 113.3, 32, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3623, N'10000146', N' Diogo Gutierres de Almeida', N'Ampla', 113.19, 0, 113.19, 33, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3624, N'10003677', N' Ananda de Cassia do Nascimento Laurent Rocchi', N'Ampla', 113.17, 0, 113.17, 34, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3625, N'10010020', N' Leonardo Carvalho de Medeiros', N'Ampla', 113.08, 0, 113.08, 35, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3626, N'10015832', N' Lucas Vale Adjafre', N'Ampla', 112.97, 0, 112.97, 36, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3627, N'10033563', N' Daniele Barbosa da Silva', N'Ampla', 112.94, 0, 112.94, 37, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3628, N'10009205', N' Yasmin Simoes Neri Leal', N'Ampla', 112.46, 0, 112.46, 38, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3629, N'10006543', N' Rayssa Goncalves Sabino', N'Ampla', 112.44, 0, 112.44, 39, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3630, N'10019339', N' Pedro Henrique de Magalhaes Casimiro', N'Ampla', 112.29, 0, 112.29, 40, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3631, N'10037443', N' Renata Augusto Vieira', N'Ampla', 112.16, 0, 112.16, 41, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3632, N'10036608', N' Marcella Hermida de Paula', N'Ampla', 112.12, 0, 112.12, 42, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3633, N'10013415', N' Micael Alves de Paula e Silva', N'Ampla', 112.04, 0, 112.04, 43, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3634, N'10034138', N' Mariana Rocha Tomaz', N'Ampla', 112.02, 0, 112.02, 44, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3635, N'10013592', N' Lucas Nascimento Ferreira', N'Ampla', 111.96, 0, 111.96, 45, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3636, N'10017224', N' Talita Gleycilane Mendes da Silva', N'Ampla', 111.67, 0, 111.67, 46, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3637, N'10049552', N' Guilherme Carneiro Sarmento', N'Ampla', 111.55, 0, 111.55, 47, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3638, N'10023992', N' Tiago Evaldo Freitag', N'Ampla', 111.5, 0, 111.5, 48, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3639, N'10062629', N' Eric Vonderscher', N'Ampla', 111.46, 0, 111.46, 49, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3640, N'10016224', N' Marcella Jeronimo Ferreira Nunes', N'Ampla', 111.43, 0, 111.43, 50, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3641, N'10009425', N' Ihago Passos Castro', N'Ampla', 111.43, 0, 111.43, 51, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3642, N'10053723', N' Matheus Franca dos Reis', N'Ampla', 111.32, 0, 111.32, 52, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3643, N'10002637', N' Izabela Aguiar Peixoto', N'Ampla', 111.16, 0, 111.16, 53, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3644, N'10006749', N' Ciro Augusto Coelho de Almeida', N'Ampla', 111.12, 0, 111.12, 54, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3645, N'10042033', N' Marcelo Vilela Del Pino', N'Ampla', 111.1, 0, 111.1, 55, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3646, N'10041105', N' Luan Torres Topdjian', N'Ampla', 111.07, 0, 111.07, 56, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3647, N'10043305', N' Lara Morais Rocha', N'Ampla', 110.98, 0, 110.98, 57, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3648, N'10016926', N' Renan Soares do Amaral Santos', N'Ampla', 110.97, 0, 110.97, 58, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3649, N'10009037', N' Priscila Barros Matias Bearzi', N'Ampla', 110.92, 0, 110.92, 59, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3650, N'10001960', N' Dayanne Wanessa Vitoria Miranda', N'Ampla', 110.79, 0, 110.79, 60, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3651, N'10056425', N' Tallton Chalaco Lacerda Santos', N'Ampla', 110.76, 0, 110.76, 61, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3652, N'10043001', N' Ezrom Marques de Souza', N'Ampla', 110.76, 0, 110.76, 62, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3653, N'10013675', N' Pedro Ivo Marques de Melo', N'Ampla', 110.69, 0, 110.69, 63, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3654, N'10018096', N' Bruna da Costa Rodrigues', N'Ampla', 110.59, 0, 110.59, 64, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3655, N'10019214', N' Mateus Ferreira Leandro de Oliveira', N'Ampla', 110.54, 0, 110.54, 65, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3656, N'10004519', N' Alyne de Morais Santiago Gaia', N'Ampla', 110.52, 0, 110.52, 66, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3657, N'10038439', N' Victor Augusto de Araujo Goncalves', N'Ampla', 110.38, 0, 110.38, 67, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3658, N'10017514', N' Thiago Bolelli Costa', N'Ampla', 110.34, 0, 110.34, 68, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3659, N'10003588', N' Larissa Menezes dos Reis', N'Ampla', 110.12, 0, 110.12, 69, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3660, N'10022716', N' Anderson Viana de Carvalho Junior', N'Ampla', 110.04, 0, 110.04, 70, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3661, N'10002803', N' Natalia de Araujo Matte', N'Ampla', 109.91, 0, 109.91, 71, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3662, N'10007192', N' Fernanda Lima Gomes de Matos', N'Ampla', 109.91, 0, 109.91, 72, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3663, N'10024441', N' Edson Thiago Ferreira dos Santos', N'Ampla', 109.9, 0, 109.9, 73, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3664, N'10046248', N' Felipe de Carvalho Araujo', N'Ampla', 109.82, 0, 109.82, 74, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3665, N'10039904', N' Tayna Rodrigues Vieira', N'Ampla', 109.76, 0, 109.76, 75, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3666, N'10021670', N' Matheus Henrique Silva Santos', N'Ampla', 109.71, 0, 109.71, 76, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3667, N'10034381', N' Tamires Jade Pereira da Silva', N'Ampla', 109.68, 0, 109.68, 77, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3668, N'10041122', N' Igor Portela Alves Galindo', N'Ampla', 109.44, 0, 109.44, 78, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3669, N'10002200', N' Melisa Adriana Silva Pimenta', N'Ampla', 109.38, 0, 109.38, 79, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3670, N'10001424', N' Andre Gustavo Paiva Lemos', N'Ampla', 109.26, 0, 109.26, 80, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3671, N'10010121', N' Ana Luiza de Sousa Facchinetti', N'Ampla', 109.24, 0, 109.24, 81, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3672, N'10001062', N' Gabriela Marques de Moura Arruda', N'Ampla', 109.23, 0, 109.23, 82, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3673, N'10036251', N' Carlos Augusto de Carvalho Junior', N'Ampla', 109.21, 0, 109.21, 83, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3674, N'10022088', N' Leticia Esteves de Almeida Reis', N'Ampla', 109.2, 0, 109.2, 84, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3675, N'10001748', N' Filipe Leal Fernandes de Morais', N'Ampla', 109.17, 0, 109.17, 85, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3676, N'10038462', N' Marjorie Amy Yamada', N'Ampla', 109.1, 0, 109.1, 86, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3677, N'10008984', N' Glauco Alves e Santos Junior', N'Ampla', 109.09, 0, 109.09, 87, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3678, N'10017074', N' Luis Fernando Serrao Fabio', N'Ampla', 109, 0, 109, 88, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3679, N'10002679', N' Joao Pedro Oliveira Silva', N'Ampla', 108.97, 0, 108.97, 89, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3680, N'10027396', N' Gabriela de Morais', N'Ampla', 108.93, 0, 108.93, 90, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3681, N'10026880', N' Farida de Oliveira Luz', N'Ampla', 108.84, 0, 108.84, 91, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3682, N'10020943', N' Marcus Vinicius Machado de Abreu Silveira', N'Ampla', 108.82, 0, 108.82, 92, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3683, N'10044942', N' Wilquer Coelho dos Santos', N'Ampla', 108.78, 0, 108.78, 93, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3684, N'10003686', N' Luis Felipe de Castro Rodrigues', N'Ampla', 108.75, 0, 108.75, 94, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3685, N'10043393', N' Antonio Liuesjhon dos Santos Melo', N'Ampla', 108.73, 0, 108.73, 95, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3686, N'10001041', N' Amanda de Lena Leao Dutra', N'Ampla', 108.6, 0, 108.6, 96, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3687, N'10003895', N' Nathalia Azarias de Souza', N'Ampla', 108.53, 0, 108.53, 97, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3688, N'10013025', N' Isabella Pinheiro Tavares', N'Ampla', 108.49, 0, 108.49, 98, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3689, N'10025049', N' Gabriel da Silva Meneses', N'Ampla', 108.44, 0, 108.44, 99, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3690, N'10015891', N' Gustavo Cruz Damico Campello', N'Ampla', 108.41, 0, 108.41, 100, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3691, N'10011635', N' Daniel de Almeida Dallariva', N'Ampla', 108.37, 0, 108.37, 101, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3692, N'10022007', N' Keila Naomi Miyasaki', N'Ampla', 108.29, 0, 108.29, 102, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3693, N'10016966', N' Maiara Neri Josino', N'Ampla', 108.2, 0, 108.2, 103, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3694, N'10036639', N' Leonardo Alves de Oliva Passos', N'Ampla', 108.15, 0, 108.15, 104, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3695, N'10000434', N' Bruna Carvalho Moura', N'Ampla', 108.03, 0, 108.03, 105, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3696, N'10023401', N' Fabiola Imperiano Figueira', N'Ampla', 108, 0, 108, 106, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3697, N'10061865', N' Rafael Ferreira Dutra', N'Ampla', 107.87, 0, 107.87, 107, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3698, N'10040855', N' Giovane Camargos Rezende de Lima', N'Ampla', 107.82, 0, 107.82, 108, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3699, N'10008749', N' Camila Maria Araujo da Silva', N'Ampla', 107.76, 0, 107.76, 109, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3700, N'10020619', N' Webert Hudson Araujo Alquimim', N'Ampla', 107.7, 0, 107.7, 110, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3701, N'10006418', N' Jessica Oliveira Neiva', N'Ampla', 107.69, 0, 107.69, 111, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3702, N'10013319', N' Miguel Paulo Rodrigues Neto', N'Ampla', 107.66, 0, 107.66, 112, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3703, N'10028407', N' Pedro de Freitas Neder', N'Ampla', 107.65, 0, 107.65, 113, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3704, N'10047529', N' Felipe Matsunaga Mizuno', N'Ampla', 107.64, 0, 107.64, 114, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3705, N'10055104', N' Lucca Bernardo Borges', N'Ampla', 107.62, 0, 107.62, 115, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3706, N'10058533', N' Emiliane Ribeiro dos Santos Carvalho', N'Ampla', 107.61, 0, 107.61, 116, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3707, N'10035434', N' Ricardo Pedrosa Dagosto', N'Ampla', 107.59, 0, 107.59, 117, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3708, N'10000192', N' Thais Milene dos Santos Alves', N'Ampla', 107.54, 0, 107.54, 118, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3709, N'10059325', N' Paulo Ricardo Lopes Lobo', N'Ampla', 107.45, 0, 107.45, 119, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3710, N'10056802', N' Eduardo Figueiredo Fialho', N'Ampla', 107.43, 0, 107.43, 120, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3711, N'10042277', N' Laryssa de Castro Manfrin Manso', N'Ampla', 107.39, 0, 107.39, 121, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3712, N'10025498', N' Natalia Maria Silva Luz', N'Ampla', 107.28, 0, 107.28, 122, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3713, N'10002293', N' Thiago Carvalho Santos de Souza', N'Ampla', 107.28, 0, 107.28, 123, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3714, N'10036634', N' Samuel de Araujo Freire', N'Ampla', 107.27, 0, 107.27, 124, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3715, N'10008684', N' Matheus Medeiros Lenz', N'Ampla', 107.19, 0, 107.19, 125, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3716, N'10046624', N' Humberto Alves Brito Sousa de Melo', N'Ampla', 107.17, 0, 107.17, 126, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3717, N'10007432', N' Bruno Godoy de Camargo', N'Ampla', 107.17, 0, 107.17, 127, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3718, N'10039023', N' Daniel da Silva Rocha', N'Ampla', 107.1, 0, 107.1, 128, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3719, N'10000652', N' Lucas Amaral Oliveira', N'Ampla', 107.1, 0, 107.1, 129, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3720, N'10005883', N' Alan Pedro Mendes Coelho', N'Ampla', 107.07, 0, 107.07, 130, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3721, N'10009515', N' Lucas Cruvinel Santana', N'Ampla', 107.06, 0, 107.06, 131, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3722, N'10020355', N' Guido Venceslau Barusco Almeida Junior', N'Ampla', 107.06, 0, 107.06, 132, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3723, N'10066836', N' Havilla Fernanda Araujo do Monte', N'Ampla', 107.01, 0, 107.01, 133, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3724, N'10057334', N' Alberto Leopoldo Luna da Mota', N'Ampla', 107.01, 0, 107.01, 134, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3725, N'10010016', N' Andrea Siaticosqui Barbedo da Silva', N'Ampla', 106.96, 0, 106.96, 135, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3726, N'10042762', N' Dereck Bruno de Honorato Ferrao', N'Ampla', 106.93, 0, 106.93, 136, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3727, N'10071337', N' Giovanni Mendes Ribas Novi', N'Ampla', 106.9, 0, 106.9, 137, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3728, N'10022138', N' Rafael Loureiro Coutinho', N'Ampla', 106.87, 0, 106.87, 138, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3729, N'10021799', N' Bruna Maria de Pina', N'Ampla', 106.85, 0, 106.85, 139, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3730, N'10002246', N' Julia de Oliveira Soares', N'Ampla', 106.84, 0, 106.84, 140, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3731, N'10042742', N' Wanderlan Fernandes Guedes Filho', N'Ampla', 106.82, 0, 106.82, 141, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3732, N'10032043', N' Thiago Felipe de Oliveira Spagnolo', N'Ampla', 106.8, 0, 106.8, 142, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3733, N'10055698', N' Gerffystron Maykon do Nascimento Moreira', N'Ampla', 106.78, 0, 106.78, 143, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3734, N'10056968', N' Arthur Machado Gomes Barbosa Souto', N'Ampla', 106.7, 0, 106.7, 144, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3735, N'10034535', N' Gabriel Leite Monteiro Fortes', N'Ampla', 106.69, 0, 106.69, 145, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3736, N'10033653', N' Priscila da Silva Alves', N'Ampla', 106.68, 0, 106.68, 146, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3737, N'10007915', N' Bruna Cassia Schmidt Buzatti', N'Ampla', 106.66, 0, 106.66, 147, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3738, N'10032549', N' Lucas Augusto Abbott Jacob', N'Ampla', 106.65, 0, 106.65, 148, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3739, N'10063079', N' Igor Soto Silawsky', N'Ampla', 106.64, 0, 106.64, 149, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3740, N'10007886', N' Luiza Fernandes Carlos', N'Ampla', 106.61, 0, 106.61, 150, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3741, N'10018898', N' Emanuel Cardoso Pereira', N'Ampla', 106.6, 0, 106.6, 151, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3742, N'10004640', N' Leonardo Dias Carneiro', N'Ampla', 106.6, 0, 106.6, 152, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3743, N'10032376', N' Julio Cesar Martins Vaz', N'Ampla', 106.56, 0, 106.56, 153, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3744, N'10009203', N' Luis Felipe Moreira Baroni Vianna', N'Ampla', 106.55, 0, 106.55, 154, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3745, N'10011612', N' Fernanda Beserra de Almeida', N'Ampla', 106.49, 0, 106.49, 155, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3746, N'10004057', N' Carolina Farias Ferreira Moretto', N'Ampla', 106.42, 0, 106.42, 156, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3747, N'10000090', N' Iasmim Gabriela Silva Souza', N'Ampla', 106.29, 0, 106.29, 157, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3748, N'10027932', N' Milena Ribeiro da Rocha', N'Ampla', 106.28, 0, 106.28, 158, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3749, N'10036010', N' Gustavo Barbosa Machado', N'Ampla', 106.23, 0, 106.23, 159, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3750, N'10029707', N' Jose Luiz Neves dos Santos Junior', N'Ampla', 106.21, 0, 106.21, 160, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3751, N'10028029', N' Gustavo Gualda Goncalves', N'Ampla', 106.21, 0, 106.21, 161, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3752, N'10052351', N' Leonardo Camargo Rodrigues', N'Ampla', 106.19, 0, 106.19, 162, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3753, N'10011748', N' Ariana Engelmann Rodrigues Aragao', N'Ampla', 106.19, 0, 106.19, 163, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3754, N'10034874', N' Juliana Veloso Sa', N'Ampla', 106.12, 0, 106.12, 164, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3755, N'10009955', N' Laiane Silva Pereira', N'Ampla', 106.12, 0, 106.12, 165, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3756, N'10044311', N' Joao Lucas Santos Flores', N'Ampla', 106.05, 0, 106.05, 166, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3757, N'10025947', N' Rafael Augusto de Souza Viana', N'Ampla', 106.01, 0, 106.01, 167, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3758, N'10019825', N' Andre Barbosa Botelho', N'Ampla', 105.9, 0, 105.9, 168, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3759, N'10001965', N' Lorena Reis Oliveira', N'Ampla', 105.88, 0, 105.88, 169, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3760, N'10002518', N' Fabiano Dutra de Azevedo', N'Ampla', 105.83, 0, 105.83, 170, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3761, N'10019925', N' Joana Freitas Machado', N'Ampla', 105.83, 0, 105.83, 171, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3762, N'10013070', N' Mauro Ponciano Soares Junior', N'Ampla', 105.8, 0, 105.8, 172, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3763, N'10023376', N' Paula Reginatto Bau', N'Ampla', 105.78, 0, 105.78, 173, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3764, N'10018029', N' Marceu Silva Sa', N'Ampla', 105.7, 0, 105.7, 174, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3765, N'10012123', N' Sabrina Stinghel Soares', N'Ampla', 105.68, 0, 105.68, 175, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3766, N'10026104', N' Yuri de Torrecillas Almeida', N'Ampla', 105.6, 0, 105.6, 176, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3767, N'10003577', N' Lais Barreto de Araujo', N'Ampla', 105.57, 0, 105.57, 177, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3768, N'10055991', N' Felipe Vargas Grey Tavares', N'Ampla', 105.57, 0, 105.57, 178, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3769, N'10012880', N' Gun Jo', N'Ampla', 105.52, 0, 105.52, 179, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3770, N'10045494', N' Jose Lidberg Rocha Lima Filho', N'Ampla', 105.47, 0, 105.47, 180, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3771, N'10027738', N' Danilo Martins de Queiroz', N'Ampla', 105.46, 0, 105.46, 181, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3772, N'10049807', N' Mariana de Figueiredo Terenzi Coelho', N'Ampla', 105.44, 0, 105.44, 182, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3773, N'10012651', N' Bruno Favoretto Silva', N'Ampla', 105.42, 0, 105.42, 183, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3774, N'10006464', N' Thaiane Vanessa Meira Nascente dos Santos', N'Ampla', 105.42, 0, 105.42, 184, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3775, N'10041946', N' Ana Flavia Cardoso Almeida', N'Ampla', 105.41, 0, 105.41, 185, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3776, N'10004897', N' Wellington Henrique Ponciano', N'Ampla', 105.39, 0, 105.39, 186, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3777, N'10028229', N' Karolinne Araujo Souza', N'Ampla', 105.38, 0, 105.38, 187, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3778, N'10026415', N' Ana Beatriz Queiroz Pacheco', N'Ampla', 105.32, 0, 105.32, 188, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3779, N'10010109', N' Danielle Pereira Gonzalez da Silva', N'Ampla', 105.31, 0, 105.31, 189, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3780, N'10034154', N' Henver Medeiros Carvalho', N'Ampla', 105.3, 0, 105.3, 190, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3781, N'10003542', N' Christophe de Morais Porto', N'Ampla', 105.3, 0, 105.3, 191, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3782, N'10016727', N' Gabriel Abi Chahin de Oliveira Ferreira', N'Ampla', 105.28, 0, 105.28, 192, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3783, N'10010933', N' Amanda Laryssa Borges do Carmo', N'Ampla', 105.28, 0, 105.28, 193, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3784, N'10006175', N' Diego Henrique de Souza Braga', N'Ampla', 105.22, 0, 105.22, 194, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3785, N'10046013', N' Igor Bosco Soares', N'Ampla', 105.21, 0, 105.21, 195, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3786, N'10060049', N' Hugo Vasconcelos Loula', N'Ampla', 105.19, 0, 105.19, 196, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3787, N'10020707', N' Gabriela Moreno Gentilin de Menezes', N'Ampla', 105.19, 0, 105.19, 197, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3788, N'10024371', N' Vitor Hugo Gomes da Silva', N'Ampla', 105.17, 0, 105.17, 198, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3789, N'10004948', N' Ludmilla Eleuterio Rodrigues', N'Ampla', 105.12, 0, 105.12, 199, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3790, N'10016149', N' Beatriz de Albuquerque Rodrigues', N'Ampla', 105, 0, 105, 200, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3791, N'10056625', N' Thalita Campos Lima', N'Ampla', 104.92, 0, 104.92, 201, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3792, N'10002445', N' Murilo Santos Durao', N'Ampla', 104.9, 0, 104.9, 202, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3793, N'10000195', N' Mauricio Brayan Cruz Alves Martins', N'Ampla', 104.89, 0, 104.89, 203, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3794, N'10019223', N' Isabela Vieira Borba', N'Ampla', 104.84, 0, 104.84, 204, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3795, N'10030286', N' Matheus Henrique Fernandes di Credico', N'Ampla', 104.8, 0, 104.8, 205, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3796, N'10000968', N' Ananda Fernandes Constantino', N'Ampla', 104.8, 0, 104.8, 206, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3797, N'10031956', N' Thaissa Barros de Souza', N'Ampla', 104.79, 0, 104.79, 207, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3798, N'10002735', N' Guilherme Augusto Hirata', N'Ampla', 104.75, 0, 104.75, 208, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3799, N'10055321', N' Ronei Ademir Wolff Athayde Junior', N'Ampla', 104.75, 0, 104.75, 209, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3800, N'10032468', N' Mariana Koury Veloso', N'Ampla', 104.7, 0, 104.7, 210, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3801, N'10033997', N' Luiz Henrique dos Santos Silva', N'Ampla', 104.68, 0, 104.68, 211, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3802, N'10003861', N' Sandra Cristina Cavalcante de Araujo', N'Ampla', 104.66, 0, 104.66, 212, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3803, N'10024184', N' Matheus Oliveira Vasconcelos', N'Ampla', 104.64, 0, 104.64, 213, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3804, N'10004582', N' Nathan de Jesus Menezes', N'Ampla', 104.64, 0, 104.64, 214, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3805, N'10051920', N' Silvia Isabella Santos Cavalcanti', N'Ampla', 104.64, 0, 104.64, 215, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3806, N'10030891', N' Estela Alassall de Oliveira Nunes', N'Ampla', 104.63, 0, 104.63, 216, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3807, N'10004806', N' Daniel Brant Llorente Barrio', N'Ampla', 104.58, 0, 104.58, 217, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3808, N'10052277', N' Bruna Barbosa Borges', N'Ampla', 104.49, 0, 104.49, 218, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3809, N'10004462', N' Jeferson Jesus de Aragao', N'Ampla', 104.47, 0, 104.47, 219, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3810, N'10005227', N' Bruno Lopes Vasconcelos', N'Ampla', 104.4, 0, 104.4, 220, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3811, N'10051234', N' Leticia Goncalves Valfre', N'Ampla', 104.4, 0, 104.4, 221, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3812, N'10005285', N' Christiana Mamede Carvalho', N'Ampla', 104.39, 0, 104.39, 222, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3813, N'10006304', N' Bruno Saboia Demeterco', N'Ampla', 104.37, 0, 104.37, 223, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3814, N'10043840', N' Marcelo Ferraz Mourao Bastos', N'Ampla', 104.33, 0, 104.33, 224, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3815, N'10005511', N' Leandro Henrique Pereira de Paula', N'Ampla', 104.32, 0, 104.32, 225, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3816, N'10015343', N' Rudgere Gomes Vasconcelos', N'Ampla', 104.31, 0, 104.31, 226, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3817, N'10001539', N' Gustavo Mainenti Fontes', N'Ampla', 104.3, 0, 104.3, 227, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3818, N'10017152', N' Vitor Heiderick Vilarins', N'Ampla', 104.28, 0, 104.28, 228, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3819, N'10031960', N' Rafael de Oliveira Avila', N'Ampla', 104.28, 0, 104.28, 229, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3820, N'10039335', N' Monike Pontes Silva', N'Ampla', 104.27, 0, 104.27, 230, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3821, N'10018834', N' Eric de Almeida Alvarenga', N'Ampla', 104.26, 0, 104.26, 231, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3822, N'10020975', N' Darlan Ferreira da Silva', N'Ampla', 104.21, 0, 104.21, 232, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3823, N'10031841', N' Leiliane Xavier Alves', N'Ampla', 104.21, 0, 104.21, 233, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3824, N'10066787', N' Leonardo de Oliveira Ramos', N'Ampla', 104.18, 0, 104.18, 234, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3825, N'10051753', N' Matheus Augusto Aguiar Ursulino', N'Ampla', 104.16, 0, 104.16, 235, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3826, N'10018963', N' Tacyara Gobbis Sagae', N'Ampla', 104.15, 0, 104.15, 236, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3827, N'10004440', N' Damaris Moreira de Lima', N'Ampla', 104.06, 0, 104.06, 237, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3828, N'10033147', N' Eduardo Jose Silva Andrade', N'Ampla', 104.05, 0, 104.05, 238, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3829, N'10029757', N' Kyvia Brandao Cavalcanti Gomes', N'Ampla', 104, 0, 104, 239, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3830, N'10017512', N' Lucas Noleto da Silva', N'Ampla', 103.98, 0, 103.98, 240, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3831, N'10044140', N' Vitor Neves Ergang', N'Ampla', 103.94, 0, 103.94, 241, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3832, N'10014399', N' Lucas Augusto Borges Pereira', N'Ampla', 103.89, 0, 103.89, 242, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3833, N'10017012', N' Fernanda Viana de Morais', N'Ampla', 103.87, 0, 103.87, 243, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3834, N'10015537', N' Alexandre Gomes Serra', N'Ampla', 103.83, 0, 103.83, 244, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3835, N'10018581', N' Rafael Cavaignac Ribeiro Borges', N'Ampla', 103.82, 0, 103.82, 245, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3836, N'10007589', N' Marinaldo Moreira dos Santos', N'Ampla', 103.76, 0, 103.76, 246, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3837, N'10050919', N' Arthur Nunes Correia', N'Ampla', 103.75, 0, 103.75, 247, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3838, N'10003055', N' Rubens Martins de Oliveira Filho', N'Ampla', 103.72, 0, 103.72, 248, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3839, N'10025522', N' Rayssa de Souza Leao Rodrigues Lins da Silva', N'Ampla', 103.66, 0, 103.66, 249, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3840, N'10035174', N' Larissa Augusto Ferreira de Queiroz', N'Ampla', 103.64, 0, 103.64, 250, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3841, N'10036241', N' Filipe Camargos Silva Gomes', N'Ampla', 103.59, 0, 103.59, 251, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3842, N'10012158', N' Abimael Silva Chiberio', N'Ampla', 103.57, 0, 103.57, 252, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3843, N'10009633', N' Fabiane Cileia Oliveira Soares', N'Ampla', 103.47, 0, 103.47, 253, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3844, N'10022641', N' Luiza Marques Lanca Gomes', N'Ampla', 103.47, 0, 103.47, 254, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3845, N'10003262', N' Daniela Maia Baruzzi', N'Ampla', 103.36, 0, 103.36, 255, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3846, N'10015199', N' Lucas Oliveira Vecchia', N'Ampla', 103.36, 0, 103.36, 256, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3847, N'10020767', N' Luciana Graever de Medeiros', N'Ampla', 103.35, 0, 103.35, 257, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3848, N'10053701', N' Leandro Arthur Ribeiro Grecco', N'Ampla', 103.31, 0, 103.31, 258, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3849, N'10007031', N' Sahydi Tedesco Abrahao', N'Ampla', 103.29, 0, 103.29, 259, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3850, N'10016797', N' Carlos Fernando Costa Silva', N'Ampla', 103.26, 0, 103.26, 260, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3851, N'10046200', N' Keliane Martins de Ataides', N'Ampla', 103.24, 0, 103.24, 261, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3852, N'10008884', N' Ricardo Hoeveler Costa', N'Ampla', 103.23, 0, 103.23, 262, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3853, N'10002817', N' Luiz Carlos de Paiva Junior', N'Ampla', 103.2, 0, 103.2, 263, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3854, N'10001502', N' Vitor Cardoso de Souza', N'Ampla', 103.18, 0, 103.18, 264, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3855, N'10039012', N' Guilherme Camunha Franchetti', N'Ampla', 103.18, 0, 103.18, 265, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3856, N'10043803', N' Leticia de Aguiar Avelino da Silva', N'Ampla', 103.12, 0, 103.12, 266, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3857, N'10053719', N' Mateus Silva Luna', N'Ampla', 103.04, 0, 103.04, 267, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3858, N'10072329', N' Fabio Roberto Kunz', N'Ampla', 102.99, 0, 102.99, 268, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3859, N'10047103', N' Rafael Rodrigues de Melo Anicezio', N'Ampla', 102.94, 0, 102.94, 269, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3860, N'10056472', N' Aline Vitorassi Moreira', N'Ampla', 102.94, 0, 102.94, 270, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3861, N'10046418', N' Stephanne Andrade Novaes', N'Ampla', 102.91, 0, 102.91, 271, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3862, N'10047120', N' Pedro Ribeiro Dornelas', N'Ampla', 102.89, 0, 102.89, 272, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3863, N'10022884', N' Lucas Martins Ramalho', N'Ampla', 102.72, 0, 102.72, 273, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3864, N'10011802', N' Bruno Kolliker Werneck', N'Ampla', 102.7, 0, 102.7, 274, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3865, N'10006968', N' Leticia Campos Callado', N'Ampla', 102.67, 0, 102.67, 275, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3866, N'10017789', N' Felipe Santos Magnani Carneiro', N'Ampla', 102.66, 0, 102.66, 276, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3867, N'10001061', N' Bruno Lechensque de Aquino', N'Ampla', 102.63, 0, 102.63, 277, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3868, N'10007345', N' Felipe Schaper Ferraz', N'Ampla', 102.58, 0, 102.58, 278, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3869, N'10022168', N' Gleodes Victor Duarte de Souza', N'Ampla', 102.41, 0, 102.41, 279, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3870, N'10007636', N' Lucas Vinicius Diniz Prado', N'Ampla', 102.28, 0, 102.28, 280, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3871, N'10005381', N' Gabriel Galvao Sarzedas', N'Ampla', 102.27, 0, 102.27, 281, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3872, N'10037362', N' Deypson Goncalves Carvalho Filho', N'Ampla', 102.24, 0, 102.24, 282, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3873, N'10008408', N' Lucas Leal Lima de Abreu', N'Ampla', 102.22, 0, 102.22, 283, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3874, N'10017113', N' Walter Aires da Silva', N'Ampla', 102.17, 0, 102.17, 284, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3875, N'10015365', N' Yara Verlaine Cordeiro Matias', N'Ampla', 102.17, 0, 102.17, 285, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3876, N'10020863', N' Hellen Tavares Rodrigues', N'Ampla', 102.09, 0, 102.09, 286, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3877, N'10029938', N' Rodrigo Monteiro Araujo', N'Ampla', 102.06, 0, 102.06, 287, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3878, N'10002226', N' Pablo Araujo da Gama', N'Ampla', 102.06, 0, 102.06, 288, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3879, N'10063679', N' Luiz Marcelo Bergamaschi de Souza', N'Ampla', 101.89, 0, 101.89, 289, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3880, N'10001761', N' Carolina Costa Rubinger', N'Ampla', 101.85, 0, 101.85, 290, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3881, N'10008339', N' Henrique Alves Moreira Rosa', N'Ampla', 101.84, 0, 101.84, 291, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3882, N'10019639', N' Danilo Fialho Severino', N'Ampla', 101.84, 0, 101.84, 292, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3883, N'10055750', N' Jheynysson Soares da Silva', N'Ampla', 101.83, 0, 101.83, 293, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3884, N'10027923', N' Ana Gabriele Fereira Goncalves', N'Ampla', 101.82, 0, 101.82, 294, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3885, N'10065876', N' Matheus Silva Matias', N'Ampla', 101.71, 0, 101.71, 295, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3886, N'10003448', N' Thais Rodrigues Costa', N'Ampla', 101.6, 0, 101.6, 296, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3887, N'10002880', N' Janaina Homero de Almeida', N'Ampla', 101.39, 0, 101.39, 297, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3888, N'10004121', N' Rayff de La Tour Melo Lima', N'Ampla', 101.33, 0, 101.33, 298, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3889, N'10064490', N' Magno Santana Soares', N'Ampla', 101.3, 0, 101.3, 299, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3890, N'10052574', N' Dennis Larsen dos Santos', N'Ampla', 101.29, 0, 101.29, 300, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3891, N'10026655', N' Luiza Regis de Almeida', N'Ampla', 101.21, 0, 101.21, 301, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3892, N'10006383', N' Robson Veloso Goes', N'Ampla', 101.16, 0, 101.16, 302, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3893, N'10026546', N' Diego Batista Morais e Silva', N'Ampla', 101.16, 0, 101.16, 303, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3894, N'10004926', N' Matheus Muniz Barreto', N'Ampla', 100.96, 0, 100.96, 304, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3895, N'10028714', N' Pedro Jose Vales Lima', N'Ampla', 100.9, 0, 100.9, 305, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3896, N'10066166', N' Josue Goncalves Barbosa Junior', N'Ampla', 100.72, 0, 100.72, 306, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3897, N'10004560', N' Renan Andre de Oliveira Soares', N'Ampla', 100.63, 0, 100.63, 307, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3898, N'10020787', N' Gregorio Fernandes Pimenta dos Anjos', N'Ampla', 100.56, 0, 100.56, 308, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3899, N'10027320', N' Hugo Fraga Lattanzi Mota', N'Ampla', 100.52, 0, 100.52, 309, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3900, N'10015567', N' Roger David Dias Rodrigues', N'Ampla', 100.52, 0, 100.52, 310, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3901, N'10058620', N' Pedro Henrique Barcelos Lobo Ramos', N'Ampla', 100.45, 0, 100.45, 311, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3902, N'10012121', N' Tayssa Cordeiro de Oliveira', N'Ampla', 100.21, 0, 100.21, 312, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3903, N'10003885', N' Luis Miguel Fructuoso Ferreira', N'Ampla', 100.19, 0, 100.19, 313, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3904, N'10043916', N' Felippe Henrique Almada Albuquerque Moreira', N'Ampla', 100.17, 0, 100.17, 314, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3905, N'10002739', N' Patrik Mendonca Caires', N'Ampla', 99.95, 0, 99.95, 315, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3906, N'10042784', N' Joao Antonio da Silva Filho', N'Ampla', 99.57, 0, 99.57, 316, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3907, N'10012175', N' Joao Pedro Ferreira Gueiros', N'Ampla', 99.54, 0, 99.54, 317, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3908, N'10012660', N' Gusthavo Damito Baldini', N'Ampla', 99.51, 0, 99.51, 318, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3909, N'10036974', N' Jonas Ricardo e Silva Campos', N'Ampla', 99.49, 0, 99.49, 319, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3910, N'10000103', N' Nathallia Franco Santos', N'Ampla', 99.47, 0, 99.47, 320, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3911, N'10060202', N' Victor Alexandre Paulo Comeira', N'Ampla', 99.18, 0, 99.18, 321, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3912, N'10022516', N' Leonardo Yugo Abe Tanaka', N'Ampla', 98.95, 0, 98.95, 322, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3913, N'10026687', N' Leonardo David Costa de Souza', N'Ampla', 98.88, 0, 98.88, 323, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3914, N'10014828', N' Marlos Angelo Silva Quirino', N'Ampla', 98.78, 0, 98.78, 324, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3915, N'10004947', N' Vitor Gama Amaral', N'Ampla', 98.43, 0, 98.43, 325, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3916, N'10030657', N' Adson Felipe da Cruz Dantas Rocha', N'Ampla', 98.41, 0, 98.41, 326, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3917, N'10026722', N' Mariana de Lacerda Maciel', N'Ampla', 97.93, 0, 97.93, 327, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3918, N'10043078', N' Samuel Oliveira da Cunha', N'Ampla', 97.45, 0, 97.45, 328, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3919, N'10034306', N' Guilherme de Castro Garcia', N'Ampla', 97.44, 0, 97.44, 329, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3920, N'10001096', N' Icaro Pinto Carvalho', N'Ampla', 97.4, 0, 97.4, 330, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3921, N'10010045', N' Everton Simas de Carvalho', N'Ampla', 97.09, 0, 97.09, 331, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3922, N'10000322', N' Nathalia Feitosa de Franca', N'Ampla', 96.85, 0, 96.85, 332, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3923, N'10047517', N' Raquel Silva Moreira', N'Ampla', 96.82, 0, 96.82, 333, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3924, N'10022511', N' Rillary Bertolini Ferrari', N'Ampla', 96.42, 0, 96.42, 334, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3925, N'10008160', N' Artur Albuquerque de Queiroga', N'Ampla', 95.93, 0, 95.93, 335, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3926, N'10002429', N' Ana Karoline Ferreira', N'Ampla', 95.93, 0, 95.93, 336, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3927, N'10056360', N' Rodrigo Rabelo Torres', N'Ampla', 94.4, 0, 94.4, 337, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3928, N'10003668', N' Henrique Carreiro Duarte Araujo Pereira', N'Ampla', 94.01, 0, 94.01, 338, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3929, N'10035421', N'Stephani Lorhani Ribeiro Brito', N'PCD', 84.38, 0, 84.38, 1, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3930, N'10037163', N' Eunice Vitorio de Oliveira', N'Negros', 114.05, 0, 114.05, 1, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3931, N'10004519', N' Alyne de Morais Santiago Gaia', N'Negros', 110.52, 0, 110.52, 2, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3932, N'10058533', N' Emiliane Ribeiro dos Santos Carvalho', N'Negros', 107.61, 0, 107.61, 3, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3933, N'10036634', N' Samuel de Araujo Freire', N'Negros', 107.27, 0, 107.27, 4, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3934, N'10045494', N' Jose Lidberg Rocha Lima Filho', N'Negros', 105.47, 0, 105.47, 5, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3935, N'10002445', N' Murilo Santos Durao', N'Negros', 104.9, 0, 104.9, 6, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3936, N'10000195', N' Mauricio Brayan Cruz Alves Martins', N'Negros', 104.89, 0, 104.89, 7, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3937, N'10004462', N' Jeferson Jesus de Aragao', N'Negros', 104.47, 0, 104.47, 8, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3938, N'10017012', N' Fernanda Viana de Morais', N'Negros', 103.87, 0, 103.87, 9, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3939, N'10034578', N' Thallys Deusdara Monsueth Alves', N'Negros', 103.58, 0, 103.58, 10, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3940, N'10046200', N' Keliane Martins de Ataides', N'Negros', 103.24, 0, 103.24, 11, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3941, N'10000595', N' Kassia Karolliny Ribeiro Camilo', N'Negros', 102.45, 0, 102.45, 12, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3942, N'10022168', N' Gleodes Victor Duarte de Souza', N'Negros', 102.41, 0, 102.41, 13, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3943, N'10007636', N' Lucas Vinicius Diniz Prado', N'Negros', 102.28, 0, 102.28, 14, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3944, N'10033577', N' Glenda Gomes Silva Frank', N'Negros', 102.13, 0, 102.13, 15, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3945, N'10041654', N' Gabriela de Carvalho Soares', N'Negros', 101.89, 0, 101.89, 16, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3946, N'10027923', N' Ana Gabriele Fereira Goncalves', N'Negros', 101.82, 0, 101.82, 17, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3947, N'10007283', N' Thiago Fernandes Caldas Souza', N'Negros', 100.82, 0, 100.82, 18, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3948, N'10053642', N' Rock Ney Gomes dos Santos Junior', N'Negros', 100.65, 0, 100.65, 19, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3949, N'10015563', N' Micael Macedo Pereira da Trindade', N'Negros', 100.32, 0, 100.32, 20, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3950, N'10013256', N' Alisson Carlos Martins Felipe', N'Negros', 99.65, 0, 99.65, 21, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3951, N'10004771', N' Vinicius Tavares de Castro', N'Negros', 99.29, 0, 99.29, 22, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3952, N'10063382', N' Julio Cezar Goncalves Dias', N'Negros', 99.27, 0, 99.27, 23, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3953, N'10017962', N' Danilo Santiago Rodrigues', N'Negros', 98.96, 0, 98.96, 24, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3954, N'10014828', N' Marlos Angelo Silva Quirino', N'Negros', 98.78, 0, 98.78, 25, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3955, N'10020890', N' Raquel Bispo Silva', N'Negros', 98.72, 0, 98.72, 26, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3956, N'10045968', N' Mayara Alves Barbosa Neres', N'Negros', 98.63, 0, 98.63, 27, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3957, N'10009593', N' Kelly Alves dos Santos', N'Negros', 98.54, 0, 98.54, 28, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3958, N'10057299', N' Leandro Ferreira da Mata', N'Negros', 98.45, 0, 98.45, 29, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3959, N'10052765', N' Fernando Souza Lopes', N'Negros', 98.37, 0, 98.37, 30, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3960, N'10037120', N' Vitor Luca Santos Veras Valotto', N'Negros', 98.32, 0, 98.32, 31, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3961, N'10054634', N' Alan Moreira da Silva', N'Negros', 98, 0, 98, 32, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3962, N'10033884', N' Graciella Amorim da Cruz', N'Negros', 97.92, 0, 97.92, 33, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3963, N'10054130', N' Rodrigo de Oliveira Barreto', N'Negros', 97.8, 0, 97.8, 34, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3964, N'10016739', N' Arthur Gouvea Fernandes', N'Negros', 97.79, 0, 97.79, 35, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3965, N'10059187', N' Adamastor Vieira Brandao', N'Negros', 97.7, 0, 97.7, 36, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3966, N'10005352', N' Rafael Lima Barbosa', N'Negros', 97.32, 0, 97.32, 37, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3967, N'10034746', N' Andrei Helber da Costa Moreira', N'Negros', 96.88, 0, 96.88, 38, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3968, N'10054743', N' Tiago Spindula Ferreira', N'Negros', 96.65, 0, 96.65, 39, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3969, N'10038713', N' Joao Victor Carvalho de Oliveira Rocha', N'Negros', 96.06, 0, 96.06, 40, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3970, N'10054698', N' Viviane Narciso Marques', N'Negros', 95.56, 0, 95.56, 41, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3971, N'10044468', N' Igor Cantanhede', N'Negros', 95.18, 0, 95.18, 42, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3972, N'10027563', N' Mayara Araujo Mendes', N'Negros', 94.87, 0, 94.87, 43, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3973, N'10019819', N' Arthur Nunes Esteves', N'Negros', 94.26, 0, 94.26, 44, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3974, N'10039036', N' Matheus Dias de Franca', N'Negros', 94.16, 0, 94.16, 45, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3975, N'10003401', N' Lorena Reylla Oliveira de Sousa Silva', N'Negros', 94.14, 0, 94.14, 46, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3976, N'10024509', N' Luan Sousa Dias Nogueira', N'Negros', 93.48, 0, 93.48, 47, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3977, N'10039577', N' Fernanda Silva de Souza', N'Negros', 93.37, 0, 93.37, 48, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3978, N'10049130', N' Juliana Dantas Mota', N'Negros', 93.3, 0, 93.3, 49, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3979, N'10062052', N' Thiago Costa dos Santos', N'Negros', 93.16, 0, 93.16, 50, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3980, N'10032984', N' Lucas Florencio dos Santos Sampaio', N'Negros', 92.57, 0, 92.57, 51, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3981, N'10003453', N' Amanda Caroline Albernaz da Silva', N'Negros', 92.36, 0, 92.36, 52, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3982, N'10060103', N' Douglas Mendes Trindade', N'Negros', 92.21, 0, 92.21, 53, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3983, N'10052817', N' Brenda Leoterio dos Santos', N'Negros', 92.03, 0, 92.03, 54, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3984, N'10051850', N' Leandro Sousa do Nascimento', N'Negros', 91.36, 0, 91.36, 55, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3985, N'10011519', N' Ramon Pereira Pinto', N'Negros', 91.14, 0, 91.14, 56, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3986, N'10006192', N' Thayza Denize Feitoza de Oliveira', N'Negros', 89.53, 0, 89.53, 57, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3987, N'10013897', N' Jessica de Ornelis Borges', N'Negros', 89.13, 0, 89.13, 58, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3988, N'10033008', N' Loise Kelem Oliveira da Hora', N'SJA', 117.45, 0, 117.45, 8, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3989, N'10032049', N' Miriam Roisman', N'SJA', 116.84, 0, 116.84, 10, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3990, N'10030602', N' Degma Lucia de Alencar Oliveira', N'SJA', 114.95, 0, 114.95, 23, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3991, N'10002749', N' Rene Rodrigues Ferreira Batista dos Santos', N'SJA', 111.92, 0, 111.92, 46, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3992, N'10066144', N' Bruno Batista Suehara', N'SJA', 111.56, 0, 111.56, 47, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3993, N'10001696', N' Lucas Gomes Marques', N'SJA', 109.76, 0, 109.76, 75, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3994, N'10050804', N' Jose Castanheira Clemente', N'SJA', 109.54, 0, 109.54, 78, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3995, N'10000143', N' Paula Maria Vargas Alves', N'SJA', 108.1, 0, 108.1, 105, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3996, N'10005694', N' Breno Carlos Martins Leitao', N'SJA', 107.74, 0, 107.74, 110, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3997, N'10021716', N' Mateus Ribeiro Araujo', N'SJA', 107.67, 0, 107.67, 112, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3998, N'10007235', N' Andley Luiz Clementino de Ceia', N'SJA', 107.59, 0, 107.59, 117, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (3999, N'10000224', N' Erick Tavares de Abreu', N'SJA', 107.12, 0, 107.12, 128, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4000, N'10058392', N' Karen Cristine Moreno de Medeiros Carvalho', N'SJA', 106.87, 0, 106.87, 139, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4001, N'10030194', N' Camila Moura Carrolo', N'SJA', 106.79, 0, 106.79, 143, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4002, N'10014855', N' Marcelo Bezerra Rios', N'SJA', 106.78, 0, 106.78, 143, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4003, N'10065403', N' Vantuyler Borges de Morais', N'SJA', 106.03, 0, 106.03, 167, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4004, N'10016211', N' Caroline Oliveira Rezende', N'SJA', 105.88, 0, 105.88, 170, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4005, N'10013036', N' Carlos Procopio Vieira Freitas', N'SJA', 105.48, 0, 105.48, 180, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4006, N'10039708', N' Maiara da Silva Barros', N'SJA', 105.11, 0, 105.11, 200, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4007, N'10016282', N' Mayara Pereira Antunes', N'SJA', 103.79, 0, 103.79, 246, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4008, N'10018760', N' Diego Messias dos Santos Serafim', N'SJA', 103.66, 0, 103.66, 250, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4009, N'10022371', N' Iandra Barbosa Fontes', N'SJA', 103.34, 0, 103.34, 258, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4010, N'10008935', N' Bruna Dutra Donzelli', N'SJA', 103.29, 0, 103.29, 259, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4011, N'10012218', N' Raphael Ribeiro Rocha', N'SJA', 103.23, 0, 103.23, 262, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4012, N'10023698', N' Julia Scarponi Pinto Costa Pereira', N'SJA', 102.94, 0, 102.94, 270, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4013, N'10048925', N' Marcela Ribas Silva Farage', N'SJA', 102.11, 0, 102.11, 286, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4014, N'10003985', N' Rennan Felipeto Andrade', N'SJA', 101.61, 0, 101.61, 296, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4015, N'10001842', N' Isabella Bruno de Souza', N'SJA', 101.59, 0, 101.59, 297, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4016, N'10039188', N' Fernanda Rodrigues Silva', N'SJA', 101.29, 0, 101.29, 301, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4017, N'10043011', N' Lays Lesli Pereira Dias', N'SJA', 100.94, 0, 100.94, 305, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4018, N'10015067', N' Raphael Miranda Coelho', N'SJA', 99.47, 0, 99.47, 321, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4019, N'10002217', N' Brenda Fernandes Canedo', N'SJA', 99.46, 0, 99.46, 321, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4020, N'10007246', N' Jefson Brandao da Silva', N'SJA', 98.77, 0, 98.77, 325, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4021, N'10042982', N' Roberto Martins dos Santos', N'SJA', 97.73, 0, 97.73, 328, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4022, N'10036877', N' Priscilla Duarte Lopes', N'SJA', 97.53, 0, 97.53, 328, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4023, N'10024260', N' Maykon Braga Pinto Queiroz Vianna', N'SJA', 97.14, 0, 97.14, 331, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4024, N'10040771', N' Gabriel Victor Kataoka Tobias', N'SJA', 96.5, 0, 96.5, 334, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4025, N'10006534', N' Diego Galvao Chaves', N'SJA', 95.85, 0, 95.85, 337, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4026, N'10048643', N' Alanah Ahmad Lopes', N'SJA', 95.5, 0, 95.5, 337, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4027, N'10018045', N' Lays Venancio Lira', N'SJD', 88.12, 0, 88.12, 1, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4028, N'10029772', N' Thassia Hammer Vieira', N'SJD', 82.55, 0, 82.55, 0, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4029, N'10003999', N' Jeferson Cardoso Costa', N'SJD', 82.48, 0, 82.48, 0, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4030, N'10037715', N' Fabio Andre de Souza Resende', N'SJD', 80.87, 0, 80.87, 0, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4031, N'10033008', N' Loise Kelem Oliveira da Hora', N'SJN', 117.45, 0, 117.45, 1, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4032, N'10002749', N' Rene Rodrigues Ferreira Batista dos Santos', N'SJN', 111.92, 0, 111.92, 2, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4033, N'10015067', N' Raphael Miranda Coelho', N'SJN', 99.47, 0, 99.47, 22, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4034, N'10000126', N' Igo Ferreira de Oliveira', N'SJN', 98.62, 0, 98.62, 28, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4035, N'10027958', N' Daniel Lima das Virgens Ferreira', N'SJN', 97.79, 0, 97.79, 35, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4036, N'10016074', N' Marriete Araujo da Silva', N'SJN', 93.89, 0, 93.89, 47, N'Escrivao')
        GO
        INSERT [dbo].[Aluno] ([ID], [Inscricao], [Nome], [Concorrencia], [NotaEtapa1], [NotaEtapa2], [NotaFinal], [Posicao], [Cargo]) VALUES (4037, N'10011345', N' Tharsis Lisboa Martins', N'SJN', 92.24, 0, 92.24, 53, N'Escrivao')
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
