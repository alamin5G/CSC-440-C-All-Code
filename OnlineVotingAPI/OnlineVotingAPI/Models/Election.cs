namespace OnlineVotingAPI.Models
{
    public class Election
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Voter> Voters { get; set; }
        public ICollection<Result> Results { get; set; }
    }
}
