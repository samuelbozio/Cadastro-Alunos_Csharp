using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula1
{
    public class Aluno
    {
        
        private int Idade { get; set; }
        public string Nome { get; private set; }
        public int ID  { get;  set; }
        public double NotaFinal {get; set;}
    


    public Aluno (int idade, string nome, int id) {
        this.Nome = nome;   
        this.Idade = idade;
        this.ID = id;
        this.NotaFinal = 0;
      
    
    }



    }
}