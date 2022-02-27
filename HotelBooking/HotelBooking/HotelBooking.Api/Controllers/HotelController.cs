using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using HotelBooking.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<HotelController> logger;

        public HotelController(IHotelService iHotelService, ILogger<HotelController> logger)
        {
            this.iHotelService = iHotelService;
            this.logger = logger;
        }



        [HttpPost]
        public string CreateHotel([FromBody] Hotel hotel)
        {

            return iHotelService.CreateHotel(hotel);
        }


        [HttpGet]
        [Route("Get")]
        public ActionResult<IEnumerable< Hotel>> GetAllHotel()
        {
            try
            {
                var hotels = iHotelService.GetAllHotel();
                var hotelsService = hotels.Select(h => new Hotel
                {
                    HotelId = h.HotelId,
                    HotelName = h.HotelName,
                    HotelImage = h.HotelImage,
                    Hotelprice = h.Hotelprice,
                    HotelDiscount = h.HotelDiscount,
                    HotelDescription = h.HotelDescription,
                    HotelRank = h.HotelRank
                });
                return Ok(hotelsService);
            }
            catch(Exception ex)
            {
                logger.LogError($"Failed to get hotels: {ex} ");
                return BadRequest("FAild to get Hotels");
            }
        }

        [Route("{HotelId}")]
        [HttpDelete]
        public ActionResult  DeleteHotelByID(int HotelId)
        {
            try
            {
                var hotel = iHotelService.DeleteHotelByID(HotelId);
                if (hotel != null)
                    return Ok(hotel);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed To Delete This Hotel: {ex} ");
                return BadRequest(ex.Message);
            }
            //return iHotelService.DeleteHotelByID(HotelId);
        }

        [Route("{HotelId}")]
        [HttpGet]
        public ActionResult GetHotelById(int HotelId)
        {
            try
            {
                var hotel = iHotelService.GetHotelByID(HotelId);
                if (hotel != null)
                    return Ok(hotel);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get hotels: {ex} ");
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        public ActionResult UpdateHotel([FromBody] Hotel hotel)
        {
            try
            {
                 var hotels = iHotelService.UpdateHotel(hotel);

                if (hotels != null)
                    return Ok(hotels);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get hotels: {ex} ");
                return BadRequest("FAild to get Hotels");
            }


              
        }

        [Route("GetHotelByAddress/{hotelAddress}")]
        [HttpGet]

        public ActionResult<IEnumerable<Hotel>> GetHotelByAddress(string hotelAddress)
        {
            try
            {
                var hotels = iHotelService.GetHotelByAddress(hotelAddress);
                var hotelsService = hotels.Select(h => new Hotel
                {
                    HotelId = h.HotelId,
                    HotelName = h.HotelName,
                    HotelImage = h.HotelImage,
                    Hotelprice = h.Hotelprice,
                    HotelDiscount = h.HotelDiscount,
                    HotelDescription = h.HotelDescription,
                    HotelRank = h.HotelRank,
                    HotelAddresses=h.HotelAddresses
                });
                return Ok(hotelsService);
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get hotels: {ex} ");
                return BadRequest("Faild to get Hotels");
            }
         }
    }
}
