using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCsharp.Excecoes
{
    public class Conta
    {
        double saldo;

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor > saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            saldo -= valor;
        }
    }

    internal class PrimeiraExcao
    {
        public static void Executar()
        {
            var conta = new Conta(8);

            try // o try tenta executar alguma ação, geralmente é usado quando algo pode dar erro por isso você tenta
            {
                conta.Sacar(1800);
                Console.WriteLine("Retirada com sucesso");
            }
            catch (Exception ex) //o catch pega a exeção q aconteceu e responde de forma generalizada com um mensagem do próprio console
            {
                Console.WriteLine(ex.Message);
            }
            finally // o finally aparece no console independentemente de executar o catch ou não.
            {
                Console.WriteLine("Obrigado");
            }

        }
    }
}
