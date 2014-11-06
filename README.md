StrategyPatternExample
======================

StrategyPatternExample

Points to note:

- Encapsulate a family of related algorithms
- Let the algorithm vary evolve separate from the class using it
- Allow a class to maintain a single purpose
- Separate the calculation from the delivery of its results
- 

Applicability

- Switch statements are a RED flag
- Adding a new calculation will cause a class file to be modified
- 

This implementation will do the following:
- Create classes for each calculation (strategies)
- Use a common interface for each Strategy
- 


