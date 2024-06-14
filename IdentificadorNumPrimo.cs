using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificadorDeNumeroPrimo
{
    internal class IdentificadorNumPrimo
    {
        public static void Main(string[] args) {
            // Inicialização e conversão de valor string para int -------------
            Console.Write("Digite o valor a ser verificado: ");
            int numero = int.Parse(Console.ReadLine());

            // Chamando método ------------------------------------------------
            bool ehPrimo = VerificarSeEhPrimo(numero);

            // Saída
            if(ehPrimo) {
                Console.WriteLine($"O numero {numero} é um valor primo");
            } else {
                Console.WriteLine($"O numero {numero} não é um valor primo");
            }

        }
        // Método de verificação ----------------------------------------------
        static bool VerificarSeEhPrimo(int numero) {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            var limite = (int)Math.Sqrt(numero);
            for (int i = 3; i < limite; i+= 2) {
                if (numero % i == 0) return false;
            }

            return true;
        }
    }
}


