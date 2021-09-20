using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Setea el valor del atributo numero
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor con un parametro de tipo double
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor con un parametro de tipo string
        /// </summary>
        /// <param name="numero"></param>
        public Operando(string numero)
        {
            this.Numero = numero;

        }

        //CONVERSORES

        /// <summary>
        /// Valida que el string pasado como parametro sea un numero binario
        /// </summary>
        /// <param name="binario"></param> tipo string, contiene el valor a validar
        /// <returns></returns> Retorna true si es un numero binario
        private static bool EsBinario(string binario)
        {
            bool esBinario = true;

            foreach (char i in binario)
            {
                if (i != '0' && i != '1')
                {
                    esBinario = false;
                    break;
                }
            }
            return esBinario;
        }

        /// <summary>
        ///  Si numero es un decimal lo convierte a binario. 
        /// </summary>
        /// <param name="numero"></param> tipo double, valor a convertir en binario 
        /// <returns></returns> Devuelve el numero convertido en binario, si es posible
        public string DecimalBinario(double numero)
        {
            string binarioResultado = string.Empty;

            int numAConvertir = (int)Math.Abs(numero);

            if (numAConvertir == 0)
            {
                binarioResultado = "0";
            }

            while (numAConvertir > 0)
            {
                binarioResultado = (int)numAConvertir % 2 + binarioResultado;
                numAConvertir = (int)numAConvertir / 2;
            }

            return binarioResultado;
        }

        /// <summary>
        /// Si el string numero es un decimal decimal, lo convierte a binario. 
        /// </summary>
        /// <param name="numero"></param> tipo string, valor a convertir a binario 
        /// <returns></returns>Devuelve el numero convertido a binario si es posible
        public string DecimalBinario(string numero)
        {
            string retorno;
            if (Double.TryParse(numero, out double numDecimal))
            {
                retorno = DecimalBinario(numDecimal);
            }else
            {
                retorno = "Valor Invalido";
            }

            return retorno;
        }

        /// <summary>
        /// Si el string numero es un numero binario, lo convierte a decimal 
        /// </summary>
        /// <param name="binario"></param> tipo string, valor a convertir a decimal
        /// <returns></returns> Devuelve el numero convertido a decimal si es posible
        public string BinarioDecimal(string binario)
        {
            int intResultado = 0;
            char[] charNumero = binario.ToCharArray();
            Array.Reverse(charNumero);
            string strResultadoTerminado;

            if (EsBinario(binario))
            {
                for (int i = 0; i < charNumero.Length; i++)
                {
                    if (charNumero[i] == '1')
                    {
                        intResultado += (int)Math.Pow(2, i);
                    }
                }
                strResultadoTerminado = intResultado.ToString();
            }
            else
            {
                strResultadoTerminado = "Valor inválido";
            }

            return strResultadoTerminado;
        }
        //SOBRECARGAS
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="n1"></param> primer operando
        /// <param name="n2"></param> segundo operando
        /// <returns></returns> devuelve el valor de la sobracarga
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="n1"></param>primer operando
        /// <param name="n2"></param>segundo operando
        /// <returns></returns>devuelve el valor de la sobracarga
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador /
        /// </summary>
        /// <param name="n1"></param>primer operando
        /// <param name="n2"></param>segundo operando
        /// <returns></returns>devuelve el valor de la sobracarga
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        /// <summary>
        /// Sobrecarga del operador *
        /// </summary>
        /// <param name="n1"></param>primer operando
        /// <param name="n2"></param>segundo operando
        /// <returns></returns>devuelve el valor de la sobracarga
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        //VALIDACIONES

        /// <summary>
        /// Comprueba que el valor recibido como parametro sea numerico, si es asi, lo retorna como double. 
        /// </summary>
        /// <param name="strNumero"></param> numero a comprobar
        /// <returns></returns> Devuelve el numero en double si es numerico
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            double var;

            if (double.TryParse(strNumero.Replace(".", ","), out var))
            {
                retorno = var;
            }
            return retorno;
        }
    }
}
