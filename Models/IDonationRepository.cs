using System;
using System.Linq;

namespace WaterProject.Models
{
    public interface IDonationRepository
    {
        IQueryable<Donation> Donations { get; }

        public void SaveDonation(Donation donation);
    }
}
