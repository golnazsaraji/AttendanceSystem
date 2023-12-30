using System;
using System.ComponentModel.DataAnnotations;

namespace AttendanceSystem.Domain.Entities
{
	public class Event
	{
		#region [ Properties ]
		
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(70)]
		public string Title { get; set; }

		[Required]
		public string Location { get; set; }

		[Required]
		public DateTime Date { get; set; }
		public string Type { get; set; }
		public TimeSpan Duration { get; set; }

        #endregion

        #region [ Constructors ]
        public Event()
        {
        }
        #endregion
    }
}

