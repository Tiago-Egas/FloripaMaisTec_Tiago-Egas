using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02.Models;

public class NotaDisciplina
{
    public int Id { get; set; }
    public decimal Nota { get; set; }
    public int DisciplinaId { get; set; }
    public Disciplina Disciplina { get; set; }
}
