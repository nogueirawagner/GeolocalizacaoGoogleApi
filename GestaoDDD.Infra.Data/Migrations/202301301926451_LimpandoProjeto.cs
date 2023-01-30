namespace GestaoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LimpandoProjeto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Servico", "categoria_id", "dbo.Categoria");
            DropForeignKey("dbo.OrcamentoPrestador", "orcamento_id_fk", "dbo.Orcamento");
            DropForeignKey("dbo.OrcamentoPrestador", "prestador_id_fk", "dbo.Prestador");
            DropForeignKey("dbo.Prestador", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.ServicoPrestador", "pres_Id", "dbo.Prestador");
            DropForeignKey("dbo.ServicoPrestador", "serv_Id", "dbo.Servico");
            DropForeignKey("dbo.IndiqueProfissional", "Servico_serv_Id", "dbo.Servico");
            DropIndex("dbo.Servico", new[] { "categoria_id" });
            DropIndex("dbo.ServicoPrestador", new[] { "pres_Id" });
            DropIndex("dbo.ServicoPrestador", new[] { "serv_Id" });
            DropIndex("dbo.Prestador", new[] { "Id" });
            DropIndex("dbo.IndiqueProfissional", new[] { "Servico_serv_Id" });
            DropIndex("dbo.OrcamentoPrestador", new[] { "orcamento_id_fk" });
            DropIndex("dbo.OrcamentoPrestador", new[] { "prestador_id_fk" });
           
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrcamentoPrestador",
                c => new
                    {
                        orcamento_id_fk = c.Int(nullable: false),
                        prestador_id_fk = c.String(nullable: false, maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => new { t.orcamento_id_fk, t.prestador_id_fk });
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        usu_id = c.String(nullable: false, maxLength: 128, unicode: false),
                        pes_nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        pes_cpf = c.String(nullable: false, maxLength: 11, unicode: false),
                        pes_rg = c.String(maxLength: 9, unicode: false),
                        pes_endereco = c.String(maxLength: 200, unicode: false),
                        pes_numero = c.Int(nullable: false),
                        pes_bairro = c.String(maxLength: 100, unicode: false),
                        pes_cidade = c.String(maxLength: 100, unicode: false),
                        pes_cep = c.String(maxLength: 9, unicode: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.usu_id);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mensagem = c.String(maxLength: 500, unicode: false),
                        Controller = c.String(maxLength: 500, unicode: false),
                        View = c.String(maxLength: 500, unicode: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IndiqueProfissional",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome_profissional = c.String(nullable: false, maxLength: 256, unicode: false),
                        telefone = c.String(nullable: false, maxLength: 20, unicode: false),
                        email_empresa = c.String(maxLength: 128, unicode: false),
                        estado = c.Int(nullable: false),
                        cidade = c.String(nullable: false, maxLength: 128, unicode: false),
                        nome_solicitante = c.String(nullable: false, maxLength: 256, unicode: false),
                        email_solicitante = c.String(nullable: false, maxLength: 128, unicode: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                        Servico_serv_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        email = c.String(nullable: false, maxLength: 500, unicode: false),
                        telefone = c.String(nullable: false, maxLength: 500, unicode: false),
                        mensagem = c.String(nullable: false, maxLength: 500, unicode: false),
                        ctt_msg2 = c.String(maxLength: 500, unicode: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComoFunciona",
                c => new
                    {
                        cf_Id = c.Int(nullable: false, identity: true),
                        cf_Ordem = c.Int(nullable: false),
                        cf_Informacao = c.String(nullable: false, maxLength: 500, unicode: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.cf_Id);
            
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        codigo = c.Int(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                        data_alteracao = c.DateTime(nullable: false),
                        situacao = c.Boolean(nullable: false),
                        codigo_cidade = c.String(maxLength: 500, unicode: false),
                        nome_cidade = c.String(maxLength: 200, unicode: false),
                        codigo_uf = c.String(maxLength: 500, unicode: false),
                        uf = c.Int(nullable: false),
                        codigo_pais = c.String(maxLength: 500, unicode: false),
                        pais = c.String(maxLength: 500, unicode: false),
                        Mundo = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Email = c.String(nullable: false, maxLength: 256, unicode: false),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(maxLength: 500, unicode: false),
                        SecurityStamp = c.String(maxLength: 500, unicode: false),
                        PhoneNumber = c.String(maxLength: 500, unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orcamento",
                c => new
                    {
                        orc_Id = c.Int(nullable: false, identity: true),
                        descricao = c.String(nullable: false, maxLength: 500, unicode: false),
                        endereco = c.String(nullable: false, maxLength: 500, unicode: false),
                        prazo = c.String(nullable: false, maxLength: 500, unicode: false),
                        solicitante = c.String(nullable: false, maxLength: 200, unicode: false),
                        email_solicitante = c.String(nullable: false, maxLength: 200, unicode: false),
                        telefone_solicitante = c.String(nullable: false, maxLength: 500, unicode: false),
                        endereco_solicitante = c.String(maxLength: 200, unicode: false),
                        latitude = c.String(maxLength: 500, unicode: false),
                        servico_id = c.Int(nullable: false),
                        longitude = c.String(maxLength: 500, unicode: false),
                        cidade = c.String(maxLength: 500, unicode: false),
                        estado = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        distancia = c.String(maxLength: 500, unicode: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.orc_Id);
            
            CreateTable(
                "dbo.Prestador",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        cpf_cnpj = c.String(nullable: false, maxLength: 14, unicode: false),
                        endereco = c.String(maxLength: 200, unicode: false),
                        raio = c.String(maxLength: 500, unicode: false),
                        email = c.String(maxLength: 100, unicode: false),
                        telefone_fixo = c.String(maxLength: 14, unicode: false),
                        celular = c.String(maxLength: 14, unicode: false),
                        status = c.Int(nullable: false),
                        nome_empresa = c.String(maxLength: 500, unicode: false),
                        caminho_foto = c.String(maxLength: 500, unicode: false),
                        apresentacao_pessoal = c.String(maxLength: 500, unicode: false),
                        apresentacao_empresa = c.String(maxLength: 500, unicode: false),
                        latitude = c.String(maxLength: 500, unicode: false),
                        longitude = c.String(maxLength: 500, unicode: false),
                        cidade = c.String(maxLength: 500, unicode: false),
                        estado = c.Int(nullable: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServicoPrestador",
                c => new
                    {
                        serv_Pres_Id = c.Int(nullable: false, identity: true),
                        pres_Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        serv_Id = c.Int(nullable: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.serv_Pres_Id);
            
            CreateTable(
                "dbo.Servico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        categoria_id = c.Int(nullable: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 500, unicode: false),
                        data_alteracao = c.DateTime(nullable: false),
                        data_inclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.OrcamentoPrestador", "prestador_id_fk");
            CreateIndex("dbo.OrcamentoPrestador", "orcamento_id_fk");
            CreateIndex("dbo.IndiqueProfissional", "Servico_serv_Id");
            CreateIndex("dbo.Prestador", "Id");
            CreateIndex("dbo.ServicoPrestador", "serv_Id");
            CreateIndex("dbo.ServicoPrestador", "pres_Id");
            CreateIndex("dbo.Servico", "categoria_id");
            AddForeignKey("dbo.IndiqueProfissional", "Servico_serv_Id", "dbo.Servico", "Id");
            AddForeignKey("dbo.ServicoPrestador", "serv_Id", "dbo.Servico", "Id");
            AddForeignKey("dbo.ServicoPrestador", "pres_Id", "dbo.Prestador", "Id");
            AddForeignKey("dbo.Prestador", "Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.OrcamentoPrestador", "prestador_id_fk", "dbo.Prestador", "Id");
            AddForeignKey("dbo.OrcamentoPrestador", "orcamento_id_fk", "dbo.Orcamento", "orc_Id");
            AddForeignKey("dbo.Servico", "categoria_id", "dbo.Categoria", "Id");
        }
    }
}
