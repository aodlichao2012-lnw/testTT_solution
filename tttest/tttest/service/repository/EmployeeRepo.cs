using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tttest.DbContexts;
using tttest.Models;

namespace tttest.service.repository
{
    public class EmployeeRepo : IEmployee
    {
        private readonly Dbcon dbcon;
        public EmployeeRepo(Dbcon dbcon)
        {
            this.dbcon = dbcon;
        }
        public void Delete(int id)
        {
            var cs = dbcon.empolyees.Find(id);
            dbcon.Remove(cs);
            dbcon.SaveChanges();
        }

        public List<Empolyee> Getall()
        {
            return dbcon.empolyees.ToList();
        }

        public Empolyee Getid(int id)
        {
            var cs = dbcon.empolyees.Find(id);
            return cs;
        }

        public void Save(Empolyee empolyee)
        {
            dbcon.empolyees.Add(empolyee);
            dbcon.SaveChanges();
        }

        public void Update(Empolyee empolyee)
        {
            dbcon.empolyees.Update(empolyee);
            dbcon.SaveChanges();
        }
    }
}
