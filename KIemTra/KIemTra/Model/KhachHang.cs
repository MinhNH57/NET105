using Microsoft.AspNetCore.SignalR;

namespace KIemTra.Model
{
    public class KhachHang
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public string DiaChi { get; set; }
    }
}
