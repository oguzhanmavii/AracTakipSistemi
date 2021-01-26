using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class AracManager
    {
      public void  Araclar(List<Ulasim> ulasim)
        {
            foreach (var ulasimAraclari in ulasim)
            {
                ulasimAraclari.ozellik();
            }
        }
    }
}
