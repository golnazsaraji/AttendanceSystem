using System;
using AttendanceSystem.DataAccess.Interfaces;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.Application.Services
{
	public class DepartmentService: IDepartmentRepository
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
		{
			_departmentRepository = departmentRepository;
		}


        public void Create(Department department) {
            _departmentRepository.Create(department);
        }

        public void Update(Department department) {
            _departmentRepository.Update(department);
        }

        public void Delete(int departmentId) {
            _departmentRepository.Delete(departmentId);
        }

        public Department GetDepartment(int departmentId) {
           return _departmentRepository.GetDepartment(departmentId);
        }

        public IEnumerable<Department> GetDepartments() {
            return _departmentRepository.GetDepartments();
        }
    }
}

