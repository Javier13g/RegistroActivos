using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.ServiciosCorreo
{
    class SoporteSystem:ServicioMail
    {
        public SoporteSystem()
        {
            senderMail = "systemid80@gmail.com";
            password = "lospepe15";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
