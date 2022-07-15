﻿using System;

namespace WPF_MVVM_HotelReservation.Models
{
    public class Reservation
    {
        public RoomId RoomId { get; }
        public string Username { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(RoomId roomId, string username, DateTime startTime, DateTime endTime)
        {
            RoomId = roomId;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
