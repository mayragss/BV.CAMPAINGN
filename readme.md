# EventCampaign API

## Visão Geral

A API EventCampaign é um sistema de gestão de campanhas de eventos que permite criar, listar, atualizar e excluir campanhas. 

## Endpoints

### CRUD de Campanhas

#### Listar todas as campanhas

- **Endpoint**: `GET /event-campaigns`
- **Descrição**: Retorna todas as campanhas de eventos.

#### Criar uma campanha

- **Endpoint**: `POST /event-campaigns`
- **Descrição**: Cria uma nova campanha de evento.

#### Atualizar uma campanha

- **Endpoint**: `PUT /event-campaigns/{id}`
- **Descrição**: Atualizauma campanha de evento. 

#### Excluir uma campanha

- **Endpoint**: `DELETE /event-campaigns/{id}`
- **Descrição**: Exclui uma campanha de evento.

### Consulta de Eventos 

- **Endpoint**: `GET /event-campaigns/`
- **Descrição**: Consulta as campanhas cadastradas.

#### Consultar eventos por filtro (sugestão de rota) 

- **Endpoint**: `POST /event-campaigns/filter`
- **Descrição**: Consulta eventos de forma genérica com base em um filtro específico.

## Status das Campanhas

As campanhas de eventos podem ter os seguintes status:

- **Criada**: A campanha foi criada, mas ainda não passou por revisão ou publicação.

- **Em Revisão**: A campanha está passando por revisão antes de ser publicada.

- **Publicada**: A campanha está ativa e disponível ao público.

- **Cancelada**: A campanha foi cancelada e não está mais ativa.

- **Realizada/Terminada**: A campanha foi realizada com sucesso e está encerrada.


## Informações Adicionais

- A campanha de eventos será criada sempre como inativa. A propriedade de status será adicionada em favor de uma tabela para controle de status para uma melhor gestão da entidade.

- Pensando em um fluxo escalável, a arquitetura escolhida permite a criação de outras entidades segregadas para gerenciar eventos atrelados às campanhas. Isso oferece flexibilidade e escalabilidade para a gestão de eventos.


## Exemplo de Uso

- A API inclui documentação Swagger para facilitar o uso e a exploração dos endpoints.



