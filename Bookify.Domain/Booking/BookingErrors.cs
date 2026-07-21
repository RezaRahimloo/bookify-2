using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Domain.Booking
{
    public static class BookingErrors
    {
        public static Error NotFound = new(
            "Booking.NotFound",
            "The booking with the specific identifier was not found");

        public static Error Overlap = new(
            "Booking.Overlap",
            "The current booking is overlapping with an existing one");

        public static Error NotReserved = new(
            "Booking.NotReserved",
            "The bookking is pending");

        public static Error NotConfirmed = new(
            "Booking.NotConfirmed",
            "The booking is not confirmed");

        public static Error AlreadyStarted = new(
            "Booking.AlreadyStarted",
            "The booking has already started");

        public static Error NotPending = new(
            "Booking.NotPending",
            "The booking is not pending");
    }
}
