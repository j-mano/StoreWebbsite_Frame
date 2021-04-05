using DataAcess.Modell;
using System.Threading.Tasks;

namespace Services.DatabaseAcess.WriteToDatabase
{
    public interface IWriteReview
    {
        Task<bool> createReviewAsync(ProductReviewModell ínputProduct);
    }
}
