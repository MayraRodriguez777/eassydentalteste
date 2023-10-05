
namespace eassydental.Controllers;

        public interface IClienteRepository
        {
            IEnumerable<Cliente> GetAllClientes();
            Cliente GetClienteById(int id);
            void AddCliente(Cliente cliente);
            void UpdateCliente(Cliente cliente);
            void DeleteCliente(int id);
        }


