using BusinessStaffManger.DbContexts;
using BusinessStaffManger.DTOs;
using BusinessStaffManger.Models.Reservations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationConflictValidators
{
    public class DatabaseReservationConflictValidator : IReservationConflictValidator
    {
        private readonly BusinessStaffDbContextFactory _dbContextFactory;
        public DatabaseReservationConflictValidator(BusinessStaffDbContextFactory businessStaffDbContextFactory)
        {
            _dbContextFactory = businessStaffDbContextFactory;
        }

        public async Task<DepartmentReservation> GetConflictReservation(DepartmentReservation departmentReservation)
        {
            using(BusinessStaffDbContext context = _dbContextFactory.CreateDbContext())
            {
                DepartmentDTO departmentDTO = await context.Departments
                    .Where(d =>d.ReservationID == departmentReservation.ReservationID)
                    .Where(d => d.Name == departmentReservation.Name)
                    .Where(d => d.Position == departmentReservation.Position)
                    .FirstOrDefaultAsync();

                if (departmentDTO == null)
                {
                    return null;
                }

                return ToDepartmentReservation(departmentDTO);
            }
            
        }

        private DepartmentReservation ToDepartmentReservation(DepartmentDTO dto)
        {
            return new DepartmentReservation(dto.ReservationID, dto.Name, dto.Position);
        }

        public async Task<PositionReservation> GetConflictReservation(PositionReservation positionReservation)
        {
            using (BusinessStaffDbContext context = _dbContextFactory.CreateDbContext())
            {
                PositionDTO positionDTO = await context.Positions
                    .Where(d => d.ReservationID == positionReservation.ReservationID)
                    .Where(p => p.Name == positionReservation.Name)
                    .Where(p => p.Salary == positionReservation.Salary)
                    .Where(p => p.MaxNumber == positionReservation.MaxNumber)
                    .Where(p => p.Staff == positionReservation.Staff)
                    .Where(p => p.Department == positionReservation.Department)
                    .FirstOrDefaultAsync();

                if (positionDTO == null)
                {
                    return null;
                }

                return ToPositionReservation(positionDTO);
            }
        }

        private PositionReservation ToPositionReservation(PositionDTO dto)
        {
            return new PositionReservation(dto.ReservationID, dto.Name, dto.Salary, dto.MaxNumber, dto.Staff, dto.Department);
        }

        public async Task<StaffReservation> GetConflictReservation(StaffReservation staffReservation)
        {
            using (BusinessStaffDbContext context = _dbContextFactory.CreateDbContext())
            {
                StaffDTO staffDTO = await context.Staffs
                    .Where(d => d.ReservationID == staffReservation.ReservationID)
                    .Where(s => s.Name == staffReservation.Name)
                    .Where(s => s.SurName == staffReservation.SurName)
                    .Where(s => s.Phone == staffReservation.Phone)
                    .Where(s => s.Position == staffReservation.Position)
                    .FirstOrDefaultAsync();

                if (staffDTO == null)
                {
                    return null;
                }

                return ToStaffReservation(staffDTO);
            }
        }

        private StaffReservation ToStaffReservation(StaffDTO dto)
        {
            return new StaffReservation(dto.ReservationID, dto.Name, dto.SurName, dto.Phone, dto.Position);
        }
    }
}
