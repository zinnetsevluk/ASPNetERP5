using RE.Models.Entities;

namespace RE.BLL.Repository
{
    //bunları kendimiz ekledik. ara tablo(birden fazla primary key olan tabloya nasıl sorgu atıcaz(Params ile)). getbyıd yi nasıl çalıştırcaz.
    public class ProductRepo : RepositoryBase<Product, int> { }
    public class CategoryRepo : RepositoryBase<Category, int> { }
    public class EmployeeRepo : RepositoryBase<Employee, int> { }
    public class ShipperRepo : RepositoryBase<Shipper, int> { }
    public class SupplierRepo : RepositoryBase<Supplier, int> { }
    public class OrderDetailRepo : RepositoryBase<Order_Detail, object> { }
    public class CustomerRepo : RepositoryBase<Customer, string> { }
}
