using System;
using System.ComponentModel.DataAnnotations;
namespace AttendanceSystem.Domain.Entities
{
	public class Employee
	{

		#region [ Properties ]
		[Key]
        public int Id { get; set;  }

		[Required]
		[StringLength(50, MinimumLength = 3)]
		public string Firstname { get; set; }

		[Required]
		[StringLength(70, MinimumLength = 3)]
		public string Lastname { get; set; }

		[Required]
		[Range(18, 100)]
		public int Age { get; set; }

		[StringLength(30, MinimumLength = 5)]
		public string Position  { get; set; }

		[Required]
		public string Sex { get; set; }

		[Required]
		public DateTime Birthday { get; set; }
		public DateTime JoinDate { get; set; }
		public string Status { get; set; }
		public int Rate { get; set; }
		public bool MaritalStatus { get; set; }

		[Required]
		[StringLength(10)]
		public string MobileNumber { get; set; }

		[StringLength(100)]
		public string Address { get; set; }


		[Required]
		[StringLength(50)]
		public string Email { get; set; }

		#endregion

		#region [ Methods ]

		public void Join(Employee employee) {

			if (employee == null)
				throw new ArgumentNullException("Employee can not be null!");
			if (String.IsNullOrEmpty(employee.Firstname) || String.IsNullOrEmpty(employee.Lastname))
				throw new ArgumentException("Fullname is required!");
		}

		public void GetEmployee(int employeeId) {
			if (employeeId < 0)
				throw new ArgumentException("Employee Id must be greater than 0!");
			
		}

		public void Leave(int employeeId) {
            if (employeeId < 0)
                throw new ArgumentException("Employee Id must be greater than 0!");
        }

		public void Delete(int employeeId) {
            if (employeeId < 0)
                throw new ArgumentException("Employee Id must be greater than 0!");
        }

        #endregion

        #region [ Constructors ]
        public Employee()
        {
            JoinDate = DateTime.Now;
        }
        #endregion

    }
}

