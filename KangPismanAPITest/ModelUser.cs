using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KangPismanAPITest
{
    public class ModelUser
    {
        public string name { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public string country { get; set; }
    }

    public class ViewUser
    {
        public List<ModelUser> result { get; set; }
    }
}
