using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02.Models;

public abstract class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
}
