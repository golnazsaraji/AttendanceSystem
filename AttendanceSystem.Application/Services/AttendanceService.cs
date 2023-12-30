using System;
using AttendanceSystem.Application.Interfaces;
using AttendanceSystem.DataAccess.Interfaces;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.Application.Services
{
	public class AttendanceService: IAttendanceService
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public AttendanceService(IAttendanceRepository attendanceRepository)
		{
			_attendanceRepository = attendanceRepository;
		}

        public void Enter(Attendance attendance) {
            _attendanceRepository.Enter(attendance);
        }

        public void Update(Attendance attendance) {
            _attendanceRepository.Update(attendance);
        }

        public IEnumerable<Attendance> GetEmployeeAttendances(int employeeId) {
           return _attendanceRepository.GetEmployeeAttendances(employeeId);
        }

        public IEnumerable<Attendance> GetADayAttendances(DateTime attendanceDate) {
            return _attendanceRepository.GetADayAttendances(attendanceDate);
        }


    }
}

