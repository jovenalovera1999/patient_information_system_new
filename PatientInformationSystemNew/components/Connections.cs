using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystemNew.components
{
    class Connections
    {
        components.Values val = new components.Values();

        public string conString()
        {
            return String.Format("datasource = {0}; username = {1}; password = {2}; port = {3}; database = {4};", 
                                    val.server_name, val.server_user, val.server_pass, val.server_port, val.db_name);
        }
    }
}
