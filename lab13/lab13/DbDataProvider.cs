using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    public class DbDataProvider: IDataProvider
    {
        public DbDataProvider(Context context)
        {
            Context = context;
        }

        public Context Context { get; set; }



        public int GetData()
        {
            return Context.Models.FirstOrDefault().Amount;
        }
    }
}
