
    using Microsoft.EntityFrameworkCore;
    using OnlineVotingAPI.Models;

    public class VotingDbContext : DbContext
    {
        public VotingDbContext(DbContextOptions<VotingDbContext> options) : base(options) { }

        public DbSet<Election> Elections { get; set; }
        public DbSet<Voter> Voters { get; set; }
        public DbSet<Result> Results { get; set; }
    }
