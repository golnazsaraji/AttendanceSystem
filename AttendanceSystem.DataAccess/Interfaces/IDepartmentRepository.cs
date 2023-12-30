using System;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.DataAccess.Interfaces
{
	public interface IDepartmentRepository
	{
        void Create(Department department);
        void Update(Department department);
        void Delete(int departmentId);
        Department GetDepartment(int departmentId);
        IEnumerable<Department> GetDepartments();

    }
}

