# OOP Zoo

This repo is an excercise in OOP with classes and interfaces. The goal is to create an architected structure of classifications and permissions in order to add animals to a proof-of-concept virtual zoo effectively.

### UML

![UML Diagram](https://i.imgur.com/TFpocKD.png)

As seen above, all animals are defined around an abstract Animal class. They are further defined through additional layers (only one in the current version) of definition, until a specific enough class is defined as a concrete class.

### Current functionality

- `Animal.Eat()` - Used to simulate the animal eating food. Currently all animals can eat. This method is overriden at each concrete class to reflect individual eating behaviors and eventually diets.
- `ICanSwim.Swim()` - Used to simulate the animal swimming in water. Currently the ICanSwim interface is applied to the Fish and Platypus classes.
- `ICanHunt.Hunt(IHuntable prey)` - Used to simulate a predator hunting and killing a prey. Currently the ICanHunt interface is applied to the Bear and Shark classes, and the IHuntable is applied to everything else.

### OOP Principles

#### Encapsulation

*Encapsulation is the technique of using class-level public methods to return otherwise private properties about an object. This prevents property values from being altered except through intentionally-built methods.*

I have not yet implemented encapsulation into this project. In future updates I will be adding methods to each class to return properties which should be given permissions-based access.

#### Abstraction

*Abstract classes, from which no object can be instantiated, are used to more efficiently define and group concrete classes and the objects created through them.*

This project uses abstract classes to define behavior and characteristics of broader groups of animals. For example, the ability to swim is defined at the level of the Fish class, rather than at each individual fish' class.

#### Inheritance

*Inheritance is the functionality of derived classes following and expanding on their base' definition.*

In this app, every class except Animal inherits some functionality or shape from its base class, its interfaces, or both.

#### Polymorphism

*Polymorphism describes the behavior of a subclass acting as its base. If a type of X is required as a parameter, a class Y derived from X may be used as well.*

This app uses polymorphism in several places. For example, the monkey's Pet(Mammal) requires an argument of type Mammal. However, Mammal is an abstract and therefore we cannot have objects of that type. Thanks to polymorphism, any Monkey, Bear, or Platypus (derived classes of Mammal) may be used as an argument instead.

### Interfaces

An interface is used to define behavior and further properties of a class. It provides required functionality in a more flexible manner than a base class, since any number of interfaces can be applied to any class at any level.

The interfaces used in this project are:

- `ICanSwim` - Defines animals that can swim. Previously, I had applied swimming functionality to the Fish class, but made it an interface when I realized that many Mammals can swim as well.
- `ICanHunt` - Defines animals that can hunt other animals. This allows for the `Hunt()` function to be applied to any predators.
- `IHuntable` - Defines animals that can be hunted. This is used as a parameter type for `Hunt()`, establishing a food chain and preventing a shark from hunting a bear or a monkey.