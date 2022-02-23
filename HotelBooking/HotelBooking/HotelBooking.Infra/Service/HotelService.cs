using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using HotelBooking.Core.Repository;
using HotelBooking.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Infra.Service
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository iHotelRepository;

        public HotelService(IHotelRepository iHotelRepository)
        {
            this.iHotelRepository = iHotelRepository;
        }
        public string CreateHotel(Hotel hotel)
        {
            iHotelRepository.CreateHotel(hotel);
            return "successfully";
        }

        public string DeleteHotelByID(int hotelId)
        {

            iHotelRepository.DeleteHotelByID(hotelId);
            return "Deleted";
        }

        public List<Hotel> GetAllHotel()
        {
            return iHotelRepository.GetAllHotel();
        }

        public List<Hotel> GetHotelByAddress(string hotelAddress)
        {
            return iHotelRepository.GetHotelByAddress(hotelAddress);
        }

        public Hotel GetHotelByID(int hotelId)
        {
            return iHotelRepository.GetHotelByID(hotelId);
        }

        public string UpdateHotel(Hotel hotel)
        {
            iHotelRepository.UpdateHotel(hotel);

            return "Updated";
        }


    }
}
