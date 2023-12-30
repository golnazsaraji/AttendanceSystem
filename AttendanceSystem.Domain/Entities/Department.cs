using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Domain.Entities
{
	public class Department
	{

		#region [ Properties ]

		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		// Foreign Key to an Employee
		[ForeignKey("Employee")]
		public int ManagerId { get; set; }

		// For Hierarchy Implementation of the Company Structure
		[ForeignKey("Department")]
		public int ParentId { get; set; }

		#endregion

		#region [ Methods ]

		public void Create(Department department) {

			if (department == null)
				throw new ArgumentNullException("Department can not be null!");
			if (String.IsNullOrEmpty(department.Name))
				throw new ArgumentException("Name of department is required!");
			if(department.ManagerId < 0)
                throw new ArgumentException("ManagerId must be greater than 0!");
			if(department.ParentId < 0)
                throw new ArgumentException("ParentId must be greater than 0!");

        }

		public void Update(Department department) {

            if (department == null)
                throw new ArgumentNullException("Department can not be null!");
            if (department.Id < 0)
                throw new ArgumentException("Department Id must be greater than 0!");
            if (String.IsNullOrEmpty(department.Name))
                throw new ArgumentException("Name of department is required!");
            if (department.ManagerId < 0)
                throw new ArgumentException("ManagerId must be greater than 0!");
            if (department.ParentId < 0)
                throw new ArgumentException("ParentId must be greater than 0!");


        }

        public void GetDepartment(int departmentId)
		{
            if (departmentId < 0)
                throw new ArgumentException("Department Id must be greater than 0!");

        }

        public void Delete(int departmentId) {

			if (departmentId == null)
				throw new ArgumentNullException("Department Id can not be null!");
			if (departmentId < 0)
				throw new ArgumentException("Department Id must be greater than 0!");
			
		}

        #endregion

        #region [ Constructors ]
        public Department()
        {
        }
        #endregion

    }
}

