using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public static class function
    {
        public static string ConnectionString()
        {
            
            string constring = "Server = localhost; database = cafe_management; Uid= root; Pwd = ''; SslMode = none";
            return constring;
        }
        
           
        }
    }

