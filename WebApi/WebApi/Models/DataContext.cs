

namespace WebApi.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApi.Models.Phone> Phones { get; set; }
    }
}