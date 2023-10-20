using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.ClassesEMetodos
{
    //Interface é como se fosse um contrato e quem assinar terá q utilizar esse membro em específico
    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    //Quando eu falo para o código q "coordenada: ponto" cordenada se torna obrigado a usar o membro da interface do ponto
    //A structure é identica a uma classe pois tem parâmetros, atributos, métodos construtores a não ser pelo
    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta)
        {
            //forma de adição sem mudar o valor do delta apenas adicionando x e y a ele
            X += delta;
            Y += delta;

        }

        internal class StructExemplo
        {
            public static void Executar()
            {
                //sem precisar usar o operador new ele já da um valor inicial a coordenadaInicial
                Coordenada coordenadaInicial ;
                coordenadaInicial.X = 2;
                coordenadaInicial.Y = 2;

                Console.WriteLine("Coordenada Inicial:");
                Console.WriteLine("X = {0}", coordenadaInicial.X);
                Console.WriteLine("Y = {0}", coordenadaInicial.Y);

                //chamou o construtor passando o valor de (x: 8, y: 4) em forma de parametros nomeados
                var coordenadaFinal = new Coordenada(x: 8, y: 4);
                coordenadaFinal.MoverNaDiagonal(8);
                //chamou o método movernadiagonal da interface e atribuiu um valor padrão a delta
                Console.WriteLine("Coordenada Final:");
                Console.WriteLine("X = {0}", coordenadaFinal.X);
                Console.WriteLine("Y = {0}", coordenadaFinal.Y);
            }
        }
    }
}
