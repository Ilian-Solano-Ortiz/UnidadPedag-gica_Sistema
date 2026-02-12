using GenerarPDFUP.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenerarPDFUP.Services;

namespace GenerarPDFUP.Services
{
    public class PlantillaExistente
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

        private void InicializarDocumento(string ruta)
        {
            this.documento = new Document(PageSize.A4, 50, 50, 40, 40);
            this.fileStream = new FileStream(ruta, FileMode.Create);
            this.writer = PdfWriter.GetInstance(documento, fileStream);
            documento.Open();
        }

        public void CrearFormulario(string ruta, Estudiante es, Encargado en,
            string pagoPatronato, string monto)
        {
            InicializarDocumento(ruta);
            AgregarEncabezado();
            AgregarTitulo(es);
            AgregarCuerpo(es, en,pagoPatronato,monto);
            AgregarPieDePagina();
            CerrarDocumento();
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

        private void AgregarTitulo(Estudiante es)
        {
            Paragraph titulo = new Paragraph($"Validación De Matrícula\nCurso Lectivo: {GenerarAño()}\n\n",
                new Font(Font.TIMES_ROMAN, 11, Font.BOLD));

            AgregarNivelConChecks(es.NivelSeleccionado);
            titulo.Alignment = Element.ALIGN_CENTER;

            documento.Add(titulo);
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

        private string GenerarAño()
        {
            string fecha;
            fecha = DateAndTime.Year(DateAndTime.Now) + "";
            return fecha;
        }

        private void CerrarDocumento()
        {
            documento.Close();
            fileStream.Close();
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

        private void AgregarPieDePagina()
        {
            documento.Add(new Paragraph("\nFirma del funcionario que hace la matrícula: ___________________________", new Font(Font.TIMES_ROMAN, 12)));  
        }

        public void AgregarCuerpo(Estudiante es, Encargado en, string pagoPatronato, string monto)
        {
            PdfPTable tabla = new PdfPTable(2);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 35f, 65f });
            AgregarFilaConLinea(tabla, "Nivel:", es.NivelEstudiante);
            AgregarFilaConLinea(tabla, "Fecha de Matrícula:", es.FechaMatricula);
            AgregarFilaConLinea(tabla, "Nombre Completo del Estudiante:", es.NombreEstudiante);
            AgregarFilaConLinea(tabla, "Cédula:", es.CedulaEstudiante);
            AgregarFilaConLinea(tabla, "Teléfono del encargado:", en.TelefonoEncargado);

            AgregarFilaChecks(tabla, "Si cursa el nivel de 10° elija el idioma (10°):",
                ("Inglés", string.Equals(es.IdiomaElegido, "Inglés", StringComparison.OrdinalIgnoreCase)),
                ("Francés", string.Equals(es.IdiomaElegido, "Francés", StringComparison.OrdinalIgnoreCase))
            );


            AgregarFilaChecks(tabla, "Si cursa el nivel de 11° indique si ya realizó horas TC:",
                ("Sí", string.Equals(es.HorasTC+"","true",StringComparison.OrdinalIgnoreCase)),
                ("No", string.Equals(es.HorasTC + "", "false", StringComparison.OrdinalIgnoreCase))
            );


            AgregarFilaChecks(tabla, "Cuenta con Adecuación Curricular Aprobada:",
                ("Sí", string.Equals(es.AdecuacionAprobada + "", "true", StringComparison.OrdinalIgnoreCase)),
                ("No", string.Equals(es.AdecuacionAprobada + "", "false", StringComparison.OrdinalIgnoreCase))
            );

            AgregarFilaChecks(tabla, "Pagó patronato?",
                ("Sí", string.Equals(pagoPatronato, "true", StringComparison.OrdinalIgnoreCase)),
                ("No", string.Equals(pagoPatronato, "false", StringComparison.OrdinalIgnoreCase))
            );
            AgregarFilaConLinea(tabla, "Monto: ", monto);
            documento.Add(tabla);
            PlantillaNoExistente.AgregarActaDeCompromiso(this.documento);
        }

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

        private PdfPCell CeldaLinea(string texto = "", float altura = ALTURA_LINEA)
        {
            Phrase frase = new Phrase(texto ?? "", fValor);
            frase.Leading = 12f; // asegura alineación base del texto

            var c = new PdfPCell(frase)
            {
                Border = Rectangle.BOTTOM_BORDER,
                BorderWidthBottom = GRUESO_LINEA,
                BorderWidthLeft = 0,
                BorderWidthRight = 0,
                BorderWidthTop = 0,

                //Ajustes para alinear el texto justo encima de la línea
                PaddingTop = 0f,          
                PaddingBottom = 2f,       
                FixedHeight = 20f,        
                VerticalAlignment = Element.ALIGN_BOTTOM
            };

            if (string.IsNullOrWhiteSpace(texto))
                c.FixedHeight = altura;

            return c;
        }

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
    }
}
