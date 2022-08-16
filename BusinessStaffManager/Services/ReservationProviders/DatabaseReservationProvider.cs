using BusinessStaffManger.DbContexts;
using BusinessStaffManger.DTOs;
using BusinessStaffManger.Models.Reservations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationProviders
{
    public class DatabaseReservationProvider : IReservationProvider
    {
        private readonly BusinessStaffDbContextFactory _businessStaffDbContextFactory;
        public DatabaseReservationProvider(BusinessStaffDbContextFactory businessStaffDbContextFactory)
        {
            _businessStaffDbContextFactory = businessStaffDbContextFactory;
        }

        public async Task<IEnumerable<DepartmentReservation>> GetAllDepartmentReservation()
        {
            using(BusinessStaffDbContext context = _businessStaffDbContextFactory.CreateDbContext())
            {
                IEnumerable<DepartmentDTO> departmentDTOs = await context.Departments.ToListAsync();
                await Task.Delay(2000);
                return departmentDTOs.Select(d => ToDepartmentReservation(d));
            }
        }

        private DepartmentReservation ToDepartmentReservation(DepartmentDTO dto)
        {
            return new DepartmentReservation(dto.ReservationID, dto.Name, dto.Position);
        }

        public async Task<IEnumerable<PositionReservation>> GetAllPositionReservation()
        {
            using (BusinessStaffDbContext context = _businessStaffDbContextFactory.CreateDbContext())
            {
                IEnumerable<PositionDTO> positionDTOs = await context.Positions.ToListAsync();
                await Task.Delay(2000);
                return positionDTOs.Select(d => ToPositionReservation(d));
            }
        }

        private PositionReservation ToPositionReservation(PositionDTO dto)
        {
            return new PositionReservation(dto.ReservationID, dto.Name, dto.Salary, dto.MaxNumber, dto.Staff, dto.Department);
        }

        public async Task<IEnumerable<StaffReservation>> GetAllStaffReservation()
        {
            using (BusinessStaffDbContext context = _businessStaffDbContextFactory.CreateDbContext())
            {
                IEnumerable<StaffDTO> staffDTOs = await context.Staffs.ToListAsync();
                await Task.Delay(2000);
                return staffDTOs.Select(d => ToStaffReservation(d));
            }
        }

        private StaffReservation ToStaffReservation(StaffDTO dto)
        {
            return new StaffReservation(dto.ReservationID, dto.Name, dto.SurName, dto.Phone, dto.Position);
        }
    }
}
