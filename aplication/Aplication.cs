using Services.DatabaseAcess.GetFromDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreWebbsite_Frame.aplication
{
        public class Aplication : IAplication
        {
            IGetProduct _CordinatesModells;

            public Aplication(IGetProduct CordinatesModells)
            {
                _CordinatesModells = CordinatesModells;
            }

            public void Run()
            {
                _CordinatesModells.GetProduct();
            }
        }
}