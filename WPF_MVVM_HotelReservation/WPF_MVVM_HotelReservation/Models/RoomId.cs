using System;
using System.Windows.Controls.Primitives;

namespace WPF_MVVM_HotelReservation.Models
{
    public class RoomId
    {
        public int FloorNumber { get; }

        public int RoomNumber { get; }

        public RoomId(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override bool Equals(object obj)
        {
            return obj is RoomId roomId &&
                   FloorNumber == roomId.FloorNumber &&
                   RoomNumber == roomId.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public override string ToString()
        {
            return $"{FloorNumber} : {RoomNumber}";
        }

        public static bool operator ==(RoomId firstRoomId, RoomId secondRoomId)
        {
            if (firstRoomId is null && secondRoomId is null)
            {
                return true;
            }

            return !(firstRoomId is null) && firstRoomId.Equals(secondRoomId);
        }

        public static bool operator !=(RoomId firstRoomId, RoomId secondRoomId)
        {
            return !(firstRoomId == secondRoomId);
        }

    }
}
