namespace InventoryManagementAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; } // Clave primaria
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; } // Clave primaria
        public string Name { get; set; }
        public string Description { get; set; }

        // Lista de productos en esta categoría
        public List<Product> Products { get; set; }
    }


    public class InventoryRecord
    {
        public int InventoryRecordId { get; set; }
        public int ProductId { get; set; }
        public int QuantityChanged { get; set; }
        public DateTime DateOfChange { get; set; }
        public string ChangedBy { get; set; } // Usuario que realizó el cambi

        public Product Product { get; set; }
    }

}