using DataAcess.Context;
using DataAcess.Modell;
using Services.DatabaseAcess.Database;
using System;
using System.Threading.Tasks;

namespace Services.DatabaseAcess.WriteToDatabase
{
    public class WriteReview : DatabaseConection, IWriteReview
    {
        /// <summary>
        /// This takes in ProductReviewModell / review giving it and guid id and add it to the database.
        /// </summary>
        /// <param name="ínputProduct"></param>
        /// <returns></returns>
        public async Task<bool> createReviewAsync(ProductReviewModell ínputProduct)
        {
            try
            {
                if (ínputProduct != null)
                {
                    ínputProduct.ReviewIDKey = Guid.NewGuid();

                    while (await validateIDToDatabaseAsync(ínputProduct) == true)
                    {
                        ínputProduct.ReviewIDKey = Guid.NewGuid();
                    }

                    ProductReviewModellContext.Productreviews.Add(ínputProduct);
                    await ProductReviewModellContext.SaveChangesAsync();

                    return true;
                }
                else
                {
                    throw new InvalidOperationException("Emty / Invalid input.");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Validating if id of in ProductReviewModell exist or not. Return an bool.
        /// </summary>
        /// <param name="ínputProduct"></param>
        /// <returns></returns>
        private async Task<bool> validateIDToDatabaseAsync(ProductReviewModell ínputProduct)
        {
            try
            {
                ProductModell PruductId = await ProductsContext.Products.FindAsync(ínputProduct.ReviewIDKey);

                while (PruductId != null)
                {
                    return true;
                }
            }
            catch
            {
                throw;
            }

            return false;
        }
    }
}
