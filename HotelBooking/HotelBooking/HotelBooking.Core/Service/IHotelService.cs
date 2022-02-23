using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Core.Service
{
   public interface IHotelService
    {
        List<Hotel> GetAllHotel();//Stored in Repository GetAllHotel
        string CreateHotel(Hotel hotel);//Stored in Repository InsertHotel
        string UpdateHotel(Hotel hotel);//Stored in Repository UpdateHotel
        string DeleteHotelByID(int hotelId);//Stored in Repository DeleteHotelByID
        Hotel GetHotelByID(int hotelId);//Stored in Repository GetHotelByID
        List<Hotel> GetHotelByAddress(string hotelAddress);//Stored in Repository GetHotelByAddress 

    }
}
