using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using HotelBooking.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService iHotelService;
        public HotelController(IHotelService iHotelService)
        {
            this.iHotelService = iHotelService;
        }



        [HttpPost]
        public string CreateHotel([FromBody] Hotel hotel)
        {

            return iHotelService.CreateHotel(hotel);
        }


        [HttpGet]
        [Route("Get")]
        public List<Hotel> GetAllHotel()
        {
            return iHotelService.GetAllHotel();
        }

        [Route("{HotelId}")]
        [HttpDelete]
        public string DeleteHotelByID(int HotelId)
        {
            return iHotelService.DeleteHotelByID(HotelId);
        }

        [Route("{HotelId}")]
        [HttpGet]
        public Hotel GetHotelById(int HotelId)
        {
            return iHotelService.GetHotelByID(HotelId);
        }

        [HttpPut]
        public string UpdateHotel([FromBody] Hotel hotel)
        {
            return iHotelService.UpdateHotel(hotel);
        }

        [Route("GetHotelByAddress/{hotelAddress}")]
        [HttpGet]

        public List<Hotel> GetHotelByAddress(string hotelAddress)
        {
            return iHotelService.GetHotelByAddress(hotelAddress);
        }
    }
}
