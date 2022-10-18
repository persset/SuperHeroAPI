using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data {
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Needed for the dataset to appear as a table on SQL Management Studio or Whatever u use.
        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();

    }
}
