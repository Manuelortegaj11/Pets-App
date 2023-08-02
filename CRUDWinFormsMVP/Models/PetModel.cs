using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDWinFormsMVP.Models
{
    public class PetModel
    {
        //Fields
        private int id;
        private string name;
        private string type;
        private string colour;

        //Properties - Validations
        [DisplayName("ID de la mascota")]
        public int Id
        {
            get => id;
            set => id = value;
        }

        [DisplayName("Nombre de la mascota")]
        [Required(ErrorMessage = "Nombre de la mascota es requerido")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "El campo nombre debe tener entre 3 a 12 caracteres")]
        public string Name
        {
            get => name;
            set => name = value;
        }
        [DisplayName("Tipo de la mascota")]
        [Required(ErrorMessage = "Nombre de la mascota es requerido")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "El campo tipo debe tener entre 3 a 12 caracteres")]
        public string Type
        {
            get => type;
            set => type = value;
        }
        [DisplayName("Color de la mascota")]
        [Required(ErrorMessage = "Nombre de la mascota es requerido")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "El campo Color debe tener entre 3 a 12 caracteres")]
        public string Colour
        {
            get => colour;
            set => colour = value;
        }
    }
}
