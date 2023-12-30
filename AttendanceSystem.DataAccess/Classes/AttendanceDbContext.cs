using System;
using Microsoft.EntityFrameworkCore;
using AttendanceSystem.Domain.Entities;
namespace AttendanceSystem.DataAccess.Classes
{
	public class AttendanceDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        
        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options) : base(options)
        {
        }
	}
}

