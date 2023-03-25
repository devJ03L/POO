namespace POO.Colecciones;
public class MiPila<T>
{
    private static int capacidadInicial = 5;
    private MiColeccion<T> coll = new MiColeccion<T>(capacidadInicial);
    public void apilar(T elm) => coll.insertar(elm, 0);
    public T desapilar() => coll.eliminar(0);
}