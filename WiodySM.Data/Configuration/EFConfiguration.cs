using System.Data.Entity.Migrations;
using WiodySM.Data.Model.Context;

namespace WiodySM.Data.Configuration
{
    public sealed class EFConfiguration : DbMigrationsConfiguration<WiodySMContext>
    {
        public EFConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(WiodySMContext context)
        {

        }
    }
}
