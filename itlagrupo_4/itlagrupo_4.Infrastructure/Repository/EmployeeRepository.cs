using itlagrupo_4.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Text;
using static itlagrupo_4.Domain.Entities.class1;

namespace itlagrupo_4.Infrastructure.Repository
{



    public class EmployeeRepository:BaseRepository<Employee>, IRepositoryBase<Employee>
    {


        public void Save(Employee employee)
        {

        }

   

        public List<Employee> GetAll()
        {
            
            return new List<Employee>();




    }



        public override List<Employee> GetEntities()
        {
            throw new NotImplementedException();
        }

        public override Employee GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public override void save(Employee entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
