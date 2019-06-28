using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Html_helpersTarea.Models
{
    public class Persona
    {
        [Required]
        public int Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Range(15, 99)]
        public int Edad { get; set; }

        public int Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name ="Correo electronico")]
        public string CorreoElectronico { get; set; }

        [Display(Name = "Genero")]
        public Genero GeneroPersona { get; set; }

        [Display(Name ="Estado civil")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Llorar cuando ella no esta")]
        public bool Hobby1 { get; set; }

        [Display(Name = "Pelear cuando me aburro")]
        public bool Hobby2 { get; set; }

        [Display(Name = "Ver anime")]
        public bool Hobby3 { get; set; }

        [Display(Name = "Posar como un jojo")]
        public bool Hobby4 { get; set; }

        //enumerables
        public enum Genero
        {
            Masculino,
            Femenino
        }

    }
}