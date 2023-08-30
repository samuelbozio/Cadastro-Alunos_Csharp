using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1
{
    public interface InterfaceCadastro
    {
        public  void cadastrar(Aluno aluno);
        public void consultarAluno(int id);
        public void removerAluno(int id);


    

    }
}