using System;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.DataAccess.Interfaces
{
	public interface IAttendanceRepository
	{
        void Enter(Attendance attendance);
        void Update(Attendance attendance);
        IEnumerable<Attendance> GetEmployeeAttendances(int employeeId);
        IEnumerable<Attendance> GetADayAttendances(DateTime attendanceDate);
    }
}

