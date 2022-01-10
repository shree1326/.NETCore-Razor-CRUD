namespace BookRazor.Model
{
    public class DBContext
    {
        private DBContextOptions<ApplicationDBContext> options;

        public DBContext(DBContextOptions<ApplicationDBContext> options)
        {
            this.options = options;
        }
    }
}