namespace POO_heranca.Classe
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string incricaoEstadual;

        public bool ValidarCNPJ(string documento)
        {
            if(documento != "" && documento.Length > 10){
                return true;
            }
            return false;
        }
    }
}