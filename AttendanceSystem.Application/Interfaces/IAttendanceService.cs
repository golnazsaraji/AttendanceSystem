using System;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.Application.Interfaces
{
	public interface IAttendanceService
	{
        void Enter(Attendance attendance);
        void Update(Attendance attendance);
        IEnumerable<Attendance> GetEmployeeAttendances(int employeeId);
        IEnumerable<Attendance> GetADayAttendances(DateTime attendanceDate);
    }
}

