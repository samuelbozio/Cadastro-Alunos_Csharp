using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1
{
    public class Notas
    {

   private Cadastro cadastro;

   public Notas(Cadastro cadastro) {
    this.cadastro = cadastro;
   }
        public void cadastrarNotas(int id, double nota) {
            foreach (Aluno aluno in cadastro.listaAlunos ) {
                if (id  == aluno.ID) {
                    aluno.NotaFinal = nota;
                    Console.WriteLine("Nota cadastrada.");
                }
            }
        }
    }
}