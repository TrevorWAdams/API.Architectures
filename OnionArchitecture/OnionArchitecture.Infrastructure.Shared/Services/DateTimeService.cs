using System;
using OnionArchitecture.Application.Interfaces;

namespace OnionArchitecture.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
