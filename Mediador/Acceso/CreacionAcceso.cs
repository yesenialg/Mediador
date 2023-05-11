namespace Mediador.Acceso
{
    public class CreacionAcceso
    {
        private readonly string tipo_usuario;
        private IAcceso acceso;

        public CreacionAcceso(string tipo_usuario) 
        {
            this.tipo_usuario = tipo_usuario;
        }

        public IAcceso? Crear()
        {
            if(tipo_usuario == "regular")
            {
                acceso = new AccesoRegular();
                return acceso;
            } 
            else if(tipo_usuario == "admin")
            {
                acceso = new AccesoAdmin();
                return acceso;
            }
            else
            {
                return null;
            }
        }
    }
}
