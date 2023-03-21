namespace KantorWebAPI.Models
{
    public class EmployeeItem
    {
        private Models.EmployeeContext context;

        public int Id { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
    }
}
