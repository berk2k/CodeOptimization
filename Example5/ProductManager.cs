using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    public class ProductManager
    {
        private string connectionString;

        public ProductManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Price = (decimal)reader["Price"]
                };
                products.Add(product);
            }

            reader.Close();
            connection.Close();
            return products;
        }

        public List<Product> GetProductByName(string productName)
        {
            List<Product> products = new List<Product>();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($"SELECT * FROM Products WHERE Name = '{productName}'", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Price = (decimal)reader["Price"]
                };
                products.Add(product);
            }

            reader.Close();
            connection.Close();

            return products;
        }
}
