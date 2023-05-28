﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDDD.Domain.Entities
{
  public class Aluno
  {
    public int ID { get; set; }

    public string Inscricao { get; set; }

    public string Nome { get; set; }
    public string Concorrencia { get; set; }
    public float NotaEtapa1 { get; set; }
    public float NotaEtapa2 { get; set; }
    public float NotaSAT { get; set; }
    public float NotaTIPDPP { get; set; }
    
    [NotMapped]
    public int Posicao { get; set; }
  }
}