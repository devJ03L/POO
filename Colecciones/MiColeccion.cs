namespace POO.Colecciones
{
    public class MiColeccion
    {
        private Object[]? datos;
        private int len = 0;

        public MiColeccion(int capacidadInicial) =>
            datos = new Object[capacidadInicial];
        
    }
}