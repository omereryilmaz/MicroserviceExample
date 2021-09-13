using Reservation.Models;

namespace Reservation.Infrastructure
{
    public interface IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int bkgNumber);
    }
}
