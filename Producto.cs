public class Producto {
private String nombre;
private int precio;

public Producto(string nombre, int precio){
    this.nombre = nombre;
    this.precio = precio;
}
public String Nombre{
    get{return nombre;}
    set{nombre = value;}
}
public int Precio{
    get{return precio;}
    set{precio = value;}
}

    internal int getPrecio()
    {
        throw new NotImplementedException();
    }
}
