using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static string GramosTotalExt(this CasaDeChocolate fabrica, out double total)
        {
            double acumuladorChocolateLeche = 0;
            double acumuladorChocolateAmargo = 0;
            double acumuladorChocolateSemiamargo = 0;
            double acumuladorChocolateBlanco = 0;
            fabrica = CasaDeChocolate.GetFabrica("Milka");
            StringBuilder sb = new StringBuilder();

            foreach (Chocolate item in fabrica.ListaDeChocolates)
            {
                
                if(item.ClaseDeChocolate == EClaseChocolate.Leche)
                {
                    acumuladorChocolateLeche += item.Gramos * item.CantidadAProducir;
                }else
                {
                    if(item.ClaseDeChocolate == EClaseChocolate.Amargo)
                    {
                        acumuladorChocolateAmargo += item.Gramos * item.CantidadAProducir;
                    }else
                    {
                        if(item.ClaseDeChocolate == EClaseChocolate.Semiamargo)
                        {
                            acumuladorChocolateSemiamargo += item.Gramos * item.CantidadAProducir;
                        }else
                        {
                            if (item.ClaseDeChocolate == EClaseChocolate.Blanco)
                            {
                                acumuladorChocolateBlanco += item.Gramos * item.CantidadAProducir;
                            }
                        }
                    }

                }   
            }
            sb.AppendLine("GRAMOS DE CHOCOLATE DE LECHE TOTALES: ");
            sb.AppendLine(acumuladorChocolateLeche.ToString());
            sb.AppendLine("GRAMOS DE CHOCOLATE AMARGO TOTALES: ");
            sb.AppendLine(acumuladorChocolateAmargo.ToString());
            sb.AppendLine("GRAMOS DE CHOCOLATE SEMIAMARGO TOTALES: ");
            sb.AppendLine(acumuladorChocolateSemiamargo.ToString());
            sb.AppendLine("GRAMOS DE CHOCOLATE BLANCO TOTALES: ");
            sb.AppendLine(acumuladorChocolateBlanco.ToString());
            sb.AppendLine("GRAMOS TOTALES: ");
            total = acumuladorChocolateLeche + acumuladorChocolateAmargo + acumuladorChocolateSemiamargo + acumuladorChocolateBlanco;
            sb.AppendLine(total.ToString());
            return sb.ToString();
        }
    }
}
