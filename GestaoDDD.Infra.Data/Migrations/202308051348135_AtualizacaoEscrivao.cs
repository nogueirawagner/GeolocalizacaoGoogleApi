namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class AtualizacaoEscrivao : DbMigration
  {
    public override void Up()
    {
      Sql(@"CREATE TABLE [dbo].[Auxiliar](
	      [Inscricao] [nvarchar](255) NULL,
	      [Nome] [nvarchar](255) NULL,
	      [Nota] [nvarchar](255) NULL,
	      [Posicao] [float] NULL,
	      [Concorrencia] [nvarchar](255) NULL,
	      [Cargo] [nvarchar](255) NULL
      ) ON [PRIMARY]");


      Sql(@"

        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002184', N' Pedro Vitor Resende', N' 215.81', 1, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10024163', N' Gibran Daoud', N' 213.89', 2, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10050684', N' Marcos Antonio Alves de Oliveira Pinto', N' 211.81', 3, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10031628', N' Filipe Humberto Oliveira Drumond Albuquerque', N' 211.10', 4, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10049186', N' Carlos Magno Machado Lemos', N' 210.07', 5, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10041105', N' Luan Torres Topdjian', N' 208.99', 6, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000839', N' Elisangela Maria Andrioli', N' 207.56', 7, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10008110', N' Jessica de Jesus Pinto', N' 206.99', 8, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007579', N' Ana Clara de Almeida Bossi Guimaraes', N' 206.61', 9, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10047695', N' Thiago Fernandes Beserra', N' 206.29', 10, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10011351', N' Matheus Costa de Freitas', N' 206.18', 11, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10027396', N' Gabriela de Morais', N' 205.80', 12, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10044942', N' Wilquer Coelho dos Santos', N' 205.65', 13, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10045128', N' Elvys Joubert Calai Bitencourt', N' 205.62', 14, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10010155', N' Jhuly Kelly Ferreira Rodrigues', N' 205.27', 15, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10053723', N' Matheus Franca dos Reis', N' 205.07', 16, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007752', N' Fernanda Schreiber', N' 204.93', 17, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10035216', N' Gabryella Melo Silveira', N' 204.85', 18, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007192', N' Fernanda Lima Gomes de Matos', N' 204.70', 19, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10020943', N' Marcus Vinicius Machado de Abreu Silveira', N' 204.65', 20, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10020619', N' Webert Hudson Araujo Alquimim', N' 204.57', 21, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017224', N' Talita Gleycilane Mendes da Silva', N' 204.38', 22, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006771', N' Thaynna Correa de Oliveira', N' 204.33', 23, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10011846', N' Joao Pedro Koerich', N' 204.21', 24, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022088', N' Leticia Esteves de Almeida Reis', N' 203.99', 25, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10037163', N' Eunice Vitorio de Oliveira', N' 203.63', 26, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003686', N' Luis Felipe de Castro Rodrigues', N' 203.54', 27, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10039490', N' Jefferson Paiva Nascimento', N' 203.29', 28, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034983', N' Davi Angelo do Rego Negreiros', N' 203.27', 29, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015891', N' Gustavo Cruz Damico Campello', N' 203.20', 30, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10052920', N' Pablo Felipe dos Santos', N' 202.78', 31, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003677', N' Ananda de Cassia do Nascimento Laurent Rocchi', N' 202.75', 32, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004750', N' Hugo de Miranda Taglialegna', N' 202.69', 33, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10009205', N' Yasmin Simoes Neri Leal', N' 202.04', 34, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000652', N' Lucas Amaral Oliveira', N' 201.89', 35, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006283', N' Daniela Nogueira de Resende Lopes', N' 201.84', 36, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003588', N' Larissa Menezes dos Reis', N' 201.79', 37, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10010020', N' Leonardo Carvalho de Medeiros', N' 201.62', 38, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10023376', N' Paula Reginatto Bau', N' 201.61', 39, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10038469', N' Gabriel Rodrigues Soares', N' 201.60', 40, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016926', N' Renan Soares do Amaral Santos', N' 201.59', 41, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10024441', N' Edson Thiago Ferreira dos Santos', N' 201.57', 42, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10028407', N' Pedro de Freitas Neder', N' 201.40', 43, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10011612', N' Fernanda Beserra de Almeida', N' 201.28', 44, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10026415', N' Ana Beatriz Queiroz Pacheco', N' 201.15', 45, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10036634', N' Samuel de Araujo Freire', N' 201.02', 46, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017514', N' Thiago Bolelli Costa', N' 200.96', 47, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001424', N' Andre Gustavo Paiva Lemos', N' 200.93', 48, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002637', N' Izabela Aguiar Peixoto', N' 200.74', 49, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10009037', N' Priscila Barros Matias Bearzi', N' 200.50', 50, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015832', N' Lucas Vale Adjafre', N' 200.47', 51, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034437', N' Cesar Rodrigues de Queiroz Macedo', N' 200.45', 52, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10068820', N' Amanda Dornelas da Silveira', N' 200.40', 53, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10032549', N' Lucas Augusto Abbott Jacob', N' 200.40', 54, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006304', N' Bruno Saboia Demeterco', N' 200.20', 55, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10020707', N' Gabriela Moreno Gentilin de Menezes', N' 199.98', 56, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10038439', N' Victor Augusto de Araujo Goncalves', N' 199.96', 57, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10019339', N' Pedro Henrique de Magalhaes Casimiro', N' 199.79', 58, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10005883', N' Alan Pedro Mendes Coelho', N' 199.78', 59, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10047120', N' Pedro Ribeiro Dornelas', N' 199.76', 60, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10037443', N' Renata Augusto Vieira', N' 199.66', 61, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022716', N' Anderson Viana de Carvalho Junior', N' 199.62', 62, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002679', N' Joao Pedro Oliveira Silva', N' 199.59', 63, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022138', N' Rafael Loureiro Coutinho', N' 199.58', 64, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10043305', N' Lara Morais Rocha', N' 199.52', 65, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10055698', N' Gerffystron Maykon do Nascimento Moreira', N' 199.49', 66, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034535', N' Gabriel Leite Monteiro Fortes', N' 199.40', 67, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007915', N' Bruna Cassia Schmidt Buzatti', N' 199.37', 68, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10047529', N' Felipe Matsunaga Mizuno', N' 199.31', 69, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004057', N' Carolina Farias Ferreira Moretto', N' 199.13', 70, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10025049', N' Gabriel da Silva Meneses', N' 199.06', 71, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10008884', N' Ricardo Hoeveler Costa', N' 199.06', 72, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10049552', N' Guilherme Carneiro Sarmento', N' 199.05', 73, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10039012', N' Guilherme Camunha Franchetti', N' 199.01', 74, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10062629', N' Eric Vonderscher', N' 198.96', 75, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10025947', N' Rafael Augusto de Souza Viana', N' 198.72', 76, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10038462', N' Marjorie Amy Yamada', N' 198.68', 77, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10019825', N' Andre Barbosa Botelho', N' 198.61', 78, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10042033', N' Marcelo Vilela Del Pino', N' 198.60', 79, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10071337', N' Giovanni Mendes Ribas Novi', N' 198.57', 80, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10042742', N' Wanderlan Fernandes Guedes Filho', N' 198.49', 81, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10032043', N' Thiago Felipe de Oliveira Spagnolo', N' 198.47', 82, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10013592', N' Lucas Nascimento Ferreira', N' 198.42', 83, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10012158', N' Abimael Silva Chiberio', N' 198.36', 84, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10063079', N' Igor Soto Silawsky', N' 198.31', 85, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10043393', N' Antonio Liuesjhon dos Santos Melo', N' 198.31', 86, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10055991', N' Felipe Vargas Grey Tavares', N' 198.28', 87, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10056425', N' Tallton Chalaco Lacerda Santos', N' 198.26', 88, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006464', N' Thaiane Vanessa Meira Nascente dos Santos', N' 198.13', 89, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006175', N' Diego Henrique de Souza Braga', N' 197.93', 90, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016224', N' Marcella Jeronimo Ferreira Nunes', N' 197.89', 91, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10029707', N' Jose Luiz Neves dos Santos Junior', N' 197.88', 92, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10028029', N' Gustavo Gualda Goncalves', N' 197.88', 93, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10052351', N' Leonardo Camargo Rodrigues', N' 197.86', 94, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034874', N' Juliana Veloso Sa', N' 197.79', 95, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10036639', N' Leonardo Alves de Oliva Passos', N' 197.73', 96, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10066836', N' Havilla Fernanda Araujo do Monte', N' 197.63', 97, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10010016', N' Andrea Siaticosqui Barbedo da Silva', N' 197.58', 98, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015537', N' Alexandre Gomes Serra', N' 197.58', 99, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10019223', N' Isabela Vieira Borba', N' 197.55', 100, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10019925', N' Joana Freitas Machado', N' 197.50', 101, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10031956', N' Thaissa Barros de Souza', N' 197.50', 102, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10025522', N' Rayssa de Souza Leao Rodrigues Lins da Silva', N' 197.41', 103, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10012123', N' Sabrina Stinghel Soares', N' 197.35', 104, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10033563', N' Daniele Barbosa da Silva', N' 197.31', 105, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10005227', N' Bruno Lopes Vasconcelos', N' 197.11', 106, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003895', N' Nathalia Azarias de Souza', N' 197.07', 107, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10011635', N' Daniel de Almeida Dallariva', N' 196.91', 108, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10027932', N' Milena Ribeiro da Rocha', N' 196.90', 109, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10046013', N' Igor Bosco Soares', N' 196.88', 110, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10018963', N' Tacyara Gobbis Sagae', N' 196.86', 111, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10011748', N' Ariana Engelmann Rodrigues Aragao', N' 196.81', 112, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006749', N' Ciro Augusto Coelho de Almeida', N' 196.54', 113, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10008019', N' Angelina Segre Melhoranca', N' 196.48', 114, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10021799', N' Bruna Maria de Pina', N' 196.43', 115, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10056968', N' Arthur Machado Gomes Barbosa Souto', N' 196.28', 116, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10018898', N' Emanuel Cardoso Pereira', N' 196.18', 117, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022641', N' Luiza Marques Lanca Gomes', N' 196.18', 118, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034381', N' Tamires Jade Pereira da Silva', N' 196.14', 119, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001041', N' Amanda de Lena Leao Dutra', N' 196.10', 120, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10037362', N' Deypson Goncalves Carvalho Filho', N' 195.99', 121, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003542', N' Christophe de Morais Porto', N' 195.92', 122, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10036010', N' Gustavo Barbosa Machado', N' 195.81', 123, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016966', N' Maiara Neri Josino', N' 195.70', 124, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002445', N' Murilo Santos Durao', N' 195.52', 125, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017789', N' Felipe Santos Magnani Carneiro', N' 195.37', 126, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10035174', N' Larissa Augusto Ferreira de Queiroz', N' 195.31', 127, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10033997', N' Luiz Henrique dos Santos Silva', N' 195.30', 128, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004806', N' Daniel Brant Llorente Barrio', N' 195.20', 129, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002880', N' Janaina Homero de Almeida', N' 195.14', 130, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004640', N' Leonardo Dias Carneiro', N' 195.14', 131, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10009203', N' Luis Felipe Moreira Baroni Vianna', N' 195.09', 132, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004462', N' Jeferson Jesus de Aragao', N' 195.09', 133, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10053701', N' Leandro Arthur Ribeiro Grecco', N' 194.98', 134, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10028229', N' Karolinne Araujo Souza', N' 194.96', 135, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10056802', N' Eduardo Figueiredo Fialho', N' 194.93', 136, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004519', N' Alyne de Morais Santiago Gaia', N' 194.89', 137, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10042277', N' Laryssa de Castro Manfrin Manso', N' 194.89', 138, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034154', N' Henver Medeiros Carvalho', N' 194.88', 139, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10010933', N' Amanda Laryssa Borges do Carmo', N' 194.86', 140, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002226', N' Pablo Araujo da Gama', N' 194.77', 141, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10024371', N' Vitor Hugo Gomes da Silva', N' 194.75', 142, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004948', N' Ludmilla Eleuterio Rodrigues', N' 194.70', 143, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10008684', N' Matheus Medeiros Lenz', N' 194.69', 144, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10032468', N' Mariana Koury Veloso', N' 194.28', 145, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10018029', N' Marceu Silva Sa', N' 194.24', 146, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10026104', N' Yuri de Torrecillas Almeida', N' 194.14', 147, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10009633', N' Fabiane Cileia Oliveira Soares', N' 194.09', 148, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10035434', N' Ricardo Pedrosa Dagosto', N' 194.05', 149, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10027738', N' Danilo Martins de Queiroz', N' 194.00', 150, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000192', N' Thais Milene dos Santos Alves', N' 194.00', 151, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10051234', N' Leticia Goncalves Valfre', N' 193.98', 152, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10005285', N' Christiana Mamede Carvalho', N' 193.97', 153, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007636', N' Lucas Vinicius Diniz Prado', N' 193.95', 154, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015343', N' Rudgere Gomes Vasconcelos', N' 193.89', 155, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10041122', N' Igor Portela Alves Galindo', N' 193.81', 156, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002200', N' Melisa Adriana Silva Pimenta', N' 193.75', 157, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10072329', N' Fabio Roberto Kunz', N' 193.61', 158, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10039023', N' Daniel da Silva Rocha', N' 193.56', 159, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10057334', N' Alberto Leopoldo Luna da Mota', N' 193.47', 160, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10056625', N' Thalita Campos Lima', N' 193.46', 161, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001965', N' Lorena Reis Oliveira', N' 193.38', 162, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003055', N' Rubens Martins de Oliveira Filho', N' 193.30', 163, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10013070', N' Mauro Ponciano Soares Junior', N' 193.30', 164, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007345', N' Felipe Schaper Ferraz', N' 193.20', 165, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10046248', N' Felipe de Carvalho Araujo', N' 193.15', 166, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10055104', N' Lucca Bernardo Borges', N' 193.04', 167, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10032376', N' Julio Cesar Martins Vaz', N' 193.02', 168, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003262', N' Daniela Maia Baruzzi', N' 192.94', 169, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10041946', N' Ana Flavia Cardoso Almeida', N' 192.91', 170, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004897', N' Wellington Henrique Ponciano', N' 192.89', 171, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10059325', N' Paulo Ricardo Lopes Lobo', N' 192.87', 172, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10019214', N' Mateus Ferreira Leandro de Oliveira', N' 192.83', 173, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10051753', N' Matheus Augusto Aguiar Ursulino', N' 192.70', 174, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002293', N' Thiago Carvalho Santos de Souza', N' 192.70', 175, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10029938', N' Rodrigo Monteiro Araujo', N' 192.68', 176, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10009425', N' Ihago Passos Castro', N' 192.68', 177, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022884', N' Lucas Martins Ramalho', N' 192.30', 178, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10058533', N' Emiliane Ribeiro dos Santos Carvalho', N' 191.98', 179, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10045494', N' Jose Lidberg Rocha Lima Filho', N' 191.93', 180, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007031', N' Sahydi Tedesco Abrahao', N' 191.83', 181, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016727', N' Gabriel Abi Chahin de Oliveira Ferreira', N' 191.74', 182, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001502', N' Vitor Cardoso de Souza', N' 191.72', 183, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10025498', N' Natalia Maria Silva Luz', N' 191.65', 184, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022007', N' Keila Naomi Miyasaki', N' 191.62', 185, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10033147', N' Eduardo Jose Silva Andrade', N' 191.55', 186, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10046624', N' Humberto Alves Brito Sousa de Melo', N' 191.54', 187, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10036251', N' Carlos Augusto de Carvalho Junior', N' 191.50', 188, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10030286', N' Matheus Henrique Fernandes di Credico', N' 191.26', 189, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003448', N' Thais Rodrigues Costa', N' 191.18', 190, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10051920', N' Silvia Isabella Santos Cavalcanti', N' 191.10', 191, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10043001', N' Ezrom Marques de Souza', N' 190.97', 192, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10031841', N' Leiliane Xavier Alves', N' 190.67', 193, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10029757', N' Kyvia Brandao Cavalcanti Gomes', N' 190.46', 194, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017512', N' Lucas Noleto da Silva', N' 190.44', 195, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10047103', N' Rafael Rodrigues de Melo Anicezio', N' 190.44', 196, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001761', N' Carolina Costa Rubinger', N' 190.39', 197, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10008339', N' Henrique Alves Moreira Rosa', N' 190.38', 198, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000434', N' Bruna Carvalho Moura', N' 190.32', 199, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002518', N' Fabiano Dutra de Azevedo', N' 190.20', 200, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10061865', N' Rafael Ferreira Dutra', N' 190.16', 201, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001061', N' Bruno Lechensque de Aquino', N' 190.13', 202, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10036241', N' Filipe Camargos Silva Gomes', N' 190.05', 203, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001960', N' Dayanne Wanessa Vitoria Miranda', N' 189.96', 204, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10020767', N' Luciana Graever de Medeiros', N' 189.81', 205, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10060049', N' Hugo Vasconcelos Loula', N' 189.56', 206, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007589', N' Marinaldo Moreira dos Santos', N' 189.18', 207, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000968', N' Ananda Fernandes Constantino', N' 189.17', 208, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10011802', N' Bruno Kolliker Werneck', N' 189.16', 209, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10031960', N' Rafael de Oliveira Avila', N' 188.65', 210, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10066787', N' Leonardo de Oliveira Ramos', N' 188.55', 211, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007432', N' Bruno Godoy de Camargo', N' 188.42', 212, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10044311', N' Joao Lucas Santos Flores', N' 188.34', 213, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10044140', N' Vitor Neves Ergang', N' 188.31', 214, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10055750', N' Jheynysson Soares da Silva', N' 188.29', 215, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10065876', N' Matheus Silva Matias', N' 188.17', 216, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10050919', N' Arthur Nunes Correia', N' 188.12', 217, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003861', N' Sandra Cristina Cavalcante de Araujo', N' 187.99', 218, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10024184', N' Matheus Oliveira Vasconcelos', N' 187.97', 219, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004121', N' Rayff de La Tour Melo Lima', N' 187.79', 220, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10064490', N' Magno Santana Soares', N' 187.76', 221, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10043840', N' Marcelo Ferraz Mourao Bastos', N' 187.66', 222, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017152', N' Vitor Heiderick Vilarins', N' 187.61', 223, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10020863', N' Hellen Tavares Rodrigues', N' 187.51', 224, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004440', N' Damaris Moreira de Lima', N' 187.39', 225, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10063679', N' Luiz Marcelo Bergamaschi de Souza', N' 187.31', 226, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016149', N' Beatriz de Albuquerque Rodrigues', N' 187.29', 227, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10019639', N' Danilo Fialho Severino', N' 187.26', 228, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10055321', N' Ronei Ademir Wolff Athayde Junior', N' 187.04', 229, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10030891', N' Estela Alassall de Oliveira Nunes', N' 186.92', 230, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006418', N' Jessica Oliveira Neiva', N' 186.86', 231, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10039335', N' Monike Pontes Silva', N' 186.56', 232, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10018834', N' Eric de Almeida Alvarenga', N' 186.55', 233, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001748', N' Filipe Leal Fernandes de Morais', N' 186.25', 234, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000195', N' Mauricio Brayan Cruz Alves Martins', N' 186.14', 235, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10012880', N' Gun Jo', N' 185.73', 236, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10012651', N' Bruno Favoretto Silva', N' 185.63', 237, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10043803', N' Leticia de Aguiar Avelino da Silva', N' 185.41', 238, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004582', N' Nathan de Jesus Menezes', N' 184.85', 239, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015365', N' Yara Verlaine Cordeiro Matias', N' 184.46', 240, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002817', N' Luiz Carlos de Paiva Junior', N' 184.45', 241, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10027923', N' Ana Gabriele Fereira Goncalves', N' 184.11', 242, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016797', N' Carlos Fernando Costa Silva', N' 183.47', 243, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017012', N' Fernanda Viana de Morais', N' 183.04', 244, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10052574', N' Dennis Larsen dos Santos', N' 182.54', 245, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015199', N' Lucas Oliveira Vecchia', N' 182.53', 246, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10005381', N' Gabriel Galvao Sarzedas', N' 182.48', 247, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10010109', N' Danielle Pereira Gonzalez da Silva', N' 182.39', 248, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022168', N' Gleodes Victor Duarte de Souza', N' 180.53', 249, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017113', N' Walter Aires da Silva', N' 173.00', 250, N'Ampla', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10018045', N' Lays Venancio Lira', N' 174.58', 1, N'PCD', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10035421', N' Stephani Lorhani Ribeiro Brito', N' 169.80', 2, N'PCD', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10029772', N' Thassia Hammer Vieira', N' 164.84', 3, N'PCD', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10037715', N' Fabio Andre de Souza Resende', N' 162.12', 4, N'PCD', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10041654', N' Gabriela de Carvalho Soares', N' 195.64', 1, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016739', N' Arthur Gouvea Fernandes', N' 194.66', 2, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000595', N' Kassia Karolliny Ribeiro Camilo', N' 193.07', 3, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034746', N' Andrei Helber da Costa Moreira', N' 192.71', 4, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10034578', N' Thallys Deusdara Monsueth Alves', N' 192.12', 5, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10005352', N' Rafael Lima Barbosa', N' 192.11', 6, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10038713', N' Joao Victor Carvalho de Oliveira Rocha', N' 191.89', 7, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10037120', N' Vitor Luca Santos Veras Valotto', N' 191.03', 8, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10004771', N' Vinicius Tavares de Castro', N' 190.96', 9, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10054634', N' Alan Moreira da Silva', N' 190.71', 10, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10059187', N' Adamastor Vieira Brandao', N' 190.41', 11, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10009593', N' Kelly Alves dos Santos', N' 190.21', 12, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015563', N' Micael Macedo Pereira da Trindade', N' 189.90', 13, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10063382', N' Julio Cezar Goncalves Dias', N' 189.89', 14, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10017962', N' Danilo Santiago Rodrigues', N' 189.58', 15, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10013256', N' Alisson Carlos Martins Felipe', N' 189.23', 16, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10024509', N' Luan Sousa Dias Nogueira', N' 188.27', 17, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10053642', N' Rock Ney Gomes dos Santos Junior', N' 188.15', 18, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10027563', N' Mayara Araujo Mendes', N' 186.54', 19, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10045968', N' Mayara Alves Barbosa Neres', N' 186.13', 20, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10057299', N' Leandro Ferreira da Mata', N' 185.95', 21, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10019819', N' Arthur Nunes Esteves', N' 185.93', 22, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10062052', N' Thiago Costa dos Santos', N' 185.87', 23, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10020890', N' Raquel Bispo Silva', N' 185.18', 24, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10054698', N' Viviane Narciso Marques', N' 185.14', 25, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10014828', N' Marlos Angelo Silva Quirino', N' 182.11', 26, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003453', N' Amanda Caroline Albernaz da Silva', N' 181.94', 27, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10039577', N' Fernanda Silva de Souza', N' 181.91', 28, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10011519', N' Ramon Pereira Pinto', N' 181.76', 29, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10039036', N' Matheus Dias de Franca', N' 181.66', 30, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10044468', N' Igor Cantanhede', N' 181.64', 31, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016074', N' Marriete Araujo da Silva', N' 181.39', 32, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10054743', N' Tiago Spindula Ferreira', N' 181.02', 33, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10051850', N' Leandro Sousa do Nascimento', N' 180.94', 34, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003401', N' Lorena Reylla Oliveira de Sousa Silva', N' 180.60', 35, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10049130', N' Juliana Dantas Mota', N' 179.76', 36, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10033577', N' Glenda Gomes Silva Frank', N' 179.21', 37, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10054130', N' Rodrigo de Oliveira Barreto', N' 179.05', 38, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10060103', N'  Douglas Mendes Trindade', N' 177.63', 39, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10052765', N' Fernando Souza Lopes', N' 177.54', 40, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10013897', N' Jessica de Ornelis Borges', N' 175.59', 41, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10032984', N' Lucas Florencio dos Santos Sampaio', N' 174.86', 42, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007283', N' Thiago Fernandes Caldas Souza', N' 174.78', 43, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10052817', N' Brenda Leoterio dos Santos', N' 174.32', 44, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10006192', N' Thayza Denize Feitoza de Oliveira', N' 164.53', 45, N'Negros', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10032049', N' Miriam Roisman', N' 210.59', 5, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10033008', N' Loise Kelem Oliveira da Hora', N' 207.03', 8, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10066144', N' Bruno Batista Suehara', N' 202.18', 34, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016211', N' Caroline Oliveira Rezende', N' 199.63', 62, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001696', N' Lucas Gomes Marques', N' 198.30', 87, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10021716', N' Mateus Ribeiro Araujo', N' 198.29', 87, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10000224', N' Erick Tavares de Abreu', N' 197.74', 96, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10058392', N' Karen Cristine Moreno de Medeiros Carvalho', N' 197.49', 103, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10018760', N' Diego Messias dos Santos Serafim', N' 197.41', 104, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10065403', N' Vantuyler Borges de Morais', N' 196.65', 113, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002749', N' Rene Rodrigues Ferreira Batista dos Santos', N' 196.29', 116, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10023698', N' Julia Scarponi Pinto Costa Pereira', N' 195.65', 125, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10014855', N' Marcelo Bezerra Rios', N' 195.32', 127, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10030194', N' Camila Moura Carrolo', N' 194.29', 145, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10013036', N' Carlos Procopio Vieira Freitas', N' 194.02', 150, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003985', N' Rennan Felipeto Andrade', N' 193.28', 165, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10050804', N' Jose Castanheira Clemente', N' 192.87', 173, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10039708', N' Maiara da Silva Barros', N' 192.61', 178, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10022371', N' Iandra Barbosa Fontes', N' 191.88', 181, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10012218', N' Raphael Ribeiro Rocha', N' 191.77', 182, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10007235', N' Andley Luiz Clementino de Ceia', N' 190.92', 193, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10008935', N' Bruna Dutra Donzelli', N' 189.75', 206, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10048643', N' Alanah Ahmad Lopes', N' 188.21', 216, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10016282', N' Mayara Pereira Antunes', N' 188.16', 217, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10024260', N' Maykon Braga Pinto Queiroz Vianna', N' 187.76', 222, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10001842', N' Isabella Bruno de Souza', N' 187.01', 230, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10002217', N' Brenda Fernandes Canedo', N' 186.96', 230, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10048925', N' Marcela Ribas Silva Farage', N' 185.44', 238, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10040771', N' Gabriel Victor Kataoka Tobias', N' 181.92', 249, N'SJA', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10003999', N'Jeferson Cardoso Costa', N'156.44', 1, N'SJD', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10015067', N' Raphael Miranda Coelho', N' 185.93', 23, N'SJN', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10027958', N' Daniel Lima das Virgens Ferreira', N' 185.29', 24, N'SJN', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10043128', N' Joao Alexandre Garcia Leite', N' 177.76', 39, N'SJN', N'Escrivao')
        GO
        INSERT [dbo].[Auxiliar] ([Inscricao], [Nome], [Nota], [Posicao], [Concorrencia], [Cargo]) VALUES (N'10044913', N' Cintia Almeida Barbosa', N' 175.51', 42, N'SJN', N'Escrivao')
        GO

        ");

      Sql(@"update Auxiliar set Posicao = 1  where Inscricao = '10003999'");

      Sql(@"update al set  
	        al.NotaEtapa2 = (amp.Nota - al.NotaEtapa1), 
	        NotaFinal = amp.Nota, 
	        al.Posicao = amp.Posicao
        from Aluno al
	        left join Auxiliar amp on TRIM(amp.Inscricao) = TRIM(al.Inscricao)
        where al.Cargo = 'Escrivao'
        and amp.Inscricao is not  null
        ");

      Sql("delete from Aluno where Cargo = 'Escrivao' and NotaEtapa2 = 0 and Inscricao != '10003999'");


    }

    public override void Down()
    {
    }
  }
}
