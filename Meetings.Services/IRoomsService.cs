using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Meetings.Services
{
    public interface IRoomsService
    {
        Task<Meetings.Domain.Room> GetAll();

        Task<Meetings.Domain.Room> GetAllAvailable();

        Task<Meetings.Domain.Room> Create();

        Task<Meetings.Domain.Room> Update();

        Task<Meetings.Domain.Room> Delete();
    }
}
