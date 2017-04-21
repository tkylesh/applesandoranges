using applesandoranges.Api.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using applesandoranges.Api.Models;

namespace applesandoranges.Api.DAL
{
    public class AppleRepo : IAppleRepo
    {
        public bool CreateApple()
        {
            throw new NotImplementedException();
        }

        public Apple GetAppleById(int id)
        {
            if (id == 0) return null;

            return new Apple
            {
                Name = "Clementine",
                Cost = 7,
                Quantity = 10
            };
        }

        public List<Apple> GetApples()
        {
            throw new NotImplementedException();
        }
    }
}