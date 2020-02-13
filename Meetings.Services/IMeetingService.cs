using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meetings.Services
{
    public interface IMeetingService
    {
        Task<Meetings.Domain.Meeting> Get(int id);

        Task<Meetings.Domain.Meeting> GetAll();

        Task<Meetings.Domain.Meeting> Create();

        Task<Meetings.Domain.Meeting> Update();

        Task<Meetings.Domain.Meeting> Delete();
    }
}
