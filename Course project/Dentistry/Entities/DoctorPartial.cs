using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistry.Entities
{
    public partial class Doctor
    {
        public string FullNameDoctor
        {
            get
            {
                try
                {
                    return $"{Users.FirstOrDefault().FullName}";
                }
                catch
                {
                    return null;
                }
            }
            set
            {

            }
        }
    }
}

