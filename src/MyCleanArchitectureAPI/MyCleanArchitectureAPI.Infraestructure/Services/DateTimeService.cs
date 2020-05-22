using MyDevPortfolioAPI.Application.Common.Interfaces;
using System;

namespace MyDevPortfolioAPI.Infraestructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
