
using System;
using Microsoft.EntityFrameworkCore;

namespace microservice_classes_registration.db{
	public class DatabaseSqlServer: DbContext{

        public DatabaseSqlServer(DbContextOptions<DatabaseSqlServer> options) : base(options) { }
        public DbSet<Students> Products { get; set; }

    }
}

