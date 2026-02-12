using GenerarPDFUP.Models;
using GenerarPDFUP.Services;
using Microsoft.VisualBasic;

Encargado en = new Encargado 
{ 
    NombreEncargado = "Juan", 
    CedulaEncargado="32432",
    Parentesco="Padre", 
    TelefonoEncargado="2344",
    LugarTrabajo="ICE"
};

Estudiante es = new Estudiante
{
    NombreEstudiante = "Ilian",
    CedulaEstudiante = "2343",
    FechaNacimiento = "29/08/2004",
    Direccion = "cariari",
    NivelEstudiante = "décimo",
    AdecuacionEstudiante = "No",
    EnfermedadEstudiante = "No",
    TratamientoEstudiante = "No",
    Beca = "No",
    TipoBeca ="No",
    FechaMatricula="Hoy"
};

es.IdiomaElegido = "";
es.HorasTC = "";
es.AdecuacionAprobada = "";
es.NivelSeleccionado = "Secundaria";


//PlantillaNoExistente plantilla = new PlantillaNoExistente();
PlantillaExistente plantilla2 = new PlantillaExistente();
//plantilla.CrearFormulario("FormularioMatricula.pdf", es, en);
plantilla2.CrearFormulario("FormularioMatricula2.pdf", es, en, "true", "1000");




