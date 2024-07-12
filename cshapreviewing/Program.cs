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
}
*/


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
}
*/


// sobrescribir override
/*
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
*/


//sobrecarga
/*
using System.Security.Principal;

Sale sale = new Sale(20);
sale.GetInfo();

Console.WriteLine(sale.GetInfo());
Console.WriteLine(sale.GetInfo("hola"));

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

    public virtual string GetInfo(string hola) //sobrecarga
    {
        return "El total es " + Total + " " +hola;
    }
}
*/


//interface
/*
Send send = new Send();
send.Save();

Sale sale = new Sale();
sale.Save();


interface ISale
{
    decimal Total { get; set; }
}

interface ISave
{
    public void Save()
    {
        
    }
}

class Sale : ISale, ISave //implementar interface obliga a poner total y el metodo
{
    public decimal Total { get; set; } //interfaz agrega atributo

    public void Save()  //interfaz obliga agregar el metodo
    {
        Console.WriteLine("guardado");
    }
}

class Send : ISave
{
    public void Save()  //interfaz obliga agregar el metodo
    {
        Console.WriteLine("Enviado");
    }
}
*/

/*
//generics
var numbers = new MyList<int>(5);
var names = new MyList<string>(5);
var beers = new MyList<Beer>(3);

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Add(6);
Console.WriteLine(numbers.GetContent());

names.Add("juan");
names.Add("pedro");
names.Add("karla");
names.Add("kairo");
names.Add("julia");
names.Add("raul");
Console.WriteLine(names.GetContent());

beers.Add(new Beer() { Name = "imperial", Price = 1 });
beers.Add(new Beer() { Name = "pilsen", Price = 2 });
beers.Add(new Beer() { Name = "babaria", Price = 3 });
Console.WriteLine(beers.GetContent());

public class MyList<T>  //T tipo de dato que desconocemos
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit) 
    {
        _limit = limit;
        _list = new List<T>(); //inicializar el elemento
    }


    public void Add(T item)
    {
        if (_list.Count < _limit) 
        {
            _list.Add(item);
        }
    }

    public string GetContent()
    {
        string content = "";

        foreach (var item in _list)
        {
            content += item + " , ";
        }

        return content;
    }
}

public class Beer
{
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return Name.ToString()  + " =" + Price.ToString(); 
    }

}
*/

/*
//serelizacion 

using System.Text.Json; //libreria

People pedro = new People()
{
    Name = "Pedro",
    Age = 11,
};

People juan = new People();

juan.Age = 10;
juan.Name = "Juan";

string json = JsonSerializer.Serialize(juan);
Console.WriteLine(json);

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}
*/


/*
//deserilazacion
using System.Text.Json; //libreria

People pedro = new People()
{
    Name = "Pedro",
    Age = 11,
};

string myJson = @"{
    ""Name"":""Fito"",
    ""Age"":26    
}";


People? fito  = JsonSerializer.Deserialize<People>(myJson);

Console.WriteLine(fito?.Name + ", " + fito?.Age);  //? puede ser nulo

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}
*/

/*
//programacion funcional
//funcion pura

Console.WriteLine(Sub(2,1));

int Sub(int a, int b)
{
    return a - b;
}


//ejemplo de uppercase beer

Beer beer = new Beer() { Name = "Imperial"};

Console.WriteLine(beer.Name);
Console.WriteLine(ToUpper(beer).Name);

Beer ToUpper(Beer beer)
{
    Beer beer2 = new Beer() //al crear otra instancia que se modifique no se modifica la original
    {
        Name = beer.Name.ToUpper(),
    };
    return beer2;
}

class Beer
{
    public string Name;
}
*/

/*
//guardar funcion en una variable funcion de primera clase
var show = Show;

show("hola");

Some(show, "hola que tal");

void Show(string message)
{
    Console.WriteLine(message);
}


//action recive elementos pero no retorna nada

void Some(Action<string> fn, string message) //
{
    Console.WriteLine("antes");
    fn(message);
    Console.WriteLine("despues");
}


//Func si retorna algo

var showtwo = ShowTwo;

SomeTwo(showtwo, "hola que tal dos");

string ShowTwo(string message)
{
    return message.ToUpper();
}
void SomeTwo(Func<string, string> fn, string message) //string entrada, string salida
{
    Console.WriteLine("antes");
    Console.WriteLine(fn(message));
    Console.WriteLine("despues");
}
*/

/*
//Lambda  arrow functions

Func<int, int, int> sub = (int a, int b) => a - b;

Func<int, int, int> sub2 = ( a, b) => a - b;

Func<int, int> mul = (int a) => a * 2;

Func<int, int> mul2 =  a => a * 2;


Func<int, int> some = a => {   //agregar mas lineas en la funcion se abren parentesis
    a = a * 4;
    return a;
};


// pasar lambda por parametro

Some((a, b) => a + b, 5);

void Some(Func<int, int, int> fn, int number)
{
    var result = fn(number, number);
}*/


//LINQ
//hacer sql en c#

var names = new List<string>() //origen datos
{
    "Fito", "Tati", "Ange", "Antho", "Rodo"
};


var namesResult = from name in names orderby name select name; //consulta

var namesResultLength = from name in names where name.Length > 2 && name.Length < 5 select name; //consulta

foreach (var name in namesResult)
{
    Console.WriteLine(name);
}


foreach (var name in namesResultLength)
{
    Console.WriteLine(name);
}