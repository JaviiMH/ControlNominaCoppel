using ControlEmpleadosCoppel.Logica;
using ControlEmpleadosCoppel.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace ControlEmpleadosCoppel.Controllers
{

    public class EmpleadosController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult AltaEmpleados()
        {
            return View();
        }
        public List<EmpleadosModel> GuardarEmpleados(EmpleadosModel model)
        {
            List<EmpleadosModel> modelList = new List<EmpleadosModel>();

            DataTable dt = LogicaDatos.AltaEmpleados(model);
            if (dt != null && dt.Rows.Count > 0)
            {
                modelList = JsonConvert.DeserializeObject<List<EmpleadosModel>>(JsonConvert.SerializeObject(dt, Formatting.Indented));
            }
            //var serializer = new JavaScriptSerializer();
            ////Se cambia el Length directo a nuestra referencia
            //serializer.MaxJsonLength = 1000000000;
            ////return Json(collection, JsonRequestBehavior.AllowGet);
            //var json = Json(model, System.Web.Mvc.JsonRequestBehavior.AllowGet);

            //ViewBag.json = "";
            return modelList;
        }
        public ActionResult ConsultaEmpleados()
        {
            return View();
        }
        public List<EmpleadosModel> ConsultarEmpleados(int NumEmpleado, int mes)
        {
            List<EmpleadosModel> modelList = new List<EmpleadosModel>();

            DataTable dt = LogicaDatos.ConsultaEmpleado( NumEmpleado,  mes);
            if (dt != null && dt.Rows.Count > 0)
            {
                modelList = JsonConvert.DeserializeObject<List<EmpleadosModel>>(JsonConvert.SerializeObject(dt, Formatting.Indented));
            }
            //var serializer = new JavaScriptSerializer();
            ////Se cambia el Length directo a nuestra referencia
            //serializer.MaxJsonLength = 1000000000;
            ////return Json(collection, JsonRequestBehavior.AllowGet);
            //var json = Json(model, System.Web.Mvc.JsonRequestBehavior.AllowGet);

            //ViewBag.json = "";
            return modelList;
        }
        public ActionResult CapturaMovimientoEmpleado()
        {
            return View();
        }
        public List<EmpleadosModel> GuardarCapturaMovimientoEmpleado(EmpleadosModel model)
        {
            List<EmpleadosModel> modelList = new List<EmpleadosModel>();

            DataTable dt = LogicaDatos.AltaEmpleados(model);
            if (dt != null && dt.Rows.Count > 0)
            {
                modelList = JsonConvert.DeserializeObject<List<EmpleadosModel>>(JsonConvert.SerializeObject(dt, Formatting.Indented));
            }
            //var serializer = new JavaScriptSerializer();
            ////Se cambia el Length directo a nuestra referencia
            //serializer.MaxJsonLength = 1000000000;
            ////return Json(collection, JsonRequestBehavior.AllowGet);
            //var json = Json(model, System.Web.Mvc.JsonRequestBehavior.AllowGet);

            //ViewBag.json = "";
            return modelList;
        }
        [HttpGet]
        public ActionResult ReporteEmpleadosGeneral()
        {
            return View();
        }
        public List<EmpleadosModel> ObtenerReporteEmpleadosGeneral(string fechaIni)
        {
            List<EmpleadosModel> modelList = new List<EmpleadosModel>();

            DataTable dt = LogicaDatos.ReporteMovimientosEmpleados(fechaIni);
            if (dt != null && dt.Rows.Count > 0)
            {
                modelList = JsonConvert.DeserializeObject<List<EmpleadosModel>>(JsonConvert.SerializeObject(dt, Formatting.Indented));
            }
            //var serializer = new JavaScriptSerializer();
            ////Se cambia el Length directo a nuestra referencia
            //serializer.MaxJsonLength = 1000000000;
            ////return Json(collection, JsonRequestBehavior.AllowGet);
            //var json = Json(model, System.Web.Mvc.JsonRequestBehavior.AllowGet);

            //ViewBag.json = "";
            return modelList;
        }
    }
}
