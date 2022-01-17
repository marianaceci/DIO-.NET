namespace ExemploConstrutores.Models
{
    //CONSTRUTOR NA PRÁTICA
    /*public class Pessoa
    {
        private string nome;
        private string sobrenome;

        public Pessoa() //CTOR + tab //construtor sem parâmetros (construtor padrão)
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome) //construtor com parâmetros
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }*/

    //CONSTRUTOR PADRÃO
    /*public class Pessoa
    {
        private string nome;
        private string sobrenome;

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }*/

    //CONSTRUTOR PRIVADO - Log.cs


    //CHAMANDO O CONSTRUTOR DA HERANÇA
    /*public class Pessoa
    {
        private string nome;
        private string sobrenome;
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }
    }*/


    //3. MODIFICADORES
    //3.1 READONLY:

    /*public class Pessoa
    {
        private readonly string nome = "Mari"; //quando tem readonly, só pode ser alterado no construtor ou aqui na inicialização
        private readonly string sobrenome;

        public Pessoa() //CTOR + tab //construtor sem parâmetros (construtor padrão)
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            this.nome = "teste"; //SOMENTE LEITURA!!! NAO PODE SER ALTERADO AQUI
        }
    }*/

}