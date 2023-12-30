using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Domain.Entities
{
	public class Event_Participant
	{
		#region [ Properties ]

		[Key]
		public int Id { get; set; }

		// Foreign Key to Event Entity
		[Required]
		[ForeignKey("Event")]
		public int EventId { get; set; }

		// Foreign Key to Employee
		[Required]
		[ForeignKey("Employee")]
		public int EmployeeId { get; set; }

        #endregion

        #region [ Constructors ]
        public Event_Participant()
        {
        }
        #endregion
    }
}

