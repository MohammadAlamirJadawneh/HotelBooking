using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Core.Repository
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotel();
        void CreateHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void DeleteHotelByID(int hotelId);
        Hotel GetHotelByID(int hotelId);
        List<Hotel> GetHotelByAddress(string hotelAddress);
        List<Hotel> GetHotelByRank(double hotelRank);
    }
}
