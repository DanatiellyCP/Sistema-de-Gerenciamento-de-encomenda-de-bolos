using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cake
{
    class oleDbDataAdapter
    {
        private string p;
        private string connect_string;

        public oleDbDataAdapter(string p, string connect_string)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.connect_string = connect_string;
        }

        internal void Fill(System.Data.DataSet BolosDataSet, string p)
        {
            throw new NotImplementedException();
        }
    }
}
