using System;
using Microsoft.AspNetCore.Mvc;

namespace Meetings.Web.Controllers
{
    [Route("api/meetings")]
    public class MeetingsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        // Should return a single meeting by it's id, or return a 404 if the meeting doesn't exist
        public IActionResult GetMeeting()
        {
            throw new NotImplementedException();
        }

        // Should return a list of meetings the user has been invited to or chaired
        public IActionResult GetMeetings()
        {
            throw new NotImplementedException();
        }

        // Creates a new meeting with current user designated as the chair and accept a list of invitees
        public IActionResult CreateMeeting()
        {
            throw new NotImplementedException();
        }

        // Updates an existing meeting
        public IActionResult UpdateMeeting()
        {
            throw new NotImplementedException();
        }

        // Delete and existing meeting
        public IActionResult DeleteMeeting()
        {
            throw new NotImplementedException();
        }
    }
}