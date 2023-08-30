using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1
{
    public struct Aluno
    {
        
        private int Idade { get; set; }
        public string Nome { get; private set; }
        public int ID  { get; private set; }
    


    public Aluno (int idade, string nome, int id) {
        this.Nome = nome;   
        this.Idade = idade;
        this.ID = id;
    }



    }
}