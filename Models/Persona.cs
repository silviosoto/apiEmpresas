using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEmpresa.Models
{
    public partial class Persona
    {
        public int Id { get; set; }
        public string TipoIdentificacion { get; set; }
        public int? NumeroIdentificacion { get; set; }
        public string NombreCompania { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public string Via { get; set; }
        public int? Numero { get; set; }
        public string Letra { get; set; }
        public int? Numero2 { get; set; }
        public int IdMunicipio { get; set; }
        public string Telefono { get; set; }
        public string NumeroComplemento { get; set; }
        public bool? EnvioMensajes { get; set; }

        public virtual Municipio IdMunicipioNavigation { get; set; }
    }
}
