using BusinessStaffManger.DbContexts;
using BusinessStaffManger.DTOs;
using BusinessStaffManger.Models.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessStaffManger.Services.ReservationCreators
{
    public class DatabaseReservationCreator : IReservationCreator
    {

        private readonly BusinessStaffDbContextFactory _dbContextFactory;
        public DatabaseReservationCreator(BusinessStaffDbContextFactory businessStaffDbContextFactory)
        {
            _dbContextFactory = businessStaffDbContextFactory;
        }

        public async Task CreateDepartmentReservation(DepartmentReservation departmentReservation)
        {
            using(BusinessStaffDbContext context = _dbContextFactory.CreateDbContext())
            {
                DepartmentDTO departmentDTO = ToDepartmentReservation(departmentReservation);
                context.Departments.Add(departmentDTO);
                await context.SaveChangesAsync();
            }
        }

        private DepartmentDTO ToDepartmentReservation(DepartmentReservation departmentReservation)
        {
            return new DepartmentDTO()
            {
                ReservationID = departmentReservation.ReservationID,
                Name = departmentReservation.Name,
                Position = departmentReservation.Position
            };
        }

        public async Task CreatePositionReservation(PositionReservation positionReservation)
        {
            using (BusinessStaffDbContext context = _dbContextFactory.CreateDbContext())
            {
                PositionDTO positionDTO = ToPositionReservation(positionReservation);
                context.Positions.Add(positionDTO);
                await context.SaveChangesAsync();
            }
        }

        private PositionDTO ToPositionReservation(PositionReservation positionReservation)
        {
            return new PositionDTO()
            {
                ReservationID = positionReservation.ReservationID,
                Name = positionReservation.Name,
                Salary = positionReservation.Salary,
                MaxNumber = positionReservation.MaxNumber,
                Staff = positionReservation.Staff,
                Department = positionReservation.Department
            };
        }

        public async Task CreateStaffReservation(StaffReservation staffReservation)
        {
            using (BusinessStaffDbContext context = _dbContextFactory.CreateDbContext())
            {
                StaffDTO staffDTO = ToStaffReservation(staffReservation);
                context.Staffs.Add(staffDTO);
                await context.SaveChangesAsync();
            }
        }

        private StaffDTO ToStaffReservation(StaffReservation staffReservation)
        {
            return new StaffDTO()
            {
                ReservationID = staffReservation.ReservationID,
                Name = staffReservation.Name,
                SurName = staffReservation.SurName,
                Phone = staffReservation.Phone,
                Position = staffReservation.Position
            };
        }
    }
}
