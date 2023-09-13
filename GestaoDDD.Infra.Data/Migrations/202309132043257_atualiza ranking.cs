namespace GestaoDDD.Infra.Data.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class atualizaranking : DbMigration
  {
    public override void Up()
    {
      Sql(@"
          WITH AtualizarRank AS (

              select 
              ID, Nome, NotaEtapa1, NotaEtapa2, NotaFinal,
              ROW_NUMBER ( )   
                  OVER ( order by NotaFinal desc )  Posicao

              from Aluno where Cargo = 'Agente'
              and Concorrencia = 'SJN'
              )

              update a set a.Posicao = ar.Posicao from Aluno a
              join AtualizarRank ar on ar.ID = a.ID");

      Sql(@"
          WITH AtualizarRank AS (

              select 
              ID, Nome, NotaEtapa1, NotaEtapa2, NotaFinal,
              ROW_NUMBER ( )   
                  OVER ( order by NotaFinal desc )  Posicao

              from Aluno where Cargo = 'Agente'
              and Concorrencia = 'Negros'
              )

              update a set a.Posicao = ar.Posicao from Aluno a
              join AtualizarRank ar on ar.ID = a.ID");

      Sql(@"
          WITH AtualizarRank AS (

              select 
              ID, Nome, NotaEtapa1, NotaEtapa2, NotaFinal,
              ROW_NUMBER ( )   
                  OVER ( order by NotaFinal desc )  Posicao

              from Aluno where Cargo = 'Agente'
              and Concorrencia = 'Ampla'
              )

              update a set a.Posicao = ar.Posicao from Aluno a
              join AtualizarRank ar on ar.ID = a.ID");

      Sql(@"
          WITH AtualizarRank AS (

              select 
              ID, Nome, NotaEtapa1, NotaEtapa2, NotaFinal,
              ROW_NUMBER ( )   
                  OVER ( order by NotaFinal desc )  Posicao

              from Aluno where Cargo = 'Agente'
              and Concorrencia = 'PCD'
              )

              update a set a.Posicao = ar.Posicao from Aluno a
              join AtualizarRank ar on ar.ID = a.ID");

      Sql(@"
          WITH AtualizarRank AS (

              select 
              ID, Nome, NotaEtapa1, NotaEtapa2, NotaFinal,
              ROW_NUMBER ( )   
                  OVER ( order by NotaFinal desc )  Posicao

              from Aluno where Cargo = 'Agente'
              and Concorrencia = 'SJA'
              )

              update a set a.Posicao = ar.Posicao from Aluno a
              join AtualizarRank ar on ar.ID = a.ID");

      Sql(@"
          WITH AtualizarRank AS (

              select 
              ID, Nome, NotaEtapa1, NotaEtapa2, NotaFinal,
              ROW_NUMBER ( )   
                  OVER ( order by NotaFinal desc )  Posicao

              from Aluno where Cargo = 'Agente'
              and Concorrencia = 'SJN'
              )

              update a set a.Posicao = ar.Posicao from Aluno a
              join AtualizarRank ar on ar.ID = a.ID");
    }

    public override void Down()
    {
    }
  }
}
