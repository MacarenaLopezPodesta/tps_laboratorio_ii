using System;
using Entidades;
using Entidades.Clases;
using Entidades.Interfaces;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            CasaDeChocolate fabrica = new CasaDeChocolate("Arcor");

            Tabletas tableta1 = new Tabletas(EClaseChocolate.Amargo, 15, "cofler", EAgregadoTableta.Almendra, ETipoTableta.Aireado);
            Tabletas tableta2 = new Tabletas(EClaseChocolate.Amargo, 20, "cofler",  EAgregadoTableta.Almendra, ETipoTableta.Aireado);
            Tabletas tableta3 = new Tabletas(EClaseChocolate.Leche, 20, "cofler", EAgregadoTableta.Almendra, ETipoTableta.Aireado);

            Bombones bomb1 = new Bombones(EClaseChocolate.Blanco, 15, "cofler", EAgregadoBombones.Licor, EFormaBombones.Corazon);
            Bombones bomb2 = new Bombones(EClaseChocolate.Leche, 15, "cofler", EAgregadoBombones.Licor, EFormaBombones.Corazon);
            Bombones bomb3 = new Bombones(EClaseChocolate.Blanco, 15, "cofler", EAgregadoBombones.Licor, EFormaBombones.Corazon);

            //TEST DE METODO ==
            Console.WriteLine("TEST METODO ==");
            Console.WriteLine(bomb1 == bomb2);//false
            Console.WriteLine(bomb1 == bomb3);//true
            Console.WriteLine(tableta2 == bomb2);//false
            Console.WriteLine(tableta2 == tableta1);//true

            //TEST DE AGREGAR A LA LISTA
            Console.WriteLine("\nTEST AGREGAR A LA LISTA");
            Console.WriteLine(fabrica.AgregarLista(tableta1));//true
            Console.WriteLine(fabrica.AgregarLista(tableta2));//false
            Console.WriteLine(fabrica.AgregarLista(tableta3));//true
            Console.WriteLine(fabrica.AgregarLista(bomb1));//true
            Console.WriteLine(fabrica.AgregarLista(bomb2));//true
            Console.WriteLine(fabrica.AgregarLista(bomb3));//false

            //MOSTRAR TODA LA FABRICA
            Console.WriteLine("\nTEST MOSTRAR TODA LA FABRICA");
            Console.WriteLine(CasaDeChocolate.Mostrar(fabrica));
     

            Console.ReadKey();
        }
    }
}
