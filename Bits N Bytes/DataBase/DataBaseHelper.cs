using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Collections.Generic;

namespace Bits_N_Bytes.Database
{
    public static class DatabaseHelper
    {
        private static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "BitsNBytes.db");

        private static readonly string ConnectionString =
            $"Data Source={DbPath}";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }



        public static void ClearCart2()
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM Cart";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        public static void InitializeDatabase()
        {





            using var connection = GetConnection();
            connection.Open();

            using var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Products";

            MessageBox.Show("Products in database: " + cmd.ExecuteScalar());

            string folder = Path.GetDirectoryName(DbPath)!;


            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

           

            string createProductsTable = @"
            CREATE TABLE IF NOT EXISTS Products(
                ProductID INTEGER PRIMARY KEY AUTOINCREMENT,
                ProductName TEXT NOT NULL,
                Brand TEXT,
                Category TEXT,
                Price REAL NOT NULL,
                Stock INTEGER NOT NULL,
                Image TEXT
            );";

            string createCartTable = @"
            CREATE TABLE IF NOT EXISTS Cart(
            CartID INTEGER PRIMARY KEY AUTOINCREMENT,
            ProductName TEXT NOT NULL,
            Description TEXT,
            Price REAL NOT NULL,
            Quantity INTEGER NOT NULL
            );";



            string sql = @"
CREATE TABLE IF NOT EXISTS Users
(
    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL,
    Password TEXT NOT NULL,
    Role TEXT NOT NULL
);";

            using var command = connection.CreateCommand();

            command.CommandText = createProductsTable;
            command.ExecuteNonQuery();

            command.CommandText = createCartTable;
            command.ExecuteNonQuery();

            command.CommandText = sql;
            command.ExecuteNonQuery();

            // Ensure legacy databases get the new columns without recreating the table.
            // Check existing columns in Products and add Brand/Category if missing.
            using var checkCmd = connection.CreateCommand();
            checkCmd.CommandText = "PRAGMA table_info('Products');";
            using var reader = checkCmd.ExecuteReader();

            var existingColumns = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            while (reader.Read())
            {
                existingColumns.Add(reader.GetString(reader.GetOrdinal("name")));
            }
            reader.Close();

            if (!existingColumns.Contains("Brand"))
            {
                using var addBrand = connection.CreateCommand();
                addBrand.CommandText = "ALTER TABLE Products ADD COLUMN Brand TEXT;";
                addBrand.ExecuteNonQuery();
            }

            if (!existingColumns.Contains("Category"))
            {
                using var addCategory = connection.CreateCommand();
                addCategory.CommandText = "ALTER TABLE Products ADD COLUMN Category TEXT;";
                addCategory.ExecuteNonQuery();
            }

        }
        public static void AddProduct(string name, decimal price, int stock, string image, string brand = null, string category = null)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
        INSERT INTO Products
        (ProductName, Brand, Category, Price, Stock, Image)
        VALUES
        (@name, @brand, @category, @price, @stock, @image);";

            using var command = connection.CreateCommand();

            command.CommandText = sql;

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@brand", (object)brand ?? DBNull.Value);
            command.Parameters.AddWithValue("@category", (object)category ?? DBNull.Value);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@stock", stock);
            command.Parameters.AddWithValue("@image", image);

            command.ExecuteNonQuery();
        }
        public static void AddToCart(string productName, string description, decimal price)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
         INSERT INTO Cart
         (ProductName, Description, Price, Quantity)
         VALUES
         (@productName, @description, @price, 1);";

            using var command = connection.CreateCommand();

            command.CommandText = sql;

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@price", price);

            command.ExecuteNonQuery();
        }

        public static System.Data.DataTable GetCartItems()
        {
            System.Data.DataTable table = new();

            using var connection = GetConnection();
            connection.Open();

            string sql = @"
               SELECT
               CartID,
               ProductName,
               Description,
               Price,
               Quantity
               FROM Cart";

            using var command = connection.CreateCommand();
            command.CommandText = sql;

            using var reader = command.ExecuteReader();

            table.Load(reader);

            return table;
        }

        public static void ClearCart()
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = "DELETE FROM Cart;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;

            command.ExecuteNonQuery();
        }

        public static void IncreaseQuantity(int cartId)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
            UPDATE Cart
            SET Quantity = Quantity + 1
            WHERE CartID = @id;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", cartId);

            command.ExecuteNonQuery();
        }

        public static void DecreaseQuantity(int cartId)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
    DELETE FROM Cart
    WHERE CartID = @id
    AND Quantity = 1;

    UPDATE Cart
    SET Quantity = Quantity - 1
    WHERE CartID = @id
    AND Quantity > 1;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", cartId);

            command.ExecuteNonQuery();
        }
    }



}