# DIO - Trilha .NET - Explorando a linguagem C#
Este projeto implementa um sistema de reserva de hotel em C#, seguindo as especificações do desafio da trilha .NET da DIO.

## 🔍Objetivo:

O projeto visa criar um sistema que permite realizar reservas em um hotel, utilizando as classes Pessoa (hóspede), Suíte e Reserva.

## ✨Funcionalidades:

### Classe Pessoa:
Armazena informações do hóspede (nome, CPF, etc.).

### Classe Suíte:
Define a capacidade da suíte (número de hóspedes).

### Classe Reserva:

- Realiza a reserva de uma suíte para um hóspede.
- Calcula o valor da diária com desconto para reservas acima de 10 dias.
- Valida a capacidade da suíte em relação à quantidade de hóspedes.

### Regras e Validações:

- Impede reservas de suítes com capacidade menor que a quantidade de hóspedes.
- Calcula o valor da diária com base nos dias reservados e no valor da diária da suíte.
- Aplica desconto de 10% na diária para reservas de 10 dias ou mais.

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

