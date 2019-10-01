using System.Collections.Generic;

namespace BroAPI
{
    public class BroList
    {
        public List<string> BroNames { get; set; }

        public BroList()
        {
            BroNames.Add("Broseph Conrad");
            BroNames.Add("Coleen Brolan");
            BroNames.Add("Alan Bromax");
            BroNames.Add("Brodo de Conteville");     
        }
    }
}