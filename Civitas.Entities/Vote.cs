using System;

namespace Civitas.Entities
{
    public class Vote
    {
        public Guid id { get; set; }

        public User Voter { get; set; }
        public string Statement { get; set; }

        /// <summary>
        /// Positive is in favour, Negative is against
        /// </summary>
        public int NumericVote{ get;set; }

        public DateTime Creation { get; set; }
    }
}