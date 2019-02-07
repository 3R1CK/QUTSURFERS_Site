using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using QUTSurfers.Models;


namespace QUTSurfers.Controllers.Api
{
    public class MembersController : ApiController
    {

        private ApplicationDbContext _context;

        public MembersController()
        {
                _context = new ApplicationDbContext();
        }

        //GET /api/members
        public IEnumerable<Members> GetMembers()
        {
            return _context.Members.ToList();
        }

        //GET /api/members/1
        public Members GetMember(int id)
        {
            var member = _context.Members.SingleOrDefault(c => c.Id == id);

            if (member == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return member;
        }

        //POST /api/members
        [HttpPost]
        public Members CreateCustomer(Members member)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Members.Add(member);
            _context.SaveChanges();

            return member;
        }

        //PUT /api/members/1
        [HttpPut]
        public void UpdateCustomer(int id, Members member)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var memberInDb = _context.Members.SingleOrDefault(c => c.Id == id);

            if (memberInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            memberInDb.FirstName = member.FirstName;
            memberInDb.LastName = member.LastName;
            memberInDb.Email = member.Email;
            memberInDb.PhoneNumber = member.PhoneNumber;
            memberInDb.SurfingLevelId = member.SurfingLevelId;
            memberInDb.PaymentTypeId = member.PaymentTypeId;
            memberInDb.IntlStudent = member.IntlStudent;

            _context.SaveChanges();

        }

        //DELETE /api/members/1
        [HttpDelete]
        public void DeleteMember(int id)
        {
            var memberInDb = _context.Members.SingleOrDefault(c => c.Id == id);

            if (memberInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Members.Remove(memberInDb);
            _context.SaveChanges();

        }
    }
}
