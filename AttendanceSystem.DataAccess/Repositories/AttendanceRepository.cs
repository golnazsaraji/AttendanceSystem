using System;
using AttendanceSystem.DataAccess.Classes;
using AttendanceSystem.DataAccess.Interfaces;
using AttendanceSystem.Domain.Entities;

namespace AttendanceSystem.DataAccess.Repositories
{
	public class AttendanceRepository: IAttendanceRepository
    {
        private readonly AttendanceDbContext _dbContext;

        public AttendanceRepository(AttendanceDbContext dbContext)
		{
            _dbContext = dbContext;
		}

        public void Enter(Attendance attendance) {

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

        }

        public void Update(Attendance attendance) {

            _dbContext.Attendances.Update(attendance);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Attendance> GetEmployeeAttendances(int employeeId) {
            return _dbContext.Attendances.Where(p => p.EmployeeId == employeeId).ToList();
        }

        public IEnumerable<Attendance> GetADayAttendances(DateTime attendanceDate) {
            return _dbContext.Attendances.Where(p => p.EntranceTime == attendanceDate).ToList();
        }
    }
}

