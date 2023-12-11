public class LineaCompra {
private Producto producto;
private int cantidad;
private int precio;

public LineaCompra(Producto producto, int cantidad, int precio){
    this.producto = producto;
    this.cantidad = cantidad;
    this.precio = precio;
}

public Producto producto1{
    get{return producto;}
    set{producto = value;}
}
public int Cantidad{
    get{return cantidad;}
    set{cantidad = value;}
}
public int Precio{
    get{return precio;}
    set{precio = value;}
}
public void incrementa() {
cantidad++;
precio += producto.getPrecio();
}

}