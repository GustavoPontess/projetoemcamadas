namespace Projeto3Camadas.Code.DTO
{
    class SorveteDTO
    {
        //Propriedades privadas
        private int _id;
        private string _sabor;
        private string _marca;

        public int Id { get => _id; set => _id = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public string Marca { get => _marca; set => _marca = value; }
    }
}
