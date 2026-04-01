using GenerarPDFUP.Data;
using GenerarPDFUP.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaUPGrafica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Creacion de coleccion de servicios
            var services = new ServiceCollection();

            //Configuración de la cadena de conexión
            services.AddDbContext<MatriculasContext>(options =>
            options.UseMySql(
              "Server=localhost;Database=BD_Unidad_Pedagogica_Sistema;User Id=root;Password=Ilian29*;",
              new MySqlServerVersion(new Version(8, 0, 21))
            ));

            //Agregar todos los servicios
            services.AddTransient<EstudianteService>();
            services.AddTransient<UsuarioService>();
            var provider= services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login(provider));

        }
    }
}