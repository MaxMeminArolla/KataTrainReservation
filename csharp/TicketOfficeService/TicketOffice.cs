namespace TicketOfficeService;

public record ReservationRequest(string TrainId, int SeatCount);
public record Reservation(string TrainId, string BookingId, List<Seat> Seats);
public record Seat(string Coach, int SeatNumber);

public class TicketOffice
{
    public Reservation MakeReservation(ReservationRequest request)
    {
        var seats = new List<Seat>
        {
            new Seat("", request.SeatCount) 
        };
        return new Reservation(request.TrainId, 123456790.ToString("x"), seats);
    }
}