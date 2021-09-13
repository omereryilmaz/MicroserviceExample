using Reservation.Infrastructure;
using Reservation.Models;
using System;

namespace Reservation.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(100),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                BkgNumber = bkgNumber
            };
        }
    }
}
