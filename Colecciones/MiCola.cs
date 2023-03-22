namespace POO.Colecciones
{
    public class MiCola<T>
    {
        private static int capacidadInicial = 5;
        private MiColeccion<T> coll = new MiColeccion<T>(capacidadInicial);
        public void encolar(T elm) => coll.agregar(elm);
        public T desencolar() => coll.eliminar(0);
    }
}