using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula01.Models;

namespace Aula01.Controllers;

[ApiController]
[Route("obter-alunos")]
public class AunoController : ControllerBase
{ 
    public IActionResult ObterAlunos()
    {
        var aluno = new Aluno();
        aluno.Id = 1;
        aluno.Nome = "João";
        aluno.DatadeNascimento = new DateTime(1990,08,14);

        return OK(aluno);
    }

    private IActionResult OK(Aluno aluno)
    {
        throw new NotImplementedException();
    }
}