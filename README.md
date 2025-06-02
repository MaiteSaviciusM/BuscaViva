# 🔍 BuscaViva - Console Edition

**BuscaViva** é uma aplicação de console em C# desenvolvida para auxiliar equipes de resgate na priorização de buscas em áreas afetadas por desastres naturais, especialmente em contextos com falhas de energia e sem infraestrutura de comunicação.

---

## 🧩 Objetivo

Simular um sistema leve, offline e resiliente que registre alertas de sensores fictícios, organize uma fila de busca por prioridade, e mantenha um histórico de ocorrências. O sistema também conta com autenticação de usuários para controle de acesso.

---

## ⚙️ Funcionalidades

- Login obrigatório com validação de usuário e senha.
- Registro de alertas com ID do sensor e ponto de detecção.
- Preenchimento automático da data e hora do alerta.
- Organização automática da fila de busca em ordem de chegada.
- Marcação de alertas como resolvidos ou descartados.
- Exibição de histórico completo com status de cada alerta.
- Visualização da fila atual de pontos de busca.

---

## ✅ Requisitos Funcionais

1. Validar acesso de usuários antes do uso do sistema.
2. Permitir o registro de alertas com dados obrigatórios.
3. Armazenar os alertas com timestamp e status padrão "Pendente".
4. Marcar alertas como resolvidos ou descartados (sem exclusão real).
5. Exibir histórico completo de todos os alertas registrados.
6. Validar campos com tratamento de exceções para garantir integridade.

---

## 🚫 Requisitos Não Funcionais

- Funcionar totalmente offline.
- Executável leve, compatível com Windows 10+.
- Tolerante a falhas: entradas inválidas tratadas via `try-catch`.
- Interface simples, interativa e baseada em menus no console.

---

## 📜 Regras de Negócio

- Apenas usuários autenticados podem acessar o sistema.
- Todo alerta deve conter: ID numérico do sensor, ponto de detecção e timestamp.
- Alertas não são excluídos: apenas marcados como "Resolvido" ou "Descartado".
- A fila de busca só exibe alertas com status "Pendente", em ordem de chegada.

---

## 💻 Tecnologias Utilizadas

- C#
- .NET 6 ou superior (console app)
- Programação Orientada a Objetos (POO)
- Estrutura modular (Models, Services, Utils)

---

## 🧪 Simulações de Erro

Todas tratadas com `try-catch`, incluindo:

- Campos vazios
- Números inválidos para ID do sensor
- Opções inválidas em menus

---

## 📁 Estrutura de Pastas


Copiar

Editar

/BuscaViva

├── Program.cs

├── Models/

│   └── Alerta.cs

│   └── Usuario.cs

├── Services/

│   └── FilaBusca.cs

│   └── Usuario.cs

├── Utils/

│   └── Validador.cs

└── README.md



---

## 🚀 Execução

1. Clone o repositório.
2. Abra o projeto no Visual Studio.
3. Compile com o SDK do .NET 6 ou superior.
4. Execute o programa. Use um dos usuários pré-cadastrados para login.
5. Siga as opções do menu para registrar e gerenciar alertas.

---

## 👤 Usuários para Teste (nome / rm)

| Usuário       | Senha       |
|---------------|-------------|
| fabio         | 2257        |
| lucas         | 98188       |
| maite         | 98435       |
| murilo        | 99855       |

---

## 👥 Time BuscaViva

- Lucas Sobral Roxo – RM98188  
- Maitê Savicius Menezes – RM98435  
- Murilo Henrique Obinata – RM99855

--- 

## 🔗 Vídeo 

https://youtu.be/tatfkibkZn4
