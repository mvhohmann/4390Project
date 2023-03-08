using System;
using Microsoft.EntityFrameworkCore;

namespace Project // You can use any namespace you like. Remember to add the using directive to Program.cs
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
			: base(options)
		{
		}
    }
}