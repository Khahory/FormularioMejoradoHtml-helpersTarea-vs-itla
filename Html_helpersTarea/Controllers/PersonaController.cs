using Html_helpersTarea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Html_helpersTarea.Controllers
{
    public class PersonaController : Controller
    {
        Persona _persona;
        public PersonaController()
        {
            _persona = new Persona();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            _persona.Cedula = persona.Cedula;
            _persona.Nombre = persona.Nombre;
            _persona.Apellido = persona.Apellido;
            _persona.Edad = persona.Edad;
            _persona.Telefono = persona.Telefono;
            _persona.CorreoElectronico = persona.CorreoElectronico;
            _persona.GeneroPersona = persona.GeneroPersona;
            _persona.EstadoCivil = persona.EstadoCivil;
            _persona.Hobby1 = persona.Hobby1;

            return View(persona);
        }
    }
}
