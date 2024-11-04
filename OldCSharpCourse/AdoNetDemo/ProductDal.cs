using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=Etrade;integrated security=true");  // @ isareti orda yazilan herseyi string olarak kabul et demek
        public List<Product> GetAll()  // urunleri listelicez
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Selecet * from Products",_connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())   // datayi tek tek oku 
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32((reader)["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockaAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }
           
            reader.Close();
            _connection.Close();
            return products ;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            } //baglantimizi actik
        }

        public DataTable GetAll2()  // urunleri listelicez
        {

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }  //baglantimizi actik

            SqlCommand command = new SqlCommand("Selecet * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@UnitPrice,@StockAmount)",_connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StorckAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();


        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Product Set Name= @name, UnitPrice=@Unitprice,StockAmount=@StockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@StorckAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();


        }

    }
}
