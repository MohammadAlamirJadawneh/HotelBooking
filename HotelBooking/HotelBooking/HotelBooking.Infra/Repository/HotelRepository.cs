using HotelBooking.Core.Data;
using HotelBooking.Core.DTO;
using HotelBooking.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Infra.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly DataContext dataContext;

        public HotelRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void CreateHotel(Hotel hotel)
        {

            Hotel hotel1 = new Hotel();
            hotel1.HotelId = hotel.HotelId;
            hotel1.HotelName = hotel.HotelName;
            hotel1.HotelImage = hotel.HotelImage;
            hotel1.Hotelprice = hotel.Hotelprice;
            hotel1.HotelDescription = hotel.HotelDescription;
            hotel1.HotelDiscount = hotel.HotelDiscount;
            hotel1.HotelRank = hotel.HotelRank;
            hotel.HotelAddresses = hotel.HotelAddresses;
            dataContext.Hotels.Add(hotel1); /**/
            dataContext.SaveChanges();
        }

        public void DeleteHotelByID(int hotelId)
        {
            dataContext.Remove(dataContext.Hotels.FirstOrDefault(a => a.HotelId == hotelId));
            dataContext.SaveChanges();
        }

        public List<Hotel> GetAllHotel()
        {
            var result = dataContext.Hotels.ToList(); /**/
            return result;



        }

        public List<Hotel> GetHotelByAddress(string hotelAddress)
        {

            var Result = dataContext.Hotels.Where(x => x.HotelAddresses.Where(y => y.HotelAddressCity.Equals(hotelAddress)).Any());

            return Result.ToList();
        }


        public Hotel GetHotelByID(int hotelId)
        {
            var hotels = dataContext.Hotels;

            //Hotel hotel = dataContext.Hotels.Where(val => val.HotelId == hotelId).Select(val => new Hotel()


            Hotel hotel = hotels.Where(val => val.HotelId == hotelId).Select(val => new Hotel()
            {
                HotelId = val.HotelId,
                HotelName = val.HotelName,
                HotelDescription = val.HotelDescription,
                Hotelprice = val.Hotelprice,
                HotelDiscount = val.HotelDiscount,
                HotelImage = val.HotelImage,
                HotelRank = val.HotelRank,
                HotelAddresses = val.HotelAddresses


            }).SingleOrDefault();

            return hotel;
        }

        public List<Hotel> GetHotelByRank(double hotelRank)
        {
            IEnumerable<Hotel> hotel = dataContext.Hotels.Where(val => val.HotelRank == hotelRank).Select(val => new Hotel()
            {
                HotelId = val.HotelId,
                HotelName = val.HotelName,
                HotelDescription = val.HotelDescription,
                Hotelprice = val.Hotelprice,
                HotelDiscount = val.HotelDiscount,
                HotelImage = val.HotelImage,
                HotelRank = val.HotelRank,
                HotelAddresses = val.HotelAddresses


            }).ToList();

            return hotel.ToList();

        }

        public void UpdateHotel(Hotel hotel)
        {
            dataContext.Update(hotel);
            dataContext.SaveChanges();
        }


    }


}
