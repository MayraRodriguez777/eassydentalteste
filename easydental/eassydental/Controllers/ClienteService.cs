

namespace eassydental.Controllers;


    public class ClienteService : IClienteService
{
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clienteRepository.GetAllClientes();
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteRepository.GetClienteById(id);
        }

        public void AddCliente(Cliente cliente)
        {
            _clienteRepository.AddCliente(cliente);
        }

        public void UpdateCliente(int id, Cliente cliente)
        {
            var existingCliente = _clienteRepository.GetClienteById(id);
            if (existingCliente != null)
            {
                existingCliente.Nome = cliente.Nome;
                existingCliente.Email = cliente.Email;
                existingCliente.Telefone = cliente.Telefone;
                _clienteRepository.UpdateCliente(existingCliente);
            }
        }

        public void DeleteCliente(int id)
        {
            _clienteRepository.DeleteCliente(id);
        }
    }
