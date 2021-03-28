using DataAcess.Modell;
using Services.DatabaseAcess.Database;
using System;
using System.Threading.Tasks;

namespace Services.DatabaseAcess.WriteToDatabase
{
    public class WriteProduct : DatabaseConection, IWriteProduct
    {
        public async Task createProductAsync(ProductModell ínputProduct)
        {
            try
            {
                if (ínputProduct != null)
                {
                    ínputProduct.productID = Guid.NewGuid();

                    while(await validateIDToDatabaseAsync(ínputProduct) == false)
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
