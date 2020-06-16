using cruddemo.Data.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace cruddemo.Data.rdbms.configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        void IEntityTypeConfiguration<Product>.Configure(
            EntityTypeBuilder<Product> builder)
        {
            //builder.HasKey(p => new { p.Id }).IsClustered;
        }
    }
}
