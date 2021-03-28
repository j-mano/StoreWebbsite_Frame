using DataAcess.Modell;
using Services.DatabaseAcess.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.DatabaseAcess.GetFromDatabase
{
    public class GetReviewByProductID : DatabaseConection, IGetReviewByProductID
    {
        List<ProductReviewModell> ProductReviews = new List<ProductReviewModell>();
        List<ProductReviewModell> ReturnProductReviews = new List<ProductReviewModell>();

        /// <summary>
        /// Return an list of review of an inputed productid.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public List<ProductReviewModell> GetReviewByProductI(Guid ProductId)
        {
            try
            {
                Task AsynGetStoreTask = Task.Run(() =>
                {
                    ProductReviews = (from ProductReviews in ProductReviewModellContext.Productreviews select ProductReviews).ToList();
                });

                AsynGetStoreTask.Wait();

                foreach (ProductReviewModell review in ProductReviews)
                {
                    if(review.ProductIDKey == ProductId)
                    {
                        ReturnProductReviews.Add(review);
                    }
                }

                return ReturnProductReviews;
            }
            catch
            {
                throw;
            }
        } 
    }
}
