using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Contracts
{
    public interface IDeveloperService
    {
        Task<Developer[]> GetDevelopers();
    }
}
