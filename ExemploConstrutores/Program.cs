using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            //1.CONSTRUTORES
            //1.1 CONSTRUTOR NA PRÁTICA
                /*
                Pessoa p1 = new Pessoa("Mariana", "Schmidt");
                p1.Apresentar();
                */


            //1.2 CONSTRUTOR PADRÃO (sem parâmetros)
                /*
                Pessoa p1 = new Pessoa();
                p1.Apresentar();
                */

            //1.3 CONSTRUTOR PRIVADO - quando se quer evitar instancia da classe (não consegue fazer instância do objeto) - Log.cs - classe que passa por vários lugares, se utiliza padrão de projeto chamado Singleton
                /*
                Log log = Log.GetInstance();

                log.PropriedadeLog = "Teste instancia";

                Log log2 = Log.GetInstance();
                System.Console.WriteLine(log2.PropriedadeLog);
                */


            //1.4 CHAMANDO O CONSTRUTOR DA HERANÇA
                /*
                Aluno p1 = new Aluno("Mariana", "Schmidt", "Construtores");
                p1.Apresentar();
                */


            //2.1 GET E SET
                /*
                Data data = new Data();
                data.SetMes(2);
                data.ApresentarMes();
                */

            //2.2 PROPRIEDADES
                /*
                Data data = new Data();
                //data.SetMes(2);

                data.Mes = 12; //12 é a variavel value, é o valor que esta sendo recebido pelo set
                //System.Console.WriteLine(data.Mes);

                data.ApresentarMes();
                */

            //3. MODIFICADORES
            //3.1 READONLY
            //3.2 CONSTANTE
                /*
                const double pi = 3.14;
                const double pi; //CONST DEVE TER VALOR NA INICIALIZAÇÃO               AO
                System.Console.WriteLine(pi);

                pi = 0; //CONST NAO PODE SER ALTERADA
                */
            
            //4. DELEGATE
                /*
                //Operacao op = Calculadora.Somar -> outra maneira de passar Delegate
                Operacao op = new Operacao(Calculadora.Somar);
                op.Invoke(10, 10);

                //op(10, 10); -> outra opção de invocar
                */

            //4.1 MULTI CAST DELEGATE - ordem First In First Out
                /*
                Operacao op = new Operacao(Calculadora.Somar);
                op += Calculadora.Subtrair; //+= -> adiciona um método sem perder a referencia do método original
                op.Invoke(10, 10);
                */

            //5. EVENTOS
                Matematica m = new Matematica(10, 20);
                m.Somar();

        }
    }
}
