using System;
using Aula1;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Aluno aluno = new Aluno(18, "Samuel", 1032);
            Cadastro cadastro = new Cadastro();
            Notas notas = new Notas(cadastro);
            cadastro.cadastrar(aluno);
            notas.cadastrarNotas(1032, 10.0);
           
            cadastro.consultarAluno(1032);
            


        }
    }
}