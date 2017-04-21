using applesandoranges.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applesandoranges.Api.Contracts
{
    public interface IAppleRepo
    {
        //get one by id
        Apple GetAppleById(int id);
        //get all
        List<Apple> GetApples();
        //create one
        bool CreateApple();
    }
}
