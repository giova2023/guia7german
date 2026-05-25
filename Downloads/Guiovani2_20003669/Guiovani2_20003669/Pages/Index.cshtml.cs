using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Guiovani2_20003669.Pages
{
    public class IndexModel : PageModel
    {
        // --- Propiedades del capítulo ---
        public string visitante { get; set; } = "";
        public string fecha { get; set; } = "";
        public List<string> visitantes = new List<string>();

        // --- Propiedades del ejercicio (NUEVAS) ---
        public DateTime fechaCreacion { get; set; }
        public int diasDesdeCreacion { get; set; }

        public void OnGet()
        {
            // Del capítulo
            visitante = "Santiago";
            fecha = DateTime.Now.ToString("dd-MM-yyyy");
            visitantes.Add("Matias");
            visitantes.Add("Micaela");
            visitantes.Add("Andres");
            visitantes.Add("Marta");

            // Del ejercicio (NUEVO)
            fechaCreacion = new DateTime(2026, 5, 17); // cambia por HOY
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaCreacion;
            diasDesdeCreacion = (int)diferencia.TotalDays;
        }
    }
}