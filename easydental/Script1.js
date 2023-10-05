document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById('cadastroForm');
    const mensagemErro = document.getElementById('mensagemErro');
    const mensagemSucesso = document.getElementById('mensagemSucesso');
    const loading = document.getElementById('loading');

    form.addEventListener('submit', function (event) {
        event.preventDefault();

        // Oculta mensagens anteriores
        mensagemErro.textContent = '';
        mensagemSucesso.textContent = '';

        // Obtém valores do formulário
        const nome = document.getElementById('nome').value;
        const email = document.getElementById('email').value;
        const telefone = document.getElementById('telefone').value;

        // Exibe indicador de carregamento
        loading.style.display = 'block';

        fetch('https://localhost:3000', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                nome: nome,
                email: email,
                telefone: telefone
            }),
        })
            .then(response => response.json())
            .then(data => {
                // Oculta indicador de carregamento
                loading.style.display = 'none';

                if (data.status === 'success') {
                    mensagemSucesso.textContent = 'Cadastro realizado com sucesso!';
                } else {
                    mensagemErro.textContent = 'Erro ao cadastrar. Por favor, tente novamente.';
                }
            })
            .catch(error => {
                // Oculta indicador de carregamento e exibe mensagem de erro
                loading.style.display = 'none';
                mensagemErro.textContent = 'Erro ao conectar com o servidor. Por favor, tente novamente mais tarde.';
                console.error('Erro:', error);
            });
    });
});
