﻿using CRUD.data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CRUD.Controllers
{
    public class EmployeesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View("Index", employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Store(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("Index");


        }
        public IActionResult Edit(int id )
        {
            var employee = context.Employees.Find(id);

            return View(employee);
        }
        public IActionResult Update(Employee emp) {
            var employee = context.Employees.Find(emp.Id);

            employee.Name = emp.Name;
            employee.Email = emp.Email;
            employee.Password=emp.Password;

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var employee = context.Employees.Find(id);
            context.Employees.Remove(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
