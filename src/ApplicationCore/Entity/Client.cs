using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entity
{
    public class Client
    {
        public Client()
        {

        }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
    }
}
