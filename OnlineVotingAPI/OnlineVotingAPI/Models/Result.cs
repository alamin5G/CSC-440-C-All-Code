namespace OnlineVotingAPI.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int ElectionId { get; set; }
        public Election Election { get; set; }
        public int CandidateId { get; set; }
        public int VoteCount { get; set; }
    }
}
