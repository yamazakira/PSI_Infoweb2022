﻿using Microsoft.AspNet.Identity.EntityFramework;
using PSI2022.Areas.Seguranca.Models;
using System.Data.Entity;

namespace PSI2022.DAL
{
    public class IdentityDbContextAplicacao : IdentityDbContext<Usuario>
    {
        public IdentityDbContextAplicacao() : base("IdentityDb")
        { }
        static IdentityDbContextAplicacao()
        {
            Database.SetInitializer<IdentityDbContextAplicacao>(
            new IdentityDbInit());
        }
        public static IdentityDbContextAplicacao Create()
        {
            return new IdentityDbContextAplicacao();
        }
    }
    public class IdentityDbInit :
        DropCreateDatabaseIfModelChanges
            <IdentityDbContextAplicacao>
    {
    }
}