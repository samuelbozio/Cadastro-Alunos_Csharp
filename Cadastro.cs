using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1
{
    public class Cadastro : InterfaceCadastro

    {

        private List<Aluno> listaAlunos =  new List<Aluno>();
        public void cadastrar(Aluno aluno)
        {
            listaAlunos.Add(aluno);
            Console.WriteLine("Aluno" +aluno.Nome + "cadastrado");
        }

        public void consultarAluno(int id)
        {
            foreach (Aluno aluno in listaAlunos){
                if (id == aluno.ID) {
                    Console.WriteLine(aluno.Nome);
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