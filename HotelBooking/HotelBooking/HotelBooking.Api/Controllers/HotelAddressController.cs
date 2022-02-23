using HotelBooking.Core.Data;
using HotelBooking.Core.Service;
using HotelBooking.Infra.Service;
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
    public class HotelAddressController : ControllerBase
    {
        private readonly IHotelAddressService iHotelAddressService;
        public HotelAddressController(IHotelAddressService iHotelAddressService)
        {
            this.iHotelAddressService = iHotelAddressService;
        }



        [HttpPost]
        public string CreateHotelAddress([FromBody] HotelAddress hotelAddress)
        {

            return iHotelAddressService.CreateHotelAddress(hotelAddress);
        }


        [HttpGet]
        public List<HotelAddress> GetAllHotelAddress()
        {
            return iHotelAddressService.GetAllHotelAddress();
        }

        [Route("{HotelAddressId}")]
        [HttpDelete]
        public string DeleteHotelAddressByID(int HotelAddressId)
        {
            return iHotelAddressService.DeleteHotelAddressByID(HotelAddressId);
        }

        [Route("{HotelAddressId}")]
        [HttpGet]
        public HotelAddress GetHotelAddressById(int hotelAddressId)
        {
            return iHotelAddressService.GetHotelAddressByID(hotelAddressId);
        }

        [HttpPut]
        public string UpdateHotel([FromBody] HotelAddress hotelAddress)
        {
            return iHotelAddressService.UpdateHotelAddress(hotelAddress);
        }
    }
}
