using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GenerarPDFUP.Models;
using Microsoft.VisualBasic;

namespace GenerarPDFUP.Services
{
    public class PlantillaNoExistente
    {
        //Variables que nos ayudaran con el diseño
        private readonly Font fEtiqueta = new Font(Font.TIMES_ROMAN, 12, Font.BOLD);
        private readonly Font fValor = new Font(Font.TIMES_ROMAN, 12);
        private const float ALTURA_LINEA = 14f;
        private const float GRUESO_LINEA = 0.8f;
        //Variables que nos sirven para crear el documento e interactuar con él
        private Document documento;
        private PdfWriter writer;
        private FileStream fileStream;
        //Propiedad para separar textos en encargado
        public string[]? EnCasoEmergencia { get; set; }
        public string[]? TelofonoEmergencia { get; set; }
        //Método principal para crear la hoja de matricula
        public void CrearFormulario(string ruta, Estudiante es, Encargado en, CondicionSocioEconomica con)
        {
            InicializarDocumento(ruta);
            separarCasoEmergencia(en);
            separarTelefonoEmergencia(en);

            AgregarEncabezado();
            AgregarTitulo(es);
            AgregarCuerpo(es, en, con);
            AgregarPieDePagina();
            CerrarDocumento();
        }
        //Método que inicializa el documento
        private void InicializarDocumento(string ruta)
        {
            this.documento = new Document(PageSize.A4, 50, 50, 40, 40);
            this.fileStream = new FileStream(ruta, FileMode.Create);
            this.writer = PdfWriter.GetInstance(documento, fileStream);
            documento.Open();
        }

        //Método para generar el año en base al ordenador
        private string GenerarAño()
        {
            string fecha;
            fecha = DateAndTime.Year(DateAndTime.Now) + "";
            return fecha;
        }

        
        private void AgregarEncabezado()
        {
            PdfPTable encabezado = new PdfPTable(3);
            encabezado.WidthPercentage = 100;
            encabezado.SetWidths(new float[] { 25f, 55f, 20f });
            encabezado.AddCell(ObtenerCeldaImagen("MEPLogo.png", Element.ALIGN_LEFT, 180f, 60f));
            PdfPCell texto = new PdfPCell(new Phrase(
                "MINISTERIO DE EDUCACIÓN PÚBLICA\n" +
                "Unidad Pedagógica Río Cuba\n" +
                "Código Presupuestario 3360 / 5683\n" +
                "Tel. 2797 8265\n" +
                "Correo: upe.riocuba@mep.go.cr",
                new Font(Font.TIMES_ROMAN, 11, Font.BOLD)
            ));
            texto.HorizontalAlignment = Element.ALIGN_CENTER;
            texto.VerticalAlignment = Element.ALIGN_MIDDLE;
            texto.Border = Rectangle.NO_BORDER;
            encabezado.AddCell(texto);
            encabezado.AddCell(ObtenerCeldaImagen("UPLogo.png", Element.ALIGN_RIGHT, 80f, 80f));
            documento.Add(encabezado);
            documento.Add(new Paragraph("\n"));
        }

        //Método para agregar el titulo en el pdf
        private void AgregarTitulo(Estudiante es)
        {
            Paragraph titulo = new Paragraph($"Hoja De Matrícula\nCurso Lectivo: {GenerarAño()}\n\n",
                new Font(Font.TIMES_ROMAN, 11, Font.BOLD));
            
            AgregarNivelConChecks(es.NivelSeleccionado);
            titulo.Alignment = Element.ALIGN_CENTER;
           
            documento.Add(titulo);
        }
        //Método para agregar toda la información en el pdf 
        public void AgregarCuerpo(Estudiante es, Encargado en, CondicionSocioEconomica con)
        {

            

            PdfPTable tabla = new PdfPTable(2);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 35f, 65f });

            AgregarFilaConLinea(tabla, "Nivel:", es.NivelEstudiante);
            

            AgregarFilaConLinea(tabla, "Fecha de Matrícula:", es.FechaMatricula);
            AgregarFilaConLinea(tabla, "Nombre Completo del Estudiante:", es.NombreEstudiante);
            AgregarFilaConLinea(tabla, "Fecha de nacimiento:", es.FechaNacimiento);
            AgregarFilaConLinea(tabla, "Cédula:", es.CedulaEstudiante);
            AgregarFilaConLinea(tabla, "Dirección exacta del estudiante:", es.Direccion);


            AgregarFilaChecks(tabla, "Si cursa el nivel de 10° elija el idioma (10°):",
                ("Inglés", string.Equals(es.IdiomaElegido, "Inglés", StringComparison.OrdinalIgnoreCase)),
                ("Francés", string.Equals(es.IdiomaElegido, "Francés", StringComparison.OrdinalIgnoreCase))
            );


            AgregarFilaChecks(tabla, "Si cursa el nivel de 11° indique si ya realizó horas TC:",
                ("Sí", string.Equals(es.HorasTC + "", "true", StringComparison.OrdinalIgnoreCase)),
                ("No", string.Equals(es.HorasTC + "", "false", StringComparison.OrdinalIgnoreCase))
            );


            AgregarFilaChecks(tabla, "Cuenta con Adecuación Curricular Aprobada:",
                 ("Sí", string.Equals(es.AdecuacionAprobada + "", "true", StringComparison.OrdinalIgnoreCase)),
                 ("No", string.Equals(es.AdecuacionAprobada + "", "false", StringComparison.OrdinalIgnoreCase))
             );


            AgregarFilaConLinea(tabla, "¿Presenta alguna enfermedad?  Especifique:", es.EnfermedadEstudiante);
            AgregarFilaConLinea(tabla, "¿Tiene prescrito tratamiento médico?", es.TratamientoEstudiante);
            documento.Add(tabla);
            
            Paragraph tituloEncargado = new Paragraph
                ("Datos del Encargado Legal,Padre o Madre de Familia. \n\n",
                new Font(Font.TIMES_ROMAN, 11, Font.BOLD));

            tituloEncargado.Alignment = Element.ALIGN_CENTER;
            documento.Add(tituloEncargado);

            tabla.DeleteBodyRows();

            AgregarFilaConLinea(tabla, "Nombre del encargado legal que matricula:", en.NombreEncargado);
            AgregarFilaConLinea(tabla, "Cédula:", en.CedulaEncargado);
            AgregarFilaConLinea(tabla, "Parentesco estudiante:", en.Parentesco);
            AgregarFilaConLinea(tabla, "Teléfono:", en.TelefonoEncargado);
            AgregarFilaConLinea(tabla, "Lugar de trabajo:", en.LugarTrabajo);
            AgregarFilaConLinea(tabla, "Correo:", en.Correo);

            
            AgregarFilaDosLineas(tabla, "En caso de emergencia comunicarse con:", this.EnCasoEmergencia[0], this.EnCasoEmergencia[1]);
            AgregarFilaDosLineas(tabla, "Teléfono emergencia:", this.TelofonoEmergencia[0], this.TelofonoEmergencia[1]);

            documento.Add(tabla);
            AgregarInfoBeca(con);
            AgregarActaDeCompromiso(this.documento);
        }

        
        private void AgregarPieDePagina()
        { 
          documento.Add(new Paragraph("\nFirma del funcionario que hace la matrícula: ___________________________", new Font(Font.TIMES_ROMAN, 12)));
          
        }
        //Método que nos permite encontrar la imagen y darle diseño
        private PdfPCell ObtenerCeldaImagen(string nombreArchivo, int alineacion, float anchoMax, float altoMax)
        {
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            string rutaImagen = Path.Combine(rutaBase, nombreArchivo);
            PdfPCell celda;

            if (File.Exists(rutaImagen))
            {
                Image img = Image.GetInstance(rutaImagen);
                img.ScaleToFit(anchoMax, altoMax);
                celda = new PdfPCell(img)
                {
                    Border = Rectangle.NO_BORDER,
                    HorizontalAlignment = alineacion,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    Padding = 0
                };
            }
            else
            {
                celda = new PdfPCell(new Phrase("Imagen no encontrada", new Font(Font.HELVETICA, 8, Font.ITALIC)))
                {
                    Border = Rectangle.NO_BORDER,
                    HorizontalAlignment = Element.ALIGN_CENTER
                };
            }
            return celda;
        }

        //permite cerrar el documento y el flujo
        private void CerrarDocumento()
        {
            documento.Close();
            fileStream.Close();
        }

        
        //Celda con “línea” (borde inferior).
        private PdfPCell CeldaLinea(string texto = "", float altura = ALTURA_LINEA)
        {
            Phrase frase = new Phrase(texto ?? "", fValor);
            frase.Leading=12f; 

            var c = new PdfPCell(frase)
            {
                Border = Rectangle.BOTTOM_BORDER,
                BorderWidthBottom = GRUESO_LINEA,
                BorderWidthLeft = 0,
                BorderWidthRight = 0,
                BorderWidthTop = 0,

                
                PaddingTop = 0f,          
                PaddingBottom = 2f,       
                FixedHeight = 20f,        
                VerticalAlignment = Element.ALIGN_BOTTOM
            };

            if (string.IsNullOrWhiteSpace(texto))
                c.FixedHeight = altura;

            return c;
        }

        // Fila etiqueta y valor con línea 
        private void AgregarFilaConLinea(PdfPTable tabla, string etiqueta, string valor)
        {
            var celdaEtiqueta = new PdfPCell(new Phrase(etiqueta, fEtiqueta))
            {
                Border = Rectangle.NO_BORDER,
                PaddingTop = 0f,
                PaddingBottom = 2f,
                VerticalAlignment = Element.ALIGN_BOTTOM
            };

            var celdaValor = CeldaLinea(valor);
            celdaValor.PaddingTop = 0f;
            celdaValor.PaddingBottom = 2f;

            tabla.AddCell(celdaEtiqueta);
            tabla.AddCell(celdaValor);

     
            PdfPCell espacio = AgregarEspacio();
            tabla.AddCell(espacio);
        }

        
        private PdfPCell CeldaCheck(bool marcado)
        {
            var c = new PdfPCell(new Phrase(marcado ? "X" : " ", fValor))
            {
                Border = Rectangle.BOX,
                HorizontalAlignment = Element.ALIGN_CENTER,
                VerticalAlignment = Element.ALIGN_MIDDLE,
                FixedHeight = 12f,
                Padding = 0
            };
            return c;
        }

        // Grupo de checkboxes horizontales en la celda de valor.
        private void AgregarFilaChecks(PdfPTable tabla, string etiqueta, params (string Texto, bool Marcado)[] opciones)
        {
            // Etiqueta de la fila
            tabla.AddCell(new PdfPCell(new Phrase(etiqueta, fEtiqueta))
            {
                Border = Rectangle.NO_BORDER,
                PaddingBottom = 6f,
                VerticalAlignment = Element.ALIGN_MIDDLE
            });

            // Tabla interna para los checkboxes y sus textos
            int totalCols = opciones.Length * 2;
            PdfPTable inner = new PdfPTable(totalCols)
            {
                WidthPercentage = 100
            };

            
            float[] widths = new float[totalCols];
            for (int i = 0; i < totalCols; i++)
                widths[i] = (i % 2 == 0) ? 4f : 20f; 
            inner.SetWidths(widths);

            float checkSize = 16f; 

            foreach (var op in opciones)
            {
                // Cuadro del checkbox
                PdfPCell checkCell = CeldaCheck(op.Marcado);
                checkCell.FixedHeight = checkSize;
                checkCell.MinimumHeight = checkSize;
                checkCell.Padding = 0;
                checkCell.BorderWidth = 1f;
                checkCell.HorizontalAlignment = Element.ALIGN_CENTER;
                checkCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                inner.AddCell(checkCell);

                // Texto del checkbox
                PdfPCell textCell = new PdfPCell(new Phrase(" " + op.Texto, fValor))
                {
                    Border = Rectangle.NO_BORDER,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    PaddingLeft = 4f,
                    PaddingRight = 6f,
                    FixedHeight = checkSize
                };

                //  texto largo sin corte
                textCell.NoWrap = false;
                textCell.UseAscender = true;
                inner.AddCell(textCell);
            }

            // Evitar compresión
            inner.DefaultCell.FixedHeight = checkSize;

            // Contenedor principal
            PdfPCell container = new PdfPCell(inner)
            {
                Border = Rectangle.NO_BORDER,
                PaddingBottom = 8f,
                MinimumHeight = checkSize + 4f
            };

            tabla.AddCell(container);
        }



        private void AgregarFilaDosLineas(PdfPTable tabla, string etiqueta, string valor, string valor2)
        {
            var celdaValor = CeldaLinea(valor);
            celdaValor.PaddingTop = 0f;
            celdaValor.PaddingBottom = 2f;

            tabla.AddCell(new PdfPCell(new Phrase(etiqueta, fEtiqueta)) { Border = Rectangle.NO_BORDER });
            var inner = new PdfPTable(3) { WidthPercentage = 100 };
            inner.SetWidths(new float[] { 1f, 0.25f, 1f });
            inner.AddCell(celdaValor);

            celdaValor = CeldaLinea(valor2);
            inner.AddCell(new PdfPCell(new Phrase("")) { Border = Rectangle.NO_BORDER }); 
            inner.AddCell(celdaValor);

            tabla.AddCell(new PdfPCell(inner) { Border = Rectangle.NO_BORDER, PaddingBottom = 3f });
            PdfPCell espacio = AgregarEspacio();
            tabla.AddCell(espacio);

        }

       
        private void AgregarNivelConChecks(string nivelSeleccionado)
        {
            var t = new PdfPTable(6) { WidthPercentage = 70 }; 
            t.HorizontalAlignment = Element.ALIGN_CENTER;
            t.SetWidths(new float[] { 12f, 5f, 12f, 5f, 12f, 5f });

            t.AddCell(new PdfPCell(new Phrase($"Preescolar", fValor)) { Border = Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, PaddingRight = 6f });
            t.AddCell(CeldaCheck(nivelSeleccionado?.Equals("Preescolar", StringComparison.OrdinalIgnoreCase) == true));
            t.AddCell(new PdfPCell(new Phrase("Primaria", fValor)) { Border = Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, PaddingRight = 6f });
            t.AddCell(CeldaCheck(nivelSeleccionado?.Equals("Primaria", StringComparison.OrdinalIgnoreCase) == true));
            t.AddCell(new PdfPCell(new Phrase("Secundaria", fValor)) { Border = Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT, PaddingRight = 6f });
            t.AddCell(CeldaCheck(nivelSeleccionado?.Equals("Secundaria", StringComparison.OrdinalIgnoreCase) == true));

            documento.Add(t);
            documento.Add(new Paragraph("\n"));
        }

        private PdfPCell AgregarEspacio()
        {
            PdfPCell espacio = new PdfPCell(new Phrase("\n"))
            {
                Border = Rectangle.NO_BORDER,
                Colspan = 2,  
                FixedHeight = 5f 
            };
            return espacio;
        }

        private void AgregarInfoBeca(CondicionSocioEconomica condicionSocioEconomica)
        {
            AgregarEncabezado();
            Chunk subtituloSubrayado = new Chunk("Condición Socioeconómica", new Font(Font.TIMES_ROMAN, 12, Font.BOLD));
            subtituloSubrayado.SetUnderline(0.5f, -2f);
            documento.Add(new Paragraph(subtituloSubrayado));



            var tablaBeca = new PdfPTable(2) { WidthPercentage = 100 };
            tablaBeca.SetWidths(new float[] { 35f, 65f });
            
            AgregarFilaChecks(tablaBeca, "Tiene beca:",
                ("Sí", string.Equals(condicionSocioEconomica.TieneBeca + "", "true", StringComparison.OrdinalIgnoreCase)),
                ("No", string.Equals(condicionSocioEconomica.TieneBeca + "", "false", StringComparison.OrdinalIgnoreCase))
            );
            AgregarFilaChecks(tablaBeca, "¿Cuál posee?:",
                ("IMAS", string.Equals(condicionSocioEconomica.TipoBeca + "", "Imas", StringComparison.OrdinalIgnoreCase)),
                ("Comedor", string.Equals(condicionSocioEconomica.TipoBeca + "", "Comedor", StringComparison.OrdinalIgnoreCase)),
                ("Transporte", string.Equals(condicionSocioEconomica.TipoBeca + "", "Transporte", StringComparison.OrdinalIgnoreCase))
            );
            AgregarFilaChecks(tablaBeca, "Núcleo Familiar:",
                ("Padre", string.Equals(condicionSocioEconomica.NucleoFamiliar + "", "Padre", StringComparison.OrdinalIgnoreCase)),
                ("Madre", string.Equals(condicionSocioEconomica.NucleoFamiliar + "", "Madre", StringComparison.OrdinalIgnoreCase)),
                ("Padre y Madre", string.Equals(condicionSocioEconomica.NucleoFamiliar + "", "Padre y Madre", StringComparison.OrdinalIgnoreCase))
            );

            AgregarFilaChecks(tablaBeca, "",
              ("Otros", string.Equals(condicionSocioEconomica.NucleoFamiliar + "", "Otros", StringComparison.OrdinalIgnoreCase)));

            AgregarFilaChecks(tablaBeca, "Nivel Académico del encargado legal del estudiante:",
                ("Primaria completa", string.Equals(condicionSocioEconomica.EducacionEncargado, "Primaria completa", StringComparison.OrdinalIgnoreCase)),
                ("Primaria incompleta", string.Equals(condicionSocioEconomica.EducacionEncargado, "Primaria incompleta", StringComparison.OrdinalIgnoreCase))

            );
            AgregarFilaChecks(tablaBeca, "",
                ("Secundaria completa", string.Equals(condicionSocioEconomica.EducacionEncargado, "Secundaria completa", StringComparison.OrdinalIgnoreCase)),
                ("Secundaria incompleta", string.Equals(condicionSocioEconomica.EducacionEncargado, "Secundaria incompleta", StringComparison.OrdinalIgnoreCase))
            );
            AgregarFilaChecks(tablaBeca, "",
              ("Universitaria", string.Equals(condicionSocioEconomica.EducacionEncargado, "Universitaria", StringComparison.OrdinalIgnoreCase)));

            AgregarFilaChecks(tablaBeca, "Pagó patronato?",
                ("Sí", string.Equals(condicionSocioEconomica.PagoPatronato, "true", StringComparison.OrdinalIgnoreCase)),
                ("No", string.Equals(condicionSocioEconomica.PagoPatronato, "false", StringComparison.OrdinalIgnoreCase))
            );

            AgregarFilaConLinea(tablaBeca, "Monto: ", condicionSocioEconomica.Monto);
            documento.Add(tablaBeca);
        }

        public static void AgregarActaDeCompromiso(Document documento)
        {
            //servirá como cuadro contenedor
            PdfPTable tabla = new PdfPTable(1);
            tabla.WidthPercentage = 100;
            Font fTexto = new Font(Font.TIMES_ROMAN, 9);
            string textoActa =
           @"                                                                               Acta de Compromiso

Yo _____________________________________________ portador(a) de la Cédula #____________________
en calidad de encargado(a) legal del estudiante _____________________________ de la sección ___________,
después de leídos los lineamientos, me comprometo a que mi representado(a) cumpla y respete lo que estipula
la Normativa Interna de la UP Río Cuba, así como las responsabilidades y obligaciones que tiene el estudiante
según lo establecido en el Reglamento de Evaluación de los Aprendizajes del MEP. Además, se me ha de saber
que en caso de que mi hijo(a) incurra en alguna falta (Muy Leve, Leve, Grave, Muy Grave, Gravísima) de las señaladas en la NI o REA será expuesto a sanciones e incluso a la interrupción del curso lectivo de acuerdo a la tipicidad de la falta, consideradas en ambos reglamentos.
De las Obligaciones:
• Adquirir Cuaderno de Comunicaciones.
• Atender todo comunicado referido al hogar.
• Asistir a Asambleas de Padres, Entrega de Notas y convocatoria de docentes.
• Visitar al menos 1 vez al mes el Centro Educativo para información sobre mi hijo(a).
• Actualizar datos en caso de cambio de domicilio, teléfono o dirección.
• Reportar cualquier cambio en la salud física, emocional de sus hijos y presentar dictámenes médicos que certifiquen algún problema de salud.
* El encargado debe velar porque, si su hijo tiene algún tratamiento médico prescrito, cumpla con el mismo.
* Además, se solicita al encargado NO ENVIAR al estudiante al Centro Educativo en caso de que presente alguna enfermedad infectocontagiosa.
* En caso de presentarse una eventualidad de salud con alguno de los estudiantes, se procederá según el protocolo del MEP.
* El encargado debe velar porque el estudiante dé buen uso de los beneficios que le brinde el Estado o la Institución, a saber: IMAS, TRANSPORTE, BIENESTAR ESTUDIANTIL, COMEDOR.
  En caso de que la institución verifique que ese recurso no se está aprovechando, se procederá a la suspensión de este beneficio.
* No se permite la salida de los estudiantes sin la debida autorización de los padres; para todo permiso de salida debe venir firmado y autorizado en el cuaderno de comunicaciones.
* Adquirir carnet estudiantil.
* El padre de familia o encargado autoriza el permiso de uso de imágenes del estudiante con carácter de promoción de actividades educativas, culturales y deportivas
  por parte de la institución y por resguardo de la seguridad de sus hijos.
* La póliza estudiantil no es un requisito para matrícula para la Institución, queda en el padre de familia o encargado a su criterio la adquisición de ese beneficio.
* Al llenar los documentos por parte de los padres de familia para la solicitud de Transporte Estudiantil, la administración NO GARANTIZA que le sea otorgado.
  Por tal motivo, el padre de familia o encargado que no sea beneficiario por estos servicios debe hacerse cargo del costo que devengan estos.

Firma Encargado Legal: _________________________________________________";

            
            Paragraph contenido = new Paragraph(textoActa, fTexto)
            {
                Alignment = Element.ALIGN_JUSTIFIED,
                Leading = 14f,  // espacio entre líneas
                SpacingBefore = 2f,
                SpacingAfter = 2f,
                IndentationLeft = 4f,
                IndentationRight = 4f
            };

            //Celda que contiene todo el texto (con borde)
            PdfPCell celda = new PdfPCell();
            celda.AddElement(contenido);
            celda.Border = Rectangle.BOX;
            celda.BorderWidth = 1f;
            celda.Padding = 10f;
            celda.VerticalAlignment = Element.ALIGN_TOP;

            tabla.AddCell(celda);
            documento.Add(tabla);

            documento.Add(new Paragraph("\n"));
        }

        private void separarCasoEmergencia(Encargado en)
        {
            this.EnCasoEmergencia=en.ComunicacionEmergencia.Split(',');
        }

        private void separarTelefonoEmergencia(Encargado en)
        {
            this.TelofonoEmergencia = en.TelefonoEmergencia.Split(',');
        }
    }//FIN DE LA CLASE
}
