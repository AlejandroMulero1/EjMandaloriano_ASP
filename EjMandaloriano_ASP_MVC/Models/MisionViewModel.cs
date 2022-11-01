using Microsoft.AspNetCore.Mvc.Rendering;

namespace EjMandaloriano_ASP_MVC.Models
{
    public class MisionViewModel
    {
        public String IdMision { get; set; }
        public List<SelectListItem> misionSelectList { get; set; }
    }
}
