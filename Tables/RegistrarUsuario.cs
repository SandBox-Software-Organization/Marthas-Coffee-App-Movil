﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marthas_Coffee_App_Movil.Tables
{
    public class RegistrarUsuario
    {
        public Guid IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }

    }
}
