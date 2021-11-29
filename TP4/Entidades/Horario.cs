using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Horario
    {
        int hora;
        int minuto;
        int segundo;

        public delegate void CambioHorario(Horario horario);
        public event CambioHorario HorarioCambiado;

        /// <summary>
        /// Iniciara el cambio de horario
        /// </summary>
        public void Iniciar()
        {
            Task.Run(() =>
            {

                while (true)
                {

                    DateTime dt = DateTime.Now;
                    Thread.Sleep(10);


                    if (dt.Second != segundo)
                    {

                        if (HorarioCambiado is not null)
                        {
                            HorarioCambiado(this);
                        }
                    }
                    hora = dt.Hour;
                    minuto = dt.Minute;
                    segundo = dt.Second;
                }

            });



        }
        public override string ToString()
        {
            return $"{hora} : {minuto} : {segundo}";
        }
    }
}
