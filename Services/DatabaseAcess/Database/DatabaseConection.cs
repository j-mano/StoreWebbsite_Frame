using DataAcess.Context;

namespace Services.DatabaseAcess.Database
{
    /// <summary>
    /// Connection to all contexts on the database.
    /// </summary>
    public class DatabaseConection
    {
        public static ManagerContext ManagersContext                         = new ManagerContext();
        public static ProductReviewModellContext ProductReviewModellContext  = new ProductReviewModellContext();
        public static ProductContext ProductsContext                         = new ProductContext();
        public static StoreContext StoresContext                             = new StoreContext();
    }
}
