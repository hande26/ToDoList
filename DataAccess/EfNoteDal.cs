using Core;
using Core.DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EfNoteDal : EfEntityRepositoryBase<Note, ToDoContext>, INoteDal
    {
        
    }
}
