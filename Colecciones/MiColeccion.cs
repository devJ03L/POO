namespace POO.Colecciones
{
    public class MiColeccion<T>
    {
        private Object[] datos;
        private int len = 0;

        public MiColeccion(int capacidadInicial) =>
            datos = new Object[capacidadInicial];
        public T obtener(int i) => (T)datos[i];
        public int cantidad() => len;        
        public void insertar(T elm, int i)
        {
            if (len == datos.Length)
            {
                Object[]? aux = datos;
                datos = new Object[datos.Length * 2];
                for (int j = 0; j < len; j++)
                    datos[j] = aux[j];
                aux = null;
            }
            for (int j = len - 1; j >= i; j--)
                datos[j + 1] = datos[j];

            datos[i] = elm;
            len++;
        }
        public int buscar(T elm)
        {
            int i = 0;
            for (; i < len && !datos[i].Equals(elm); i++) { }
            return i < len ? i : -1;
        }
        public void agregar(T elm) => insertar(elm, len);
        public T eliminar(int i)
        {
            Object aux = datos[i];
            for (int j = i; j < len - 1; j++)
                datos[j] = datos[j + 1];
            len--;

            return (T)aux;
        }
    }
}