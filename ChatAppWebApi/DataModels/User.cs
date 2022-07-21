using System;
using System.Collections.Generic;

#nullable disable

namespace ChatAppWebApi.DataModels
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public bool Gender { get; set; }
        
    }
}
