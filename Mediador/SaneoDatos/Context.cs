namespace Mediador.SaneoDatos
{
    public class Context
    {
        public IValidador validador;

        public void setValidador(string tipoValidador) 
        {
            if (tipoValidador == "codigo")
            {
                this.validador = new ValidatorCodigo();
            }
            else if (tipoValidador == "string")
            {
                this.validador = new ValidatorString();
            }
        }

        public bool validarData(string datoValidar) 
        {
            return validador.validar(datoValidar);
        }
    }
}
