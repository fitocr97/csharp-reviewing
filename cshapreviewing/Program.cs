/* //objeto y clase
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
}*/


// herencia
/*
Sale sale = new Sale(20);
var message = sale.GetInfo();

Console.WriteLine(message);

class Sale //objeto
{
    public decimal Total { get; set; }
    private string _some; //atributo privado _es para decir que es privado

    public Sale(decimal total)   //contructor
    {
        Total = total;
    }

    //protected string GetInfo() protected lo puede hacer padre e hijo por otro lado no
    public string GetInfo()
    {
        return "El total es " + Total;
    }
}

class SaleWithTax : Sale  //herencia como en el contrutor padre pide dato hay que agregarlo tambien en el hijo
{

    public decimal Tax { get; set; }

    public SaleWithTax(decimal total) : base(total)
    {
        Total = total;
    }

    public string GetInfoWithTax()
    {
        return "el impuesto es "+ "impuesto " + Tax;
    }
}*/


// sobrescribir override

SaleWithTax sale = new SaleWithTax(20,1.16m);
var message = sale.GetInfo();

Console.WriteLine(message);

class Sale 
{
    public decimal Total { get; set; }
    private string _some; 

    public Sale(decimal total)   
    {
        Total = total;
    }

    
    public virtual string GetInfo()
    {
        return "El total es " + Total;
    }
}

class SaleWithTax : Sale  
{

    public decimal Tax { get; set; }

    public SaleWithTax(decimal total, decimal tax) : base(total)
    {
        Tax = tax;
    }

    public override string GetInfo() //metodo del padre pero sobrescrito
    {
        return "el total es "+ Total + " impuesto " + Tax;
    }
}