using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercLogin.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {

            context.Database.EnsureCreated();

            context.SaveChanges();
        }
    }
}
