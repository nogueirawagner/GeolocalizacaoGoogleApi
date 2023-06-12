namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class inserindorelacionamentodedelegaciaserisp : DbMigration
  {
    public override void Up()
    {
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(2, 1)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(5, 1)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(6, 1)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(7, 1)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(3, 1)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(10, 1)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(4, 1)");

      Sql("insert into DepartamentoRISP(DptoId, RispId) values(23, 2)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(24, 2)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(31, 2)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(27, 2)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(25, 2)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(30, 2)");

      Sql("insert into DepartamentoRISP(DptoId, RispId) values(12, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(11, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(13, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(26, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(16, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(17, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(18, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(19, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(22, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(28, 3)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(29, 3)");

      Sql("insert into DepartamentoRISP(DptoId, RispId) values(21, 4)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(9, 4)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(8, 4)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(32, 4)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(14, 4)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(15, 4)");
      Sql("insert into DepartamentoRISP(DptoId, RispId) values(20, 4)");
    }

    public override void Down()
    {
    }
  }
}
