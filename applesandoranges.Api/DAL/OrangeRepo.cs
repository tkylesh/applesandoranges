using applesandoranges.Api.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using applesandoranges.Api.Models;

namespace applesandoranges.Api.DAL
{
    public class OrangeRepo : IOrangeRepo
    {
        public bool CreateOrange()
        {
            throw new NotImplementedException();
        }

        public Orange GetOrangeById(int id)
        {
            if (id == 0) return null;

            return new Orange
            {
                Name = "Clementine",
                Cost = 5,
                Quantity = 10
            };
        }

        public List<Orange> GetOranges()
        {
            throw new NotImplementedException();
        }
    }
}