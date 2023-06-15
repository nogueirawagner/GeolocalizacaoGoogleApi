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
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (2, N'Sim', N'01ª DP', N'01ª DP; 04ª DP; 10ª DP', N'Setor Policial - Sul, s/n - Asa Sul, Brasília - DF, 70297-400, Brasil', N'Telefones
        PLANTÃO - 3207-6331
        PLANTÃO - 3207-6352
        . SAA (SEÇÃO DE APOIO ADMINISTRATIVO) - 3207-6332
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 01 - 3207-6340
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 01 - 3207-6375', 3, N'-15.8338639', N'-47.9332502')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (3, N'Não', N'04ª DP', NULL, N'Área Especial - Guará II Eq 23/25 - Guará, Brasília - DF, 71050-190, Brasil', N'Telefones
        PLANTÃO - 3207-6572
        PLANTÃO - 3207-6622
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-6571
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 03 - 3207-6580
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 03 - 3207-6613', 10, N'-15.8322141', N'-47.9806349')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (4, N'Não', N'10ª DP', NULL, N'Casa 01 - SHIS QI 5 Conj. 18 - Lago Sul, Brasília - DF, 71615-180, Brasil', N'Telefones
        PLANTÃO - 3207-6971
        PLANTÃO - 3207-7016
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-6972', 0, N'-15.8486322', N'-47.90255459999999')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (5, N'Sim', N'05ª DP', N'02ª DP, 03ª DP, 05ª DP', N'Lote A - Sgan Q 901 - Asa Norte, Brasília - DF, 70040-000, Brasil', N'Telefones
        PLANTÃO - 3207-6651
        PLANTÃO - 3207-6688
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-6661', 0, N'-15.7869204', N'-47.8922249')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (6, N'Não', N'02ª DP', NULL, N'STN Quadra 916 Lote E - Asa Norte, Brasília - DF, 70620-000, Brasil', N'Telefones
        PLANTÃO - 3207-6412
        PLANTÃO - 3207-6434
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-6413', 0, N'-15.7348808', N'-47.9028797')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (7, N'Não', N'03ª DP', NULL, N'SRES AE 3, Lote 16 - Cruzeiro Velho, Brasília - DF, 70640-002, Brasil', N'Telefones
        PLANTÃO - 3207-6546
        PLANTÃO - 3207-6547
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-6473
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 02 - 3207-6545', 0, N'-15.78919404961569', N'-47.941313241768285')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (8, N'Sim', N'06ª DP', N'09ª DP', N'AE Q. 33 Lote 04 - Paranoá, Brasília - DF, 71570-330, Brasil', N'Telefones
        PLANTÃO - 3207-6731
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 07 - 3207-6730
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 07 - 3207-6775', 0, N'-15.7609294', N'-47.7820191')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (9, N'Não', N'09ª DP', NULL, N'Polícia Civil Lago Norte - SHIN QI 5 - Lago Norte, Brasília - DF, 71505-200, Brasil', N'Telefones
        PLANTÃO - 3207-6891
        PLANTÃO - 3207-6900
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-6897', 0, N'-15.7320305', N'-47.86495960000001')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (10, N'Sim', N'08ª DP', N'38ª DP e 08ª DP', N'Q 8, SCIA - Asa Norte Q 8 - Guará, Brasília - DF, 70770-010, Brasil', N'Telefones
        PLANTÃO - 3207-6811
        PLANTÃO - 3207-6851
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-6812
        Cartório - 3207-6816', 0, N'-15.7837017', N'-47.9881405')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (11, N'Não', N'38ª DP', NULL, N'Rua 4A travessa 5 bloco 4 modulo 18 Ao lado da Administração de Vicente Pires - St. Hab. Vicente Pires - Taguatinga, Brasília - DF, 72006-212, Brasil', N'Telefones
        PLANTÃO - 3207-8731
        PLANTÃO - 3207-8802
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8732', 0, N'-15.8148362', N'-48.0148805')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (12, N'Sim', N'12ª DP', N'12ª DP e 17ª DP', N'C 03, Área Especial, Taguatinga Centro - Taguatinga, Brasília - DF, 72010-020, Brasil', N'Telefones
        PLANTÃO - 3207-7131
        PLANTÃO - 3207-7167
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7132', 0, N'-15.8313859', N'-48.0544688')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (13, N'Não', N'17ª DP', NULL, N'QNG 39, Lote 01 - Taguatinga Norte - Taguatinga, Brasília - DF, 72130-003, Brasil', N'Telefones
        PLANTÃO - 3207-7531
        PLANTÃO - 3207-7550
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7532', 0, N'-15.8037151', N'-48.0714145')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (14, N'Sim', N'13ª DP', N'13ª DP e 35ª DP', N'Rua 2 - Setor Administrativo e Cultural Quadra Central Lote M (Delegacia / McDonald''s) - Sobradinho, Brasília - DF, 70297-400, Brasil', N'Telefones
        PLANTÃO - 3207-7211
        PLANTÃO - 3207-7263', 0, N'-15.653345625758218', N'-47.79459959259034')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (15, N'Não', N'35ª DP', NULL, N'Lote 07 - Ar 5 Conjunto 11 - Sobradinho II, Brasília - DF, 73060-511, Brasil', N'Telefones
        PLANTÃO - 3207-8651
        PLANTÃO - 3207-8660
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8655', 0, N'-15.6414047', N'-47.8268663')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (16, N'Sim', N'15ª DP', N'15ª DP, 19ª DP, 23ª DP e 24ª DP', N'QNM 02, AE, Conjunto G/H -Ceilândia/DF - CEP: 72.210 - Ceilândia, Brasília - DF, 72210-515, Brasil', N'Telefones
        PLANTÃO - 3207-7371
        PLANTÃO - 3207-7418
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7374', 0, N'-15.815391147882284', N'-48.1060777803566')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (17, N'Não', N'19ª DP', NULL, N'Eqnp 15/19 Bloco E Lote 2 - Ceilândia, Brasília - DF, 72241-565, Brasil', N'Telefones
        PLANTÃO - 3207- 7691
        PLANTÃO  - 3207-7712
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7692', 0, N'-15.808386417417422', N'-48.13405721286277')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (18, N'Não', N'23ª DP', NULL, N'50 - St. P EQNP 30/34 - Ceilândia, Brasília - DF, 72236-505, Brasil', N'Telefones
        PLANTÃO - 3207-7970
        PLANTÃO - 3207-7980
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7932', 0, N'-15.848585738183239', N'-48.116337218385326')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (19, N'Não', N'24ª DP', NULL, N'St. O EQNO 10/12 Lote E - Ceilândia, Brasília - DF, 72255-170, Brasil', N'Telefones
        PLANTÃO - 3207-8011
        PLANTÃO - 3207-8045
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8013', 0, N'-15.7946751', N'-48.132282')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (20, N'Sim', N'16ª DP', N'16ª DP e 31ª DP', N'St. Comercial Central - Sobradinho, Brasília - DF, 70297-400, Brasil', N'Telefones
        PLANTÃO - 3207-7451
        PLANTÃO - 3207-7472
        PLANTÃO - 3207-7473
        PLANTÃO - 3207-7475
        PLANTÃO - 3207-7479
        PLANTÃO - 3207-7504
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7452
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 04 - 3207-8422', 0, N'-15.6510655', N'-47.7900594')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (21, N'Não', N'31ª DP', NULL, N'0 - St. Res. Leste | Buritís IV - St. Res. Leste, Planaltina, Brasília - DF, 73357-000, Brasil', N'Telefones
        PLANTÃO - 3207-8411
        PLANTÃO - 3207-8433
        PLANTÃO - 3207-8465
        PLANTÃO - 3207-8466
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8412', 0, N'-15.616726137883154', N'-47.635412467459105')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (22, N'Sim', N'18ª DP', N'18ª DP', N'Via SN3 - Setor Norte Quadra 4 Lote 178 - Brazlândia, Brasília - DF, Brasil', N'Telefones
        PLANTÃO - 3207-7632
        PLANTÃO - 3207-7643
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7657
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 10 - 3207-7619', 0, N'-15.680445459105353', N'-48.19071897731552')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (23, N'Sim', N'20ª DP', N'14ª DP, 20ª DP e 33ª DP', N'72 - St. Oeste - Gama, Brasília - DF, 70297-400, Brasil', N'Telefones
        PLANTÃO - 3207-7790
        PLANTÃO - 3207-7771
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7772', 0, N'-16.00958463750069', N'-48.07666746693421')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (24, N'Não', N'14ª DP', NULL, N'Via SCN - SCE, Comércio Central (14ª DP) - Gama, Brasília - DF, Brasil', N'Telefones
        PLANTÃO - 3207-7291
        PLANTÃO - 3207-7315
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7292', 0, N'-16.01717174930355', N'-48.06547861901436')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (25, N'Não', N'33ª DP', NULL, N'Cl 114, s/n - Santa Maria, Brasília - DF, Brasil', N'Telefones
        PLANTÃO - 3207-8571
        PLANTÃO - 3207-8590
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8572
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 06 - 3207-8599
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 06 - 3207-8619', 0, N'-16.006779828810142', N'-48.002240002238445')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (26, N'Sim', N'21ª DP', N'11ª DP e 21ª DP', N'Lotes 09/10 - Qs 9 Rua 123, 9 - Taguatinga, Brasília - DF, 70297-400, Brasil', N'Telefones
        PLANTÃO - 3207-7851
        PLANTÃO - 3207-7904
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7852', 0, N'-15.873640388410658', N'-48.0277546095398')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (27, N'Não', N'11ª DP', NULL, N'Praça Central 3ª Avenida Avenida Contôrno Ae 3 Bl 625, s/n - Núcleo Bandeirante, Brasília - DF, 71700-000, Brasil', N'Telefones
        PLANTÃO - 3207-7051
        PLANTÃO - 3207-7094
        PLANTÃO - 3207-7075
        PLANTÃO - 3207-7095
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-7052', 0, N'-15.8702374', N'-47.9672113')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (28, N'Sim', N'26ª DP', N'26ª DP e 32ª DP', N'0 - QS 411 - Samambaia Norte (Samambaia), Brasília - DF, 72321-556, Brasil', N'Telefones
        PLANTÃO - 3207-8091
        PLANTÃO - 3207-8158
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8092', 0, N'-15.879588740447739', N'-48.10690380657235')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (29, N'Não', N'32ª DP', NULL, N'Lote 01 - Samambaia Sul, Brasília - DF, 71690-000, Brasil', N'Telefones
        PLANTÃO - 3207-8491
        PLANTÃO - 3207-8500
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8553
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 05 - 3207-8499
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 05 - 3207-8518', 0, N'-15.8754401', N'-48.0759364')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (30, N'Sim', N'27ª DP', N'27ª DP e 29ª DP', N'quadra 301, área especial 2, Ema Recanto das - Recanto das Emas, Brasília - DF, 72602-216, Brasil', N'Telefones
        PLANTÃO - 3207-8220
        PLANTÃO - 3207-8171
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 09 - 3207-8179
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 09 - 3207-8195
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8172', 0, N'-15.9135527', N'-48.0965181')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (31, N'Não', N'29ª DP', NULL, N'Condomínio da Qsb 02 Área Especial 5/6 Setor B Sul - QS 6/12 - Riacho Fundo I, Brasília - DF, 71800-000, Brasil', N'Telefones
        PLANTÃO - 3207-8251
        PLANTÃO - 3207-8272
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8252', 0, N'-15.8866299', N'-48.0183517')
        GO
        INSERT [dbo].[DepartamentoPolicia] ([ID], [EhSede], [Nome], [AreaAtuacao], [Endereco], [Descricao], [Vagas], [Latitude], [Longitude]) VALUES (32, N'Sim', N'30ª DP', N'30ª DP', N'Av. Comercial, Lote 01 - Quadra 02 - Conjunto 02 - São Sebastião, Brasília - DF, 71697-043, Brasil', N'Telefones
        PLANTÃO - 3207-8331
        PLANTÃO - 3207-8401
        PLANTÃO - 3207-8402
        PLANTÃO - 3207-8405
        PLANTÃO - 3207-8406
        . SAAEI (SERVIÇO DE APOIO ADMINISTRATIVO, ESTATÍSTICA E INFORMÁTICA) - 3207-8332
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 08 - 3207-8369
        . POSTO DE IDENTIFICAÇÃO BIOMÉTRICA Nº 08 - 3207-8373', 0, N'-15.8953237', N'-47.77790479999999')
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
