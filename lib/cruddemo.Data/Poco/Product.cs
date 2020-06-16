using System;
using System.Collections.Generic;
using System.Text;

namespace cruddemo.Data.Poco
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreateAt { get; set; }

        public DateTimeOffset UpdateAt { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public Currency Currency { get; set; }
    }
}
