using Asistencias.Data.Repositories;
using Registro.Data.Model;
using Registro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FrontEnd.Models;
using Asistencias.Repositories;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Personal()
        {
            IHorariosRepositorios horariosRepositorios = new HorariosRepositorios();

            ViewBag.ListaHorarios = horariosRepositorios.GetList().Select(x=> new HorariosModel { Id = x.Id, hsDesde = $"{ x.hsEntrada}: {x.minEntrada}" , hsHasta = $"{ x.hsSalida}: {x.minSalida}" }).ToList();

            return View();
        }


        public ActionResult Horarios()
        {
            

            return View();
        }
        public ActionResult Save(HorariosModel modelHorario)
        {
            Horario horario = new Horario();
            horario.Id = Guid.NewGuid();
            char separator = ':';
            string[] Entrada = modelHorario.hsDesde.Split(separator);
            string[] Salida = modelHorario.hsHasta.Split(separator);

            
            horario.hsEntrada = Int32.Parse(Entrada[0]);
            horario.minEntrada = Int32.Parse(Entrada[1]);
            horario.hsSalida = Int32.Parse(Salida[0]);
            horario.minSalida = Int32.Parse(Salida[1]);
            IHorariosRepositorios horariosRepositorios = new HorariosRepositorios();
            horariosRepositorios.Insert(horario);

            return RedirectToAction("Index");
            
        }

        public ActionResult SavePersonal(PersonalModel modelPersonal)
        {
            Personal personal = new Personal();
            personal.Id = Guid.NewGuid();
            personal.Nombre = modelPersonal.viewNombre;
            personal.Apellido = modelPersonal.viewApellido;
            personal.FechaNac = modelPersonal.viewFechaNac;
            personal.DNI = modelPersonal.viewDni;
            personal.Domicilio = modelPersonal.viewDomicilio;
            personal.Email = modelPersonal.viewEmail;
            personal.IdHorario = modelPersonal.viewIdHorario;
            IPersonalRepositorio personalRepositorio = new PersonalRepositorios();
            personalRepositorio.Insert(personal);
            return RedirectToAction("Index");
        }
        public ActionResult SaveRegistroAsistencia(string txtdni, string captura)//agregar despues la foto
        {
            IPersonalRepositorio personalRepositorio = new PersonalRepositorios();
            var persona = personalRepositorio.buscarDNI(txtdni);
            RegistrosAsistencia registro = new RegistrosAsistencia();
            if (persona != null)
            {

                registro.Id = Guid.NewGuid();
                registro.IdPersonal = persona.Id;
                registro.FechaHora = DateTime.Now;
                //registro.Foto = captura;
                //registro.Movimiento = modelRegistro.movimiento;
                registro.IdHorario = (Guid)persona.IdHorario;
                IRegistrosAsistenciaRepositorio registrosAsistenciaRepositorio = new RegistrosAsistenciaRepositorio();
                registrosAsistenciaRepositorio.Insert(registro);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Personal");
        }



    }
}