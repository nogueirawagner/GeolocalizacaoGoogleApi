namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class Adicionandodelegacias : DbMigration
  {
    public override void Up()
    {
      Sql("delete from DepartamentoPolicia");

      Sql(@"
        USE [GestaoDados]
        GO
        SET IDENTITY_INSERT [dbo].[DepartamentoPolicia] ON 
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (2, N'Sim', N'01� DP', N'01� DP; 04� DP; 10� DP', N'Setor Policial - Sul, s/n - Asa Sul, Bras�lia - DF, 70297-400, Brasil', N'Telefones
        PLANT�O - 3207-6331
        PLANT�O - 3207-6352
        . SAA (SE��O DE APOIO ADMINISTRATIVO) - 3207-6332
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 01 - 3207-6340
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 01 - 3207-6375', 3, N'-15.8338639', N'-47.9332502')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (3, N'N�o', N'04� DP', NULL, N'�rea Especial - Guar� II Eq 23/25 - Guar�, Bras�lia - DF, 71050-190, Brasil', N'Telefones
        PLANT�O - 3207-6572
        PLANT�O - 3207-6622
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-6571
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 03 - 3207-6580
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 03 - 3207-6613', 10, N'-15.8322141', N'-47.9806349')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (4, N'N�o', N'10� DP', NULL, N'Casa 01 - SHIS QI 5 Conj. 18 - Lago Sul, Bras�lia - DF, 71615-180, Brasil', N'Telefones
        PLANT�O - 3207-6971
        PLANT�O - 3207-7016
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-6972', 0, N'-15.8486322', N'-47.90255459999999')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (5, N'Sim', N'05� DP', N'02� DP, 03� DP, 05� DP', N'Lote A - Sgan Q 901 - Asa Norte, Bras�lia - DF, 70040-000, Brasil', N'Telefones
        PLANT�O - 3207-6651
        PLANT�O - 3207-6688
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-6661', 0, N'-15.7869204', N'-47.8922249')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (6, N'N�o', N'02� DP', NULL, N'STN Quadra 916 Lote E - Asa Norte, Bras�lia - DF, 70620-000, Brasil', N'Telefones
        PLANT�O - 3207-6412
        PLANT�O - 3207-6434
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-6413', 0, N'-15.7348808', N'-47.9028797')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (7, N'N�o', N'03� DP', NULL, N'SRES AE 3, Lote 16 - Cruzeiro Velho, Bras�lia - DF, 70640-002, Brasil', N'Telefones
        PLANT�O - 3207-6546
        PLANT�O - 3207-6547
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-6473
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 02 - 3207-6545', 0, N'-15.78919404961569', N'-47.941313241768285')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (8, N'Sim', N'06� DP', N'09� DP', N'AE Q. 33 Lote 04 - Parano�, Bras�lia - DF, 71570-330, Brasil', N'Telefones
        PLANT�O - 3207-6731
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 07 - 3207-6730
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 07 - 3207-6775', 0, N'-15.7609294', N'-47.7820191')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (9, N'N�o', N'09� DP', NULL, N'Pol�cia Civil Lago Norte - SHIN QI 5 - Lago Norte, Bras�lia - DF, 71505-200, Brasil', N'Telefones
        PLANT�O - 3207-6891
        PLANT�O - 3207-6900
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-6897', 0, N'-15.7320305', N'-47.86495960000001')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (10, N'Sim', N'08� DP', N'38� DP e 08� DP', N'Q 8, SCIA - Asa Norte Q 8 - Guar�, Bras�lia - DF, 70770-010, Brasil', N'Telefones
        PLANT�O - 3207-6811
        PLANT�O - 3207-6851
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-6812
        Cart�rio - 3207-6816', 0, N'-15.7837017', N'-47.9881405')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (11, N'N�o', N'38� DP', NULL, N'Rua 4A travessa 5 bloco 4 modulo 18 Ao lado da Administra��o de Vicente Pires - St. Hab. Vicente Pires - Taguatinga, Bras�lia - DF, 72006-212, Brasil', N'Telefones
        PLANT�O - 3207-8731
        PLANT�O - 3207-8802
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8732', 0, N'-15.8148362', N'-48.0148805')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (12, N'Sim', N'12� DP', N'12� DP e 17� DP', N'C 03, �rea Especial, Taguatinga Centro - Taguatinga, Bras�lia - DF, 72010-020, Brasil', N'Telefones
        PLANT�O - 3207-7131
        PLANT�O - 3207-7167
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7132', 0, N'-15.8313859', N'-48.0544688')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (13, N'N�o', N'17� DP', NULL, N'QNG 39, Lote 01 - Taguatinga Norte - Taguatinga, Bras�lia - DF, 72130-003, Brasil', N'Telefones
        PLANT�O - 3207-7531
        PLANT�O - 3207-7550
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7532', 0, N'-15.8037151', N'-48.0714145')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (14, N'Sim', N'13� DP', N'13� DP e 35� DP', N'Rua 2 - Setor Administrativo e Cultural Quadra Central Lote M (Delegacia / McDonald''s) - Sobradinho, Bras�lia - DF, 70297-400, Brasil', N'Telefones
        PLANT�O - 3207-7211
        PLANT�O - 3207-7263', 0, N'-15.653345625758218', N'-47.79459959259034')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (15, N'N�o', N'35� DP', NULL, N'Lote 07 - Ar 5 Conjunto 11 - Sobradinho II, Bras�lia - DF, 73060-511, Brasil', N'Telefones
        PLANT�O - 3207-8651
        PLANT�O - 3207-8660
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8655', 0, N'-15.6414047', N'-47.8268663')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (16, N'Sim', N'15� DP', N'15� DP, 19� DP, 23� DP e 24� DP', N'QNM 02, AE, Conjunto G/H -Ceil�ndia/DF - CEP: 72.210 - Ceil�ndia, Bras�lia - DF, 72210-515, Brasil', N'Telefones
        PLANT�O - 3207-7371
        PLANT�O - 3207-7418
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7374', 0, N'-15.815391147882284', N'-48.1060777803566')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (17, N'N�o', N'19� DP', NULL, N'Eqnp 15/19 Bloco E Lote 2 - Ceil�ndia, Bras�lia - DF, 72241-565, Brasil', N'Telefones
        PLANT�O - 3207- 7691
        PLANT�O  - 3207-7712
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7692', 0, N'-15.808386417417422', N'-48.13405721286277')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (18, N'N�o', N'23� DP', NULL, N'50 - St. P EQNP 30/34 - Ceil�ndia, Bras�lia - DF, 72236-505, Brasil', N'Telefones
        PLANT�O - 3207-7970
        PLANT�O - 3207-7980
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7932', 0, N'-15.848585738183239', N'-48.116337218385326')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (19, N'N�o', N'24� DP', NULL, N'St. O EQNO 10/12 Lote E - Ceil�ndia, Bras�lia - DF, 72255-170, Brasil', N'Telefones
        PLANT�O - 3207-8011
        PLANT�O - 3207-8045
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8013', 0, N'-15.7946751', N'-48.132282')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (20, N'Sim', N'16� DP', N'16� DP e 31� DP', N'St. Comercial Central - Sobradinho, Bras�lia - DF, 70297-400, Brasil', N'Telefones
        PLANT�O - 3207-7451
        PLANT�O - 3207-7472
        PLANT�O - 3207-7473
        PLANT�O - 3207-7475
        PLANT�O - 3207-7479
        PLANT�O - 3207-7504
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7452
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 04 - 3207-8422', 0, N'-15.6510655', N'-47.7900594')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (21, N'N�o', N'31� DP', NULL, N'0 - St. Res. Leste | Burit�s IV - St. Res. Leste, Planaltina, Bras�lia - DF, 73357-000, Brasil', N'Telefones
        PLANT�O - 3207-8411
        PLANT�O - 3207-8433
        PLANT�O - 3207-8465
        PLANT�O - 3207-8466
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8412', 0, N'-15.616726137883154', N'-47.635412467459105')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (22, N'Sim', N'18� DP', N'18� DP', N'Via SN3 - Setor Norte Quadra 4 Lote 178 - Brazl�ndia, Bras�lia - DF, Brasil', N'Telefones
        PLANT�O - 3207-7632
        PLANT�O - 3207-7643
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7657
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 10 - 3207-7619', 0, N'-15.680445459105353', N'-48.19071897731552')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (23, N'Sim', N'20� DP', N'14� DP, 20� DP e 33� DP', N'72 - St. Oeste - Gama, Bras�lia - DF, 70297-400, Brasil', N'Telefones
        PLANT�O - 3207-7790
        PLANT�O - 3207-7771
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7772', 0, N'-16.00958463750069', N'-48.07666746693421')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (24, N'N�o', N'14� DP', NULL, N'Via SCN - SCE, Com�rcio Central (14� DP) - Gama, Bras�lia - DF, Brasil', N'Telefones
        PLANT�O - 3207-7291
        PLANT�O - 3207-7315
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7292', 0, N'-16.01717174930355', N'-48.06547861901436')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (25, N'N�o', N'33� DP', NULL, N'Cl 114, s/n - Santa Maria, Bras�lia - DF, Brasil', N'Telefones
        PLANT�O - 3207-8571
        PLANT�O - 3207-8590
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8572
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 06 - 3207-8599
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 06 - 3207-8619', 0, N'-16.006779828810142', N'-48.002240002238445')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (26, N'Sim', N'21� DP', N'11� DP e 21� DP', N'Lotes 09/10 - Qs 9 Rua 123, 9 - Taguatinga, Bras�lia - DF, 70297-400, Brasil', N'Telefones
        PLANT�O - 3207-7851
        PLANT�O - 3207-7904
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7852', 0, N'-15.873640388410658', N'-48.0277546095398')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (27, N'N�o', N'11� DP', NULL, N'Pra�a Central 3� Avenida Avenida Cont�rno Ae 3 Bl 625, s/n - N�cleo Bandeirante, Bras�lia - DF, 71700-000, Brasil', N'Telefones
        PLANT�O - 3207-7051
        PLANT�O - 3207-7094
        PLANT�O - 3207-7075
        PLANT�O - 3207-7095
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-7052', 0, N'-15.8702374', N'-47.9672113')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (28, N'Sim', N'26� DP', N'26� DP e 32� DP', N'0 - QS 411 - Samambaia Norte (Samambaia), Bras�lia - DF, 72321-556, Brasil', N'Telefones
        PLANT�O - 3207-8091
        PLANT�O - 3207-8158
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8092', 0, N'-15.879588740447739', N'-48.10690380657235')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (29, N'N�o', N'32� DP', NULL, N'Lote 01 - Samambaia Sul, Bras�lia - DF, 71690-000, Brasil', N'Telefones
        PLANT�O - 3207-8491
        PLANT�O - 3207-8500
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8553
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 05 - 3207-8499
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 05 - 3207-8518', 0, N'-15.8754401', N'-48.0759364')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (30, N'Sim', N'27� DP', N'27� DP e 29� DP', N'quadra 301, �rea especial 2, Ema Recanto das - Recanto das Emas, Bras�lia - DF, 72602-216, Brasil', N'Telefones
        PLANT�O - 3207-8220
        PLANT�O - 3207-8171
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 09 - 3207-8179
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 09 - 3207-8195
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8172', 0, N'-15.9135527', N'-48.0965181')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (31, N'N�o', N'29� DP', NULL, N'Condom�nio da Qsb 02 �rea Especial 5/6 Setor B Sul - QS 6/12 - Riacho Fundo I, Bras�lia - DF, 71800-000, Brasil', N'Telefones
        PLANT�O - 3207-8251
        PLANT�O - 3207-8272
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8252', 0, N'-15.8866299', N'-48.0183517')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (32, N'Sim', N'30� DP', N'30� DP', N'Av. Comercial, Lote 01 - Quadra 02 - Conjunto 02 - S�o Sebasti�o, Bras�lia - DF, 71697-043, Brasil', N'Telefones
        PLANT�O - 3207-8331
        PLANT�O - 3207-8401
        PLANT�O - 3207-8402
        PLANT�O - 3207-8405
        PLANT�O - 3207-8406
        . SAAEI (SERVI�O DE APOIO ADMINISTRATIVO, ESTAT�STICA E INFORM�TICA) - 3207-8332
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 08 - 3207-8369
        . POSTO DE IDENTIFICA��O BIOM�TRICA N� 08 - 3207-8373', 0, N'-15.8953237', N'-47.77790479999999')
        GO
        SET IDENTITY_INSERT [dbo].[DepartamentoPolicia] OFF
        GO
        ");
    }

    public override void Down()
    {
      
    }
  }
}
