namespace OnlineVotingAPI.Models
{
    public class Voter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VoterId { get; set; } // Unique identifier
        public int ElectionId { get; set; }
        public Election Election { get; set; }
        public int? VotedForCandidateId { get; set; } // Nullable, as they may not have voted yet
    }
}
