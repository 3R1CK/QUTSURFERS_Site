using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using QUTSurfers.Models;
using QUTSurfers.ViewModels;

namespace QUTSurfers.Controllers{
   

    public class MembersController : Controller
    {
        private ApplicationDbContext _context;

        public MembersController()
        {
                _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Students
        [Authorize(Roles = RoleName.CanManageMembersAndEvents)]
        public ActionResult Details()
        {
            var members = _context.Members
                .Include(c=>c.SurfingLevel)
                .Include(c=>c.PaymentType)
                .ToList();
           
            return View("MembersInfo", members);
        }

        public ActionResult New()
        {
            var paymentMethod = _context.PaymentMethods.ToList();
            var surfingLevels = _context.SurfingLevels.ToList();
            var viewModel = new MemberFormViewModel
            {
                PaymentType = paymentMethod,
                Student = new Members(),
                LevelOfSurfing = surfingLevels,
             
                
            };
                 return View("StudentForm",viewModel);
        }

        public ActionResult Save(Members student)
        {
            if (!ModelState.IsValid)
            {
               var viewModel = new MemberFormViewModel
               {
                   PaymentType = _context.PaymentMethods.ToList(),
                   Student = student,
                   LevelOfSurfing = _context.SurfingLevels.ToList()
                   
               };
                return View("StudentForm", viewModel);
            };

            if (student.Id == 0)
            {
                student.DateAdded = DateTime.Now;
                _context.Members.Add(student);

                _context.SaveChanges();

                return RedirectToAction("Payment", "Members");
            }

            else
            {
                var studentInDb = _context.Members.Single(c => c.Id == student.Id);
                studentInDb.FirstName = student.FirstName;
                studentInDb.LastName = student.LastName;
                studentInDb.Email = student.Email;
                studentInDb.StudentNumber = student.StudentNumber;
                studentInDb.PaymentApproval = student.PaymentApproval;
                studentInDb.PhoneNumber = student.PhoneNumber;
                studentInDb.SurfingLevelId = student.SurfingLevelId;
                studentInDb.PaymentTypeId = student.PaymentTypeId;
                studentInDb.IntlStudent = student.IntlStudent;

                _context.SaveChanges();

                return RedirectToAction("Details", "Members");
            }

           
        }

        public ActionResult Payment()
        {
            return View("MembershipPayment");
        }

        [Authorize(Roles = RoleName.CanManageMembersAndEvents)]
        public ActionResult Edit(int id)
        {
            var student = _context.Members.SingleOrDefault(c => c.Id == id);

            if (student == null)
                return HttpNotFound();

            var viewModel = new MemberFormViewModel()
            {
                Student = student,
                LevelOfSurfing = _context.SurfingLevels.ToList(),
                PaymentType = _context.PaymentMethods.ToList()
                
            };

            return View("EditMemberForm", viewModel);
        }
    }
}