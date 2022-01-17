namespace ExemploConstrutores.Models
{
    public class Data
    {

        //2.1 GET E SET

        /*private int mes; //private para que nao possa ser modificada
        private bool mesValido;
        public int GetMes()
        {
            return this.mes;
        }

        //unica maneira de alterar a variavel mes é pelo SetMes
        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mês inválido");
            }
        }*/


        //2.2 PROPRIEDADES

        //CRIANDO PARAMETROS GET E SET (nao é o mais recomendavel, é melhor colocar parametros no GET E SET, como mostrado abaixo)
        private int mes; //private para que nao possa ser modificada
        private bool mesValido;
        public int GetMes()
        {
            return this.mes;
        }

        //unica maneira de alterar a variavel mes é pelo SetMes
        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        //COLOCANDO PARAMETROS EM GET(ACESSAR VALOR) E SET(ATRIBUIR VALOR):
            public int Mes 
            { 
                get
                {
                    return this.mes;
                }
                set
                {
                    if (value > 0 && value <= 12)
                    {
                        this.mes = value;
                        this.mesValido = true;
                    }
                }
            }

        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mês inválido");
            }
        }
        
    }
}