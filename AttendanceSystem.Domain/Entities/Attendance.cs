using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Domain.Entities
{
	public class Attendance
	{

        #region [ Properties ]

        [Key]
        public int Id { get; set; }

        // Each Record is uniqued by an employee
        [Required]
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime EntranceTime { get; set; }
        public DateTime? ExitTime { get; set; }

        #endregion

        #region [ Methods ]

        public void Enter(Attendance attendance) {

            if (attendance == null)
                throw new ArgumentNullException("attendance can not be null!");
            if (attendance.EmployeeId < 0)
                throw new ArgumentException("Employee Id must be greater than 0!");
            if (attendance.EntranceTime == null)
                throw new ArgumentException("Enter time must has a valid value!");
            if (attendance.EntranceTime != null && attendance.ExitTime < attendance.EntranceTime)
                throw new ArgumentException("Exit time must be after the entrance time");
        }

        // This Method can be used for recording Exit and also correction in another fields except than employee Id
        public void Update(Attendance attendance) {

            if (attendance == null)
                throw new ArgumentNullException("attendance can not be null!");
            if(attendance.Id < 0)
                throw new ArgumentException("Attendance Id must be greater than 0!");
            if (attendance.EmployeeId < 0)
                throw new ArgumentException("Employee Id must be greater than 0!");
            if (attendance.ExitTime != null && attendance.ExitTime < attendance.EntranceTime)
                throw new ArgumentException("Exit time must be after the entrance time");

        }
        #endregion

        #region [ Constructors ]

        public Attendance()
		{
		}

        #endregion
    }
}

