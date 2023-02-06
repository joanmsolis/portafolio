namespace portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenerGuid = Guid.NewGuid();

        }
        public Guid ObtenerGuid { get; private set; }
    }

    public class ServicioDeLimitado
    { 
        public ServicioDeLimitado()
        {
            ObtenerGuid = Guid.NewGuid();

        }
        public Guid ObtenerGuid { get; private set; }
    }
    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            ObtenerGuid = Guid.NewGuid();

        }
        public Guid ObtenerGuid { get; private set; }
    }
}
