using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingApi.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }// foreign key
        public Country Country { get; set; }
    }

   
}
