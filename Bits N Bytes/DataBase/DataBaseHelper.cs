using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

            string folder = Path.GetDirectoryName(DbPath)!;


            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            using var connection = GetConnection();
            connection.Open();

           
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
                ProductID INTEGER NOT NULL,
                ProductName TEXT NOT NULL,
                Description TEXT,
                Price REAL NOT NULL,
                Quantity INTEGER NOT NULL
            );";

            string sql = @"
            CREATE TABLE IF NOT EXISTS Users
          (
            UserID INTEGER PRIMARY KEY AUTOINCREMENT,
            Username TEXT NOT NULL UNIQUE,
            Password TEXT NOT NULL,
            Role TEXT NOT NULL
          );";

            string createReceiptsTable = @"
CREATE TABLE IF NOT EXISTS Receipts(
    ReceiptID INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL,
    ProductName TEXT NOT NULL,
    Quantity INTEGER NOT NULL,
    Price REAL NOT NULL,
    Total REAL NOT NULL,
    PurchaseDate TEXT NOT NULL
);";


            using var command = connection.CreateCommand();

            command.CommandText = createProductsTable;
            command.ExecuteNonQuery();

            command.CommandText = createCartTable;
            command.ExecuteNonQuery();

            command.CommandText = sql;
            command.ExecuteNonQuery();

            command.CommandText = createReceiptsTable;
            command.ExecuteNonQuery();

            using var adminCommand = connection.CreateCommand();

            adminCommand.CommandText = @"
            INSERT OR IGNORE INTO Users
            (Username, Password, Role)
            VALUES
            ('admin', 'admin123', 'Admin');";

            adminCommand.ExecuteNonQuery();

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

            // Check if product already exists
            string checkSql = "SELECT COUNT(*) FROM Products WHERE ProductName = @name;";

            using var checkCommand = connection.CreateCommand();
            checkCommand.CommandText = checkSql;
            checkCommand.Parameters.AddWithValue("@name", name);

            long count = (long)checkCommand.ExecuteScalar();

            if (count > 0)
                return;

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


        public static void AddToCart(int productId, string productName, string description, decimal price)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
                INSERT INTO Cart
                (ProductID, ProductName, Description, Price, Quantity)
                VALUES
                (@productId, @productName, @description, @price, 1);";

            using var command = connection.CreateCommand();

            command.CommandText = sql;

            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@price", price);

            command.ExecuteNonQuery();
        }


        public static void SaveCartReceipt(string username)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
    INSERT INTO Receipts
    (Username, ProductName, Quantity, Price, Total, PurchaseDate)
    SELECT
        @user,
        ProductName,
        Quantity,
        Price,
        Quantity * Price,
        @date
    FROM Cart;";

            using var command = connection.CreateCommand();

            command.CommandText = sql;

            command.Parameters.AddWithValue("@user", username);
            command.Parameters.AddWithValue("@date",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            command.ExecuteNonQuery();
        }


        public static DataTable GetRecentPurchases()
        {
            DataTable table = new();

            using var connection = GetConnection();
            connection.Open();

          



            string sql = @"
SELECT
    Username,
    ProductName,
    Quantity,
    Price,
    Total,
    PurchaseDate
FROM Receipts
ORDER BY PurchaseDate DESC; ";

            using var command = connection.CreateCommand();

            command.CommandText = sql;
            

            using var reader = command.ExecuteReader();

            table.Load(reader);

          

            return table;
        }

        public static int GetStock(int productId)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
             SELECT Stock
             FROM Products
             WHERE ProductID = @id;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", productId);

            object result = command.ExecuteScalar();

            if (result != null)
                return Convert.ToInt32(result);

            return 0;
        }

        public static void DecreaseStock(int productId)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
                UPDATE Products
                SET Stock = Stock - 1
                WHERE ProductID = @id
                AND Stock > 0;";

            using var command = connection.CreateCommand();

            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", productId);

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

        public static System.Data.DataTable GetProducts()
        {
            System.Data.DataTable table = new();

            using var connection = GetConnection();
            connection.Open();

            string sql = @"
                SELECT
                ProductID,
                ProductName,
                Price,
                Stock
                FROM Products;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;

            using var reader = command.ExecuteReader();

            table.Load(reader);

            return table;
        }

        public static string LoginUser(string username, string password)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
            SELECT Role
            FROM Users
            WHERE Username = @username
            AND Password = @password;";

            using var command = connection.CreateCommand();

            command.CommandText = sql;
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            var result = command.ExecuteScalar();

            if (result != null)
                return result.ToString();

            return null;
        }

        public static bool RegisterUser(string username, string password)
        {
            using var connection = GetConnection();
            connection.Open();

            // Check if username already exists
            string checkSql = "SELECT COUNT(*) FROM Users WHERE Username = @username;";

            using var checkCommand = connection.CreateCommand();
            checkCommand.CommandText = checkSql;
            checkCommand.Parameters.AddWithValue("@username", username);

            long count = (long)checkCommand.ExecuteScalar();

            if (count > 0)
            {
                return false;
            }

            //Insert new user
            string insertSql = @"
            INSERT INTO Users
            (Username, Password, Role)
            VALUES
            (@username, @password, 'User');";

            using var insertCommand = connection.CreateCommand();

            insertCommand.CommandText = insertSql;
            insertCommand.Parameters.AddWithValue("@username", username);
            insertCommand.Parameters.AddWithValue("@password", password);

            insertCommand.ExecuteNonQuery();

            return true;
        }

        //ADMIN PANEL SEARCH PRODUCT FUNCTION
        public static System.Data.DataTable SearchProduct(int productId)
        {
            System.Data.DataTable table = new();

            using var connection = GetConnection();
            connection.Open();

            string sql = @"
            SELECT
            ProductID,
            ProductName,
            Price,
            Stock
            FROM Products
            WHERE ProductID = @id;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", productId);

            using var reader = command.ExecuteReader();

            table.Load(reader);

            return table;
        }

        

        public static void UpdateStock(int productId, int newStock)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
            UPDATE Products
            SET Stock = @stock
            WHERE ProductID = @id;";

            using var command = connection.CreateCommand();

            command.CommandText = sql;
            command.Parameters.AddWithValue("@stock", newStock);
            command.Parameters.AddWithValue("@id", productId);

            command.ExecuteNonQuery();
        }

        public static int GetProductIdFromCart(int cartId)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
                SELECT ProductID
                FROM Cart
                WHERE CartID = @id;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", cartId);

            object result = command.ExecuteScalar();

            if (result != null)
                return Convert.ToInt32(result);

            return 0;
        }

        public static void IncreaseStock(int productId)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
                UPDATE Products
                SET Stock = Stock + 1
                WHERE ProductID = @id;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", productId);

            command.ExecuteNonQuery();
        }

        //FIX CLEAR CART-STOCK FUNCTION BUG
        public static DataTable GetCartItemsForRestock()
        {
            DataTable table = new();

            using var connection = GetConnection();
            connection.Open();

            string sql = @"
            SELECT ProductID, Quantity
            FROM Cart;";

            using var command = connection.CreateCommand();
            command.CommandText = sql;

            using var reader = command.ExecuteReader();
            table.Load(reader);

            return table;
        }

        public static void IncreaseStockByAmount(int productId, int amount)
        {
            using var connection = GetConnection();
            connection.Open();

            string sql = @"
            UPDATE Products
            SET Stock = Stock + @amount
            WHERE ProductID = @id;";

            using var command = connection.CreateCommand();

            command.CommandText = sql;
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@id", productId);

            command.ExecuteNonQuery();
        }
    }
        
 }



