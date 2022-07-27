namespace ProjetoFormulario.Models
{
    public static class Dados
    {
        //dados da aplicação
        private static List<Cliente> listaClientes = new List<Cliente>();

        public static List<Cliente> todosOsClientes()
        {
            // todos os clientes da aplicação
            return listaClientes;   
        }
        
        public static void adicionarCliente(Cliente clienteTemp)
        {
            //buscar o id disponivel
            int id = 0;
            if(listaClientes.Count != 0)
            {
                id = listaClientes.Last<Cliente>().Id + 1;
            }

            //guardar os dados do novo cliente
            clienteTemp.Id = id;
            listaClientes.Add(clienteTemp);
        }

        public static Cliente dadosCliente(int id)
        {
            //devolve os dados do cliente selecionado
            Cliente clienteTemp = listaClientes.Where(i => i.Id == id).FirstOrDefault();
            return clienteTemp;
        }

        public static void editarCliente(Cliente cliente)
        {
            //editar os dados do cliente selecionado
            listaClientes.First<Cliente>(i => i.Id == cliente.Id).Nome = cliente.Nome;
            listaClientes.First<Cliente>(i => i.Id == cliente.Id).Telefone = cliente.Telefone;
        }

        public static void excluirCliente(int id)
        {
            //eliminar cliente da lista de clientes
            var clienteTemp = listaClientes.First<Cliente>(i => i.Id == id);
            listaClientes.Remove(clienteTemp);
        }

    }
}
