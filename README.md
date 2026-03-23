# JotaSystem.Sdk.Data

Biblioteca de dados estáticos e referências embarcadas da **Jota System** para aplicações .NET.

## Descrição

O `JotaSystem.Sdk.Data` expõe coleções JSON incorporadas ao assembly e acessadas de forma tipada.

Hoje o pacote contém:

- Dados de bancos do Brasil.
- Dados de estados do Brasil.
- Dados de cidades do Brasil.
- Dados de grupos de produtos do Brasil.
- Dados de países.

## Como funciona

Os arquivos JSON ficam embarcados como `EmbeddedResource` e são carregados por serviços específicos, com cache em memória por tipo de coleção.

Os principais serviços públicos hoje são:

- `BrazilBankData`
- `BrazilStateData`
- `BrazilCityData`
- `BrazilProductGroupData`
- `CountryData`

## Perfil do pacote

Este SDK não depende de banco de dados nem de APIs externas para entregar os dados. O objetivo é oferecer acesso rápido, tipado e previsível a catálogos de referência usados em outros sistemas da Jota System.
