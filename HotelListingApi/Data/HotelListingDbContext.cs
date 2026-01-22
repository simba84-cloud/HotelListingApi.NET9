using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options ): base( options ) 
        {
            
        }
    }
}
