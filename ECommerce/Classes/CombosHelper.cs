using ECommerce.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ECommerce.Classes
{
    public class CombosHelper : IDisposable
    {
        private static ECommerceContext db = new ECommerceContext();

        public static List<Department> GetDepartment()
        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Select a department...]",
            });
            return departments = departments.OrderBy(d => d.Name).ToList();

        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}