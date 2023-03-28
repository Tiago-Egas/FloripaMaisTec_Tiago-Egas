using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02.Models;

public class Aluno : Pessoa
{
    public List<NotaDisciplina> Notas { get; set; }
}
