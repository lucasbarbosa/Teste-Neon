# Teste-Neon

1. **Código:** Escreva um algoritmo que dada uma lista de números inteiros, retorne a soma dos menores números pares.

2. **Código:** Escreva um algoritmo que simule o funcionamento de um caixa eletrônico. Deverá receber o valor desejado de saque e ele retornará à quantidade de cédulas de cada valor. As cédulas consideradas pelo caixa eletrônico são: 100, 50, 20, 10, 5 e 2. Deve ser retornado a menor quantidade de cédulas possível para o valor do saque.

3. **Design:** Em uma pasta, são criados arquivos que indicam depósitos de dinheiro em contas de diferentes clientes da Neon. Nestes arquivos, cada linha é uma transação recebida. Em cada linha existem as seguintes informações:
- banco origem
- agência origem
- conta origem
- conta destino
- valor
- tipo de transação

Criar a aplicação que fará a leitura e interpretação destes arquivos. Esse worker vai buscar estes arquivos sempre na mesma pasta. Não há necessidade de planejar gravação em BD, apenas as regras negócio. Os arquivos a serem recebidos serão TED’s que chegaram aos clientes, portanto o campo "tipo de transação" virá preenchido com o valor "TED".  

Realizar a validação destes registros. Pode-se presumir que o arquivo sempre virá no formato correto, mas validar se as informações dessa linha batem com o que existe na Neon. Depois disso, para os registros inválidos, uma mensagem de log deve ser exibida na tela, e caso seja válido, um e-mail com os dados da transação deve ser enviado ao cliente. 