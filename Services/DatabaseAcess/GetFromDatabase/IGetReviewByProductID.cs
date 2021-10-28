using DataAcess.Modell;
using System;
using System.Collections.Generic;

namespace Services.DatabaseAcess.GetFromDatabase
{
    public interface IGetReviewByProductID
    {
        List<ProductReviewModell> GetReviewByProductI(Guid ProductId);
    }
}
