using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementandoClasses
{
    class Aluno
    {
        private string nome;
        private int idade;
        //metodo chamado ao instanciar a classe
        //construtor
        public Aluno()
        {
            Console.WriteLine("contrutur Aluno");
        }

        //construtor com parametros
        public Aluno(string _nome, int _idade)
        {
            //this modificador que acessa os elementos da proria classe
            this.nome = _nome;
            this.idade = _idade;
        }

        public string Nome
        {
            get { return nome; }   //retorna os valores
            set { nome = value; }  //seta os valores para o field  
        }

        public int Idade { get; set; } // modo reduzido, quando usado o valor fica armazenado na property
                                       // e não no field
        public int GetTwiceIdade()
        {
            //o dobro da property
            int twice = this.Idade * 2;
            return twice;
        }

        public string GetNome()
        {
            //retorna o valor do field
            return this.nome;
        }
        public bool Major(int _idade) 
        {
            /*bool major = false;

            if (_idade >= 18)
                major = true;
            else
                major = false;
            */

            bool major = (idade >= 18) ? false : true;

            return major;
        }

        //metodo que limpa os fields
        //o modificador public define o acesso do metodo
        public void Limpar()
        {
            this.nome = string.Empty;
            this.idade = 0;
        }

        //metodo privado que só pode ser acessado dentro da propia classe
        private void GoAge()
        {
            this.idade = 21;
        }

        ~Aluno()
        {
            //metodo que destroi a classe
            //chamado quando a classe nao é mais referenciada
            //no programa
            Console.WriteLine("Destrutur Aluno");
            Console.ReadKey();
        }
    }
}
