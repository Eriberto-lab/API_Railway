# API_Railway
Simples API REST em C# para testar o Railway com Dockerfile

# README - API de Gerenciamento de Pets

Bem-vindo à API de Gerenciamento de Pets! Esta API permite que você crie, liste, obtenha detalhes e exclua informações sobre animais de estimação.

## Endpoints

### 1. Cadastrar um novo Pet
#### Endpoint base:  https://petshop.up.railway.app/pet
#### POST /Pet

Este endpoint permite que você cadastre um novo animal de estimação.

**Parâmetros:**
- Nenhum parâmetro é necessário.

**Corpo da Requisição:**
- Tipo: `application/json`
- Exemplo:
```json
{
  "id": 0,
  "name": "Nome do Pet",
  "breed": "Raça do Pet",
  "age": 0
}
```

**Respostas:**
- Código 200: Sucesso

### 2. Listar todos os Pets

#### GET /Pet

Este endpoint lista todos os animais de estimação cadastrados.

**Parâmetros:**
- Nenhum parâmetro é necessário.

**Respostas:**
- Código 200: Sucesso

### 3. Obter detalhes de um Pet específico

#### GET /Pet/{id}

Este endpoint permite que você obtenha os detalhes de um animal de estimação específico com base em seu ID.

**Parâmetros:**
- `id` (integer): ID do Pet a ser recuperado.

**Respostas:**
- Código 200: Sucesso

### 4. Excluir um Pet

#### DELETE /Pet/{id}

Este endpoint permite que você exclua um animal de estimação com base em seu ID.

**Parâmetros:**
- `id` (integer): ID do Pet a ser excluído.

**Respostas:**
- Código 200: Sucesso

## Esquema de Dados

A estrutura de dados utilizada para representar os Pets é a seguinte:

```json
Pet{
  "id": integer($int32),
  "name": string,
  "breed": string,
  "age": integer($int32)
}
```

Os campos `id`, `name`, `breed`, e `age` são utilizados para armazenar informações sobre cada animal de estimação. Os campos `name` e `breed` são opcionais e podem ser nulos.

## Exemplos de Uso

Aqui estão alguns exemplos de como você pode usar esta API:

- Para cadastrar um novo Pet, faça uma requisição POST para `/Pet` com os dados do Pet no corpo da requisição.

- Para listar todos os Pets cadastrados, faça uma requisição GET para `/Pet`.

- Para obter detalhes de um Pet específico, faça uma requisição GET para `/Pet/{id}`, onde `{id}` é o ID do Pet desejado.

- Para excluir um Pet, faça uma requisição DELETE para `/Pet/{id}`, onde `{id}` é o ID do Pet a ser excluído.


