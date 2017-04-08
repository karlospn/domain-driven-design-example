﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeatReservationApp.Domain.Entities;

namespace SeatReservationApp.Domain.UniTest
{
    public class StubHelper
    {
        public static List<Seat> seatsStub = new List<Seat>
        {
            new Seat
            {
                Column = 1,
                Row = 1,
                Available = AvailabilityEnum.Booked
            },
            new Seat
            {
                Column = 1,
                Row = 2,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 2,
                Row = 1,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 2,
                Row = 2,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 3,
                Row = 1,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 3,
                Row = 2,
                Available = AvailabilityEnum.Free
            },
            new Seat
            {
                Column = 4,
                Row = 1,
                Available = AvailabilityEnum.Booked
            },
            new Seat
            {
                Column = 4,
                Row = 2,
                Available = AvailabilityEnum.Booked
            }

        };
    }
}
