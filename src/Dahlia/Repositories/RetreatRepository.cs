using System;
using System.Collections.Generic;
using Dahlia.Models;

namespace Dahlia.Repositories
{
    public interface IRetreatRepository
    {
        IEnumerable<Retreat> GetList();
        void Add(Retreat retreat);
    }

    public class RetreatRepository : IRetreatRepository
    {
        static ICollection<Retreat> _Retreats;

        static RetreatRepository()
        {
            _Retreats = new List<Retreat>
            {
                new Retreat { StartDate = new DateTime(2011, 4, 1)},
                new Retreat { StartDate = new DateTime(2011, 6, 1)},
                new Retreat { StartDate = new DateTime(2011, 7, 15)},
            };
        }

        IEnumerable<Retreat> IRetreatRepository.GetList()
        {
            return _Retreats;
        }

        void IRetreatRepository.Add(Retreat retreat)
        {
            _Retreats.Add(retreat);
        }
    }
}