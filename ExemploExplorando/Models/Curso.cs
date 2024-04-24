using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); //retorna tipo booleano por causa do método "Remove()" , passe o mouse em cima pra + informações
        }
        public void ListarAlunos()
        {
            for(int counter =0; counter<Alunos.Count; counter++)
            {
                Console.WriteLine($"Nº {counter + 1} - {Alunos[counter].NomeCompleto} :");
            }
        }

    }
}