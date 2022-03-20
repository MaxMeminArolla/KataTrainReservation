using System.Collections.Generic;
using Xunit;

namespace TicketOfficeService.Tests;

public class TicketOfficeTests
{
    [Fact]
    public void Must_generate_a_train_reservation()
    {
        var ticketOffice = new TicketOffice();
        var reserveRequest = new ReservationRequest("toto", 1);
        var actualReservation = ticketOffice.MakeReservation(reserveRequest);

        Assert.Equal("toto", actualReservation.TrainId);
        Assert.Single(actualReservation.Seats);
    }
}