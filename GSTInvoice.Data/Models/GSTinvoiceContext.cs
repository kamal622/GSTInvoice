using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GSTInvoice.Data.Models.Mapping;

namespace GSTInvoice.Data.Models
{
    public partial class GSTinvoiceContext : DbContext
    {
        static GSTinvoiceContext()
        {
            Database.SetInitializer<GSTinvoiceContext>(null);
        }

        public GSTinvoiceContext()
            : base("Name=GSTinvoiceContext")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountBankDetail> AccountBankDetails { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceTransaction> InvoiceTransactions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TaxableRate> TaxableRates { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new AccountBankDetailMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new InvoiceTransactionMap());
            modelBuilder.Configurations.Add(new ItemMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TaxableRateMap());
            modelBuilder.Configurations.Add(new UnitOfMeasurementMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserTypeMap());
        }
    }
}
