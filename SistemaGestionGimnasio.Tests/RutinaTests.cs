using Xunit;
using SistemaGestionGimnasio.Modelos;

namespace SistemaGestionGimnasio.Tests 
{
    public class RutinaTests 
    {
        [Fact]
        public void AgregarEjercicio_DebeAgregarALista() 
        {
            //Arrange

            Rutina rutina = new Rutina("Brazo", 120);
            Ejercicio ejercicio1 = new Ejercicio("Press",4,2,60);
            Ejercicio ejercicio2 = new Ejercicio("Fondo", 10, 3, 60);
            Ejercicio ejercicio3 = new Ejercicio("Lagartija", 15, 3, 60);

            //Act

            rutina.AgregarEjercicio(ejercicio1);
            rutina.AgregarEjercicio(ejercicio2);
            rutina.AgregarEjercicio(ejercicio3);

            //Assert

            Assert.Contains("Press", rutina.ObtenerEjercicios()[0].Nombre);
            Assert.NotEmpty(rutina.ObtenerEjercicios());

        }
    }
}
