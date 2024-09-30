# Intro-To-Adapter-Design-Pattern
Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

<p align="center">
  <img src="https://github.com/user-attachments/assets/800ba92b-8834-45b5-ba4c-2098853f24ff" width="800">
</p>

1. The Client is a class that contains the existing business logic of the program.

2. The Client Interface describes a protocol that other classes must follow to be able to collaborate with the client code.

3. The Service is some useful class (usually 3rd-party or legacy). The client can’t use this class directly because it has an incompatible interface.

4. The Adapter is a class that’s able to work with both the client and the service: it implements the client interface, while wrapping the service object. The adapter receives calls from the client via the client interface and translates them into calls to the wrapped service object in a format it can understand.

5. The client code doesn’t get coupled to the concrete adapter class as long as it works with the adapter via the client interface. Thanks to this, you can introduce new types of adapters into the program without breaking the existing client code. This can be useful when the interface of the service class gets changed or replaced: you can just create a new adapter class without changing the client code.

Image and Description source: Dive Into DESIGN PATTERNS by Alexander Shvets <br/>
Link to the book : https://refactoring.guru/design-patterns/book
