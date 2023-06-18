using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlagrupo_4.Infrastructure.@interface
{
    public interface IemployeeRepository : IRepositoryBase<class1>
    {
        void Add(class1 entity);

        List<EmployeeRepository> GetEmployeesByDepartment(int EmployeeId)
        {
            throw new NotImplementedException();
        }
    }
}
