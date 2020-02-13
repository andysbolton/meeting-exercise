using System;
using Microsoft.AspNetCore.Mvc;

namespace Meetings.Web.Controllers
{
    [Route("api/rooms")]
    public class RoomsController : Controller
    {
        // Creates a new room
        public IActionResult CreateRoom()
        {
            throw new NotImplementedException();
        }

        // Updates information about a specified room
        public IActionResult UpdateRoom()
        {
            throw new NotImplementedException();
        }

        // Deletes the specified room and any meetings scheduled
        public IActionResult DeleteRoom()
        {
            throw new NotImplementedException();
        }

        // Returns a list of all rooms
        public IActionResult GetRooms()
        {
            throw new NotImplementedException();
        }

        // Should return a list of rooms that are available when compared to a start and end datetime
        public IActionResult GetAvailableRooms()
        {
            throw new NotImplementedException();
        }

    }
}