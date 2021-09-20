using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Clase estática Calculadora:
• El método ValidarOperador será privado y estático. Deberá validar que el operador
recibido sea +, -, / o *. Caso contrario retornará +.
• El método Operar será de clase: validará y realizará la operación pedida entre
ambos números.
 */
namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador y realiza la operacion entre los dos numeros de acuerdo a el operador del parametro
        /// </summary>
        /// <param name="num1"></param> primer operando
        /// <param name="num2"></param> segundo operando
        /// <param name="operador"></param> operador del calculo
        /// <returns></returns> Devuelve el resultado de la operacion
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;
      
            switch(ValidarOperador(operador))
            {
                case '+':
                   resultado = num1 + num2;
                   break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
                return resultado;
          
        }

        /// <summary>
        /// Comprueba que el operador recibido sea +,-,/,*, si no lo es retorna +
        /// </summary>
        /// <param name="operador"></param> operador elegido
        /// <returns></returns> Retorna el operador validado
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if (operador.Equals('-') || operador.Equals('*') || operador.Equals('/') || operador.Equals('+'))
            {
                retorno= operador;
            }        
                return retorno;
        }
    }
}
