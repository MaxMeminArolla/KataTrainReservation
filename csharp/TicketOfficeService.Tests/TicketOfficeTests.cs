using System.Collections.Generic;
using Xunit;

namespace TicketOfficeService.Tests;

public class TicketOfficeTests
{
    private const string Toto = "toto";
    private const string Titi = "titi";

    [Fact]
    public void Must_generate_a_train_reservation_with_one_seat()
    {
        var ticketOffice = new TicketOffice();
        var reserveRequest = new ReservationRequest(Toto, 1);
        var actualReservation = ticketOffice.MakeReservation(reserveRequest);

        Assert.Equal(Toto, actualReservation.TrainId);
        Assert.Equal(1, actualReservation.Seats[0].SeatNumber);
    }

    [Fact]
    public void Must_generate_a_train_reservation_with_two_seats()
    {
        var ticketOffice = new TicketOffice();
        var reserveRequest = new ReservationRequest(Titi, 2);
        var actualReservation = ticketOffice.MakeReservation(reserveRequest);

        Assert.Equal(Titi, actualReservation.TrainId);
        Assert.Equal(2, actualReservation.Seats[0].SeatNumber);
    }
}