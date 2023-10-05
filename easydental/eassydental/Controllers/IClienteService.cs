
namespace eassydental.Controllers;

    public interface IClienteService
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente GetClienteById(int id);
        void AddCliente(Cliente cliente);
        void UpdateCliente(int id, Cliente cliente);
        void DeleteCliente(int id);
    }

