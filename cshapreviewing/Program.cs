
Sale sale = new Sale(20);
var message = sale.GetInfo();

Console.WriteLine(message);

class Sale //objeto
{
    public decimal Total {  get; set; }
    private string _some; //atributo privado _es para decir que es privado

    public Sale(decimal total)   //contructor
    {
        Total = total;
    }

    public string GetInfo() 
    {
        return "El total es " + Total;
    }
}