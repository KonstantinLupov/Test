using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Whatever.Data;
using Whatever.Models;

namespace Whatever.Controllers
{
    public class TeamController : Controller
    {
        private WhateverDbContext db;

        public TeamController(WhateverDbContext db)
        {
            this.db = db;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Team model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                Team team = new Team()
                {
                    TeamName = model.TeamName,
                    FirstPlayerClass = model.FirstPlayerClass,
                    FirstPlayerEmail = model.FirstPlayerEmail,
                    FirstPlayerName = model.FirstPlayerName,
                    FirstPlayerPhoneNumber = model.FirstPlayerPhoneNumber,
                    FirstPlayerSchool = model.FirstPlayerSchool,
                    SecondPlayerClass = model.SecondPlayerClass,
                    SecondPlayerEmail = model.SecondPlayerEmail,
                    SecondPlayerName = model.SecondPlayerName,
                    SecondPlayerPhoneNumber = model.SecondPlayerPhoneNumber,
                    SecondPlayerSchool = model.SecondPlayerSchool
                };

                this.db.Teams.Add(team);
                this.db.SaveChanges();
                return RedirectToAction(nameof(Successful));
            }
            // return RedirectToAction(nameof(Register));
        }

        public IActionResult Successful()
        {
            return View();
        }
    }
}