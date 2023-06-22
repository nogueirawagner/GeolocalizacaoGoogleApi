namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class atualizandopontuacao : DbMigration
  {
    public override void Up()
    {
      Sql(@"
        update DepartamentoPolicia set Pontuacao = 33 where ID = 8
        update DepartamentoPolicia set Pontuacao = 32 where ID = 30
        update DepartamentoPolicia set Pontuacao = 29 where ID = 32
        update DepartamentoPolicia set Pontuacao = 29 where ID = 20
        update DepartamentoPolicia set Pontuacao = 27 where ID = 14
        update DepartamentoPolicia set Pontuacao = 27 where ID = 26
        update DepartamentoPolicia set Pontuacao = 26 where ID = 2
        update DepartamentoPolicia set Pontuacao = 26 where ID = 28
        update DepartamentoPolicia set Pontuacao = 26 where ID = 12
        update DepartamentoPolicia set Pontuacao = 25 where ID = 5
        update DepartamentoPolicia set Pontuacao = 24 where ID = 16
        update DepartamentoPolicia set Pontuacao = 23 where ID = 22
        update DepartamentoPolicia set Pontuacao = 24 where ID = 23
        update DepartamentoPolicia set Pontuacao = 22 where ID = 10
        update DepartamentoPolicia set Pontuacao = 21 where ID = 25
        update DepartamentoPolicia set Pontuacao = 21 where ID = 13
        update DepartamentoPolicia set Pontuacao = 18 where ID = 18
        update DepartamentoPolicia set Pontuacao = 19 where ID = 29
        update DepartamentoPolicia set Pontuacao = 17 where ID = 17
        update DepartamentoPolicia set Pontuacao = 18 where ID = 24
        update DepartamentoPolicia set Pontuacao = 17 where ID = 31
        update DepartamentoPolicia set Pontuacao = 15 where ID = 3
        update DepartamentoPolicia set Pontuacao = 15 where ID = 21
        update DepartamentoPolicia set Pontuacao = 15 where ID = 19
        update DepartamentoPolicia set Pontuacao = 16 where ID = 15
        update DepartamentoPolicia set Pontuacao = 15 where ID = 6
        update DepartamentoPolicia set Pontuacao = 13 where ID = 27
        update DepartamentoPolicia set Pontuacao = 13 where ID = 11
        update DepartamentoPolicia set Pontuacao = 12 where ID = 7
        update DepartamentoPolicia set Pontuacao = 6 where ID = 9
        update DepartamentoPolicia set Pontuacao = 5 where ID = 4
      ");
    }

    public override void Down()
    {
    }
  }
}
