using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logics.Model
{
    public class testlistmodel
    {

        public class internalnames
        {


            public static string Title = "Title";
            public static string name = "name";
            public static string my_country = "my_x0020_country";
            public static string Created = "Created";

        }
        [DataContract]
        public class displayname
        {
            [DataMember]
            public int ID { get; set; }
            [DataMember]
            public string Title { get; set; }
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public string my_country { get; set; }
            [DataMember]
            public DateTime Created { get; set; }

        }
    }
}
