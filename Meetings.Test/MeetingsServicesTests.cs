using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Meetings.Data;
using Meetings.Domain;

namespace Meetings.Test
{
    [TestClass]
    public class MeetingsServicesTests
    {
        private Data.MeetingsContext _context;

        [TestInitialize]
        public async Task Initialize()
        {
            var options = new DbContextOptionsBuilder<MeetingsContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

            // Run the test against one instance of the context
            var context = new Data.MeetingsContext(options);
            context.Meetings.Add(new Meeting
            {
                Id = 1,
                Name = "Test meeting",
                Description = "A meeting for testing",
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now.AddMinutes(5),
                Room = new Room
                {
                    Name = "First Room",
                    MaxOccupancy = 5
                },
            });

            await context.SaveChangesAsync();

            this._context = context;
        }

        [TestMethod]
        public async Task GetSingleRoom_ShouldReturnTheCorrectRoom()
        {
            var meetingsService = new Services.MeetingsService(this._context);

            var result = await meetingsService.Get(1);

            Assert.IsNotNull(result);
            Assert.AreEqual<int>(result.Id, 1);
            Assert.AreEqual<string>(result.Name, "Test meeting");
        }
    }
}
