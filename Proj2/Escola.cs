using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Proj2
{
    class Escola
    {
        public List<Turma> ListaTurma { get; set; } = new List<Turma>();
        public List<Professor> ListaProfessor { get; set; } = new List<Professor>();
        public List<Aluno> ListaAluno { get; set; } = new List<Aluno>();

    }
}