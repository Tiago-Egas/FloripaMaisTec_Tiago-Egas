using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02.Controllers;
using Aula02.Models;

namespace Aula02.Repositories;

public class DisciplinaRepository
{
    private static List<Disciplina> lista = new List<Disciplina>()
    {
        new Disciplina
        {
            Id = 1,
            CargaHoraria = 20,
            Nome = "História"
        },
        new Disciplina
        {
            Id = 2,
            CargaHoraria = 10,
            Nome = "História do Brasil"
        },
        new Disciplina
        {
            Id = 3,
            CargaHoraria = 25,
            Nome = "História Geral"
        },
        new Disciplina
        {
            Id = 4,
            CargaHoraria = 20,
            Nome = "Matemática"
        }
    };

    public List<Disciplina> ListarDisciplinas(string filtroNome)
    {
        if (string.IsNullOrEmpty(filtroNome))
            return lista;
        else
            return lista.Where(x => x.Nome.Contains(filtroNome)).ToList();
    }

    public Disciplina ObterDisciplina(int id)
    {
        return lista.FirstOrDefault(x => x.Id == id);
    }

    public Disciplina AtualizarCargaHoraria(int id, DisciplinaDto dto)
    {
        var disciplina = ObterDisciplina(id);
        lista.Remove(disciplina);

        disciplina.CargaHoraria = dto.CargaHoraria;
        disciplina.Nome = dto.Nome;

        lista.Add(disciplina);

        return disciplina;
    }

    public Disciplina CriarDisciplina(DisciplinaDto dto)
    {
        var disciplina = new Disciplina();
        disciplina.Id = 
        disciplina.CargaHoraria = dto.CargaHoraria;
        disciplina.Nome = dto.NOme;
        disciplina.DataDaInclusao = DateTime.Now;
        disciplina.UsuarioInclusao = "USUARIO";

        lista.ADD(disciplina);

        return disciplina;
    }

    private int GerarId()
    {
        return 
    }
}
