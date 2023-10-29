using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Invoice;
class Customer {
    private int id;
    private string name;
    private int discount;

    public Customer(int id, string name, int discount) {
        this.id = id;
        this.name = name;
        this.discount = discount;
    }
    public int GetId() { return id; }
    public string GetName() { return name; }
    public int GetDiscount() { return discount; }
    public void SetDiscount(int discount) { this.discount = discount; }
    public override string ToString() {
        return $"Name:{GetName()} ID:{GetId()} Discount:{GetDiscount()}";
    }
}
class Invoice {
    private int id;
    private Customer customer;
    private double amount;

    public Invoice(int id, Customer customer, double amount) {
        this.id = id;
        this.customer = customer;
        this.amount = amount;
    }
    public int GetId() { return id; }
    public Customer GetCustomer() { return customer; }
    public void SetCustomer(Customer customer) { this.customer = customer; }
    public double GetAmount() { return amount; }
    public void SetAmount(double amount) { this.amount = amount; }
    public int GetCustomerId() { return id; }
    public string GetCustomerName() { return customer.GetName(); }
    public int GetCustomerDiscount() { return customer.GetDiscount(); }
    public double GetAmountAfterDiscount() { return amount - (amount * customer.GetDiscount() / 100); }
    public override string ToString() {
        return $"Invoice [id={GetId()}, customer={customer.GetName()}({customer.GetId()})({customer.GetDiscount()}%), amount={GetAmount()}]";
    }
}
class Program {
    static void Main(string[] args) {

        Customer c1 = new Customer(0, "Jan Novák", 20);
        Customer c2 = new Customer(1, "Petr Novák", 10);
        Invoice i1 = new Invoice(0, c1, 200);
        Invoice i2 = new Invoice(1, c2, 500);

        Console.WriteLine(c1.ToString());
        Console.WriteLine(c2.ToString());
        Console.WriteLine(i1.ToString());
        Console.WriteLine(i2.ToString());

        c2.SetDiscount(100);
        Console.WriteLine("--Sleva 100%--");
        Console.WriteLine(i2.GetAmountAfterDiscount());
    }
}
