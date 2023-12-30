using System;
using AttendanceSystem.DataAccess.Classes;
using AttendanceSystem.DataAccess.Interfaces;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.DataAccess.Repositories
{
	public class DepartmentRepository: IDepartmentRepository
    {
        private readonly AttendanceDbContext _dbContext;

        public DepartmentRepository(AttendanceDbContext dbContext)
		{
			_dbContext = dbContext;
		}

        public void Create(Department department) {

            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();
        }

        public void Update(Department department) {

            _dbContext.Departments.Update(department);
            _dbContext.SaveChanges();
        }

        public void Delete(int departmentId) {

            Department? department = _dbContext.Departments.FirstOrDefault(p => p.Id == departmentId);
            if (department != null) {
                _dbContext.Departments.Remove(department);
                _dbContext.SaveChanges();
            }
        }

        public Department GetDepartment(int departmentId) {

            return _dbContext.Departments.FirstOrDefault(p => p.Id == departmentId);
        }

        public IEnumerable<Department> GetDepartments() {
            return _dbContext.Departments.ToList();
        }
    }
}

