using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlEmpleadosCoppel.Models
{
    public class EmpleadosModel
    {
        public string NumEmpleado { get; set; }
        public string Nombre_empleado { get; set; }
        public string RolId { get; set; }
        public decimal HorasTrabajadas { get; set; }
        public decimal PagoTotalHoras { get; set; }
        public decimal PagoTotalBonos { get; set; }
        public decimal PagoTotalEntregas { get; set; }
        public decimal Retenciones { get; set; }
        public decimal Vales { get; set; }
        public decimal NumMovimientos{ get; set; }
        public decimal SueldoTotal { get; set; }

    }
}
