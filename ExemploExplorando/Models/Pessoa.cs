using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() //Construtor padrão vazio
        {            
        }
        public Pessoa(string nome, string sobrenome)  //Construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;            
        }
        
        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get => _nome.ToUpper(); //é o mesmo que,  get{return _nome.ToUpper();}  
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser/estar vazio:");
                }
                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); //Aqui não precisa do "SET", Mesmo que {get => "{Nome} {Sobrenome}";}
        public int Idade 
        {
            get => _idade;  //é o mesmo que,  get{return _idade;}
                       
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade não pode ser menor ou igual a 0:");
                }
                _idade=value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}