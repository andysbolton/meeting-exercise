using System;
using System.Threading.Tasks;
using Meetings.Data;

namespace Meetings.Services
{
    public class MeetingsService : IMeetingService
    {
        private readonly MeetingsContext _context;

        public MeetingsService(MeetingsContext context)
        {
            this._context = context;
        }

        public async Task<Meetings.Domain.Meeting> Get(int id)
        {
            return await this._context.Meetings.FindAsync(id);
        }

        public async Task<Meetings.Domain.Meeting> GetAll()
        {
            return null;
        }

        public async Task<Meetings.Domain.Meeting> Create()
        {
            return null;
        }

        public async Task<Meetings.Domain.Meeting> Update()
        {
            return null;
        }

        public async Task<Meetings.Domain.Meeting> Delete()
        {
            return null;
        }
    }
}
