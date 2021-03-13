using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tttest.Models;

namespace tttest.service
{
    public interface IEmployee
    {
        List<Empolyee> Getall();
        Empolyee Getid(int id);
        void Update(Empolyee empolyee);
        void Save(Empolyee empolyee);
        void Delete(int id);
    }
}
