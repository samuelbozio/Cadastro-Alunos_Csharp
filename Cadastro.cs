using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1
{
    public class Cadastro : InterfaceCadastro

    {

        public List<Aluno> listaAlunos {get; set;} = new List<Aluno>();
        public void cadastrar(Aluno aluno)
        {
            listaAlunos.Add(aluno);
            Console.WriteLine("Aluno" +aluno.Nome + "cadastrado");
        }


        public void consultarAluno(int id)
        {
            foreach (Aluno aluno in listaAlunos){
                if (id == aluno.ID) {
                    Console.WriteLine(aluno.Nome + ", "+  aluno.ID + ", " + aluno.NotaFinal);
                }
            }
        }

        public void removerAluno(int id)
        {
            foreach (Aluno aluno in listaAlunos) {
                if (id == aluno.ID) {
                    listaAlunos.Remove(aluno);
                }
            }
        }
    }
}