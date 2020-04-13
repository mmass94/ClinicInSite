using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClinicInfoManager.Models;

namespace ClinicInfoManager.Context
{
    public class SignupContext:DbContext
    {

        public DbSet<Signup> Signups { get; set;  }
    }
}