using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry
{
    class AppData
    {
        public static Entities.DentistryRLEntitiesColl Context = new Entities.DentistryRLEntitiesColl();
        public static Entities.User CurrentUser;

    }
}
