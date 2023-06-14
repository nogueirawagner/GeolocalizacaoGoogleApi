namespace GestaoDDD.Infra.Data.Migrations
{
  using System.Data.Entity.Migrations;

  public partial class Adicionandovaloresembairros : DbMigration
  {
    public override void Up()
    {
      Sql(@"

			WITH Bairros AS (
			select 
				ID,
				(case
					when CHARINDEX('Asa Sul', Endereco) <> 0 then 'Asa Sul'
					when CHARINDEX('Guará', Endereco) <> 0 then 'Guará'
					when CHARINDEX('Lago Sul', Endereco) <> 0 then 'Lago Sul'
					when CHARINDEX('Asa Norte', Endereco) <> 0 then 'Asa Norte'
					when CHARINDEX('Cruzeiro', Endereco) <> 0 then 'Cruzeiro'
					when CHARINDEX('Paranoá', Endereco) <> 0 then 'Paranoá'
					when CHARINDEX('Lago Norte', Endereco) <> 0 then 'Lago Norte'
					when CHARINDEX('Vicente Pires', Endereco) <> 0 then 'Vicente Pires'
					when CHARINDEX('Taguatinga', Endereco) <> 0 then 'Taguatinga'
					when CHARINDEX('Sobradinho', Endereco) <> 0 then 'Sobradinho'
					when CHARINDEX('Sobradinho II', Endereco) <> 0 then 'Sobradinho II'
					when CHARINDEX('Ceilandia', Endereco) <> 0 then 'Ceilandia'
					when CHARINDEX('Planaltina', Endereco) <> 0 then 'Planaltina'
					when CHARINDEX('Brazlândia', Endereco) <> 0 then 'Brazlândia'
					when CHARINDEX('Gama', Endereco) <> 0 then 'Gama'
					when CHARINDEX('Santa Maria', Endereco) <> 0 then 'Santa Maria'
					when CHARINDEX('Núcleo Bandeirante', Endereco) <> 0 then 'Núcleo Bandeirante'
					when CHARINDEX('Samambaia', Endereco) <> 0 then 'Samambaia'
					when CHARINDEX('Recanto das Emas', Endereco) <> 0 then 'Recanto das Emas'
					when CHARINDEX('Riacho Fundo', Endereco) <> 0 then 'Riacho Fundo'
					when CHARINDEX('São Sebastião', Endereco) <> 0 then 'São Sebastião'

				end) Bairro
			from DepartamentoPolicia
			)

			update dp set dp.Bairro = b.Bairro from DepartamentoPolicia dp
			join Bairros b on b.ID = dp.ID");
    }

    public override void Down()
    {
    }
  }
}
