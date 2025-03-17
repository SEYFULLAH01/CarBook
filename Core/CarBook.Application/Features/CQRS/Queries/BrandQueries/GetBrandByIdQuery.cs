using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {
        public int BrandID { get; set; }

        public GetBrandByIdQuery(int brandID)
        {
            BrandID = brandID;
        }
    }
}
