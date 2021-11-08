using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Entidades.Clases;
namespace TestUnitarioChocolates
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AgregarTabletaTest()
        {
            CasaDeChocolate fabrica = new CasaDeChocolate("Prueba1");
            Tabletas tableta = new Tabletas(EClaseChocolate.Amargo,10,"Mamuschka",EAgregadoTableta.Almendra,ETipoTableta.Masizo);

            fabrica.AgregarLista(tableta);
            Assert.IsTrue(fabrica.ListaDeChocolates.Count > 0);
        }
        [TestMethod]
        public void AgregarBombonesTest()
        {
            CasaDeChocolate fabrica = new CasaDeChocolate("Prueba1");
            Bombones bombon = new Bombones(EClaseChocolate.Amargo, 10, "Mamuschka", EAgregadoBombones.Whisky, EFormaBombones.Redondo);

            fabrica.AgregarLista(bombon);
            Assert.IsTrue(fabrica.ListaDeChocolates.Count > 0);
        }
        [TestMethod]
        public void AgregarDosChocolatesIguales()
        {
            CasaDeChocolate fabrica = new CasaDeChocolate("Prueba2");
            Tabletas tableta1 = new Tabletas(EClaseChocolate.Amargo, 10, "Mamuschka", EAgregadoTableta.Almendra, ETipoTableta.Masizo);
            Tabletas tableta2 = new Tabletas(EClaseChocolate.Amargo, 10, "Mamuschka", EAgregadoTableta.Almendra, ETipoTableta.Masizo);
            
            fabrica.AgregarLista(tableta1);
            Assert.IsTrue(fabrica.AgregarLista(tableta2) == false);
        }
        [TestMethod]
        public void VerificarArchivo()
        {
            CasaDeChocolate fabrica = new CasaDeChocolate("Prueba3");
            bool retorno = CasaDeChocolate.Guardar(fabrica);

            Assert.IsTrue(retorno);
        }
    }
}
