using CustomerDomain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.PersistenceDatabase.Configuration
{
    public class ClientConfiguration
    {
        public ClientConfiguration(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.HasIndex(x => x.ClientId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(500);

            // Client by default
            var clients = new List<Client>();
            var random = new Random();
            for (var i = 1; i <= 10; i++)
            {
                clients.Add(
                    new Client
                    {
                        ClientId = i,
                        Name = $"Client {i}",
                    });
            }

            entityBuilder.HasData(clients);
        }
    }
}
