using applesandoranges.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applesandoranges.Api.Contracts
{
    public interface IOrangeRepo
    {
        //get one by id
        Orange GetOrangeById(int id);
        //get all
        List<Orange> GetOranges();
        //create one
        bool CreateOrange();
    }
}
