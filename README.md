# Exercicios OOP

## Heranca, Polimorfismo, Abstracao e Encapsulamento

### Problema 1: Superheroes

Neste trabalho vamos criar uma hierarquia de super heróis com diferentes superpoderes.

A hierarquia de classes vai consistir de uma classe de SuperHero abstracta, e várias outras subclasses que herdam dela.
Cada subclasse deve ter um SuperPoder único, que utiliza para derrotar os super Vilões.
Cada subclasse deve ainda ter um método `GetInfo()`, que imprime para a consola os seus atributos.

**Instruções:**

  1. Cria uma class abstrata chamada SuperHero com as seguintes propriedades:
      * Name (string)
      * Health (int)
      * Power (int)
      * Defense (int)
  2. Esta class deve conter um método abstrato UseSuperPower(), que cada subclass deve implementar à sua maneira.
  3. Esta class deve conter um método virtual GetInfo(), que cada subclass deve implementar à sua maneira.
  4. Cria as seguintes subclasses com o respectivo SuperPoder.
      * FlyingSuperhero: Can fly and has increased agility and speed
      * SuperStrengthHero: Has super strength and can lift heavy objects
  5. Cada subclass deve ter propriedades únicas que são específicas do seu superpoder.
  6. Finalmente, cria uma class `app`, que cria vários objetos do tipo superHero, e demonstra como utilizam os seus poderes.
