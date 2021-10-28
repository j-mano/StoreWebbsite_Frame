using DataAcess.Modell;
using Services.DatabaseAcess.Database;
using System;
using System.Threading.Tasks;

namespace Services.DatabaseAcess.WriteToDatabase
{
    public class WriteProduct : DatabaseConection, IWriteProduct
    {
        /// <summary>
        /// This takes in productmodell / product giving it and guid id and add it to the database.
        /// </summary>
        /// <param name="ínputProduct"></param>
        /// <returns></returns>
        public async Task createProductAsync(ProductModell ínputProduct)
        {
            try
            {
                if (ínputProduct != null)
                {
                    ínputProduct.productID = Guid.NewGuid();

                    while(await validateIDToDatabaseAsync(ínputProduct) == true)
                    {
                        ínputProduct.productID = Guid.NewGuid();
                    }

                    ProductsContext.Products.Add(ínputProduct);
                    await ProductsContext.SaveChangesAsync();
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
        /// Validating if id of in ProductModell exist or not. Return an bool.
        /// </summary>
        /// <param name="ínputProduct"></param>
        /// <returns></returns>
        private async Task<bool> validateIDToDatabaseAsync(ProductModell ínputProduct)
        {
            try
            {
                ProductModell PruductId = await ProductsContext.Products.FindAsync(ínputProduct.productID);

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
